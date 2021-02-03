using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bulletin
{
    public class eleves
    {
        private int v1;
        private int v2;
        private string v3;
        private string v4;
        private string v5;
        private int v6;

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

        public eleves(int uneMoyenne_annee1, int uneMoyenne_annee2, string unNom, string unPrenom, string unePromotion, DateTime uneAnnee, int uneObtention)
        {
            this.Moyenne_annee1 = uneMoyenne_annee1;
            this.Moyenne_annee2 = uneMoyenne_annee2;
            this.nom = unNom;
            this.prenom = unPrenom;
            this.promotion = unePromotion;
            this.annee = uneAnnee;
            this.obtention = uneObtention;
        }
    }
}

