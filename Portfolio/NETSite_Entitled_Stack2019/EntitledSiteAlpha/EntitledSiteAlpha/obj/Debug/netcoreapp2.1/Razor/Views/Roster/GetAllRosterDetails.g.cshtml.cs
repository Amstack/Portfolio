#pragma checksum "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Roster\GetAllRosterDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8691edeca9166b6198ce98bc087b13706e95c59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roster_GetAllRosterDetails), @"mvc.1.0.view", @"/Views/Roster/GetAllRosterDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Roster/GetAllRosterDetails.cshtml", typeof(AspNetCore.Views_Roster_GetAllRosterDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8691edeca9166b6198ce98bc087b13706e95c59", @"/Views/Roster/GetAllRosterDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e37e66e455607227fdf263ebc0ab0428e03622f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Roster_GetAllRosterDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntitledSiteAlpha.Models.RosterModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 86, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(145, 44, false);
#line 7 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Roster\GetAllRosterDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(189, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(245, 39, false);
#line 10 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Roster\GetAllRosterDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.dkp));

#line default
#line hidden
            EndContext();
            BeginContext(284, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(340, 48, false);
#line 13 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Roster\GetAllRosterDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.numDonations));

#line default
#line hidden
            EndContext();
            BeginContext(388, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 19 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Roster\GetAllRosterDetails.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(506, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(555, 43, false);
#line 22 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Roster\GetAllRosterDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(598, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(654, 38, false);
#line 25 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Roster\GetAllRosterDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.dkp));

#line default
#line hidden
            EndContext();
            BeginContext(692, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(748, 47, false);
#line 28 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Roster\GetAllRosterDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.numDonations));

#line default
#line hidden
            EndContext();
            BeginContext(795, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 31 "C:\Users\Amsta\source\repos\EntitledSiteAlpha\EntitledSiteAlpha\Views\Roster\GetAllRosterDetails.cshtml"
}

#line default
#line hidden
            BeginContext(834, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntitledSiteAlpha.Models.RosterModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
