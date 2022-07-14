using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using RepTracker.Services;
using RepTracker.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RepTracker.Pages
{
    public partial class EmployeeEdit
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        [Inject]
        public ICountryDataService CountryDataService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();

        public List<Country> Countries { get; set; } = new List<Country>();


        protected string CountryId = string.Empty;

        //used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;

        protected async override Task OnInitializedAsync()
        {
            Saved = false;
            Countries = (await CountryDataService.GetAllCountries()).ToList();

            int.TryParse(EmployeeId, out var employeeId);

            if (employeeId == 0) //new employee is being created
            {
                //add some defaults
                Employee = new Employee { CountryId = 1, BirthDate = DateTime.Now, StartDate = DateTime.Now };
            }
            else
            {
                Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
            }

            CountryId = Employee.CountryId.ToString();
        }

        private IReadOnlyList<IBrowserFile> selectedFiles;
        private void OnInputFileChange(InputFileChangeEventArgs e)
        {
            selectedFiles = e.GetMultipleFiles();
            Message = $"{selectedFiles.Count} file(s) selected";
            StateHasChanged();
        }

        protected async Task HandleValidSubmit()
        {
            Saved = false;
            Employee.CountryId = int.Parse(CountryId);

            if (Employee.EmployeeId == 0) //new
            {
                if (selectedFiles != null)//take first image
                {
                    var file = selectedFiles[0];
                    Stream stream = file.OpenReadStream();
                    MemoryStream ms = new MemoryStream();
                    await stream.CopyToAsync(ms);
                    stream.Close();

                    Employee.ImageName = file.Name;
                    Employee.ImageContent = ms.ToArray();
                }
                var addedEmployee = await EmployeeDataService.AddEmployee(Employee);
                if (addedEmployee != null)
                {
                    StatusClass = "alert-success";
                    Message = "New employee added successfully.";
                    Saved = true;
                }
                else
                {
                    StatusClass = "alert-danger";
                    Message = "Something went wrong adding the new employee. Please try again.";
                    Saved = false;
                }
            }
            else
            {
                await EmployeeDataService.UpdateEmployee(Employee);
                StatusClass = "alert-success";
                Message = "Employee updated successfully.";
                Saved = true;
            }
        }

        protected void HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "There are some validation errors. Please try again.";
        }

        protected async Task DeleteEmployee()
        {
            await EmployeeDataService.DeleteEmployee(Employee.EmployeeId);

            StatusClass = "alert-success";
            Message = "Deleted successfully";

            Saved = true;
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/employeeoverview");
        }


    }
}
