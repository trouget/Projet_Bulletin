using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Bulletin
{
    class annee1
    {
        public double id_bulletin1 { get; set; }
        public double Moyenne1 { get; set; }
        public double Administration_réseau { get; set; }
        public double Anglais_technique { get; set; }
        public double Base_de_données { get; set; }
        public double Communication_écrite { get; set; }
        public double Conception_et_modélisation { get; set; }
        public double Controle_de_gestion { get; set; }
        public double Gestion_de_projet { get; set; }
        public double Infrastructure_et_scripting { get; set; }
        public double JSE { get; set; }
        public double Securite { get; set; }
        public double Systeme_open_source { get; set; }
        public double Systeme_proprietaire { get; set; }
        public double Technologie_web_dynamique { get; set; }
        public double Droit_informatique { get; set; }
        public double Framework_web { get; set; }
        public double Outils_informatique { get; set; }
        public double Livret_de_suivi { get; set; }
        public double Management { get; set; }

        public annee1()
        {

        }

        public annee1(double uneMoyenne1, double uneAdministration_réseau, double uneAnglais_technique, double uneBase_de_données, double uneCommunication_écrite, double uneConception_et_modélisation, double uneControle_de_gestion, double uneGestion_de_projet, double uneInfrastructure_et_scripting, double uneJSE, double uneSecurite, double uneSysteme_open_source, double uneSysteme_proprietaire, double uneTechnologie_web_dynamique, double uneDroit_informatique, double uneFramework_web, double uneOutils_informatique, double uneLivret_de_suivi, double uneManagement)
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
