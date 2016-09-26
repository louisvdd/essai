using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo2
{
    class Entreprise
    {
        private string EntrName { get; set; }
        private string Localite { get; set; }

        public Entreprise(string entrName, string localite)
        {
            EntrName = entrName;
            Localite = localite;
        }

        public override string ToString()
        {
            return " ";
        }
    }
}
