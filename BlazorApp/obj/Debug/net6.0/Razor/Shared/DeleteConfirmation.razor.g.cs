#pragma checksum "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Shared\DeleteConfirmation.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4fa09186f570b2b017ebb84df27fa769a369d91e811c7657bbd05d8b22c52911"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Shared
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
    public partial class DeleteConfirmation : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Shared\DeleteConfirmation.razor"
 if (showPopup)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"modal-backdrop show\"></div>\r\n    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade show");
            __builder.AddAttribute(3, "style", "display:block");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "modal-dialog");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal-content");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-header");
            __builder.AddMarkupContent(11, "<h5 class=\"modal-title\">Confirm Delete</h5>\r\n                    ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "type", "button");
            __builder.AddAttribute(14, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Shared\DeleteConfirmation.razor"
                                                    Hide

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "class", "btn-close");
            __builder.AddAttribute(16, "data-bs-dismiss", "modal");
            __builder.AddAttribute(17, "aria-label", "Close");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "modal-body");
            __builder.OpenElement(21, "p");
#nullable restore
#line (12,25)-(12,36) 25 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Shared\DeleteConfirmation.razor"
__builder.AddContent(22, BodyContent);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "modal-footer");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "type", "button");
            __builder.AddAttribute(28, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Shared\DeleteConfirmation.razor"
                                                    Hide

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "class", "btn btn-secondary");
            __builder.AddAttribute(30, "data-bs-dismiss", "modal");
            __builder.AddContent(31, "Close");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Shared\DeleteConfirmation.razor"
                                                    Confirm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "class", "btn btn-danger");
            __builder.AddContent(37, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Shared\DeleteConfirmation.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Shared\DeleteConfirmation.razor"
       
    private bool showPopup = false;
    public string BodyContent { get; set; }

    public Contact ContactToDelete { get; set; }

    [Parameter]
    public EventCallback<Contact> OnConfirmed { get; set; }

    public void Show() => showPopup = true;
    public void Hide() => showPopup = false;

    private async Task Confirm()
    {
        await OnConfirmed.InvokeAsync(ContactToDelete);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
