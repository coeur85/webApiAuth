#pragma checksum "/Users/magdi/Documents/Projects/wepApiAuth/spa/spa.Client/Shared/SurveyPrompt.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5e86ccd42676ee8960045cf5aa12e98f68327af"
// <auto-generated/>
#pragma warning disable 1591
namespace spa.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using spa.Client;
    using spa.Client.Shared;
    public class SurveyPrompt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "alert alert-secondary mt-4");
            builder.AddAttribute(2, "role", "alert");
            builder.AddMarkupContent(3, "\r\n    <span class=\"oi oi-pencil mr-2\" aria-hidden=\"true\"></span>\r\n    ");
            builder.OpenElement(4, "strong");
            builder.AddContent(5, Title);
            builder.CloseElement();
            builder.AddMarkupContent(6, "\r\n\r\n    ");
            builder.AddMarkupContent(7, "<span class=\"text-nowrap\">\r\n        Please take our\r\n        <a target=\"_blank\" class=\"font-weight-bold\" href=\"https://go.microsoft.com/fwlink/?linkid=2086020\">brief survey</a>\r\n    </span>\r\n    and tell us what you think.\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 12 "/Users/magdi/Documents/Projects/wepApiAuth/spa/spa.Client/Shared/SurveyPrompt.razor"
            
    // Demonstrates how a parent component can supply parameters
    [Parameter] string Title { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591