#pragma checksum "C:\Users\taef_\source\repos\BookStore\BookStore\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e47a85d119c5bb5e557dbe1bd92a261281c90a5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#line 1 "C:\Users\taef_\source\repos\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\taef_\source\repos\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e47a85d119c5bb5e557dbe1bd92a261281c90a5f", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970ad2232b60c18355d1b72e2ff9366751045b67", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\taef_\source\repos\BookStore\BookStore\Views\Products\Details.cshtml"
   var product = (ProductModel)ViewData["product"];


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-bordered"">


    <thead>
        <tr>
            <th scope=""col"">Book Id  </th>
            <th scope=""col""> Book Name </th>
            <th scope=""col"">  Book Price  </th>
            <th scope=""col""> Book Author  </th>
            <th scope=""col""> Book Image   </th>
            <th scope=""col""> Back   </th>

        </tr>
    </thead>
  

    <tbody>
        <tr>
            <td scope=""row"" style=""text-align:center"">
                ");
#nullable restore
#line 24 "C:\Users\taef_\source\repos\BookStore\BookStore\Views\Products\Details.cshtml"
           Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n            <td scope=\"row\" style=\"text-align:center \">\r\n                ");
#nullable restore
#line 29 "C:\Users\taef_\source\repos\BookStore\BookStore\Views\Products\Details.cshtml"
           Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n            <td scope=\"row\" style=\"text-align:center\">\r\n                ");
#nullable restore
#line 34 "C:\Users\taef_\source\repos\BookStore\BookStore\Views\Products\Details.cshtml"
           Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td scope=\"row\" style=\"text-align:center\">\r\n                ");
#nullable restore
#line 37 "C:\Users\taef_\source\repos\BookStore\BookStore\Views\Products\Details.cshtml"
           Write(product.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <img style=width:200 height=200");
            BeginWriteAttribute("src", " src=\"", 972, "\"", 992, 1);
#nullable restore
#line 40 "C:\Users\taef_\source\repos\BookStore\BookStore\Views\Products\Details.cshtml"
WriteAttributeValue("", 978, product.Image, 978, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 993, "\"", 1013, 1);
#nullable restore
#line 40 "C:\Users\taef_\source\repos\BookStore\BookStore\Views\Products\Details.cshtml"
WriteAttributeValue("", 999, product.Image, 999, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

            </td>
            <td style=""text-align:center"">
                <a href=""/Products"">
                    <button type=""button"" class=""btn btn-outline-info"">Back</button>
                </a>
            </td>
        </tr>

    </tbody>


</table>
");
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
