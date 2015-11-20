using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace ProiectPSSC
{
    class Facultate
    {
        public PlainText NumeFacultate { get; internal set; }
        private List<Materie> _listaMaterii;
        public ReadOnlyCollection<Materie> ListaMaterii { get { return _listaMaterii.AsReadOnly(); } }

        internal Facultate(PlainText nume)
        {
            Contract.Requires(nume != null, "nume");
            
            NumeFacultate = nume;            
            _listaMaterii = new List<Materie>();
        }

        
        public void AdaugaMaterie(Materie disciplina)
        {
            Contract.Requires(disciplina != null, "disciplina");
            
            var gasit = _listaMaterii.FirstOrDefault(s => s.Equals(disciplina));
            if (gasit == null)
            {
                _listaMaterii.Add(disciplina);
            }
            else
            {
                throw new FacultateaExistaExceptions();
            }
        }
    }
}
