#pragma checksum "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Account/Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14f9e2abe306b9b53e3bf935cdbe5794293690f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Orders), @"mvc.1.0.view", @"/Views/Account/Orders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Orders.cshtml", typeof(AspNetCore.Views_Account_Orders))]
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
#line 1 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/_ViewImports.cshtml"
using csharp_project;

#line default
#line hidden
#line 2 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/_ViewImports.cshtml"
using csharp_project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14f9e2abe306b9b53e3bf935cdbe5794293690f2", @"/Views/Account/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d60866982e904e501eafe1415376d08702dcbdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Account/Orders.cshtml"
  
    ViewData["Title"] = "Orders";

#line default
#line hidden
            BeginContext(39, 23, true);
            WriteLiteral("orders page goes here!\n");
            EndContext();
#line 5 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Account/Orders.cshtml"
  
    foreach(var order in ViewBag.User)
    {

#line default
#line hidden
            BeginContext(110, 13, true);
            WriteLiteral("        <hr>\n");
            EndContext();
#line 9 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Account/Orders.cshtml"
        foreach(var item in order)
        {

#line default
#line hidden
            BeginContext(168, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(184, 18, false);
#line 11 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Account/Orders.cshtml"
          Write(item.Product.Title);

#line default
#line hidden
            EndContext();
            BeginContext(202, 20, true);
            WriteLiteral("</p>\n            <p>");
            EndContext();
            BeginContext(223, 24, false);
#line 12 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Account/Orders.cshtml"
          Write(item.Product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(247, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 13 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Account/Orders.cshtml"
        }
    }

#line default
#line hidden
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
