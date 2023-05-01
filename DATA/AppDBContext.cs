using DATA.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class AppDBContext : DbContext
    {
        public DbSet<ApplicationForm>  ApplicationForms { get; set; }
        public DbSet<ProgramDetails> ProgramDetails { get; set; }
        public AppDBContext(DbContextOptions<AppDBContext> dbContextOptions): base(dbContextOptions){}


    }
}
