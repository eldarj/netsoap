using DLWMSClient.DLWSMServis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMSClient
{
    public partial class Form1 : Form
    {
        MojServisSoapClient klijent = new MojServisSoapClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbGodinaStudija.DataSource = klijent.GetGodineStudija();
            cmbGodinaStudija.ValueMember = "Id";
            cmbGodinaStudija.DisplayMember = "Oznaka";

            dgvStudenti.DataSource = "Lista studenata...";
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            dgvStudenti.DataSource = klijent.GetStudenteByGodinaStudija(int.Parse(cmbGodinaStudija.SelectedValue.ToString()));
        }
    }
}
