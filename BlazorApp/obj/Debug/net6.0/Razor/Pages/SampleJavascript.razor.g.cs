#pragma checksum "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\Pages\SampleJavascript.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ad4b757f31ada6bdf4ab985257139dc8a5fc640"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\_Imports.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\_Imports.razor"
using BlazorApp.Pages.ContactComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\_Imports.razor"
using BlazorApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/sample-javascript")]
    public partial class SampleJavascript : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Sample Javascript</h3>\r\n");
            __builder.OpenElement(1, "span");
#nullable restore
#line (5,8)-(5,19) 24 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\Pages\SampleJavascript.razor"
__builder.AddContent(2, confirmData);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\Pages\SampleJavascript.razor"
                  ShowAlert

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, " Show Alert");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\Pages\SampleJavascript.razor"
                  ShowConfirm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, " Show Confirm");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\Pages\SampleJavascript.razor"
       
    private string confirmData;
    private void ShowAlert()
    {
        jsRuntime.InvokeVoidAsync("alert","Welcome to JS RUN Time");
    }

    private async Task ShowConfirm()
    {
        var res = await jsRuntime.InvokeAsync<bool>("confirm", "Do you want to proceed?");

        confirmData = res.ToString();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
