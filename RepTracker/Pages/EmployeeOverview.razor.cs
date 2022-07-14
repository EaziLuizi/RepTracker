using Microsoft.AspNetCore.Components;
using RepTracker.Components;
using RepTracker.Services;
using RepTracker.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepTracker.Pages
{
    public partial class EmployeeOverview
    {

        public IEnumerable<Employee> Employees { get; set; }

        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Employees = await EmployeeDataService.GetAllEmployees();
        }

        protected AddEmployeeDialog AddEmployeeDialog { get;set;}

        protected void QuickAddEmployee()
        {
            AddEmployeeDialog.Show();
        }

        public async void AddEmployeeDialog_OnDialogClose()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
            StateHasChanged();
        }

    }
}
