#pragma checksum "C:\Repos\Api appdoptanos\appdoptanosV2\Views\Adopcions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47ae947ec3b2d03086f2282a2648c761332202a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adopcions_Index), @"mvc.1.0.view", @"/Views/Adopcions/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47ae947ec3b2d03086f2282a2648c761332202a4", @"/Views/Adopcions/Index.cshtml")]
    public class Views_Adopcions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Appdoptanos.Api.Models.Adopcion>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Repos\Api appdoptanos\appdoptanosV2\Views\Adopcions\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Repos\Api appdoptanos\appdoptanosV2\Views\Adopcions\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Animal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "C:\Repos\Api appdoptanos\appdoptanosV2\Views\Adopcions\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "C:\Repos\Api appdoptanos\appdoptanosV2\Views\Adopcions\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Animal.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 586, "\"", 617, 1);
#nullable restore
#line 28 "C:\Repos\Api appdoptanos\appdoptanosV2\Views\Adopcions\Index.cshtml"
WriteAttributeValue("", 601, item.IdAdopcion, 601, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 670, "\"", 701, 1);
#nullable restore
#line 29 "C:\Repos\Api appdoptanos\appdoptanosV2\Views\Adopcions\Index.cshtml"
WriteAttributeValue("", 685, item.IdAdopcion, 685, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 756, "\"", 787, 1);
#nullable restore
#line 30 "C:\Repos\Api appdoptanos\appdoptanosV2\Views\Adopcions\Index.cshtml"
WriteAttributeValue("", 771, item.IdAdopcion, 771, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Repos\Api appdoptanos\appdoptanosV2\Views\Adopcions\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Appdoptanos.Api.Models.Adopcion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
