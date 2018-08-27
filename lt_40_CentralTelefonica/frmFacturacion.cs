using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lt_40_CentralTelefonica
{
    public partial class frmFacturacion : Form
    {
        private Centralita central;
        private string opcion;

        public string Opcion
        {
            set { this.opcion = value;}
        }

        public Centralita Central
        {
            set { this.central=value;}
        }

        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            switch (opcion)
            {
                case "total":
                    rchtFacturacion.Text = "Facturacion total: " + central.GananciasPorTotal.ToString();
                    break;
                case "local":
                    rchtFacturacion.Text = "Facturacion local: " + central.GananciasPorLocal.ToString();
                    break;
                case "provincial":
                    rchtFacturacion.Text = "Facturacion provincial: " + central.GananciasPorProvincial.ToString();
                    break;
            }
        }

        private void rchtFacturacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
