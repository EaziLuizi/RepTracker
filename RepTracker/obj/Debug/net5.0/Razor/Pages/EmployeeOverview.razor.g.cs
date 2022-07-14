#pragma checksum "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3571acea9eb0f3f27d7410860655b1edc1656a8"
// <auto-generated/>
#pragma warning disable 1591
namespace RepTracker.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Dev2022\RepTracker\RepTracker\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev2022\RepTracker\RepTracker\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dev2022\RepTracker\RepTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Dev2022\RepTracker\RepTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Dev2022\RepTracker\RepTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Dev2022\RepTracker\RepTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Dev2022\RepTracker\RepTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Dev2022\RepTracker\RepTracker\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Dev2022\RepTracker\RepTracker\_Imports.razor"
using RepTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Dev2022\RepTracker\RepTracker\_Imports.razor"
using RepTracker.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Dev2022\RepTracker\RepTracker\_Imports.razor"
using RepTracker.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Dev2022\RepTracker\RepTracker\_Imports.razor"
using RepTracker.Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Dev2022\RepTracker\RepTracker\_Imports.razor"
using RepTracker.Library.Map;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeoverview")]
    public partial class EmployeeOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"page-title\">All employees</h1>");
#nullable restore
#line 5 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeOverview.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 8 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeOverview.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th></th>\r\n                <th>Employee ID</th>\r\n                <th>First name</th>\r\n                <th>Last name</th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 22 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeOverview.razor"
             foreach (var employee in Employees)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 25 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeOverview.razor"
                                   employee.ImageName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "class", "rounded-circle profile-picture-small");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
#nullable restore
#line 26 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeOverview.razor"
__builder.AddContent(13, employee.EmployeeId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
#nullable restore
#line 27 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeOverview.razor"
__builder.AddContent(16, employee.FirstName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
#nullable restore
#line 28 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeOverview.razor"
__builder.AddContent(19, employee.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "href", 
#nullable restore
#line 30 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeOverview.razor"
                                   $"employeedetail/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "class", "btn btn-primary table-btn");
            __builder.AddMarkupContent(25, "<i class=\"fas fa-info-circle\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", 
#nullable restore
#line 33 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeOverview.razor"
                                   $"employeeedit/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "class", "btn btn-primary table-btn");
            __builder.AddMarkupContent(30, "<i class=\"fas fa-edit\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeOverview.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeOverview.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "class", "btn btn-primary");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeOverview.razor"
                                          QuickAddEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "\r\n    Add Employee\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.OpenComponent<RepTracker.Components.AddEmployeeDialog>(36);
            __builder.AddAttribute(37, "CloseEventCallback", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 45 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeOverview.razor"
                                                                 AddEmployeeDialog_OnDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(38, (__value) => {
#nullable restore
#line 45 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeOverview.razor"
                         AddEmployeeDialog = (RepTracker.Components.AddEmployeeDialog)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
