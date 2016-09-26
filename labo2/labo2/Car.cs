using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo2
{
    class Car
    {
        private string Plaque { get; set; }

        public Car(string plaque)
        {
            Plaque = plaque;
        }

        public override string ToString()
        {
            return Plaque + "\n";
        }
    }
}
