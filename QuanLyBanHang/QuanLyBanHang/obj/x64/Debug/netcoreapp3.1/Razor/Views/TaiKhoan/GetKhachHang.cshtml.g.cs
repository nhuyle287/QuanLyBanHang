#pragma checksum "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetKhachHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "537fe56d3311ece82887317fb871fc0838875604"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TaiKhoan_GetKhachHang), @"mvc.1.0.view", @"/Views/TaiKhoan/GetKhachHang.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"537fe56d3311ece82887317fb871fc0838875604", @"/Views/TaiKhoan/GetKhachHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a930d1715b4ad9ce26b761c9e2d72f5b03ea0fa", @"/Views/_ViewImports.cshtml")]
    public class Views_TaiKhoan_GetKhachHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuanLyBanHang.Models.TaiKhoan_NhanVien_KhachHang_Admin_VaiTro>>
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
#line 3 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetKhachHang.cshtml"
  
    ViewData["Title"] = "GetKhachHang";
    Layout = "~/Views/Shared/Layout_Admin.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Links", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "537fe56d3311ece82887317fb871fc08388756045099", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "537fe56d3311ece82887317fb871fc08388756046277", async() => {
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
            WriteLiteral("\r\n<div class=\"background-popup\">\r\n\r\n\r\n</div>\r\n<div class=\"container\">\r\n    <div class=\"header-content\">\r\n        <h2>Danh sách tài khoản</h2>\r\n\r\n        <div class=\"header-event\">\r\n");
#nullable restore
#line 21 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetKhachHang.cshtml"
             using (Html.BeginForm("GetKhachHang", "TaiKhoan", FormMethod.Get))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"search\">\r\n                    Title: ");
#nullable restore
#line 24 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetKhachHang.cshtml"
                      Write(Html.TextBox("SearchString"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Tìm kiếm\" id=\"search\" />\r\n                </p>\r\n");
#nullable restore
#line 26 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetKhachHang.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <a class=""add-user btn"" id=""add-custom"">
                <i class=""fa fa-plus"" aria-hidden=""true""></i>&nbsp;
                Thêm tài khoản
            </a>

        </div>
    </div>
    <div class=""content-content"">
        <table class=""table table-hover tm-table-small "">
            <thead>
                <tr>
                    <th scope=""col""><input type=""checkbox"" id=""checkall"" /></th>
                    <th scope=""col"">Mã tài khoản</th>
                    <th scope=""col"">Họ và tên</th>
                    <th scope=""col"">Tên đăng nhập</th>
                    <th scope=""col"">Mật khẩu</th>
                    <th scope=""col"">Ngày tạo</th>
                    <th scope=""col"">Vai trò</th>
                    <th scope=""col"">Chức năng</th>

                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 50 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetKhachHang.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td scope=\"row\"><input type=\"checkbox\" class=\"tick\" name=\"listcustom\"");
            BeginWriteAttribute("value", " value=\"", 1833, "\"", 1868, 1);
#nullable restore
#line 53 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetKhachHang.cshtml"
WriteAttributeValue("", 1841, item.khachhang.KhachHangId, 1841, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 55 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetKhachHang.cshtml"
                   Write(item.taiKhoan.TaiKhoanId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 58 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetKhachHang.cshtml"
                   Write(item.khachhang.HoTen);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 61 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetKhachHang.cshtml"
                   Write(item.taiKhoan.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 64 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetKhachHang.cshtml"
                   Write(item.taiKhoan.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 67 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetKhachHang.cshtml"
                   Write(item.taiKhoan.NgayTao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 70 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetKhachHang.cshtml"
                   Write(item.vaiTro.MoTa);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <div>\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2571, "\"", 2616, 3);
            WriteAttributeValue("", 2581, "Update(", 2581, 7, true);
#nullable restore
#line 74 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetKhachHang.cshtml"
WriteAttributeValue("", 2588, item.khachhang.KhachHangId, 2588, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2615, ")", 2615, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn tm-product-delete-link\" id=\"update-staff\"><i class=\"fas fa-edit tm-product-delete-icon\"></i></a>\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2757, "\"", 2802, 3);
            WriteAttributeValue("", 2767, "Delete(", 2767, 7, true);
#nullable restore
#line 75 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetKhachHang.cshtml"
WriteAttributeValue("", 2774, item.khachhang.KhachHangId, 2774, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2801, ")", 2801, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"tm-product-delete-link\" id=\"delete-staff\"><i class=\"far fa-trash-alt tm-product-delete-icon\"></i></a>\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2944, "\"", 2989, 3);
            WriteAttributeValue("", 2954, "Detail(", 2954, 7, true);
#nullable restore
#line 76 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetKhachHang.cshtml"
WriteAttributeValue("", 2961, item.khachhang.KhachHangId, 2961, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2988, ")", 2988, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn tm-product-delete-link\" id=\"detail-staff\"><i class=\"fas fa-eye tm-product-delete-icon\"></i></a>\r\n                        </div>\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 81 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetKhachHang.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n\r\n    <br />\r\n    <br />\r\n    <!-- table container -->\r\n\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "537fe56d3311ece82887317fb871fc083887560415290", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuanLyBanHang.Models.TaiKhoan_NhanVien_KhachHang_Admin_VaiTro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
