#pragma checksum "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f2d824aac5204442d7a4cd15e42c54dc5c51a6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewCart), @"mvc.1.0.view", @"/Views/Home/ViewCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ViewCart.cshtml", typeof(AspNetCore.Views_Home_ViewCart))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f2d824aac5204442d7a4cd15e42c54dc5c51a6b", @"/Views/Home/ViewCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d60866982e904e501eafe1415376d08702dcbdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 489, true);
            WriteLiteral(@"<h2 class=""text-center h2_cart"">Your Cart </h2>
<div class=""container"">
<table class=""table"">
  <thead>
    <tr class=""cart_header"">
      <th class=""text-center"" scope=""col"">Image</th>
      <th class=""text-center"" scope=""col"">Title</th>
      <th class=""text-center"" scope=""col"">Price</th>
      <th class=""text-center"" scope=""col"">Material</th>
      <th class=""text-center"" scope=""col"">Quantity</th>
      <th class=""text-center"" scope=""col"">Remove</th>
    </tr>
  </thead>
  <tbody>
");
            EndContext();
#line 15 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
  
    foreach(var item in ViewBag.Cart.ItemsOrdered)
    {

#line default
#line hidden
            BeginContext(549, 39, true);
            WriteLiteral("    <tr class=\"cart_size\">\n      <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 588, "\"", 629, 2);
            WriteAttributeValue("", 595, "/image/", 595, 7, true);
#line 19 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
WriteAttributeValue("", 602, item.ChosenImage.Galleryid, 602, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(630, 126, true);
            WriteLiteral("><img style=\"max-width: 300px; max-height: 300px;box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.8);\"");
            EndContext();
            BeginWriteAttribute("src", "src=\"", 756, "\"", 788, 1);
#line 19 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
WriteAttributeValue("", 761, item.ChosenImage.Image_URL, 761, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(789, 42, true);
            WriteLiteral(" alt=\"whuthappened\" /></a></td>\n      <td>");
            EndContext();
            BeginContext(832, 22, false);
#line 20 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
     Write(item.ChosenImage.Title);

#line default
#line hidden
            EndContext();
            BeginContext(854, 16, true);
            WriteLiteral("</td>\n      <td>");
            EndContext();
            BeginContext(871, 18, false);
#line 21 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
     Write(item.Product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(889, 16, true);
            WriteLiteral("</td>\n      <td>");
            EndContext();
            BeginContext(906, 18, false);
#line 22 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
     Write(item.Product.Style);

#line default
#line hidden
            EndContext();
            BeginContext(924, 16, true);
            WriteLiteral("</td>\n      <td>");
            EndContext();
            BeginContext(941, 13, false);
#line 23 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
     Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(954, 18, true);
            WriteLiteral("</td>\n      <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 972, "\"", 999, 2);
            WriteAttributeValue("", 979, "/delete/", 979, 8, true);
#line 24 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
WriteAttributeValue("", 987, item.Itemid, 987, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1000, 62, true);
            WriteLiteral("><button class=\"btn btn-danger\">x</button></a></td>\n    </tr>\n");
            EndContext();
#line 26 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
    }

#line default
#line hidden
            BeginContext(1070, 56, true);
            WriteLiteral("</table>\n<p class=\"text-right\"><strong>Taxes: </strong>$");
            EndContext();
            BeginContext(1127, 13, false);
#line 29 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
                                          Write(ViewBag.Taxes);

#line default
#line hidden
            EndContext();
            BeginContext(1140, 52, true);
            WriteLiteral("</p>\n<p class=\"text-right\"><strong>TOTAL: </strong>$");
            EndContext();
            BeginContext(1193, 13, false);
#line 30 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
                                          Write(ViewBag.Total);

#line default
#line hidden
            EndContext();
            BeginContext(1206, 633, true);
            WriteLiteral(@"</p>
</div>
<div class=""container"">
  <div class=""row"">
  <div class=""col col-md-10""></div>
  <div class=""col col-md-2"">
<div id=""paypal-button-container"" style=""width: 10vw;""></div></div></div></div>


<script src=""https://www.paypal.com/sdk/js?client-id=sb&currency=USD""></script>

    <script>
        // Render the PayPal button into #paypal-button-container
        paypal.Buttons({

            // Set up the transaction
            createOrder: function(data, actions) {
                return actions.order.create({
                    purchase_units: [{
                        amount: {
                            value: '");
            EndContext();
            BeginContext(1840, 13, false);
#line 50 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
                               Write(ViewBag.Total);

#line default
#line hidden
            EndContext();
            BeginContext(1853, 498, true);
            WriteLiteral(@"'
                        }
                    }]
                });
            },

            // Finalize the transaction
            onApprove: function(data, actions) {
                return actions.order.capture().then(function(details) {
                    // Show a success message to the buyer
                    alert('Transaction completed by ' + details.payer.name.given_name + '!');
                });
            }


        }).render('#paypal-button-container');
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
