using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string RegNo { get; set; }

        public Car()
        {

        }
        public Car(string model, string color, string regno)
        {
            Model = model;
            Color = color;
            RegNo = regno;
        }

        public override string ToString()
        {
            return $"{nameof(Model)}: {Model}, {nameof(Color)}: {Color}, {nameof(RegNo)}: {RegNo}";
        }
    }
}
