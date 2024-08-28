using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3___Mekanikerværksted
{
    public class Firma(Adresse adresse) : IHarAdresse
    {
        public Adresse Adresse { get => adresse; set => adresse = value; }

        public override string ToString()
        {
            return String.Format("Firma {0}", Adresse);
        }
    }
}
