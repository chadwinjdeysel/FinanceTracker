#pragma checksum "C:\Projects\FinanceTracker\FinanceTracker\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dee9c68908c43a5fbdec3d4e58a204042405a6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Projects\FinanceTracker\FinanceTracker\Views\_ViewImports.cshtml"
using FinanceTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\FinanceTracker\FinanceTracker\Views\_ViewImports.cshtml"
using FinanceTracker.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\FinanceTracker\FinanceTracker\Views\_ViewImports.cshtml"
using FinanceTracker.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Projects\FinanceTracker\FinanceTracker\Views\_ViewImports.cshtml"
using FinanceTracker.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6dee9c68908c43a5fbdec3d4e58a204042405a6f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7afca9de6cef832f0f3132aa2911dd1bcb06f321", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\FinanceTracker\FinanceTracker\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <style>
        .item1 {
            grid-area: card-1;
        }

        .item2 {
            grid-area: card-2;
        }

        .item3 {
            grid-area: card-3;
        }

        .item4 {
            grid-area: card-4;
        }

        .item5 {
            grid-area: card-5;
        }


        .grid-container {
            display: grid;
            grid-template-areas: 
                'card-1 card-1 card-2'
                'card-1 card-1 card-2'
                'card-3 card-4 card-2'
                'card-3 card-4 card-2'
                'card-3 card-4 card-2'
                'card-3 card-5 card-2';
            grid-template-rows: 1fr 1fr 1fr 1fr 1fr 1fr;
            grid-template-columns: 1fr 1fr 1fr;
            height: 88vh;
            grid-gap: 1em;
        }

            .grid-container>div{
                min-width: 0;
            }

        body{
            overflow-y: hidden;
        }
    </style>
");
            }
            );
            WriteLiteral("\r\n<div class=\"grid-container\">\r\n    <div class=\"item1\">\r\n        ");
#nullable restore
#line 55 "C:\Projects\FinanceTracker\FinanceTracker\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("ExpenseSavingsCard"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n    </div>\r\n\r\n    <div class=\"item2\">\r\n        ");
#nullable restore
#line 59 "C:\Projects\FinanceTracker\FinanceTracker\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("CategoryExpensesCard"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n    </div>\r\n\r\n    <div class=\"item3\">\r\n        ");
#nullable restore
#line 63 "C:\Projects\FinanceTracker\FinanceTracker\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("BudgetUsedCard"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n    </div>\r\n\r\n    <div class=\"item4\">\r\n        ");
#nullable restore
#line 67 "C:\Projects\FinanceTracker\FinanceTracker\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("SavingsGoalCard"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n    </div>\r\n\r\n    <div class=\"item5\">\r\n        <div class=\"card h-100 shadow-sm\">\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
