using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Llamada
    {
        #region ATRIBUTOS

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #endregion

        #region PROPIEDADES

        public float Duracion
        {
            get
            {
                return this.duracion;
            }

            //set
            //{
            //    this.Duracion = value;
            //}
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        #endregion

        #region METODOS Y CONSTRUCTORES

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            string ans = "";
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("NºOrigen:{0}\tNºDestino:{1}\tDuracion:{2}\t", this.NroOrigen, this.NroDestino, this.Duracion);
            ans = sb.ToString();

            return ans;
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int ans = 0;

            if (!(object.ReferenceEquals(null, llamada1)) && !(object.ReferenceEquals(null, llamada2)))
            {
                if (llamada1.duracion > llamada2.duracion)
                {
                    ans = 1;
                }
                else if (llamada1.duracion < llamada2.duracion)
                {
                    ans = -1;
                }
            }

            return ans;
        }

        #endregion

        #region NESTED TYPES

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas,
        }

        #endregion
    }
}
