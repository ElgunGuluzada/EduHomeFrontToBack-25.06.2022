#pragma checksum "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24737ebee1139b216b83a78aa769fd4a16894eb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24737ebee1139b216b83a78aa769fd4a16894eb5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b94b9e002193b50af18a14f38e29f0522064a44", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://devitems.us11.list-manage.com/subscribe/post?u=6bbb9b6f5827bd842d9640c82&amp;id=05d85f18ef"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mc-embedded-subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("mc-embedded-subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("validate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t<!-- Background Area Start -->\r\n        <section id=\"slider-container\" class=\"slider-area\"> \r\n            <div class=\"slider-owl owl-theme owl-carousel\"> \r\n");
#nullable restore
#line 9 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Home\Index.cshtml"
                 foreach (var item in Model.Sliders)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!-- Start Slingle Slide -->\r\n                <div class=\"single-slide item\"");
            BeginWriteAttribute("style", " style=\"", 378, "\"", 434, 4);
            WriteAttributeValue("", 386, "background-image:", 386, 17, true);
            WriteAttributeValue(" ", 403, "url(img/slider/", 404, 16, true);
#nullable restore
#line 12 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Home\Index.cshtml"
WriteAttributeValue("", 419, item.ImageUrl, 419, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 433, ")", 433, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    <!-- Start Slider Content -->
                    <div class=""slider-content-area"">  
                        <div class=""container"">
                            <div class=""row"">
                                <div class=""col-md-7 col-md-offset-left-5""> 
                                    <div class=""slide-content-wrapper"">
                                        <div class=""slide-content"">
                                           ");
#nullable restore
#line 20 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Home\Index.cshtml"
                                      Write(Html.Raw(Model.SliderContent.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            <p>");
#nullable restore
#line 21 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Home\Index.cshtml"
                                          Write(Model.SliderContent.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                            <a class=\"default-btn\" href=\"about.html\">");
#nullable restore
#line 22 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Home\Index.cshtml"
                                                                                Write(Model.SliderContent.Button);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Start Slider Content -->
                </div>
                <!-- End Slingle Slide -->
");
#nullable restore
#line 32 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </section>
		<!-- Background Area End -->
        <!-- Notice Start -->
        <section class=""notice-area pt-150 pb-150"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-6 col-sm-6 col-xs-12"">
                        <div class=""notice-left"">
                            <h3>notice board</h3>
");
#nullable restore
#line 43 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Home\Index.cshtml"
                            foreach (var item in Model.NoticeLeftSides)
                          {

#line default
#line hidden
#nullable disable
            WriteLiteral("                              <div class=\"single-notice-left mb-25 pb-35\">\r\n                                <h4>");
#nullable restore
#line 46 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Home\Index.cshtml"
                               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 47 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Home\Index.cshtml"
                              Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            </div> \n");
#nullable restore
#line 49 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Home\Index.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                        <div class=\"notice-right\">\r\n");
#nullable restore
#line 58 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Home\Index.cshtml"
                            foreach (var item in Model.NoticeRightSides)
                          {

#line default
#line hidden
#nullable disable
            WriteLiteral("                              <div class=\"single-notice-right mb-25 pb-25\">\r\n                                <h3>");
#nullable restore
#line 61 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Home\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p>");
#nullable restore
#line 62 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Home\Index.cshtml"
                              Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            </div>  \n");
#nullable restore
#line 64 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Home\Index.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- Notice End -->
        <!-- Choose Start -->
      <section class=""choose-area pb-85 pt-77"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-8 col-md-offset-left-4 col-sm-8 col-md-offset-left-4"">
                        <div class=""choose-content text-left"">
                            <h2>");
#nullable restore
#line 77 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Home\Index.cshtml"
                           Write(Model.Choose.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            ");
#nullable restore
#line 78 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Home\Index.cshtml"
                       Write(Html.Raw(Model.Choose.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <a class=\"default-btn\" href=\"course-details.html\">");
#nullable restore
#line 79 "D:\Asp.NetCore\EduHomeFrontToBack25062022\EduHomeFrontToBack25062022\Views\Home\Index.cshtml"
                                                                         Write(Model.Choose.Button);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                        </div>  
                    </div>
                </div>
            </div>
        </section>
        <!-- Choose Area End -->
        <!-- Courses Area Start -->
        <div class=""courses-area pt-150 text-center"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xs-12"">
                        <div class=""section-title"">
                            <img src=""img/icon/section.png"" alt=""section-title"">
                            <h2>COURSES WE OFFER</h2>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-4 col-sm-6 col-xs-12"">
                        <div class=""single-course"">
                            <div class=""course-img"">
                                <a href=""course-details.html""><img src=""img/course/course1.jpg"" alt=""course"">
                                    <div class=""course-hove");
            WriteLiteral(@"r"">
                                        <i class=""fa fa-link""></i>
                                    </div>
                                </a>
                            </div>
                            <div class=""course-content"">
                                <h3><a href=""course-details.html"">CSE ENGINEERING</a></h3>
                                <p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness</p>
                                <a class=""default-btn"" href=""course-details.html"">read more</a>
                            </div>   
                        </div>
                    </div>
                    <div class=""col-md-4 col-sm-6 col-xs-12"">
                        <div class=""single-course"">
                            <div class=""course-img"">
                                <a href=""course-details.html""><img src=""img/course/course2.jpg"" alt=""course"">
                                    <div cla");
            WriteLiteral(@"ss=""course-hover"">
                                        <i class=""fa fa-link""></i>
                                    </div>
                                </a>
                            </div>
                            <div class=""course-content"">
                                <h3><a href=""course-details.html"">CSE ENGINEERING</a></h3>
                                <p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness</p>
                                <a class=""default-btn"" href=""course-details.html"">read more</a>
                            </div>   
                        </div>
                    </div>
                    <div class=""col-md-4 hidden-sm col-xs-12"">
                        <div class=""single-course"">
                            <div class=""course-img"">
                                <a href=""course-details.html""><img src=""img/course/course3.jpg"" alt=""course"">
                            ");
            WriteLiteral(@"        <div class=""course-hover"">
                                        <i class=""fa fa-link""></i>
                                    </div>
                                </a>
                            </div>
                            <div class=""course-content"">
                                <h3><a href=""course-details.html"">CSE ENGINEERING</a></h3>
                                <p>I must explain to you how all this a mistaken idea of denouncing great explorer of the rut the is lder of human happiness</p>
                                <a class=""default-btn"" href=""course-details.html"">read more</a>
                            </div>   
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Courses Area End -->
        <!-- Event Area Start -->
        <div class=""event-area one text-center pt-140 pb-150"">
            <div class=""container"">
                <div class=""row"">
                     <div cl");
            WriteLiteral(@"ass=""col-xs-12"">
                        <div class=""section-title"">
                            <img src=""img/icon/section.png"" alt=""section-title"">
                            <h2>UPCOMMING EVENTS</h2>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-6 col-sm-12 col-xs-12"">
                        <div class=""single-event mb-35"">
                            <div class=""event-date"">
                                <h3><a href=""event-details.html"">20 <span>June</span></a></h3>
                            </div>
                            <div class=""event-content text-left"">
                                <div class=""event-content-left"">
                                    <h4><a href=""event-details.html"">MICRO BIOLOGICAL WORKSHOP</a></h4>
                                    <ul>
                                        <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
            ");
            WriteLiteral(@"                            <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                                    </ul>
                                </div>
                                <div class=""event-content-right"">
                                    <a class=""default-btn"" href=""event-details.html"">join now</a>
                                </div>
                            </div>
                        </div>
                        <div class=""single-event mb-35"">
                            <div class=""event-date"">
                                <h3><a href=""event-details.html"">18 <span>June</span></a></h3>
                            </div>
                            <div class=""event-content text-left"">
                                <div class=""event-content-left"">
                                    <h4><a href=""event-details.html"">ADVANCE PHP WORKSHOP</a></h4>
                                    <ul>
                                        <li><i class=""fa fa-clo");
            WriteLiteral(@"ck-o""></i>9.00 AM - 4.45 PM</li>
                                        <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                                    </ul>
                                </div>
                                <div class=""event-content-right"">
                                    <a class=""default-btn"" href=""event-details.html"">join now</a>
                                </div>
                            </div>
                        </div>
                        <div class=""single-event mb-35"">
                            <div class=""event-date"">
                                <h3><a href=""event-details.html"">16 <span>June</span></a></h3>
                            </div>
                            <div class=""event-content text-left"">
                                <div class=""event-content-left"">
                                    <h4><a href=""event-details.html"">LEARN ENGLISH HISTORY</a></h4>
                                    <ul>
                ");
            WriteLiteral(@"                        <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                                        <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                                    </ul>
                                </div>
                                <div class=""event-content-right"">
                                    <a class=""default-btn"" href=""event-details.html"">join now</a>
                                </div>
                            </div>
                        </div>
                        <div class=""single-event"">
                            <div class=""event-date"">
                                <h3><a href=""event-details.html"">14 <span>June</span></a></h3>
                            </div>
                            <div class=""event-content text-left"">
                                <div class=""event-content-left"">
                                    <h4><a href=""event-details.html"">GLOBAL ECONOMIC CONFERENCE</a></h4>
            ");
            WriteLiteral(@"                        <ul>
                                        <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                                        <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                                    </ul>
                                </div>
                                <div class=""event-content-right"">
                                    <a class=""default-btn"" href=""event-details.html"">join now</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-6 hidden-sm hidden-xs"">
                        <div class=""single-event mb-35"">
                            <div class=""event-date"">
                                <h3><a href=""event-details.html"">12 <span>June</span></a></h3>
                            </div>
                            <div class=""event-content text-left"">
                                <div cla");
            WriteLiteral(@"ss=""event-content-left"">
                                    <h4><a href=""event-details.html"">MATHEMATICAL WORKSHOP</a></h4>
                                    <ul>
                                        <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                                        <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                                    </ul>
                                </div>
                                <div class=""event-content-right"">
                                    <a class=""default-btn"" href=""event-details.html"">join now</a>
                                </div>
                            </div>
                        </div>
                        <div class=""single-event mb-35"">
                            <div class=""event-date"">
                                <h3><a href=""event-details.html"">10 <span>June</span></a></h3>
                            </div>
                            <div class=""event-content text-l");
            WriteLiteral(@"eft"">
                                <div class=""event-content-left"">
                                    <h4><a href=""event-details.html"">WORDPRESS AUTHOR MEET UP</a></h4>
                                    <ul>
                                        <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                                        <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                                    </ul>
                                </div>
                                <div class=""event-content-right"">
                                    <a class=""default-btn"" href=""event-details.html"">join now</a>
                                </div>
                            </div>
                        </div>
                        <div class=""single-event mb-35"">
                            <div class=""event-date"">
                                <h3><a href=""event-details.html"">08 <span>June</span></a></h3>
                            </div>
          ");
            WriteLiteral(@"                  <div class=""event-content text-left"">
                                <div class=""event-content-left"">
                                    <h4><a href=""event-details.html"">DIGITAL MARKETING ANALYSIS</a></h4>
                                    <ul>
                                        <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                                        <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                                    </ul>
                                </div>
                                <div class=""event-content-right"">
                                    <a class=""default-btn"" href=""event-details.html"">join now</a>
                                </div>
                            </div>
                        </div>
                        <div class=""single-event"">
                            <div class=""event-date"">
                                <h3><a href=""event-details.html"">06 <span>June</span></a></h3>
");
            WriteLiteral(@"                            </div>
                            <div class=""event-content text-left"">
                                <div class=""event-content-left"">
                                    <h4><a href=""event-details.html"">WROKSHOP ON UI &amp; UX</a></h4>
                                    <ul>
                                        <li><i class=""fa fa-clock-o""></i>9.00 AM - 4.45 PM</li>
                                        <li><i class=""fa fa-map-marker""></i>New Yourk City</li>
                                    </ul>
                                </div>
                                <div class=""event-content-right"">
                                    <a class=""default-btn"" href=""event-details.html"">join now</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Event Area End -->
        <!-- Testimonial Area Start --");
            WriteLiteral(@">
        <div class=""testimonial-area pt-110 pb-105 text-center"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""testimonial-owl owl-theme owl-carousel"">
                        <div class=""col-md-8 col-md-offset-2 col-sm-12"">
                            <div class=""single-testimonial"">
                                <div class=""testimonial-info"">
                                    <div class=""testimonial-img"">
                                        <img src=""img/testimonial/testimonial.jpg"" alt=""testimonial"">
                                    </div>
                                    <div class=""testimonial-content"">
                                        <p>I must explain to you how all this mistaken idea of denoung pleure and praising pain was born and I will give you a coete account of the system, and expound the actual</p>
                                        <h4>David Morgan</h4>
                                        <h5>S");
            WriteLiteral(@"tudent, CSE</h5>
                                    </div>
                                </div>
                            </div>
                        </div> 
                    </div>
                </div>
            </div>
        </div>
        <!-- Testimonial Area End -->
        <!-- Blog Area Start -->
        <div class=""blog-area pt-150 pb-150"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xs-12"">
                        <div class=""section-title text-center"">
                            <img src=""img/icon/section.png"" alt=""section-title"">
                            <h2>LATEST FROM BLOG</h2>
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-4 col-sm-6 col-xs-12"">
                        <div class=""single-blog"">
                            <div class=""blog-img"">
                                <a href=""");
            WriteLiteral(@"blog-details.html""><img src=""img/blog/blog1.jpg"" alt=""blog""></a>
                                <div class=""blog-hover"">
                                    <a href=""blog-details.html""><i class=""fa fa-link""></i></a>
                                </div>
                            </div>
                            <div class=""blog-content"">
                                <div class=""blog-top"">
                                    <p>By Alex  /  June 20, 2017  /  <i class=""fa fa-comments-o""></i> 4</p>
                                </div>
                                <div class=""blog-bottom"">
                                    <h2><a href=""blog-details.html"">I must explain to you how all this a mistaken idea </a></h2>
                                    <a href=""blog-details.html"">read more</a>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-4 col-sm-6 col-xs-12"">
");
            WriteLiteral(@"                        <div class=""single-blog"">
                            <div class=""blog-img"">
                                <a href=""blog-details.html""><img src=""img/blog/blog2.jpg"" alt=""blog""></a>
                                <div class=""blog-hover"">
                                    <a href=""blog-details.html""><i class=""fa fa-link""></i></a>
                                </div>
                            </div>
                            <div class=""blog-content"">
                                <div class=""blog-top"">
                                    <p>By Alex  /  June 20, 2017  /  <i class=""fa fa-comments-o""></i> 4</p>
                                </div>
                                <div class=""blog-bottom"">
                                    <h2><a href=""blog-details.html"">I must explain to you how all this a mistaken idea </a></h2>
                                    <a href=""blog-details.html"">read more</a>
                                </div>
               ");
            WriteLiteral(@"             </div>
                        </div>
                    </div>
                    <div class=""col-md-4 hidden-sm col-xs-12"">
                        <div class=""single-blog"">
                            <div class=""blog-img"">
                                <a href=""blog-details.html""><img src=""img/blog/blog3.jpg"" alt=""blog""></a>
                                <div class=""blog-hover"">
                                    <a href=""blog-details.html""><i class=""fa fa-link""></i></a>
                                </div>
                            </div>
                            <div class=""blog-content"">
                                <div class=""blog-top"">
                                    <p>By Alex  /  June 20, 2017  /  <i class=""fa fa-comments-o""></i> 4</p>
                                </div>
                                <div class=""blog-bottom"">
                                    <h2><a href=""blog-details.html"">I must explain to you how all this a mistaken idea ");
            WriteLiteral(@"</a></h2>
                                    <a href=""blog-details.html"">read more</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Blog Area End -->
        <!-- Subscribe Start -->
        <div class=""subscribe-area pt-60 pb-70"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-8 col-md-offset-2"">
                        <div class=""subscribe-content section-title text-center"">
                            <h2>subscribe our newsletter</h2>
                            <p>I must explain to you how all this mistaken idea </p>
                        </div>
                        <div class=""newsletter-form mc_embed_signup"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24737ebee1139b216b83a78aa769fd4a16894eb533856", async() => {
                WriteLiteral("\r\n                                <div id=\"mc_embed_signup_scroll\" class=\"mc-form\"> \r\n                                    <input type=\"email\"");
                BeginWriteAttribute("value", " value=\"", 23502, "\"", 23510, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""EMAIL"" class=""email"" id=""mce-EMAIL"" placeholder=""Enter your e-mail address"" required>
                                    <!-- real people should not fill this in and expect good things - do not remove this or risk form bot signups-->
                                    <div class=""mc-news"" aria-hidden=""true""><input type=""text"" name=""b_6bbb9b6f5827bd842d9640c82_05d85f18ef"" tabindex=""-1""");
                BeginWriteAttribute("value", " value=\"", 23909, "\"", 23917, 0);
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                                    <button id=\"mc-embedded-subscribe\" class=\"default-btn\" type=\"submit\" name=\"subscribe\"><span>subscribe</span></button> \r\n                                </div>    \r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <!-- mailchimp-alerts Start -->
                            <div class=""mailchimp-alerts"">
                                <div class=""mailchimp-submitting""></div><!-- mailchimp-submitting end -->
                                <div class=""mailchimp-success""></div><!-- mailchimp-success end -->
                                <div class=""mailchimp-error""></div><!-- mailchimp-error end -->
                            </div>
                            <!-- mailchimp-alerts end -->
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Subscribe End -->

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591