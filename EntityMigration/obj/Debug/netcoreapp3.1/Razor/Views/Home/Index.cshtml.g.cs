#pragma checksum "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7acacc27436dda0f26e0e9cb958d02c2b11d084"
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
#line 1 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\_ViewImports.cshtml"
using EntityMigration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\_ViewImports.cshtml"
using EntityMigration.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\_ViewImports.cshtml"
using EntityMigration.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7acacc27436dda0f26e0e9cb958d02c2b11d084", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76110aca6da9ed0f354d98448431f66b73abf1a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ProductsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n <!-- MAIN START -->\r\n<main>\r\n\r\n    <!-- SLIDER START -->\r\n\r\n    <section id=\"slider\">\r\n        <div class=\"owl-carousel slider\">\r\n");
#nullable restore
#line 10 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
             foreach (var item in Model.Sliders)
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div> <img");
            BeginWriteAttribute("src", " src=\"", 240, "\"", 261, 2);
            WriteAttributeValue("", 246, "img/", 246, 4, true);
#nullable restore
#line 12 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
WriteAttributeValue("", 250, item.Image, 250, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 262, "\"", 268, 0);
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n");
#nullable restore
#line 13 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"container context pl-lg-5 ml-lg-3\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-5\">\r\n                    <div class=\"text\">\r\n                        ");
#nullable restore
#line 19 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                   Write(Html.Raw(@Model.Detail.Header));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                       \r\n                        <p class=\"text-black-50 d-none d-sm-block\">\r\n                           ");
#nullable restore
#line 22 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                      Write(Model.Detail.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                    <div class=\"img\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 809, "\"", 838, 2);
            WriteAttributeValue("", 815, "img/", 815, 4, true);
#nullable restore
#line 26 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
WriteAttributeValue("", 819, Model.Detail.Image, 819, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 839, "\"", 845, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
        </div> 
    </section>

    <!-- SLIDER END -->
    <!-- PRODUCTS START -->

    <section id=""products"">
        <div class=""container"">
            <div class=""row pt-5"">
                <div class=""col-12 d-flex justify-content-between"">
                    <ul class=""category-mobile d-md-none list-unstyled"">
                        <li>
                            <a");
            BeginWriteAttribute("href", " href=\"", 1313, "\"", 1320, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\r\n                            <i class=\"fas fa-caret-down\"></i>\r\n                            <ul class=\"category list-unstyled\" style=\"display: none;\">\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1551, "\"", 1558, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 46 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                                 foreach (var item in Model.Categories)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a");
            BeginWriteAttribute("href", " href=\"", 1738, "\"", 1745, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 48 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                                                       Write(item.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 48 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 49 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </li>\r\n                    </ul>\r\n                    <ul class=\"category d-none d-md-flex list-unstyled\">\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2031, "\"", 2038, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n");
#nullable restore
#line 55 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                         foreach (var item in Model.Categories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2194, "\"", 2201, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 57 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                                               Write(item.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 57 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 58 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                    <ul class=\"list-unstyled\">\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2417, "\"", 2424, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\">Filter</a>\r\n                            <i class=\"fas fa-caret-down\"></i>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d7acacc27436dda0f26e0e9cb958d02c2b11d08410920", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 69 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Products;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
    </section>

    <!-- PRODUCTS END -->
    <!-- ABOUT START -->

    <section id=""about"">
        <div class=""container py-5"">
            <div class=""row py-5"">
                <div class=""col-lg-6"">
                    <div class=""img"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 3046, "\"", 3073, 2);
            WriteAttributeValue("", 3052, "img/", 3052, 4, true);
#nullable restore
#line 85 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
WriteAttributeValue("", 3056, Model.Videos.Url, 3056, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 3092, "\"", 3098, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"player position-absolute rounded-circle d-flex align-items-center justify-content-center\">\r\n                            <i");
            BeginWriteAttribute("class", " class=\"", 3260, "\"", 3286, 1);
#nullable restore
#line 87 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
WriteAttributeValue("", 3268, Model.Videos.Icon, 3268, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6\">\r\n                    <div class=\"about-text mt-5 mt-lg-0 px-lg-5\">\r\n                        ");
#nullable restore
#line 93 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.Valentines.Header));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <p class=\"py-3\">\r\n                            ");
#nullable restore
#line 95 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                       Write(Model.Valentines.Main);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <ul class=\"list-unstyled\">\r\n                            ");
#nullable restore
#line 98 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                       Write(Html.Raw(Model.Valentines.LiOne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 99 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                       Write(Html.Raw(Model.Valentines.LiSecond));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 100 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                       Write(Html.Raw(Model.Valentines.LiThird));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- ABOUT END -->
    <!-- EXPERTS START -->

    <section id=""experts"">
        <div class=""container"">
            <div class=""row py-5"">
                <div class=""offset-lg-3 col-lg-6"">
                    <div class=""section-title"">
                        <h1>");
#nullable restore
#line 116 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                       Write(Model.Experts.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p class=\"text-black-50\">\r\n                            ");
#nullable restore
#line 118 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                       Write(Model.Experts.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row pb-5\">\r\n");
#nullable restore
#line 124 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                 foreach (var item in Model.Employees)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 col-lg-3\">\r\n                        <div class=\"item text-center\">\r\n                            <div class=\"img\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 4871, "\"", 4892, 2);
            WriteAttributeValue("", 4877, "img/", 4877, 4, true);
#nullable restore
#line 129 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
WriteAttributeValue("", 4881, item.Image, 4881, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded-circle\"");
            BeginWriteAttribute("alt", " alt=\"", 4926, "\"", 4932, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"text mt-3\">\r\n                                <h6>");
#nullable restore
#line 132 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <p class=\"text-black-50\">");
#nullable restore
#line 133 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                                                    Write(item.Job);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 137 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
               
                <div class=""col-lg-3""></div>
                <div class=""col-lg-3""></div>
                <div class=""col-lg-3""></div>
            </div>
        </div>
    </section>

    <!-- EXPERTS END -->
    <!-- SUBSCRIBE START -->

    <section id=""subscribe"">
        <div class=""container py-5"">
            <div class=""row py-5"">
                <div class=""col-12"">
                    <div class=""content text-center py-5"">
                        <h3>Join The Colorful Bunch!</h3>
                        <div class=""form-group d-flex justify-content-center flex-wrap mt-5"">
                            <input type=""email"" placeholder=""Email Address"" class=""form-control-lg rounded-0"">
                            <button class=""btn btn-danger btn-lg rounded-0 px-5 mt-3 mt-sm-0"">Subscribe</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SUBSCRIBE END -->
    <!-");
            WriteLiteral("- BLOG START -->\r\n\r\n    <section id=\"blog\">\r\n        <div class=\"container\">\r\n            <div class=\"row py-5\">\r\n                <div class=\"offset-lg-3 col-lg-6\">\r\n                    <div class=\"section-title\">\r\n                        <h1>");
#nullable restore
#line 174 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                       Write(Model.Blogs.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p class=\"text-black-50\">\r\n                          ");
#nullable restore
#line 176 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                     Write(Model.Blogs.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row pb-5\">\r\n");
#nullable restore
#line 182 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                 foreach (var item in Model.BlogCards)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6 col-lg-4\">\r\n                    <div class=\"item\">\r\n                        <div class=\"img position-relative\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 7055, "\"", 7077, 2);
            WriteAttributeValue("", 7061, "img/", 7061, 4, true);
#nullable restore
#line 187 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
WriteAttributeValue("", 7065, item.Images, 7065, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 7096, "\"", 7102, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"date rounded bg-light position-absolute py-1 px-2\">\r\n                                <span>");
#nullable restore
#line 189 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                                 Write(item.dateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"text mt-3 text-center px-5\">\r\n                            <h5>");
#nullable restore
#line 193 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"text-black-50\">\r\n                                ");
#nullable restore
#line 195 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 200 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"             
            </div>
        </div>
    </section>

    <!-- BLOG END -->
    <!-- SAY START -->

    <section id=""say"">
        <div class=""container"">
            <div class=""row py-5 justify-content-center"">
                <div class=""col-md-8 col-xl-6"">
                    <div class=""owl-carousel say"">
");
#nullable restore
#line 214 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                         foreach (var item in Model.Employees)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                <div class=\"item text-center\">\r\n                                    <div class=\"img d-flex justify-content-center\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 8340, "\"", 8361, 2);
            WriteAttributeValue("", 8346, "img/", 8346, 4, true);
#nullable restore
#line 219 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
WriteAttributeValue("", 8350, item.Image, 8350, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 8362, "\"", 8368, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </div>\r\n                                    <div class=\"text text-muted pt-3 pb-5\">\r\n                                        <i>\r\n                                           ");
#nullable restore
#line 223 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                                      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </i>\r\n                                    </div>\r\n                                    <div class=\"author\">\r\n                                        <h6>");
#nullable restore
#line 227 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                        <p class=\"text-black-50\">");
#nullable restore
#line 228 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                                                            Write(item.Job);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 232 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SAY END -->
    <!-- INSTAGRAM START -->

    <section id=""instagram"">
        <div class=""owl-carousel instagram"">
");
#nullable restore
#line 245 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
             foreach (var item in Model.InstaCarousels)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div><img");
            BeginWriteAttribute("src", " src=\"", 9395, "\"", 9416, 2);
            WriteAttributeValue("", 9401, "img/", 9401, 4, true);
#nullable restore
#line 247 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
WriteAttributeValue("", 9405, item.Image, 9405, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 9435, "\"", 9441, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 248 "C:\Users\hp\Desktop\New folder\EntityMigration\EntityMigration\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n        <div class=\"hastag bg-light text-muted py-2 px-3\">\r\n            #FIORELLO\r\n        </div>\r\n    </section>\r\n\r\n    <!-- INSTAGRAM END -->\r\n\r\n</main>\r\n\r\n<!-- MAIN END -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
