using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        //this's a constructor 
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        //that's a table in our Data base named Users, 
        //with columns Id and UserName 
        //(check "go to definition" for info)
        public DbSet<AppUser> Users { get; set; }
    }
}