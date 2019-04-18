using System;
using System.Collections.Generic;

namespace EmployeApp.Models
{
    public partial class Departments
    {
        public Departments()
        {
            Employes = new HashSet<Employes>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Employes> Employes { get; set; }
    }
}
