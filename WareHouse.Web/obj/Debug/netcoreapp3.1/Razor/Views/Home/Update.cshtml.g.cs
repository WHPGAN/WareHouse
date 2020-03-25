#pragma checksum "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Home\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c87520a1e5fabe696c5c0d1c0f8d1b4d3983f144"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Update), @"mvc.1.0.view", @"/Views/Home/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c87520a1e5fabe696c5c0d1c0f8d1b4d3983f144", @"/Views/Home/Update.cshtml")]
    public class Views_Home_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Home\Update.cshtml"
  
    ViewData["Title"] = "Update";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-8"">
    <div class=""form-group"">
        <label class=""col-md-2 control-label"" for=""name"">用户名</label>
        <div class=""col-md-10"">
            <input class=""form-control"" type=""text"" id=""name"" name=""name"" placeholder=""请输入用户名.."">
        </div>
    </div>
    <div class=""form-group"">
        <label class=""col-md-2 control-label"" for=""pwd"">密码</label>
        <div class=""col-md-10"">
            <input class=""form-control"" type=""password"" id=""pwd"" name=""pwd"" placeholder=""请输入密码.."">
        </div>
    </div>
    <div class=""form-group"">
        <label class=""col-md-2 control-label"" for=""corporatename"">公司名</label>
        <div class=""col-md-10"">
            <input class=""form-control"" type=""text"" id=""corporatename"" name=""corporatename"" placeholder=""请输入公司名.."">
        </div>
    </div>
    <div class=""form-group"">
        <label class=""col-md-2 control-label"" for=""phone"">手机号</label>
        <div class=""col-md-10"">
            <input class=""form-control"" type=""text"" id=""ph");
            WriteLiteral(@"one"" name=""phone"" placeholder=""请输入手机号.."">
        </div>
    </div>
    <div class=""form-group"">
        <label class=""col-md-2 control-label"" for=""email"">邮箱</label>
        <div class=""col-md-10"">
            <input class=""form-control"" type=""email"" id=""email"" name=""email"" placeholder=""请输入邮箱.."">
        </div>
    </div>
    <div class=""form-group"">
        <label class=""col-md-2 control-label"" for=""postcode"">邮编</label>
        <div class=""col-md-10"">
            <input class=""form-control"" type=""text"" id=""postcode"" name=""postcode"" placeholder=""请输入邮编.."">
        </div>
    </div>
    <div class=""form-group"">
        <label class=""col-md-2 control-label"" for=""address"">地址</label>
        <div class=""col-md-10"">
            <input class=""form-control"" type=""text"" id=""address"" name=""address"" placeholder=""请输入地址.."">
        </div>
    </div>
    <div class=""form-group"">
        <div class=""col-md-1 col-md-offset-3"">
            <button id=""update-btn"" class=""btn btn-primary"" type=""submit"">修改");
            WriteLiteral("</button>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        //console.log(GetQueryString(""id""));
        $.ajax({
            url: '/Home/FindUser',
            data: {
                id:GetQueryString(""id"")
            },
            type: 'get',
            success: function(res) {
                console.log(res);
                $(""#id"").val(res.id);
                $(""#name"").val(res.name);
                $(""#pwd"").val(res.pwd);
                $(""#corporatename"").val(res.corporateName);
                $(""#phone"").val(res.phone);
                $(""#email"").val(res.email);
                $(""#postcode"").val(res.postCode);
                $(""#address"").val(res.address);
     ");
                WriteLiteral(@"       }
        });

        $(""#update-btn"").click(function () {
            var data = {
                id: GetQueryString(""id""),
                name: $(""#name"").val(),
                pwd: $(""#pwd"").val(),
                phone: $(""#phone"").val(),
                corporatename: $(""#corporatename"").val(),
                email: $(""#email"").val(),
                postcode: $(""#postcode"").val(),
                address: $(""#address"").val()
            }
            //console.log(data);
            $.ajax({
                url: '/Home/UpdateUser',
                type: 'post',
                data: data,
                success: function () {
                    window.location.href = """);
#nullable restore
#line 104 "D:\MyProject\OneDrive - OBA GG\C#\Warehouse\WareHouse.Web\Views\Home\Update.cshtml"
                                       Write(Url.Action("Index"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n                    //console.log(\"修改成功\");\r\n                },\r\n                error: function () {\r\n                    //alert(\"添加失败\");\r\n                    console.log(\"修改失败\");\r\n                }\r\n            });\r\n        });\r\n    </script>\r\n");
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
