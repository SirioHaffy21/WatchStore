#pragma checksum "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\WatchUser\WatchByName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5092268e9fe3b4f0b5be807f9781d1727b18c3fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WatchUser_WatchByName), @"mvc.1.0.view", @"/Views/WatchUser/WatchByName.cshtml")]
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
#line 1 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\_ViewImports.cshtml"
using WatchManageStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\_ViewImports.cshtml"
using WatchManageStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5092268e9fe3b4f0b5be807f9781d1727b18c3fb", @"/Views/WatchUser/WatchByName.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0897fb513dcf51d4d8d0f59fb37e263cfb4c8a06", @"/Views/_ViewImports.cshtml")]
    public class Views_WatchUser_WatchByName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WatchManageStore.Models.Watch>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary-image imgwatch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-box-inner"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\WatchUser\WatchByName.cshtml"
  
    ViewData["Title"] = "Dongho";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""breadcrumb-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <!-- breadcrumb-list start -->
                <ul class=""breadcrumb-list"">
                    <li class=""breadcrumb-item"">");
#nullable restore
#line 12 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\WatchUser\WatchByName.cshtml"
                                           Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                    <li class=""breadcrumb-item active"">Watch</li>
                </ul>
                <!-- breadcrumb-list end -->
            </div>
        </div>
    </div>
</div>
<div class=""product-area section-pb section-pt-30"">
    <div class=""container"">
        <div class=""tab-pane fade show active"">
            <div class=""product-carousel-group"">
                <div class=""row"" id=""listWatch"">
");
#nullable restore
#line 25 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\WatchUser\WatchByName.cshtml"
                     foreach (var item in @Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-sm-3"">
                            <!-- single-product-area start -->
                            <div class=""single-product-area mt-30"" style=""height:500px"">
                                <div class=""product-thumb"">
                                    <a href=""product-details.html"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5092268e9fe3b4f0b5be807f9781d1727b18c3fb6859", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1316, "~/imgs/", 1316, 7, true);
#nullable restore
#line 32 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\WatchUser\WatchByName.cshtml"
AddHtmlAttributeValue("", 1323, item.Image, 1323, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </a>\r\n                                </div>\r\n                                <div class=\"product-caption\">\r\n                                    <h4 class=\"product-name\"><a href=\"product-details.html\">");
#nullable restore
#line 36 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\WatchUser\WatchByName.cshtml"
                                                                                       Write(item.WatchName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                    <div class=\"price-box\">\r\n                                        <span class=\"new-price\">");
#nullable restore
#line 38 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\WatchUser\WatchByName.cshtml"
                                                           Write(item.Price.ToString("0,000"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>đ\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"text-center mr-2\">\r\n                                    ");
#nullable restore
#line 42 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\WatchUser\WatchByName.cshtml"
                               Write(Html.ActionLink("Detail", "Detail", "WatchUser", new { id = item.WatchId }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n\r\n                            </div>\r\n                            <!-- single-product-area end -->\r\n                        </div>\r\n");
#nullable restore
#line 48 "D:\FileOfSH\doan\App\WatchStore\WatchManageStore\WatchManageStore\Views\WatchUser\WatchByName.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("search", async() => {
                WriteLiteral("\r\n    <div class=\"search-box-wrapper\">\r\n        <div class=\"search-box-inner-wrap\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5092268e9fe3b4f0b5be807f9781d1727b18c3fb10827", async() => {
                    WriteLiteral(@"
                <div class=""search-field-wrap"">
                    <input type=""text"" class=""search-field"" placeholder=""Tìm kiếm..."" id=""myInput"">

                    <div class=""search-btn"">
                        <button id=""search""><i class=""icon-magnifier""></i></button>
                    </div>
                </div>

            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            }
            );
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).on('click', '#search', function () {
            $(""#search-form"").submit((e) => {
                e.preventDefault();
            });
            if ($(""#myInput"").val().trim()) {
                var value = $(""#myInput"").val().toLowerCase();
                $.ajax({
                    url: '/WatchUser/SearchWatch',
                    type: 'get',
                    data: { search: value },
                    success: function (data) {
                        $('#listWatch').empty();
                        $('#listWatch').removeClass('slick-slider');
                        $.each(data.searchItem, function (k, v) {
                            let str = ` <div class=""col-sm-3"">
                                <!-- single-product-area start -->
                                <div class=""single-product-area mt-30"" style=""height:500px"">
                                    <div class=""product-thumb"">
                                        <a href=""produ");
                WriteLiteral(@"ct-details.html"">
                                            <img class=""primary-image imgwatch"" src=""imgs/${v.image}"" alt="""">
                                        </a>
                                    </div>
                                    <div class=""product-caption"">
                                        <h4 class=""product-name""><a href=""product-details.html"">${v.watchName}</a></h4>
                                        <div class=""price-box"">
                                            <span class=""new-price"">${v.price}</span>đ
                                        </div>
                                    </div>
                                    <div class=""text-center mr-2"">
                                        <a class = ""btn btn-danger"" href=""../WatchUser/Detail/ ${v.watchId}"">Detail</a>
                                    </div>

                                </div>
                                <!-- single-product-area end -->
                            </");
                WriteLiteral(@"div>`;
                            document.querySelector('#listWatch').insertAdjacentHTML('beforeend', str);
                        })

                    },
                    error: function (xhr, status, error) {
                        console.log(xhr);
                    }
                });
            }

        })
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WatchManageStore.Models.Watch>> Html { get; private set; }
    }
}
#pragma warning restore 1591
