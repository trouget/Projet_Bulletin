using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bulletin
{
    public class eleves
    {
        // Création de 3 propriétés identifiant, nom et téléphone
        public int id_eleve { get; set; }
        public int Moyenne_annee1 { get; set; }
        public int Moyenne_annee2 { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string promotion { get; set; }
        public DateTime annee { get; set; }
        public int obtention { get; set; }

        public eleves()
        {

        }
    }
}

