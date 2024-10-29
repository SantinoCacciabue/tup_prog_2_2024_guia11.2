using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ej1.models
{
    [Serializable]
    internal class VTV : IComparable
    {
        public Propietario propietario;
        private List<Evaluacion> verificaciones = new List<Evaluacion>();

        public string Patente {  get; private set; }
        public DateTime Fecha { get;  set; }
        public  int CantidadVerificaciones
        {
            get
            {
                return verificaciones.Count;
            }
        }
        public Evaluacion this[int i]
        {
            get
            {
                return verificaciones[i];
            }
        }
        public TipoAprobación VerificarAprobacion()
        {

            
               int min = 0;
             for(int i = 0;i<CantidadVerificaciones;i++)
                {
                    Evaluacion ev = verificaciones[i];
                    if (i == 0)
                    {
                        min = (int)ev.Evaluar();
                    }
                    else if ((int)ev.Evaluar() < min)
                    {
                        min = (int)ev.Evaluar();
                    }
             }
                return (TipoAprobación)min;
            
        }
        public VTV(string patente,Propietario p)
        {
            Patente = patente;
            propietario = p;
            string pat = patente.Replace("-", "").Trim().ToUpper();
            Match a = Regex.Match(pat, @"^[A-Z]{2}\d{3}[A-Z]{2}$");
            Match b = Regex.Match(pat, @"^[A-Z]{3}\d{3}$");
            Fecha = DateTime.Now;
            if (!a.Success && !b.Success)
            {
                throw new PatenteInvalidaException();
            }
            verificaciones = new List<Evaluacion> {new EvaluacionParametrica(0,30,30,"Porcentaje","Prueba de frenos delanteros","Porcentaje de diferencia de frenado entre ejes"),
        new EvaluacionParametrica(0,30,30,"Porcentaje","Prueba de frenos traseros","Porcentaje de diferencia de frenado entre ejes"),
        new EvaluacionParametrica(0.0,0.5,30,"Grado","Alineación","Convergencia en grados"),
        new EvaluacionParametrica(10000,15000,30,"Candela","Luces de corto alcante","Intensidad lumínica"),
        new EvaluacionParametrica(30000,40000,30,"Candela","Luces de largo alcante","Intensidad lumínica"),
                new EvaluacionSimple("Bocina","Funcionamiento correcto"),};
        }
        public string[] EmitirComprobante()
        {
            string[] a = new string[CantidadVerificaciones + 1];
            a[0] = propietario.ToString();
            for (int i = 1; i < CantidadVerificaciones; i++)
            {
                a[i] = verificaciones[i-1].ToString();
            }
            return a;
        }

        public int CompareTo(object obj)
        {
            Propietario a = obj as Propietario;
            if (a != null)
            {
                return propietario.DNI.CompareTo(a.DNI);
            }
            return -1;
        }
        private DateTime FechaRevalidacion()
        {
            DateTime fecha = Fecha;
            int i = 0;
            while (i < 20)
            {
                if (fecha.DayOfWeek != DayOfWeek.Sunday | fecha.DayOfWeek != DayOfWeek.Saturday)
                {
                    i++;
                }
                fecha = fecha.AddDays(1);
            }
            return fecha;
        }
        public override string ToString()
        {
            string a = $"-------------------------------------------------\r\n{propietario}{Patente}-{VerificarAprobacion()}-{Fecha}\r\n";
            if(VerificarAprobacion()==TipoAprobación.Aprobado)
            {
                return $"{a}Fecha Vencimiento: {Fecha.AddYears(1)}\r\n-------------------------------------------------";
            }
            if(VerificarAprobacion()==TipoAprobación.Parcial)
            {
               
                return $"{a}Fecha Revalidación: {FechaRevalidacion()}\r\n-------------------------------------------------";
            }
            return a;
        }
    }
}
