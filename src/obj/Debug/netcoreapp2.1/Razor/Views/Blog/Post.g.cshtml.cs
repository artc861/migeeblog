#pragma checksum "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2783b6b724df4d1a2397c6426c8d16165bf33792"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Post), @"mvc.1.0.view", @"/Views/Blog/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Post.cshtml", typeof(AspNetCore.Views_Blog_Post))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2783b6b724df4d1a2397c6426c8d16165bf33792", @"/Views/Blog/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698bc5c2bf880e0068e5406ccd42e18b65ba6a52", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Edit the post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("itemprop", new global::Microsoft.AspNetCore.Html.HtmlString("articleBody mainEntityOfPage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-page", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("preload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/comments.scss"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("as", new global::Microsoft.AspNetCore.Html.HtmlString("style"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/prism/prism.scss"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/prism/prism.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/admin.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/admin.scss"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::WebEssentials.AspNetCore.CdnTagHelpers.CdnifyTagHelper __WebEssentials_AspNetCore_CdnTagHelpers_CdnifyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::WebOptimizer.Taghelpers.LinkTagHelper __WebOptimizer_Taghelpers_LinkTagHelper;
        private global::WebEssentials.AspNetCore.CdnTagHelpers.CdnTagHelper __WebEssentials_AspNetCore_CdnTagHelpers_CdnTagHelper;
        private global::WebOptimizer.Taghelpers.ScriptTagHelper __WebOptimizer_Taghelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
  
    ViewData["Title"] = Model.Title;
    ViewData["Description"] = Model.Excerpt;
    bool showFullPost = ViewContext.RouteData.Values.ContainsKey("slug");
    string host = Context.Request.Scheme + "://" + Context.Request.Host;
    bool isCodePreview = Model.Content.Contains("</code>");

#line default
#line hidden
            BeginContext(354, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Head", async() => {
                BeginContext(370, 26, true);
                WriteLiteral("\n    <link rel=\"canonical\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 396, "\"", 428, 1);
#line 12 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
WriteAttributeValue("", 403, host + Model.GetLink(), 403, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(429, 4, true);
                WriteLiteral(" />\n");
                EndContext();
            }
            );
            BeginContext(435, 157, true);
            WriteLiteral("\n<article class=\"post container\" itemscope itemtype=\"http://schema.org/BlogPosting\" itemprop=\"blogPost\">\n    <header>\n        <h1 itemprop=\"name headline\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 592, "\"", 615, 1);
#line 17 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
WriteAttributeValue("", 599, Model.GetLink(), 599, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(616, 32, true);
            WriteLiteral(" rel=\"canonical\" itemprop=\"url\">");
            EndContext();
            BeginContext(649, 11, false);
#line 17 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
                                                                                          Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(660, 23, true);
            WriteLiteral("</a></h1>\n        <time");
            EndContext();
            BeginWriteAttribute("datetime", " datetime=\"", 683, "\"", 722, 1);
#line 18 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
WriteAttributeValue("", 694, Model.PubDate.ToString("s"), 694, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(723, 36, true);
            WriteLiteral(" itemprop=\"datePublished\">Published ");
            EndContext();
            BeginContext(760, 37, false);
#line 18 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
                                                                                    Write(Model.PubDate.ToString("MMM d, yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(797, 8, true);
            WriteLiteral("</time>\n");
            EndContext();
#line 19 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
            BeginContext(859, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(871, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cad0a402d2594e169c718c9aa62f670c", async() => {
                BeginContext(961, 9, true);
                WriteLiteral("Edit post");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 21 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
                                                         WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(974, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 22 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
        }

#line default
#line hidden
            BeginContext(985, 19, true);
            WriteLiteral("    </header>\n\n    ");
            EndContext();
            BeginContext(1004, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2554e6fd23414e38a88a321af156726f", async() => {
                BeginContext(1056, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(1066, 31, false);
#line 26 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
   Write(Html.Raw(Model.RenderContent()));

#line default
#line hidden
                EndContext();
                BeginContext(1097, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
            __WebEssentials_AspNetCore_CdnTagHelpers_CdnifyTagHelper = CreateTagHelper<global::WebEssentials.AspNetCore.CdnTagHelpers.CdnifyTagHelper>();
            __tagHelperExecutionContext.Add(__WebEssentials_AspNetCore_CdnTagHelpers_CdnifyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("cdnify", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1108, 15, true);
            WriteLiteral("\n\n    <footer>\n");
            EndContext();
#line 30 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
         if (Model.Categories.Any())
        {

#line default
#line hidden
            BeginContext(1170, 73, true);
            WriteLiteral("            <ul class=\"categories\">\n                <li> Posted in </li>\n");
            EndContext();
#line 34 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
                 foreach (string cat in Model.Categories)
                {

#line default
#line hidden
            BeginContext(1319, 50, true);
            WriteLiteral("                    <li itemprop=\"articleSection\">");
            EndContext();
            BeginContext(1369, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8a197eebdd04f7cbab43e33be37aa5d", async() => {
                BeginContext(1480, 3, false);
#line 36 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
                                                                                                                                                           Write(cat);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
                                                                                                         WriteLiteral(cat.ToLowerInvariant());

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1487, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 37 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
                }

#line default
#line hidden
            BeginContext(1511, 18, true);
            WriteLiteral("            </ul>\n");
            EndContext();
            BeginContext(1547, 7, true);
            WriteLiteral("and has");
            EndContext();
#line 39 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
                                
        }

#line default
#line hidden
            BeginContext(1572, 11, true);
            WriteLiteral("\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1583, "\"", 1615, 2);
#line 42 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
WriteAttributeValue("", 1590, Model.GetLink(), 1590, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 1606, "#comments", 1606, 9, true);
            EndWriteAttribute();
            BeginContext(1616, 104, true);
            WriteLiteral(" itemprop=\"discussionUrl\" title=\"Go to the comments section\">\n            <span itemprop=\"commentCount\">");
            EndContext();
            BeginContext(1721, 20, false);
#line 43 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
                                     Write(Model.Comments.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1741, 8, true);
            WriteLiteral("</span> ");
            EndContext();
            BeginContext(1751, 50, false);
#line 43 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
                                                                   Write(Model.Comments.Count == 1 ? "comment" : "comments");

#line default
#line hidden
            EndContext();
            BeginContext(1802, 46, true);
            WriteLiteral("\n        </a>\n\n        <meta itemprop=\"author\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 1848, "\"", 1879, 1);
#line 46 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
WriteAttributeValue("", 1858, settings.Value.Owner, 1858, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1880, 41, true);
            WriteLiteral(" />\n        <meta itemprop=\"dateModified\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 1921, "\"", 1964, 1);
#line 47 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
WriteAttributeValue("", 1931, Model.LastModified.ToString("s"), 1931, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1965, 45, true);
            WriteLiteral(" />\n        <meta itemprop=\"mainEntityOfPage\"");
            EndContext();
            BeginWriteAttribute("content", " content=\"", 2010, "\"", 2045, 1);
#line 48 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
WriteAttributeValue("", 2020, host + Model.GetLink(), 2020, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2046, 30, true);
            WriteLiteral(" />\n    </footer>\n</article>\n\n");
            EndContext();
#line 52 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
 if (showFullPost)
{
    await Html.RenderPartialAsync("_SocialSharing", Model.Title);
    await Html.RenderPartialAsync("Comments");

    

#line default
#line hidden
            DefineSection("Preload", async() => {
                BeginContext(2233, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(2308, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(2316, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d3bc6d73ea045f39f62f51a0c5cac0a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __WebOptimizer_Taghelpers_LinkTagHelper = CreateTagHelper<global::WebOptimizer.Taghelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__WebOptimizer_Taghelpers_LinkTagHelper);
                __WebEssentials_AspNetCore_CdnTagHelpers_CdnTagHelper = CreateTagHelper<global::WebEssentials.AspNetCore.CdnTagHelpers.CdnTagHelper>();
                __tagHelperExecutionContext.Add(__WebEssentials_AspNetCore_CdnTagHelpers_CdnTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2376, 19, true);
                WriteLiteral("\n        <noscript>");
                EndContext();
                BeginContext(2395, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "85cb7abea3544360a78ec766f7139ce3", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __WebOptimizer_Taghelpers_LinkTagHelper = CreateTagHelper<global::WebOptimizer.Taghelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__WebOptimizer_Taghelpers_LinkTagHelper);
                __WebEssentials_AspNetCore_CdnTagHelpers_CdnTagHelper = CreateTagHelper<global::WebEssentials.AspNetCore.CdnTagHelpers.CdnTagHelper>();
                __tagHelperExecutionContext.Add(__WebEssentials_AspNetCore_CdnTagHelpers_CdnTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2447, 12, true);
                WriteLiteral("</noscript>\n");
                EndContext();
#line 61 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
         if (isCodePreview)
        {

#line default
#line hidden
                BeginContext(2497, 12, true);
                WriteLiteral("            ");
                EndContext();
                BeginContext(2509, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "00ff924db2204b9cbaf50653f3ed2a32", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __WebOptimizer_Taghelpers_LinkTagHelper = CreateTagHelper<global::WebOptimizer.Taghelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__WebOptimizer_Taghelpers_LinkTagHelper);
                __WebEssentials_AspNetCore_CdnTagHelpers_CdnTagHelper = CreateTagHelper<global::WebEssentials.AspNetCore.CdnTagHelpers.CdnTagHelper>();
                __tagHelperExecutionContext.Add(__WebEssentials_AspNetCore_CdnTagHelpers_CdnTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2572, 13, true);
                WriteLiteral("\n            ");
                EndContext();
                BeginContext(2585, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5727961c7b87416094d5513740a4107f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __WebOptimizer_Taghelpers_ScriptTagHelper = CreateTagHelper<global::WebOptimizer.Taghelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__WebOptimizer_Taghelpers_ScriptTagHelper);
                __WebEssentials_AspNetCore_CdnTagHelpers_CdnTagHelper = CreateTagHelper<global::WebEssentials.AspNetCore.CdnTagHelpers.CdnTagHelper>();
                __tagHelperExecutionContext.Add(__WebEssentials_AspNetCore_CdnTagHelpers_CdnTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("async", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("defer", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2641, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 65 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
        }

#line default
#line hidden
                BeginContext(2652, 4, true);
                WriteLiteral("    ");
                EndContext();
            }
            );
#line 66 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
     
}

#line default
#line hidden
            BeginContext(2660, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 69 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
 if (User.Identity.IsAuthenticated)
{
    

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(2721, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(2730, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaaf1ff1c40e41dc94cc786f5a6fefbb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __WebOptimizer_Taghelpers_ScriptTagHelper = CreateTagHelper<global::WebOptimizer.Taghelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__WebOptimizer_Taghelpers_ScriptTagHelper);
                __WebEssentials_AspNetCore_CdnTagHelpers_CdnTagHelper = CreateTagHelper<global::WebEssentials.AspNetCore.CdnTagHelpers.CdnTagHelper>();
                __tagHelperExecutionContext.Add(__WebEssentials_AspNetCore_CdnTagHelpers_CdnTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("async", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("defer", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2779, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(2788, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8532c14f441644f0a55771e80c905e4e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __WebOptimizer_Taghelpers_LinkTagHelper = CreateTagHelper<global::WebOptimizer.Taghelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__WebOptimizer_Taghelpers_LinkTagHelper);
                __WebEssentials_AspNetCore_CdnTagHelpers_CdnTagHelper = CreateTagHelper<global::WebEssentials.AspNetCore.CdnTagHelpers.CdnTagHelper>();
                __tagHelperExecutionContext.Add(__WebEssentials_AspNetCore_CdnTagHelpers_CdnTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2837, 5, true);
                WriteLiteral("\n    ");
                EndContext();
            }
            );
#line 74 "C:\netcore\Miniblog.Core-master\src\Views\Blog\Post.cshtml"
     
}

#line default
#line hidden
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
