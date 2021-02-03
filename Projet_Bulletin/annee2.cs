using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bulletin
{
    class annee2
    {
        public int id_bulletin2 { get; set; }
        public int Moyenne2 { get; set; }
        public int Administration_reseau { get; set; }
        public int Anglais_technique { get; set; }
        public int Application_hybride { get; set; }
        public int Droit_informatique { get; set; }
        public int Infrastructure_et_scripting { get; set; }
        public int JEE { get; set; }
        public int Outils_Mathematiques { get; set; }
        public int Securite { get; set; }
        public int Suivi_de_projet { get; set; }
        public int Systeme_open_source { get; set; }
        public int Systeme_proprietaire { get; set; }
        public int Technologie_web_dynamique { get; set; }
        public int Deploiement_serveur { get; set; }
        public int Big_data { get; set; }
        public int Arduino { get; set; }
        public int Projet { get; set; }
        public int Livret_de_suivi { get; set; }

        public annee2()
        {

        }

        public annee2(int uneMoyenne2, int uneAdministration_reseau, int uneAnglais_technique, int uneApplication_hybride, int uneDroit_informatique, int uneInfrastructure_et_scripting, int uneJEE, int uneOutils_Mathematiques, int uneSecurite, int uneSuivi_de_projet, int uneSysteme_open_source, int uneSysteme_proprietaire, int uneTechnologie_web_dynamique, int uneDeploiement_serveur, int uneBig_data, int uneArduino, int uneProjet, int uneLivret_de_suivi)
        {
            this.Moyenne2 = uneMoyenne2;
            this.Administration_reseau = uneAdministration_reseau;
            this.Anglais_technique = uneAnglais_technique;
            this.Application_hybride = uneApplication_hybride;
            this.Droit_informatique = uneDroit_informatique;
            this.Infrastructure_et_scripting = uneInfrastructure_et_scripting;
            this.JEE = uneJEE;
            this.Outils_Mathematiques = uneOutils_Mathematiques;
            this.Securite = uneSecurite;
            this.Suivi_de_projet = uneSuivi_de_projet;
            this.Systeme_open_source = uneSysteme_open_source;
            this.Systeme_proprietaire = uneSysteme_proprietaire;
            this.Technologie_web_dynamique = uneTechnologie_web_dynamique;
            this.Deploiement_serveur = uneDeploiement_serveur;
            this.Big_data = uneBig_data;
            this.Arduino = uneArduino;
            this.Projet = uneProjet;
            this.Livret_de_suivi = uneLivret_de_suivi;

        }
    }
}
