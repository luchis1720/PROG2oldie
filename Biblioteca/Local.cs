using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Local : Llamada
    {
        #region ATRIBUTOS

        protected float costo;

        #endregion

        #region PROPIEDADES

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        #endregion

        #region METODOS Y CONSTRUCTORES

        private float CalcularCosto()
        {
            float ans = 0;

            ans = this.costo * base.Duracion;

            return ans;
        }

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        new public string Mostrar()
        {
            string ans = "";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\tCosto:${1}", base.Mostrar(), this.CostoLlamada);
            ans = sb.ToString();
            return ans;
        }

        #endregion
    }
}
