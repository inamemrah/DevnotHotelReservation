#pragma checksum "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\User\SignUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8d94496a972db2782670dc4b10875be3f29c92a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_SignUp), @"mvc.1.0.view", @"/Views/User/SignUp.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/SignUp.cshtml", typeof(AspNetCore.Views_User_SignUp))]
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
#line 1 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\_ViewImports.cshtml"
using DevnotHotelReservation.Web;

#line default
#line hidden
#line 2 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\_ViewImports.cshtml"
using DevnotHotelReservation.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8d94496a972db2782670dc4b10875be3f29c92a", @"/Views/User/SignUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26af0f3b7b2b51ada6054ce1f8052349b0c97af3", @"/Views/_ViewImports.cshtml")]
    public class Views_User_SignUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevnotHotelReservation.Entity.Model.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\User\SignUp.cshtml"
  
    Layout = "~/Views/Shared/_MyLayout.cshtml";

#line default
#line hidden
            BeginContext(105, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(134, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8d94496a972db2782670dc4b10875be3f29c92a4557", async() => {
                BeginContext(140, 91, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Login</title>\r\n    ");
                EndContext();
                BeginContext(231, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a8d94496a972db2782670dc4b10875be3f29c92a5036", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(291, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(300, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(302, 955, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8d94496a972db2782670dc4b10875be3f29c92a7164", async() => {
                BeginContext(308, 71, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <h2>Kayıt Sayfası</h2>\r\n        ");
                EndContext();
                BeginContext(380, 15, false);
#line 17 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\User\SignUp.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
                EndContext();
                BeginContext(395, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 18 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\User\SignUp.cshtml"
         using (Html.BeginForm("SaveUser", "User", FormMethod.Post))
        {

#line default
#line hidden
                BeginContext(478, 54, true);
                WriteLiteral("            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(533, 30, false);
#line 21 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\User\SignUp.cshtml"
           Write(Html.LabelFor(m => m.UserName));

#line default
#line hidden
                EndContext();
                BeginContext(563, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(582, 96, false);
#line 22 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\User\SignUp.cshtml"
           Write(Html.TextBoxFor(m => m.UserName, new { @class = "form-control", placeholder = "Kullanıcı Adı" }));

#line default
#line hidden
                EndContext();
                BeginContext(678, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(755, 34, false);
#line 25 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\User\SignUp.cshtml"
           Write(Html.LabelFor(m => m.EmailAddress));

#line default
#line hidden
                EndContext();
                BeginContext(789, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(808, 93, false);
#line 26 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\User\SignUp.cshtml"
           Write(Html.TextBoxFor(m => m.EmailAddress, new { @class = "form-control", placeholder = "E-mail" }));

#line default
#line hidden
                EndContext();
                BeginContext(901, 76, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
                EndContext();
                BeginContext(978, 30, false);
#line 29 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\User\SignUp.cshtml"
           Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
                EndContext();
                BeginContext(1008, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1027, 89, false);
#line 30 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\User\SignUp.cshtml"
           Write(Html.PasswordFor(m => m.Password, new { @class = "form-control", placeholder = "Sifre" }));

#line default
#line hidden
                EndContext();
                BeginContext(1116, 109, true);
                WriteLiteral("\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-success btn-block\">Kayıt Ol</button>\r\n");
                EndContext();
#line 33 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\User\SignUp.cshtml"
        }

#line default
#line hidden
                BeginContext(1236, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1257, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevnotHotelReservation.Entity.Model.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
