using Contoso.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(ContosoDbContext context) : base(context)
        {

        }


        public Student GetStudentByLastName(string Lastname)
        {
            var student = _context.People.OfType<Student>().FirstOrDefault(s => s.LastName == Lastname);
            return student;

        }
    }

    public interface IStudentRepository : IRepository<Student>
    {
        Student GetStudentByLastName(String Lastname);

    }
}
