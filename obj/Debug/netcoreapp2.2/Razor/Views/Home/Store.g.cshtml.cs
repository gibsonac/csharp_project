#pragma checksum "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/Store.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "674d5f19284ee7d7cf17e5e183802fb142a08539"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Store), @"mvc.1.0.view", @"/Views/Home/Store.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Store.cshtml", typeof(AspNetCore.Views_Home_Store))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"674d5f19284ee7d7cf17e5e183802fb142a08539", @"/Views/Home/Store.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d60866982e904e501eafe1415376d08702dcbdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Store : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/Store.cshtml"
  
    ViewData["Title"] = "Gallery";

#line default
#line hidden
            BeginContext(61, 123, true);
            WriteLiteral("<div class=\"container text-center\">\n    <div class=\"row\">\n        <div class=\"col-6\">\n            <h2>Canvas Prints: </h2>\n");
            EndContext();
#line 9 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/Store.cshtml"
             foreach(var product in Model)
            {
                

#line default
#line hidden
#line 11 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/Store.cshtml"
                 if(product.Style == "Canvas")
                {

#line default
#line hidden
            BeginContext(306, 46, true);
            WriteLiteral("                    <p><strong>Size:</strong> ");
            EndContext();
            BeginContext(353, 12, false);
#line 13 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/Store.cshtml"
                                         Write(product.Size);

#line default
#line hidden
            EndContext();
            BeginContext(365, 53, true);
            WriteLiteral("</p>\n                    <p><strong>Price:</strong> $");
            EndContext();
            BeginContext(419, 13, false);
#line 14 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/Store.cshtml"
                                           Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(432, 30, true);
            WriteLiteral("</p>\n                    <hr>\n");
            EndContext();
#line 16 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/Store.cshtml"
                }

#line default
#line hidden
#line 16 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/Store.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(494, 81, true);
            WriteLiteral("        </div>\n        <div class=\"col-6\">\n            <h2>Metalic Prints: </h2>\n");
            EndContext();
#line 21 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/Store.cshtml"
             foreach(var product in Model)
            {
                

#line default
#line hidden
#line 23 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/Store.cshtml"
                 if(product.Style == "Metalic")
                {

#line default
#line hidden
            BeginContext(698, 46, true);
            WriteLiteral("                    <p><strong>Size:</strong> ");
            EndContext();
            BeginContext(745, 12, false);
#line 25 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/Store.cshtml"
                                         Write(product.Size);

#line default
#line hidden
            EndContext();
            BeginContext(757, 53, true);
            WriteLiteral("</p>\n                    <p><strong>Price:</strong> $");
            EndContext();
            BeginContext(811, 13, false);
#line 26 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/Store.cshtml"
                                           Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(824, 30, true);
            WriteLiteral("</p>\n                    <hr>\n");
            EndContext();
#line 28 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/Store.cshtml"
                }

#line default
#line hidden
#line 28 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/Store.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(886, 32, true);
            WriteLiteral("        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
