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
            DataGridViewButtonColumn c = new DataGridViewButtonColumn();
            c.Name = "annee1";
            c.HeaderText = "Annee1";
            c.Text = "Voir";
            eleves_dtgv.Columns.Insert(5, c);
            DataGridViewButtonColumn c2 = new DataGridViewButtonColumn();
            c2.Name = "annee2";
            c2.HeaderText = "Annee2";
            c2.Text = "Voir";
            eleves_dtgv.Columns.Insert(6, c2);
            DataGridViewButtonColumn certif = new DataGridViewButtonColumn();
            certif.Name = "Certification";
            certif.HeaderText = "Certification";
            certif.Text = "Voir";
            eleves_dtgv.Columns.Insert(7, certif);
            eleves_dtgv.Columns["id_eleve"].Visible = false;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }
        
    }
}