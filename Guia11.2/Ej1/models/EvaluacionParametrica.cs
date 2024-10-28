using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    [Serializable]
    internal class EvaluacionParametrica:Evaluacion
    {
        public double ValorMinimo {  get;private set; }
        public double ValorMaximo { get; private set; }
        public double ValorTolerado { get; private set; }
        public double ValorMedido { get; set; }
        public string Unidad {  get; private set; }
        public EvaluacionParametrica(double valorMinimo, double valorMaximo, double valorTolerado, string unidad,string n,string d):base(n,d)
        {
            ValorMinimo = valorMinimo;
            ValorMaximo = valorMaximo;
            ValorTolerado = valorTolerado;
            Unidad = unidad;
        }
        public override TipoAprobación Evaluar()
        {
            double valor70 = ValorMinimo * (1 - ValorTolerado / 100);
            double valor130=ValorMaximo * (1 + ValorTolerado / 100);
            if (ValorMedido < valor70)
            {
                return TipoAprobación.NoAprobado;
            }
            else if (ValorMedido < ValorMinimo)
            {
                return TipoAprobación.Parcial;
            }
            else if (ValorMedido <= ValorMaximo)
            {
                return TipoAprobación.Aprobado;
            }
            else if (ValorMedido < valor130)
            {
                return TipoAprobación.Aprobado;
            }
            return TipoAprobación.Aprobado;
        }
        public override string ToString()
        {
            string nombre = Nombre.Length > 20 ? Nombre.Substring(0, 21) + "..." : Nombre.PadRight(20, '_');
            string descripcion = Descripcion.Length > 20 ? Descripcion.Substring(0, 21) + "..." : Descripcion.PadRight(20, '_');
            return $"{nombre} - {descripcion} - {Evaluar()}\r\n";
        }
    }
}
