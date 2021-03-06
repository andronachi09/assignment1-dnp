#pragma checksum "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21d63f9c70eb758aba42bf38c2012fd76beb0507"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\_Imports.razor"
using Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\_Imports.razor"
using Assignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
using Assignment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
using Assignment.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
using Microsoft.AspNetCore.Mvc.Filters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adult")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Adult</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Filter by user ID: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "number");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
                                                        (arg) => Filter(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
 if (adultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p><em>Loading...</em></p>");
#nullable restore
#line 21 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
}
else if (!adultsToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Please add adults.</em></p>");
#nullable restore
#line 27 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.OpenElement(10, "thead");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "<th>ID</th>\r\n            ");
            __builder.AddMarkupContent(13, "<th>First Name</th>\r\n            ");
            __builder.AddMarkupContent(14, "<th>Last Name</th>\r\n            ");
            __builder.AddMarkupContent(15, "<th>Job</th>\r\n            ");
            __builder.AddMarkupContent(16, "<th>Hair Color</th>\r\n            ");
            __builder.AddMarkupContent(17, "<th>Eye Color</th>\r\n            ");
            __builder.AddMarkupContent(18, "<th>Age</th>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(19);
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(21, "<th>Remove</th>\r\n                ");
                __builder2.AddMarkupContent(22, "<th>Edit</th>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "tbody");
#nullable restore
#line 47 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
         foreach (var item in adultsToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "tr");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 50 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 51 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "td");
            __builder.AddContent(33, 
#nullable restore
#line 52 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 53 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
                     item.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 54 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
                     item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 55 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
                     item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 56 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(47);
            __builder.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(49, "td");
                __builder2.OpenElement(50, "button");
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
                                            () => RemoveAdult(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(52, "<i class=\"oi oi-trash\" style=\"color:red\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                    ");
                __builder2.OpenElement(54, "td");
                __builder2.OpenElement(55, "button");
                __builder2.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
                                            () => Edit(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(57, "<i class=\"oi oi-pencil\" style=\"color: black\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 73 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\Tudor\RiderProjects\SolutionExample\Assignment\Pages\Adults.razor"
       

    private IList<Adult> adults;
    private IList<Adult> adultsToShow;

    protected override async Task OnInitializedAsync()
    {
        adults = AdultData.GetAdults();
        adultsToShow = adults;
    }

    private void RemoveAdult(int id)
    {
        Adult toRemove = adults.First(a => a.Id == id);
        adults.Remove(toRemove);
        adultsToShow.Remove(toRemove);
        AdultData.RemoveAdult(toRemove);
    }

    private void Filter(ChangeEventArgs changeEventArgs)
    {
        int? filterById = null;
        try
        {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e)
        {
        }
        if (filterById != null)
        {
            adultsToShow = adults.Where(t => t.Id == filterById).ToList();
        }
        else
        {
            adultsToShow = adults;
        }
    }

    private void Edit(int id)
    {
        NavMgr.NavigateTo($"edit/{id}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData AdultData { get; set; }
    }
}
#pragma warning restore 1591
