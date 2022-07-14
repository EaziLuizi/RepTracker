#pragma checksum "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "782a3643e5939aa0604276d030dbd1d0063c6289"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetail/{EmployeeId}")]
    public partial class EmployeeDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "employee-detail");
            __builder.OpenElement(2, "h1");
            __builder.AddAttribute(3, "class", "page-title");
            __builder.AddContent(4, "Details for ");
#nullable restore
#line 4 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeDetail.razor"
__builder.AddContent(5, Employee.FirstName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, " ");
#nullable restore
#line 4 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeDetail.razor"
__builder.AddContent(7, Employee.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-12 row");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-2");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 7 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeDetail.razor"
                        $"https://gillcleerenpluralsight.blob.core.windows.net/person/{Employee.EmployeeId}.jpg"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "class", "img-responsive rounded-circle employee-detail-img");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-10 row");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-xs-12 col-sm-8");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group row");
            __builder.AddMarkupContent(23, "<label class=\"col-sm-4 col-form-label\">Employee ID</label>\r\n                    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-sm-8");
            __builder.OpenElement(26, "label");
            __builder.AddAttribute(27, "type", "text");
            __builder.AddAttribute(28, "class", "form-control-plaintext");
#nullable restore
#line 14 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeDetail.razor"
__builder.AddContent(29, Employee.EmployeeId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group row");
            __builder.AddMarkupContent(33, "<label class=\"col-sm-4 col-form-label\">First name</label>\r\n                    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-sm-8");
            __builder.OpenElement(36, "label");
            __builder.AddAttribute(37, "type", "text");
            __builder.AddAttribute(38, "readonly");
            __builder.AddAttribute(39, "class", "form-control-plaintext");
#nullable restore
#line 20 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeDetail.razor"
__builder.AddContent(40, Employee.FirstName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n                ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group row");
            __builder.AddMarkupContent(44, "<label class=\"col-sm-4 col-form-label\">Last name</label>\r\n                    ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-sm-8");
            __builder.OpenElement(47, "label");
            __builder.AddAttribute(48, "type", "text");
            __builder.AddAttribute(49, "readonly");
            __builder.AddAttribute(50, "class", "form-control-plaintext");
#nullable restore
#line 27 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeDetail.razor"
__builder.AddContent(51, Employee.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n                ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "form-group row");
            __builder.AddMarkupContent(55, "<label class=\"col-sm-4 col-form-label\">Birthdate</label>\r\n                    ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "col-sm-8");
            __builder.OpenElement(58, "label");
            __builder.AddAttribute(59, "type", "text");
            __builder.AddAttribute(60, "readonly");
            __builder.AddAttribute(61, "class", "form-control-plaintext");
#nullable restore
#line 34 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeDetail.razor"
__builder.AddContent(62, Employee.BirthDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n\r\n                ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "form-group row");
            __builder.AddMarkupContent(66, "<label class=\"col-sm-4 col-form-label\">Email</label>\r\n                    ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "col-sm-8");
            __builder.OpenElement(69, "label");
            __builder.AddAttribute(70, "type", "text");
            __builder.AddAttribute(71, "readonly");
            __builder.AddAttribute(72, "class", "form-control-plaintext");
#nullable restore
#line 41 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeDetail.razor"
__builder.AddContent(73, Employee.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n\r\n                ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "form-group row");
            __builder.AddMarkupContent(77, "<label class=\"col-sm-4 col-form-label\">Phone number</label>\r\n                    ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "col-sm-8");
            __builder.OpenElement(80, "label");
            __builder.AddAttribute(81, "type", "text");
            __builder.AddAttribute(82, "readonly");
            __builder.AddAttribute(83, "class", "form-control-plaintext");
#nullable restore
#line 48 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeDetail.razor"
__builder.AddContent(84, Employee.PhoneNumber);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n\r\n                ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "form-group row");
            __builder.AddMarkupContent(88, "<label class=\"col-sm-4 col-form-label\">Gender</label>\r\n                    ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "col-sm-8");
            __builder.OpenElement(91, "label");
            __builder.AddAttribute(92, "type", "text");
            __builder.AddAttribute(93, "readonly");
            __builder.AddAttribute(94, "class", "form-control-plaintext");
#nullable restore
#line 55 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeDetail.razor"
__builder.AddContent(95, Employee.Gender);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n\r\n                ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "form-group row");
            __builder.AddMarkupContent(99, "<label class=\"col-sm-4 col-form-label\">Joined us</label>\r\n                    ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "col-sm-8");
            __builder.OpenElement(102, "label");
            __builder.AddAttribute(103, "type", "text");
            __builder.AddAttribute(104, "readonly");
            __builder.AddAttribute(105, "class", "form-control-plaintext");
#nullable restore
#line 62 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeDetail.razor"
__builder.AddContent(106, Employee.StartDate?.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n\r\n                ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "form-group row");
            __builder.AddMarkupContent(110, "<label class=\"col-sm-4 col-form-label\">Left us</label>\r\n                    ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "col-sm-8");
            __builder.OpenElement(113, "label");
            __builder.AddAttribute(114, "type", "text");
            __builder.AddAttribute(115, "readonly");
            __builder.AddAttribute(116, "class", "form-control-plaintext");
#nullable restore
#line 69 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeDetail.razor"
__builder.AddContent(117, Employee.EndDate?.ToShortDateString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n            ");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "col-xs-12 col-sm-8");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "class", "track-order-map");
            __builder.OpenComponent<RepTracker.Library.Map.Map>(123);
            __builder.AddAttribute(124, "Zoom", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 75 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeDetail.razor"
                               10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(125, "Markers", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<RepTracker.Library.Map.Marker>>(
#nullable restore
#line 75 "C:\Dev2022\RepTracker\RepTracker\Pages\EmployeeDetail.razor"
                                            MapMarkers

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591