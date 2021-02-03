using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bulletin
{
    class annee1
    {
        public int id_bulletin1 { get; set; }
        public int Moyenne1 { get; set; }
        public int Administration_réseau { get; set; }
        public int Anglais_technique { get; set; }
        public int Base_de_données { get; set; }
        public int Communication_écrite { get; set; }
        public int Conception_et_modélisation { get; set; }
        public int Controle_de_gestion { get; set; }
        public int Gestion_de_projet { get; set; }
        public int Infrastructure_et_scripting { get; set; }
        public int JSE { get; set; }
        public int Securite { get; set; }
        public int Systeme_open_source { get; set; }
        public int Systeme_proprietaire { get; set; }
        public int Technologie_web_dynamique { get; set; }
        public int Droit_informatique { get; set; }
        public int Framework_web { get; set; }
        public int Outils_informatique { get; set; }
        public int Livret_de_suivi { get; set; }
        public int Management { get; set; }

        public annee1()
        {

        }

        public annee1(int uneMoyenne1, int uneAdministration_réseau, int uneAnglais_technique, int uneBase_de_données, int uneCommunication_écrite, int uneConception_et_modélisation, int uneControle_de_gestion, int uneGestion_de_projet, int uneInfrastructure_et_scripting, int uneJSE, int uneSecurite, int uneSysteme_open_source, int uneSysteme_proprietaire, int uneTechnologie_web_dynamique, int uneDroit_informatique, int uneFramework_web, int uneOutils_informatique, int uneLivret_de_suivi, int uneManagement)
        {
            this.Moyenne1 = uneMoyenne1;
            this.Administration_réseau = uneAdministration_réseau;
            this.Anglais_technique = uneAnglais_technique;
            this.Base_de_données = uneBase_de_données;
            this.Communication_écrite = uneCommunication_écrite;
            this.Conception_et_modélisation = uneConception_et_modélisation;
            this.Controle_de_gestion = uneControle_de_gestion;
            this.Gestion_de_projet = uneGestion_de_projet;
            this.Infrastructure_et_scripting = uneInfrastructure_et_scripting;
            this.JSE = uneJSE;
            this.Securite = uneSecurite;
            this.Systeme_open_source = uneSysteme_open_source;
            this.Systeme_proprietaire = uneSysteme_proprietaire;
            this.Technologie_web_dynamique = uneTechnologie_web_dynamique;
            this.Droit_informatique = uneDroit_informatique;
            this.Framework_web = uneFramework_web;
            this.Outils_informatique = uneOutils_informatique;
            this.Livret_de_suivi = uneLivret_de_suivi;
            this.Management = uneManagement;
        }
    }
}
