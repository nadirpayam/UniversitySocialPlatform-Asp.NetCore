#pragma checksum "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "878206d41396b7a326c15adbbfc7e2f38e1eaa89"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"878206d41396b7a326c15adbbfc7e2f38e1eaa89", @"/Views/Post/Index.cshtml")]
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
            WriteLiteral("                    <div class=\"col-lg-4 card\">\r\n                        <h5 class=\"card-title\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 636, "\"", 673, 2);
            WriteAttributeValue("", 643, "/Post/PostReadAll/", 643, 18, true);
#nullable restore
#line 22 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
WriteAttributeValue("", 661, item.PostID, 661, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
                                                                Write(item.PostTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </h5>\r\n\r\n");
#nullable restore
#line 25 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
                         if (item.PostImage != "" || item.PostImage != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a href=\"single.html\">\r\n                                <img");
            BeginWriteAttribute("src", " src=", 922, "", 942, 1);
#nullable restore
#line 28 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
WriteAttributeValue("", 927, item.PostImage, 927, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 973, "\"", 979, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </a>\r\n");
#nullable restore
#line 30 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <p class=\"card-text mb-3\"></p>");
#nullable restore
#line 31 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
                                               Write(item.PostContent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""card-body"">
                            <ul class=""blog-icons my-2"">
                                <li>
                                    <a href=""#"">
                                        <i class=""far fa-user""></i> ");
#nullable restore
#line 36 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
                                                               Write(item.Learner.LearnerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 36 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
                                                                                          Write(item.Learner.LearnerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </a>\r\n                                </li>\r\n                                <li>\r\n                                    <a href=\"#\">\r\n                                        <i class=\"fas fa-eye\"></i> ");
#nullable restore
#line 41 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
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
#line 48 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
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
                        </div>
                        <a");
            BeginWriteAttribute("href", " href=\"", 2542, "\"", 2579, 2);
            WriteAttributeValue("", 2549, "/Post/PostReadAll/", 2549, 18, true);
#nullable restore
#line 58 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
WriteAttributeValue("", 2567, item.PostID, 2567, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Devamını Oku</a>\r\n                    </div> ");
#nullable restore
#line 59 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\Index.cshtml"
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
