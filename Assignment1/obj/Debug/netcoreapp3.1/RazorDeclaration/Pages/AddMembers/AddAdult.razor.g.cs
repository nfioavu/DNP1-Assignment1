#pragma checksum "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\AddMembers\AddAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a30e938deb2e69d0d7d83564e56154b0c4eefa11"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment1.Pages
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
#line 4 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\AddMembers\AddAdult.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\AddMembers\AddAdult.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\AddMembers\AddAdult.razor"
using Assignment1.Data.FamilyMembersService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\AddMembers\AddAdult.razor"
           [Authorize(Policy="MustBeAdmin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addAdult")]
    public partial class AddAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\ioana\RiderProjects\DNP1\Assignment1\Pages\AddMembers\AddAdult.razor"
       
    private Adult newAdult = new Adult();

    private void AddNewAdult()
    {
        FamilyMembersService.AddAdult(newAdult);
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyMembersService FamilyMembersService { get; set; }
    }
}
#pragma warning restore 1591