using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data_Access_using_Entity_Framework.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
    }
}