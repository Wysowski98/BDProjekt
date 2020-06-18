using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_UI.Database.Domain
{
    public class CarBrands
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Models> Models { get; set; }
    }
}
