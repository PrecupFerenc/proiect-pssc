using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPSSC
{
    class Note
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
            _note = note;
        }

        public Nota Media
        {
            get
            {
                if (_note.Count < 2) throw new NoteInsuficienteException();
                return new Nota(_note.Select(n => n.Valoare).Average());
            }
        }

        internal void AdaugaNota(Nota nota)
        {
            _note.Add(nota);
        }
    }
}
