using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lt_40_CentralTelefonica
{
    public class CentralitaException_lt_ex41 : Exception
    {
        #region ATRIBUTOS

        private string nombreClase;
        private string nombreMetodo;

        #endregion

        #region PROPIEDADES

        public Exception ExcepcionInterna
        {
            get { return base.InnerException;}
        }

        public string NombreClase
        {
            get { return this.nombreClase;}
        }

        public string NombreMetodo
        {
            get { return this.nombreMetodo;}
        }

        #endregion

        #region METODOS

        public CentralitaException_lt_ex41(string mensaje, string clase, string metodo) 
            : this(mensaje,clase,metodo,null)  //cualquiera lo que te deje hardcodear con null! pero bue... es asi...
        {
           
        }

        public CentralitaException_lt_ex41(string mensaje, string clase, string metodo, Exception innerException) 
            :base(mensaje, innerException) 
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        #endregion

        public override string ToString()
        {
            return "Mensaje: " + base.Message + ", Origen del error: " + base.Source;
        }
    }
}
