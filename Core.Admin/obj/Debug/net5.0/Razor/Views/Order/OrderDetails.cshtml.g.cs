#pragma checksum "F:\REPOTEQ\BunicherSystem\BunicherSystem\Core.Admin\Views\Order\OrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2eaa18a28ee2c18412861dbd1c5e455e9e9b5c1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderDetails), @"mvc.1.0.view", @"/Views/Order/OrderDetails.cshtml")]
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
#line 1 "F:\REPOTEQ\BunicherSystem\BunicherSystem\Core.Admin\Views\Order\OrderDetails.cshtml"
using Core.Model.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2eaa18a28ee2c18412861dbd1c5e455e9e9b5c1f", @"/Views/Order/OrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feddaf0402013db547d7276aae0d65373cc4ef30", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\REPOTEQ\BunicherSystem\BunicherSystem\Core.Admin\Views\Order\OrderDetails.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Users";
    ViewBag.Page = "تفاصيل الفاتورة";

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
                                <i class=""icon-layers2""></i> &nbsp; تفاصيل الفاتورة

                                <a class=""add-user""");
            BeginWriteAttribute("href", " href=\"", 682, "\"", 709, 1);
#nullable restore
#line 23 "F:\REPOTEQ\BunicherSystem\BunicherSystem\Core.Admin\Views\Order\OrderDetails.cshtml"
WriteAttributeValue("", 689, Url.Action("Index"), 689, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""icon-controller-fast-backward""></i> عودة</a>
                            </div>

                        </div>
                        <div class=""card-body"">

                            <div class=""row gutters"">
                                
                                <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12 mt-30"">

                                    <div class=""card"">
                                        <div class=""card-body"">
                                            <div class=""table-responsive"">
                                                <table class=""table table-bordered table-striped"">
                                                    <thead>
                                                        <tr>
                                                            <th>#</th>
                                                            <th>مقدم الخدمة</th>
                                                            <th>اسم العميل</th>
");
            WriteLiteral(@"                                                            <th>اسم الخدمة</th>
                                                            <th>الكمية</th>
                                                            <th>الخصم</th>
                                                           
                                                            
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr>
                                                            <td>1</td>
                                                            <td>أحمد خالد محمود</td>
                                                            <td>عبد الله ابراهيم</td>
                                                            <td></td>
                                                            <td></td>
                                ");
            WriteLiteral(@"                            <td></td>
                                                            
                                                         
                                                        </tr>
                                                        
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
