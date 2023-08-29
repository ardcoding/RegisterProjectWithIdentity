using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ProjectDb.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

public class ProjectDbContext : IdentityDbContext
{
    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Database=ProjectDb;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;");
    }
}

class Start
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}