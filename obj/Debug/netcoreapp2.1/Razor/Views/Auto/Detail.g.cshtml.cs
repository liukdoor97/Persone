#pragma checksum "D:\SER\PROGETTI\Persone\Views\Auto\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63f422becd9a0bc8517d0b7202620aba15c961ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auto_Detail), @"mvc.1.0.view", @"/Views/Auto/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Auto/Detail.cshtml", typeof(AspNetCore.Views_Auto_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63f422becd9a0bc8517d0b7202620aba15c961ed", @"/Views/Auto/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"494c0b8cb83c724ff707f9066e3f07745103b566", @"/Views/_ViewImports.cshtml")]
    public class Views_Auto_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AutoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 61, true);
            WriteLiteral("<section>\r\n\r\n    <div>\r\n        <ul>\r\n            <li>marca: ");
            EndContext();
            BeginContext(84, 11, false);
#line 6 "D:\SER\PROGETTI\Persone\Views\Auto\Detail.cshtml"
                  Write(Model.marca);

#line default
#line hidden
            EndContext();
            BeginContext(95, 32, true);
            WriteLiteral("</li>\r\n            <li>modello: ");
            EndContext();
            BeginContext(128, 13, false);
#line 7 "D:\SER\PROGETTI\Persone\Views\Auto\Detail.cshtml"
                    Write(Model.modello);

#line default
#line hidden
            EndContext();
            BeginContext(141, 30, true);
            WriteLiteral("</li>\r\n            <li>targa: ");
            EndContext();
            BeginContext(172, 11, false);
#line 8 "D:\SER\PROGETTI\Persone\Views\Auto\Detail.cshtml"
                  Write(Model.targa);

#line default
#line hidden
            EndContext();
            BeginContext(183, 32, true);
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AutoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
