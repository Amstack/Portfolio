#pragma checksum "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllNewInvoices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fad101e2f18f99d5e5d737edfffcea4fdbb7dd62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_GetAllNewInvoices), @"mvc.1.0.view", @"/Views/Invoice/GetAllNewInvoices.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoice/GetAllNewInvoices.cshtml", typeof(AspNetCore.Views_Invoice_GetAllNewInvoices))]
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
#line 1 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\_ViewImports.cshtml"
using EntitledSiteAlpha;

#line default
#line hidden
#line 2 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\_ViewImports.cshtml"
using EntitledSiteAlpha.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fad101e2f18f99d5e5d737edfffcea4fdbb7dd62", @"/Views/Invoice/GetAllNewInvoices.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e37e66e455607227fdf263ebc0ab0428e03622f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_GetAllNewInvoices : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntitledSiteAlpha.Models.InvoiceModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 86, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(146, 47, false);
#line 7 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllNewInvoices.cshtml"
           Write(Html.DisplayNameFor(model => model.InvoiceType));

#line default
#line hidden
            EndContext();
            BeginContext(193, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(249, 52, false);
#line 10 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllNewInvoices.cshtml"
           Write(Html.DisplayNameFor(model => model.InvoiceItemCount));

#line default
#line hidden
            EndContext();
            BeginContext(301, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(357, 51, false);
#line 13 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllNewInvoices.cshtml"
           Write(Html.DisplayNameFor(model => model.InvoiceItemName));

#line default
#line hidden
            EndContext();
            BeginContext(408, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(464, 45, false);
#line 16 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllNewInvoices.cshtml"
           Write(Html.DisplayNameFor(model => model.InvoiceID));

#line default
#line hidden
            EndContext();
            BeginContext(509, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(565, 47, false);
#line 19 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllNewInvoices.cshtml"
           Write(Html.DisplayNameFor(model => model.RequestUser));

#line default
#line hidden
            EndContext();
            BeginContext(612, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(668, 47, false);
#line 22 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllNewInvoices.cshtml"
           Write(Html.DisplayNameFor(model => model.ApproveUser));

#line default
#line hidden
            EndContext();
            BeginContext(715, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(771, 49, false);
#line 25 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllNewInvoices.cshtml"
           Write(Html.DisplayNameFor(model => model.InvoiceStatus));

#line default
#line hidden
            EndContext();
            BeginContext(820, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllNewInvoices.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(955, 40, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n");
            EndContext();
#line 35 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllNewInvoices.cshtml"
                     if (item.InvoiceType == 1)
                        {

#line default
#line hidden
            BeginContext(1075, 8, true);
            WriteLiteral("Donation");
            EndContext();
#line 36 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllNewInvoices.cshtml"
                                               }
                    else
                        { 

#line default
#line hidden
            BeginContext(1152, 7, true);
            WriteLiteral("Request");
            EndContext();
#line 38 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllNewInvoices.cshtml"
                                              }

#line default
#line hidden
            BeginContext(1169, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1235, 51, false);
#line 41 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllNewInvoices.cshtml"
               Write(Html.DisplayFor(modelItem => item.InvoiceItemCount));

#line default
#line hidden
            EndContext();
            BeginContext(1286, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1354, 50, false);
#line 44 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllNewInvoices.cshtml"
               Write(Html.DisplayFor(modelItem => item.InvoiceItemName));

#line default
#line hidden
            EndContext();
            BeginContext(1404, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1472, 44, false);
#line 47 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllNewInvoices.cshtml"
               Write(Html.DisplayFor(modelItem => item.InvoiceID));

#line default
#line hidden
            EndContext();
            BeginContext(1516, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1584, 46, false);
#line 50 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllNewInvoices.cshtml"
               Write(Html.DisplayFor(modelItem => item.RequestUser));

#line default
#line hidden
            EndContext();
            BeginContext(1630, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1698, 46, false);
#line 53 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllNewInvoices.cshtml"
               Write(Html.DisplayFor(modelItem => item.ApproveUser));

#line default
#line hidden
            EndContext();
            BeginContext(1744, 137, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    New\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1882, 73, false);
#line 59 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllNewInvoices.cshtml"
               Write(Html.ActionLink("Approve", "ApproveInvoice", new { id = item.InvoiceID }));

#line default
#line hidden
            EndContext();
            BeginContext(1955, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1980, 67, false);
#line 60 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllNewInvoices.cshtml"
               Write(Html.ActionLink("Deny", "DenyInvoice", new { id = item.InvoiceID }));

#line default
#line hidden
            EndContext();
            BeginContext(2047, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 63 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllNewInvoices.cshtml"
        }

#line default
#line hidden
            BeginContext(2102, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntitledSiteAlpha.Models.InvoiceModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
