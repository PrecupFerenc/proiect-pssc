using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace ProiectPSSC
{
    public class MaterieFactory   // creeam un ob de tipul Materie
    {
        public static readonly MaterieFactory Instance = new MaterieFactory();

        private MaterieFactory()
        {

        }

        public Materie CreeazaDisciplina(string numeMaterie)
        {
            Contract.Requires<ArgumentNullException>(numeMaterie != null, "text");
            Contract.Requires<ArgumentInvalidLengthException>(numeMaterie.Length >= 2 && numeMaterie.Length <= 40,
                    "Numele disciplinei trebuie sa contina intre 2 si 40 de caractere.");

            var disciplina = new Materie(new PlainText(numeMaterie) ,new CoeficientNote(1, 2));

            return disciplina;
        }

        
        public Student CreeazaStudent(string numarMatricol, string numeStudent)
        {
            return new Student(new NrMatricol(numarMatricol) ,new PlainText(numeStudent));
        }
    }
}
