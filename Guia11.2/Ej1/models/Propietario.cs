using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ej1.models
{
    [Serializable]
    internal class Propietario
    {
        private string email;
        private int dni;
        public int DNI
        {
            get { return dni; }
            set
            {
                if (value < 1000000)
                {
                    throw new DniInvalidoException();
                }
                dni = value;
            }
        }
        public string ApellidoNombres{get; set; }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                Match a = Regex.Match(value, @"^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,}$");
                if (!a.Success)
                {
                    throw new EmailInvalidoException();
                }
                email = value;
            }
        }
        public Propietario(int dNI, string apellidoNombres, string email)
        {
            DNI = dNI;
            ApellidoNombres = apellidoNombres;
            Email = email;
        }
        public override string ToString()
        {
            return $"{ApellidoNombres}({DNI})";
        }
    }
}
