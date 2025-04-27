using AspNetCRUDEFCore.Data;
using AspNetCRUDEFCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCRUDEFCore.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private readonly AppDbContext context;

    public EmployeesController(AppDbContext dbContext)
    {
        context = dbContext;
    }

    [HttpGet]
    public IActionResult GetAllEmployees()
    {
        var employees = context.Employees.ToList();
        return Ok(employees);
    }
    
    [HttpPost]
    public IActionResult CreateEmployee([FromBody] CreateEmployeeDto employeeDto)
    {
        var employee = new Employee
        {
            Name = employeeDto.Name,
            Email = employeeDto.Email,
            Phone = employeeDto.Phone,
            Salary = employeeDto.Salary
        };

        context.Employees.Add(employee);
        context.SaveChanges();

        return Ok(employee);
    }
}