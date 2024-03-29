#pragma checksum "C:\Users\agunn\Code\Northwind-Identity-FP\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "571d7e1486e2f90f18008f13e9c1bf5893c5f8b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Index), @"mvc.1.0.view", @"/Index.cshtml")]
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
#line 1 "C:\Users\agunn\Code\Northwind-Identity-FP\Index.cshtml"
using Identity.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"571d7e1486e2f90f18008f13e9c1bf5893c5f8b7", @"/Index.cshtml")]
    #nullable restore
    public class Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div id=\"User\" style=\"display:none;\" data-email=\"");
#nullable restore
#line 4 "C:\Users\agunn\Code\Northwind-Identity-FP\Index.cshtml"
                                            Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n    data-customer=\"");
#nullable restore
#line 5 "C:\Users\agunn\Code\Northwind-Identity-FP\Index.cshtml"
              Write(User.IsInRole("northwind-customer"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""></div>
<table class=""table table-hover"">
    <thead>
        <tr>
            <th scope=""col"">
                <div class=""form-row"">
                    <div class=""form-group col-md-8 mb-0"">
                        <select class=""form-control form-control-sm"" id=""CategoryId"">
");
#nullable restore
#line 13 "C:\Users\agunn\Code\Northwind-Identity-FP\Index.cshtml"
                             foreach (Category c in Model)
                            {
                                if (c.CategoryId == ViewBag.id)
                                { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option");
            BeginWriteAttribute("value", " value=\"", 706, "\"", 727, 1);
#nullable restore
#line 17 "C:\Users\agunn\Code\Northwind-Identity-FP\Index.cshtml"
WriteAttributeValue("", 714, c.CategoryId, 714, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 17 "C:\Users\agunn\Code\Northwind-Identity-FP\Index.cshtml"
                                                                      Write(c.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 18 "C:\Users\agunn\Code\Northwind-Identity-FP\Index.cshtml"
                                }
                                else
                                { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <option");
            BeginWriteAttribute("value", " value=\"", 916, "\"", 937, 1);
#nullable restore
#line 21 "C:\Users\agunn\Code\Northwind-Identity-FP\Index.cshtml"
WriteAttributeValue("", 924, c.CategoryId, 924, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "C:\Users\agunn\Code\Northwind-Identity-FP\Index.cshtml"
                                                             Write(c.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 22 "C:\Users\agunn\Code\Northwind-Identity-FP\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </select>
                    </div>
                    <div class=""form-group col-md-4 mb-0"">
                        <div class=""form-check text-right"">
                            <input class=""form-check-input"" type=""checkbox"" id=""Discontinued"">
                            <label class=""form-check-label"" for=""Discontinued"">Discontinued</label>
                        </div>
                    </div>
                </div>
            </th>
            <th scope=""col"" class=""text-right"">Price ($)</th>
            <th scope=""col"" class=""text-right"">Stock</th>
        </tr>
    </thead>
    <tbody id=""product_rows"" data-id=""");
#nullable restore
#line 38 "C:\Users\agunn\Code\Northwind-Identity-FP\Index.cshtml"
                                 Write(ViewBag.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""></tbody>
</table>
<!-- cart item modal -->
<div id=""cartModal"" class=""modal fade"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Add to Cart?</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div style=""display:none;"" id=""ProductId""></div>
                <div class=""row"">
                    <div class=""col col-xs-5""><strong>Product</strong></div>
                    <div class=""col col-xs-2 text-right""><strong>Price</strong></div>
                    <div class=""col col-xs-2""><strong>Quantity</strong></div>
                    <div class=""col col-xs-3 text-right""><strong>Total</strong></div>
                </div>
                <div class=");
            WriteLiteral(@"""row"">
                    <div class=""col col-xs-5 pt-2"" id=""ProductName"">Cool Product</div>
                    <div class=""col col-xs-2 pt-2 text-right"">
                        $<span id=""UnitPrice"">9.99</span>
                    </div>
                    <div class=""col col-xs-2"">
                        <input type=""number"" min=""1"" value=""1"" id=""Quantity"" class=""form-control"" />
                    </div>
                    <div class=""col col-xs-3 pt-2 text-right"">
                        $<span id=""Total"">0.00</span>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                <button type=""button"" class=""btn btn-primary"" id=""addToCart"">Continue</button>
            </div>
        </div>
    </div>
</div>
<!-- toast -->
<!-- Flexbox container for aligning the toasts -->
<div id=""cart_toast"" class=""toast bg-info text");
            WriteLiteral(@"-light"" role=""alert"" aria-live=""assertive"" aria-atomic=""true""
    style=""position: fixed;top: 65px;right: 10px;"">
    <div class=""toast-header"">
        <strong id=""toast_header"">This is a toast header</strong>
    </div>
    <div class=""toast-body"" id=""toast_body"">
        This is a toast message.
    </div>
</div>
");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n<script src=\"../../js/product.js\"></script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
