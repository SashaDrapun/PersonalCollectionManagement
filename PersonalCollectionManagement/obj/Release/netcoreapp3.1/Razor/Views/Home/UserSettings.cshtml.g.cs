#pragma checksum "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59aa47c7c92b6c2cde31a9cd409bcff95ba77c97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserSettings), @"mvc.1.0.view", @"/Views/Home/UserSettings.cshtml")]
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
#line 1 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59aa47c7c92b6c2cde31a9cd409bcff95ba77c97", @"/Views/Home/UserSettings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33ee78d0c2dc3b34e8ac3dc3614354e3df8b881c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserSettings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Settings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeLanguage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeTheme", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/settings.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
  
    ViewData["Title"] = Localizer["Settings"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"m-3\">\r\n    <h2");
            BeginWriteAttribute("class", " class=\"", 163, "\"", 189, 2);
            WriteAttributeValue("", 171, "text-", 171, 5, true);
#nullable restore
#line 8 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
WriteAttributeValue("", 176, ViewBag.Text, 176, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 8 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
                              Write(Localizer["ProfileSettings"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59aa47c7c92b6c2cde31a9cd409bcff95ba77c976321", async() => {
                WriteLiteral("\r\n        <p");
                BeginWriteAttribute("class", " class=\"", 305, "\"", 331, 2);
                WriteAttributeValue("", 313, "text-", 313, 5, true);
#nullable restore
#line 11 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
WriteAttributeValue("", 318, ViewBag.Text, 318, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 11 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
                                 Write(Localizer["ChooseLanguage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <select");
                BeginWriteAttribute("class", " class=\"", 382, "\"", 438, 5);
                WriteAttributeValue("", 390, "text-", 390, 5, true);
#nullable restore
#line 12 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
WriteAttributeValue("", 395, ViewBag.Text, 395, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 408, "bg-", 409, 4, true);
#nullable restore
#line 12 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
WriteAttributeValue("", 412, ViewBag.Bg, 412, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 423, "languageSelect", 424, 15, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 13 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
             if (ViewBag.Language == "ru")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59aa47c7c92b6c2cde31a9cd409bcff95ba77c978653", async() => {
#nullable restore
#line 15 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
                            Write(Localizer["Russian"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59aa47c7c92b6c2cde31a9cd409bcff95ba77c9710228", async() => {
#nullable restore
#line 16 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
                   Write(Localizer["English"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59aa47c7c92b6c2cde31a9cd409bcff95ba77c9711764", async() => {
#nullable restore
#line 20 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
                   Write(Localizer["Russian"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59aa47c7c92b6c2cde31a9cd409bcff95ba77c9713008", async() => {
#nullable restore
#line 21 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
                            Write(Localizer["English"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n\r\n        <input class=\"d-none\"\r\n               name=\"language\"\r\n               id=\"languageValue\"");
                BeginWriteAttribute("value", "\r\n               value=\"", 923, "\"", 964, 1);
#nullable restore
#line 28 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
WriteAttributeValue("", 947, ViewBag.Language, 947, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n        <button type=\"submit\" class=\"btn btn-primary\">");
#nullable restore
#line 30 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
                                                 Write(Localizer["SaveChanges"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59aa47c7c92b6c2cde31a9cd409bcff95ba77c9717198", async() => {
                WriteLiteral("\r\n        <p");
                BeginWriteAttribute("class", " class=\"", 1148, "\"", 1174, 2);
                WriteAttributeValue("", 1156, "text-", 1156, 5, true);
#nullable restore
#line 34 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
WriteAttributeValue("", 1161, ViewBag.Text, 1161, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 34 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
                                 Write(Localizer["ChooseATopic"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <select");
                BeginWriteAttribute("class", " class=\"", 1223, "\"", 1276, 5);
                WriteAttributeValue("", 1231, "text-", 1231, 5, true);
#nullable restore
#line 35 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
WriteAttributeValue("", 1236, ViewBag.Text, 1236, 13, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1249, "bg-", 1250, 4, true);
#nullable restore
#line 35 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
WriteAttributeValue("", 1253, ViewBag.Bg, 1253, 11, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1264, "themeSelect", 1265, 12, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 36 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
             if (ViewBag.Bg == "dark")
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59aa47c7c92b6c2cde31a9cd409bcff95ba77c9719536", async() => {
#nullable restore
#line 38 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
                        Write(Localizer["Dark"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59aa47c7c92b6c2cde31a9cd409bcff95ba77c9721101", async() => {
#nullable restore
#line 39 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
               Write(Localizer["Light"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59aa47c7c92b6c2cde31a9cd409bcff95ba77c9722631", async() => {
#nullable restore
#line 43 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
                   Write(Localizer["Dark"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59aa47c7c92b6c2cde31a9cd409bcff95ba77c9723872", async() => {
#nullable restore
#line 44 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
                            Write(Localizer["Light"]);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </select>\r\n        <input class=\"d-none\"\r\n               name=\"theme\"");
                BeginWriteAttribute("value", "\r\n               value=\"", 1701, "\"", 1736, 1);
#nullable restore
#line 50 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
WriteAttributeValue("", 1725, ViewBag.Bg, 1725, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n               id=\"ThemeValue\">\r\n        <button type=\"submit\" class=\"btn btn-primary\">");
#nullable restore
#line 52 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\UserSettings.cshtml"
                                                 Write(Localizer["SaveChanges"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59aa47c7c92b6c2cde31a9cd409bcff95ba77c9728054", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
