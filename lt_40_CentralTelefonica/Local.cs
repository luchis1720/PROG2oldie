using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lt_40_CentralTelefonica
{
    public class Local : Llamada
    {
        #region Fields
        protected float costo;
        #endregion

        #region properties
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        #endregion

        #region Methods

        private float CalcularCosto()
        {
            float ans = 0;

            ans = this.costo * base.Duracion;

            return ans;
        }

        public override bool Equals(object obj)
        {
            bool ans = false;
            if (obj is Local)
            {
                ans = true;
            }
            return ans;
        }

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        protected override string Mostrar()
        {
            string retorno = "";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} Cost {1}", base.Mostrar(), this.CostoLlamada);
            retorno = sb.ToString();
            return retorno;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno = this.Mostrar();
            return retorno;
        }

        #endregion

    }
}