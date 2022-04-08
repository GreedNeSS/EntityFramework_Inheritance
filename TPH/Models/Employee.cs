using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPH.Models
{
    public class Employee: User
    {
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, Salary: {Salary}";
        }
    }
}
