using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace ProiectPSSC
{
    class Student
    {
        public NrMatricol nrMatricol { get; internal set; }
        public PlainText numeStudent { get; internal set; }
        public Note noteParcurs { get; internal set; }
        public Nota notaExamen { get; internal set; }
        public Nota Medie_Materie { get; internal set; }


        internal Student(NrMatricol numarMatricol, PlainText nume)
        {
            Contract.Requires(nrMatricol != null, "numar matricol");
            Contract.Requires(nume != null, "nume");
            nrMatricol = numarMatricol;
            numeStudent = nume;
            noteParcurs = new Note();
        }

        internal void CalculeazaNotaFinala(CoeficientNote coeficient)
        {
            Contract.Requires(coeficient != null, "coeficient");
            Contract.Requires(notaExamen != null, "nota la examen");
            Contract.Requires(noteParcurs.Media.Valoare>=5, "nota activitate");
            Contract.Requires(notaExamen.Valoare>= 5, "nota examen");

            var valCoeficient = coeficient.Fractie;
            Medie_Materie = new Nota(Math.Round(valCoeficient * notaExamen.Valoare + (1 - valCoeficient) * noteParcurs.Media.Valoare));
        }
        
    }
}
