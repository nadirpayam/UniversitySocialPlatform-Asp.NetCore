#pragma checksum "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c2b64acf9f23666c0e295eda05029cbded7901e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
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
#line 1 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c2b64acf9f23666c0e295eda05029cbded7901e", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c28c813bc7100ff6d1fdf98a1f700436968b935a", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Gönderiler</h3>
        <div class=""inner-sec"">
            <!--left-->
            <div class=""left-blog-info-w3layouts-agileits text-left"">
                <div class=""row"">
");
#nullable restore
#line 18 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 card\">\r\n                        <a href=\"single.html\">\r\n                            <img");
            BeginWriteAttribute("src", " src=", 637, "", 657, 1);
#nullable restore
#line 22 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
WriteAttributeValue("", 642, item.PostImage, 642, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 688, "\"", 694, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                        <div class=""card-body"">
                            <ul class=""blog-icons my-2"">
                                <li>
                                    <a href=""#"">
                                        <i class=""far fa-user""></i> ");
#nullable restore
#line 28 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
                                                               Write(item.Learner.LearnerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 28 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
                                                                                          Write(item.Learner.LearnerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </a>
                                </li>
                               
                                <li>
                                    <a href=""#"">
                                        <i class=""fas fa-eye""></i> ");
#nullable restore
#line 34 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
                                                              Write(item.Learner.LearnerType.LearnerTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </a>
                                </li>

                            </ul>
                            <ul class=""blog-icons my-2"">
                                <li>
                                    <a href=""#"">
                                        <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 42 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
                                                                        Write(((DateTime)item.PostCreateDate).ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </a>
                                </li>
                                <li class=""mx-2"">
                                    <a href=""#"">
                                        <i class=""far fa-comment""></i> 0
                                    </a>
                                </li>
                            </ul>

                                <h5 class=""card-title"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 2229, "\"", 2266, 2);
            WriteAttributeValue("", 2236, "/Post/PostReadAll/", 2236, 18, true);
#nullable restore
#line 53 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
WriteAttributeValue("", 2254, item.PostID, 2254, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 53 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
                                                                        Write(item.PostTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h5>\r\n                                <p class=\"card-text mb-3\">");
#nullable restore
#line 55 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
                                                     Write(item.PostContent.Substring(0,item.PostContent.Substring(0,70).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2509, "\"", 2546, 2);
            WriteAttributeValue("", 2516, "/Post/PostReadAll/", 2516, 18, true);
#nullable restore
#line 56 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
WriteAttributeValue("", 2534, item.PostID, 2534, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Devamını Oku</a>\r\n                        </div>\r\n                    </div> ");
#nullable restore
#line 58 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <!--//left-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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