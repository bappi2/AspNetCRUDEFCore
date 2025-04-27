using AspNetCRUDEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCRUDEFCore.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext (options)
{
    public DbSet<Employee> Employees { get; set; }


}