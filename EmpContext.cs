using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Demo_WebAPI_MVC_CORE.Models;

namespace Demo_WebAPI_MVC_CORE
{
    public class EmpContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Neeraj.Boga\source\repos\DemoWebApplication1\App_Data\MyDatabase1.mdf;Integrated Security=True");
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
