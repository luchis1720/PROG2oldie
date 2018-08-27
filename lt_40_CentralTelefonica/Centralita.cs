using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lt_40_CentralTelefonica
{
    public class Centralita
    {
        #region Fields
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        #endregion

        #region properties
        public float GananciasPorLocal
        {
            get
            {
                float retorno;
                retorno = this.CalcularGanancia(Llamada.TipoLlamadas.Local);
                return retorno;
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                float retorno;
                retorno = this.CalcularGanancia(Llamada.TipoLlamadas.Provincial);
                return retorno;
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                float retorno;
                retorno = this.CalcularGanancia(Llamada.TipoLlamadas.Todas);
                return retorno;
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

        #region methods

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        private float CalcularGanancia(Llamada.TipoLlamadas tipo)
        {
            Local auxLocal;
            Provincial auxProvincial;
            float retornoLocal = 0;
            float retornoProvincial = 0;
            float retorno = 0;
            foreach (Llamada aux in this.Llamadas)
            {
                if (aux is Local)
                {
                    auxLocal = (Local)aux;
                    retornoLocal += auxLocal.CostoLlamada;
                }
                else if (aux is Provincial)
                {
                    auxProvincial = (Provincial)aux;
                    retornoProvincial += auxProvincial.CostoLlamada;
                }
            }

            switch ((int)tipo)
            {
                case 0: //local
                    retorno = retornoLocal;
                    break;
                case 1: //provincial
                    retorno = retornoProvincial;
                    break;
                case 2: //todas
                    retorno = retornoLocal + retornoProvincial;
                    break;
            }

            return retorno;
        }

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private string Mostrar()
        {
            string retorno = "";
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Ganancia Total: {0} Ganancia por Local {1} Ganancia por Provincial {2} ",                                                      this.GananciasPorTotal, this.GananciasPorLocal, this.GananciasPorProvincial);
            sb.AppendLine("");
            sb.AppendLine("--------------------------------------------");
            foreach (Llamada aux in this.Llamadas)
            {
                sb.AppendFormat("{0}", aux.ToString());
                sb.AppendLine("");
            }

            retorno = sb.ToString();
            return retorno;
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool retorno = false;

            foreach (Llamada aux in c.Llamadas)
            {
                if (aux == llamada)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            bool retorno = false;
            if (!(c == llamada))
                retorno = true;
            return retorno;
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            foreach (Llamada aux in c.Llamadas)
            {
                if (nuevaLlamada == aux)
                    return c;
            }
            c.AgregarLlamada(nuevaLlamada);
            return c;

            //try   // el try en este caso con el catch van en el main! (el contenido del try si se queda aca)
            //    // cuando se agrega cada llamada.  pasa que no tengo el main de consola... BOLUDO.
            //{
            //    if (c != nuevaLlamada)
            //        c.AgregarLlamada(nuevaLlamada);
            //    else
            //     //   throw new CentralitaException_lt_ex41("La llamada ya se encuentra registrada.", "Centralita", "Operator +", ex);
            //    return c;
            //}
            //catch (CentralitaException_lt_ex41 ex) //CAPTURO EXCEPCION PERSONALIZADA
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex) //CAPTURO CUALQUIER EXCEPCION
            //{
            //    throw new CentralitaException_lt_ex41("error","Centralita","Operator +" , ex);
            //}

             
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
