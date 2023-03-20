using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EMS.Models
{
    public class Employee
    {
        [DisplayName("Employee ID")]
        public int EmployeeId { get; set; }
        
        [DisplayName("Employee Name")]
        [MinLength(2, ErrorMessage = 
            "The employee name is too short atleast input two characters!")]
        public string EmployeeName { get; set; }

        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DOB { get; set; }

        
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", 
            ErrorMessage = "Must be a valid email")]
        public string Email { get; set; }

        [Range(0, Int64.MaxValue, ErrorMessage = "Contact number should not contain characters")]
        [StringLength(20, MinimumLength = 11, ErrorMessage = "Contact number should have minimum 11 digits")]
        public string Phone { get; set; }

        [DisplayName("Department")]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public Employee() { }

        public Employee(int employeeId, string employeeName, DateTime dOB, string email, string phone, int departmentId, Department? department)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            DOB = dOB;
            Email = email;
            Phone = phone;
            DepartmentId = departmentId;
            Department = department;
        }
    }
}
