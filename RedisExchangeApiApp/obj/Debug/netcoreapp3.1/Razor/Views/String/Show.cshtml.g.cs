#pragma checksum "C:\Users\farid.al\source\repos\Cache\RedisExchangeApiApp\Views\String\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b648d54bd0c0d1087c080db430d3d5174e24bef0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_String_Show), @"mvc.1.0.view", @"/Views/String/Show.cshtml")]
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
#line 1 "C:\Users\farid.al\source\repos\Cache\RedisExchangeApiApp\Views\_ViewImports.cshtml"
using RedisExchangeApiApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\farid.al\source\repos\Cache\RedisExchangeApiApp\Views\_ViewImports.cshtml"
using RedisExchangeApiApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b648d54bd0c0d1087c080db430d3d5174e24bef0", @"/Views/String/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0279d89ae8c435f661110e23b2f0966f46511d67", @"/Views/_ViewImports.cshtml")]
    public class Views_String_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\farid.al\source\repos\Cache\RedisExchangeApiApp\Views\String\Show.cshtml"
  
    ViewData["Title"] = "Show";
    Product product = @ViewBag.product as Product;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Show</h1>\r\n<h1> Name: ");
#nullable restore
#line 8 "C:\Users\farid.al\source\repos\Cache\RedisExchangeApiApp\Views\String\Show.cshtml"
      Write(ViewBag.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1> Users count: ");
#nullable restore
#line 9 "C:\Users\farid.al\source\repos\Cache\RedisExchangeApiApp\Views\String\Show.cshtml"
             Write(ViewBag.users);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1> ProductId: ");
#nullable restore
#line 10 "C:\Users\farid.al\source\repos\Cache\RedisExchangeApiApp\Views\String\Show.cshtml"
           Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" , ProductName: ");
#nullable restore
#line 10 "C:\Users\farid.al\source\repos\Cache\RedisExchangeApiApp\Views\String\Show.cshtml"
                                      Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" , ProductStock: ");
#nullable restore
#line 10 "C:\Users\farid.al\source\repos\Cache\RedisExchangeApiApp\Views\String\Show.cshtml"
                                                                    Write(product.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
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