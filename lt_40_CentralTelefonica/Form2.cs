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
    public partial class frmLlamador : Form
    {
        private Centralita central;

        public Centralita Central
        {
            set { this.central = value; }
        }

        public frmLlamador()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNrodestino.AppendText("3");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtNrodestino.Text = "";
            txtNroOrigen.Text = "";
            cmbFranja.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNrodestino.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNrodestino.AppendText("2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtNrodestino.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtNrodestino.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtNrodestino.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtNrodestino.AppendText("7"); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtNrodestino.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtNrodestino.AppendText("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtNrodestino.AppendText("0");
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            txtNrodestino.AppendText("*");
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            txtNrodestino.AppendText("#");
        }

        private void frmLlamador_Load(object sender, EventArgs e)
        {
            txtNrodestino.Text = "";
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            cmbFranja.SelectedIndex = 1;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if (object.Equals(txtNrodestino.Text[0], '#'))
            {
                Provincial.Franja franjas;
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
                Provincial llamadaProvincial = new Provincial(txtNroOrigen.Text, franjas, 45, txtNrodestino.Text);
                central += llamadaProvincial;
            }
            else
            {
                Local llamadaLocal = new Local(txtNroOrigen.Text, 45, txtNrodestino.Text, 1.23f);
                central += llamadaLocal;
            }
        }
    }
}
