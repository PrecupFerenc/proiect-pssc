using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPSSC
{
    class Student
    {
        public NrMatricol nrMatricol { get; internal set; }
        public PlainText numeStudent { get; internal set; }
        public Note noteParcurs { get; internal set; }
        public Nota notaExamen { get; internal set; }

        internal Student(NrMatricol numarMatricol, PlainText nume)
        {            
            nrMatricol = numarMatricol;
            numeStudent = nume;
            noteParcurs = new Note();
        }
    }
}
