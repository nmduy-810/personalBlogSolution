#pragma checksum "/Users/duynguyen/Documents/Development/NETCore/personalBlogSolution/personalBlogSolution.AdminApp/Views/Shared/_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "824eb19ea2f4c4c2ef267685df3e6a80057f6d26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "/Users/duynguyen/Documents/Development/NETCore/personalBlogSolution/personalBlogSolution.AdminApp/Views/_ViewImports.cshtml"
using personalBlogSolution.AdminApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/duynguyen/Documents/Development/NETCore/personalBlogSolution/personalBlogSolution.AdminApp/Views/_ViewImports.cshtml"
using personalBlogSolution.AdminApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"824eb19ea2f4c4c2ef267685df3e6a80057f6d26", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"722bff7eaef18698562e46db7872c32791c40fc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "824eb19ea2f4c4c2ef267685df3e6a80057f6d264552", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <title>Regal Admin</title>
    
    <!-- base:css -->
    <link rel=""stylesheet"" href=""vendors/feather/feather.css"">
    <link rel=""stylesheet"" href=""vendors/base/vendor.bundle.base.css"">
    <!-- end inject -->
    
    <!-- plugin css for this page -->
    <link rel=""stylesheet"" href=""vendors/flag-icon-css/css/flag-icon.min.css""/>
    <link rel=""stylesheet"" href=""vendors/font-awesome/css/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""vendors/jquery-bar-rating/fontawesome-stars-o.css"">
    <link rel=""stylesheet"" href=""vendors/jquery-bar-rating/fontawesome-stars.css"">
    <!-- End plugin css for this page -->
    
    <!-- inject:css -->
    <link rel=""stylesheet"" href=""css/style.css"">
    <!-- end inject -->
    
    <link rel=""shortcut icon"" href=""images/favicon.png""/>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "824eb19ea2f4c4c2ef267685df3e6a80057f6d266483", async() => {
                WriteLiteral(@"
<div class=""container-scroller"">
<!-- partial:partials/_navbar.html -->
<nav class=""navbar col-lg-12 col-12 p-0 fixed-top d-flex flex-row"">
    <div class=""text-center navbar-brand-wrapper d-flex align-items-center justify-content-center"">
        <a class=""navbar-brand brand-logo"" href=""/index.html"">
            <img src=""images/logo.svg"" alt=""logo""/>
        </a>
        <a class=""navbar-brand brand-logo-mini"" href=""/index.html"">
            <img src=""images/logo-mini.svg"" alt=""logo""/>
        </a>
    </div>
    <div class=""navbar-menu-wrapper d-flex align-items-center justify-content-end"">
        <button class=""navbar-toggler navbar-toggler align-self-center"" type=""button"" data-toggle=""minimize"">
            <span class=""icon-menu""></span>
        </button>
        <ul class=""navbar-nav mr-lg-2"">
            <li class=""nav-item nav-search d-none d-lg-block"">
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-te");
                WriteLiteral(@"xt"" id=""search"">
                            <i class=""icon-search""></i>
                        </span>
                    </div>
                    <input type=""text"" class=""form-control"" placeholder=""Search Projects.."" aria-label=""search"" aria-describedby=""search"">
                </div>
            </li>
        </ul>
        <ul class=""navbar-nav navbar-nav-right"">
            <li class=""nav-item dropdown d-lg-flex d-none"">
                <button type=""button"" class=""btn btn-info font-weight-bold"">+ Create New</button>
            </li>
            <li class=""nav-item dropdown d-flex"">
                <a class=""nav-link count-indicator dropdown-toggle d-flex justify-content-center align-items-center"" id=""messageDropdown"" href=""#"" data-toggle=""dropdown"">
                    <i class=""icon-air-play mx-0""></i>
                </a>
                <div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""messageDropdown"">
                    <p class=""mb-0 font-weight-no");
                WriteLiteral(@"rmal float-left dropdown-header"">Messages</p>
                    <a class=""dropdown-item preview-item"">
                        <div class=""preview-thumbnail"">
                            <img src=""images/faces/face4.jpg"" alt=""image"" class=""profile-pic"">
                        </div>
                        <div class=""preview-item-content flex-grow"">
                            <h6 class=""preview-subject ellipsis font-weight-normal"">
                                David Grey
                            </h6>
                            <p class=""font-weight-light small-text text-muted mb-0"">
                                The meeting is cancelled
                            </p>
                        </div>
                    </a>
                    <a class=""dropdown-item preview-item"">
                        <div class=""preview-thumbnail"">
                            <img src=""images/faces/face2.jpg"" alt=""image"" class=""profile-pic"">
                        </div>
                        <div class");
                WriteLiteral(@"=""preview-item-content flex-grow"">
                            <h6 class=""preview-subject ellipsis font-weight-normal"">
                                Tim Cook
                            </h6>
                            <p class=""font-weight-light small-text text-muted mb-0"">
                                New product launch
                            </p>
                        </div>
                    </a>
                    <a class=""dropdown-item preview-item"">
                        <div class=""preview-thumbnail"">
                            <img src=""images/faces/face3.jpg"" alt=""image"" class=""profile-pic"">
                        </div>
                        <div class=""preview-item-content flex-grow"">
                            <h6 class=""preview-subject ellipsis font-weight-normal"">
                                Johnson
                            </h6>
                            <p class=""font-weight-light small-text text-muted mb-0"">
                                Upcoming board mee");
                WriteLiteral(@"ting
                            </p>
                        </div>
                    </a>
                </div>
            </li>
            <li class=""nav-item dropdown d-flex mr-4 "">
                <a class=""nav-link count-indicator dropdown-toggle d-flex align-items-center justify-content-center"" id=""notificationDropdown"" href=""#"" data-toggle=""dropdown"">
                    <i class=""icon-cog""></i>
                </a>
                <div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""notificationDropdown"">
                    <p class=""mb-0 font-weight-normal float-left dropdown-header"">Settings</p>
                    <a class=""dropdown-item preview-item"">
                        <button class=""dropdown-item"" type=""submit""><i class=""icon-head""></i>Profile</button> 
                    </a>
                    <a class=""dropdown-item preview-item"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "824eb19ea2f4c4c2ef267685df3e6a80057f6d2612068", async() => {
                    WriteLiteral("\n                            <button class=\"dropdown-item\" type=\"submit\"><i class=\"icon-inbox\"></i>Logout</button>\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </a>
                </div>
            </li>
            <li class=""nav-item dropdown mr-4 d-lg-flex d-none"">
                <a class=""nav-link count-indicatord-flex align-item s-center justify-content-center"" href=""#"">
                    <i class=""icon-grid""></i>
                </a>
            </li>
        </ul>
        <button class=""navbar-toggler navbar-toggler-right d-lg-none align-self-center"" type=""button"" data-toggle=""offcanvas"">
            <span class=""icon-menu""></span>
        </button>
    </div>
</nav>
<!-- partial -->
<div class=""container-fluid page-body-wrapper"">
<!-- partial:partials/_sidebar.html -->
<nav class=""sidebar sidebar-offcanvas"" id=""sidebar"">
    <div class=""user-profile"">
        <div class=""user-image"">
            <img src=""images/faces/face28.png""");
                BeginWriteAttribute("alt", " alt=\"", 7059, "\"", 7065, 0);
                EndWriteAttribute();
                WriteLiteral(@">
        </div>
        <div class=""user-name"">
            Edward Spencer
        </div>
        <div class=""user-designation"">
            Developer
        </div>
    </div>
    <ul class=""nav"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/index.html"">
                <i class=""icon-box menu-icon""></i>
                <span class=""menu-title"">Dashboard</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""collapse"" href=""#ui-basic"" aria-expanded=""false"" aria-controls=""ui-basic"">
                <i class=""icon-disc menu-icon""></i>
                <span class=""menu-title"">UI Elements</span>
                <i class=""menu-arrow""></i>
            </a>
            <div class=""collapse"" id=""ui-basic"">
                <ul class=""nav flex-column sub-menu"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""pages/ui-features/buttons.html"">Buttons</a>
                    </li>
                ");
                WriteLiteral(@"    <li class=""nav-item"">
                        <a class=""nav-link"" href=""pages/ui-features/typography.html"">Typography</a>
                    </li>
                </ul>
            </div>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""pages/forms/basic_elements.html"">
                <i class=""icon-file menu-icon""></i>
                <span class=""menu-title"">Form elements</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""pages/charts/chartjs.html"">
                <i class=""icon-pie-graph menu-icon""></i>
                <span class=""menu-title"">Charts</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""pages/tables/basic-table.html"">
                <i class=""icon-command menu-icon""></i>
                <span class=""menu-title"">Tables</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""pages/icons/feather-ic");
                WriteLiteral(@"ons.html"">
                <i class=""icon-help menu-icon""></i>
                <span class=""menu-title"">Icons</span>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""collapse"" href=""#auth"" aria-expanded=""false"" aria-controls=""auth"">
                <i class=""icon-head menu-icon""></i>
                <span class=""menu-title"">User Pages</span>
                <i class=""menu-arrow""></i>
            </a>
            <div class=""collapse"" id=""auth"">
                <ul class=""nav flex-column sub-menu"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""pages/samples/login.html""> Login </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""pages/samples/login-2.html""> Login 2 </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""pages/samples/register.html""> Register </a>
            ");
                WriteLiteral(@"        </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""pages/samples/register-2.html""> Register 2 </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""pages/samples/lock-screen.html""> Lockscreen </a>
                    </li>
                </ul>
            </div>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/docs/documentation.html"">
                <i class=""icon-book menu-icon""></i>
                <span class=""menu-title"">Documentation</span>
            </a>
        </li>
    </ul>
</nav>
<!-- partial -->
<div class=""main-panel"">
    ");
#nullable restore
#line 233 "/Users/duynguyen/Documents/Development/NETCore/personalBlogSolution/personalBlogSolution.AdminApp/Views/Shared/_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
<!-- content-wrapper ends -->
<!-- partial:partials/_footer.html -->
<footer class=""footer"">
    <div class=""d-sm-flex justify-content-center justify-content-sm-between"">
        <span class=""text-muted d-block text-center text-sm-left d-sm-inline-block"">Copyright © bootstrapdash.com 2020</span>
        <span class=""float-none float-sm-right d-block mt-1 mt-sm-0 text-center""> Free <a href=""https://www.bootstrapdash.com/"" target=""_blank"">Bootstrap dashboard templates</a> from Bootstrapdash.com</span>
    </div>
</footer>
<!-- partial -->
</div>
<!-- main-panel ends -->
</div>
<!-- page-body-wrapper ends -->
</div>
<!-- container-scroller -->

<!-- base:js -->
<script src=""vendors/base/vendor.bundle.base.js""></script>
<!-- end inject -->

<!-- Plugin js for this page-->
<!-- End plugin js for this page-->

<!-- inject:js -->
<script src=""js/off-canvas.js""></script>
<script src=""js/hoverable-collapse.js""></script>
<script src=""js/template.js""></script>
<!-- end inject -->

<!-- plugin js for this page -->
<scri");
                WriteLiteral(@"pt src=""vendors/chart.js/Chart.min.js""></script>
<script src=""vendors/jquery-bar-rating/jquery.barrating.min.js""></script>
<!-- End plugin js for this page -->

<!-- Custom js for this page-->
<script src=""js/dashboard.js""></script>
<!-- End custom js for this page-->

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>");
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
