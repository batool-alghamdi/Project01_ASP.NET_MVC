#pragma checksum "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.NET\Projects\Project01_ASP.NET_MVC\plantsShop\plantsShop\Views\Images\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "113c5db2fc101cab73dee447929c7f6af67deccd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Images_Index), @"mvc.1.0.view", @"/Views/Images/Index.cshtml")]
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
#line 1 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.NET\Projects\Project01_ASP.NET_MVC\plantsShop\plantsShop\Views\_ViewImports.cshtml"
using plantsShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.NET\Projects\Project01_ASP.NET_MVC\plantsShop\plantsShop\Views\_ViewImports.cshtml"
using plantsShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"113c5db2fc101cab73dee447929c7f6af67deccd", @"/Views/Images/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bed17f141cbaace2d3d2bf9f6f7ab96a3149756", @"/Views/_ViewImports.cshtml")]
    public class Views_Images_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.NET\Projects\Project01_ASP.NET_MVC\plantsShop\plantsShop\Views\Images\Index.cshtml"
  
    var image = (List<ImageModel>)ViewData["Images"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 6 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.NET\Projects\Project01_ASP.NET_MVC\plantsShop\plantsShop\Views\Images\Index.cshtml"
     foreach (var i in image )
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-6 p-2 \">\r\n            <div class=\"card \">\r\n                <div class=\"card-body\">\r\n                    <img class=\"card-img-top border-radius: 8px\"");
            BeginWriteAttribute("src", " src=\"", 297, "\"", 311, 1);
#nullable restore
#line 11 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.NET\Projects\Project01_ASP.NET_MVC\plantsShop\plantsShop\Views\Images\Index.cshtml"
WriteAttributeValue("", 303, i.image, 303, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 15 "C:\Users\Batool Alghamdi\Desktop\Tuwaiq\.NET\Projects\Project01_ASP.NET_MVC\plantsShop\plantsShop\Views\Images\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
