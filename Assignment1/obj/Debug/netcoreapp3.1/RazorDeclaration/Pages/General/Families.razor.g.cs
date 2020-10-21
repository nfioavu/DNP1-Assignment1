#pragma checksum "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\Pages\General\Families.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07f643084236bd5ffc63168359de8d17a94679ef"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 9 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\Pages\General\Families.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\Pages\General\Families.razor"
using Microsoft.AspNetCore.Mvc.Filters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\Pages\General\Families.razor"
using Microsoft.AspNetCore.Mvc.Formatters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\Pages\General\Families.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\Pages\General\Families.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\Pages\General\Families.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\Pages\General\Families.razor"
using Assignment1.Data.FamilyMembersService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\Pages\General\Families.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/families")]
    public partial class Families : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\ROG\RiderProjects\DNP\DNP1-Assignment1\Assignment1\Pages\General\Families.razor"
       
    private IList<Family> families;
    private IList<Family> familiesToShow;
    private IList<Adult> adults;

    private Family _selectedFamily;

    

    protected override async Task OnInitializedAsync()
    {
        families = FamilyMembersService.GetFamilies();
        familiesToShow = families;
    }

    
    private void ShowFamilyMembers()
    {
        NavigationManager.NavigateTo("/familymembers");
    }

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

 
    private async Task<IEnumerable<Family>> FilterByFamilyName(string familyName)
    {
        return await Task.FromResult(families.Where(x => x.FamilyName.ToLower().Contains(familyName.ToLower())).ToList());
    }



    private void ShowAllFamilies()
    {
        familiesToShow = families;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyMembersService FamilyMembersService { get; set; }
    }
}
#pragma warning restore 1591
