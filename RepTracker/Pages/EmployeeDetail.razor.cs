using RepTracker.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RepTracker.Services;
using RepTracker.Library.Map;

namespace RepTracker.Pages
{
    public partial class EmployeeDetail
    {
        [Parameter]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }
        public List<Marker> MapMarkers { get; set; } = new List<Marker>();

        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));;

            MapMarkers = new List<Marker>
            {
                new Marker{Description = $"{Employee.FirstName} {Employee.LastName}", ShowPopup = false, X = Employee.Longitude, Y = Employee.Latitude} 
            };
        }
    }
}
