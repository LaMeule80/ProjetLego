#pragma checksum "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66d580817972b6ff4e7aa31a079d944146eb7bac"
// <auto-generated/>
#pragma warning disable 1591
namespace LegoBlazor.Pages
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
#nullable restore
#line 2 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
using LegoBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/produits")]
    public partial class Produits : ProduitsPagesV2
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Sets</h1>\r\n\r\n");
#nullable restore
#line 7 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
 if (Items == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 10 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenComponent<Blazorise.Row>(4);
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<Blazorise.DataGrid.DataGrid<Set>>(7);
                __builder2.AddAttribute(8, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Set>>(
#nullable restore
#line 15 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
                         Items

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Editable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 18 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 19 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
                            10

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "UseInternalEditing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 20 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
                                      true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "IsStriped", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "IsBordered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "IsHoverable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "SelectedRow", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Set>(
#nullable restore
#line 21 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
                                      selected

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "SelectedRowChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Set>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Set>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selected = __value, selected))));
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(20, "\r\n                ");
                    __builder3.OpenComponent<Blazorise.DataGrid.DataGridColumn<Set>>(21);
                    __builder3.AddAttribute(22, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
                                                    nameof(Set.SetNum)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "Caption", "Numéro");
                    __builder3.AddAttribute(24, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 26 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
                                                                                                   false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(25, "\r\n                ");
                    __builder3.OpenComponent<Blazorise.DataGrid.DataGridColumn<Set>>(26);
                    __builder3.AddAttribute(27, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
                                                    nameof(Set.Name)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "Caption", "Name");
                    __builder3.AddAttribute(29, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
                                                                                               false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(30, "\r\n                ");
                    __builder3.OpenComponent<Blazorise.DataGrid.DataGridColumn<Set>>(31);
                    __builder3.AddAttribute(32, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
                                                    nameof(Set.Year)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(33, "Caption", "Année");
                    __builder3.AddAttribute(34, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 28 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
                                                                                                false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(35, "\r\n                ");
                    __builder3.OpenComponent<Blazorise.DataGrid.DataGridColumn<Set>>(36);
                    __builder3.AddAttribute(37, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
                                                    nameof(Set.Theme)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "Caption", "Thème");
                    __builder3.AddAttribute(39, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
                                                                                                 false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(40, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.OpenComponent<Blazorise.Row>(43);
            __builder.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "width", "500px");
                __builder2.AddAttribute(48, "height", "150px");
                __builder2.AddMarkupContent(49, "\r\n            ");
                __builder2.OpenComponent<Blazorise.Card>(50);
                __builder2.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(52, "\r\n                ");
                    __builder3.OpenComponent<Blazorise.CardHeader>(53);
                    __builder3.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(55, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.CardTitle>(56);
                        __builder4.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(58, 
#nullable restore
#line 37 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
                                selected?.Name

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(59, "\r\n                    ");
                        __builder4.OpenComponent<Blazorise.CardSubtitle>(60);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(61, "\r\n                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(62, "\r\n                ");
                    __builder3.OpenComponent<Blazorise.CardImage>(63);
                    __builder3.AddAttribute(64, "Source", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 40 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
                                    selected?.SetImgUrl?.AbsoluteUri

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "Alt", "Placeholder image");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(66, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 44 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\_Temp\GIT\ProjetLego\LegoBlazor\LegoBlazor\Pages\Produits.razor"
       

    Set selected;


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
