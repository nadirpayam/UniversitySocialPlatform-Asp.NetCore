#pragma checksum "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\PostReadAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88ada9802206502911cc10e5a970ed557e072a65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_PostReadAll), @"mvc.1.0.view", @"/Views/Post/PostReadAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88ada9802206502911cc10e5a970ed557e072a65", @"/Views/Post/PostReadAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c28c813bc7100ff6d1fdf98a1f700436968b935a", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_PostReadAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Post>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/USPTema/images/banner1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\PostReadAll.cshtml"
  
    ViewData["Title"] = "PostDetails";
    Layout = "~/Views/Shared/MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <!--//banner-->
    <section class=""banner-bottom"">
        <!--/blog-->
        <div class=""container"">
            <div class=""row"">
                <!--left-->
                <div class=""col-lg-8 left-blog-info-w3layouts-agileits text-left"">
");
#nullable restore
#line 16 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\PostReadAll.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""blog-grid-top"">
                            <div class=""b-grid-top"">
                                <div class=""blog_info_left_grid"">
                                    <a href=""single.html"">
                                        <img");
            BeginWriteAttribute("src", " src=", 758, "", 778, 1);
#nullable restore
#line 22 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\PostReadAll.cshtml"
WriteAttributeValue("", 763, item.PostImage, 763, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 796, "\"", 802, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </a>
                                </div>
                                <div class=""blog-info-middle"">
                                    <ul>
                                        <li>
                                            <a href=""#"">
                                                <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 29 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\PostReadAll.cshtml"
                                                                                Write(((DateTime)item.PostCreateDate).ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </a>
                                        </li>
                                      

                                    </ul>
                                </div>
                            </div>

                            <h3>
                                <a href=""single.html"">");
#nullable restore
#line 39 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\PostReadAll.cshtml"
                                                 Write(item.PostTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                            </h3>\r\n                            <p>\r\n                                ");
#nullable restore
#line 42 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\PostReadAll.cshtml"
                           Write(item.PostContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            <a href=\"/Post/Index/\" class=\"btn btn-primary read-m\">Gönderilere Dön</a>\r\n                        </div>\r\n");
#nullable restore
#line 46 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\PostReadAll.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
#nullable restore
#line 47 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\PostReadAll.cshtml"
               Write(await Component.InvokeAsync("CommentListByBlog",new { id = ViewBag.PostId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                    ");
#nullable restore
#line 48 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\PostReadAll.cshtml"
               Write(await Html.PartialAsync("~/Views/Comment/PartialAddComment.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>

                <!--//left-->
                <!--right-->
                <aside class=""col-lg-4 agileits-w3ls-right-blog-con text-right"">
                    <div class=""right-blog-info text-left"">
                        <div class=""tech-btm"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "88ada9802206502911cc10e5a970ed557e072a659340", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        ");
#nullable restore
#line 59 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\PostReadAll.cshtml"
                   Write(await Component.InvokeAsync("SectionList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 60 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\Post\PostReadAll.cshtml"
                   Write(await Component.InvokeAsync("LearnerLastPost", new { id = ViewBag.PostId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                </aside>\r\n                <!--//right-->\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
