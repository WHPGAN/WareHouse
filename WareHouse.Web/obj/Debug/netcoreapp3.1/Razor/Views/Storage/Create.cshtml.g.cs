#pragma checksum "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Storage\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6e6f77bb9532a8fed11dddfe0cf94c5611c3b7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Storage_Create), @"mvc.1.0.view", @"/Views/Storage/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6e6f77bb9532a8fed11dddfe0cf94c5611c3b7f", @"/Views/Storage/Create.cshtml")]
    public class Views_Storage_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Storage\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<form");
            BeginWriteAttribute("action", " action=\"", 96, "\"", 130, 1);
#nullable restore
#line 6 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Storage\Create.cshtml"
WriteAttributeValue("", 105, Url.Action("AddStorage"), 105, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" method=\"post\">\r\n    <div class=\"form-group\">\r\n        <label for=\"name\">名称</label>\r\n        <input class=\"form-control\" type=\"text\" id=\"name\" name=\"name\" placeholder=\"请输入仓库名称..\"");
            BeginWriteAttribute("required", " required=\"", 309, "\"", 320, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"address\">地址</label>\r\n        <input class=\"form-control\" type=\"text\" id=\"address\" name=\"address\" placeholder=\"请输入仓库地址..\"");
            BeginWriteAttribute("required", " required=\"", 506, "\"", 517, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"capacity\">容量</label>\r\n        <input class=\"form-control\" type=\"number\" id=\"capacity\" name=\"capacity\" placeholder=\"请输入仓库容量..\"");
            BeginWriteAttribute("required", " required=\"", 708, "\"", 719, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <button class=\"btn btn-primary\" type=\"submit\">添加</button>\r\n    </div>\r\n</form>");
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
