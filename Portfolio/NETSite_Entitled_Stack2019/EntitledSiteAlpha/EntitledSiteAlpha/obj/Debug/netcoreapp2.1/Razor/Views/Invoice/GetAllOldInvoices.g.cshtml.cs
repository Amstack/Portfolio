#pragma checksum "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbb4d74acad6ebb4bf88c87d4c7d6f564035be99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_GetAllOldInvoices), @"mvc.1.0.view", @"/Views/Invoice/GetAllOldInvoices.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Invoice/GetAllOldInvoices.cshtml", typeof(AspNetCore.Views_Invoice_GetAllOldInvoices))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbb4d74acad6ebb4bf88c87d4c7d6f564035be99", @"/Views/Invoice/GetAllOldInvoices.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e37e66e455607227fdf263ebc0ab0428e03622f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Invoice_GetAllOldInvoices : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntitledSiteAlpha.Models.InvoiceModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 86, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(146, 47, false);
#line 7 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml"
           Write(Html.DisplayNameFor(model => model.InvoiceType));

#line default
#line hidden
            EndContext();
            BeginContext(193, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(249, 51, false);
#line 10 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml"
           Write(Html.DisplayNameFor(model => model.InvoiceItemName));

#line default
#line hidden
            EndContext();
            BeginContext(300, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(356, 52, false);
#line 13 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml"
           Write(Html.DisplayNameFor(model => model.InvoiceItemCount));

#line default
#line hidden
            EndContext();
            BeginContext(408, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(464, 45, false);
#line 16 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml"
           Write(Html.DisplayNameFor(model => model.InvoiceID));

#line default
#line hidden
            EndContext();
            BeginContext(509, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(565, 47, false);
#line 19 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml"
           Write(Html.DisplayNameFor(model => model.RequestUser));

#line default
#line hidden
            EndContext();
            BeginContext(612, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(668, 47, false);
#line 22 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml"
           Write(Html.DisplayNameFor(model => model.ApproveUser));

#line default
#line hidden
            EndContext();
            BeginContext(715, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(771, 49, false);
#line 25 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml"
           Write(Html.DisplayNameFor(model => model.InvoiceStatus));

#line default
#line hidden
            EndContext();
            BeginContext(820, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(938, 32, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n");
            EndContext();
#line 34 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml"
                 if (item.InvoiceType == 1)
                    {

#line default
#line hidden
            BeginContext(1042, 8, true);
            WriteLiteral("Donation");
            EndContext();
#line 35 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml"
                                           }
                else
                    { 

#line default
#line hidden
            BeginContext(1111, 7, true);
            WriteLiteral("Request");
            EndContext();
#line 37 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml"
                                          }

#line default
#line hidden
            BeginContext(1128, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1182, 50, false);
#line 40 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml"
           Write(Html.DisplayFor(modelItem => item.InvoiceItemName));

#line default
#line hidden
            EndContext();
            BeginContext(1232, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1288, 51, false);
#line 43 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml"
           Write(Html.DisplayFor(modelItem => item.InvoiceItemCount));

#line default
#line hidden
            EndContext();
            BeginContext(1339, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1395, 44, false);
#line 46 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml"
           Write(Html.DisplayFor(modelItem => item.InvoiceID));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1495, 46, false);
#line 49 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml"
           Write(Html.DisplayFor(modelItem => item.RequestUser));

#line default
#line hidden
            EndContext();
            BeginContext(1541, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1597, 46, false);
#line 52 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml"
           Write(Html.DisplayFor(modelItem => item.ApproveUser));

#line default
#line hidden
            EndContext();
            BeginContext(1643, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 55 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml"
                 if (item.InvoiceType == 1)
                    {

#line default
#line hidden
            BeginContext(1754, 8, true);
            WriteLiteral("Approved");
            EndContext();
#line 56 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml"
                                           }
                else
                    { 

#line default
#line hidden
            BeginContext(1823, 6, true);
            WriteLiteral("Denied");
            EndContext();
#line 58 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml"
                                         }

#line default
#line hidden
            BeginContext(1839, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 61 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Invoice\GetAllOldInvoices.cshtml"
}

#line default
#line hidden
            BeginContext(1876, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
