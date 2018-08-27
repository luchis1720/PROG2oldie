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
    public partial class frmCentralTelefonica : Form
    {
        private Centralita central;

        public frmCentralTelefonica()
        {
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
           frmLlamador llam = new frmLlamador();
           llam.Central = central;
            llam.ShowDialog();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            frmFacturacion fact = new frmFacturacion();
            fact.Central = this.central;
            fact.Opcion = "total";
            fact.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            frmFacturacion fact = new frmFacturacion();
            fact.Central = this.central;
            fact.Opcion = "local";
            fact.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            frmFacturacion fact = new frmFacturacion();
            fact.Central = this.central;
            fact.Opcion = "provincial";
            fact.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCentralTelefonica_Load(object sender, EventArgs e)
        {
            central = new Centralita("Centralita S.A.");
        }
    }
}
