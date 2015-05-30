using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    public class Accounts
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int AccountID { get; set; }
        public string Website { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

    }
}
