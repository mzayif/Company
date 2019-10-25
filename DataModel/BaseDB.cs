using System;
using System.Collections.Generic;
using System.Text;

namespace Company.DataModel
{
    public class BaseDB
    {
        public int id  { get; set; }
        public bool Active { get; set; }

        public BaseDB()
        {
            Active = true;
        }
    }
}
