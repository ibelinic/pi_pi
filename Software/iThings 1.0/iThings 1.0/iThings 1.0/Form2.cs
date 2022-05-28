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

        public Form2()
        {
            InitializeComponent();
            DB.SetConfiguration("ibelinic20_DB", "ibelinic20", "'CTvZ;12l'");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
        }
    }
}
