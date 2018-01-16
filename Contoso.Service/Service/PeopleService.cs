using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data.Repository;
using Contoso.Model.Model;

namespace Contoso.Service
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository _personRepository;
        public PeopleService(IPeopleRepository personRepository)
        {
            _personRepository = personRepository;

        }

        public void AddPerson(People people)
        {
            _personRepository.Add(people);
            _personRepository.SaveChanges();
        }

        public IEnumerable<People> GetAllPeople()
        {
            return _personRepository.GetAll();
        }

        public People GetPersonById(int id)
        {
            return _personRepository.GetById(id);
        }
    }

    public interface IPeopleService
    {
        IEnumerable<People> GetAllPeople();
        People GetPersonById(int id);
        void AddPerson(People people);

    }

}
