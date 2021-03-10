using PdfSharp.Drawing;
using PdfSharp.Pdf;
using Spire.Pdf.Tables;
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
using PdfDocument = PdfSharp.Pdf.PdfDocument;

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
        double moyenne;

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


            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Times New Roman", 8, XFontStyle.Bold);
            XPen pen = new XPen(XColors.Black, 0.8);
            gfx.DrawRectangle(pen, 75, 70, 150, 65);
            gfx.DrawRectangle(pen, 400, 70, 125, 65);

            gfx.DrawString("Lycée Pasteur Mont Roland", font, XBrushes.Black, 100, 80);
            gfx.DrawString("Enseignement Supérieur", font, XBrushes.Black, 107, 90);
            font = new XFont("Times New Roman", 8, XFontStyle.Regular);
            gfx.DrawString("9 avenue Rockefeller", font, XBrushes.Black, 117, 100);
            gfx.DrawString("BP 24", font, XBrushes.Black, 139, 110);
            gfx.DrawString("39107 Dole Cedex", font, XBrushes.Black, 120, 120);
            gfx.DrawString("03 84 79 75 00", font, XBrushes.Black, 127, 130);
            gfx.DrawString("En partenariat avec :", font, XBrushes.Black, 429, 80);
            font = new XFont("Times New Roman", 8, XFontStyle.Bold);
            gfx.DrawString("CFA ASPECT", font, XBrushes.Black, 438, 100);
            font = new XFont("Times New Roman", 8, XFontStyle.Regular);
            gfx.DrawString("20 rue Megevand", font, XBrushes.Black, 435, 110);
            gfx.DrawString("25041 Besançon", font, XBrushes.Black, 436, 120);
            gfx.DrawString("03 81 25 03 75", font, XBrushes.Black, 439, 130);
            gfx.DrawImage(XImage.FromFile("lpmr.png"), 230, 75, 80, 50);
            gfx.DrawImage(XImage.FromFile("aspect.jpg"), 318, 75, 80, 50);
            font = new XFont("Times New Roman", 10, XFontStyle.Bold);
            gfx.DrawString("RELEVE DE NOTES - Promotion 2019 2021 - Première année", font, XBrushes.Black, 184, 160);
            gfx.DrawString("Administrateur de Systèmes d'Information", font, XBrushes.Black, 222, 180);
            font = new XFont("Times New Roman", 8, XFontStyle.Bold);
            gfx.DrawString("TITRE RNCP de Niveau 6 - N° de certification 26E32601 - Code NSF 326 n", font, XBrushes.Black, 186, 195);

            font = new XFont("Times New Roman", 8, XFontStyle.Regular);
            gfx.DrawString("Nom de l'apprenti : COURBEZ Julian", font, XBrushes.Black, 90, 220);
            pen = new XPen(XColors.Black, 1);
            XBrush brush = new XSolidBrush(XColor.FromArgb(240, 240, 240));
            gfx.DrawRectangle(pen, brush, 75, 225, 450, 15);
            font = new XFont("Times New Roman", 8, XFontStyle.Bold);
            gfx.DrawString("Envaluation au sein du centre de formation ", font, XBrushes.Black, 228, 235);
            pen = new XPen(XColors.Black, 0.8);
            font = new XFont("Times New Roman", 8, XFontStyle.Regular);
            gfx.DrawRectangle(pen, 75, 240, 80, 20);

            gfx.DrawString("Matières ", font, XBrushes.Black, 100, 252);

            gfx.DrawRectangle(pen, 155, 240, 180, 10);
            gfx.DrawRectangle(pen, 155, 260, 180, 10);
            gfx.DrawRectangle(pen, 155, 280, 180, 10);

            gfx.DrawString("Moyennes sur 20", font, XBrushes.Black, 222, 248);
            gfx.DrawRectangle(pen, 155, 250, 36, 10);

            gfx.DrawString("Coef", font, XBrushes.Black, 164, 258);
            gfx.DrawRectangle(pen, 191, 250, 36, 10);
            gfx.DrawString("Ctrl Cont", font, XBrushes.Black, 194, 258);
            gfx.DrawRectangle(pen, 227, 250, 36, 10);
            gfx.DrawString("Examen", font, XBrushes.Black, 232, 258);
            gfx.DrawRectangle(pen, 263, 250, 36, 10);
            gfx.DrawString("Total", font, XBrushes.Black, 272, 258);
            gfx.DrawRectangle(pen, 299, 250, 36, 10);
            gfx.DrawString("Classe", font, XBrushes.Black, 307, 258);
            gfx.DrawRectangle(pen, 335, 240, 190, 20);
            gfx.DrawString("Notes sur 20", font, XBrushes.Black, 414, 252);



            gfx.DrawString("Soutenance Oral : ", font, XBrushes.Black, 250, 300);
            gfx.DrawString(note_soutenance.ToString(), font, XBrushes.Black, 350, 300);

            gfx.DrawString("Projet Pédagogique : ", font, XBrushes.Black, 250, 320);
            gfx.DrawString(note_projPeda.ToString(), font, XBrushes.Black, 350, 320);

            gfx.DrawString("Evaluation Entreprise : ", font, XBrushes.Black, 250, 330);
            gfx.DrawString(note_evalEntreprise.ToString(), font, XBrushes.Black, 350, 330);

            gfx.DrawString("Moyenne de 1ère année : ", font, XBrushes.Black, 250, 340);
            gfx.DrawString(note_1annee.ToString(), font, XBrushes.Black, 350, 340);

            gfx.DrawString("Moyenne de 2ère année : ", font, XBrushes.Black, 250, 350);
            gfx.DrawString(note_2annee.ToString(), font, XBrushes.Black, 350, 350);

            gfx.DrawString("Resultat Final : ", font, XBrushes.Black, 250, 360);
            gfx.DrawString(resultatFinal.ToString(), font, XBrushes.Black, 350, 360);

            gfx.DrawString("Moyenne Final : ", font, XBrushes.Black, 250, 370);
            gfx.DrawString(moyenne.ToString(), font, XBrushes.Black, 350, 370);

            const string filename = "Bulletin-notes.pdf";
            document.Save(filename);

            Process.Start(filename);
        }
    }
}
