#pragma checksum "/Users/calebgregory/Documents/dojo_assignments/c_sharp/aspdotnet_core/asp_mvc_ii/DojoSurveyWithValidations/Views/Home/Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30aa1d37151b4ab09daa288b147042344f1f73c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
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
#line 1 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/aspdotnet_core/asp_mvc_ii/DojoSurveyWithValidations/Views/_ViewImports.cshtml"
using DojoSurveyWithValidations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/aspdotnet_core/asp_mvc_ii/DojoSurveyWithValidations/Views/_ViewImports.cshtml"
using DojoSurveyWithValidations.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30aa1d37151b4ab09daa288b147042344f1f73c8", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1ce34a5b46c0fb7100a79cca97847504334e373", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SurveyResult>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/aspdotnet_core/asp_mvc_ii/DojoSurveyWithValidations/Views/Home/Result.cshtml"
  
    ViewData["Title"] = "Dojo Survey";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container mt-3\">\n    <h3><u>Submitted Info</u></h3>\n    <p>Name: ");
#nullable restore
#line 8 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/aspdotnet_core/asp_mvc_ii/DojoSurveyWithValidations/Views/Home/Result.cshtml"
        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Location: ");
#nullable restore
#line 9 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/aspdotnet_core/asp_mvc_ii/DojoSurveyWithValidations/Views/Home/Result.cshtml"
            Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Language: ");
#nullable restore
#line 10 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/aspdotnet_core/asp_mvc_ii/DojoSurveyWithValidations/Views/Home/Result.cshtml"
            Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    <p>Comment: ");
#nullable restore
#line 11 "/Users/calebgregory/Documents/dojo_assignments/c_sharp/aspdotnet_core/asp_mvc_ii/DojoSurveyWithValidations/Views/Home/Result.cshtml"
           Write(Model.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SurveyResult> Html { get; private set; }
    }
}
#pragma warning restore 1591