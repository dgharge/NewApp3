using Microsoft.EntityFrameworkCore;
using NewApp.API.Models;
namespace NewApp.API.Models
{
    public class DataContext:DbContext
    {
public DataContext(DbContextOptions<DataContext>options):base(options){}
public DbSet<Value> Values {get; set;}
public DbSet<User> Users {get; set;}
    }
}