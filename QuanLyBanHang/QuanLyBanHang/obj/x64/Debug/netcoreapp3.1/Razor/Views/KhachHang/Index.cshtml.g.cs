#pragma checksum "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\KhachHang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0971ce35c80825c6647531d98a72fcc606c8c513"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KhachHang_Index), @"mvc.1.0.view", @"/Views/KhachHang/Index.cshtml")]
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
#line 1 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\_ViewImports.cshtml"
using QuanLyBanHang;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\_ViewImports.cshtml"
using QuanLyBanHang.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0971ce35c80825c6647531d98a72fcc606c8c513", @"/Views/KhachHang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a930d1715b4ad9ce26b761c9e2d72f5b03ea0fa", @"/Views/_ViewImports.cshtml")]
    public class Views_KhachHang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuanLyBanHang.Models.KhachHang>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/custom/admin_users.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/css/khachhang.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/js/khachhang.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\KhachHang\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/Layout_Admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Links", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0971ce35c80825c6647531d98a72fcc606c8c5135060", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0971ce35c80825c6647531d98a72fcc606c8c5136238", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"
<div class=""background-popup"">


</div>
<div class=""container"">
    <div class=""header-content"">
        <h2>Danh sách khách hàng</h2>
        <div class=""header-event"">
            <a class=""add-user btn"" id=""add-custom"">
                <i class=""fa fa-plus"" aria-hidden=""true""></i>&nbsp;
                Thêm khách hàng
            </a>
            <a class=""add-user btn"" id=""delete"">
                <i class=""fa fa-minus""></i>&nbsp;
                Xóa khách hàng
            </a>
        </div>
    </div>
    <div class=""content-content"">
        <table class=""table table-hover tm-table-small "">
            <thead>
                <tr>
                    <th scope=""col""><input type=""checkbox"" id=""checkall"" /></th>
                    <th scope=""col"">Họ và tên</th>
                    <th scope=""col"">Ngày sinh</th>
                    <th scope=""col"">Email</th>
                    <th scope=""col"">Số điện thoại</th>
                    <th scope=""col"">Địa chỉ</th>
              ");
            WriteLiteral("      <th scope=\"col\">Tài khoản</th>\r\n                    <th scope=\"col\">Chức năng</th>\r\n                    \r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 47 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\KhachHang\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td scope=\"row\"><input type=\"checkbox\" class=\"tick\" name=\"listcustom\"");
            BeginWriteAttribute("value", " value=\"", 1688, "\"", 1713, 1);
#nullable restore
#line 50 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\KhachHang\Index.cshtml"
WriteAttributeValue("", 1696, item.KhachHangId, 1696, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 52 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\KhachHang\Index.cshtml"
                       Write(item.HoTen);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 55 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\KhachHang\Index.cshtml"
                       Write(item.NgaySinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 58 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\KhachHang\Index.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 61 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\KhachHang\Index.cshtml"
                       Write(item.Sdt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 64 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\KhachHang\Index.cshtml"
                       Write(item.DiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 67 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\KhachHang\Index.cshtml"
                       Write(item.TaiKhoanId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            <div>\r\n                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2444, "\"", 2479, 3);
            WriteAttributeValue("", 2454, "Update(", 2454, 7, true);
#nullable restore
#line 72 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\KhachHang\Index.cshtml"
WriteAttributeValue("", 2461, item.KhachHangId, 2461, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2478, ")", 2478, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn tm-product-delete-link\" id=\"update-staff\"><i class=\"fas fa-edit tm-product-delete-icon\"></i></a>\r\n                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2624, "\"", 2659, 3);
            WriteAttributeValue("", 2634, "Delete(", 2634, 7, true);
#nullable restore
#line 73 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\KhachHang\Index.cshtml"
WriteAttributeValue("", 2641, item.KhachHangId, 2641, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2658, ")", 2658, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"tm-product-delete-link\" id=\"delete-staff\"><i class=\"far fa-trash-alt tm-product-delete-icon\"></i></a>\r\n                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2805, "\"", 2840, 3);
            WriteAttributeValue("", 2815, "Detail(", 2815, 7, true);
#nullable restore
#line 74 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\KhachHang\Index.cshtml"
WriteAttributeValue("", 2822, item.KhachHangId, 2822, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2839, ")", 2839, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn tm-product-delete-link\" id=\"detail-staff\"><i class=\"fas fa-eye tm-product-delete-icon\"></i></a>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 78 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\KhachHang\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n\r\n    <br />\r\n    <br />\r\n    <!-- table container -->\r\n\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0971ce35c80825c6647531d98a72fcc606c8c51314421", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuanLyBanHang.Models.KhachHang>> Html { get; private set; }
    }
}
#pragma warning restore 1591
