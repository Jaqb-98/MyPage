#pragma checksum "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e52505255f6af6b216df097e63f1d8f5eb0c8e64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyPage_Index), @"mvc.1.0.view", @"/Views/MyPage/Index.cshtml")]
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
#line 1 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\_ViewImports.cshtml"
using MyPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\_ViewImports.cshtml"
using MyPage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e52505255f6af6b216df097e63f1d8f5eb0c8e64", @"/Views/MyPage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a81ad0979f29c6bc8554041958600b33a1e9bb67", @"/Views/_ViewImports.cshtml")]
    public class Views_MyPage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PageModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/beach.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/trevel.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/books.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/birds.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
  
    int photoCount = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link href=""assets/css/style.css"" rel=""stylesheet"">


<!-- ======= Slider Section ======= -->
<section id=""slider"" class=""slider"">
    <div class=""section-title"">
        <h2>Slider</h2>
    </div>


    <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
");
#nullable restore
#line 19 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
             foreach (var photo in Model.PhotoData)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
                 if (photoCount == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 23 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
                                                                           Write(photoCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"active\"></li>\r\n");
#nullable restore
#line 24 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 27 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
                                                                           Write(photoCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></li>\r\n");
#nullable restore
#line 28 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
                 
                photoCount++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ol>\r\n        <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 33 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
              
                photoCount = 0;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 37 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
             foreach (var photo in Model.PhotoData)
            {


                

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
                 if (photoCount == 0)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item active\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1193, "\"", 1218, 1);
#nullable restore
#line 45 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
WriteAttributeValue("", 1199, photo.Urls.regular, 1199, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block\" alt=\"Slide\">\r\n                    </div>\r\n");
#nullable restore
#line 47 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1415, "\"", 1440, 1);
#nullable restore
#line 51 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
WriteAttributeValue("", 1421, photo.Urls.regular, 1421, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"d-block\" alt=\"Slide\">\r\n                    </div>\r\n");
#nullable restore
#line 53 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
                 
                photoCount++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
</section><!-- End Slider Section -->
<!-- ======= hobbies Section ======= -->
<section id=""hobbies"" class=""hobbies"">
    <div class=""container"">

        <div class=""section-title"">
            <h2>Hobbies</h2>
        </div>

        <div class=""row"">
            <div class=""col-md-6"">
                <div class=""card"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e52505255f6af6b216df097e63f1d8f5eb0c8e6411554", async() => {
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
            WriteLiteral(@"
                    <div class=""card-body"">
                        <h5 class=""card-title"">Long walks on the beach at sunset</h5>

                    </div>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""card"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e52505255f6af6b216df097e63f1d8f5eb0c8e6413056", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""card-body"">
                        <h5 class=""card-title"">Travel</h5>

                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">

            <div class=""col-md-6"">
                <div class=""card"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e52505255f6af6b216df097e63f1d8f5eb0c8e6414578", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""card-body"">
                        <h5 class=""card-title"">Literature</h5>

                    </div>
                </div>
            </div>
            <div class=""col-md-6"">
                <div class=""card"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e52505255f6af6b216df097e63f1d8f5eb0c8e6416057", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""card-body"">
                        <h5 class=""card-title"">Ornithology</h5>

                    </div>
                </div>
            </div>
        </div>
    </div>





</section><!-- End hobbies Section -->
<!-- ======= News Section ======= -->
<section id=""news"" class=""news section-bg"">
    <div class=""container"">

        <div class=""section-title"">
            <h2>News</h2>
        </div>

");
#nullable restore
#line 139 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
          
            var row = 1;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
         foreach (var item in Model.RssItems)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
             if (row % 2 != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
           Write(Html.Raw("<div class=\"row\">"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
                                                ;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-6\">\r\n                <h2>");
#nullable restore
#line 149 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <h5>");
#nullable restore
#line 150 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
               Write(item.PubDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p>");
#nullable restore
#line 151 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
              Write(Html.Raw(item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n");
#nullable restore
#line 154 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
             if (row % 2 == 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 156 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
           Write(Html.Raw("</div>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 156 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
                                   ;
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "E:\Visual Studio workspace\internetu\MyPage\MyPage\Views\MyPage\Index.cshtml"
             
            row++;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



    </div>
</section><!-- End News Section -->
<!-- ======= Map Section ======= -->
<section id=""map"" class=""map"">
    <div class=""container"">

        <div class=""section-title"">
            <h2>Map</h2>
        </div>

        <div id=""map-container-google-1"" class=""z-depth-1-half map-container"" style=""height: 500px"">
            <iframe src=""https://maps.google.com/maps?q=bielsko-biala&t=&z=13&ie=UTF8&iwloc=&output=embed""
                    frameborder=""0"" style=""border:0; width: 100%; height: 400px;"" allowfullscreen></iframe>
        </div>


    </div>
</section><!-- End Map Section -->

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
