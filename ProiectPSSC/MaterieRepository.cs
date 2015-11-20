using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPSSC
{
    public class MaterieRepository : IMaterieRepository
    {
        private static List<Materie> materii = new List<Materie>();

        public MaterieRepository()
        {
        }

        public void AdaugaDisciplina(Materie numeMaterie)
        {
            var result = materii.FirstOrDefault(d => d.Equals(numeMaterie));

            if (result != null) throw new DuplicateWaitObjectException();

            materii.Add(numeMaterie);
            Console.WriteLine("O noua disciplina a fostr adaugata.");
        }
    }
}
