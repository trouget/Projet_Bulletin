using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Bulletin
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
            BDDConnection BDD1 = new BDDConnection();

            eleves_dtgv.AutoGenerateColumns = true;
            eleves_dtgv.DataSource = BDD1.tableauBDDAccueil();

            eleves_dtgv.Columns["id_eleve"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }
        
    }
}