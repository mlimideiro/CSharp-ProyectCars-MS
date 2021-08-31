using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ProjectCars
{
    public class Car
    {
        public string id { get; set; }
        public string model { get; set; }
        public int doorsQuantity { get; set; }
        public string color { get; set; }
        public bool gearBox { get; set; }

    }
}
