using Contoso.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data.Repository
{
    public class DepartmentRepository : Repository<Departments>, IDepartmentRepository
    {
        public DepartmentRepository(ContosoDbContext context) : base(context)
        {
        }

        public Departments GetByLastName(string name)
        {
            throw new NotImplementedException();
        }
    }

    public interface IDepartmentRepository : IRepository<Departments>
    {
        Departments GetByLastName(String name);

    }
}
