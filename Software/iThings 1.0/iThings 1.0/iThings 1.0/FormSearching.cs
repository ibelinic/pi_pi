using DBLayer;
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

namespace iThings_1._0
{
    public partial class FormSearching : Form
    {

        private Zahtjev zahtjev;

        public FormSearching()
        {
            InitializeComponent();
            DB.SetConfiguration("ibelinic20_DB", "ibelinic20", "'CTvZ;12l'");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int id = int.Parse(txtIDPretraga.Text.ToString());
            dgvSearchingID.DataSource = ZahtjevRepository.PretragaID(id);
        }

        private void btnSearchbyStatus_Click(object sender, EventArgs e)
        {
            string status = txtStatusSearch.Text;
            dgvSearchingStatus.DataSource = ZahtjevRepository.PretragaStatus(status);
        }

        private void btnZatvoriKonacno_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
