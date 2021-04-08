#pragma checksum "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b89ad421316acd108dae1efb039eaff124c18b29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Budget__SpendingMonthPartial), @"mvc.1.0.view", @"/Views/Budget/_SpendingMonthPartial.cshtml")]
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
#line 1 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\_ViewImports.cshtml"
using Budget_Tracker_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\_ViewImports.cshtml"
using Budget_Tracker_App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b89ad421316acd108dae1efb039eaff124c18b29", @"/Views/Budget/_SpendingMonthPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21ddf9a61d92040ac526bee8e6da6cc3c6d685ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Budget__SpendingMonthPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Budget_Tracker_App.ViewModels.UserNameSpendingViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
  decimal sum = @Model.spendings.Select(x => x.SpendAmount).Sum();

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
  decimal salary = Model.Salary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
  decimal difference = @salary - @sum;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"styled-table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Income</th>\r\n            <th>Spend Amount($)</th>\r\n            <th>Difference</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 16 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
       Write(salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 17 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
       Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 18 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
         if (salary == 0 && sum==0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td style=\"color:green\">");
#nullable restore
#line 20 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
                               Write(difference);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 21 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
        }
        else if (sum >= salary)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td style=\"color:red\">");
#nullable restore
#line 24 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
                             Write(difference);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 25 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
        }
        else if (salary / 2 < sum)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td style=\"color:orange\">");
#nullable restore
#line 28 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
                                Write(difference);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 29 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td style=\"color:green\">");
#nullable restore
#line 32 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
                               Write(difference);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 33 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n</table>\r\n\r\n<table class=\"styled-table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Category</th>\r\n            <th>Spend Amount($)</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n");
#nullable restore
#line 45 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
     foreach (var item in Model.spendings)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 48 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
           Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 49 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
           Write(item.SpendAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 50 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
           Write(item.Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 52 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>Total</td>\r\n\r\n");
#nullable restore
#line 56 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
         if (salary == 0 && sum == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td style=\"color:green\">You Spent ");
#nullable restore
#line 58 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
                                         Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $. Very good!</td>\r\n");
#nullable restore
#line 59 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
        }
        else if (sum >= salary)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td style=\"color:red\">You Spent ");
#nullable restore
#line 62 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
                                       Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $. You must spend less!</td>\r\n");
#nullable restore
#line 63 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
        }
        else if (salary / 2 < sum)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td style=\"color:orange\">You Spent ");
#nullable restore
#line 66 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
                                          Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $. It\'s normal, but try spend less money!</td>\r\n");
#nullable restore
#line 67 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td style=\"color:green\">You Spent ");
#nullable restore
#line 70 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
                                         Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $. Very good!</td>\r\n");
#nullable restore
#line 71 "C:\Users\Volod\source\repos\Budget Tracker App\Budget Tracker App\Views\Budget\_SpendingMonthPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tr>\r\n</table>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Budget_Tracker_App.ViewModels.UserNameSpendingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
