#pragma checksum "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\Pages\TestPageDirective.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b2eedb3d7c1e184c4369dac9f9688d79a17489c"
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/testpage")]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/testpage2")]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/testpage/demo")]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/testpage/{contactName}/{Age:int}")]
    public partial class TestPageDirective : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Test Page Directive</h3>\r\n\r\n<br>\r\n");
            __builder.AddMarkupContent(1, "<a href=\"./index\">Index</a>\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\Pages\TestPageDirective.razor"
                  NavigateToIndex

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Navigate to Index");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(6, "span");
#nullable restore
#line (20,8)-(20,19) 24 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\Pages\TestPageDirective.razor"
__builder.AddContent(7, contactName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "\'s Age is ");
#nullable restore
#line (20,30)-(20,33) 24 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\Pages\TestPageDirective.razor"
__builder.AddContent(9, Age);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\Pages\TestPageDirective.razor"
       
    [Parameter]
    public string contactName { get; set; }

    [Parameter]
    public int Age { get; set; }

    private void NavigateToIndex()
    {
        navManager.NavigateTo("./index");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
    }
}
#pragma warning restore 1591
