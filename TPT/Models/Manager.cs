using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPT.Models
{
    //[Table("Managers")]
    public class Manager: User
    {
        public string? Departament { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, Departament: {Departament}";
        }
    }
}
