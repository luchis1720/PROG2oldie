using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lt_40_CentralTelefonica
{
    public class Provincial : Llamada
    {
        #region Fields
        public Franja franjaHoraria;
        #endregion

        #region properties
        public override float CostoLlamada
        {
            get
            {
                return this.calcularCosto();
            }
        }
        #endregion

        #region Methods

        private float calcularCosto()
        {
            float retorno = 0;
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = ((float)Franja.Franja_1 / 100) * (this.Duracion);
                    break;
                case Franja.Franja_2:
                    retorno = ((float)Franja.Franja_2 / 100) * (this.Duracion);
                    break;
                case Franja.Franja_3:
                    retorno = ((float)Franja.Franja_3 / 100) * (this.Duracion);
                    break;
            }
            return retorno;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Provincial)
                retorno = true;
            return retorno;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }

        protected override string Mostrar()
        {
            string retorno = "";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} Costo: {1}", base.Mostrar(), this.CostoLlamada);
            retorno = sb.ToString();
            return retorno;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

        #region Nested Types
        public enum Franja
        {
            Franja_1 = 99,
            Franja_2 = 125,
            Franja_3 = 66,
        }

        #endregion
    }
}
