#pragma checksum "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae0faa9c78bb7e2be898cb020e995097f0d3108c"
// <auto-generated/>
#pragma warning disable 1591
namespace LegoBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\_Imports.razor"
using LegoBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\_Imports.razor"
using LegoBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\_Imports.razor"
using Blazorise.Sidebar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\_Imports.razor"
using Blazorise.DataGrid;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazorise.Sidebar.Sidebar>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.OpenComponent<Blazorise.Sidebar.SidebarContent>(3);
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(5, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.Sidebar.SidebarBrand>(6);
                    __builder3.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(8, "\r\n            ");
                        __builder4.AddMarkupContent(9, "<a href>Blazorise\" Demo</a>\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.Sidebar.SidebarNavigation>(11);
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(13, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.Sidebar.SidebarLabel>(14);
                        __builder4.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(16, "Main");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(17, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.Sidebar.SidebarItem>(18);
                        __builder4.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(20, "\r\n                ");
                            __builder5.OpenComponent<Blazorise.Sidebar.SidebarLink>(21);
                            __builder5.AddAttribute(22, "Toggled", new System.Action<System.Boolean>(
#nullable restore
#line 9 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Shared\NavMenu.razor"
                                      (isOpen)=> sidebarSubItemTests.Toggle(isOpen)

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(23, "IsShow", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Shared\NavMenu.razor"
                                                                                             true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(25, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.Icon>(26);
                                __builder6.AddAttribute(27, "Name", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Shared\NavMenu.razor"
                                IconName.Edit

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(28, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentSpacing>(
#nullable restore
#line 10 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Shared\NavMenu.razor"
                                                       Margin.Is3.FromRight

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(29, "Pages\r\n                ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(30, "\r\n                ");
                            __builder5.OpenComponent<Blazorise.Sidebar.SidebarSubItem>(31);
                            __builder5.AddAttribute(32, "IsShow", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Shared\NavMenu.razor"
                                                                   true

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(34, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.Sidebar.SidebarItem>(35);
                                __builder6.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(37, "\r\n                        ");
                                    __builder7.OpenComponent<Blazorise.Sidebar.SidebarLink>(38);
                                    __builder7.AddAttribute(39, "To", "produits");
                                    __builder7.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddContent(41, "Sets");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(42, "\r\n                    ");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(43, "\r\n                ");
                            }
                            ));
                            __builder5.AddComponentReferenceCapture(44, (__value) => {
#nullable restore
#line 12 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Shared\NavMenu.razor"
                                      sidebarSubItemTests = (Blazorise.Sidebar.SidebarSubItem)__value;

#line default
#line hidden
#nullable disable
                            }
                            );
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(45, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(46, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n");
            }
            ));
            __builder.AddComponentReferenceCapture(49, (__value) => {
#nullable restore
#line 1 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Shared\NavMenu.razor"
               sidebar = (Blazorise.Sidebar.Sidebar)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Shared\NavMenu.razor"
       

    Sidebar sidebar;
    SidebarSubItem sidebarSubItemTests;
    SidebarSubItem sidebarSubItemApps;

    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
