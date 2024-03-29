#pragma checksum "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Areas\Admin\Views\Learner\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "445f9798dc2aadd2a253f832b679f013248b3c2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Learner_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Learner/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"445f9798dc2aadd2a253f832b679f013248b3c2e", @"/Areas/Admin/Views/Learner/Index.cshtml")]
    public class Areas_Admin_Views_Learner_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\nadirpayam\Desktop\MyProjects\UniversitySocialPlatform\UniversitySocialPlatform\Areas\Admin\Views\Learner\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Eğitici Ajax İşlemleri</h1>

<br />

<button type=""button"" id=""btngetlist"" class=""btn btn-primary"">Eğitici Listesi</button>
<button type=""button"" id=""btngetbyid"" class=""btn btn-success"">Eğitici Getir</button>
<button type=""button"" id=""btnaddlearner"" class=""btn btn-info"">Eğitici Ekle</button>
<button type=""button"" id=""btndeletelearner"" class=""btn btn-danger"">Eğitici Sil</button>
<button type=""button"" id=""btnupdatelearner"" class=""btn btn-info"">Eğiticiyü Güncelle</button>

<br />

<div id=""learnerlist"">
    Buraya eğiticiler gelecek
</div>
<br />
<div id=""learnerget"">
    Buraya 1 eğitici gelecek
</div>
<br />
<div>
    <input type=""text"" id=""learnerId"" placeholder=""Eğitici ID Değerini Girin"" class=""form-control"" />
</div>
<br />

<div>
    <input type=""text"" id=""txtID"" placeholder=""Silinecek Eğitici ID Değerini Girin"" class=""form-control"" />
</div>

<div>
    <br />
    <input type=""text"" class=""form-control"" id=""txtlearnerid"" placeholder=""Eğitici ID"" />
    <br />
    <in");
            WriteLiteral(@"put type=""text"" class=""form-control"" id=""txtlearnername"" placeholder=""Eğitici Adı"" />
    <br />
</div>

<br />

<input type=""text"" id=""updateidtxt"" placeholder=""Güncellenecek eğiticinin ID'si'"" class=""form-control"" />
<input type=""text"" id=""updatenametxt"" placeholder=""Güncellenecek eğiticinin Adı'si'"" class=""form-control"" />
<br />



");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""#btngetlist"").click(function () {
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Admin/Learner/LearnerList"",
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(w);
                    let tablehtml = ""<table class=table table-bordered>"" +
                        ""<tr> <th>Eğitici ID</th>  <th>Eğitici Adı</th></tr>"";
                    $.each(w, (index, value) => {
                        tablehtml += `<tr><td>${value.Id}</td> <td>${value.Name}</td></tr>`
                    });
                    tablehtml += ""</table>"";
                    $(""#learnerlist"").html(tablehtml);
                }
            });
        });

        $(""#btngetbyid"").click(x => {
            let id = $(""#learnerId"").val();
            $.ajax({
                contentType: ""application/json"",
     ");
                WriteLiteral(@"           dataType: ""json"",
                type: ""get"",
                url: ""/Admin/Learner/GetLearnerByID"",
                data: { learnerId: id },
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(w);

                    let getvalue = `<table class=table table-bordered> <tr> <th>Eğitici ID</th>
                            <th> Eğitici Adı </th> </tr> <tr> <td>${w.Id} </td><td>${w.Name}</td></tr></table>`;
                    $(""#learnerget"").html(getvalue);
                }
            });

        })

        $(""#btnaddlearner"").click(function () {
            let learner = {
                Id: $(""#txtlearnerid"").val(),
                Name: $(""#txtlearnername"").val()
            };
            $.ajax({
                type: ""post"",
                url: ""/Admin/Learner/AddLearner"",
                data: learner,
                success: function (func) {
                    let result = jQuery.par");
                WriteLiteral(@"seJSON(func);
                    alert(""Eğitici ekleme işlemi başarılı bir şekilde gerçekleşti"");
                }
            })
        })

        $(""#btndeletelearner"").click(x => {
            let id = $(""#txtID"").val();
            $.ajax({
                url: ""/Admin/Learner/DeleteLearner/"" + id,
                type: ""post"",
                dataType: ""json"",
                success: function (func) {
                    alert(""yazar silindi"");
                }
            });
        });

        $(""#btnupdatelearner"").click(function () {
            let learner = {
                Id: $(""#updateidtxt"").val(),
                Name: $(""#updatenametxt"").val()
            };

            $.ajax({
                type: ""post"",
                url: ""/Admin/Learner/UpdateLearner"",
                data: learner,
                success: function (func) {
                    alert(""Güncelleme Yapıldı"");
                }
            })
        })

    </script>
");
            }
            );
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
