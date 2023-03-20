using EMS.Models;

namespace EMS.Repository
{
    public class IEMSRepository
    {
        public interface IEMSRepositoryFactory
        {
            List<Employee> GetAllEmployees();

            //Get any specific employee
            Employee GetEmployeeId(int Id);

            //Add employee into the list
            Employee AddEmployee(Employee newEmployee);

            //Update employee in the list
            Employee UpdateEmployee(int employeeId, Employee newEmployee);

            // delete 
            Employee DeleteEmployee(int employeeId);

        }
    }
}
