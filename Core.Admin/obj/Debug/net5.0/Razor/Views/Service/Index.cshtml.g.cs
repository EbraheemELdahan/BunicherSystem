#pragma checksum "F:\REPOTEQ\BunicherSystem\BunicherSystem\Core.Admin\Views\Service\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba64674981466f18dc157527c66b5fd9d4888a1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Index), @"mvc.1.0.view", @"/Views/Service/Index.cshtml")]
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
#nullable restore
#line 1 "F:\REPOTEQ\BunicherSystem\BunicherSystem\Core.Admin\Views\Service\Index.cshtml"
using Core.Model.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba64674981466f18dc157527c66b5fd9d4888a1d", @"/Views/Service/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feddaf0402013db547d7276aae0d65373cc4ef30", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<User>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\REPOTEQ\BunicherSystem\BunicherSystem\Core.Admin\Views\Service\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Users";
    ViewBag.Page = "الخدمات";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">

    <!-- Row start -->
    <div class=""row gutters"">

        <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12"">
            <div class=""card h-100"">

                <div class=""card-body"">
                    <div class=""card-form"">
                        <div class=""card-header"">
                            <div class=""card-title"">
                                <i class=""icon-layers2""></i> &nbsp; الخدمات

                                
                            </div>

                        </div>
                        <div class=""card-body"">

                            <div class=""row gutters"">
                                <div class=""row"">
                                    <div class=""col-xl-4 col-lg col-md-4 col-sm-4 col-12"">
                                        <div class=""form-group"">
                                            <label for=""fullName"">بحث من :</label>
                                            <inpu");
            WriteLiteral(@"t type=""date"" class=""form-control"" placeholder="" "">
                                        </div>

                                    </div>
                                    <div class=""col-xl-4 col-lg col-md-4 col-sm-4 col-12"">
                                        <div class=""form-group"">
                                            <label for=""fullName"">بحث الى  :</label>
                                            <input type=""date"" class=""form-control"" id=""fullName"" placeholder="" "">
                                        </div>

                                    </div>
                                    <div class=""col-xl-4 col-lg-4 col-md-4 col-sm-4 col-12"">
                                        <div class=""form-group"">
                                            <label for=""fullName""> التصنيف حسب المستخدم:</label>
                                            <select class=""form-control"">

                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba64674981466f18dc157527c66b5fd9d4888a1d5630", async() => {
                WriteLiteral("اختر التصنيف...");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba64674981466f18dc157527c66b5fd9d4888a1d6645", async() => {
                WriteLiteral("الاول");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba64674981466f18dc157527c66b5fd9d4888a1d7650", async() => {
                WriteLiteral("الاول");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </select>
                                        </div>
                                    </div>
                                    <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12 "">
                                        <div class=""text-right"">

                                            <a href=""#"" class=""add_userbtn""><i class=""icon-search""></i> بحث</a>
                                        </div>
                                    </div>
                                    <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12 mt-30"">

                                        <div class=""card"">
                                            <div class=""card-body"">
                                                <div class=""table-responsive"">
                                                    <table class=""table table-bordered table-striped"">
                                                        <thead>
                   ");
            WriteLiteral(@"                                         <tr>
                                                                <th>#</th>
                                                                <th>اسم الخدمة</th>
                                                                <th>اسم مقدم الخدمة</th>
                                                                <th>اسم العميل</th>
                                                                <th>السعر</th>
                                                                <th>تاريخ اضافة الخدمة</th>
                                                                <th>الصورة</th>

                                                                <th></th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                            <tr>
                                              ");
            WriteLiteral(@"                  <td>1</td>
                                                                <td></td>
                                                                <td></td>
                                                                <td></td>
                                                                <td>100$</td>
                                                                <td></td>
                                                                <td><img class=""img_table"" src=""/images/logo-2.png""></td>

");
            WriteLiteral(@"                                                            </tr>
                                                           

                                                        </tbody>
                                                    </table>
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                </div>

                        </div>

                    </div>




                </div>
            </div>
        </div>
    </div>

</div>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
