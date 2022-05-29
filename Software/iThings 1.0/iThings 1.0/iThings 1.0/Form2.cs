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
    public partial class Form2 : Form
    {

        private Zahtjev zahtjev;
        
        public Form2()
        {
            InitializeComponent();
            DB.SetConfiguration("ibelinic20_DB", "ibelinic20", "'CTvZ;12l'");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text.ToString());
            string podnositelj = textBox1.Text;
            string status = textBox3.Text;
            string datumPodnosenja = textBox4.Text;
            string naziv = textBox5.Text;
            int kolicina = int.Parse(textBox6.Text);

            ZahtjevRepository.InsertIntoZahtjev(id, podnositelj, status, datumPodnosenja, naziv, kolicina);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtID.Text.ToString());
            ZahtjevRepository.DeleteFromZahtjev(id);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtID.Text.ToString());
            string podnositelj = textBox1.Text;
            string status = textBox3.Text;
            string datumPodnosenja = textBox4.Text;
            string naziv = textBox5.Text;
            int kolicina = int.Parse(textBox6.Text.ToString());

            ZahtjevRepository.UpdateFromZahtjev(id, podnositelj, status, datumPodnosenja, naziv, kolicina);
            Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text.ToString());
            dgvPretragaZahtjev.DataSource = ZahtjevRepository.Pretraga(id);
        }
    }
}
