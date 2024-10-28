using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class PatenteInvalidaException : ApplicationException
    {
        public PatenteInvalidaException() : base("Patente invalida") { }
        public PatenteInvalidaException(string message) : base(message) { }
        public PatenteInvalidaException(string m, Exception e) : base(m, e) { }
    }
}
