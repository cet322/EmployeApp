using System;
using System.Collections.Generic;

namespace EmployeApp.Models
{
    public partial class Employes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public int DepartmentId { get; set; }

        public virtual Departments Department { get; set; }
    }
}
