using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPSSC
{
    class PlainText
    {
        private string _text;
        public string Text { get { return _text; } }

        public PlainText(string text)
        {
            if (!String.IsNullOrEmpty(text))
            {
                _text = text;
            }
            else { Console.Write("Introduceti caractere"); }
        }
    }
}
