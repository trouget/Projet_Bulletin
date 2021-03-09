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
    public partial class gen_2 : Form
    {
        public gen_2()
        {
            InitializeComponent();
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            Accueil ac = new Accueil();
            ac.Show();
            this.Close();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            double note_anglais = Convert.ToInt32(tbx_anglais.Text);
            double note_droit = Convert.ToInt32(tbx_droit.Text);
            double note_livret = Convert.ToInt32(tbx_livret.Text);
            double note_maths = Convert.ToInt32(tbx_maths.Text);
            double note_projet = Convert.ToInt32(tbx_projet.Text);
            double note_bigData = Convert.ToInt32(tbx_bigData.Text);
            double note_technoWeb = Convert.ToInt32(tbx_technoWeb.Text);
            double note_suiviProjet = Convert.ToInt32(tbx_suiviProjet.Text);
            double note_appHybrid = Convert.ToInt32(tbx_appHybrid.Text);
            double note_jee = Convert.ToInt32(tbx_jee.Text);
            double note_arduino = Convert.ToInt32(tbx_arduino.Text);
            double note_infraScript = Convert.ToInt32(tbx_infraScript.Text);
            double note_SystOpn = Convert.ToInt32(tbx_SystOpn.Text);
            double note_secu = Convert.ToInt32(tbx_secu.Text);
            double note_AdminRes = Convert.ToInt32(tbx_adminRes.Text);
            double note_SystPro = Convert.ToInt32(tbx_SystPro.Text);
            double note_deploiSrv = Convert.ToInt32(tbx_deplsrv.Text);
            
            double reseau, dev;
            reseau = note_AdminRes + note_deploiSrv + note_SystOpn + note_SystPro + note_secu + note_infraScript;
            dev = note_appHybrid + note_arduino + note_jee;
            double note_resultat = (note_anglais + note_droit + (note_maths * 3) + note_bigData + (note_livret * 12) + (dev * 3) + (reseau * 3)) / 24;
            label_resultat.Text = Convert.ToString(note_resultat);


        }
    }
}
