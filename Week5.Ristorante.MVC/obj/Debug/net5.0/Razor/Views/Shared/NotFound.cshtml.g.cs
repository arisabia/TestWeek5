#pragma checksum "C:\Users\larisa.b.antonica\source\repos\Week5.Ristorante.MVC\Week5.Ristorante.MVC\Views\Shared\NotFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "895659ffaf4867a3a029e579e490e76c9ffd4e68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_NotFound), @"mvc.1.0.view", @"/Views/Shared/NotFound.cshtml")]
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
#line 1 "C:\Users\larisa.b.antonica\source\repos\Week5.Ristorante.MVC\Week5.Ristorante.MVC\Views\_ViewImports.cshtml"
using Week5.Ristorante.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\larisa.b.antonica\source\repos\Week5.Ristorante.MVC\Week5.Ristorante.MVC\Views\_ViewImports.cshtml"
using Week5.Ristorante.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\larisa.b.antonica\source\repos\Week5.Ristorante.MVC\Week5.Ristorante.MVC\Views\_ViewImports.cshtml"
using Week5.Ristorante.Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"895659ffaf4867a3a029e579e490e76c9ffd4e68", @"/Views/Shared/NotFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a0ab9d5664f1207496a384e4c3ec2daa64e5440", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_NotFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NotFoundViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\larisa.b.antonica\source\repos\Week5.Ristorante.MVC\Week5.Ristorante.MVC\Views\Shared\NotFound.cshtml"
   ViewData["Title"] = "Not Found"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 class=\"text-danger\">Error.</h1>\n<h2 class=\"text-danger\">");
#nullable restore
#line 6 "C:\Users\larisa.b.antonica\source\repos\Week5.Ristorante.MVC\Week5.Ristorante.MVC\Views\Shared\NotFound.cshtml"
                   Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<h2 class=\"text-danger\">Item with ");
#nullable restore
#line 7 "C:\Users\larisa.b.antonica\source\repos\Week5.Ristorante.MVC\Week5.Ristorante.MVC\Views\Shared\NotFound.cshtml"
                             Write(Model.EntityId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" not found</h2>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NotFoundViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
