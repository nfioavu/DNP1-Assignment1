#pragma checksum "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\Members\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54fec1f9fe3540cef75d7d468bb7b2977bd7cde1"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Pages.Members
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\_Imports.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\Members\Adults.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\Members\Adults.razor"
using Microsoft.AspNetCore.Mvc.Filters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\Members\Adults.razor"
using Microsoft.AspNetCore.Mvc.Formatters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\Members\Adults.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\Members\Adults.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\Members\Adults.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\Members\Adults.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\Members\Adults.razor"
using Assignment1.Data.FamilyMembersService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\Members\Adults.razor"
using Syncfusion.Blazor.Diagrams;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\Members\Adults.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Adults</h3>\r\n\r\n    ");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.AddMarkupContent(4, "<thead>\r\n        <tr>\r\n            <th>Names</th>\r\n            <th>Age</th>\r\n            <th>Job</th>\r\n        </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 27 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\Members\Adults.razor"
         foreach (var items in familiesToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 30 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\Members\Adults.razor"
                     ExtractFamilyAdults(items)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 31 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\Members\Adults.razor"
                     ExtractFamilyAdultsAges(items)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 32 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\Members\Adults.razor"
                     ExtractFamilyAdultsJobs(items)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 34 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\Members\Adults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\Members\Adults.razor"
       
    private IList<Family> families;
    private IList<Family> familiesToShow;

    protected override async Task OnInitializedAsync()
    {
        families = FamilyMembersService.GetFamilies();
        familiesToShow = families;
    }

    // private void RemoveAdult(int id)
    // {
    //     Adult adultToRemove = adults.First(a => a.Id == id);
    //     FamilyMembersService.RemoveAdult(id);
    //     adults.Remove(adultToRemove);
    // }
    
    private StringBuilder ExtractFamilyAdults(Family family)
    {
        StringBuilder trmp = new StringBuilder();
        int count = 0;
        foreach (var adult in family.Adults)
        {
            if (adult != null)
            {
                count++;
                trmp.Append(adult.FirstName + " " + adult.LastName + ", ");
            }
        }

        if (count != 0)
        {
            trmp.Length--;
            trmp.Length--;
        }
        return trmp;
    }
    
    private StringBuilder ExtractFamilyAdultsAges(Family family)
    {
        StringBuilder trmp = new StringBuilder();
        int count = 0;
        foreach (var adult in family.Adults)
        {
            if (adult != null)
            {
                count++;
                trmp.Append(adult.Age + ", ");
            }
        }

        if (count != 0)
        {
            trmp.Length--;
            trmp.Length--;
        }
        return trmp;
    }
    
    private StringBuilder ExtractFamilyAdultsJobs(Family family)
    {
        StringBuilder trmp = new StringBuilder();
        int count = 0;
        foreach (var adult in family.Adults)
        {
            if (adult != null)
            {
                count++;
                trmp.Append(adult.JobTitle + ", ");
            }
        }

        if (count != 0)
        {
            trmp.Length--;
            trmp.Length--;
        }
        return trmp;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyMembersService FamilyMembersService { get; set; }
    }
}
#pragma warning restore 1591
