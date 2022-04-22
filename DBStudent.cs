using Microsoft.EntityFrameworkCore;
using Sample_Web_Api.Modal;
using System.Collections.Generic;

namespace Sample_Web_Api.DB
{
    public class DBStudent:DbContext
    {
        public DBStudent(DbContextOptions options) : base(options) { }

        public DbSet<Student> students { get; set; }
        //public IEnumerable<Student> Student { get; internal set; }
    }
    
}
