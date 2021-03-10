using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projet_Bulletin
{
    public partial class gen_certif : Form
    {
        double note_soutenance; 
        double note_projPeda;
        double note_evalEntreprise;
        double note_1annee;
        double note_2annee;
        double resultatFinal;

        public gen_certif()
        {
            InitializeComponent();
        }


        private void btn_retour_Click(object sender, EventArgs e)
        {
            Accueil ac = new Accueil();
            ac.Show();
            
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            double note_soutenance = Convert.ToInt32(tbx_soutenance.Text);
            double note_projPeda = Convert.ToInt32(tbx_projPeda.Text);
            double note_evalEntreprise = Convert.ToInt32(tbx_evalEtp.Text);
            double note_1annee = Convert.ToInt32(tbx_1annee.Text);
            double note_2annee = Convert.ToInt32(tbx_2annee.Text);


            double resultatFinal;
            resultatFinal = (note_soutenance + note_projPeda + note_evalEntreprise + (note_1annee * 1.5) + (note_2annee * 1.5)) / 6;
            label_moyenne.Text = Convert.ToString(resultatFinal);
        }

        private void CreerPDF_Click(object sender, EventArgs e)
        {
            PdfDocument doc = new PdfDocument();
            doc.Info.Title = "Created with PDFsharp";

            PdfPage page = doc.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont font = new XFont("Times New Roman", 8, XFontStyle.Regular);

            gfx.DrawString(note_soutenance.ToString(), font, XBrushes.Black, 100, 100);
            gfx.DrawString(note_projPeda.ToString(), font, XBrushes.Black, 100, 100);
            gfx.DrawString(note_evalEntreprise.ToString(), font, XBrushes.Black, 100, 100);
            gfx.DrawString(note_1annee.ToString(), font, XBrushes.Black, 100, 100);
            gfx.DrawString(note_2annee.ToString(), font, XBrushes.Black, 100, 100);
            gfx.DrawString(resultatFinal.ToString(), font, XBrushes.Black, 100, 100);

            const string filename = "Bulletin-note.pdf";
            doc.Save(filename);

            Process.Start(filename);
        }
    }
}
