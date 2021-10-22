using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeMangSystem.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Desgination { get; set; }

        public string Salary { get; set; }
    }
 
}