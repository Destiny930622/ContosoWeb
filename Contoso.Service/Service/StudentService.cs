using Contoso.Data.Repository;
using Contoso.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IEnumerable<Student> GetAllStudent()
        {
            return _studentRepository.GetAll();
        }

        public Student GetStudentByLastName(string LastName)
        {
            return _studentRepository.GetStudentByLastName(LastName);
        }
        
    }


    public interface IStudentService
    {
       
        Student GetStudentByLastName(string LastName);
        IEnumerable<Student> GetAllStudent();
        

    }
}
