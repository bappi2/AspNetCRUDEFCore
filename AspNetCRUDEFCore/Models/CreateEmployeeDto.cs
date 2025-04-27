namespace AspNetCRUDEFCore.Models;

public class CreateEmployeeDto
{
    public required string Name { get; set; } 
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public decimal? Salary { get; set; }
}