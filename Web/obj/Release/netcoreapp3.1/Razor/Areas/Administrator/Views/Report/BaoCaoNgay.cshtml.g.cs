#pragma checksum "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNgay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79c068f5e6e59f91c6b2930c04b94c164db9623b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Report_BaoCaoNgay), @"mvc.1.0.view", @"/Areas/Administrator/Views/Report/BaoCaoNgay.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79c068f5e6e59f91c6b2930c04b94c164db9623b", @"/Areas/Administrator/Views/Report/BaoCaoNgay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Administrator_Views_Report_BaoCaoNgay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNgay.cshtml"
  
    string filter = ViewBag.Filter != DateTime.MinValue ? ViewBag.Filter.ToString("yyyy-MM-dd") : DateTime.Now.Date.ToString("yyyy-MM-dd");
    string filterTitle = ViewBag.Filter != DateTime.MinValue ? ViewBag.Filter.ToString("dd-MM-yyyy") : DateTime.Now.Date.ToString("dd-MM-yyyy");
    string strFilter = ViewBag.Filter != DateTime.MinValue ? ViewBag.Filter.ToString("yyyy-MM-dd") : DateTime.Now.Date.ToString("yyyy-MM-dd");
    ViewData["Title"] = "Báo cáo ngày " + filterTitle;
    Layout = "~/Areas/Administrator/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://cdn.jsdelivr.net/npm/chart.js@2.8.0\"></script>\r\n<div class=\"col-lg-6\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <input class=\"form-control\" id=\"ddlFilterData\" onchange=\"OnchangeData()\" type=\"date\"");
            BeginWriteAttribute("value", " value=\'", 807, "\'", 825, 1);
#nullable restore
#line 13 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNgay.cshtml"
WriteAttributeValue("", 815, strFilter, 815, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" onkeypress=""return false"" />
        </div>
    </div>
    <hr />
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"">
                <div class=""card-header border-0"">
                    <div class=""d-flex justify-content-between"">
                        <h3 class=""card-title"">THỐNG KÊ ĐƠN HÀNG NGÀY <b>");
#nullable restore
#line 22 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNgay.cshtml"
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
                    <div style=""height: 500px;"">
                        <canvas id=""chartNgay""></canvas>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <hr />
</div>

<script>
    function OnchangeData() {
        var valYear = $('#ddlFilterData').val();
        window.location.href = """);
#nullable restore
#line 43 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNgay.cshtml"
                           Write(Url.Action("BaoCaoNgay", "Report"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?ngay="" + valYear;
    }
</script>
<script>
    function moneyFormat(price, sign = ' đ') {
        const pieces = parseFloat(price).toFixed(1).split('')
        let ii = pieces.length - 3
        while ((ii -= 3) > 0) {
            pieces.splice(ii, 0, ',')
        }
        return pieces.join('') + sign
    }
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
#line 64 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNgay.cshtml"
             Write(Url.Action("GetDataBaoCaoNgay", "Report"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?ngay=");
#nullable restore
#line 64 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNgay.cshtml"
                                                             Write(filter);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            dataType: 'json',
            success: function (res) {
                $(""#totalDoanhThu"").text(moneyFormat(res.DoanhThu))
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
                            'rgba(66, 66, 66, 1)'");
            WriteLiteral("\n                        ],\r\n                        borderWidth: 1\r\n                    }]\r\n                },\r\n            });\r\n        });\r\n    }\r\n    SetChartNgay();\r\n</script>");
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
