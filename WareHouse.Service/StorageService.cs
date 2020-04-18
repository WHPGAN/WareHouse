﻿/*
 * Copyright (c) 2020
 * All rights reserved.
 *
 * 文件名称：StorageService.cs
 /* 摘   要：
 *
 * 当前版本：1.0
 * 作   者：SoulCrazy
 * 创建日期：2020-03-25 18:03:07
 */

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using WareHouse.Core.Data;
using WareHouse.Dto;
using WareHouse.Entity;
using WareHouse.Service.Interface;

namespace WareHouse.Service
{
    public class StorageService : IStorageService
    {
        private readonly IRepository<Storage, int> _repository;
        private readonly IRepository<Region, int> _regionRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRegionService _regionService;
        private readonly IStorageRegionService _storageRegionService;

        public StorageService(IServiceProvider serviceProvider)
        {
            _repository = serviceProvider.GetRequiredService<IRepository<Storage, int>>();
            _unitOfWork = serviceProvider.GetRequiredService<IUnitOfWork>();
            _regionService = serviceProvider.GetRequiredService<IRegionService>();
            _regionRepository = serviceProvider.GetRequiredService<IRepository<Region, int>>();
            _storageRegionService = serviceProvider.GetRequiredService<IStorageRegionService>();
        }

        public string Get()
        {
            return Guid.NewGuid().ToString();
        }

        public List<Storage> GetAll()
        {
            return _repository.Select(c => true);
        }

        public IPageResult<Storage> GetPageResult(IPager pager)
        {
            return _repository.Select(pager, c => true, c => c.Id);
        }

        public Storage Find(int id)
        {
            return _repository.Find(id);
        }

        public int Add(Storage storage)
        {
            if (string.IsNullOrEmpty(storage.Name) || string.IsNullOrEmpty(storage.Address))
            {
                return 3;
            }
            if (_repository.Select(c => c.Name == storage.Name).Count == 1)
            {
                return 2;
            }
            _repository.Add(storage);
            return _unitOfWork.Commit() > 0 ? 0 : 1;
        }

        public bool Delete(int id)
        {
            Storage storage = Find(id);
            if (storage == null)
            {
                return false;
            }

            List<StorageRegion> storageRegions = _storageRegionService.GetAll(c => c.StorageId == id);
            foreach (var storageRegion in storageRegions)
            {
                _storageRegionService.Delete(storageRegion);
            }

            _repository.Delete(storage);
            return _unitOfWork.Commit() > 0;
        }

        public int Update(Storage storage)
        {
            if (storage.Id <= 0)
            {
                return 4;
            }

            if (_repository.Select(c => c.Name == storage.Name).Count > 0)
            {
                return 3;
            }

            Storage tempStorage = _repository.Find(storage.Id);
            if (tempStorage == null)
            {
                return 2;
            }

            tempStorage.Name = storage.Name;
            tempStorage.Address = storage.Address;
            _repository.Update(tempStorage);
            return _unitOfWork.Commit() > 0 ? 0 : 1;
        }

        public bool AddNewRegion(GetRegionDto getRegionDto)
        {
            if (_regionService.Find(c => c.Name == getRegionDto.RegionName) == null)
            {
                if (_regionService.Add(getRegionDto.RegionName) != 0)
                {
                    return false;
                }
            }

            Region region = _regionService.Find(c => c.Name == getRegionDto.RegionName);
            StorageRegion storageRegion = new StorageRegion()
            {
                RegionId = region.Id,
                StorageId = getRegionDto.StorageId,
                Capacity = getRegionDto.RegionCapacity
            };
            return _storageRegionService.Add(storageRegion);
        }
    }
}