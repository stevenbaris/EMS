using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EMS.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [DisplayName("Department Name")]
        [MinLength(2, ErrorMessage =
            "The department name is too short atleast input two characters!")]
        public string DepartmentName { get; set; }
        public ICollection<Employee>? Employees { get; set; }

        public Department()
        {

        }

        public Department(int departmentId, string departmentName)
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
        }
    }
}
