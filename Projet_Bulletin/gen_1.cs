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
    public partial class gen_1 : Form
    {
        public gen_1()
        {
            InitializeComponent();
        }

        private void gen_1_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_valider1_Click(object sender, EventArgs e)
        {
            double note_anglais = Convert.ToInt32(tbx_anglais.Text);
            double note_droit = Convert.ToInt32(tbx_droit.Text);
            double note_livret = Convert.ToInt32(tbx_livret.Text);
            double note_maths = Convert.ToInt32(tbx_maths.Text);
            double note_gestProjet = Convert.ToInt32(tbx_gestProj.Text);
            double note_bdd = Convert.ToInt32(tbx_bdd.Text);
            double note_comEcrite = Convert.ToInt32(tbx_comEcrite.Text);
            double note_contGest = Convert.ToInt32(tbx_contGest.Text);
            double note_mana = Convert.ToInt32(tbx_mana.Text);
            double note_framework = Convert.ToInt32(tbx_frwk.Text);
            double note_jse = Convert.ToInt32(tbx_jse.Text);
            double note_technoWeb = Convert.ToInt32(tbx_technoWeb.Text);
            double note_concepMod = Convert.ToInt32(tbx_concepMod.Text);
            double note_infraScript = Convert.ToInt32(tbx_infraScript.Text);
            double note_SystOpn = Convert.ToInt32(tbx_SystOpn.Text);
            double note_secu = Convert.ToInt32(tbx_secu.Text);
            double note_AdminRes = Convert.ToInt32(tbx_adminRes.Text);
            double note_SystPro = Convert.ToInt32(tbx_SystPro.Text);
            double resultat = Convert.ToInt32(tbx_resultat);
        }
    }
}
