using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_UI.Database.Domain
{
    public class Cars
    {
        public int Id { get; set; }

        public int ProductionYear { get; set; }

        public string Body { get; set; }

        public Decimal Price { get; set; }

        public Decimal EngineCapacity { get; set; }

        public Models Model { get; set; }

        public CarShowrooms CarShowroom { get; set; }
    }
}
