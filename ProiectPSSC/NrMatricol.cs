using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace ProiectPSSC
{
    class NrMatricol  
    {
        private string _numar;
        public string Numar { get { return _numar; } }

        public NrMatricol(string numar)
        {
            Contract.Requires<ArgumentNullException>(numar != null, "text");
            Contract.Requires<ArgumentCannotBeEmptyStringException>(!string.IsNullOrEmpty(numar), "text");
            Contract.Requires<ArgumentException>(numar.Length==7, "Numarul matricol are exact 7 caractere.");
            _numar = numar;
        }
    }
}
