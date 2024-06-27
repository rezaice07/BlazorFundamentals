#pragma checksum "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\RadzenDDL.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "db1dca9dbd21592205cf5d5407b2c43ea4314adf004eb53d5178de624241aaed"
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
#nullable restore
#line 3 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\RadzenDDL.razor"
           [Authorize(Roles ="Administrator")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/dropdown")]
    public partial class RadzenDDL : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Drop Down Example</h3>");
#nullable restore
#line 7 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\RadzenDDL.razor"
 if (products == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading....</em></p>");
#nullable restore
#line 10 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\RadzenDDL.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Radzen.Blazor.RadzenDropDownDataGrid<string>>(2);
            __builder.AddAttribute(3, "FilterCaseSensitivity", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Radzen.FilterCaseSensitivity>(
#nullable restore
#line 13 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\RadzenDDL.razor"
                                                                   FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "AllowFiltering", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 13 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\RadzenDDL.razor"
                                                                                                                          true

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "AllowClear", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 14 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\RadzenDDL.razor"
                true

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "Data", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.IEnumerable>(
#nullable restore
#line 14 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\RadzenDDL.razor"
                             products.Select(s=>new {ProductId=s.ProductId,ProductName=s.ProductName}).Distinct().AsQueryable()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "TextProperty", (object)("ProductName"));
            __builder.AddAttribute(8, "ValueProperty", (object)("ProductId"));
            __builder.AddAttribute(9, "Style", (object)("margin-bottom:20px"));
            __builder.AddAttribute(10, "Placeholder", (object)("Select..."));
            __builder.CloseComponent();
#nullable restore
#line 18 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\RadzenDDL.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\RadzenDDL.razor"
       
    IEnumerable<Product> products;
    protected override async Task OnInitializedAsync()
    {
        products = await Task.Run(() => productService.ProductList());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductService productService { get; set; }
    }
}
#pragma warning restore 1591