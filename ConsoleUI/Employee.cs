using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Employee
    {
        public string EmpId { get; set; }
        public string? Mode { get; set;}
        public string? In0rOut { get; set;}
        public bool Antipass { get; set;}
        public bool ProxyWork { get; set;}
        public DateTime DateTime { get; set;}
    }
}
