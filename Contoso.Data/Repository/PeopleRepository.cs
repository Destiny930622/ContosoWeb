﻿using Contoso.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data.Repository
{
    public class PeopleRepository : Repository<People>, IPeopleRepository
    {
        public PeopleRepository(ContosoDbContext context) : base(context)
        {
        }

        public People GetByLastName(string lastname)
        {
            var person = _context.People.Where(p => p.LastName == lastname).FirstOrDefault();
            return person;

        }
    }

    public interface IPeopleRepository : IRepository<People>
    {
        People GetByLastName(String name);

    }
}
