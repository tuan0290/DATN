#pragma checksum "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "823335fe3c15dfbda76765a08d3043abd0f393f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Report_BaoCaoNam), @"mvc.1.0.view", @"/Areas/Administrator/Views/Report/BaoCaoNam.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"823335fe3c15dfbda76765a08d3043abd0f393f0", @"/Areas/Administrator/Views/Report/BaoCaoNam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Administrator_Views_Report_BaoCaoNam : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNam.cshtml"
  
    string filter = ViewBag.Filter != null ? ViewBag.Filter.ToString() : DateTime.Now.Date.ToString("dd/MM/yyyy");
    ViewData["Title"] = "Báo cáo năm " + filter;
    Layout = "~/Areas/Administrator/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script src=\"https://cdn.jsdelivr.net/npm/chart.js@2.8.0\"></script>\r\n<div class=\"col-lg-12\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-4\">\r\n            <select class=\"form-control\" id=\"ddlFilterData\" onchange=\"OnchangeData()\">\r\n");
#nullable restore
#line 12 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNam.cshtml"
                 for (int i = 2010; i < 2023; i++)
                {
                    if (i.ToString() == filter)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "823335fe3c15dfbda76765a08d3043abd0f393f04289", async() => {
                WriteLiteral("Năm ");
#nullable restore
#line 16 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNam.cshtml"
                                                   Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNam.cshtml"
                           WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 17 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNam.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "823335fe3c15dfbda76765a08d3043abd0f393f06733", async() => {
                WriteLiteral("Năm ");
#nullable restore
#line 20 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNam.cshtml"
                                          Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNam.cshtml"
                           WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 21 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNam.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
    </div>
    <hr />
    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""card"">
                <div class=""card-header border-0"">
                    <div class=""d-flex justify-content-between"">
                        <h1 class=""card-title"">Biểu đồ thống kê đơn hàng năm ");
#nullable restore
#line 32 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNam.cshtml"
                                                                        Write(filter);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                    </div>
                </div>
                <div class=""card-body"">
                    <div style=""height: 500px;"">
                        <canvas id=""chartDoc""></canvas>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""card"">
                <div class=""card-header border-0"">
                    <div class=""d-flex justify-content-between"">
                        <h3 class=""card-title"">Biểu đồ doanh thu năm ");
#nullable restore
#line 46 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNam.cshtml"
                                                                Write(filter);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""d-flex"">
                        <p class=""d-flex flex-column"">
                            <span class=""text-bold text-lg"" id=""totalDoanhThu"">0 đ</span>
                            <span>Tổng doanh thu </span>
                        </p>
                    </div>
                    <!-- /.d-flex -->
                    <div style=""height: 430px;"">
                        <canvas id=""chartDoanhThu""></canvas>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <hr />
</div>

<script>
    function OnchangeData() {
        var val = $('#ddlFilterData').val();
        window.location.href = """);
#nullable restore
#line 70 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNam.cshtml"
                           Write(Url.Action("BaoCaoNam", "Report"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?nam="" + val;
    }
</script>
<script>
    function numberWithCommas(x) {
        return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, "","");
    }
    function SetChartBieuDoDoc() {
        var ctxDoc = document.getElementById('chartDoc').getContext('2d');
        var arrDataMoi = [];
        var arrDataThanhCong = [];
        var arrDataThatBai = [];
        var arrDataHuy = [];
        $.ajax({
            type: ""GET"",
            url: '");
#nullable restore
#line 85 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNam.cshtml"
             Write(Url.Action("GetDataBaoCaoNam", "Report"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?nam=");
#nullable restore
#line 85 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNam.cshtml"
                                                           Write(filter);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            dataType: 'json',
            success: function (res) {
                arrDataMoi.push(res.Thang1.DonHangMoi);
                arrDataMoi.push(res.Thang2.DonHangMoi);
                arrDataMoi.push(res.Thang3.DonHangMoi);
                arrDataMoi.push(res.Thang4.DonHangMoi);
                arrDataMoi.push(res.Thang5.DonHangMoi);
                arrDataMoi.push(res.Thang6.DonHangMoi);
                arrDataMoi.push(res.Thang7.DonHangMoi);
                arrDataMoi.push(res.Thang8.DonHangMoi);
                arrDataMoi.push(res.Thang9.DonHangMoi);
                arrDataMoi.push(res.Thang10.DonHangMoi);
                arrDataMoi.push(res.Thang11.DonHangMoi);
                arrDataMoi.push(res.Thang12.DonHangMoi);

                arrDataThanhCong.push(res.Thang1.DonHangThanhCong);
                arrDataThanhCong.push(res.Thang2.DonHangThanhCong);
                arrDataThanhCong.push(res.Thang3.DonHangThanhCong);
                arrDataThanhCong.push(res.Thang4.DonHa");
            WriteLiteral(@"ngThanhCong);
                arrDataThanhCong.push(res.Thang5.DonHangThanhCong);
                arrDataThanhCong.push(res.Thang6.DonHangThanhCong);
                arrDataThanhCong.push(res.Thang7.DonHangThanhCong);
                arrDataThanhCong.push(res.Thang8.DonHangThanhCong);
                arrDataThanhCong.push(res.Thang9.DonHangThanhCong);
                arrDataThanhCong.push(res.Thang10.DonHangThanhCong);
                arrDataThanhCong.push(res.Thang11.DonHangThanhCong);
                arrDataThanhCong.push(res.Thang12.DonHangThanhCong);

                arrDataThatBai.push(res.Thang1.DonHangThatBai);
                arrDataThatBai.push(res.Thang2.DonHangThatBai);
                arrDataThatBai.push(res.Thang3.DonHangThatBai);
                arrDataThatBai.push(res.Thang4.DonHangThatBai);
                arrDataThatBai.push(res.Thang5.DonHangThatBai);
                arrDataThatBai.push(res.Thang6.DonHangThatBai);
                arrDataThatBai.push(res.Thang7.DonHangThatBai)");
            WriteLiteral(@";
                arrDataThatBai.push(res.Thang8.DonHangThatBai);
                arrDataThatBai.push(res.Thang9.DonHangThatBai);
                arrDataThatBai.push(res.Thang10.DonHangThatBai);
                arrDataThatBai.push(res.Thang11.DonHangThatBai);
                arrDataThatBai.push(res.Thang12.DonHangThatBai);

                arrDataHuy.push(res.Thang1.DonHangHuy);
                arrDataHuy.push(res.Thang2.DonHangHuy);
                arrDataHuy.push(res.Thang3.DonHangHuy);
                arrDataHuy.push(res.Thang4.DonHangHuy);
                arrDataHuy.push(res.Thang5.DonHangHuy);
                arrDataHuy.push(res.Thang6.DonHangHuy);
                arrDataHuy.push(res.Thang7.DonHangHuy);
                arrDataHuy.push(res.Thang8.DonHangHuy);
                arrDataHuy.push(res.Thang9.DonHangHuy);
                arrDataHuy.push(res.Thang10.DonHangHuy);
                arrDataHuy.push(res.Thang11.DonHangHuy);
                arrDataHuy.push(res.Thang12.DonHangHuy);
    ");
            WriteLiteral(@"            console.log(res);
            }
        }).done(function () {
            var myChart = new Chart(ctxDoc, {
                type: 'bar',
                data: {
                    labels: ['Tháng 1', 'Tháng 2', 'Tháng 3', 'Tháng 4', 'Tháng 5', 'Tháng 6', 'Tháng 7', 'Tháng 8', 'Tháng 9', 'Tháng 10', 'Tháng 11', 'Tháng 12'],
                    datasets: [
                        {
                            label: 'Đơn hàng mới',
                            data: arrDataMoi,
                            backgroundColor: [
                                '#007bff',
                                '#007bff',
                                '#007bff',
                                '#007bff',
                                '#007bff',
                                '#007bff',
                                '#007bff',
                                '#007bff',
                                '#007bff',
                                '#007bff',
                                ");
            WriteLiteral(@"'#007bff',
                                '#007bff'
                            ],
                            borderColor: [
                                '#007bff',
                                '#007bff',
                                '#007bff',
                                '#007bff',
                                '#007bff',
                                '#007bff',
                                '#007bff',
                                '#007bff',
                                '#007bff',
                                '#007bff',
                                '#007bff',
                                '#007bff'
                            ],
                            borderWidth: 1
                        },
                        {
                            label: 'Đơn hàng thành công',
                            data: arrDataThanhCong,
                            backgroundColor: [
                                '#28a745',
                               ");
            WriteLiteral(@" '#28a745',
                                '#28a745',
                                '#28a745',
                                '#28a745',
                                '#28a745',
                                '#28a745',
                                '#28a745',
                                '#28a745',
                                '#28a745',
                                '#28a745',
                                '#28a745'
                            ],
                            borderColor: [
                                '#28a745',
                                '#28a745',
                                '#28a745',
                                '#28a745',
                                '#28a745',
                                '#28a745',
                                '#28a745',
                                '#28a745',
                                '#28a745',
                                '#28a745',
                                '#28a745',
            ");
            WriteLiteral(@"                    '#28a745'
                            ],
                            borderWidth: 1
                        },
                        {
                            label: 'Đơn hàng thất bại',
                            data: arrDataThatBai,
                            backgroundColor: [
                                '#ffc107',
                                '#ffc107',
                                '#ffc107',
                                '#ffc107',
                                '#ffc107',
                                '#ffc107',
                                '#ffc107',
                                '#ffc107',
                                '#ffc107',
                                '#ffc107',
                                '#ffc107',
                                '#ffc107'
                            ],
                            borderColor: [
                                '#ffc107',
                                '#ffc107',
               ");
            WriteLiteral(@"                 '#ffc107',
                                '#ffc107',
                                '#ffc107',
                                '#ffc107',
                                '#ffc107',
                                '#ffc107',
                                '#ffc107',
                                '#ffc107',
                                '#ffc107',
                                '#ffc107'
                            ],
                            borderWidth: 1
                        },
                        {
                            label: 'Đơn hàng hủy',
                            data: arrDataHuy,
                            backgroundColor: [
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
              ");
            WriteLiteral(@"                  '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d'
                            ],
                            borderColor: [
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d'
                            ],
                            borderWidth: 1
                        }
                    ]
                },
                options: {
                    scales: {
           ");
            WriteLiteral(@"             yAxes: [{
                            ticks: {
                                beginAtZero: true
                            }
                        }]
                    }
                }
            });
        });
    }
    function SetChartDoanhThu() {
        var ctxDoc = document.getElementById('chartDoanhThu').getContext('2d');
        var arrDataDoanhThu = [];
        var totalDoanhThu = 0;
        $.ajax({
            type: ""GET"",
            url: '");
#nullable restore
#line 299 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNam.cshtml"
             Write(Url.Action("GetDataBaoCaoNam", "Report"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?nam=");
#nullable restore
#line 299 "D:\DevOps\DATN\TuNgaComputer_DA\Web\Areas\Administrator\Views\Report\BaoCaoNam.cshtml"
                                                           Write(filter);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            dataType: 'json',
            success: function (res) {
                arrDataDoanhThu.push(res.Thang1.DoanhThu);
                arrDataDoanhThu.push(res.Thang2.DoanhThu);
                arrDataDoanhThu.push(res.Thang3.DoanhThu);
                arrDataDoanhThu.push(res.Thang4.DoanhThu);
                arrDataDoanhThu.push(res.Thang5.DoanhThu);
                arrDataDoanhThu.push(res.Thang6.DoanhThu);
                arrDataDoanhThu.push(res.Thang7.DoanhThu);
                arrDataDoanhThu.push(res.Thang8.DoanhThu);
                arrDataDoanhThu.push(res.Thang9.DoanhThu);
                arrDataDoanhThu.push(res.Thang10.DoanhThu);
                arrDataDoanhThu.push(res.Thang11.DoanhThu);
                arrDataDoanhThu.push(res.Thang12.DoanhThu);

                arrDataDoanhThu.forEach(function (item, index) {
                    totalDoanhThu += item;
                });
                $(""#totalDoanhThu"").text(numberWithCommas(totalDoanhThu) + "" đ"");
           ");
            WriteLiteral(@"     console.log(arrDataDoanhThu);
            }
        }).done(function () {
            var myChart = new Chart(ctxDoc, {
                type: 'line',
                data: {
                    labels: ['Tháng 1', 'Tháng 2', 'Tháng 3', 'Tháng 4', 'Tháng 5', 'Tháng 6', 'Tháng 7', 'Tháng 8', 'Tháng 9', 'Tháng 10', 'Tháng 11', 'Tháng 12'],
                    datasets: [
                        {
                            label: 'Doanh thu',
                            data: arrDataDoanhThu,
                            backgroundColor: [
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                        ");
            WriteLiteral(@"        '#6c757d',
                                '#6c757d'
                            ],
                            borderColor: [
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d',
                                '#6c757d'
                            ],
                            borderWidth: 1
                        }
                    ]
                },
                options: {
                    scales: {
                        yAxes: [{
                            ticks: {
                                beginAtZero: true
                            }");
            WriteLiteral("\r\n                        }]\r\n                    }\r\n                }\r\n            });\r\n        });\r\n    }\r\n</script>\r\n<script>\r\n    SetChartBieuDoDoc();\r\n    SetChartDoanhThu();\r\n</script>");
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