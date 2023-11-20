#pragma checksum "C:\Users\tanyapornk.std\Desktop\iTDashboard\Github\iTDashboardFrontEnd\iTDashboardFrontEnd\Views\Home\ChartTAT.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ee79190874b26dc33acc09f168b657aa192f3b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ChartTAT), @"mvc.1.0.view", @"/Views/Home/ChartTAT.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ee79190874b26dc33acc09f168b657aa192f3b5", @"/Views/Home/ChartTAT.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99f7ec520bf37c06db868103d1cfb530daaea8cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ChartTAT : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col bg-white custom-border"" style=""height: 370px; width: 660px; margin-top: 8px;"">
    <div style=""height: 367px;"" id=""containerchart2""></div>
</div>
<div class=""col bg-white custom-border"" style=""height: 370px; width: 660px; margin-top: 11px; "" id=""Chart3"">
    <div style=""height: 367px;"" id=""containerchart3""></div>
</div>
<script>

    $(document).ready(function () {
        loadChart();


    });
     function loadChart() {
            $.ajax({
                type: ""GET"",
               url: `/Home/IndexChart2?year=${`");
#nullable restore
#line 17 "C:\Users\tanyapornk.std\Desktop\iTDashboard\Github\iTDashboardFrontEnd\iTDashboardFrontEnd\Views\Home\ChartTAT.cshtml"
                                          Write(TempData["Year"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"`}`,
                dataType: ""json"",
                data: {},
                success: function (result) {
                    BindChart(result, ""Main"");
                },
                error: function (data) {
                    alert(""The System has some problem..please try it again."");
                }
            }); // Removed the extra comma here

          $.ajax({
            type: ""GET"",
             url: `/Home/IndexChart3?year=${`");
#nullable restore
#line 30 "C:\Users\tanyapornk.std\Desktop\iTDashboard\Github\iTDashboardFrontEnd\iTDashboardFrontEnd\Views\Home\ChartTAT.cshtml"
                                        Write(TempData["Year"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("`}&mmonth=${`");
#nullable restore
#line 30 "C:\Users\tanyapornk.std\Desktop\iTDashboard\Github\iTDashboardFrontEnd\iTDashboardFrontEnd\Views\Home\ChartTAT.cshtml"
                                                                      Write(TempData["Month"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("`}`,\r\n            dataType: \"json\",\r\n            data: {},\r\n                success: function (result) {\r\n                     var monthColor = getMonthColor(`");
#nullable restore
#line 34 "C:\Users\tanyapornk.std\Desktop\iTDashboard\Github\iTDashboardFrontEnd\iTDashboardFrontEnd\Views\Home\ChartTAT.cshtml"
                                                Write(TempData["Month"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("`);\r\n                    BindChart2(result, \"Category\", monthColor,`");
#nullable restore
#line 35 "C:\Users\tanyapornk.std\Desktop\iTDashboard\Github\iTDashboardFrontEnd\iTDashboardFrontEnd\Views\Home\ChartTAT.cshtml"
                                                          Write(TempData["Year"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"`);
                },
                error: function (data) {
                    alert(""The System has some problem..please try it again."");
                },
            })
         function getMonthColor(month) {
             switch (month) {
                 case ""Jan"":
                     return '#FF5721';
                 case ""Feb"":
                     return '#FF7F50';
                 case ""Mar"":
                     return '#FF7D40';
                 case ""Apr"":
                     return '#FFC469';
                 case ""May"":
                     return '#FFA824';
                 case ""Jun"":
                     return '#FFFF7E';
                 case ""Jul"":
                     return '#FFFF00';
                 case ""Aug"":
                     return '#FFE303';
                 case ""Sep"":
                     return '#EEC900';
                 case ""Oct"":
                     return '#EE7621';
                 case ""Nov"":
                     return '#FF8C00'");
            WriteLiteral(@";
                 case ""Dec"":
                     return '#EE4000';
                 default:
                     return getRandColor(false, 2);
             }
         }
    }

    function BindChart(serie, name, color) {

        var _data = [];
        var _tatTarget = [];
        for (var i in serie) {
            var itm = {
                name: (name == ""Main"" ? serie[i].short_month : serie[i].category),
                y: (name == ""Main"" ? serie[i].tat : serie[i].taTofCate),
                target: serie[i].target,
                chart: (name == ""Main"" ? 'Monthly' : 'Category'),
                iyear: `");
#nullable restore
#line 83 "C:\Users\tanyapornk.std\Desktop\iTDashboard\Github\iTDashboardFrontEnd\iTDashboardFrontEnd\Views\Home\ChartTAT.cshtml"
                   Write(TempData["Year"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"`,
                imonth: serie[i].short_month,
                drilldown: (name == ""Main"" ? true : false),
                
            }

            _data.push(itm);
            _tatTarget.push(serie[i].target);

        }
        
  

        Highcharts.chart('containerchart2', {
            chart: {
                type: 'column',
                backgroundColor: '#FFFFFF',
                borderColor: '#17202A',
                borderWidth: 0,
                className: 'dark-container',
                plotBackgroundColor: '#F4F6F6',
                plotBorderColor: '#A9CCE3',
                plotBorderWidth: 1,
                events: {
                }
            },
            title: {
                text: 'TAT - IT ' + (name == ""Main"" ? '' : serie[i].short_month) + ' (Target : <= ' + serie[i].target +' Calendar day)'
            },
            xAxis: {
                type: 'category',

                labels: {
                    style: {
                    ");
            WriteLiteral(@"    color: 'black',
                        fontWeight: 'bold',
                        fontSize: '12px'

                    }

                },

                stackLabels: {
                    enabled: true,
                    style: {
                        fontWeight: 'bold',
                        fontSize: '15px',
                        color: 'black'
                    }
                },

            },
            legend: {
                itemStyle: {
                    fontSize: '15px',
                    font: '15pt Trebuchet MS, Verdana, sans-serif',
                    color: '#8b8378'

                }

            },
            yAxis: {
                min: 0,
                max: 50,
                title: {
                    text: 'Turnaround time of TSD(Calendar Day)'
                },
                stackLabels: {
                    enabled: true,
                    style: {
                        fontWeight: 'bold',
              ");
            WriteLiteral(@"          color: (Highcharts.theme && Highcharts.theme.textColor) || '#0A0A09'
                    }
                },

            },
            tooltip: {
                formatter: function () {
                    return '<b>' + '<br/>' +
                        this.series.name + ': ' + this.y + ' Days' + '<br/>' +
                        'Total: ' + this.point.stackTotal + ' Days';
                }
            },
            legend: {
                enabled: true
            },

            plotOptions: {
                series: {
                    stacking: 'normal',
                    borderWidth: 0,
                    dataLabels: {
                        enabled: false
                    },
                    colorByPoint: true,
                    point: {
                        events: {
                            click: function (e) {
                                {
                                    //Call table
                                    if (");
            WriteLiteral(@"e.point.chart == 'Monthly') {

                                        GetCategoryChart(e.point.iyear, e.point.name, e.point.color, e.srcElement.attributes.fill.nodeValue);

                                        //console.log(e);
                                        //console.log(e.srcElement.attributes.fill.nodeValue);
                                        //onClick(e.point.name, this.name, e.point.label);
                                    }
                                    else if (e.point.chart == 'Category') {

                                        onClick(e.point.name, e.point.imonth, e.point.iyear);
                                        //console.log(e.point.name);
                                        // console.log(e.point.imonth);
                                        //console.log(e.point.iyear);
                                    }


                                }
                            }
                        }
                    }
             ");
            WriteLiteral(@"   }
            },
            credits: {
                ""enabled"": true
            },
            series: [{
                type: 'column',
                name: 'TAT',
                pointWidth: 30,
                colors: [
                    '#FF5721', '#FF7F50', '#FF7D40', '#FFC469', '#FFA824', '#FFFF7E',
                    '#FFFF00', '#FFE303', '#EEC900', '#EE7621', '#FF8C00', '#EE4000'
                ], 
                colorByPoint: true,
                data: _data,

                borderWidth: 2,


            }, {
                type: 'spline',
                name: 'Target',
                data: _tatTarget,//_tatTarget,
                marker: {
                    lineWidth: 2,
                    lineColor: Highcharts.getOptions().colors[3],
                    fillColor: 'white'
                }
            }]

             
        });


        function GetCategoryChart(year,name, color) {
            $.ajax({
            type: ""GET"",
         ");
            WriteLiteral(@"       url: `/Home/IndexChart3?year=` + year + `&mmonth=` + name,
            dataType: ""json"",
            data: {},
                success: function (result) {

                    BindChart2(result, ""Category"", color, year);
                },
                error: function (data) {
                    alert(""The System has some problem..please try it again."");
                },
            })
        }
    }

    function BindChart2(serie, name, color,year) {

        var _data = [];
        var _tatTarget = [];
        for (var i in serie) {
            var itm = {
                name: (name == ""Main"" ? serie[i].short_month : serie[i].category),
                y: (name == ""Main"" ? serie[i].tat : serie[i].taTofCate),
                target: serie[i].target,
                chart: (name == ""Main"" ? 'Monthly' : 'Category'),
                iyear: year,
                imonth: serie[i].short_month,
                drilldown: (name == ""Main"" ? true : false),
                col");
            WriteLiteral(@"or: color
                
            }

            _data.push(itm);
            _tatTarget.push(serie[i].target);

        }

        //console.log(_data);
        //console.log(_tatTarget);

        Highcharts.chart('containerchart3', {
            chart: {
                type: 'column',
                backgroundColor: '#FFFFFF',
                borderColor: '#17202A',
                borderWidth: 0,
                className: 'dark-container',
                plotBackgroundColor: '#F4F6F6',
                plotBorderColor: '#A9CCE3',
                plotBorderWidth: 1,
                events: {
                }
            },
            title: {
                text: 'TAT - IT ' + (name == ""Main"" ? '' : serie[i].short_month) + ' (Target : <= 25' +  ' Calendar day)'
            },
            xAxis: {
                type: 'category',

                labels: {
                    style: {
                        color: 'black',
                        fontWeight: 'bo");
            WriteLiteral(@"ld',
                        fontSize: '12px'

                    }

                },

                stackLabels: {
                    enabled: true,
                    style: {
                        fontWeight: 'bold',
                        fontSize: '15px',
                        color: 'black'
                    }
                },

            },
            legend: {
                itemStyle: {
                    fontSize: '15px',
                    font: '15pt Trebuchet MS, Verdana, sans-serif',
                    color: '#8b8378'

                }

            },
            yAxis: {
                min: 0,
                max: 50,
                title: {
                    text: 'Turnaround time of TSD(Calendar Day)'
                },
                stackLabels: {
                    enabled: true,
                    style: {
                        fontWeight: 'bold',
                        color: (Highcharts.theme && Highcharts.theme.textC");
            WriteLiteral(@"olor) || '#0A0A09'
                    }
                },

            },
            tooltip: {
                formatter: function () {
                    return '<b>' + '<br/>' +
                        this.series.name + ': ' + this.y + ' Days' + '<br/>' +
                        'Total: ' + this.point.stackTotal + ' Days';
                }
            },
            legend: {
                enabled: true
            },

            plotOptions: {
                series: {
                    stacking: 'normal',
                    borderWidth: 0,
                    dataLabels: {
                        enabled: false
                    },
                    colorByPoint: true,

                }
            },
            credits: {
                ""enabled"": true
            },
            series: [{
                type: 'column',
                name: 'TAT',
                pointWidth: 30,
                /*colorByPoint: true,*/
                data: _data,
");
            WriteLiteral(@"
                borderWidth: 2,


            }, {
                type: 'spline',
                name: 'Target',
                data: _tatTarget,//_tatTarget,
                marker: {
                    lineWidth: 2,
                    lineColor: Highcharts.getOptions().colors[3],
                    fillColor: 'white'
                }
            }]




        });


        function GetCategoryChart(name, color) {
            $.ajax({
            type: ""GET"",
                url: `/Home/IndexChart3?year=${`");
#nullable restore
#line 398 "C:\Users\tanyapornk.std\Desktop\iTDashboard\Github\iTDashboardFrontEnd\iTDashboardFrontEnd\Views\Home\ChartTAT.cshtml"
                                           Write(TempData["Year"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"`}&mmonth=` + name,
            dataType: ""json"",
            data: {},
                success: function (result) {

                    BindChart(result, ""Category"", null, 'containerchart3');
                },
                error: function (data) {
                    alert(""The System has some problem..please try it again."");
                },
            })
        }
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
