#pragma checksum "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad85fa6f93a765303d50c6e40465913d9386b54b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
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
#nullable restore
#line 1 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\_ViewImports.cshtml"
using PersonalCollectionManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\_ViewImports.cshtml"
using PersonalCollectionManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad85fa6f93a765303d50c6e40465913d9386b54b", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33ee78d0c2dc3b34e8ac3dc3614354e3df8b881c", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
  
    ViewData["CurrentPage"] = "Registration";
    ViewData["Title"] = Localizer["Registration"];
    ViewData["Dog"] = "@";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"modal-dialog modal-dialog-centered \" role=\"document\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 291, "\"", 346, 5);
            WriteAttributeValue("", 299, "modal-content", 299, 13, true);
            WriteAttributeValue(" ", 312, "text-", 313, 6, true);
#nullable restore
#line 10 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
WriteAttributeValue("", 318, ViewBag.Text, 318, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 331, "bg-", 332, 4, true);
#nullable restore
#line 10 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
WriteAttributeValue("", 335, ViewBag.Bg, 335, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"modal-header \">\r\n            <h5 class=\"modal-title\">");
#nullable restore
#line 12 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                               Write(Localizer["Registration"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        </div>\r\n        <div class=\"modal-body\">\r\n            <div class=\"container-fluid\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad85fa6f93a765303d50c6e40465913d9386b54b5773", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                     if (ViewBag.MessageAboutBlocked != null)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <small class=\"form-text text-danger\">");
#nullable restore
#line 19 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                                                        Write(ViewBag.MessageAboutBlocked);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n");
#nullable restore
#line 20 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"form-group\">\r\n                        <label for=\"InputEmail\">");
#nullable restore
#line 22 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                                           Write(Localizer["Email"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        <input type=\"email\"\r\n                               name=\"email\"\r\n                               class=\"form-control\"\r\n                               id=\"InputEmail\"\r\n                               placeholder=\"Email\"");
                BeginWriteAttribute("pattern", "\r\n                               pattern=\"", 1159, "\"", 1256, 3);
                WriteAttributeValue("", 1201, "([0-9a-z_.]+", 1201, 12, true);
#nullable restore
#line 28 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
WriteAttributeValue("", 1213, ViewData["Dog"], 1213, 18, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1231, "[0-9a-z_^.]+.[a-z]{2,3})+", 1231, 25, true);
                EndWriteAttribute();
                BeginWriteAttribute("title", "\r\n                               title=\"", 1257, "\"", 1333, 1);
#nullable restore
#line 29 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
WriteAttributeValue("", 1297, Localizer["MailEnteredIncorrectly"], 1297, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 30 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                         if (ViewBag.EmailMessage != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <small class=\"form-text text-danger\">");
#nullable restore
#line 32 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                                                            Write(ViewBag.EmailMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n");
#nullable restore
#line 33 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        <label for=\"Nickname\">");
#nullable restore
#line 37 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                                         Write(Localizer["Nickname"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        <input type=\"text\"\r\n                               name=\"nickname\"\r\n                               class=\"form-control\"\r\n                               id=\"Nickname\"");
                BeginWriteAttribute("placeholder", "\r\n                               placeholder=\"", 1890, "\"", 1958, 1);
#nullable restore
#line 42 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
WriteAttributeValue("", 1936, Localizer["Nickname"], 1936, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n");
#nullable restore
#line 44 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                         if (ViewBag.NicknameMessage != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <small class=\"form-text text-danger\">");
#nullable restore
#line 46 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                                                            Write(ViewBag.NicknameMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n");
#nullable restore
#line 47 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        <label for=\"InputPassword\">");
#nullable restore
#line 51 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                                              Write(Localizer["Password"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        <input type=\"password\"\r\n                               name=\"password\"\r\n                               class=\"form-control\"\r\n                               id=\"InputPassword\"");
                BeginWriteAttribute("placeholder", "\r\n                               placeholder=\"", 2537, "\"", 2605, 1);
#nullable restore
#line 56 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
WriteAttributeValue("", 2583, Localizer["Password"], 2583, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                               pattern=\"\\w{5}\"");
                BeginWriteAttribute("title", "\r\n                               title=\"", 2654, "\"", 2721, 1);
#nullable restore
#line 58 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
WriteAttributeValue("", 2694, Localizer["PasswordLimit"], 2694, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 59 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                         if (ViewBag.PasswordMessage != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <small class=\"form-text text-danger\">");
#nullable restore
#line 61 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                                                            Write(ViewBag.PasswordMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n");
#nullable restore
#line 62 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n\r\n                    <div class=\"form-group\">\r\n                        <label for=\"ConfirmPassword\">");
#nullable restore
#line 66 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                                                Write(Localizer["ConfirmPassword"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                        <input type=\"password\"\r\n                               name=\"ConfirmPassword\"\r\n                               class=\"form-control\"\r\n                               id=\"ConfirmPassword\"");
                BeginWriteAttribute("placeholder", "\r\n                               placeholder=\"", 3316, "\"", 3391, 1);
#nullable restore
#line 71 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
WriteAttributeValue("", 3362, Localizer["ConfirmPassword"], 3362, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 72 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                         if (ViewBag.ConfirmPasswordMessage != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <small class=\"form-text text-danger\">");
#nullable restore
#line 74 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                                                            Write(ViewBag.ConfirmPasswordMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n");
#nullable restore
#line 75 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n\r\n                    <button type=\"submit\" class=\"btn btn-primary\">\r\n                        ");
#nullable restore
#line 79 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Account\Register.cshtml"
                   Write(Localizer["SignUp"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
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
