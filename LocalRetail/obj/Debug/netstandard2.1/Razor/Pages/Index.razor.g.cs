#pragma checksum "C:\Users\ankur\source\repos\LocalRetail\LocalRetail\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ab66d44d51328875ca5d385fcb5fdeab0b2e06e"
// <auto-generated/>
#pragma warning disable 1591
namespace LocalRetail.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ankur\source\repos\LocalRetail\LocalRetail\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ankur\source\repos\LocalRetail\LocalRetail\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ankur\source\repos\LocalRetail\LocalRetail\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ankur\source\repos\LocalRetail\LocalRetail\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ankur\source\repos\LocalRetail\LocalRetail\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ankur\source\repos\LocalRetail\LocalRetail\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ankur\source\repos\LocalRetail\LocalRetail\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ankur\source\repos\LocalRetail\LocalRetail\_Imports.razor"
using LocalRetail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ankur\source\repos\LocalRetail\LocalRetail\_Imports.razor"
using LocalRetail.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Local Retail!</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\ankur\source\repos\LocalRetail\LocalRetail\Pages\Index.razor"
                  st

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\ankur\source\repos\LocalRetail\LocalRetail\Pages\Index.razor"
                                      HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(6);
                __builder2.AddAttribute(7, "id", "name");
                __builder2.AddAttribute(8, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "C:\Users\ankur\source\repos\LocalRetail\LocalRetail\Pages\Index.razor"
                                      st.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => st.Name = __value, st.Name))));
                __builder2.AddAttribute(10, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => st.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.AddMarkupContent(12, "<button type=\"submit\">Submit</button>\r\n    ");
                __builder2.OpenElement(13, "p");
                __builder2.AddContent(14, "Current count: ");
                __builder2.AddContent(15, 
#nullable restore
#line 8 "C:\Users\ankur\source\repos\LocalRetail\LocalRetail\Pages\Index.razor"
                       st.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\ankur\source\repos\LocalRetail\LocalRetail\Pages\Index.razor"
       
    private Student st = new Student();

    private void HandleValidSubmit()
    {

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
