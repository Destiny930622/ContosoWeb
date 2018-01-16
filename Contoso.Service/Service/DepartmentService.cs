using Contoso.Data.Repository;
using Contoso.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Service.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public void AddDepartment(Departments department)
        {
            _departmentRepository.Add(department);
        }

        public IEnumerable<Departments> GetAllDepartments()
        {
            return _departmentRepository.GetAll();
        }

        public Departments GetDepartmentById(int id)
        {
            return _departmentRepository.GetById(id);
        }

        public void UpdateDepartment(Departments department)
        {
            _departmentRepository.Update(department);
        }
    }


    public interface IDepartmentService
    {

        Departments GetDepartmentById(int id);
        IEnumerable<Departments> GetAllDepartments();
        void AddDepartment(Departments department);
        void UpdateDepartment(Departments department);

    }
}
