#pragma checksum "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Event\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3701271380aaae81e9095a3beef7f8caca9ee58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Event_Detail), @"mvc.1.0.view", @"/Views/Event/Detail.cshtml")]
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
#line 1 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\_ViewImports.cshtml"
using EduHomeFrontToBack25062022.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\_ViewImports.cshtml"
using EduHomeFrontToBack25062022.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3701271380aaae81e9095a3beef7f8caca9ee58", @"/Views/Event/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b94b9e002193b50af18a14f38e29f0522064a44", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Event_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Event>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("800"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("event-details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("speaker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://demo.devitems.com/eduhome/mail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/blog/blog-img.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Event\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Views/Shared/_PagesLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <!-- Event Details Start -->
        <div class=""event-details-area blog-area pt-150 pb-140"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-8"">
                        <div class=""event-details"">
                            <div class=""event-details-img"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3701271380aaae81e9095a3beef7f8caca9ee588288", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 504, "~/img/event/", 504, 12, true);
#nullable restore
#line 14 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Event\Detail.cshtml"
AddHtmlAttributeValue("", 516, Model.imageUrl, 516, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <div class=\"event-date\">\r\n                                  <h3>");
#nullable restore
#line 16 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Event\Detail.cshtml"
                                 Write(Model.StartTime.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>jun</span></h3>  \r\n                                 </div>\r\n                            </div>\r\n                            <div class=\"event-details-content\">\r\n                                <h2>");
#nullable restore
#line 20 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Event\Detail.cshtml"
                               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <ul>\r\n                                    <li><span>time : </span>");
#nullable restore
#line 22 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Event\Detail.cshtml"
                                                       Write(Model.StartTime.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 22 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Event\Detail.cshtml"
                                                                             Write(Model.StartTime.Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral(" AM - ");
#nullable restore
#line 22 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Event\Detail.cshtml"
                                                                                                          Write(Model.EndTime.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 22 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Event\Detail.cshtml"
                                                                                                                              Write(Model.EndTime.Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral(" PM</li>\r\n                                    <li><span>venue : </span>Cristal Centre, 254 ");
#nullable restore
#line 23 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Event\Detail.cshtml"
                                                                            Write(Model.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                </ul>
                                <p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit asnatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui </p>
                                <p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem </p>
                                <p>I must explain to you how all this a mistaken idea of denouncing grea");
            WriteLiteral(@"t explorer of the rut the is lder of human happiness pcias unde omnis iste natus error sit voluptatem accusantium doloremque laudantium</p>
                                <div class=""speakers-area fix"">
                                    <h4>speakers</h4>
");
#nullable restore
#line 30 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Event\Detail.cshtml"
                                    foreach (var item in Model.EventTeachers)
                                  {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                       <div class=\"single-speaker\">\r\n                                        <div class=\"speaker-img\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3701271380aaae81e9095a3beef7f8caca9ee5814535", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2789, "~/img/teacher/", 2789, 14, true);
#nullable restore
#line 34 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Event\Detail.cshtml"
AddHtmlAttributeValue("", 2803, item.Teacher.ImageUrl, 2803, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"speaker-name\">\r\n                                            <h5>");
#nullable restore
#line 37 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Event\Detail.cshtml"
                                           Write(item.Teacher.FullName.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <p>");
#nullable restore
#line 38 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Event\Detail.cshtml"
                                          Write(item.Teacher.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                        </div>\r\n                                    </div>\n");
#nullable restore
#line 41 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Event\Detail.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                            </div>    
                            <div class=""reply-area"">
                                <h3>LEAVE A REPLY</h3>
                                <p>I must explain to you how all this a mistaken idea of ncing great explorer of the rut<br> the is lder of human happinescias unde omnis iste natus error sit volptatem </p>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3701271380aaae81e9095a3beef7f8caca9ee5817790", async() => {
                WriteLiteral(@"
                                    <div class=""row"">
                                        <div class=""col-md-12"">
                                            <p>Name</p>
                                            <input type=""text"" name=""name"" id=""name"">
                                        </div>
                                        <div class=""col-md-12"">
                                            <p>Email</p>
                                            <input type=""text"" name=""email"" id=""email"">
                                        </div>
                                        <div class=""col-md-12"">
                                            <p>Subject</p>
                                            <input type=""text"" name=""subject"" id=""subject"">
                                            <p>Massage</p>
                                            <textarea name=""message"" id=""message"" cols=""15"" rows=""10""></textarea>
                                        </div>
         ");
                WriteLiteral("                           </div>\r\n                                    <a class=\"reply-btn\" href=\"#\" data-text=\"send\"><span>send message</span></a>\r\n                                    <p class=\"form-messege\"></p>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""blog-sidebar right"">
                            <div class=""single-blog-widget mb-50"">
                                <h3>search</h3>
                                <div class=""blog-search"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3701271380aaae81e9095a3beef7f8caca9ee5821156", async() => {
                WriteLiteral(@"
                                        <input type=""search"" placeholder=""Search..."" name=""search"" />
                                        <button type=""submit"">
                                            <span><i class=""fa fa-search""></i></span>
                                        </button>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""single-blog-widget mb-50"">
                                <h3>categories</h3>
                                <ul>
                                    <li><a href=""#"">CSS Engineering (10)</a></li>
                                    <li><a href=""#"">Political Science (12)</a></li>
                                    <li><a href=""#"">Micro Biology (08)</a></li>
                                    <li><a href=""#"">HTML5 &amp; CSS3 (15)</a></li>
                                    <li><a href=""#"">Web Design (20)</a></li>
                                    <li><a href=""#"">PHP (23)</a></li>
                                </ul>
                            </div>
                            <div class=""single-blog-widget mb-50"">
                                <div class=""single-blog-banner"">
                                    <a href=""blog-details.html"" id=""blog"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a3701271380aaae81e9095a3beef7f8caca9ee5823925", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                                    <h2>best<br> eductaion<br> theme</h2> 
                                </div>
                            </div>
                            <div class=""single-blog-widget mb-50"">
                                <h3>latest post</h3>
                                                               ");
#nullable restore
#line 102 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Event\Detail.cshtml"
                                                          Write(await Component.InvokeAsync("SideBlog",3));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </div>
                            <div class=""single-blog-widget"">
                                <h3>tags</h3>
                                <div class=""single-tag"">
                                    <a href=""blog-details.html"" class=""mr-10 mb-10"">course</a>
                                    <a href=""blog-details.html"" class=""mr-10 mb-10"">education</a>
                                    <a href=""blog-details.html"" class=""mb-10"">teachers</a>
                                    <a href=""blog-details.html"" class=""mr-10"">learning</a>
                                    <a href=""blog-details.html"" class=""mr-10"">university</a>
                                    <a href=""blog-details.html"">events</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Event Details End -->


");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Event> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
