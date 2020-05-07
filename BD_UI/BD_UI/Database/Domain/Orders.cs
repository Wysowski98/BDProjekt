using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_UI.Database.Domain
{
    public class Orders
    {
        public int Id { get; set; }

        public int Price { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime RealizationDate { get; set; }

        public string AdditionalServices { get; set; }

        public Employees Employee { get; set; }

        public Clients Client { get; set; }

        public Cars Car { get; set; }

    }
}
