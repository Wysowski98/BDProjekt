using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_UI.Database.Domain
{
    public class Accounts
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public Employees Employee { get; set; }
    }
}
