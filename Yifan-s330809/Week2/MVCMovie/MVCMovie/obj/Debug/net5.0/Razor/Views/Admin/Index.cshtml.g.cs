#pragma checksum "/Users/yifansong/PRT585-GROUP-F/Yifan-s330809/Week2/MVCMovie/MVCMovie/Views/Admin/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f0d0b081e7f52149f20b897e08c0dee9b413a03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "/Users/yifansong/PRT585-GROUP-F/Yifan-s330809/Week2/MVCMovie/MVCMovie/Views/_ViewImports.cshtml"
using MVCMovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/yifansong/PRT585-GROUP-F/Yifan-s330809/Week2/MVCMovie/MVCMovie/Views/_ViewImports.cshtml"
using MVCMovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f0d0b081e7f52149f20b897e08c0dee9b413a03", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9169640970f372ab73cabb37e97a40665f5d6725", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/Users/yifansong/PRT585-GROUP-F/Yifan-s330809/Week2/MVCMovie/MVCMovie/Views/Admin/Index.cshtml"
  
    ViewData["Title"] = "Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Admin Page</h2>\n\n");
            WriteLiteral("\n<ul>\n    <li>\n        ");
#nullable restore
#line 19 "/Users/yifansong/PRT585-GROUP-F/Yifan-s330809/Week2/MVCMovie/MVCMovie/Views/Admin/Index.cshtml"
   Write(ViewData["Username"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </li>\n    <li>\n        ");
#nullable restore
#line 22 "/Users/yifansong/PRT585-GROUP-F/Yifan-s330809/Week2/MVCMovie/MVCMovie/Views/Admin/Index.cshtml"
   Write(ViewData["UserID"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </li>\n</ul>");
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