using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPSSC
{
    class Nota
    {
        private decimal _valoareNota;
        public decimal Valoare { get { return _valoareNota; } }

        public Nota(decimal valoare)
        {
            _valoareNota = valoare;
        }
    }
}
