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

        public void InscrieStudent(Student student)
        {
            Contract.Requires(student != null, "student");
            
            var gasit = _studentiInscrisi.FirstOrDefault(s => s.Equals(student));
            if (gasit == null)
            {
                _studentiInscrisi.Add(student);
            }
            else
            {
                throw new StudentulExistaExceptions();
            }
        }

        public void AddNota(NrMatricol NrMatStud, Nota nota)
        {
            Contract.Requires(NrMatStud != null);
            Contract.Requires(nota != null);
           

            var student = _studentiInscrisi.First(s => s.nrMatricol.Equals(NrMatStud));
            student.noteParcurs.AdaugaNota(nota);
        }

        public void AddNoteExamen(Dictionary<NrMatricol, Nota> rezultateExamen)
        {
            Contract.Requires(rezultateExamen != null);
            
            foreach (var pair in rezultateExamen)
            {
                var student = _studentiInscrisi.First(s => s.nrMatricol.Equals(pair.Key));
                student.notaExamen = pair.Value;
            }
        }
    }
}
