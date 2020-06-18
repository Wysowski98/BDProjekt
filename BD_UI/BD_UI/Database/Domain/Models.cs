using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_UI.Database.Domain
{
    public class Models
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public CarBrands Brand { get; set; }
    }
}
