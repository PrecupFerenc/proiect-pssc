using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;

namespace ProiectPSSC
{
    class Materie
    {
        public PlainText NumeMaterie { get; internal set; }
        public CoeficientNote PondereExamen { get; internal set; }

        private List<Student> _studentiInscrisi;
        public ReadOnlyCollection<Student> StudentiInscrisi { get { return _studentiInscrisi.AsReadOnly(); } }
        
        internal Materie(PlainText nume, CoeficientNote pondereExamen)  // pt profesor
        {
            Contract.Requires(nume != null, "nume");
            Contract.Requires(pondereExamen != null, "pondereExamen");

            NumeMaterie = nume;
            PondereExamen = pondereExamen;
            _studentiInscrisi = new List<Student>();
        }

        internal Materie(PlainText nume, CoeficientNote pondereExamen, List<Student> studentiInscrisi) // pt Secretariat
            :this(nume, pondereExamen)
        {
            Contract.Requires(studentiInscrisi != null, "lista de studenti inscrisi");
            _studentiInscrisi = studentiInscrisi;
        }
    }
}
