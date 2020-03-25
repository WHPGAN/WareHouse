#pragma checksum "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Goods\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f8d135f0b7ecaa2ef919b3f8cd89c0833fdb963"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Goods_Index), @"mvc.1.0.view", @"/Views/Goods/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f8d135f0b7ecaa2ef919b3f8cd89c0833fdb963", @"/Views/Goods/Index.cshtml")]
    public class Views_Goods_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WareHouse.Entity.Goods>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Goods\Index.cshtml"
  
    ViewData["Title"] = "货物管理";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <button id=\"add-btn\" class=\"btn btn-cyan\">添加货物</button>\r\n    <table class=\"table table-striped table-hover\" id=\"goods-table\">\r\n    </table>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $('#goods-table').bootstrapTable({
            method: 'get',
            url: ""/Goods/GetAll"", //请求路径
            striped: true, //是否显示行间隔色
            pageNumber: 1, //初始化加载第一页
            pagination: true, //是否分页
            sidePagination: 'client', //server:服务器端分页|client：前端分页
            pageSize: 5, //单页记录数
            pageList: [5, 10, 20, 30], //可选择单页记录数
            showRefresh: true, //刷新按钮
            columns: [
                {
                    field: ""id"",
                    title: ""主键""
                }, {
                    field: ""name"",
                    title: ""货物名称""
                }, {
                    field: ""typeId"",
                    title: ""所属种类""
                }, {
                    field: ""weight"",
                    title: ""货物重量""
                }, {
                    field: ""userId"",
                    title: ""用户编号""
                }, {
                    field: ""remarks"",
                    title: ""备注""
     ");
                WriteLiteral(@"           }, {
                    field: ""id"",
                    title: ""操作"",
                    formatter: function(value, row, index) {
                        var html = '';
                        html += ""<button class='btn btn-default' onclick='edit("" + value + "")'>修改</button>"";
                        html += ""<button class='btn btn-default' onclick='del("" + value + "")'>删除</button>"";
                        return html;
                    }
                }
            ]
        });

        $(""#add-btn"").click(function () {
            window.location.href = """);
#nullable restore
#line 60 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Goods\Index.cshtml"
                               Write(Url.Action("Create"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n        });\r\n        function edit(id) {\r\n            window.location.href = \"");
#nullable restore
#line 63 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Goods\Index.cshtml"
                               Write(Url.Action("Update"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?id=""+id;
        }
        function del(id) {
            $.ajax({
                url: '/Goods/DeleteGoods',
                data: {
                    id:id
                },
                type: 'post',
                success: function() {
                    window.location.href = """);
#nullable restore
#line 73 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Goods\Index.cshtml"
                                       Write(Url.Action("Index"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
                },
                error: function(res) {
                    alert(res);
                }
            });
        }

        function GetRole() {
            $.ajax({
                url: '/Role/GetPages',
                data: {},
                type: 'get',
                success: function (res) {
                    console.log(res);
                }
            });
        }
    </script>

    <script>
        $(""#page-btn"").click(function () {
            $.ajax({
                url: '/Goods/GetAll',
                data: {},
                type: 'get',
                success: function (res) {
                    console.log(res);
                }
            });
        });

        $(""#select-btn"").click(function () {
            $.ajax({
                url: '/Goods/GetPages',
                data: {},
                type: 'get',
                success: function (res) {
                    console.log(res);
                }
       ");
                WriteLiteral("     });\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WareHouse.Entity.Goods>> Html { get; private set; }
    }
}
#pragma warning restore 1591