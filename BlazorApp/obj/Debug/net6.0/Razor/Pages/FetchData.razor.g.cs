#pragma checksum "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\FetchData.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0837e79795e6ff684b17cd57b4d30547ab1803d52c9a021b004cd9d57dad3171"
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
#line 5 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\FetchData.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "Weather forecast");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(4, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(5, "<p>This component demonstrates fetching data from a service.</p>");
#nullable restore
#line 12 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p><em>Loading...</em></p>");
#nullable restore
#line 15 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "<thead><tr><th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th></tr></thead>\r\n        ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 28 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
#nullable restore
#line (31,26)-(31,59) 25 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\FetchData.razor"
__builder.AddContent(13, forecast.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
#nullable restore
#line (32,26)-(32,47) 25 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\FetchData.razor"
__builder.AddContent(16, forecast.TemperatureC);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
#nullable restore
#line (33,26)-(33,47) 25 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\FetchData.razor"
__builder.AddContent(19, forecast.TemperatureF);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
#nullable restore
#line (34,26)-(34,42) 25 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\FetchData.razor"
__builder.AddContent(22, forecast.Summary);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\FetchData.razor"
       
    private WeatherForecast[]? forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
