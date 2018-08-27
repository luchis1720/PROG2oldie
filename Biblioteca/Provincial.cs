using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1 = 99,
            Franja_2 = 125,
            Franja_3 = 66,
        }

        #region ATRIBUTOS

        protected Franja franjaHoraria;

        #endregion

        #region PROPIEDADES

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        #endregion

        #region METODOS Y CONSTRUCTORES

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float ans = 0;

            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    ans = ((float)Franja.Franja_1 / 100) * (this.Duracion);
                    break;
                case Franja.Franja_2:
                    ans = ((float)Franja.Franja_2 / 100) * (this.Duracion);
                    break;
                case Franja.Franja_3:
                    ans = ((float)Franja.Franja_3 / 100) * (this.Duracion);
                    break;
            }

            return ans;
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
