using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class DniInvalidoException:ApplicationException
    {
        public DniInvalidoException():base("Dni invalido") { }
        public DniInvalidoException(string message):base(message) { }
        public DniInvalidoException(string m, Exception e):base(m, e) { }  
    }
}
