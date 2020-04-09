﻿using Microsoft.AspNetCore.Mvc;
using WareHouse.Core.Data;
using WareHouse.Entity;
using WareHouse.Service.Interface;

namespace WareHouse.Web.Controllers
{
    public class RegionController : BaseController
    {
        private readonly IRegionService _regionService;

        public RegionController(IRegionService regionService)
        {
            _regionService = regionService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return Json(_regionService.GetAll());
        }

        public IActionResult GetPages(IPager pager)
        {
            return Json(_regionService.GetPageResult(pager));
        }

        public IAjaxResult Find(int id)
        {
            return Success(_regionService.Find(id));
        }

        public IActionResult AddRegion(Region region)
        {
            if (_regionService.Add(region))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return Json("添加失败");
            }
        }

        public IAjaxResult DeleteRegion(int id)
        {
            if (_regionService.Delete(id))
            {
                return Success("删除成功");
            }
            else
            {
                return Error("删除失败");
            }
        }

        public IActionResult UpdateRegion(Region region)
        {
            if (_regionService.Update(region))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return Json("修改失败");
            }
        }
    }
}