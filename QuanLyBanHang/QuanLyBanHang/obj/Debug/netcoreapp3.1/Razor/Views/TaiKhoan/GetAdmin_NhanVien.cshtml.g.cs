#pragma checksum "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetAdmin_NhanVien.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb0362f9cb06bce4484348355caad9f03118d0a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TaiKhoan_GetAdmin_NhanVien), @"mvc.1.0.view", @"/Views/TaiKhoan/GetAdmin_NhanVien.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb0362f9cb06bce4484348355caad9f03118d0a1", @"/Views/TaiKhoan/GetAdmin_NhanVien.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a930d1715b4ad9ce26b761c9e2d72f5b03ea0fa", @"/Views/_ViewImports.cshtml")]
    public class Views_TaiKhoan_GetAdmin_NhanVien : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuanLyBanHang.Models.TaiKhoan_NhanVien_KhachHang_Admin_VaiTro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/custom/admin_users.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/css/nhanvien.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/js/nhanvien.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetAdmin_NhanVien.cshtml"
  
    ViewData["Title"] = "GetAdmin_NhanVien";
    Layout = "~/Views/Shared/Layout_Admin.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("Links", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb0362f9cb06bce4484348355caad9f03118d0a15097", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bb0362f9cb06bce4484348355caad9f03118d0a16275", async() => {
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
        <h2>Danh sách tài khoản</h2>
        <div class=""header-event"">
            <a class=""add-user btn"" id=""add-staff"">
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
          ");
            WriteLiteral("  <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetAdmin_NhanVien.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td scope=\"row\"><input type=\"checkbox\" class=\"tick\" name=\"liststaff\"");
            BeginWriteAttribute("value", " value=\"", 1550, "\"", 1583, 1);
#nullable restore
#line 45 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetAdmin_NhanVien.cshtml"
WriteAttributeValue("", 1558, item.taiKhoan.TaiKhoanId, 1558, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetAdmin_NhanVien.cshtml"
                   Write(item.taiKhoan.TaiKhoanId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetAdmin_NhanVien.cshtml"
                   Write(item.nhanVien.HoTen);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetAdmin_NhanVien.cshtml"
                   Write(item.taiKhoan.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetAdmin_NhanVien.cshtml"
                   Write(item.taiKhoan.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetAdmin_NhanVien.cshtml"
                   Write(item.taiKhoan.NgayTao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetAdmin_NhanVien.cshtml"
                   Write(item.vaiTro.MoTa);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        <div>\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2287, "\"", 2330, 3);
            WriteAttributeValue("", 2297, "Update(", 2297, 7, true);
#nullable restore
#line 67 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetAdmin_NhanVien.cshtml"
WriteAttributeValue("", 2304, item.taiKhoan.TaiKhoanId, 2304, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2329, ")", 2329, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn tm-product-delete-link\" id=\"update-staff\"><i class=\"fas fa-edit tm-product-delete-icon\"></i></a>\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2471, "\"", 2514, 3);
            WriteAttributeValue("", 2481, "Delete(", 2481, 7, true);
#nullable restore
#line 68 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetAdmin_NhanVien.cshtml"
WriteAttributeValue("", 2488, item.taiKhoan.TaiKhoanId, 2488, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2513, ")", 2513, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"tm-product-delete-link\" id=\"delete-staff\"><i class=\"far fa-trash-alt tm-product-delete-icon\"></i></a>\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2656, "\"", 2699, 3);
            WriteAttributeValue("", 2666, "Detail(", 2666, 7, true);
#nullable restore
#line 69 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetAdmin_NhanVien.cshtml"
WriteAttributeValue("", 2673, item.taiKhoan.TaiKhoanId, 2673, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2698, ")", 2698, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn tm-product-delete-link\" id=\"detail-staff\"><i class=\"fas fa-eye tm-product-delete-icon\"></i></a>\r\n                        </div>\r\n                    </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 74 "C:\Users\NhuY\Desktop\Framework\QuanLyBanHang\QuanLyBanHang\QuanLyBanHang\Views\TaiKhoan\GetAdmin_NhanVien.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n\r\n    <br />\r\n    <br />\r\n    <!-- table container -->\r\n\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb0362f9cb06bce4484348355caad9f03118d0a114363", async() => {
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
