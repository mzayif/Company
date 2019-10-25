using System;
using System.Collections.Generic;
using System.Text;

namespace Company.DataModel
{
    public class Personnel : BaseDBModel
    {
        public string Name { get; set; }
        public string Surename { get; set; }
        public DateTime BirtDay { get; set; }
        public string PhoneNumber { get; set; }
    }
}
