#pragma checksum "D:\SER\PROGETTI\Persone\Views\Auto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe2dc75f1636a8b5a51d222cb5f0fec9fd81e1ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auto_Index), @"mvc.1.0.view", @"/Views/Auto/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Auto/Index.cshtml", typeof(AspNetCore.Views_Auto_Index))]
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
#line 1 "D:\SER\PROGETTI\Persone\Views\_ViewImports.cshtml"
using Persone;

#line default
#line hidden
#line 2 "D:\SER\PROGETTI\Persone\Views\_ViewImports.cshtml"
using Persone.Models;

#line default
#line hidden
#line 3 "D:\SER\PROGETTI\Persone\Views\_ViewImports.cshtml"
using Persone.Models.ViewModels;

#line default
#line hidden
#line 4 "D:\SER\PROGETTI\Persone\Views\_ViewImports.cshtml"
using Persone.Models.InputModels.Persone;

#line default
#line hidden
#line 5 "D:\SER\PROGETTI\Persone\Views\_ViewImports.cshtml"
using Persone.Models.InputModels.Auto;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe2dc75f1636a8b5a51d222cb5f0fec9fd81e1ca", @"/Views/Auto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"494c0b8cb83c724ff707f9066e3f07745103b566", @"/Views/_ViewImports.cshtml")]
    public class Views_Auto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AutoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(28, 12, true);
            WriteLiteral("\r\n<h1>\r\n    ");
            EndContext();
            BeginContext(41, 17, false);
#line 4 "D:\SER\PROGETTI\Persone\Views\Auto\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(58, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(64, 103, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f1ad2a2e8314a85a5f3ad4101fb39bc", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbd2b2a9571745379ef1aa6bd2e6f809", async() => {
>>>>>>> main
                BeginContext(126, 37, true);
                WriteLiteral("<i class=\"fa fa-plus\"></i> Crea nuova");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(167, 11, true);
            WriteLiteral("\r\n\r\n</h1>\r\n");
            EndContext();
#line 8 "D:\SER\PROGETTI\Persone\Views\Auto\Index.cshtml"
 foreach (AutoViewModel auto in Model)
{

#line default
#line hidden
            BeginContext(221, 48, true);
            WriteLiteral("    <div>\r\n        <ul>\r\n            <li>marca: ");
            EndContext();
            BeginContext(270, 10, false);
#line 12 "D:\SER\PROGETTI\Persone\Views\Auto\Index.cshtml"
                  Write(auto.marca);

#line default
#line hidden
            EndContext();
            BeginContext(280, 32, true);
            WriteLiteral("</li>\r\n            <li>modello: ");
            EndContext();
            BeginContext(313, 12, false);
#line 13 "D:\SER\PROGETTI\Persone\Views\Auto\Index.cshtml"
                    Write(auto.modello);

#line default
#line hidden
            EndContext();
            BeginContext(325, 30, true);
            WriteLiteral("</li>\r\n            <li>targa: ");
            EndContext();
            BeginContext(356, 10, false);
#line 14 "D:\SER\PROGETTI\Persone\Views\Auto\Index.cshtml"
                  Write(auto.targa);

#line default
#line hidden
            EndContext();
            BeginContext(366, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
            BeginContext(436, 89, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n    <div class=\"col-md-2 d-flex align-items-center\">\r\n        ");
            EndContext();
            BeginContext(525, 92, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9d38084d5554c2abc9eb037e2125b21", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e8d41dc66054bf0bd65437735d03b3e", async() => {
>>>>>>> main
                BeginContext(604, 9, true);
                WriteLiteral("Dettaglio");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "D:\SER\PROGETTI\Persone\Views\Auto\Index.cshtml"
                                                                 WriteLiteral(auto.id);

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
            BeginContext(617, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 21 "D:\SER\PROGETTI\Persone\Views\Auto\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AutoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
