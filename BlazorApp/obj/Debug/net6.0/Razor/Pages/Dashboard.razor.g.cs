#pragma checksum "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\Dashboard.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "62c3e5db422500ee3b63966d6fbe5abde5dc9545e9fc47c698b2f66fd85014e1"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "Dashboard");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(4);
            __builder.AddAttribute(5, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "h1");
                __builder2.AddContent(7, "Hello, ");
#nullable restore
#line (11,21)-(11,47) 25 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\Dashboard.razor"
__builder2.AddContent(8, context.User.Identity.Name);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(9, "!");
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(10, "NotAuthorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "<h1>Hello, Guest!</h1>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\nWelcome to your new app.\r\n");
            __builder.OpenComponent<global::BlazorApp.Shared.SurveyPrompt>(13);
            __builder.AddAttribute(14, "Title", (object)("How is Blazor working for you?"));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(16);
            __builder.AddAttribute(17, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(18, "<br>\r\n        <br>\r\n        ");
                __builder2.OpenElement(19, "button");
                __builder2.AddAttribute(20, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(21, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\Dashboard.razor"
                                                          DisplayGreetingAlert

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(22, "Display Greeting Alert");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
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
