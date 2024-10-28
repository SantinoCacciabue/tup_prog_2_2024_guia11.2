using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    [Serializable]
    internal class FiscalizadorVTV
    {
        public List<VTV> VTVs = new List<VTV>();
        public int CantidadVTV
        {
            get
            {
                return VTVs.Count;
            }
        }
        public VTV this[int i]
        {

            get
            {
                return VTVs[i];
            }
        }
        public VTV AgregarVTV(Propietario p, string patente)
        {
            VTV a = new VTV(patente, p);
            VTVs.Add(a);
            return a;
        }
        public List<VTV> VerVTVPorPatente(string patente)
        {
            List<VTV> ret = new List<VTV>();
            foreach(VTV v in VTVs)
            {
                if(v.Patente == patente)
                {
                    ret.Add(v);
                }
            }
            return ret;
        }
    }
}
