#pragma checksum "C:\Users\Alireza\source\repos\NikamoozBuild2019Web\NikamoozBuild2019Web.Blazor\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "626b5a091c6474f37057249e6ed974d562142d38"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace NikamoozBuild2019Web.Blazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\Alireza\source\repos\NikamoozBuild2019Web\NikamoozBuild2019Web.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\Alireza\source\repos\NikamoozBuild2019Web\NikamoozBuild2019Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "C:\Users\Alireza\source\repos\NikamoozBuild2019Web\NikamoozBuild2019Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Users\Alireza\source\repos\NikamoozBuild2019Web\NikamoozBuild2019Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 5 "C:\Users\Alireza\source\repos\NikamoozBuild2019Web\NikamoozBuild2019Web.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "C:\Users\Alireza\source\repos\NikamoozBuild2019Web\NikamoozBuild2019Web.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Users\Alireza\source\repos\NikamoozBuild2019Web\NikamoozBuild2019Web.Blazor\_Imports.razor"
using NikamoozBuild2019Web.Blazor;

#line default
#line hidden
#line 8 "C:\Users\Alireza\source\repos\NikamoozBuild2019Web\NikamoozBuild2019Web.Blazor\_Imports.razor"
using NikamoozBuild2019Web.Blazor.Shared;

#line default
#line hidden
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 34 "C:\Users\Alireza\source\repos\NikamoozBuild2019Web\NikamoozBuild2019Web.Blazor\Shared\NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
