#pragma checksum "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\Index.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ea6d6c9f101f3028e75840984fab48f344534ee098cbdabf91042c1585366e78"
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
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(2, "Home");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.AddMarkupContent(4, "<a href=\"/demo01\">Add New Contacts</a>\r\n<br>\r\n\r\n");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "checkbox");
            __builder.AddAttribute(7, "checked", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\Index.razor"
                              displayEmailAddress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => displayEmailAddress = __value, displayEmailAddress));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "<label>Display Email</label>\r\n<br>");
#nullable restore
#line 11 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\Index.razor"
 if (contacts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<span class=\"loading\">Contact is loading...</span>");
#nullable restore
#line 14 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\Index.razor"
}
else if (contacts.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<span>No Contacts to be loaded!</span>");
#nullable restore
#line 18 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\Index.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\Index.razor"
     foreach (var item in contacts)
    {
        

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::BlazorApp.Pages.ContactComponents.ContactListComponent>(12);
            __builder.AddAttribute(13, "IsDislplayEmail", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 24 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\Index.razor"
                                                displayEmailAddress

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "DeleteCurrentContact", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::BlazorApp.Data.Contact>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::BlazorApp.Data.Contact>(this, 
#nullable restore
#line 24 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\Index.razor"
                                                                                           DeleteContact

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(15, "contact", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::BlazorApp.Data.Contact>(
#nullable restore
#line 24 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\Index.razor"
                                                                                                                    item

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "<hr>");
#nullable restore
#line 28 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "D:\Learning\blazor\projects\repo\BlazorFundamentals\BlazorApp\Pages\Index.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
