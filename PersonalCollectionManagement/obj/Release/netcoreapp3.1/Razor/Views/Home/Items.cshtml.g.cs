#pragma checksum "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c35464c8d9a9189c30a51e11e0ddb1f61e07dec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Items), @"mvc.1.0.view", @"/Views/Home/Items.cshtml")]
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
#line 1 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c35464c8d9a9189c30a51e11e0ddb1f61e07dec", @"/Views/Home/Items.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33ee78d0c2dc3b34e8ac3dc3614354e3df8b881c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Items : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PersonalCollectionManagement.Models.Item>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Collection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
    ViewData["Title"] = Localizer["Items"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"text-info\">");
#nullable restore
#line 10 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
                    Write(Localizer["NoResults"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 11 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table");
            BeginWriteAttribute("class", " class=\"", 296, "\"", 374, 6);
            WriteAttributeValue("", 304, "table", 304, 5, true);
            WriteAttributeValue(" ", 309, "table-responsive-sm", 310, 20, true);
            WriteAttributeValue(" ", 329, "table-bordered", 330, 15, true);
            WriteAttributeValue(" ", 344, "table-hover", 345, 12, true);
            WriteAttributeValue(" ", 356, "table-", 357, 7, true);
#nullable restore
#line 14 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
WriteAttributeValue("", 363, ViewBag.Bg, 363, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <thead>\r\n            <tr>\r\n                <th scope=\"col\">");
#nullable restore
#line 17 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
                           Write(Localizer["ItemName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 18 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
                           Write(Localizer["Tegs"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("Теги</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 19 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
                           Write(Localizer["GoToItemCollection"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 20 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
                           Write(Localizer["GoToItemOwner"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 21 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
                           Write(Localizer["GoToItem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 28 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
                   Write(item.Tegs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c35464c8d9a9189c30a51e11e0ddb1f61e07dec9513", async() => {
                WriteLiteral("\r\n                            <button class=\"btn btn-primary\">\r\n                                ");
#nullable restore
#line 34 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
                           Write(Localizer["GoToItemCollection"]);

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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idCollection", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
                                                                                        WriteLiteral(item.CollectionId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idCollection"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idCollection", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["idCollection"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c35464c8d9a9189c30a51e11e0ddb1f61e07dec12831", async() => {
                WriteLiteral("\r\n                            <button class=\"btn btn-primary\">\r\n                                ");
#nullable restore
#line 42 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
                           Write(Localizer["GoToItemOwner"]);

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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idUser", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
                                                                                WriteLiteral(item.Collection.UserId);

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
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c35464c8d9a9189c30a51e11e0ddb1f61e07dec16118", async() => {
                WriteLiteral("\r\n                            <button class=\"btn btn-primary\">\r\n                                ");
#nullable restore
#line 50 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
                           Write(Localizer["GoToItem"]);

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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
                                                                        WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 55 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 58 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Items.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PersonalCollectionManagement.Models.Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591