using System;
using System.Collections.Generic;
using System.Text;

namespace Company.DataModel
{
    public class BaseDBModel : BaseDB
    {
        public DateTime CreateDate { get; set; }
        //public User CreateUser { get; set; }
        public DateTime CancelDate { get; set; }
        //public User CancelUser { get; set; }

        public BaseDBModel()
        {
            CreateDate = DateTime.Now;
        }
    }
}
