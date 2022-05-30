using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iThings_1._0.Repositories;
using iThings_1._0.Models;
using DBLayer;

namespace iThings_1._0
{
    public partial class FrmPopisZahtjeva : Form
    {

        public FrmPopisZahtjeva()
        {
            InitializeComponent();
            DB.SetConfiguration("ibelinic20_DB", "ibelinic20", "'CTvZ;12l'");
        }

        private void dgvZahtjevi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showZahtjevi();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            FormDataActivities FormaAktivnostisPodacima = new FormDataActivities();
            FormaAktivnostisPodacima.ShowDialog();
            showZahtjevi();
        }

        private void showZahtjevi()
        {
            List<Zahtjev> zahtjevi = ZahtjevRepository.GetZahtjevi();
            dgvZahtjevi.DataSource = zahtjevi;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
