#pragma checksum "F:\REPOTEQ\BunicherSystem\BunicherSystem\Core.Admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a35e6aedbb4fb0854856cf9a3065c2722ade15fb"
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
#line 1 "F:\REPOTEQ\BunicherSystem\BunicherSystem\Core.Admin\Views\_ViewImports.cshtml"
using Core.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\REPOTEQ\BunicherSystem\BunicherSystem\Core.Admin\Views\_ViewImports.cshtml"
using Core.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a35e6aedbb4fb0854856cf9a3065c2722ade15fb", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feddaf0402013db547d7276aae0d65373cc4ef30", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("dir", new global::Microsoft.AspNetCore.Html.HtmlString("rtl"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!doctype html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a35e6aedbb4fb0854856cf9a3065c2722ade15fb3605", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">

    <!-- Meta -->
    <meta name=""description"" content=""Responsive Bootstrap4 Dashboard Template"">
    <meta name=""author"" content=""ParkerThemes"">
    <link rel=""shortcut icon"" href=""images/logo-darkText.png"" />

    <!-- Title -->
    <title>");
#nullable restore
#line 15 "F:\REPOTEQ\BunicherSystem\BunicherSystem\Core.Admin\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Titles);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>


    <!-- *************
        ************ Common Css Files *************
    ************ -->
    <!-- Bootstrap css -->
    <link rel=""stylesheet"" href=""/css/bootstrap.min.css"">

    <!-- Icomoon Font Icons css -->
    <link rel=""stylesheet"" href=""/fonts/style.css"">

    <!-- Main css -->
    <link rel=""stylesheet"" href=""/css/main.css"">




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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a35e6aedbb4fb0854856cf9a3065c2722ade15fb5606", async() => {
                WriteLiteral(@"




    <!-- *************
        ************ Header section start *************
    ************* -->
    <!-- Header start -->
    <header class=""header"">
        <div class=""logo-wrapper"">
            <a href=""index.html"" class=""logo"">
                <img src=""/images/logo-darkText.png"" alt=""BANSHER"" />
            </a>

        </div>

    </header>
    <!-- Header end -->
    <!-- Screen overlay start -->
    <div class=""screen-overlay""></div>
    <!-- Screen overlay end -->
    <!-- *************
        ************ Header section end *************
    ************* -->
    <!-- Container fluid start -->
    <div class=""container-fluid"">

        <!-- Navigation start -->
        <nav class=""navbar navbar-expand-lg custom-navbar"">
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#WafiAdminNavbar"" aria-controls=""WafiAdminNavbar"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-");
                WriteLiteral(@"icon"">
                    <i></i>
                    <i></i>
                    <i></i>
                </span>
            </button>
            <div class=""collapse navbar-collapse"" id=""WafiAdminNavbar"">
                <ul class=""navbar-nav"">
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link """);
                BeginWriteAttribute("href", " href=\"", 2241, "\"", 2275, 1);
#nullable restore
#line 74 "F:\REPOTEQ\BunicherSystem\BunicherSystem\Core.Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2248, Url.Action("Index","User"), 2248, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" id=""appsDropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""icon-inbox nav-icon""></i>
                            الرئيسية
                        </a>

                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link """);
                BeginWriteAttribute("href", " href=\"", 2612, "\"", 2649, 1);
#nullable restore
#line 81 "F:\REPOTEQ\BunicherSystem\BunicherSystem\Core.Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2619, Url.Action("Index","Service"), 2619, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" id=""appsDropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""icon-layers2 nav-icon""></i>
                            الخدمات
                        </a>

                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link "" href=""#"" id=""appsDropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""icon-layers1 nav-icon""></i>
                            الفواتير
                        </a>

                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link """);
                BeginWriteAttribute("href", " href=\"", 3334, "\"", 3370, 1);
#nullable restore
#line 95 "F:\REPOTEQ\BunicherSystem\BunicherSystem\Core.Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3341, Url.Action("Reports","User"), 3341, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" id=""appsDropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""icon-edit1 nav-icon""></i>
                            التقارير
                        </a>

                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link active-page""");
                BeginWriteAttribute("href", " href=\"", 3718, "\"", 3756, 1);
#nullable restore
#line 102 "F:\REPOTEQ\BunicherSystem\BunicherSystem\Core.Admin\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 3725, Url.Action("Index","Customer"), 3725, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" id=""appsDropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""icon-users nav-icon""></i>
                            العملاء
                        </a>

                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link "" href=""users.html"" id=""appsDropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""icon-alert-triangle nav-icon""></i>
                            الاعدادت
                        </a>

                    </li>

                </ul>
            </div>
        </nav>
        <!-- Navigation end -->
        <!-- *************
            ************ Main container start *************
        ************* -->
        <div class=""main-container"">

            <!-- Page header start -->
            <div class=""page-header"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item"">الرئ");
                WriteLiteral("يسية</li>\r\n                    <li class=\"breadcrumb-item active\">المستخدمين</li>\r\n                </ol>\r\n            </div>\r\n            <!-- Page header end -->\r\n\r\n            ");
#nullable restore
#line 134 "F:\REPOTEQ\BunicherSystem\BunicherSystem\Core.Admin\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
        <!-- *************
            ************ Main container end *************
        ************* -->
        <!-- Footer start -->
        <footer class=""main-footer"">© BANSHER 2021</footer>
        <!-- Footer end -->

    </div>
    <!-- Container fluid end -->
    <!-- *************
        ************ Required JavaScript Files *************
    ************* -->
    <!-- Required jQuery first, then Bootstrap Bundle JS -->
    <script src=""/js/jquery.min.js""></script>
    <script src=""/js/bootstrap.bundle.min.js""></script>
    <script src=""/js/moment.js""></script>


    <!-- *************
        ************ Vendor Js Files *************
    ************* -->
    <!-- Slimscroll JS -->
    <script src=""/vendor/slimscroll/slimscroll.min.js""></script>
    <script src=""/vendor/slimscroll/custom-scrollbar.js""></script>


    <!-- Main Js Required -->
    <script src=""/js/main.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
