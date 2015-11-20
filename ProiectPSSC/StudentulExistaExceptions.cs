using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProiectPSSC
{
    class StudentulExistaExceptions : Exception
    {
        public StudentulExistaExceptions()
        {
            Console.Write("Studentul este deja inscris la aceasta materie");
        }
    }
}
