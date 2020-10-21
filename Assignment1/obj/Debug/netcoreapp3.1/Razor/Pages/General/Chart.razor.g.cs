#pragma checksum "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\Pages\General\Chart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9cac47d3a5d3f975e1f73068202d50ec0c871ae"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Pages.General
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\Pages\General\Chart.razor"
using Assignment1.Data.FamilyMembersService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chart")]
    public partial class Chart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Chart</h3>\r\n\r\n");
            __builder.OpenElement(1, "SfChart");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "ChartPrimaryXAxis");
            __builder.AddAttribute(4, "Title", "Number of adults");
            __builder.AddAttribute(5, "ValueType", "Syncfusion.Blazor.Charts.ValueType.Category");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "ChartPrimaryYAxis");
            __builder.AddAttribute(8, "Title", "Number of children");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "ChartSeriesCollection");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "ChartSeries");
            __builder.AddAttribute(13, "DataSource", 
#nullable restore
#line 14 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\Pages\General\Chart.razor"
                                  familiesChart

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "XName", "adults");
            __builder.AddAttribute(15, "YName", "children");
            __builder.AddAttribute(16, "Type", "ChartSeriesType.Column");
            __builder.AddMarkupContent(17, "\r\n            \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\Pages\General\Chart.razor"
       
    
    public class FML
    {
        public int children;
        public int adults;
    }
    public List<FML> familiesChart = new List<FML>
    {
        new FML {children = 2, adults = 2},
        new FML {children = 2, adults = 1},
        new FML {children = 0, adults = 2},
        new FML {children = 4, adults = 2},
        
        new FML {children = 2, adults = 1},
        new FML {children = 2, adults = 2},
        new FML {children = 1, adults = 2},
        new FML {children = 1, adults = 1},
        
        new FML {children = 2, adults = 2},
        new FML {children = 2, adults = 1},
        new FML {children = 2, adults = 2},
        new FML {children = 6, adults = 2},
        
        new FML {children = 3, adults = 1},
        new FML {children = 2, adults = 2},
        new FML {children = 3, adults = 2},
        new FML {children = 1, adults = 2},
        
        new FML {children = 3, adults = 2},
        new FML {children = 3, adults = 2},
        new FML {children = 3, adults = 2},
        new FML {children = 3, adults = 1},
        
        new FML {children = 2, adults = 2},
        new FML {children = 5, adults = 1},
        new FML {children = 3, adults = 2},
        new FML {children = 3, adults = 2},
        new FML {children = 2, adults = 2},
    };

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyMembersService FamilyMembersService { get; set; }
    }
}
#pragma warning restore 1591
