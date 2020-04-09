#pragma checksum "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Role\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cfb82206c62aec8e3d498adeaabb9960f451dce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Edit), @"mvc.1.0.view", @"/Views/Role/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cfb82206c62aec8e3d498adeaabb9960f451dce", @"/Views/Role/Edit.cshtml")]
    public class Views_Role_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Role\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"form-group\">\r\n    <input type=\"hidden\" id=\"id\"");
            BeginWriteAttribute("value", " value=\"", 147, "\"", 155, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
    <label for=""roleName"">角色名</label>
    <input class=""form-control"" type=""text"" id=""roleName"" name=""roleName"" placeholder=""请输入角色名.."" required=""required"">
</div>
<div class=""form-group"">
    <button id=""edit-btn"" class=""btn btn-primary"" type=""submit"">修改</button>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function GetQueryString(name) {
            var reg = new RegExp(""(^|&)"" + name + ""=([^&]*)(&|$)"");
            //console.log(window.location.search);//?id=2
            var r = window.location.search.substr(1).match(reg);
            if (r != null) return unescape(r[2]);
            return null;
        }
    </script>
    <script>
        $.ajax({
            url: '/Role/Find',
            data: {
                id: GetQueryString(""id"")
            },
            type: 'post',
            success: function (res) {
                console.log(res);
                $(""#roleName"").val(res.data.roleName);
                $(""#id"").val(res.data.id);
            }
        });
        $(""#edit-btn"").click(function () {
            if ($(""#roleName"").val()==="""") {
                $.error(""角色名不能为空"");
                return;
            }
            var data = {
                id: $(""#id"").val(),
                roleName: $(""#roleName"").val()
            };
    ");
                WriteLiteral("        $.post({\r\n                url: \'/Role/Update\',\r\n                data: data,\r\n                success: function() {\r\n                    window.location.href = \"");
#nullable restore
#line 52 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Role\Edit.cshtml"
                                       Write(Url.Action("Index"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n                }\r\n            });\r\n        });\r\n    </script>\r\n");
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
