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
            string connectionString = "SERVER=127.0.0.1; DATABASE=bdd_bulletinsasi; UID=root; PASSWORD=";
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
            catch
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le eleves à été ajouté correctement.
            }
        }
    }
}
