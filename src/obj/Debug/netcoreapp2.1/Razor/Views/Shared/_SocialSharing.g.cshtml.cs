#pragma checksum "C:\netcore\Miniblog.Core-master\src\Views\Shared\_SocialSharing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5868f08d165496f023e89f07171057b447e5f58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SocialSharing), @"mvc.1.0.view", @"/Views/Shared/_SocialSharing.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_SocialSharing.cshtml", typeof(AspNetCore.Views_Shared__SocialSharing))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5868f08d165496f023e89f07171057b447e5f58", @"/Views/Shared/_SocialSharing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698bc5c2bf880e0068e5406ccd42e18b65ba6a52", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SocialSharing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\netcore\Miniblog.Core-master\src\Views\Shared\_SocialSharing.cshtml"
  
    string currentUrl = Context.Request.Scheme + "://" + Context.Request.Host + Context.Request.Path;
    string enc = System.Net.WebUtility.UrlEncode(currentUrl);
    string text = System.Net.WebUtility.UrlEncode(Model);

#line default
#line hidden
            BeginContext(241, 37, true);
            WriteLiteral("\n<aside class=\"socialsharing\">\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 278, "\"", 334, 2);
            WriteAttributeValue("", 285, "https://www.facebook.com/sharer/sharer.php?u=", 285, 45, true);
#line 9 "C:\netcore\Miniblog.Core-master\src\Views\Shared\_SocialSharing.cshtml"
WriteAttributeValue("", 330, enc, 330, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(335, 523, true);
            WriteLiteral(@" target=""_blank"" rel=""noopener noreferrer nofollow"">
        <svg role=""img"" aria-labelledby=""_fb"">
            <title id=""_fb"">Share on Facebook</title>
            <path d=""M22.676 0H1.324C.593 0 0 .593 0 1.324v21.352C0 23.408.593 24 1.324 24h11.494v-9.294H9.689v-3.621h3.129V8.41c0-3.099 1.894-4.785 4.659-4.785 1.325 0 2.464.097 2.796.141v3.24h-1.921c-1.5 0-1.792.721-1.792 1.771v2.311h3.584l-.465 3.63H16.56V24h6.115c.733 0 1.325-.592 1.325-1.324V1.324C24 .593 23.408 0 22.676 0""></path>
        </svg>
    </a>
    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 858, "\"", 917, 4);
            WriteAttributeValue("", 865, "https://twitter.com/intent/tweet?url=", 865, 37, true);
#line 15 "C:\netcore\Miniblog.Core-master\src\Views\Shared\_SocialSharing.cshtml"
WriteAttributeValue("", 902, enc, 902, 4, false);

#line default
#line hidden
            WriteAttributeValue("", 906, "&text=", 906, 6, true);
#line 15 "C:\netcore\Miniblog.Core-master\src\Views\Shared\_SocialSharing.cshtml"
WriteAttributeValue("", 912, text, 912, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(918, 855, true);
            WriteLiteral(@" target=""_blank"" rel=""noopener noreferrer nofollow"">
        <svg role=""img"" aria-labelledby=""_tw"">
            <title id=""_tw"">Share on Twitter</title>
            <path d=""M23.954 4.569c-.885.389-1.83.654-2.825.775 1.014-.611 1.794-1.574 2.163-2.723-.951.555-2.005.959-3.127 1.184-.896-.959-2.173-1.559-3.591-1.559-2.717 0-4.92 2.203-4.92 4.917 0 .39.045.765.127 1.124C7.691 8.094 4.066 6.13 1.64 3.161c-.427.722-.666 1.561-.666 2.475 0 1.71.87 3.213 2.188 4.096-.807-.026-1.566-.248-2.228-.616v.061c0 2.385 1.693 4.374 3.946 4.827-.413.111-.849.171-1.296.171-.314 0-.615-.03-.916-.086.631 1.953 2.445 3.377 4.604 3.417-1.68 1.319-3.809 2.105-6.102 2.105-.39 0-.779-.023-1.17-.067 2.189 1.394 4.768 2.209 7.557 2.209 9.054 0 13.999-7.496 13.999-13.986 0-.209 0-.42-.015-.63.961-.689 1.8-1.56 2.46-2.548l-.047-.02z""></path>
        </svg>
    </a>
    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1773, "\"", 1818, 2);
            WriteAttributeValue("", 1780, "https://plus.google.com/share?url=", 1780, 34, true);
#line 21 "C:\netcore\Miniblog.Core-master\src\Views\Shared\_SocialSharing.cshtml"
WriteAttributeValue("", 1814, enc, 1814, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1819, 604, true);
            WriteLiteral(@" target=""_blank"" rel=""noopener noreferrer nofollow"">
        <svg role=""img"" aria-labelledby=""_gp"">
            <title id=""_gp"">Share on Google+</title>
            <path d=""M7.635 10.909v2.619h4.335c-.173 1.125-1.31 3.295-4.331 3.295-2.604 0-4.731-2.16-4.731-4.823 0-2.662 2.122-4.822 4.728-4.822 1.485 0 2.479.633 3.045 1.178l2.073-1.994c-1.33-1.245-3.056-1.995-5.115-1.995C3.412 4.365 0 7.785 0 12s3.414 7.635 7.635 7.635c4.41 0 7.332-3.098 7.332-7.461 0-.501-.054-.885-.12-1.265H7.635zm16.365 0h-2.183V8.726h-2.183v2.183h-2.182v2.181h2.184v2.184h2.189V13.09H24""></path>
        </svg>
    </a>
    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2423, "\"", 2486, 4);
            WriteAttributeValue("", 2430, "mailto:?subject=", 2430, 16, true);
#line 27 "C:\netcore\Miniblog.Core-master\src\Views\Shared\_SocialSharing.cshtml"
WriteAttributeValue("", 2446, Model.Replace(" ", "%20"), 2446, 26, false);

#line default
#line hidden
            WriteAttributeValue("", 2472, "&amp;body=", 2472, 10, true);
#line 27 "C:\netcore\Miniblog.Core-master\src\Views\Shared\_SocialSharing.cshtml"
WriteAttributeValue("", 2482, enc, 2482, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2487, 988, true);
            WriteLiteral(@" target=""_blank"" rel=""noopener noreferrer nofollow"">
        <svg role=""img"" aria-labelledby=""_em"">
            <title id=""_em"">Email</title>
            <path d=""M24 7.387v10.478c0 .23-.08.424-.238.576-.158.154-.352.23-.58.23h-8.547v-6.959l1.6 1.229c.102.085.229.126.379.126.148 0 .277-.041.389-.127L24 7.387zm-9.365-2.021h8.547c.211 0 .393.063.543.192.15.128.234.3.248.51l-7.369 5.876-1.969-1.549V5.366zM13.404.864v22.271L0 20.819V3.244L13.406.864h-.002zm-4.049 11.18c-.02-1.133-.313-2.072-.879-2.814-.555-.74-1.275-1.131-2.131-1.164-.824.033-1.529.423-2.1 1.164-.57.742-.855 1.682-.87 2.814.015 1.117.315 2.047.885 2.791.571.74 1.274 1.133 2.101 1.176.855-.035 1.574-.424 2.145-1.17.57-.748.87-1.68.885-2.797h-.036zm-3.12-2.482c.431.02.794.256 1.083.717.285.461.435 1.045.435 1.752 0 .721-.149 1.307-.435 1.771-.301.464-.66.704-1.096.704s-.795-.226-1.095-.69-.435-1.05-.435-1.754c0-.705.135-1.291.435-1.74.284-.45.646-.69 1.081-.721l.027-.039z""></path>
        </svg>
    </a>
</aside>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
