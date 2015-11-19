using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace ProiectPSSC
{
    class Note  // imi adauga nota in lista
    {
        private List<Nota> _note;
        public ReadOnlyCollection<Nota> Valori { get { return _note.AsReadOnly(); } }

        public Note()
        {
            _note = new List<Nota>();
        }

        //acest constructor este internal pentru ca ar trebui sa fie folosit doar din repository
        internal Note(List<Nota> note)
        {
            Contract.Requires(note != null, "lista de note");
            _note = note;
        }

        public Nota Media
        {
            get
            {
                if (_note.Count < 2) throw new NoteInsuficienteException(_note.Count);
                return new Nota(_note.Select(n => n.Valoare).Average());
            }
        }

        internal void AdaugaNota(Nota nota)
        {
            Contract.Requires(nota != null, "nota");
            _note.Add(nota);
        }
    }
}
