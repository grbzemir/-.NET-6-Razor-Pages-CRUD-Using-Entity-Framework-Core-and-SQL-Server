using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Models.Domain;
using RazorPagesApp.Models.ViewModels;
using RazorPagesDemoApp.Data;


namespace RazorPagesApp.Pages.Employees
{
    public class AddModel : PageModel
    {
        private readonly RazorPagesDemoDbContext dbContext;
        public AddModel(RazorPagesDemoDbContext dbContext)
        {

            this.dbContext = dbContext;
            
        }

        [BindProperty]
        public AddEmployeeViewModel AddEmployeeRequest { get; set; }
     
        public void OnGet()
        {
        }

        public void OnPost()
        {

            //Viewmodel to DomainModel
            var employeeDomainModel = new Employee

            {
                Name = AddEmployeeRequest.Name,
                Email = AddEmployeeRequest.Email,
                Salary = AddEmployeeRequest.Salary,
                DateOfBirth = AddEmployeeRequest.DateOfBirth,
                Department = AddEmployeeRequest.Department
               
            };

            dbContext.Employees.Add(employeeDomainModel);
            dbContext.SaveChanges();

            ViewData["Message"] = "Employee added successfully";
            
          }
        }
    }

