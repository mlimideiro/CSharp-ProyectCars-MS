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
        public string Id { get; set; }
        public string Model { get; set; }
        public int DoorsQuantity { get; set; }
        public string Color { get; set; }
        public bool IsManualTransmition { get; set; }

    }
}
