#pragma checksum "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\Pages\MarkupStr.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a423c04439304ffa04efb8be4d448620398a9a7c"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/markupstr")]
    public partial class MarkupStr : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "Markup String");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 5 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\Pages\MarkupStr.razor"
 foreach(var country in countries)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "p");
#nullable restore
#line (7,10)-(7,33) 24 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\Pages\MarkupStr.razor"
__builder.AddContent(4, (MarkupString)(country));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 8 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\Pages\MarkupStr.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "D:\Learning\Blazor\BlazorFundamentals\BlazorApp\Pages\MarkupStr.razor"
       
    private List<string> countries;

    protected override void OnInitialized()
    {
        base.OnInitialized();
        countries = new List<string> { "<b>Qatar</b>", "<b>Brazil</b>", "<b>USA</b>", "Candda" };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
