using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    class IncorectNumberFormatException : Exception
    {
        IncorectNumberFormatException()
        {
            Console.WriteLine("Eroare la numarul matricol");
        }
    }
}
