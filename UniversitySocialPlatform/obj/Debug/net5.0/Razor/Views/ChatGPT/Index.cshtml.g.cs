#pragma checksum "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\ChatGPT\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60551ccef5c4b031434ff902aa4d6e05e94683f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChatGPT_Index), @"mvc.1.0.view", @"/Views/ChatGPT/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60551ccef5c4b031434ff902aa4d6e05e94683f1", @"/Views/ChatGPT/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c28c813bc7100ff6d1fdf98a1f700436968b935a", @"/Views/_ViewImports.cshtml")]
    public class Views_ChatGPT_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Views\ChatGPT\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .iframethis {
        width: 100%;
        height: 550px;
    }

    .warning {
    }
</style>

<br />
<div class=""container"">
    <div class=""row"">
        <iframe class=""iframethis"" id=""iframe"" src=""https://localhost:44351/"" frameborder=""0""></iframe>
    </div>
</div>

");
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
