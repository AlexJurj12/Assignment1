#pragma checksum "C:\Users\ajurj\RiderProjects\DNP1\Assignment1\Assignment1\Pages\EditAdult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e1efdc6081200d1a649cbe586cc7be76aae981b"
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
#line 1 "C:\Users\ajurj\RiderProjects\DNP1\Assignment1\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ajurj\RiderProjects\DNP1\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ajurj\RiderProjects\DNP1\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ajurj\RiderProjects\DNP1\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ajurj\RiderProjects\DNP1\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ajurj\RiderProjects\DNP1\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ajurj\RiderProjects\DNP1\Assignment1\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ajurj\RiderProjects\DNP1\Assignment1\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ajurj\RiderProjects\DNP1\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ajurj\RiderProjects\DNP1\Assignment1\Assignment1\Pages\EditAdult.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ajurj\RiderProjects\DNP1\Assignment1\Assignment1\Pages\EditAdult.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditAdult")]
    public partial class EditAdult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\ajurj\RiderProjects\DNP1\Assignment1\Assignment1\Pages\EditAdult.razor"
       
    private Adult adultToEdit = new Adult();
    private IList<Adult> allAdults = new List<Adult>();
    private int? id;

    protected override async Task OnInitializedAsync()
    {
        allAdults = Persistence.ReadAllAdults().ToList();
    }
    
    private void UpdateAdult()
    {
        Persistence.UpdateAdult(adultToEdit);
        NavigationManager.NavigateTo("/ViewAdults");
    }

    private void GetAdultToEdit(ChangeEventArgs eventArgs)
    {
        id = null;
        try
        {
            id = int.Parse(eventArgs.Value.ToString());
        }
        catch (Exception e)
        {
        }
        adultToEdit = new Adult();
        foreach (var adult in allAdults)
        {
            if (adult.Id == id)
            {
                adultToEdit = adult;
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService Persistence { get; set; }
    }
}
#pragma warning restore 1591
