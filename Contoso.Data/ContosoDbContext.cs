using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Contoso.Model.Model;

namespace Contoso.Data
{
    public class ContosoDbContext : DbContext
    {
        public ContosoDbContext() : base("name = ContosoDbContext")
        {

        }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<Departments> Departments{ get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Instructor> Instructor { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<OfficeAssignments> OfficeAssignments { get; set; }
        public virtual DbSet<PersonRoles> PersonRoles { get; set; }
        public virtual DbSet<InstructorCourses> InstructorCourses { get; set; }







    }
}
