#pragma checksum "C:\Projects\FinanceTracker\financetracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "323802f5a8989d14be4203c9191c77b8caed905f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BudgetUsedCard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BudgetUsedCard/Default.cshtml")]
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
#line 1 "C:\Projects\FinanceTracker\financetracker\Views\_ViewImports.cshtml"
using FinanceTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\FinanceTracker\financetracker\Views\_ViewImports.cshtml"
using FinanceTracker.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\FinanceTracker\financetracker\Views\_ViewImports.cshtml"
using FinanceTracker.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\FinanceTracker\financetracker\Views\_ViewImports.cshtml"
using FinanceTracker.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"323802f5a8989d14be4203c9191c77b8caed905f", @"/Views/Shared/Components/BudgetUsedCard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7afca9de6cef832f0f3132aa2911dd1bcb06f321", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BudgetUsedCard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BudgetUsedViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Budget", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-larger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card h-100 shadow-sm\">\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Projects\FinanceTracker\financetracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
     if (Model.CategoriesInBudget > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""dropdown dropleft card-menu"">
            <a class=""text-muted""
               href=""#""
               role=""button""
               id=""dropdownMenu""
               data-toggle=""dropdown""
               aria-haspopup=""true""
               aria-expanded=""false"">
                <span class=""oi oi-ellipses"" style=""transform: rotate(90deg)""></span>
            </a>

            <div class=""dropdown-menu shadow-sm"" aria-labelledby=""dropdownMenu"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "323802f5a8989d14be4203c9191c77b8caed905f6284", async() => {
                WriteLiteral("\r\n                    View Details\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "323802f5a8989d14be4203c9191c77b8caed905f7798", async() => {
                WriteLiteral("\r\n                    Edit Budget\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Projects\FinanceTracker\financetracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
                     WriteLiteral(Model.BudgetId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral(@"        <div class=""card-body"">

            <p class=""text-larger text-center my-0"">Budget Used</p>
            <p class=""text-center text-muted my-0""><small>this month</small></p>

            <div class=""col-8 mx-auto my-1"">
                <canvas id=""budgetUsedChart"" width=""100%"" height=""100%""></canvas>

                <div class=""doughnut-inner"" style=""margin-top: -140px"">
                    <h2 class=""text-center display-4"">");
#nullable restore
#line 44 "C:\Projects\FinanceTracker\financetracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
                                                 Write(Model.PercentageUsed);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</h2>\r\n                </div>\r\n            </div>\r\n\r\n\r\n            <div class=\"row\" style=\"margin-top: 70px\">\r\n                <div class=\"col-6\">\r\n                    <div>\r\n                        <h1 class=\"display-4 text-center text-primary my-0\">");
#nullable restore
#line 52 "C:\Projects\FinanceTracker\financetracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
                                                                       Write(Model.CategoriesInBudget);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

                        <p class=""m-0 text-center"">Categories</p>
                        <p class=""m-0 text-center text-muted""><small>used in budget</small></p>
                    </div>
                </div>

                <div class=""col-6"">
                    <h1 class=""display-4 text-center text-danger my-0"">");
#nullable restore
#line 60 "C:\Projects\FinanceTracker\financetracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
                                                                  Write(Model.CategoriesOverBudget);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n                    <p class=\"m-0 text-center\">Categories</p>\r\n                    <p class=\"m-0 text-center text-muted\"><small>over budget</small></p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 67 "C:\Projects\FinanceTracker\financetracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card-body text-center\">\r\n            <p class=\"text-muted m-0\">No budget has been set for this month</p>\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "323802f5a8989d14be4203c9191c77b8caed905f12980", async() => {
                WriteLiteral("\r\n                create budget for ");
#nullable restore
#line 76 "C:\Projects\FinanceTracker\financetracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
                             Write(DateTime.Now.ToString("MMMM"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 79 "C:\Projects\FinanceTracker\financetracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 83 "C:\Projects\FinanceTracker\financetracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
 if (Model.CategoriesInBudget > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n    var ctx = document.getElementById(\'budgetUsedChart\').getContext(\'2d\');\r\n    var chart = new Chart(ctx, ");
#nullable restore
#line 87 "C:\Projects\FinanceTracker\financetracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
                          Write(Html.Raw(Json.Serialize(Model.Chart)));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n\r\n    </script>\r\n");
#nullable restore
#line 90 "C:\Projects\FinanceTracker\financetracker\Views\Shared\Components\BudgetUsedCard\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BudgetUsedViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
