#pragma checksum "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Join\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5388b0fd59f4df6f6448aa155c1759599130fda5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Join_Update), @"mvc.1.0.view", @"/Views/Join/Update.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5388b0fd59f4df6f6448aa155c1759599130fda5", @"/Views/Join/Update.cshtml")]
    public class Views_Join_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Join\Update.cshtml"
  
    ViewData["Title"] = "Update";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<form");
            BeginWriteAttribute("action", " action=\"", 96, "\"", 132, 1);
#nullable restore
#line 6 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Join\Update.cshtml"
WriteAttributeValue("", 105, Url.Action("UpdateDetail"), 105, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" method=\"post\">\r\n    <input type=\"hidden\" name=\"goodsId\" id=\"goodsId\"");
            BeginWriteAttribute("value", " value=\"", 202, "\"", 210, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"goodsStorageId\" id=\"goodsStorageId\"");
            BeginWriteAttribute("value", " value=\"", 282, "\"", 290, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div class=\"form-group\">\r\n        <label for=\"goodsName\">名称</label>\r\n        <input class=\"form-control\" type=\"text\" id=\"goodsName\" name=\"goodsName\" placeholder=\"请输入货物名称..\"");
            BeginWriteAttribute("required", " required=\"", 472, "\"", 483, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"weight\">重量</label>\r\n        <input class=\"form-control\" type=\"text\" id=\"weight\" name=\"weight\" onkeyup=\"checkInputIntFloat(this);\" placeholder=\"请输入货物重量..\"");
            BeginWriteAttribute("required", " required=\"", 702, "\"", 713, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    </div>
    <div class=""form-group"">
        <label for=""typeId"">用户</label>
        <select class=""form-control"" id=""userId"" name=""userId"" size=""1"">
            <option value=""0"">请选择所属用户</option>
        </select>
    </div>
    <div class=""form-group"">
        <label for=""typeId"">种类</label>
        <select class=""form-control"" id=""typeId"" name=""typeId"" size=""1"">
            <option value=""0"">请选择种类</option>
        </select>
    </div>
    <div class=""form-group"">
        <label for=""goodsRemarks"">备注</label>
        <input class=""form-control"" type=""text"" id=""goodsRemarks"" name=""goodsRemarks"" placeholder=""请输入货物备注..""");
            BeginWriteAttribute("required", " required=\"", 1358, "\"", 1369, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    </div>
    <div class=""form-group"">
        <label for=""typeId"">仓库</label>
        <select class=""form-control"" id=""storageId"" name=""storageId"" size=""1"" onchange=""getRegion(this.value)"">
            <option value=""0"">请选择仓库</option>
        </select>
    </div>
    <div class=""form-group"">
        <label for=""typeId"">区域</label>
        <select class=""form-control"" id=""regionId"" name=""regionId"" size=""1"">
            <option value=""0"">请选择区域</option>
        </select>
    </div>
    <div class=""form-group"">
        <button class=""btn btn-primary"" type=""submit"">修改</button>
    </div>
</form>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function checkInputIntFloat(oInput) {
            if ('' !== oInput.value.replace(/\d{1,}\.{0,1}\d{0,}/, '')) {
                oInput.value = oInput.value.match(/\d{1,}\.{0,1}\d{0,}/) == null ? '' : oInput.value.match(/\d{1,}\.{0,1}\d{0,}/);
            }
        }
        $.ajax({
            url: '/Join/GetJoinModel',
            data: {},
            type: 'get',
            success: function (res) {
                //console.log(res);
                var html = """";
                for (var i = 0; i < res.data.goodsTypeList.length; i++) {
                    html += ""<option value='"" + res.data.goodsTypeList[i].id + ""'>"" + res.data.goodsTypeList[i].name + ""</option>"";
                }
                $(""#typeId"").append(html);

                html = """";
                for (var i = 0; i < res.data.storageList.length; i++) {
                    html += ""<option value='"" + res.data.storageList[i].id + ""'>"" + res.data.storageList[i].name + ""</option>"";
          ");
                WriteLiteral(@"      }
                $(""#storageId"").append(html);

                html = """";
                for (var i = 0; i < res.data.usersList.length; i++) {
                    html += ""<option value='"" + res.data.usersList[i].id + ""'>"" + res.data.usersList[i].name + ""</option>"";
                }
                $(""#userId"").append(html);

                $.ajax({
                    url: ""/Join/GetDetail"",
                    data: {
                        id: GetId()
                    },
                    type: ""get"",
                    success: function (res) {
                        console.log(res);
                        $(""#goodsId"").val(res.data.goodsId);
                        $(""#goodsStorageId"").val(res.data.goodsStorageId);
                        $(""#goodsName"").val(res.data.goodsName);
                        $(""#weight"").val(res.data.weight);
                        $(""#userId"").val(res.data.userId);
                        $(""#typeId"").val(res.data.typeId);
        ");
                WriteLiteral(@"                $(""#goodsRemarks"").val(res.data.goodsRemarks);
                        $(""#storageId"").val(res.data.storageId);
                        var regionId = res.data.regionId;
                        $.ajax({
                            url: '/Join/GetRegion',
                            data: {
                                id: res.data.storageId
                            },
                            type: 'get',
                            success: function (res) {

                                if (res.data.region.length === 0) {
                                    $(""#regionId"").empty();
                                    $(""#regionId"").append(""<option value='0'>该仓库没有划分区域，请前往仓库进行设置</option>"");
                                } else {
                                    var html = ""<option value='0'>请选择区域</option>"";
                                    for (var i = 0; i < res.data.region.length; i++) {
                                        html += ""<option value='"" + re");
                WriteLiteral(@"s.data.region[i].id + ""'>"" + res.data.region[i].name + ""</option>"";
                                    }
                                    $(""#regionId"").empty();
                                    $(""#regionId"").append(html);
                                    $(""#regionId"").val(regionId);
                                }

                            }
                        });
                    }
                });

            }
        });
        function getRegion(id) {
            $.ajax({
                url: '/Join/GetRegion',
                data: {
                    id: id
                },
                type: 'get',
                success: function (res) {

                    if (res.data.region.length === 0) {
                        $(""#regionId"").empty();
                        $(""#regionId"").append(""<option value='0'>该仓库没有划分区域，请前往仓库进行设置</option>"");
                    } else {
                        var html = ""<option value='0'>请选择区域</option>"";
");
                WriteLiteral(@"                        for (var i = 0; i < res.data.region.length; i++) {
                            html += ""<option value='"" + res.data.region[i].id + ""'>"" + res.data.region[i].name + ""</option>"";
                        }
                        $(""#regionId"").empty();
                        $(""#regionId"").append(html);
                    }

                }
            });
        }
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591