using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPSSC
{
    class NrMatricol  
    {
        private string _numar;
        public string Numar { get { return _numar; } }

        public NrMatricol(string numar)
        {
            if (numar.Length == 7)
            {
                _numar = numar;
            }
            else
            {
                Console.Write("Numar matricol gresit");//throw new System.IncorectNumberFormatException();
           }
        }
    }
}
