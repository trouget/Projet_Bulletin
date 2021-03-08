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
    public partial class gen_certif : Form
    {
        public gen_certif()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            double note_soutenance = Convert.ToInt32(tbx_soutenance.Text);
            double note_projPeda = Convert.ToInt32(tbx_projPeda.Text);
            double note_evalEntreprise = Convert.ToInt32(tbx_evalEtp.Text);
            double note_1annee = Convert.ToInt32(tbx_1annee.Text);
            double note_2annee = Convert.ToInt32(tbx_2annee.Text);
            double resultatFinal = Convert.ToInt32(tbx_resultat.Text);
        }
    }
}
