using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProiectPSSC
{
    class NoteInsuficienteException : Exception
    {
        public NoteInsuficienteException(int _nrNote)
        {
            if (_nrNote < 2) { Console.Write("Nu se poate calcula media"); }
        }
    }
}
