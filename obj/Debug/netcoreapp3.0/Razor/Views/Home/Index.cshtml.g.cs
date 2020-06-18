#pragma checksum "E:\Demo\DropdownWithSearch\DropDownWithSearch\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "804a22a7ac9d47c3623d6589d4290df14c898162"
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
#line 1 "E:\Demo\DropdownWithSearch\DropDownWithSearch\Views\_ViewImports.cshtml"
using DropDownWithSearch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Demo\DropdownWithSearch\DropDownWithSearch\Views\_ViewImports.cshtml"
using DropDownWithSearch.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"804a22a7ac9d47c3623d6589d4290df14c898162", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d4166ccf5632e0c399a0500906f8f6bece18ac3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DropDownWithSearch.Models.ViewModel.ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "E:\Demo\DropdownWithSearch\DropDownWithSearch\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Employee List";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "804a22a7ac9d47c3623d6589d4290df14c8981623752", async() => {
                WriteLiteral("\r\n    <div>\r\n        <table class=\"table table-borderless\">\r\n            <tr class=\"table-secondary\">\r\n                <td style=\"width:150px\">\r\n                    Institution : \r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 16 "E:\Demo\DropdownWithSearch\DropDownWithSearch\Views\Home\Index.cshtml"
               Write(Html.DropDownList("institution", new SelectList(Model.institution, "Id", "InsName"), "-Select Institution-"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr class=\"table-secondary\">\r\n                <td>\r\n                    Department :  \r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 24 "E:\Demo\DropdownWithSearch\DropDownWithSearch\Views\Home\Index.cshtml"
               Write(Html.DropDownList("department", new SelectList(Model.department, "Id", "DeptName"), "-Select Deprtment-"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    <input type=\"submit\" value=\"Search\" class=\"btn btn-primary\" />\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n    <div>\r\n");
#nullable restore
#line 35 "E:\Demo\DropdownWithSearch\DropDownWithSearch\Views\Home\Index.cshtml"
         if (Model.employeeList.Count() > 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <table class=\"table table-striped\">\r\n                <tr>\r\n                    <th>Employee Name</th>\r\n                    <th>Department</th>\r\n                    <th>Institution</th>\r\n                </tr>\r\n\r\n");
#nullable restore
#line 44 "E:\Demo\DropdownWithSearch\DropDownWithSearch\Views\Home\Index.cshtml"
                 foreach (var item in Model.employeeList)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 48 "E:\Demo\DropdownWithSearch\DropDownWithSearch\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(e => item.EmpName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 51 "E:\Demo\DropdownWithSearch\DropDownWithSearch\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(e => item.InsName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 54 "E:\Demo\DropdownWithSearch\DropDownWithSearch\Views\Home\Index.cshtml"
                       Write(Html.DisplayFor(e => item.DeptName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 57 "E:\Demo\DropdownWithSearch\DropDownWithSearch\Views\Home\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n");
#nullable restore
#line 60 "E:\Demo\DropdownWithSearch\DropDownWithSearch\Views\Home\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <p>No employee exist...!!!</p>\r\n");
#nullable restore
#line 64 "E:\Demo\DropdownWithSearch\DropDownWithSearch\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DropDownWithSearch.Models.ViewModel.ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
