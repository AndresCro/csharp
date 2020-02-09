using System;
using System.Collections.Generic;
using System.Text;

namespace Expec
{
    class NegativonException : Exception
    {
        public NegativonException() : base("Operacion invalida negativa") {}
        public NegativonException(string Mensaje) : base(Mensaje) { }
    }
}
