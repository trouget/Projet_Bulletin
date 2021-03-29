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

namespace Projet_Bulletin
{
    public partial class gen_1 : Form
    {
        public gen_1()
        {
            InitializeComponent();
        }

        private void btn_retour_Click(object sender, EventArgs e)
        {
            Accueil ac = new Accueil();
            ac.Show();
            this.Close();
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

            double reseau, dev, management;

            reseau = (note_AdminRes + note_infraScript + note_secu + note_SystOpn + note_SystPro) / 5;
            dev = (note_concepMod + (note_jse * 2) + note_technoWeb + note_framework) / 5;
            management = ((note_contGest * 3) + note_mana) / 4;


            double resultat = ((reseau * 3) + (dev * 3) + (management * 2) + note_anglais + note_bdd + note_comEcrite + (note_gestProjet * 3) + note_droit + (note_maths * 3) + (note_livret * 12)) / 30;
            label_moyenne.Text = Convert.ToString(resultat);
            annee1 annee = new annee1(resultat, note_AdminRes, note_anglais, note_bdd, note_comEcrite, note_concepMod, note_contGest, note_gestProjet, note_infraScript, note_jse, note_secu, note_SystOpn, note_SystPro, note_technoWeb, note_droit, note_framework, note_maths, note_livret, note_mana);

        }

        private void button1_Click(object sender, EventArgs e)
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
            gfx.DrawString("Nom de l'apprenti : DIZIERE Emma", font, XBrushes.Black, 90, 220);
            pen = new XPen(XColors.Black, 1);
            XBrush brush = new XSolidBrush(XColor.FromArgb(240, 240, 240));
            gfx.DrawRectangle(pen, brush, 50, 225, 450, 15);
            font = new XFont("Times New Roman", 8, XFontStyle.Bold);
            gfx.DrawString("Envaluation au sein du centre de formation ", font, XBrushes.Black, 228, 235);
            pen = new XPen(XColors.Black, 0.8);
            font = new XFont("Times New Roman", 8, XFontStyle.Regular);
            gfx.DrawRectangle(pen, 50, 240, 105, 20);

            gfx.DrawString("Matières ", font, XBrushes.Black, 60, 252);
            gfx.DrawRectangle(pen, 155, 240, 180, 10);

            gfx.DrawString("Moyennes sur 20", font, XBrushes.Black, 222, 248);

            gfx.DrawString("Coef", font, XBrushes.Black, 164, 258);
            gfx.DrawRectangle(pen, 191, 250, 36, 10);
            gfx.DrawString("Ctrl Cont", font, XBrushes.Black, 194, 258);
            gfx.DrawRectangle(pen, 227, 250, 36, 10);
            gfx.DrawString("Examen", font, XBrushes.Black, 232, 258);
            gfx.DrawRectangle(pen, 263, 250, 36, 10);
            gfx.DrawString("Total", font, XBrushes.Black, 272, 258);
            gfx.DrawRectangle(pen, 299, 250, 36, 10);
            gfx.DrawString("Classe", font, XBrushes.Black, 307, 258);
            gfx.DrawRectangle(pen, 335, 240, 165, 20);
            gfx.DrawString("Notes sur 20", font, XBrushes.Black, 395, 255);

            gfx.DrawString("1", font, XBrushes.Black, 164, 268);
            gfx.DrawRectangle(pen, 155, 260, 180, 10);
            gfx.DrawRectangle(pen, 155, 260, 36, 10);
            gfx.DrawRectangle(pen, 227, 260, 36, 10);
            gfx.DrawRectangle(pen, 263, 260, 36, 10);
            gfx.DrawString("Anglais Professionel ", font, XBrushes.Black, 55, 268);
            gfx.DrawRectangle(pen, 50, 260, 450, 10);

            gfx.DrawString("1", font, XBrushes.Black, 164, 278);
            gfx.DrawRectangle(pen, 155, 270, 180, 10);
            gfx.DrawRectangle(pen, 155, 270, 36, 10);
            gfx.DrawRectangle(pen, 227, 270, 36, 10);
            gfx.DrawRectangle(pen, 263, 270, 36, 10);
            gfx.DrawString("Outil mathématique", font, XBrushes.Black, 55, 278);
            gfx.DrawRectangle(pen, 50, 270, 450, 10);

            gfx.DrawString("1", font, XBrushes.Black, 164, 288);
            gfx.DrawRectangle(pen, 155, 280, 180, 10);
            gfx.DrawRectangle(pen, 155, 280, 36, 10);
            gfx.DrawRectangle(pen, 227, 280, 36, 10);
            gfx.DrawRectangle(pen, 263, 280, 36, 10);
            gfx.DrawString("Droit informatique ", font, XBrushes.Black, 55, 288);
            gfx.DrawRectangle(pen, 50, 280, 450, 10);

            gfx.DrawString("2", font, XBrushes.Black, 164, 298);
            gfx.DrawRectangle(pen, 155, 290, 180, 10);
            gfx.DrawRectangle(pen, 155, 290, 36, 10);
            gfx.DrawRectangle(pen, 227, 290, 36, 10);
            gfx.DrawRectangle(pen, 263, 290, 36, 10);
            gfx.DrawString("Management Budgetisation", font, XBrushes.Black, 55, 298);
            gfx.DrawRectangle(pen, 50, 290, 450, 10);
            gfx.DrawString("Evalué en première année ", font, XBrushes.Black, 370, 298);

            gfx.DrawString("3", font, XBrushes.Black, 164, 308);
            gfx.DrawRectangle(pen, 155, 300, 180, 10);
            gfx.DrawRectangle(pen, 155, 300, 36, 10);
            gfx.DrawRectangle(pen, 227, 300, 36, 10);
            gfx.DrawRectangle(pen, 263, 300, 36, 10);
            gfx.DrawString("Génie Logiciel ", font, XBrushes.Black, 55, 308);
            gfx.DrawRectangle(pen, 50, 300, 450, 10);

            gfx.DrawString("3", font, XBrushes.Black, 164, 318);
            gfx.DrawRectangle(pen, 155, 310, 180, 10);
            gfx.DrawRectangle(pen, 155, 310, 36, 10);
            gfx.DrawRectangle(pen, 227, 310, 36, 10);
            gfx.DrawRectangle(pen, 263, 310, 36, 10);
            gfx.DrawString("Réseaux, Systèmes et Sécurité ", font, XBrushes.Black, 55, 318);
            gfx.DrawRectangle(pen, 50, 310, 450, 10);

            gfx.DrawString("1", font, XBrushes.Black, 164, 328);
            gfx.DrawRectangle(pen, 155, 320, 180, 10);
            gfx.DrawRectangle(pen, 155, 320, 36, 10);
            gfx.DrawRectangle(pen, 227, 320, 36, 10);
            gfx.DrawRectangle(pen, 263, 320, 36, 10);
            gfx.DrawString("BD ", font, XBrushes.Black, 55, 328);
            gfx.DrawRectangle(pen, 50, 320, 450, 10);
            gfx.DrawString("Evalué en projet tutoré", font, XBrushes.Black, 370, 328);

            gfx.DrawString("3", font, XBrushes.Black, 164, 338);
            gfx.DrawRectangle(pen, 155, 330, 180, 10);
            gfx.DrawRectangle(pen, 155, 330, 36, 10);
            gfx.DrawRectangle(pen, 227, 330, 36, 10);
            gfx.DrawRectangle(pen, 263, 330, 36, 10);
            gfx.DrawString("Conduite de Projet ", font, XBrushes.Black, 55, 338);
            gfx.DrawRectangle(pen, 50, 330, 450, 10);
            gfx.DrawString("Evalué en première année ", font, XBrushes.Black, 370, 338);

            gfx.DrawString("3", font, XBrushes.Black, 164, 348);
            gfx.DrawRectangle(pen, 155, 340, 180, 10);
            gfx.DrawRectangle(pen, 155, 340, 36, 10);
            gfx.DrawRectangle(pen, 227, 340, 36, 10);
            gfx.DrawRectangle(pen, 263, 340, 36, 10);
            gfx.DrawString("Projet Tutoré ", font, XBrushes.Black, 55, 348);
            gfx.DrawRectangle(pen, 50, 340, 450, 10);
            gfx.DrawString("Evalué en deuxième année ", font, XBrushes.Black, 370, 348);


            gfx.DrawString("Moyenne", font, XBrushes.Black, 164, 358);
            gfx.DrawRectangle(pen, 50, 350, 450, 10);
            gfx.DrawRectangle(pen, 263, 350, 36, 10);
            gfx.DrawRectangle(pen, 299, 350, 36, 10);
            gfx.DrawString("Moyenne informatique ", font, XBrushes.Black, 360, 358);
            gfx.DrawRectangle(pen, 450, 350, 50, 10);

            font = new XFont("Times New Roman", 8, XFontStyle.Bold);
            gfx.DrawString("Evaluation en entreprise", font, XBrushes.Black, 228, 378);
            pen = new XPen(XColors.Black, 0.8);
            font = new XFont("Times New Roman", 8, XFontStyle.Regular);
            gfx.DrawRectangle(pen, 50, 370, 450, 10);
            gfx.DrawString("Livret de Suivi", font, XBrushes.Black, 80, 388);
            gfx.DrawString("12", font, XBrushes.Black, 164, 388);
            gfx.DrawRectangle(pen, 50, 380, 450, 10);
            gfx.DrawRectangle(pen, 155, 380, 180, 10);
            gfx.DrawRectangle(pen, 155, 380, 36, 10);
            gfx.DrawRectangle(pen, 263, 380, 36, 10);

            gfx.DrawString("Projet Entreprise", font, XBrushes.Black, 80, 398);
            gfx.DrawRectangle(pen, 50, 390, 450, 10);
            gfx.DrawRectangle(pen, 155, 390, 180, 10);
            gfx.DrawRectangle(pen, 155, 390, 36, 10);
            gfx.DrawRectangle(pen, 263, 390, 36, 10);

            gfx.DrawString("Moyenne", font, XBrushes.Black, 164, 408);
            gfx.DrawRectangle(pen, 50, 400, 450, 10);
            gfx.DrawRectangle(pen, 263, 400, 36, 10);
            gfx.DrawRectangle(pen, 299, 400, 36, 10);

            font = new XFont("Times New Roman", 8, XFontStyle.Bold);
            gfx.DrawString("Appréciation du conseil de promotion et du responsable de dispositif", font, XBrushes.Black, 198, 428);
            pen = new XPen(XColors.Black, 0.8);
            font = new XFont("Times New Roman", 8, XFontStyle.Regular);
            gfx.DrawRectangle(pen, 50, 420, 450, 10);
            gfx.DrawRectangle(pen, 50, 430, 450, 100);


            gfx.DrawString("Rappel Moyenne année 1", font, XBrushes.Black, 134, 448);
            gfx.DrawRectangle(pen, 284, 440, 30, 10);

            gfx.DrawString("Moyenne année 2 1er semestre", font, XBrushes.Black, 134, 458);
            gfx.DrawRectangle(pen, 284, 450, 30, 10);

            gfx.DrawString("A Dole le 10 mars 2021 ", font, XBrushes.Black, 290, 470);
            gfx.DrawString("Le responsable de dispositif : Julian COURBEZ", font, XBrushes.Black, 290, 480);


            const string filename = "Bulletin-notes-1annee.pdf";
            document.Save(filename);

            Process.Start(filename);

        }
    }
}
