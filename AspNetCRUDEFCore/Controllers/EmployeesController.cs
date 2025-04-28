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
    [HttpGet("{id}")]
    public IActionResult GetEmployee(Guid id)
    {
        var employee = context.Employees.FirstOrDefault(e => e.Id == id);
        if (employee == null)
        {
            return NotFound();
        }
        return Ok(employee);
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
    [HttpPut("{id}")]
    public IActionResult UpdateEmployee(Guid id, [FromBody] CreateEmployeeDto employeeDto)
    {
        var employee = context.Employees.FirstOrDefault(e => e.Id == id);
        if (employee == null)
        {
            return NotFound();
        }

        employee.Name = employeeDto.Name;
        employee.Email = employeeDto.Email;
        employee.Phone = employeeDto.Phone;
        employee.Salary = employeeDto.Salary;

        context.SaveChanges();

        return Ok(employee);
    }
    [HttpDelete("{id}")]
    public IActionResult DeleteEmployee(Guid id)
    {
        var employee = context.Employees.FirstOrDefault(e => e.Id == id);
        if (employee == null)
        {
            return NotFound();
        }

        context.Employees.Remove(employee);
        context.SaveChanges();

        return NoContent();
    }
}