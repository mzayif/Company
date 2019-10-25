using System;
using System.Collections.Generic;
using System.Text;

namespace Company.DataModel
{
    public class User : BaseDBModel
    {
        public string UserName { get; set; }
        public string Pasword { get; set; }
        public Personnel Personnel { get; set; }
    }
}
