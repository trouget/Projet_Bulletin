using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Bulletin
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new gen_1());

            eleves eleve1 = new eleves(16, 12, "toto", "dupont", "asi2", DateTime.Now, 0);

            annee1 anneeGerard1 = new annee1(10, 16, 17, 11, 10, 12, 13, 9, 6, 15, 15, 10, 6, 2, 14, 10, 2, 15, 17);

            annee2 anneeGerard2 = new annee2(9, 13, 14, 15, 10, 9, 12, 9, 2, 15, 19, 16, 9, 2, 13, 16, 19, 16);

            BDDConnection BDD1 = new BDDConnection();
                BDD1.AddEleve(eleve1);
                BDD1.AddAnnee1(anneeGerard1);
                BDD1.AddAnnee2(anneeGerard2);
                BDD1.DeleteEleve(eleve1);

            
        }
    }
}
