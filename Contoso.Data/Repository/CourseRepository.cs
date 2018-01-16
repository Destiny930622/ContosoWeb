using Contoso.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data.Repository
{

    public class CourseRepository : Repository<Courses>, ICourseRepository
    {
        public CourseRepository(ContosoDbContext context) : base(context)
        {

        }

        public Courses GetByLastName(string name)
        {
            throw new NotImplementedException();
        }
    }

    public interface ICourseRepository : IRepository<Courses>
    {
        Courses GetByLastName(String name);

    }
}
