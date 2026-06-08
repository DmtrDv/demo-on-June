using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_Lib
{
    public class Orders
    {
        public string article { get; set; }
        public string status { get; set; }
        public string adress { get; set; }
        public DateTime orderDate { get; set; }
        public DateTime deliveryDate { get; set; }  
    }
}
