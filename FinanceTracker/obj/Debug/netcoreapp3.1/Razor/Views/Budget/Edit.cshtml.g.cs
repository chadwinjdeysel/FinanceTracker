#pragma checksum "C:\Projects\FinanceTracker\FinanceTracker\Views\Budget\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efd3216f9dd00f5f501f5527c867d786974fe28d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Budget_Edit), @"mvc.1.0.view", @"/Views/Budget/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efd3216f9dd00f5f501f5527c867d786974fe28d", @"/Views/Budget/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7afca9de6cef832f0f3132aa2911dd1bcb06f321", @"/Views/_ViewImports.cshtml")]
    public class Views_Budget_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EditBudgetViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projects\FinanceTracker\FinanceTracker\Views\Budget\Edit.cshtml"
  
    ViewData["Title"] = "Edit Your Budget";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <style>\r\n        .color-ball {\r\n            height: 20px;\r\n            width: 20px;\r\n            margin: 5px;\r\n            border-radius: 50%\r\n        }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efd3216f9dd00f5f501f5527c867d786974fe28d4731", async() => {
                WriteLiteral("\r\n\r\n    <input hidden\r\n           name=\"BudgetId\"");
                BeginWriteAttribute("value", "\r\n           value=\"", 375, "\"", 410, 1);
#nullable restore
#line 24 "C:\Projects\FinanceTracker\FinanceTracker\Views\Budget\Edit.cshtml"
WriteAttributeValue("", 395, Model.BudgetId, 395, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 27 "C:\Projects\FinanceTracker\FinanceTracker\Views\Budget\Edit.cshtml"
         foreach (var item in Model.TotalsForTheMonth)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"form-group col-6\">\r\n                <label>\r\n                    <div class=\"row justify-content-around\">\r\n                        <div class=\"color-ball\"");
                BeginWriteAttribute("style", " style=\"", 686, "\"", 731, 2);
                WriteAttributeValue("", 694, "background-color:", 694, 17, true);
#nullable restore
#line 32 "C:\Projects\FinanceTracker\FinanceTracker\Views\Budget\Edit.cshtml"
WriteAttributeValue(" ", 711, item.Key.ColorCode, 712, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                        ");
#nullable restore
#line 33 "C:\Projects\FinanceTracker\FinanceTracker\Views\Budget\Edit.cshtml"
                   Write(item.Key.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </label>\r\n\r\n                <input class=\"form-control\"");
                BeginWriteAttribute("name", "\r\n                       name=\"", 880, "\"", 923, 1);
#nullable restore
#line 38 "C:\Projects\FinanceTracker\FinanceTracker\Views\Budget\Edit.cshtml"
WriteAttributeValue("", 911, item.Key.Id, 911, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                       type=\"text\"");
                BeginWriteAttribute("value", "\r\n                       value=\"", 960, "\"", 1003, 1);
#nullable restore
#line 40 "C:\Projects\FinanceTracker\FinanceTracker\Views\Budget\Edit.cshtml"
WriteAttributeValue("", 992, item.Value, 992, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n");
#nullable restore
#line 42 "C:\Projects\FinanceTracker\FinanceTracker\Views\Budget\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n\r\n    <button class=\"btn btn-primary\"\r\n            type=\"submit\">\r\n        Edit Budget\r\n    </button>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $("".form-control"").on(""input"", function (evt) {
            var self = $(this);
            self.val(self.val().replace(/[^0-9\.]/g, ''));
            if ((evt.which != 46 || self.val().indexOf('.') != -1) && (evt.which < 48 || evt.which > 57)) {
                evt.preventDefault();
            }
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EditBudgetViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591