#pragma checksum "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "123910a885cd0fd2b67c46170e238c697ecaafbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LawyerInfo_Profile), @"mvc.1.0.view", @"/Views/LawyerInfo/Profile.cshtml")]
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
#line 1 "D:\Projects\Encyclopedia of laws\Views\_ViewImports.cshtml"
using Encyclopedia_Of_Laws;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Encyclopedia of laws\Views\_ViewImports.cshtml"
using Encyclopedia_Of_Laws.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\Encyclopedia of laws\Views\_ViewImports.cshtml"
using Encyclopedia_Of_Laws.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\Encyclopedia of laws\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"123910a885cd0fd2b67c46170e238c697ecaafbf", @"/Views/LawyerInfo/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a913c27688d65fef86afce11526088ba5fdc769b", @"/Views/_ViewImports.cshtml")]
    public class Views_LawyerInfo_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Encyclopedia_Of_Laws.Models.LawyerInfo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/user-male.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""pagetitle"">
    <h1>View Lawyer Profile</h1>
    <nav>
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
            <li class=""breadcrumb-item"">Lawyers</li>
            <li class=""breadcrumb-item active"">Lawyer profile</li>
        </ol>
    </nav>
</div><!-- End Page Title -->

<section class=""section profile"">
    <div class=""row"">
        <div class=""col-xl-4"">

            <div class=""card"">
                <div class=""card-body profile-card pt-4 d-flex flex-column align-items-center"">

");
#nullable restore
#line 26 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
                     if (Model.User.ProfilePicture != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "123910a885cd0fd2b67c46170e238c697ecaafbf6409", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 843, "~/images/", 843, 9, true);
#nullable restore
#line 28 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
AddHtmlAttributeValue("", 852, Model.User.ProfilePicture, 852, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "123910a885cd0fd2b67c46170e238c697ecaafbf8324", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 33 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n                    <h2> ");
#nullable restore
#line 35 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
                    Write(Html.DisplayFor(model => model.User.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h2>
                    <h3> </h3>
                    <div class=""social-links mt-2"">
                        <a href=""#"" class=""twitter""><i class=""bi bi-twitter""></i></a>
                        <a href=""#"" class=""facebook""><i class=""bi bi-facebook""></i></a>
                        <a href=""#"" class=""instagram""><i class=""bi bi-instagram""></i></a>
                        <a href=""#"" class=""linkedin""><i class=""bi bi-linkedin""></i></a>
                    </div>

                </div>
            </div>

        </div>

        <div class=""col-xl-8"">

            <div class=""card"">
                <div class=""card-body pt-3"">
                    <!-- Bordered Tabs -->
                    <ul class=""nav nav-tabs nav-tabs-bordered"">

                        <li class=""nav-item"">
                            <button class=""nav-link active"" data-bs-toggle=""tab"" data-bs-target=""#profile-overview"">Overview</button>
                        </li>

");
#nullable restore
#line 60 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
                         if (Model == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"nav-item\">\r\n                                <button class=\"nav-link\" data-bs-toggle=\"tab\" data-bs-target=\"#profile-create\">Profile</button>\r\n                            </li>\r\n");
#nullable restore
#line 65 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"nav-item\">\r\n                                <button class=\"nav-link\" data-bs-toggle=\"tab\" data-bs-target=\"#profile-edit\">Profile</button>\r\n                            </li>\r\n");
#nullable restore
#line 71 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </ul>

                    <div class=""tab-content pt-2"">

                        <div class=""tab-pane fade show active profile-overview"" id=""profile-overview"">
                            <h5 class=""card-title"">About</h5>
                            <p class=""small fst-italic"">");
#nullable restore
#line 80 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
                                                   Write(Html.DisplayFor(model => model.Information));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

                            <h5 class=""card-title"">Profile Details</h5>

                            <div class=""row"">
                                <div class=""col-lg-3 col-md-4 label"">Email</div>
                                <div class=""col-lg-9 col-md-8"">");
#nullable restore
#line 86 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
                                                          Write(Html.DisplayFor(model => model.User.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n\r\n                            <div class=\"row\">\r\n                                <div class=\"col-lg-3 col-md-4 label\">Name</div>\r\n                                <div class=\"col-lg-9 col-md-8\">");
#nullable restore
#line 91 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
                                                          Write(Html.DisplayFor(model => model.User.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 91 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
                                                                                                          Write(Html.DisplayFor(model => model.User.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n\r\n                            <div class=\"row\">\r\n                                <div class=\"col-lg-3 col-md-4 label\">Username</div>\r\n                                <div class=\"col-lg-9 col-md-8\">");
#nullable restore
#line 96 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
                                                          Write(Html.DisplayFor(model => model.User.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n\r\n                            <div class=\"row\">\r\n                                <div class=\"col-lg-3 col-md-4 label\">Specialization</div>\r\n                                <div class=\"col-lg-9 col-md-8\">");
#nullable restore
#line 101 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
                                                          Write(Html.DisplayFor(model => model.Specialization));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n\r\n                            <div class=\"row\">\r\n                                <div class=\"col-lg-3 col-md-4 label\">JopDescription</div>\r\n                                <div class=\"col-lg-9 col-md-8\">");
#nullable restore
#line 106 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
                                                          Write(Html.DisplayFor(model => model.JopDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n\r\n                            <div class=\"row\">\r\n                                <div class=\"col-lg-3 col-md-4 label\">OfficeLocation</div>\r\n                                <div class=\"col-lg-9 col-md-8\">");
#nullable restore
#line 111 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
                                                          Write(Html.DisplayFor(model => model.OfficeLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n\r\n                            <div class=\"row\">\r\n                                <div class=\"col-lg-3 col-md-4 label\">OfficeNumber</div>\r\n                                <div class=\"col-lg-9 col-md-8\">");
#nullable restore
#line 116 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
                                                          Write(Html.DisplayFor(model => model.OfficeNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n\r\n                        </div>\r\n\r\n");
#nullable restore
#line 121 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
                         if (Model == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"tab-pane fade pt-3\" id=\"profile-create\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "123910a885cd0fd2b67c46170e238c697ecaafbf17487", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 126 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"tab-pane fade pt-3\" id=\"profile-edit\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "123910a885cd0fd2b67c46170e238c697ecaafbf19022", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 132 "D:\Projects\Encyclopedia of laws\Views\LawyerInfo\Profile.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </div><!-- End Bordered Tabs -->\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Encyclopedia_Of_Laws.Models.LawyerInfo> Html { get; private set; }
    }
}
#pragma warning restore 1591
