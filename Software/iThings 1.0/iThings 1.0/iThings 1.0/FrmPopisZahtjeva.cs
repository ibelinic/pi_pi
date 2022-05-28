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

        private Zahtjev zahtjev;

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

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            showZahtjevi();
            InsertIntoZahtjev(zahtjev);
        }

        private void showZahtjevi()
        {
            List<Zahtjev> zahtjevi = ZahtjevRepository.GetZahtjevi();
            dgvZahtjevi.DataSource = zahtjevi;
        }
        public static void InsertIntoZahtjev(Zahtjev zahtjev)
        {
            string sql = $"INSERT INTO Zahtjev (Id, Podnositelj, Status, DatumPodnosenja, Naziv, Kolicina) VALUES({zahtjev.Id}, {zahtjev.Podnositelj},{zahtjev.Status},{zahtjev.DatumPodnosenja}, {zahtjev.Naziv}, {zahtjev.Kolicina})";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
