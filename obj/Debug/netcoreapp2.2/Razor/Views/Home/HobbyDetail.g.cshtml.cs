#pragma checksum "C:\Users\Cho\Desktop\Coding Dojo\Belt Test\CS Belt Exam\BeltTest2\Views\Home\HobbyDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6397fdfef65084d672d8d84ac6564f2792c3746e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HobbyDetail), @"mvc.1.0.view", @"/Views/Home/HobbyDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/HobbyDetail.cshtml", typeof(AspNetCore.Views_Home_HobbyDetail))]
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
#line 1 "C:\Users\Cho\Desktop\Coding Dojo\Belt Test\CS Belt Exam\BeltTest2\Views\_ViewImports.cshtml"
using BeltTest2;

#line default
#line hidden
#line 2 "C:\Users\Cho\Desktop\Coding Dojo\Belt Test\CS Belt Exam\BeltTest2\Views\_ViewImports.cshtml"
using BeltTest2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6397fdfef65084d672d8d84ac6564f2792c3746e", @"/Views/Home/HobbyDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dfbcb051bf5c23501e68731518517c29af07689", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HobbyDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hobby>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Novice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Intermediate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Expert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "JoinHobby", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Cho\Desktop\Coding Dojo\Belt Test\CS Belt Exam\BeltTest2\Views\Home\HobbyDetail.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(61, 85, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1>Hobbies</h1>\r\n    <h3>Description:</h3>\r\n    <p>");
            EndContext();
            BeginContext(147, 17, false);
#line 10 "C:\Users\Cho\Desktop\Coding Dojo\Belt Test\CS Belt Exam\BeltTest2\Views\Home\HobbyDetail.cshtml"
  Write(Model.description);

#line default
#line hidden
            EndContext();
            BeginContext(164, 327, true);
            WriteLiteral(@"</p>

    <h3>Hiking Enthusiasts</h3>
    <div class=""enthusiasts"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Proficiency</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 22 "C:\Users\Cho\Desktop\Coding Dojo\Belt Test\CS Belt Exam\BeltTest2\Views\Home\HobbyDetail.cshtml"
             foreach(var i in Model.Hobbylist)
            {

#line default
#line hidden
            BeginContext(554, 58, true);
            WriteLiteral("                <tr>\r\n                    <td scope=\"row\">");
            EndContext();
            BeginContext(613, 16, false);
#line 25 "C:\Users\Cho\Desktop\Coding Dojo\Belt Test\CS Belt Exam\BeltTest2\Views\Home\HobbyDetail.cshtml"
                               Write(i.User.firstname);

#line default
#line hidden
            EndContext();
            BeginContext(629, 43, true);
            WriteLiteral("</td>\r\n                    <td scope=\"row\">");
            EndContext();
            BeginContext(673, 13, false);
#line 26 "C:\Users\Cho\Desktop\Coding Dojo\Belt Test\CS Belt Exam\BeltTest2\Views\Home\HobbyDetail.cshtml"
                               Write(i.proficiency);

#line default
#line hidden
            EndContext();
            BeginContext(686, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 28 "C:\Users\Cho\Desktop\Coding Dojo\Belt Test\CS Belt Exam\BeltTest2\Views\Home\HobbyDetail.cshtml"
            }

#line default
#line hidden
            BeginContext(731, 48, true);
            WriteLiteral("        </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
#line 32 "C:\Users\Cho\Desktop\Coding Dojo\Belt Test\CS Belt Exam\BeltTest2\Views\Home\HobbyDetail.cshtml"
     if(Model.Creator.id == ViewBag.thisuser.id)
    {

#line default
#line hidden
            BeginContext(836, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 846, "\"", 868, 2);
            WriteAttributeValue("", 853, "/Edit/", 853, 6, true);
#line 34 "C:\Users\Cho\Desktop\Coding Dojo\Belt Test\CS Belt Exam\BeltTest2\Views\Home\HobbyDetail.cshtml"
WriteAttributeValue("", 859, Model.id, 859, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(869, 17, true);
            WriteLiteral(">Edit Hobby</a>\r\n");
            EndContext();
#line 35 "C:\Users\Cho\Desktop\Coding Dojo\Belt Test\CS Belt Exam\BeltTest2\Views\Home\HobbyDetail.cshtml"
    }

#line default
#line hidden
            BeginContext(893, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(899, 584, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6397fdfef65084d672d8d84ac6564f2792c3746e9052", async() => {
                BeginContext(964, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(974, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6397fdfef65084d672d8d84ac6564f2792c3746e9442", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 38 "C:\Users\Cho\Desktop\Coding Dojo\Belt Test\CS Belt Exam\BeltTest2\Views\Home\HobbyDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1013, 84, true);
                WriteLiteral("\r\n        <h3>Become an Enthusiast!</h3>\r\n        <input type=\"hidden\" name=\"userid\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1097, "\"", 1125, 1);
#line 40 "C:\Users\Cho\Desktop\Coding Dojo\Belt Test\CS Belt Exam\BeltTest2\Views\Home\HobbyDetail.cshtml"
WriteAttributeValue("", 1105, ViewBag.thisuser.id, 1105, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1126, 46, true);
                WriteLiteral(">\r\n        <input type=\"hidden\" name=\"hobbyid\"");
                EndContext();
                BeginWriteAttribute("value", " value =\"", 1172, "\"", 1190, 1);
#line 41 "C:\Users\Cho\Desktop\Coding Dojo\Belt Test\CS Belt Exam\BeltTest2\Views\Home\HobbyDetail.cshtml"
WriteAttributeValue("", 1181, Model.id, 1181, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1191, 52, true);
                WriteLiteral(">\r\n        <select name=\"proficiency\">\r\n            ");
                EndContext();
                BeginContext(1243, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6397fdfef65084d672d8d84ac6564f2792c3746e12205", async() => {
                    BeginContext(1266, 6, true);
                    WriteLiteral("Novice");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1281, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1295, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6397fdfef65084d672d8d84ac6564f2792c3746e13683", async() => {
                    BeginContext(1324, 12, true);
                    WriteLiteral("Intermediate");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1345, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(1359, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6397fdfef65084d672d8d84ac6564f2792c3746e15168", async() => {
                    BeginContext(1382, 6, true);
                    WriteLiteral("Expert");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1397, 79, true);
                WriteLiteral("\r\n        </select>\r\n        <input type=\"submit\" value=\"Add to Hobbies\">\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1483, 12, true);
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hobby> Html { get; private set; }
    }
}
#pragma warning restore 1591