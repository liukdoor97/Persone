#pragma checksum "D:\SER\PROGETTI\Persone\Views\Persone\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a91881cee72ae9b65eaaebcee08e91a19151ad69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Persone_Detail), @"mvc.1.0.view", @"/Views/Persone/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Persone/Detail.cshtml", typeof(AspNetCore.Views_Persone_Detail))]
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
using Persone.Models.InputModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a91881cee72ae9b65eaaebcee08e91a19151ad69", @"/Views/Persone/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"146cc14981a772db108c38cd0bd5810d2e0b9137", @"/Views/_ViewImports.cshtml")]
    public class Views_Persone_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersoneDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(31, 60, true);
            WriteLiteral("<section>\r\n\r\n    <div>\r\n        <ul>\r\n            <li>Nome: ");
            EndContext();
            BeginContext(92, 10, false);
#line 6 "D:\SER\PROGETTI\Persone\Views\Persone\Detail.cshtml"
                 Write(Model.nome);

#line default
#line hidden
            EndContext();
            BeginContext(102, 32, true);
            WriteLiteral("</li>\r\n            <li>Cognome: ");
            EndContext();
            BeginContext(135, 13, false);
#line 7 "D:\SER\PROGETTI\Persone\Views\Persone\Detail.cshtml"
                    Write(Model.cognome);

#line default
#line hidden
            EndContext();
            BeginContext(148, 28, true);
            WriteLiteral("</li>\r\n            <li>Età: ");
            EndContext();
            BeginContext(177, 9, false);
#line 8 "D:\SER\PROGETTI\Persone\Views\Persone\Detail.cshtml"
                Write(Model.eta);

#line default
#line hidden
            EndContext();
            BeginContext(186, 43, true);
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n    <div>");
            EndContext();
            BeginContext(229, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a115c63dc2448049ada82ebecde082b", async() => {
                BeginContext(314, 40, true);
                WriteLiteral("<i class=\"fa fa-plus\"></i> Modifica dati");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 11 "D:\SER\PROGETTI\Persone\Views\Persone\Detail.cshtml"
                                                                       WriteLiteral(Model.Id);

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
            BeginContext(358, 44, true);
            WriteLiteral("</div>\r\n</section>\r\n<section>\r\n    <h2>Auto(");
            EndContext();
            BeginContext(403, 16, false);
#line 14 "D:\SER\PROGETTI\Persone\Views\Persone\Detail.cshtml"
        Write(Model.Auto.Count);

#line default
#line hidden
            EndContext();
            BeginContext(419, 8, true);
            WriteLiteral(")</h2>\r\n");
            EndContext();
#line 15 "D:\SER\PROGETTI\Persone\Views\Persone\Detail.cshtml"
     foreach (var auto in Model.Auto)
    {

#line default
#line hidden
            BeginContext(473, 67, true);
            WriteLiteral("        <hr>\r\n        <div>\r\n            <div>\r\n                <a>");
            EndContext();
            BeginContext(541, 10, false);
#line 20 "D:\SER\PROGETTI\Persone\Views\Persone\Detail.cshtml"
              Write(auto.marca);

#line default
#line hidden
            EndContext();
            BeginContext(551, 64, true);
            WriteLiteral("</a>\r\n            </div>\r\n            <div>\r\n                <a>");
            EndContext();
            BeginContext(616, 12, false);
#line 23 "D:\SER\PROGETTI\Persone\Views\Persone\Detail.cshtml"
              Write(auto.modello);

#line default
#line hidden
            EndContext();
            BeginContext(628, 64, true);
            WriteLiteral("</a>\r\n            </div>\r\n            <div>\r\n                <a>");
            EndContext();
            BeginContext(693, 10, false);
#line 26 "D:\SER\PROGETTI\Persone\Views\Persone\Detail.cshtml"
              Write(auto.targa);

#line default
#line hidden
            EndContext();
            BeginContext(703, 42, true);
            WriteLiteral("</a>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 29 "D:\SER\PROGETTI\Persone\Views\Persone\Detail.cshtml"
    }

#line default
#line hidden
            BeginContext(752, 12, true);
            WriteLiteral("\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersoneDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
