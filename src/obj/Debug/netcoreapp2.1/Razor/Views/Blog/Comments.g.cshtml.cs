#pragma checksum "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0567d8446c73b4a2dfb5b96b83eb645fde595f7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Comments), @"mvc.1.0.view", @"/Views/Blog/Comments.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Comments.cshtml", typeof(AspNetCore.Views_Blog_Comments))]
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
#line 1 "C:\netcore\Miniblog.Core-master\src\Views\_ViewImports.cshtml"
using Miniblog.Core;

#line default
#line hidden
#line 2 "C:\netcore\Miniblog.Core-master\src\Views\_ViewImports.cshtml"
using Miniblog.Core.Models;

#line default
#line hidden
#line 3 "C:\netcore\Miniblog.Core-master\src\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 4 "C:\netcore\Miniblog.Core-master\src\Views\_ViewImports.cshtml"
using WebEssentials.AspNetCore.Pwa;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0567d8446c73b4a2dfb5b96b83eb645fde595f7f", @"/Views/Blog/Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698bc5c2bf880e0068e5406ccd42e18b65ba6a52", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("data:image/gif;base64,R0lGODlhAQABAIAAAP///wAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw=="), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("delete noline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-Action", "DeleteComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Delete the comment..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::WebEssentials.AspNetCore.CdnTagHelpers.CdnTagHelper __WebEssentials_AspNetCore_CdnTagHelpers_CdnTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 79, true);
            WriteLiteral("\n<section id=\"comments\">\n    <div class=\"container\">\n        <h2>Comments</h2>\n");
            EndContext();
#line 7 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
         foreach (var comment in Model.Comments)
        {

#line default
#line hidden
            BeginContext(198, 20, true);
            WriteLiteral("            <article");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 218, "\"", 234, 1);
#line 9 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
WriteAttributeValue("", 223, comment.ID, 223, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 235, "\"", 278, 1);
#line 9 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
WriteAttributeValue("", 243, comment.IsAdmin ? "admin" : null, 243, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(279, 114, true);
            WriteLiteral(" itemprop=\"comment\" itemscope itemtype=\"http://schema.org/Comment\">\n                <h3>\n                    <time");
            EndContext();
            BeginWriteAttribute("datetime", " datetime=\"", 393, "\"", 434, 1);
#line 11 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
WriteAttributeValue("", 404, comment.PubDate.ToString("s"), 404, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(435, 53, true);
            WriteLiteral(" itemprop=\"datePublished\">\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 488, "\"", 507, 2);
            WriteAttributeValue("", 495, "#", 495, 1, true);
#line 12 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
WriteAttributeValue("", 496, comment.ID, 496, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 508, "\"", 540, 4);
            WriteAttributeValue("", 516, "Permalink", 516, 9, true);
            WriteAttributeValue(" ", 525, "(#", 526, 3, true);
#line 12 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
WriteAttributeValue("", 528, comment.ID, 528, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 539, ")", 539, 1, true);
            EndWriteAttribute();
            BeginContext(541, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(543, 40, false);
#line 12 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
                                                                           Write(comment.PubDate.ToString("MMMM d, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(583, 118, true);
            WriteLiteral("</a>\n                    </time>\n                </h3>\n\n                <figure class=\"gravatar\">\n                    ");
            EndContext();
            BeginContext(701, 152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d90df42f38644c05baf0f5b1d24efc7b", async() => {
            }
            );
            __WebEssentials_AspNetCore_CdnTagHelpers_CdnTagHelper = CreateTagHelper<global::WebEssentials.AspNetCore.CdnTagHelpers.CdnTagHelper>();
            __tagHelperExecutionContext.Add(__WebEssentials_AspNetCore_CdnTagHelpers_CdnTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 17 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
AddHtmlAttributeValue("", 711, comment.Author, 711, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#line 17 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
                                                                                                                                             Write(comment.GetGravatar());

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-src", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(853, 105, true);
            WriteLiteral("\n                </figure>\n\n                <div class=\"content\">\n                    <p itemprop=\"text\">");
            EndContext();
            BeginContext(959, 23, false);
#line 21 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
                                  Write(comment.RenderContent());

#line default
#line hidden
            EndContext();
            BeginContext(982, 47, true);
            WriteLiteral("</p>\n                    <span itemprop=\"name\">");
            EndContext();
            BeginContext(1030, 14, false);
#line 22 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
                                     Write(comment.Author);

#line default
#line hidden
            EndContext();
            BeginContext(1044, 9, true);
            WriteLiteral("</span>\n\n");
            EndContext();
#line 24 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
            BeginContext(1131, 41, true);
            WriteLiteral("                        <a class=\"noline\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1172, "\"", 1200, 2);
            WriteAttributeValue("", 1179, "mailto:", 1179, 7, true);
#line 26 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
WriteAttributeValue("", 1186, comment.Email, 1186, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1201, "\"", 1237, 4);
            WriteAttributeValue("", 1209, "Send", 1209, 4, true);
            WriteAttributeValue(" ", 1213, "email", 1214, 6, true);
            WriteAttributeValue(" ", 1219, "to", 1220, 3, true);
#line 26 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
WriteAttributeValue(" ", 1222, comment.Email, 1223, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1238, 38, true);
            WriteLiteral(">&#x2709;</a>\n                        ");
            EndContext();
            BeginContext(1276, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d3e52cc07544bd7bb725d373ce9b70f", async() => {
                BeginContext(1478, 9, true);
                WriteLiteral("Delete...");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postid", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
                                                                                                        WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 27 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
                                                                                                                                        WriteLiteral(comment.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["commentid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-commentid", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["commentid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 27 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
                                                                                                                                                                     WriteLiteral(ViewData["afrt"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["afrt"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-afrt", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["afrt"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1491, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 28 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
                    }

#line default
#line hidden
            BeginContext(1514, 46, true);
            WriteLiteral("                </div>\n            </article>\n");
            EndContext();
#line 31 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
        }

#line default
#line hidden
            BeginContext(1570, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 33 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
         if (Model.AreCommentsOpen(settings.Value.CommentsCloseAfterDays))
        {
            if (Model.Comments.Count == 0)
            {

#line default
#line hidden
            BeginContext(1713, 54, true);
            WriteLiteral("                <p>Be the first to post a comment</p>\n");
            EndContext();
#line 38 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
            }


#line default
#line hidden
            BeginContext(1782, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1794, 1018, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "662a3cbd0b3a45d5bbd3f6e09248f5f4", async() => {
                BeginContext(1913, 892, true);
                WriteLiteral(@"
                <h3>Post a comment</h3>
                <br />

                <label for=""content"">Comment</label>
                <textarea id=""content"" name=""content"" rows=""5"" cols=""100"" onfocus="""" required placeholder=""Enter your comment here...""></textarea>

                <div class=""details"">
                    <label for=""author"">Name</label>
                    <input id=""author"" name=""author"" placeholder=""Your name"" required />

                    <label for=""email"">E-mail</label>
                    <input id=""email"" name=""email"" placeholder=""Example: mary@outlook.com"" required />
                    <br />

                    <input type=""submit"" value=""Post comment"" />

                    <!-- This element is being removed by site.js. It is to prevent comment spam-->
                    <input type=""hidden"" name=""website"" />
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postid", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
                                                                                    WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["postid"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postid", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["postid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 40 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery = false;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-antiforgery", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Antiforgery, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2812, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(2814, 142, true);
            WriteLiteral("            <noscript>\n                <br />\n                <p>Enable JavaScript to post comments on this blog.</p>\n            </noscript>\n");
            EndContext();
#line 66 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2989, 58, true);
            WriteLiteral("            <br />\n            <p>Comments are closed</p>\n");
            EndContext();
#line 71 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Comments.cshtml"
        }

#line default
#line hidden
            BeginContext(3057, 21, true);
            WriteLiteral("    </div>\n</section>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptionsSnapshot<BlogSettings> settings { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
