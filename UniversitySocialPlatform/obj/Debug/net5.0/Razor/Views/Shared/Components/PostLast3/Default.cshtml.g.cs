#pragma checksum "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Shared\Components\PostLast3\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db86b1e085ec6b42faa48cb51d5189fab7dae5ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_PostLast3_Default), @"mvc.1.0.view", @"/Views/Shared/Components/PostLast3/Default.cshtml")]
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
#line 1 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\_ViewImports.cshtml"
using UniversitySocialPlatform;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\_ViewImports.cshtml"
using UniversitySocialPlatform.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Shared\Components\PostLast3\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db86b1e085ec6b42faa48cb51d5189fab7dae5ac", @"/Views/Shared/Components/PostLast3/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c28c813bc7100ff6d1fdf98a1f700436968b935a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_PostLast3_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"tech-btm\">\r\n    <h3>Son Gönderiler</h3>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Shared\Components\PostLast3\Default.cshtml"
     foreach (var item in Model) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"blog-grids row mb-3\">\r\n        <div class=\"col-md-5 blog-grid-left\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 244, "\"", 281, 2);
            WriteAttributeValue("", 251, "/Post/PostReadAll/", 251, 18, true);
#nullable restore
#line 11 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Shared\Components\PostLast3\Default.cshtml"
WriteAttributeValue("", 269, item.PostID, 269, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img");
            BeginWriteAttribute("src", " src=", 305, "", 325, 1);
#nullable restore
#line 12 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Shared\Components\PostLast3\Default.cshtml"
WriteAttributeValue("", 310, item.PostImage, 310, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 356, "\"", 362, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </a>\r\n        </div>\r\n        <div class=\"col-md-7 blog-grid-right\">\r\n\r\n            <h5>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 486, "\"", 523, 2);
            WriteAttributeValue("", 493, "/Post/PostReadAll/", 493, 18, true);
#nullable restore
#line 18 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Shared\Components\PostLast3\Default.cshtml"
WriteAttributeValue("", 511, item.PostID, 511, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Shared\Components\PostLast3\Default.cshtml"
                                                    Write(item.PostContent.Substring(0, item.PostContent.Substring(0, 70).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</a>\r\n            </h5>\r\n            <div class=\"sub-meta\">\r\n                <span>\r\n                    <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 22 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Shared\Components\PostLast3\Default.cshtml"
                                             Write(((DateTime)item.PostCreateDate).ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n        </div>\r\n    </div>");
#nullable restore
#line 26 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Shared\Components\PostLast3\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591