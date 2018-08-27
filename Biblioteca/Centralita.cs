using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Centralita
    {
        #region ATRIBUTOS

        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #endregion

        #region PROPIEDADES

        public float GananciasPorLocal
        {
            get
            {
                float ans = this.CalcularGanancia(Llamada.TipoLlamada.Local);
                return ans;
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                float ans = this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
                return ans;
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                float ans = this.CalcularGanancia(Llamada.TipoLlamada.Todas);
                return ans;
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        #endregion

        #region METODOS Y CONSTRUCTORES

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            Local auxL;
            Provincial auxP;

            float ans = 0, acumL = 0, acumP = 0;
            foreach (Llamada search in Llamadas)
            {
                if (search is Local)
                {
                    auxL = (Local)search;
                    acumL += auxL.CostoLlamada;
                }
                else if (search is Provincial)
                {
                    auxP = (Provincial)search;
                    acumP += auxP.CostoLlamada;
                }
            }
            switch ((int)tipo)
            {
                case 0: //local
                    ans = acumL;
                    break;
                case 1: //provincial
                    ans = acumP;
                    break;
                case 2: //todas
                    ans = acumL + acumP;
                    break;
            }

            return ans;
        }

        public string Mostrar()
        {
            string ans = "";
            Local auxL;
            Provincial auxP;
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Ganancia Total: {0} Ganancia de Local: {1} Ganancia de Provincial: {2} ", this.GananciasPorTotal, this.GananciasPorLocal, this.GananciasPorProvincial);
            sb.AppendLine("");

            foreach (Llamada search in this.Llamadas)
            {
                if (search is Local)
                {
                    auxL = (Local)search;
                    sb.AppendFormat("{0}", auxL.Mostrar());
                    sb.AppendLine("");
                }
                else if (search is Provincial)
                {
                    auxP = (Provincial)search;
                    sb.AppendFormat("{0}", auxP.Mostrar());
                    sb.AppendLine("");
                }
            }

            ans = sb.ToString();
            return ans;
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        #endregion
    }
}
