#pragma checksum "C:\Users\farid.al\source\repos\Cache\InMemoryApp\Views\Product\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "593a7d9670847dc0db1bdd5dcff90222b29843dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Show), @"mvc.1.0.view", @"/Views/Product/Show.cshtml")]
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
#line 1 "C:\Users\farid.al\source\repos\Cache\InMemoryApp\Views\_ViewImports.cshtml"
using InMemoryApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\farid.al\source\repos\Cache\InMemoryApp\Views\_ViewImports.cshtml"
using InMemoryApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"593a7d9670847dc0db1bdd5dcff90222b29843dc", @"/Views/Product/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fdb94293622f148b2d3a42edef2ac72e37bed5a", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\farid.al\source\repos\Cache\InMemoryApp\Views\Product\Show.cshtml"
  
    ViewData["Title"] = "Show";
    var product = ViewBag.product as Product;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Show</h1>\r\n<h1>");
#nullable restore
#line 8 "C:\Users\farid.al\source\repos\Cache\InMemoryApp\Views\Product\Show.cshtml"
Write(ViewBag.zaman);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>");
#nullable restore
#line 9 "C:\Users\farid.al\source\repos\Cache\InMemoryApp\Views\Product\Show.cshtml"
Write(ViewBag.callback);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>");
#nullable restore
#line 10 "C:\Users\farid.al\source\repos\Cache\InMemoryApp\Views\Product\Show.cshtml"
Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 10 "C:\Users\farid.al\source\repos\Cache\InMemoryApp\Views\Product\Show.cshtml"
             Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 10 "C:\Users\farid.al\source\repos\Cache\InMemoryApp\Views\Product\Show.cshtml"
                             Write(product.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n\r\n");
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
