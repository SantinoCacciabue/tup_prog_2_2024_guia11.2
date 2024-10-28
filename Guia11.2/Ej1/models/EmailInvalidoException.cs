using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class EmailInvalidoException:ApplicationException
    {
        public EmailInvalidoException() : base("Email invalido") { }
        public EmailInvalidoException(string message) : base(message) { }
        public EmailInvalidoException(string m, Exception e):base(m, e) { }
    }
}
