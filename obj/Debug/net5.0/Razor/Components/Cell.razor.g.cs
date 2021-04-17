#pragma checksum "/home/darek/Programming/ZadanieRekrutacyjne/Components/Cell.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "921008f0cd3116930162d1074e9485fc224f4c4c"
// <auto-generated/>
#pragma warning disable 1591
namespace ZadanieRekrutacyjne.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/darek/Programming/ZadanieRekrutacyjne/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/darek/Programming/ZadanieRekrutacyjne/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/darek/Programming/ZadanieRekrutacyjne/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/darek/Programming/ZadanieRekrutacyjne/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/darek/Programming/ZadanieRekrutacyjne/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/darek/Programming/ZadanieRekrutacyjne/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/darek/Programming/ZadanieRekrutacyjne/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/darek/Programming/ZadanieRekrutacyjne/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/darek/Programming/ZadanieRekrutacyjne/_Imports.razor"
using ZadanieRekrutacyjne;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/darek/Programming/ZadanieRekrutacyjne/_Imports.razor"
using ZadanieRekrutacyjne.Shared;

#line default
#line hidden
#nullable disable
    public partial class Cell : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "cell");
            __builder.AddContent(2, 
#nullable restore
#line 1 "/home/darek/Programming/ZadanieRekrutacyjne/Components/Cell.razor"
                   value

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n\n\n");
            __builder.AddMarkupContent(4, @"<style scoped>
    .cell {
        background-color: rgba(255, 255, 255, 0.8);
        border: 1px solid rgba(0, 0, 0, 0.8);
        width: 20px;
        height: 20px;
        font-size: 10px;
        text-align: center;
        vertical-align: middle;
        line-height: 20px;
        border-radius: 10%;
        cursor: pointer;
    }
    .cell:hover {
        background-color: rgba(106, 202, 9, 0.8);
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "/home/darek/Programming/ZadanieRekrutacyjne/Components/Cell.razor"
            
    [Parameter]
    public char value { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
