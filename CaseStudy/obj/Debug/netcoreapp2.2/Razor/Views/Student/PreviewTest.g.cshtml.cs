#pragma checksum "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "916abed88ee8867e2434a7d6dfb1152f2d909569"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_PreviewTest), @"mvc.1.0.view", @"/Views/Student/PreviewTest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/PreviewTest.cshtml", typeof(AspNetCore.Views_Student_PreviewTest))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"916abed88ee8867e2434a7d6dfb1152f2d909569", @"/Views/Student/PreviewTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed97f03465a014740c128c8c7ba5c10f4e5d1ac9", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_PreviewTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 3 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
  
    var list = Model as List<StudentQuestViewModel>;
    ViewBag.Title = "Chi Tiết Bài Thi " + list.First().test.test_code;
    var score = ViewBag.score as score;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(225, 39, true);
            WriteLiteral("<div class=\"title-content\">\r\n    <span>");
            EndContext();
            BeginContext(265, 13, false);
#line 10 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
     Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(278, 188, true);
            WriteLiteral("</span>\r\n</div>\r\n\r\n<div class=\"content row col s12 reset-margin\" style=\"padding:0\" >\r\n    <span class=\"title\">\r\n        Số câu trả lời đúng:\r\n        <b style=\"color:red; font-size:20px;\">");
            EndContext();
            BeginContext(467, 12, false);
#line 16 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                         Write(score.detail);

#line default
#line hidden
            EndContext();
            BeginContext(479, 119, true);
            WriteLiteral("</b>\r\n    </span>   \r\n    <span class=\"title\">Điểm: </span>\r\n    <span>\r\n        <b style=\"color:red; font-size:20px;\">");
            EndContext();
            BeginContext(599, 18, false);
#line 20 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                         Write(score.score_number);

#line default
#line hidden
            EndContext();
            BeginContext(617, 36, true);
            WriteLiteral("</b>\r\n    </span>\r\n    \r\n </div>  \r\n");
            EndContext();
#line 24 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
      
        int x = 1;
        foreach (var item in list)
        {

#line default
#line hidden
            BeginContext(728, 16, true);
            WriteLiteral("            <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 744, "\"", 757, 2);
            WriteAttributeValue("", 749, "quest-", 749, 6, true);
#line 28 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
WriteAttributeValue("", 755, x, 755, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(758, 86, true);
            WriteLiteral(" class=\"item-quest\" style=\"clear:both\">\r\n                <div class=\"quest-title\">Câu ");
            EndContext();
            BeginContext(845, 1, false);
#line 29 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                        Write(x);

#line default
#line hidden
            EndContext();
            BeginContext(846, 81, true);
            WriteLiteral(" :</div>\r\n                <div class=\"quest-content\">\r\n                    <span>");
            EndContext();
            BeginContext(928, 21, false);
#line 31 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                     Write(item.question.content);

#line default
#line hidden
            EndContext();
            BeginContext(949, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
            BeginContext(1277, 158, true);
            WriteLiteral("                </div>\r\n                <div class=\"quest-answer\">\r\n                    <div>\r\n                        \r\n                            <label>\r\n");
            EndContext();
#line 42 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                 if (item.student_test.student_answer != null && item.student_test.student_answer.Trim().Equals(item.student_test.answer_a.Trim()) && item.student_test.student_answer.Trim().Equals(item.question.correct_answer.Trim()))
                                {

#line default
#line hidden
            BeginContext(1722, 42, true);
            WriteLiteral("                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 1764, "\"", 1797, 1);
#line 44 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
WriteAttributeValue("", 1771, item.question.id_question, 1771, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1798, 97, true);
            WriteLiteral(" type=\"radio\" checked disabled />\r\n                                    <span style=\"color:green\">");
            EndContext();
            BeginContext(1896, 26, false);
#line 45 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                                         Write(item.student_test.answer_a);

#line default
#line hidden
            EndContext();
            BeginContext(1922, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 46 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                }
                                else
                                {
                                    if (item.student_test.student_answer != null && item.student_test.student_answer.Trim().Equals(item.student_test.answer_a.Trim()) && !item.student_test.student_answer.Trim().Equals(item.question.correct_answer.Trim()))
                                    {

#line default
#line hidden
            BeginContext(2334, 46, true);
            WriteLiteral("                                        <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2380, "\"", 2413, 1);
#line 51 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
WriteAttributeValue("", 2387, item.question.id_question, 2387, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2414, 99, true);
            WriteLiteral(" type=\"radio\" checked disabled />\r\n                                        <span style=\"color:red\">");
            EndContext();
            BeginContext(2514, 26, false);
#line 52 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                                           Write(item.student_test.answer_a);

#line default
#line hidden
            EndContext();
            BeginContext(2540, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 53 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                    }
                                    else
                                    {
                                        if (item.student_test.answer_a.Trim().Equals(item.question.correct_answer.Trim()))
                                        {

#line default
#line hidden
            BeginContext(2836, 50, true);
            WriteLiteral("                                            <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 2886, "\"", 2919, 1);
#line 58 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
WriteAttributeValue("", 2893, item.question.id_question, 2893, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2920, 105, true);
            WriteLiteral(" type=\"radio\" checked disabled />\r\n                                            <span style=\"color:green\">");
            EndContext();
            BeginContext(3026, 26, false);
#line 59 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                                                 Write(item.student_test.answer_a);

#line default
#line hidden
            EndContext();
            BeginContext(3052, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 60 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(3193, 50, true);
            WriteLiteral("                                            <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 3243, "\"", 3276, 1);
#line 63 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
WriteAttributeValue("", 3250, item.question.id_question, 3250, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3277, 77, true);
            WriteLiteral(" type=\"radio\" disabled />\r\n                                            <span>");
            EndContext();
            BeginContext(3355, 26, false);
#line 64 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                             Write(item.student_test.answer_a);

#line default
#line hidden
            EndContext();
            BeginContext(3381, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 65 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                        }
                                    }
                                }

#line default
#line hidden
            BeginContext(3507, 182, true);
            WriteLiteral("                            </label>\r\n                        \r\n                    </div>\r\n                    <div>\r\n                        \r\n                            <label>\r\n");
            EndContext();
#line 74 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                 if (item.student_test.student_answer != null && item.student_test.student_answer.Trim().Equals(item.student_test.answer_b.Trim()) && item.student_test.student_answer.Trim().Equals(item.question.correct_answer.Trim()))
                                {

#line default
#line hidden
            BeginContext(3976, 42, true);
            WriteLiteral("                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 4018, "\"", 4051, 1);
#line 76 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
WriteAttributeValue("", 4025, item.question.id_question, 4025, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4052, 97, true);
            WriteLiteral(" type=\"radio\" checked disabled />\r\n                                    <span style=\"color:green\">");
            EndContext();
            BeginContext(4150, 26, false);
#line 77 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                                         Write(item.student_test.answer_b);

#line default
#line hidden
            EndContext();
            BeginContext(4176, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 78 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                }
                                else
                                {
                                    if (item.student_test.student_answer != null && item.student_test.student_answer.Trim().Equals(item.student_test.answer_b.Trim()) && !item.student_test.student_answer.Trim().Equals(item.question.correct_answer.Trim()))
                                    {

#line default
#line hidden
            BeginContext(4588, 46, true);
            WriteLiteral("                                        <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 4634, "\"", 4667, 1);
#line 83 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
WriteAttributeValue("", 4641, item.question.id_question, 4641, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4668, 99, true);
            WriteLiteral(" type=\"radio\" checked disabled />\r\n                                        <span style=\"color:red\">");
            EndContext();
            BeginContext(4768, 26, false);
#line 84 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                                           Write(item.student_test.answer_b);

#line default
#line hidden
            EndContext();
            BeginContext(4794, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 85 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                    }
                                    else
                                    {
                                        if (item.student_test.answer_b.Trim().Equals(item.question.correct_answer.Trim()))
                                        {

#line default
#line hidden
            BeginContext(5090, 50, true);
            WriteLiteral("                                            <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 5140, "\"", 5173, 1);
#line 90 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
WriteAttributeValue("", 5147, item.question.id_question, 5147, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5174, 105, true);
            WriteLiteral(" type=\"radio\" checked disabled />\r\n                                            <span style=\"color:green\">");
            EndContext();
            BeginContext(5280, 26, false);
#line 91 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                                                 Write(item.student_test.answer_b);

#line default
#line hidden
            EndContext();
            BeginContext(5306, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 92 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(5447, 50, true);
            WriteLiteral("                                            <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 5497, "\"", 5530, 1);
#line 95 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
WriteAttributeValue("", 5504, item.question.id_question, 5504, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5531, 77, true);
            WriteLiteral(" type=\"radio\" disabled />\r\n                                            <span>");
            EndContext();
            BeginContext(5609, 26, false);
#line 96 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                             Write(item.student_test.answer_b);

#line default
#line hidden
            EndContext();
            BeginContext(5635, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 97 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                        }
                                    }
                                }

#line default
#line hidden
            BeginContext(5761, 182, true);
            WriteLiteral("                            </label>\r\n                        \r\n                    </div>\r\n                    <div>\r\n                        \r\n                            <label>\r\n");
            EndContext();
#line 106 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                 if (item.student_test.student_answer != null && item.student_test.student_answer.Trim().Equals(item.student_test.answer_c.Trim()) && item.student_test.student_answer.Trim().Equals(item.question.correct_answer.Trim()))
                                {

#line default
#line hidden
            BeginContext(6230, 42, true);
            WriteLiteral("                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 6272, "\"", 6305, 1);
#line 108 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
WriteAttributeValue("", 6279, item.question.id_question, 6279, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6306, 97, true);
            WriteLiteral(" type=\"radio\" checked disabled />\r\n                                    <span style=\"color:green\">");
            EndContext();
            BeginContext(6404, 26, false);
#line 109 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                                         Write(item.student_test.answer_c);

#line default
#line hidden
            EndContext();
            BeginContext(6430, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 110 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                }
                                else
                                {
                                    if (item.student_test.student_answer != null && item.student_test.student_answer.Trim().Equals(item.student_test.answer_c.Trim()) && !item.student_test.student_answer.Trim().Equals(item.question.correct_answer.Trim()))
                                    {

#line default
#line hidden
            BeginContext(6842, 46, true);
            WriteLiteral("                                        <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 6888, "\"", 6921, 1);
#line 115 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
WriteAttributeValue("", 6895, item.question.id_question, 6895, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6922, 99, true);
            WriteLiteral(" type=\"radio\" checked disabled />\r\n                                        <span style=\"color:red\">");
            EndContext();
            BeginContext(7022, 26, false);
#line 116 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                                           Write(item.student_test.answer_c);

#line default
#line hidden
            EndContext();
            BeginContext(7048, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 117 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                    }
                                    else
                                    {
                                        if (item.student_test.answer_c.Trim().Equals(item.question.correct_answer.Trim()))
                                        {

#line default
#line hidden
            BeginContext(7344, 50, true);
            WriteLiteral("                                            <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 7394, "\"", 7427, 1);
#line 122 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
WriteAttributeValue("", 7401, item.question.id_question, 7401, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7428, 105, true);
            WriteLiteral(" type=\"radio\" checked disabled />\r\n                                            <span style=\"color:green\">");
            EndContext();
            BeginContext(7534, 26, false);
#line 123 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                                                 Write(item.student_test.answer_c);

#line default
#line hidden
            EndContext();
            BeginContext(7560, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 124 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(7701, 50, true);
            WriteLiteral("                                            <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 7751, "\"", 7784, 1);
#line 127 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
WriteAttributeValue("", 7758, item.question.id_question, 7758, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7785, 77, true);
            WriteLiteral(" type=\"radio\" disabled />\r\n                                            <span>");
            EndContext();
            BeginContext(7863, 26, false);
#line 128 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                             Write(item.student_test.answer_c);

#line default
#line hidden
            EndContext();
            BeginContext(7889, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 129 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                        }
                                    }
                                }

#line default
#line hidden
            BeginContext(8015, 182, true);
            WriteLiteral("                            </label>\r\n                        \r\n                    </div>\r\n                    <div>\r\n                        \r\n                            <label>\r\n");
            EndContext();
#line 138 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                 if (item.student_test.student_answer != null && item.student_test.student_answer.Trim().Equals(item.student_test.answer_d.Trim()) && item.student_test.student_answer.Trim().Equals(item.question.correct_answer.Trim()))
                                {

#line default
#line hidden
            BeginContext(8484, 42, true);
            WriteLiteral("                                    <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 8526, "\"", 8559, 1);
#line 140 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
WriteAttributeValue("", 8533, item.question.id_question, 8533, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8560, 97, true);
            WriteLiteral(" type=\"radio\" checked disabled />\r\n                                    <span style=\"color:green\">");
            EndContext();
            BeginContext(8658, 26, false);
#line 141 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                                         Write(item.student_test.answer_d);

#line default
#line hidden
            EndContext();
            BeginContext(8684, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 142 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                }
                                else
                                {
                                    if (item.student_test.student_answer != null && item.student_test.student_answer.Trim().Equals(item.student_test.answer_d.Trim()) && !item.student_test.student_answer.Trim().Equals(item.question.correct_answer.Trim()))
                                    {

#line default
#line hidden
            BeginContext(9096, 46, true);
            WriteLiteral("                                        <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 9142, "\"", 9175, 1);
#line 147 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
WriteAttributeValue("", 9149, item.question.id_question, 9149, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9176, 99, true);
            WriteLiteral(" type=\"radio\" checked disabled />\r\n                                        <span style=\"color:red\">");
            EndContext();
            BeginContext(9276, 26, false);
#line 148 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                                           Write(item.student_test.answer_d);

#line default
#line hidden
            EndContext();
            BeginContext(9302, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 149 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                    }
                                    else
                                    {
                                        if (item.student_test.answer_d.Trim().Equals(item.question.correct_answer.Trim()))
                                        {

#line default
#line hidden
            BeginContext(9598, 50, true);
            WriteLiteral("                                            <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 9648, "\"", 9681, 1);
#line 154 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
WriteAttributeValue("", 9655, item.question.id_question, 9655, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9682, 105, true);
            WriteLiteral(" type=\"radio\" checked disabled />\r\n                                            <span style=\"color:green\">");
            EndContext();
            BeginContext(9788, 26, false);
#line 155 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                                                 Write(item.student_test.answer_d);

#line default
#line hidden
            EndContext();
            BeginContext(9814, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 156 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(9955, 50, true);
            WriteLiteral("                                            <input");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 10005, "\"", 10038, 1);
#line 159 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
WriteAttributeValue("", 10012, item.question.id_question, 10012, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(10039, 77, true);
            WriteLiteral(" type=\"radio\" disabled />\r\n                                            <span>");
            EndContext();
            BeginContext(10117, 26, false);
#line 160 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                             Write(item.student_test.answer_d);

#line default
#line hidden
            EndContext();
            BeginContext(10143, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 161 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
                                        }
                                    }
                                }

#line default
#line hidden
            BeginContext(10269, 136, true);
            WriteLiteral("                            </label>\r\n                        \r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 169 "D:\Module 2\New folder\CaseStudyphucxl\CaseStudy\CaseStudy\Views\Student\PreviewTest.cshtml"
            x = x + 1;
        }
    

#line default
#line hidden
            BeginContext(10447, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
