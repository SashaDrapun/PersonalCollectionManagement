#pragma checksum "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbf41461682cb6ee105dfcf20f1b773f531dfda9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Users), @"mvc.1.0.view", @"/Views/Home/Users.cshtml")]
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
#line 1 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbf41461682cb6ee105dfcf20f1b773f531dfda9", @"/Views/Home/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33ee78d0c2dc3b34e8ac3dc3614354e3df8b881c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PersonalCollectionManagement.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deleteUserForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("setAdminForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Users.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
    ViewData["Title"] = Localizer["Users"];
    ViewData["CurrentPage"] = "Users";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<table id=\"usersTable\"");
            BeginWriteAttribute("class", " class=\"", 257, "\"", 335, 6);
            WriteAttributeValue("", 265, "table", 265, 5, true);
            WriteAttributeValue(" ", 270, "table-responsive-sm", 271, 20, true);
            WriteAttributeValue(" ", 290, "table-bordered", 291, 15, true);
            WriteAttributeValue(" ", 305, "table-hover", 306, 12, true);
            WriteAttributeValue(" ", 317, "table-", 318, 7, true);
#nullable restore
#line 10 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
WriteAttributeValue("", 324, ViewBag.Bg, 324, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">");
#nullable restore
#line 13 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
                       Write(Localizer["Nickname"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th scope=\"col\">");
#nullable restore
#line 14 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
                       Write(Localizer["LastLoginDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th scope=\"col\">");
#nullable restore
#line 15 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
                       Write(Localizer["RegistrationDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 16 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
             if (ViewBag.AutorizeUser != null && ViewBag.AutorizeUser.IsAdmin)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th scope=\"col\">");
#nullable restore
#line 18 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
                           Write(Localizer["BlockUnlock"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 19 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
                           Write(Localizer["Delete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 20 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
                           Write(Localizer["SetAsAdministrator"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 21 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th scope=\"col\">");
#nullable restore
#line 22 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
                       Write(Localizer["GoTo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
         foreach (var user in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">\r\n                ");
#nullable restore
#line 30 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
           Write(user.Nickname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
           Write(user.DateRegistration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
           Write(user.DateLastLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 35 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
             if (ViewBag.AutorizeUser != null && ViewBag.AutorizeUser.IsAdmin)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
                 if(!user.IsAdmin || ViewBag.AutorizeUser.Nickname == "Nagibator3000")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbf41461682cb6ee105dfcf20f1b773f531dfda912399", async() => {
                WriteLiteral("\r\n                            <button class=\"btn btn-danger\">\r\n                                ");
#nullable restore
#line 42 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
                            Write(user.Status == "Разблокирован" ? Localizer["Block"] : Localizer["Unlock"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </button>\r\n                        ");
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
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idUser", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
                                                                                     WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idUser"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idUser", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idUser"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <button class=\"btn btn-danger deleteUser\"");
            BeginWriteAttribute("idUser", "\r\n                                idUser=\"", 1880, "\"", 1930, 1);
#nullable restore
#line 48 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
WriteAttributeValue("", 1922, user.Id, 1922, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                data-toggle=\"modal\" data-target=\"#deleteUser\">\r\n                            ");
#nullable restore
#line 50 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
                       Write(Localizer["Delete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </button>\r\n                    </td>\r\n                    <td>\r\n                        <button class=\"btn btn-danger setAdmin\"");
            BeginWriteAttribute("idUser", "\r\n                                idUser=\"", 2214, "\"", 2264, 1);
#nullable restore
#line 55 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
WriteAttributeValue("", 2256, user.Id, 2256, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                data-toggle=\"modal\" data-target=\"#setAdmin\">\r\n                            ");
#nullable restore
#line 57 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
                       Write(Localizer["SetAsAdministrator"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </button>\r\n                    </td>\r\n");
#nullable restore
#line 60 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        <p class=\"text-info\">");
#nullable restore
#line 64 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
                                        Write(Localizer["Admin"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n                    <td>\r\n                        <p class=\"text-info\">");
#nullable restore
#line 67 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
                                        Write(Localizer["Admin"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n                    <td>\r\n                        <p class=\"text-info\">");
#nullable restore
#line 70 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
                                        Write(Localizer["Admin"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </td>\r\n");
#nullable restore
#line 72 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbf41461682cb6ee105dfcf20f1b773f531dfda919747", async() => {
                WriteLiteral("\r\n                    <button class=\"btn btn-primary\">\r\n                        ");
#nullable restore
#line 78 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
                   Write(Localizer["GoTo"]);

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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idUser", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
                                                                        WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idUser"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idUser", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idUser"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 83 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<div class=\'modal fade\' id=\'deleteUser\' tabindex=\"-1\" role=\"dialog\"\r\n     aria-hidden=\"true\">\r\n    <div class=\"modal-dialog modal-dialog-centered \" role=\"document\">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 3451, "\"", 3506, 5);
            WriteAttributeValue("", 3459, "modal-content", 3459, 13, true);
            WriteAttributeValue(" ", 3472, "text-", 3473, 6, true);
#nullable restore
#line 90 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
WriteAttributeValue("", 3478, ViewBag.Text, 3478, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3491, "bg-", 3492, 4, true);
#nullable restore
#line 90 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Users.cshtml"
WriteAttributeValue("", 3495, ViewBag.Bg, 3495, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""modal-header "">
                <h5 class=""modal-title text-danger"">Удаление пользователя</h5>
                <button class=""close autorization"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p class=""text-danger"">Вы уверены, что хотите удалить пользователя?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Отмена</button>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbf41461682cb6ee105dfcf20f1b773f531dfda924943", async() => {
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Удалить</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<div class='modal fade' id='setAdmin' tabindex=""-1"" role=""dialog""
     aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered "" role=""document"">
        <div class=""modal-content text-white bg-dark"">
            <div class=""modal-header "">
                <h5 class=""modal-title text-danger"">Назначение администратора</h5>
                <button class=""close autorization"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p class=""text-danger"">Вы уверены, что хотите сделать пользователя администратором?</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Отмена</button>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbf41461682cb6ee105dfcf20f1b773f531dfda927540", async() => {
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Назначить</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbf41461682cb6ee105dfcf20f1b773f531dfda929235", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PersonalCollectionManagement.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591