#pragma checksum "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8bdbaa5f50e40853d8685386793f630f214dbea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_student_test_detail_Index), @"mvc.1.0.view", @"/Views/student_test_detail/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/student_test_detail/Index.cshtml", typeof(AspNetCore.Views_student_test_detail_Index))]
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
#line 1 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using CaseStudy;

#line default
#line hidden
#line 2 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using CaseStudy.Models;

#line default
#line hidden
#line 3 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using CaseStudy.ViewModels;

#line default
#line hidden
#line 4 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\_ViewImports.cshtml"
using CaseStudy.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8bdbaa5f50e40853d8685386793f630f214dbea", @"/Views/student_test_detail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed97f03465a014740c128c8c7ba5c10f4e5d1ac9", @"/Views/_ViewImports.cshtml")]
    public class Views_student_test_detail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CaseStudy.Model.student_test_detail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(129, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8bdbaa5f50e40853d8685386793f630f214dbea5151", async() => {
                BeginContext(152, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(166, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(259, 43, false);
#line 16 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.student));

#line default
#line hidden
            EndContext();
            BeginContext(302, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(358, 44, false);
#line 19 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.question));

#line default
#line hidden
            EndContext();
            BeginContext(402, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(458, 44, false);
#line 22 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.answer_a));

#line default
#line hidden
            EndContext();
            BeginContext(502, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(558, 44, false);
#line 25 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.answer_b));

#line default
#line hidden
            EndContext();
            BeginContext(602, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(658, 44, false);
#line 28 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.answer_c));

#line default
#line hidden
            EndContext();
            BeginContext(702, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(758, 44, false);
#line 31 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.answer_d));

#line default
#line hidden
            EndContext();
            BeginContext(802, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(858, 50, false);
#line 34 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.student_answer));

#line default
#line hidden
            EndContext();
            BeginContext(908, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(964, 45, false);
#line 37 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.test_code));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 43 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1127, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1176, 53, false);
#line 46 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.student.id_student));

#line default
#line hidden
            EndContext();
            BeginContext(1229, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1285, 55, false);
#line 49 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.question.id_question));

#line default
#line hidden
            EndContext();
            BeginContext(1340, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1396, 43, false);
#line 52 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.answer_a));

#line default
#line hidden
            EndContext();
            BeginContext(1439, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1495, 43, false);
#line 55 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.answer_b));

#line default
#line hidden
            EndContext();
            BeginContext(1538, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1594, 43, false);
#line 58 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.answer_c));

#line default
#line hidden
            EndContext();
            BeginContext(1637, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1693, 43, false);
#line 61 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.answer_d));

#line default
#line hidden
            EndContext();
            BeginContext(1736, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1792, 49, false);
#line 64 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.student_answer));

#line default
#line hidden
            EndContext();
            BeginContext(1841, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1897, 44, false);
#line 67 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.test_code));

#line default
#line hidden
            EndContext();
            BeginContext(1941, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1996, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8bdbaa5f50e40853d8685386793f630f214dbea14028", async() => {
                BeginContext(2041, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
                                       WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2049, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2069, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8bdbaa5f50e40853d8685386793f630f214dbea16392", async() => {
                BeginContext(2117, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
                                          WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2128, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2148, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8bdbaa5f50e40853d8685386793f630f214dbea18762", async() => {
                BeginContext(2195, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
                                         WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2205, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 75 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\student_test_detail\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2244, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CaseStudy.Model.student_test_detail>> Html { get; private set; }
    }
}
#pragma warning restore 1591