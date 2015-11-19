using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProiectPSSC
{
    class ArgumentCannotBeEmptyStringException: ArgumentException
    {
        public ArgumentCannotBeEmptyStringException(string parameterName)
            : base(string.Format("Argument {0} cannot be empty string.", parameterName), parameterName)
        {

        }

    }
}
