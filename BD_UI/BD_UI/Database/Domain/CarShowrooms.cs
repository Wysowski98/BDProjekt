using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_UI.Database.Domain
{
    public class CarShowrooms
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }

        public List<Employees> Employees { get; set; }

        public List<Cars> Cars { get; set; }
    }
}
