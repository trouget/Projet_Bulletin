using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projet_Bulletin
{
    class BDDConnection
    {

        private MySqlConnection connection;

        // Constructeur
        public BDDConnection()
        {
            this.InitConnexion();
        }

        // Méthode pour initialiser la connexion
        private void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=localhost; PORT=443; DATABASE=bdd_bulletinasi; UID=root; PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }

        // Méthode pour ajouter un eleves
        public void AddEleve(eleves eleve)
        {
            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "INSERT INTO eleves (id_eleve, Moyenne_annee1, Moyenne_annee2, nom, prenom, promotion, annee, obtention) VALUES (@id_eleve, @Moyenne_annee1, @Moyenne_annee2, @nom, @prenom, @promotion, @annee, @obtention)";

                // utilisation de l'objet eleves passé en paramètre
                cmd.Parameters.AddWithValue("@id_eleve", eleve.id_eleve);
                cmd.Parameters.AddWithValue("@Moyenne_annee1", eleve.Moyenne_annee1);
                cmd.Parameters.AddWithValue("@Moyenne_annee2", eleve.Moyenne_annee2);
                cmd.Parameters.AddWithValue("@nom", eleve.nom);
                cmd.Parameters.AddWithValue("@prenom", eleve.prenom);
                cmd.Parameters.AddWithValue("@promotion", eleve.promotion);
                cmd.Parameters.AddWithValue("@annee", eleve.annee);
                cmd.Parameters.AddWithValue("@obtention", eleve.obtention);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                this.connection.Close();
            }
            catch(MySqlException mse)
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le eleves à été ajouté correctement.
            }

        }

        // Suppresssion de l'année 2 
        public void DeleteEleve(eleves eleve)
        {
            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "DELETE from eleve where id_eleve = " + eleve.id_eleve + "  ";

            }
            catch (MySqlException mse)
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le eleves à été ajouté correctement.
            }
        }

        public void modifyEleve(eleves eleve)
        {
            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "UPDATE eleve SET id_eleve = @id_eleve, Moyenne_annee1 = @Moyenne_annee1,  Moyenne_annee2 = @Moyenne_annee2, nom = @nom, prenom = @prenom, promotion = @promotion, annee = @annee, obtention = @obtention) WHERE id_eleve = " + eleve.id_eleve + " ";

                // utilisation de l'objet eleves passé en paramètre
                cmd.Parameters.AddWithValue("@id_eleve", eleve.id_eleve);
                cmd.Parameters.AddWithValue("@Moyenne_annee1", eleve.Moyenne_annee1);
                cmd.Parameters.AddWithValue("@Moyenne_annee2", eleve.Moyenne_annee2);
                cmd.Parameters.AddWithValue("@nom", eleve.nom);
                cmd.Parameters.AddWithValue("@prenom", eleve.prenom);
                cmd.Parameters.AddWithValue("@promotion", eleve.promotion);
                cmd.Parameters.AddWithValue("@annee", eleve.annee);
                cmd.Parameters.AddWithValue("@obtention", eleve.obtention);
            }
            catch (MySqlException mse)
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le eleves à été ajouté correctement.
            }

        }


        public void AddAnnee1(annee1 annee1)
            {
            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO annee1 (id_bulletin1, Moyenne1, Administration_réseau, Anglais_technique, Base_de_données, Communication_écrite, Conception_et_modélisation, Controle_de_Gestion, Gestion_de_projet, Infrastructure_et_scripting, JSE, Securite, Systeme_open_source, Systeme_proprietaire, Technologie_web_dynamique, Droit_informatique, Framework_web, Outils_mathematiques, Livret_de_suivi, Management) VALUE (@id_bulletin1, @Moyenne1, @Administration_réseau, @Anglais_technique, @Base_de_données, @Communication_écrite, @Conception_et_modélisation, @Controle_de_Gestion, @Gestion_de_projet, @Infrastructure_et_scripting, @JSE, @Securite, @Systeme_open_source, @Systeme_proprietaire, @Technologie_web_dynamique, @Droit_informatique, @Framework_web, @Outils_mathematiques, @Livret_de_suivi, @Management)";

                // utilisation de l'objet annee1 passé en paramètre
                cmd.Parameters.AddWithValue("@id_bulletin1", annee1.id_bulletin1);
                cmd.Parameters.AddWithValue("@Moyenne1", annee1.Moyenne1);
                cmd.Parameters.AddWithValue("@Administration_réseau", annee1.Administration_réseau);
                cmd.Parameters.AddWithValue("@Anglais_technique", annee1.Anglais_technique);
                cmd.Parameters.AddWithValue("@Base_de_données", annee1.Base_de_données);
                cmd.Parameters.AddWithValue("@Communication_écrite", annee1.Communication_écrite);
                cmd.Parameters.AddWithValue("@Conception_et_modélisation", annee1.Conception_et_modélisation);
                cmd.Parameters.AddWithValue("@Controle_de_Gestion", annee1.Controle_de_gestion);
                cmd.Parameters.AddWithValue("@Gestion_de_projet", annee1.Gestion_de_projet);
                cmd.Parameters.AddWithValue("@Infrastructure_et_scripting", annee1.Infrastructure_et_scripting);
                cmd.Parameters.AddWithValue("@JSE", annee1.JSE);
                cmd.Parameters.AddWithValue("@Securite", annee1.Securite);
                cmd.Parameters.AddWithValue("@Systeme_open_source", annee1.Systeme_open_source);
                cmd.Parameters.AddWithValue("@Systeme_proprietaire", annee1.Systeme_proprietaire);
                cmd.Parameters.AddWithValue("@Technologie_web_dynamique", annee1.Technologie_web_dynamique);
                cmd.Parameters.AddWithValue("@Droit_informatique", annee1.Droit_informatique);
                cmd.Parameters.AddWithValue("@Framework_web", annee1.Framework_web);
                cmd.Parameters.AddWithValue("@Outils_mathematiques", annee1.Outils_informatique);
                cmd.Parameters.AddWithValue("@Livret_de_suivi", annee1.Livret_de_suivi);
                cmd.Parameters.AddWithValue("@Management", annee1.Management);
            }
            catch(MySqlException mse)
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le eleves à été ajouté correctement.
            }

        }

        // Suppresssion de l'année 2 
        public void DeleteAnnee1(annee1 annee1)
        {
            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "DELETE from annee1 where id_bulletin1 = " + annee1.id_bulletin1 + "  ";

            }
            catch (MySqlException mse)
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le eleves à été ajouté correctement.
            }
        }

        public void modifyAnnee1(annee1 annee1)
        {
            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "UPDATE annee1 SET id_bulletin1 = @id_bulletin1, Moyenne1 = @Moyenne1, Administration_réseau = @Administration_réseau, Anglais_technique = @Anglais_technique, Base_de_données = @Base_de_données, Communication_écrite = @Communication_écrite, Conception_et_modélisation = @Conception_et_modélisation, Controle_de_gestion = @Controle_de_gestion, Gestion_de_projet = @Gestion_de_projet, Infrastructure_et_scripting = @Infrastructure_et_scripting, JSE = @JSE,  Droit_informatique = @Droit_informatique, Infrastructure_et_scripting = @Infrastructure_et_scripting, Outils_mathematiques = @Outils_mathematiques, Securite = @Securite, Systeme_open_source = @Systeme_open_source, Systeme_proprietaire = @Systeme_proprietaire, Technologie_web_dynamique = @Technologie_web_dynamique, Framework_web = @Framework_web, Livret_de_Suivi = @Livret_de_Suivi, Management = @Management) WHERE id_bulletin1 = " + annee1.id_bulletin1 + " ";

                // utilisation de l'objet annee1 passé en paramètre
                cmd.Parameters.AddWithValue("@id_bulletin1", annee1.id_bulletin1);
                cmd.Parameters.AddWithValue("@Moyenne1", annee1.Moyenne1);
                cmd.Parameters.AddWithValue("@Administration_réseau", annee1.Administration_réseau);
                cmd.Parameters.AddWithValue("@Anglais_technique", annee1.Anglais_technique);
                cmd.Parameters.AddWithValue("@Base_de_données", annee1.Base_de_données);
                cmd.Parameters.AddWithValue("@Communication_écrite", annee1.Communication_écrite);
                cmd.Parameters.AddWithValue("@Conception_et_modélisation", annee1.Conception_et_modélisation);
                cmd.Parameters.AddWithValue("@Controle_de_Gestion", annee1.Controle_de_gestion);
                cmd.Parameters.AddWithValue("@Gestion_de_projet", annee1.Gestion_de_projet);
                cmd.Parameters.AddWithValue("@Infrastructure_et_scripting", annee1.Infrastructure_et_scripting);
                cmd.Parameters.AddWithValue("@JSE", annee1.JSE);
                cmd.Parameters.AddWithValue("@Securite", annee1.Securite);
                cmd.Parameters.AddWithValue("@Systeme_open_source", annee1.Systeme_open_source);
                cmd.Parameters.AddWithValue("@Systeme_proprietaire", annee1.Systeme_proprietaire);
                cmd.Parameters.AddWithValue("@Technologie_web_dynamique", annee1.Technologie_web_dynamique);
                cmd.Parameters.AddWithValue("@Droit_informatique", annee1.Droit_informatique);
                cmd.Parameters.AddWithValue("@Framework_web", annee1.Framework_web);
                cmd.Parameters.AddWithValue("@Outils_mathematiques", annee1.Outils_informatique);
                cmd.Parameters.AddWithValue("@Livret_de_suivi", annee1.Livret_de_suivi);
                cmd.Parameters.AddWithValue("@Management", annee1.Management);
            }
            catch (MySqlException mse)
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le eleves à été ajouté correctement.
            }

        }

        public void AddAnnee2(annee2 annee2)
        {
            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "INSERT INTO annee2 (id_bulletin2, Moyenne2, Administration_réseau, Anglais_technique, Application_hybride, Droit_informatique, Infrastructure_et_scripting, JEE, Outils_mathematiques, Suivi_de_projet, Securite, Systeme_open_source, Systeme_proprietaire, Technologie_web_dynamique, Deploiement_serveur, Big_data, Arduino, Projet, Livret_de_Suivi) VALUE (@id_bulletin2, @Moyenne2, @Administration_réseau, @Anglais_technique, @Application_hybride, @Droit_informatique, @Infrastructure_et_scripting, @JEE, @Outils_mathematiques, @Suivi_de_projet, @Securite, @Systeme_open_source, @Systeme_proprietaire, @Technologie_web_dynamique, @Deploiement_serveur, @Big_data, @Arduino, @Projet, @Livret_de_Suivi";

                // utilisation de l'objet annee2 passé en paramètre
                cmd.Parameters.AddWithValue("@id_bulletin2", annee2.id_bulletin2);
                cmd.Parameters.AddWithValue("@Moyenne2", annee2.Moyenne2);
                cmd.Parameters.AddWithValue("@Administration_réseau", annee2.Administration_reseau);
                cmd.Parameters.AddWithValue("@Anglais_technique", annee2.Anglais_technique);
                cmd.Parameters.AddWithValue("@Application_hybride", annee2.Application_hybride);
                cmd.Parameters.AddWithValue("@Droit_informatique", annee2.Droit_informatique);
                cmd.Parameters.AddWithValue("@Infrastructure_et_scripting", annee2.Infrastructure_et_scripting);
                cmd.Parameters.AddWithValue("@JEE", annee2.JEE);
                cmd.Parameters.AddWithValue("@Outils_mathematiques", annee2.Outils_Mathematiques);
                cmd.Parameters.AddWithValue("@Suivi_de_projet", annee2.Suivi_de_projet);
                cmd.Parameters.AddWithValue("@Securite", annee2.Securite);
                cmd.Parameters.AddWithValue("@Systeme_open_source", annee2.Systeme_open_source);
                cmd.Parameters.AddWithValue("@Systeme_proprietaire", annee2.Systeme_proprietaire);
                cmd.Parameters.AddWithValue("@Technologie_web_dynamique", annee2.Technologie_web_dynamique);
                cmd.Parameters.AddWithValue("@Deploiement_serveur", annee2.Deploiement_serveur);
                cmd.Parameters.AddWithValue("@Big_data", annee2.Big_data);
                cmd.Parameters.AddWithValue("@Arduino", annee2.Arduino);
                cmd.Parameters.AddWithValue("@Projet", annee2.Projet);
                cmd.Parameters.AddWithValue("@Livret_de_Suivi", annee2.Livret_de_suivi);
            }
            catch(MySqlException mse)
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le eleves à été ajouté correctement.
            }
        }


        // Suppresssion de l'année 2 
        public void DeleteAnnee2(annee2 annee2)
        {
            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "DELETE from annee2 where id_bulletin2 = " +annee2.id_bulletin2 + "  ";

            }
            catch (MySqlException mse)
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le eleves à été ajouté correctement.
            }
        }

        public void modifyAnnee2(annee2 annee2)
        {
            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                cmd.CommandText = "UPDATE annee2 SET id_bulletin2 = @id_bulletin, Moyenne2 = @Moyenne2, Administration_réseau = @Administration_réseau, Anglais_technique = @Anglais_technique, Application_hybride = @Application_hybride, Droit_informatique = @Droit_informatique, Infrastructure_et_scripting = @Infrastructure_et_scripting, JEE = @JEE, Outils_mathematiques = @Outils_mathematiques, Suivi_de_projet = @Suivi_de_projet, Securite = @Securite, Systeme_open_source = @Systeme_open_source, Systeme_proprietaire = @Systeme_proprietaire, Technologie_web_dynamique = @Technologie_web_dynamique, Deploiement_serveur = @Deploiement_serveur, Big_data = @Big_data, Arduino = @Arduino, Projet = @Projet, Livret_de_Suivi = @Livret_de_Suivi) WHERE id_bulletin2 = " + annee2.id_bulletin2 + " ";

                // utilisation de l'objet annee2 passé en paramètre
                cmd.Parameters.AddWithValue("@id_bulletin2", annee2.id_bulletin2);
                cmd.Parameters.AddWithValue("@Moyenne2", annee2.Moyenne2);
                cmd.Parameters.AddWithValue("@Administration_réseau", annee2.Administration_reseau);
                cmd.Parameters.AddWithValue("@Anglais_technique", annee2.Anglais_technique);
                cmd.Parameters.AddWithValue("@Application_hybride", annee2.Application_hybride);
                cmd.Parameters.AddWithValue("@Droit_informatique", annee2.Droit_informatique);
                cmd.Parameters.AddWithValue("@Infrastructure_et_scripting", annee2.Infrastructure_et_scripting);
                cmd.Parameters.AddWithValue("@JEE", annee2.JEE);
                cmd.Parameters.AddWithValue("@Outils_mathematiques", annee2.Outils_Mathematiques);
                cmd.Parameters.AddWithValue("@Suivi_de_projet", annee2.Suivi_de_projet);
                cmd.Parameters.AddWithValue("@Securite", annee2.Securite);
                cmd.Parameters.AddWithValue("@Systeme_open_source", annee2.Systeme_open_source);
                cmd.Parameters.AddWithValue("@Systeme_proprietaire", annee2.Systeme_proprietaire);
                cmd.Parameters.AddWithValue("@Technologie_web_dynamique", annee2.Technologie_web_dynamique);
                cmd.Parameters.AddWithValue("@Deploiement_serveur", annee2.Deploiement_serveur);
                cmd.Parameters.AddWithValue("@Big_data", annee2.Big_data);
                cmd.Parameters.AddWithValue("@Arduino", annee2.Arduino);
                cmd.Parameters.AddWithValue("@Projet", annee2.Projet);
                cmd.Parameters.AddWithValue("@Livret_de_Suivi", annee2.Livret_de_suivi);
            }
            catch (MySqlException mse)
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le eleves à été ajouté correctement.
            }
        }

        public List<eleves> tableauBDDAccueil()
        {
            List<eleves> els = new List<eleves>();

            // Ouverture de la connexion SQL
            this.connection.Open();

            // Création d'une commande SQL en fonction de l'objet connection
            MySqlCommand cmd = this.connection.CreateCommand();

            cmd.CommandText = "SELECT Moyenne_annee1, Moyenne_annee2, nom, prenom, promotion, annee, obtention FROM eleves";
            MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                eleves e = new eleves(Convert.ToInt32(mySqlDataReader["Moyenne_annee1"]), Convert.ToInt32(mySqlDataReader["Moyenne_annee2"]), mySqlDataReader["nom"].ToString(), mySqlDataReader["prenom"].ToString(), mySqlDataReader["promotion"].ToString(), DateTime.Parse((mySqlDataReader["annee"]).ToString()), Convert.ToInt32(mySqlDataReader["obtention"]));
                els.Add(e);
            }
            connection.Close();
            return els;
        } 
    }
}
