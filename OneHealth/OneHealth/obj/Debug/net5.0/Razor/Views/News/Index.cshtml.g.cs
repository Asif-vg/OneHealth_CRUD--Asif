#pragma checksum "C:\Users\CASPER\Desktop\OneHealth VS\OneHealth\OneHealth\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5eaf2ca2a4155932b6f2dcf99045d7d17637f3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Index), @"mvc.1.0.view", @"/Views/News/Index.cshtml")]
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
#line 1 "C:\Users\CASPER\Desktop\OneHealth VS\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using OneHealth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CASPER\Desktop\OneHealth VS\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using OneHealth.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CASPER\Desktop\OneHealth VS\OneHealth\OneHealth\Views\_ViewImports.cshtml"
using OneHealth.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5eaf2ca2a4155932b6f2dcf99045d7d17637f3e", @"/Views/News/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"501b3e4ade82d3e3b27f269998f2dee5e916c53e", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmNews>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Uploads/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\CASPER\Desktop\OneHealth VS\OneHealth\OneHealth\Views\News\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-section\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-8\">\r\n                <div class=\"row\">\r\n\r\n");
#nullable restore
#line 13 "C:\Users\CASPER\Desktop\OneHealth VS\OneHealth\OneHealth\Views\News\Index.cshtml"
                     foreach (var news in Model.News)
                     {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-sm-6 py-3"">
                            <div class=""card-blog"">
                                <div class=""header"">
                                    <div class=""post-category"">
                                        <a href=""#"">y</a>
                                     </div>
                                    <a href=""blog-details"" class=""post-thumb"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f5eaf2ca2a4155932b6f2dcf99045d7d17637f3e6107", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 800, "~/Uploads/", 800, 10, true);
#nullable restore
#line 22 "C:\Users\CASPER\Desktop\OneHealth VS\OneHealth\OneHealth\Views\News\Index.cshtml"
AddHtmlAttributeValue("", 810, news.NewsImage, 810, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </a>\r\n                                </div>\r\n                                <div class=\"body\">\r\n                                    <h5 class=\"post-title\"><a href=\"blog-details.html\">");
#nullable restore
#line 26 "C:\Users\CASPER\Desktop\OneHealth VS\OneHealth\OneHealth\Views\News\Index.cshtml"
                                                                                  Write(news.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></h5>
                                    <div class=""site-info"">
                                        <div class=""avatar mr-2"">
                                            <div class=""avatar-img"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f5eaf2ca2a4155932b6f2dcf99045d7d17637f3e8465", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </div>\r\n                                            <span></span>\r\n                                        </div>\r\n                                        <span class=\"mai-time\"></span> ");
#nullable restore
#line 34 "C:\Users\CASPER\Desktop\OneHealth VS\OneHealth\OneHealth\Views\News\Index.cshtml"
                                                                  Write(news.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 39 "C:\Users\CASPER\Desktop\OneHealth VS\OneHealth\OneHealth\Views\News\Index.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



                    <div class=""col-12 my-5"">
                        <nav aria-label=""Page Navigation"">
                            <ul class=""pagination justify-content-center"">
                                <li class=""page-item disabled"">
                                    <a class=""page-link"" href=""#"" tabindex=""-1"" aria-disabled=""true"">Previous</a>
                                </li>
                                <li class=""page-item active"" aria-current=""page"">
                                    <a class=""page-link"" href=""#"">1 <span class=""sr-only"">(current)</span></a>
                                </li>
                                <li class=""page-item"">
                                    <a class=""page-link"" href=""#"">2</a>
                                </li>
                                <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                                <li class=""page-item"">
                                    <a class=""page-link"" hre");
            WriteLiteral(@"f=""#"">Next</a>
                                </li>
                            </ul>
                        </nav>
                    </div>
                </div> <!-- .row -->
            </div>
            <div class=""col-lg-4"">
                <div class=""sidebar"">
                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Search</h3>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5eaf2ca2a4155932b6f2dcf99045d7d17637f3e12011", async() => {
                WriteLiteral(@"
                            <div class=""form-group"">
                                <input type=""text"" class=""form-control"" placeholder=""Type a keyword and hit enter"">
                                <button type=""submit"" class=""btn""><span class=""icon mai-search""></span></button>
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
            WriteLiteral(@"
                    </div>
                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Categories</h3>
                        <ul class=""categories"">
                            <li><a href=""#"">Food <span>12</span></a></li>
                            <li><a href=""#"">Dish <span>22</span></a></li>
                            <li><a href=""#"">Desserts <span>37</span></a></li>
                            <li><a href=""#"">Drinks <span>42</span></a></li>
                            <li><a href=""#"">Ocassion <span>14</span></a></li>
                        </ul>
                    </div>

                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Recent Blog</h3>
                        <div class=""blog-item"">
                            <a class=""post-thumb""");
            BeginWriteAttribute("href", " href=\"", 4471, "\"", 4478, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"../assets/img/blog/blog_1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 4554, "\"", 4560, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""content"">
                                <h5 class=""post-title""><a href=""#"">Even the all-powerful Pointing has no control</a></h5>
                                <div class=""meta"">
                                    <a href=""#""><span class=""mai-calendar""></span> July 12, 2018</a>
                                    <a href=""#""><span class=""mai-person""></span> Admin</a>
                                    <a href=""#""><span class=""mai-chatbubbles""></span> 19</a>
                                </div>
                            </div>
                        </div>
                        <div class=""blog-item"">
                            <a class=""post-thumb""");
            BeginWriteAttribute("href", " href=\"", 5318, "\"", 5325, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"../assets/img/blog/blog_2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 5401, "\"", 5407, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""content"">
                                <h5 class=""post-title""><a href=""#"">Even the all-powerful Pointing has no control</a></h5>
                                <div class=""meta"">
                                    <a href=""#""><span class=""mai-calendar""></span> July 12, 2018</a>
                                    <a href=""#""><span class=""mai-person""></span> Admin</a>
                                    <a href=""#""><span class=""mai-chatbubbles""></span> 19</a>
                                </div>
                            </div>
                        </div>
                        <div class=""blog-item"">
                            <a class=""post-thumb""");
            BeginWriteAttribute("href", " href=\"", 6165, "\"", 6172, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"../assets/img/blog/blog_3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 6248, "\"", 6254, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </a>
                            <div class=""content"">
                                <h5 class=""post-title""><a href=""#"">Even the all-powerful Pointing has no control</a></h5>
                                <div class=""meta"">
                                    <a href=""#""><span class=""mai-calendar""></span> July 12, 2018</a>
                                    <a href=""#""><span class=""mai-person""></span> Admin</a>
                                    <a href=""#""><span class=""mai-chatbubbles""></span> 19</a>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Tag Cloud</h3>
                        <div class=""tagcloud"">
                            <a href=""#"" class=""tag-cloud-link"">dish</a>
                            <a href=""#"" class=""tag-cloud-link"">menu</a>
                          ");
            WriteLiteral(@"  <a href=""#"" class=""tag-cloud-link"">food</a>
                            <a href=""#"" class=""tag-cloud-link"">sweet</a>
                            <a href=""#"" class=""tag-cloud-link"">tasty</a>
                            <a href=""#"" class=""tag-cloud-link"">delicious</a>
                            <a href=""#"" class=""tag-cloud-link"">desserts</a>
                            <a href=""#"" class=""tag-cloud-link"">drinks</a>
                        </div>
                    </div>

                    <div class=""sidebar-block"">
                        <h3 class=""sidebar-title"">Paragraph</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ducimus itaque, autem necessitatibus voluptate quod mollitia delectus aut, sunt placeat nam vero culpa sapiente consectetur similique, inventore eos fugit cupiditate numquam!</p>
                    </div>
                </div>
            </div>
        </div> <!-- .row -->
    </div> <!-- .container -->
</div> <!-- .page-secti");
            WriteLiteral("on -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmNews> Html { get; private set; }
    }
}
#pragma warning restore 1591