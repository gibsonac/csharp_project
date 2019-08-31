#pragma checksum "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0df67bdd9ffb3c3f04cc668538e52dcd6fc22e41"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0df67bdd9ffb3c3f04cc668538e52dcd6fc22e41", @"/Views/Home/ViewCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d60866982e904e501eafe1415376d08702dcbdf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
  
    ViewData["Title"] = "Checkout";

#line default
#line hidden
            BeginContext(41, 489, true);
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
#line 18 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
  
    foreach(var item in ViewBag.Cart.ItemsOrdered)
    {

#line default
#line hidden
            BeginContext(590, 39, true);
            WriteLiteral("    <tr class=\"cart_size\">\n      <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 629, "\"", 670, 2);
            WriteAttributeValue("", 636, "/image/", 636, 7, true);
#line 22 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
WriteAttributeValue("", 643, item.ChosenImage.Galleryid, 643, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(671, 126, true);
            WriteLiteral("><img style=\"max-width: 300px; max-height: 300px;box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.8);\"");
            EndContext();
            BeginWriteAttribute("src", "src=\"", 797, "\"", 829, 1);
#line 22 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
WriteAttributeValue("", 802, item.ChosenImage.Image_URL, 802, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(830, 42, true);
            WriteLiteral(" alt=\"whuthappened\" /></a></td>\n      <td>");
            EndContext();
            BeginContext(873, 22, false);
#line 23 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
     Write(item.ChosenImage.Title);

#line default
#line hidden
            EndContext();
            BeginContext(895, 16, true);
            WriteLiteral("</td>\n      <td>");
            EndContext();
            BeginContext(912, 18, false);
#line 24 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
     Write(item.Product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(930, 16, true);
            WriteLiteral("</td>\n      <td>");
            EndContext();
            BeginContext(947, 18, false);
#line 25 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
     Write(item.Product.Style);

#line default
#line hidden
            EndContext();
            BeginContext(965, 16, true);
            WriteLiteral("</td>\n      <td>");
            EndContext();
            BeginContext(982, 13, false);
#line 26 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
     Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(995, 18, true);
            WriteLiteral("</td>\n      <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1013, "\"", 1040, 2);
            WriteAttributeValue("", 1020, "/delete/", 1020, 8, true);
#line 27 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
WriteAttributeValue("", 1028, item.Itemid, 1028, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1041, 62, true);
            WriteLiteral("><button class=\"btn btn-danger\">x</button></a></td>\n    </tr>\n");
            EndContext();
#line 29 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
    }

#line default
#line hidden
            BeginContext(1111, 56, true);
            WriteLiteral("</table>\n<p class=\"text-right\"><strong>Taxes: </strong>$");
            EndContext();
            BeginContext(1168, 13, false);
#line 32 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
                                          Write(ViewBag.Taxes);

#line default
#line hidden
            EndContext();
            BeginContext(1181, 52, true);
            WriteLiteral("</p>\n<p class=\"text-right\"><strong>TOTAL: </strong>$");
            EndContext();
            BeginContext(1234, 13, false);
#line 33 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
                                          Write(ViewBag.Total);

#line default
#line hidden
            EndContext();
            BeginContext(1247, 633, true);
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
            BeginContext(1881, 13, false);
#line 53 "/Users/Gibby540/Desktop/CodingDojo/C#.NET/csharp_project/Views/Home/ViewCart.cshtml"
                               Write(ViewBag.Total);

#line default
#line hidden
            EndContext();
            BeginContext(1894, 498, true);
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
