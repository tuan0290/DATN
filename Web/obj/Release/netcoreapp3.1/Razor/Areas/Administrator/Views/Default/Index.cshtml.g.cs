#pragma checksum "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f7b295e91c9cb159a85b53616b8b08785847dc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Default_Index), @"mvc.1.0.view", @"/Areas/Administrator/Views/Default/Index.cshtml")]
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
#line 1 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f7b295e91c9cb159a85b53616b8b08785847dc6", @"/Areas/Administrator/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Administrator_Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
  
    var roleid = TempData["RoleId"].ToString();

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
  
    string filter = DateTime.Now.Date.ToString("yyyy-MM-dd");
    string filterTitle = DateTime.Now.Date.ToString("dd-MM-yyyy");
    ViewData["Title"] = "Hệ thống quản trị";
    Layout = "~/Areas/Administrator/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://cdn.jsdelivr.net/npm/chart.js@2.8.0\"></script>\r\n");
#nullable restore
#line 11 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
 if (roleid == "1" || roleid == "3")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <h5>Quản lý nội dung</h5>\r\n        <hr />\r\n    </div>\r\n    <div class=\"col-lg-4\">\r\n        <div class=\"card border-primary mb-3\">\r\n            <div class=\"card-body text-primary\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 672, "\"", 711, 1);
#nullable restore
#line 21 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
WriteAttributeValue("", 679, Url.Action("Create", "Product"), 679, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><h5 class=""card-title""><i class=""fas fa-pen-square"" aria-hidden=""true""></i> Thêm mới sản phẩm</h5></a>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card border-primary mb-3"">
            <div class=""card-body text-primary"">
                <a");
            BeginWriteAttribute("href", " href=\"", 1009, "\"", 1053, 1);
#nullable restore
#line 28 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
WriteAttributeValue("", 1016, Url.Action("Create", "CategoryNews"), 1016, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><h5 class=""card-title""><i class=""fas fa-pen-square"" aria-hidden=""true""></i> Thêm mới Chuyên mục</h5></a>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card border-primary mb-3"">
            <div class=""card-body text-primary"">
                <a");
            BeginWriteAttribute("href", " href=\"", 1353, "\"", 1389, 1);
#nullable restore
#line 35 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
WriteAttributeValue("", 1360, Url.Action("Create", "News"), 1360, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><h5 class=""card-title""><i class=""fas fa-pen-square"" aria-hidden=""true""></i> Thêm mới tin bài</h5></a>
            </div>
        </div>
    </div>

    <div class=""col-lg-12"">
        <h5>Quản lý đơn hàng</h5>
        <hr />
    </div>
    <div class=""col-lg-4"">
        <div class=""card border-primary mb-3"">
            <div class=""card-body text-primary"">
                <a");
            BeginWriteAttribute("href", " href=\"", 1780, "\"", 1825, 2);
#nullable restore
#line 47 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
WriteAttributeValue("", 1787, Url.Action("Index", "Order"), 1787, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1816, "?status=1", 1816, 9, true);
            EndWriteAttribute();
            WriteLiteral(@"><h5 class=""card-title""><i class=""fas fa-pen-square"" aria-hidden=""true""></i> Đơn hàng chờ xác nhận</h5></a>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card border-primary mb-3"">
            <div class=""card-body text-primary"">
                <a");
            BeginWriteAttribute("href", " href=\"", 2127, "\"", 2172, 2);
#nullable restore
#line 54 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
WriteAttributeValue("", 2134, Url.Action("Index", "Order"), 2134, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2163, "?status=2", 2163, 9, true);
            EndWriteAttribute();
            WriteLiteral(@"><h5 class=""card-title""><i class=""fas fa-pen-square"" aria-hidden=""true""></i> Đơn hàng chờ giao</h5></a>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card border-primary mb-3"">
            <div class=""card-body text-primary"">
                <a");
            BeginWriteAttribute("href", " href=\"", 2470, "\"", 2515, 2);
#nullable restore
#line 61 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
WriteAttributeValue("", 2477, Url.Action("Index", "Order"), 2477, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2506, "?status=3", 2506, 9, true);
            EndWriteAttribute();
            WriteLiteral(@"><h5 class=""card-title""><i class=""fas fa-pen-square"" aria-hidden=""true""></i> Đơn hàng đang giao</h5></a>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card border-primary mb-3"">
            <div class=""card-body text-primary"">
                <a");
            BeginWriteAttribute("href", " href=\"", 2814, "\"", 2859, 2);
#nullable restore
#line 68 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
WriteAttributeValue("", 2821, Url.Action("Index", "Order"), 2821, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2850, "?status=4", 2850, 9, true);
            EndWriteAttribute();
            WriteLiteral(@"><h5 class=""card-title""><i class=""fas fa-pen-square"" aria-hidden=""true""></i> Đơn hàng đã giao</h5></a>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card border-primary mb-3"">
            <div class=""card-body text-primary"">
                <a");
            BeginWriteAttribute("href", " href=\"", 3156, "\"", 3201, 2);
#nullable restore
#line 75 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
WriteAttributeValue("", 3163, Url.Action("Index", "Order"), 3163, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3192, "?status=5", 3192, 9, true);
            EndWriteAttribute();
            WriteLiteral(@"><h5 class=""card-title""><i class=""fas fa-pen-square"" aria-hidden=""true""></i> Đơn hàng giao thất bại</h5></a>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card border-primary mb-3"">
            <div class=""card-body text-primary"">
                <a");
            BeginWriteAttribute("href", " href=\"", 3504, "\"", 3549, 2);
#nullable restore
#line 82 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
WriteAttributeValue("", 3511, Url.Action("Index", "Order"), 3511, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3540, "?status=6", 3540, 9, true);
            EndWriteAttribute();
            WriteLiteral(@"><h5 class=""card-title""><i class=""fas fa-pen-square"" aria-hidden=""true""></i> Đơn hàng bị hủy</h5></a>
            </div>
        </div>
    </div>

    <div class=""col-lg-12"">
        <h5>Báo cáo, thống kê</h5>
        <hr />
    </div>
    <div class=""col-lg-4"">
        <div class=""card border-primary mb-3"">
            <div class=""card-body text-primary"">
                <a");
            BeginWriteAttribute("href", " href=\"", 3940, "\"", 3982, 1);
#nullable restore
#line 94 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
WriteAttributeValue("", 3947, Url.Action("BaoCaoNgay", "Report"), 3947, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><h5 class=""card-title""><i class=""fas fa-pen-square"" aria-hidden=""true""></i> Thống kê đơn hàng theo ngày</h5></a>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card border-primary mb-3"">
            <div class=""card-body text-primary"">
                <a");
            BeginWriteAttribute("href", " href=\"", 4290, "\"", 4333, 1);
#nullable restore
#line 101 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
WriteAttributeValue("", 4297, Url.Action("BaoCaoThang", "Report"), 4297, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><h5 class=""card-title""><i class=""fas fa-pen-square"" aria-hidden=""true""></i> Thống kê theo tháng</h5></a>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card border-primary mb-3"">
            <div class=""card-body text-primary"">
                <a");
            BeginWriteAttribute("href", " href=\"", 4633, "\"", 4674, 1);
#nullable restore
#line 108 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
WriteAttributeValue("", 4640, Url.Action("BaoCaoNam", "Report"), 4640, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><h5 class=""card-title""><i class=""fas fa-pen-square"" aria-hidden=""true""></i> Thống kê tổng hợp năm</h5></a>
            </div>
        </div>
    </div>
    <div class=""col-lg-12"">
        <h5>Quản trị hệ thống</h5>
        <hr />
    </div>
    <div class=""col-lg-4"">
        <div class=""card border-primary mb-3"">
            <div class=""card-body text-primary"">
                <a");
            BeginWriteAttribute("href", " href=\"", 5069, "\"", 5105, 1);
#nullable restore
#line 119 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
WriteAttributeValue("", 5076, Url.Action("Index", "Users"), 5076, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><h5 class=""card-title""><i class=""fas fa-pen-square"" aria-hidden=""true""></i> Quản lý nhân viên</h5></a>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card border-primary mb-3"">
            <div class=""card-body text-primary"">
                <a");
            BeginWriteAttribute("href", " href=\"", 5403, "\"", 5442, 1);
#nullable restore
#line 126 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
WriteAttributeValue("", 5410, Url.Action("Index", "Accounts"), 5410, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><h5 class=""card-title""><i class=""fas fa-pen-square"" aria-hidden=""true""></i> Quản lý người dùng</h5></a>
            </div>
        </div>
    </div>
    <div class=""col-lg-4"">
        <div class=""card border-primary mb-3"">
            <div class=""card-body text-primary"">
                <a");
            BeginWriteAttribute("href", " href=\"", 5741, "\"", 5778, 1);
#nullable restore
#line 133 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
WriteAttributeValue("", 5748, Url.Action("Logout", "Login"), 5748, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h5 class=\"card-title\"><i class=\"fas fa-pen-square\" aria-hidden=\"true\"></i> Đăng xuất</h5></a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 138 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header border-0"">
                    <div class=""d-flex justify-content-between"">
                        <h3>THỐNG KÊ ĐƠN HÀNG NGÀY <b>");
#nullable restore
#line 146 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
                                                 Write(filterTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></h3>
                    </div>
                </div>
                <div class=""card-body"">
                    <p class=""d-flex flex-column"">
                        <span class=""text-bold text-lg"" id=""totalDoanhThu"">0 đ</span>
                        <span>Doanh thu ngày</span>
                    </p>
                    <div>
                        <canvas id=""chartNgay""></canvas>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 161 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    function OnchangeData() {\r\n        var valYear = $(\'#ddlFilterData\').val();\r\n        window.location.href = \"");
#nullable restore
#line 166 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
                           Write(Url.Action("BaoCaoNgay", "Report"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?ngay="" + valYear;
    }
</script>
<script>
    function SetChartNgay() {
        var DonHangMoi = 0;
        var DonHangThanhCong = 0;
        var DonHangThatBai = 0;
        var DonHangHuy = 0;
        var ctx = document.getElementById('chartNgay').getContext('2d');
        //get data chart
        $.ajax({
            type: ""GET"",
            url: '");
#nullable restore
#line 179 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
             Write(Url.Action("GetDataBaoCaoNgay", "Report"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?ngay=");
#nullable restore
#line 179 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Default\Index.cshtml"
                                                             Write(filter);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            dataType: 'json',
            success: function (res) {
                $(""#totalDoanhThu"").text(res.DoanhThu + "" đ"")
                DonHangMoi = res.DonHangMoi;
                DonHangThanhCong = res.DonHangThanhCong;
                DonHangThatBai = res.DonHangThatBai;
                DonHangHuy = res.DonHangHuy;
                console.log(res);
            }
        }).done(function () {
            var myChart = new Chart(ctx, {
                type: 'pie',
                data: {
                    labels: ['Đ.Hàng Mới', 'Đ.Hàng Thành Công', 'Đ.Hàng Thất Bại', 'Đ.Hàng Hủy'],
                    datasets: [{
                        label: 'Đ.Hàng Mới',
                        data: [DonHangMoi, DonHangThanhCong, DonHangThatBai, DonHangHuy],
                        backgroundColor: [
                            'rgba(0, 104, 184, 1)',
                            '#28a745',
                            '#ffc107',
                            'rgba(66, 66, 66, 1)'
     ");
            WriteLiteral("                   ],\r\n                        borderWidth: 1\r\n                    }]\r\n                },\r\n            });\r\n        });\r\n    }\r\n    SetChartNgay();\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
