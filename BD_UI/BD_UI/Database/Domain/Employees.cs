using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_UI.Database.Domain
{
    public class Employees
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public CarShowrooms CarShowroom { get; set; }

        public Jobs Job { get; set; }

        public List<Orders> Orders { get; set; }
    }
}
