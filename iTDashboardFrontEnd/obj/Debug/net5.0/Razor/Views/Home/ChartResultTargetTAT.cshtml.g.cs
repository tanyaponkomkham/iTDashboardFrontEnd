#pragma checksum "C:\Users\tanyapornk.std\Desktop\iTDashboard\Github\iTDashboardFrontEnd\iTDashboardFrontEnd\Views\Home\ChartResultTargetTAT.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c33eae94e21f203953459f3ae2160433c7f42dad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ChartResultTargetTAT), @"mvc.1.0.view", @"/Views/Home/ChartResultTargetTAT.cshtml")]
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
#line 1 "C:\Users\tanyapornk.std\Desktop\iTDashboard\Github\iTDashboardFrontEnd\iTDashboardFrontEnd\Views\_ViewImports.cshtml"
using iTDashboardFrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tanyapornk.std\Desktop\iTDashboard\Github\iTDashboardFrontEnd\iTDashboardFrontEnd\Views\_ViewImports.cshtml"
using iTDashboardFrontEnd.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c33eae94e21f203953459f3ae2160433c7f42dad", @"/Views/Home/ChartResultTargetTAT.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99f7ec520bf37c06db868103d1cfb530daaea8cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ChartResultTargetTAT : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col "" style="" height: 750px; width: 650px; margin-top: 1px; "">
        <div style="" height: 695px;"" id=""containerchart1""></div>
</div>
<script>

    $(document).ready(function () {
        $.ajax({
                type: ""GET"",
                url: '/Home/IndexChart2',
                cache: false,
                data: {
                year: '");
#nullable restore
#line 12 "C:\Users\tanyapornk.std\Desktop\iTDashboard\Github\iTDashboardFrontEnd\iTDashboardFrontEnd\Views\Home\ChartResultTargetTAT.cshtml"
                  Write(TempData["Year3"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'
                },
                dataType: ""json"",
                success: function (result) {
                    BindCharttable2(result);
            },

                error: function (data) {
                    alert(""The System has some problem..please try it again."");
                }
            });

    });


    function BindCharttable2(serie) {
        var _dataTarget = [];
        var _tatTarget = [];
        for (var i in serie) {

            if (serie[i].tat > serie[i].target) {

                var item = {
                    name: serie[i].short_month,
                    y: 1,
                    target: serie[i].target,
                    chart: 'Monthly',
                    iyear: `");
#nullable restore
#line 39 "C:\Users\tanyapornk.std\Desktop\iTDashboard\Github\iTDashboardFrontEnd\iTDashboardFrontEnd\Views\Home\ChartResultTargetTAT.cshtml"
                       Write(TempData["Year3"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"`,
                    imonth: serie[i].short_month,
                };
            } else {

                var item = {
                name: serie[i].short_month,
                y: 0,
                target: serie[i].target,
                chart: 'Monthly',
                iyear: `");
#nullable restore
#line 49 "C:\Users\tanyapornk.std\Desktop\iTDashboard\Github\iTDashboardFrontEnd\iTDashboardFrontEnd\Views\Home\ChartResultTargetTAT.cshtml"
                   Write(TempData["Year3"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"`,
                imonth: serie[i].short_month,
              };
            }

            _dataTarget.push(item);

        }
/*        console.log(_dataTarget);*/





        Highcharts.chart('containerchart1', {
            chart: {
                type: 'column',

            },
            title: {
                text: '',
                align: 'left'
            },
            subtitle: {
                text: '',
                align: 'left'
            },

            xAxis: {
                categories: ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'],
                crosshair: true,
                accessibility: {
                    description: 'month'
                }
            },
            yAxis: {
                min: 0, max: 10,

                title: {
                    text: ''
                },
                tickInterval: 1
            },
            tooltip: {
                valueSuffix: 'tar");
            WriteLiteral(@"get'
            },
            legend: {
                enabled: true
            },

            plotOptions: {
                column: {
                    pointPadding: 0.2,
                    borderWidth: 0
                }
            },

            series: [{
                type: 'column',
                name: 'ผลงานเกินกว่าเป้าหมาย (result over target)',
                pointWidth: 30,
                color: '#E40D0D',
                data: _dataTarget,
                borderWidth: 2,


            }
            ],
            legend: {
                align: 'left', //Legend (left, center, right)
                verticalAlign: 'bottom', // Legend (top, middle, bottom)
                layout: 'horizontal', // (horizontal, vertical)
                itemStyle: {
                    fontWeight: 'bold'
                },
                symbolRadius: 0

            },


        });
    }






</script>");
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
