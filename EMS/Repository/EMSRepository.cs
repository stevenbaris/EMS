using EMS.Data;
using EMS.Models;
using Microsoft.EntityFrameworkCore;

namespace EMS.Repository
{
    public class EMSRepository : IEMSRepository
    {
        private EMSDbContext _context;

        public EMSRepository(EMSDbContext context)
        {
            this._context = context;
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }
        public Employee GetEmployeeById(int id)
        {
            return _context.Employees.Find(id);
        }
        public void InsertEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
        }
        public void DeleteEmployee(int employeeId) 
        {
            Employee employee = _context.Employees.Find(employeeId);
            _context.Employees.Remove(employee);
        }
        public void UpdateEmployee(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
