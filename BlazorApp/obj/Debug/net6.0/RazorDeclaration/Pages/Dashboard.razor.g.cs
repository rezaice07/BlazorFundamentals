// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\_Imports.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\_Imports.razor"
using BlazorApp.Pages.ContactComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\_Imports.razor"
using BlazorApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/dashboard")]
    public partial class Dashboard : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\Dashboard.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationState { get; set; }
    private async Task DisplayGreetingAlert()
    {
        var authState = await authenticationState;
        var message = $"Hello {authState.User.Identity.Name})";

        await js.InvokeVoidAsync("alert",message);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
