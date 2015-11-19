using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace ProiectPSSC
{
    class Nota
    {
        private decimal _valoareNota;
        public decimal Valoare { get { return _valoareNota; } }

        public Nota(decimal valoare)
        {
            Contract.Requires<ArgumentException>(valoare > 0, "valoare");
            Contract.Requires<ArgumentException>(valoare <= 10, "valoare");

            _valoareNota = valoare;
        }
    }
}
