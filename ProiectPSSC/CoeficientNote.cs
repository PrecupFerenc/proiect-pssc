using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace ProiectPSSC
{
    class CoeficientNote
    {
        private int _numarator;
        private int _numitor;
        
        public decimal Fractie { get { return (decimal)_numarator/(decimal)_numitor; } }

        internal CoeficientNote(int numarator, int numitor)
        {
           if (( numarator > 0 ) && (numitor > 0) && (numarator > numitor))
           {
               Contract.Requires<ArgumentException>(numarator > 0, "numarator");
               Contract.Requires<ArgumentException>(numitor > 0, "numitor");
               Contract.Requires<ArgumentException>(numitor > numarator, "nu este subunitar");

               _numitor = numitor;
               _numarator = numarator;
           }

        }
    }
}
