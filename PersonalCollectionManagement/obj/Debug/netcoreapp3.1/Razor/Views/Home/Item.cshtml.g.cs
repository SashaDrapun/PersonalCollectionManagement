#pragma checksum "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37a02c9e8810974933d1b8c0d843bce12995dcd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Item), @"mvc.1.0.view", @"/Views/Home/Item.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37a02c9e8810974933d1b8c0d843bce12995dcd3", @"/Views/Home/Item.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33ee78d0c2dc3b34e8ac3dc3614354e3df8b881c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Item : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonalCollectionManagement.Models.Item>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-2 like"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/LikePressed.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Like.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/Comment.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("commentForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Item.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"

    ViewData["Title"] = "Элемент - " + Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p class=\"d-none\" id=\"isUserLike\">");
#nullable restore
#line 7 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                             Write(ViewBag.IsUserLike);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p class=\"d-none\" id=\"idItem\">");
#nullable restore
#line 8 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                         Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<table");
            BeginWriteAttribute("class", " class=\"", 226, "\"", 304, 6);
            WriteAttributeValue("", 234, "table", 234, 5, true);
            WriteAttributeValue(" ", 239, "table-responsive-sm", 240, 20, true);
            WriteAttributeValue(" ", 259, "table-bordered", 260, 15, true);
            WriteAttributeValue(" ", 274, "table-hover", 275, 12, true);
            WriteAttributeValue(" ", 286, "table-", 287, 7, true);
#nullable restore
#line 9 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
WriteAttributeValue("", 293, ViewBag.Bg, 293, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Название элемента</th>\r\n");
#nullable restore
#line 13 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
             foreach (var item in Model.Collection.FormattedFields)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th scope=\"col\">");
#nullable restore
#line 15 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 16 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <th scope=\"col\">Лайки</th>\r\n            <th scope=\"col\">Комментарии</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 24 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n");
#nullable restore
#line 26 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
             for (var i = 0; i < Model.Collection.FormattedFields.Count; i++)
            {
                var field = Model.Collection.FormattedFields[i];

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                 if (field.Type == "Числовой")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th scope=\"row\"><input type=\"number\" readonly");
            BeginWriteAttribute("value", " value=\"", 1021, "\"", 1054, 1);
#nullable restore
#line 32 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
WriteAttributeValue("", 1029, Model.FormattedValues[i], 1029, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></th>\r\n");
#nullable restore
#line 33 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                 if (field.Type == "Строковый")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th scope=\"row\"><input type=\"text\" readonly");
            BeginWriteAttribute("value", " value=\"", 1215, "\"", 1248, 1);
#nullable restore
#line 37 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
WriteAttributeValue("", 1223, Model.FormattedValues[i], 1223, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></th>\r\n");
#nullable restore
#line 38 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                 if (field.Type == "Текстовый")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th scope=\"row\"><textarea readonly>");
#nullable restore
#line 42 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                                                  Write(Model.FormattedValues[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea></th>\r\n");
#nullable restore
#line 43 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                 if (field.Type == "Дата")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th scope=\"row\"><input type=\"datetime\" readonly");
            BeginWriteAttribute("value", " value=\"", 1595, "\"", 1628, 1);
#nullable restore
#line 47 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
WriteAttributeValue("", 1603, Model.FormattedValues[i], 1603, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></th>\r\n");
#nullable restore
#line 48 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                 if (field.Type == "Логический")
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                     if (Model.FormattedValues[i] == "on")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th scope=\"row\"><input type=\"checkbox\" disabled checked></th>\r\n");
#nullable restore
#line 55 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th scope=\"row\"><input type=\"checkbox\" disabled></th>\r\n");
#nullable restore
#line 59 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <th scope=\"row\">\r\n");
#nullable restore
#line 64 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                 if (ViewBag.IsUserLike)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "37a02c9e8810974933d1b8c0d843bce12995dcd316944", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 67 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "37a02c9e8810974933d1b8c0d843bce12995dcd318371", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 71 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span id=\"countLikes\">");
#nullable restore
#line 72 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                                 Write(ViewBag.CountLikes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </th>\r\n\r\n            <th scope=\"row\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "37a02c9e8810974933d1b8c0d843bce12995dcd320156", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <span id=\"countComments\">");
#nullable restore
#line 77 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                                    Write(ViewBag.Comments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </th>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n<div class=\"modal-dialog\" role=\"document\" id=\"formCommentModal\">\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 2800, "\"", 2855, 5);
            WriteAttributeValue("", 2808, "modal-content", 2808, 13, true);
            WriteAttributeValue(" ", 2821, "text-", 2822, 6, true);
#nullable restore
#line 84 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
WriteAttributeValue("", 2827, ViewBag.Text, 2827, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2840, "bg-", 2841, 4, true);
#nullable restore
#line 84 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
WriteAttributeValue("", 2844, ViewBag.Bg, 2844, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"modal-header \">\r\n            <h5 class=\"modal-title\">Оставьте ваш комментарий</h5>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37a02c9e8810974933d1b8c0d843bce12995dcd322801", async() => {
                WriteLiteral(@"
            <div class=""modal-body"">
                <div class=""container-fluid"">
                    <textarea name=""text"" rows=""4"" cols=""30""></textarea>
                </div>
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-primary"">Комментировать</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 101 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
 foreach (var comment in ViewBag.Comments)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <div class=\"modal-dialog\" role=\"document\">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 3503, "\"", 3558, 5);
            WriteAttributeValue("", 3511, "modal-content", 3511, 13, true);
            WriteAttributeValue(" ", 3524, "text-", 3525, 6, true);
#nullable restore
#line 105 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
WriteAttributeValue("", 3530, ViewBag.Text, 3530, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3543, "bg-", 3544, 4, true);
#nullable restore
#line 105 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
WriteAttributeValue("", 3547, ViewBag.Bg, 3547, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"modal-header \">\r\n                <h5 class=\"modal-title \">");
#nullable restore
#line 107 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                                    Write(comment.User.Nickname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p>");
#nullable restore
#line 108 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
              Write(comment.DateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                <div class=\"container-fluid\">\r\n                    <span>");
#nullable restore
#line 112 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
                     Write(comment.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 118 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\'modal fade\' id=\'notFullAccess\' tabindex=\"-1\" role=\"dialog\"\r\n     aria-hidden=\"true\">\r\n    <div class=\"modal-dialog modal-dialog-centered \" role=\"document\">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 4134, "\"", 4184, 4);
            WriteAttributeValue("", 4142, "modal-content", 4142, 13, true);
#nullable restore
#line 123 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
WriteAttributeValue(" ", 4155, ViewBag.Text, 4156, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 4169, "bg-", 4170, 4, true);
#nullable restore
#line 123 "C:\Users\alexander\Desktop\Itranzition\PersonalCollectionManagement\PersonalCollectionManagement\Views\Home\Item.cshtml"
WriteAttributeValue("", 4173, ViewBag.Bg, 4173, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""modal-header "">
                <h5 class=""modal-title text-danger"">Вы не авторизованы</h5>
                <button class=""close autorization"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p class=""text-info"">Чтобы оставить комментарий или поставить лайк, авторизуйтесь!!!</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Ок</button>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37a02c9e8810974933d1b8c0d843bce12995dcd328896", async() => {
                WriteLiteral("\r\n                    <input name=\"idCollection\" id=\"idCollection\" class=\"d-none\">\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Перейти к авторизации</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37a02c9e8810974933d1b8c0d843bce12995dcd331010", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37a02c9e8810974933d1b8c0d843bce12995dcd332050", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
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
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonalCollectionManagement.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
