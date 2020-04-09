#pragma checksum "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Goods\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f384c5fa79aad8ecf2370458a21b31e877b8a963"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Goods_Create), @"mvc.1.0.view", @"/Views/Goods/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f384c5fa79aad8ecf2370458a21b31e877b8a963", @"/Views/Goods/Create.cshtml")]
    public class Views_Goods_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WareHouse.Entity.Goods>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Goods\Create.cshtml"
  
    ViewData["Title"] = "添加货物";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<form");
            BeginWriteAttribute("action", " action=\"", 125, "\"", 157, 1);
#nullable restore
#line 7 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Goods\Create.cshtml"
WriteAttributeValue("", 134, Url.Action("AddGoods"), 134, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" method=\"post\">\r\n    <div class=\"form-group\">\r\n        <label for=\"name\">名称</label>\r\n        <input class=\"form-control\" type=\"text\" id=\"name\" name=\"name\" placeholder=\"请输入货物名称..\"");
            BeginWriteAttribute("required", " required=\"", 336, "\"", 347, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"weight\">重量</label>\r\n        <input class=\"form-control\" type=\"text\" onkeyup=\"checkInputIntFloat(this)\" id=\"weight\" name=\"weight\" placeholder=\"请输入货物重量..\"");
            BeginWriteAttribute("required", " required=\"", 565, "\"", 576, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    </div>
    <div class=""form-group"">
        <label for=""typeId"">种类</label>
        <select class=""form-control"" id=""typeId"" name=""typeId"" size=""1"">
            <option value=""0"">请选择所属种类</option>
        </select>
    </div>
    <div class=""form-group"">
        <label for=""remarks"">备注</label>
        <input class=""form-control"" type=""text"" id=""remarks"" name=""remarks"" placeholder=""请输入货物备注..""");
            BeginWriteAttribute("required", " required=\"", 985, "\"", 996, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    </div>
    <div class=""form-group"">
        <label for=""userId"">用户</label>
        <select class=""form-control"" id=""userId"" name=""userId"" size=""1"">
            <option value=""0"">请选择所属用户</option>
        </select>
    </div>
    <div class=""form-group"">
        <button class=""btn btn-primary"" type=""submit"">添加</button>
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
            url: '/GoodsType/GetAll',
            data: {},
            type: 'get',
            success: function (res) {
                console.log(res);
                var html = """";
                for (var i = 0; i < res.length; i++) {
                    html += ""<option value='"" + res[i].id + ""'>"" + res[i].name + ""</option>"";
                }
                $(""#typeId"").append(html);
            }
        });

        $.ajax({
            url: ""/Home/GetPages"",
            data: {},
            type: ""get"",
            success: function (res) {
                console.log(res);
                var html = """";
                for (var i = 0; i < res.rows.length; i++) {
  ");
                WriteLiteral("                  html += \"<option value=\'\" + res.rows[i].id + \"\'>\" + res.rows[i].name + \"</option>\";\r\n                }\r\n                $(\"#userId\").append(html);\r\n            }\r\n        });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WareHouse.Entity.Goods> Html { get; private set; }
    }
}
#pragma warning restore 1591
