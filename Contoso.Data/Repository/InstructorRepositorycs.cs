using Contoso.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data.Repository
{
    public class InstructorRepository : Repository<Instructor>, IInstructorRepository
    {
        public InstructorRepository(ContosoDbContext context) : base(context)
        {
        }

        public Instructor GetByLastName(string name)
        {
            throw new NotImplementedException();
        }
    }

    public interface IInstructorRepository : IRepository<Instructor>
    {
        Instructor GetByLastName(String name);

    }
}
