using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Collections;
using static VVA.Session;
using Org.BouncyCastle.Asn1.X500;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Input;
using System.Data.SqlClient;
using System.Data.Common;

namespace VVA
{
    public static class ORMVVA
    {
        private static MySqlConnection conn = null;



        public static bool Connexion()
        {
            string sConnexion = @"server=localhost;userid=root;password=;database=vva";
            conn = new MySqlConnection(sConnexion);
            conn.Open();
            return (conn.State == System.Data.ConnectionState.Open);

        }
        public static bool Deconnexion()
        {
            conn.Close();
            return (conn.State == System.Data.ConnectionState.Closed);
        }

        public static string ConnexionUtilisateur(string nom, string pass)
        {
            string typeU = "Unknown";
            string query = "SELECT `Id_UTILISATEUR`, `PasswordUtilisateur`,`TypeUtilisateur`,`NomUtilisateur`,`PrenomUtilisateur` FROM `utilisateur` WHERE Id_UTILISATEUR='" + nom + "' and PasswordUtilisateur= sha2('" + pass + "',512)";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;

            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    typeU = rdr.GetString("TypeUtilisateur");
                    Session.Instance.Username = rdr.GetString("Id_UTILISATEUR");
                    Session.Instance.PrenomUtilisateur = rdr.GetString("PrenomUtilisateur");
                    Session.Instance.NomUtilisateur = rdr.GetString("NomUtilisateur");
                }
            }
            return typeU;
        }
        public static void DeconnexionUtilisateur()
        {
            Session.Instance.Username = "";
            Session.Instance.PrenomUtilisateur = "";
            Session.Instance.NomUtilisateur = "";
        }

        public static List<object> GetEtats()
        {
            List<object> etats = new List<object>();

            string query = "SELECT id_ETAT, NomEtat FROM type_etat";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    int idEtat = rdr.GetInt32("id_ETAT");
                    string nomEtat = rdr.GetString("NomEtat");
                    etats.Add(new { Id = idEtat, Nom = nomEtat });

                    
                }
            }

            return etats;
        }

        public static List<string> GetClientsCommande()
        {
            List<string> clients = new List<string>();

            string query = "SELECT DISTINCT Id_UTILISATEUR FROM commande";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    string id = rdr.GetString("Id_UTILISATEUR");
                    clients.Add(id);


                }
            }

            return clients;
        }


        public static string GetEtatCommandeLabel(int unEtat)
        {
            string etat ="";
            string query = "SELECT id_ETAT, NomEtat FROM type_etat WHERE id_ETAT="+unEtat+"";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    int idEtat = rdr.GetInt32("id_ETAT");
                    etat = rdr.GetString("NomEtat");
                }
            }

            return etat;
        }

        public static List<object> GetCategories()
        {
            List<object> categories = new List<object>();

            string query = "SELECT `Id_CATEGORIE`, `NomCategorie` FROM `categorie`";
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    int idCategorie = rdr.GetInt32("Id_CATEGORIE");
                    string nomCategorie = rdr.GetString("NomCategorie");
                    categories.Add(new { Id = idCategorie, Nom = nomCategorie });


                }
            }

            return categories;
        }

        public static List<Panier> GetTousLesPaniers(string recherche)
        {
            List<Panier> panierList = new List<Panier>();
            string query;
            if(recherche == ""){
                query = "SELECT `Id_PANIER`, `NomPanier`, `PrixPanier`, `DescriptionPanier`, `Id_CATEGORIE` FROM `panier`";
            }
            else
            {
                query = "SELECT `Id_PANIER`, `NomPanier`, `PrixPanier`, `DescriptionPanier`, `Id_CATEGORIE` FROM `panier` WHERE LOWER(NomPanier) LIKE LOWER('%" + recherche+ "%') OR LOWER(DescriptionPanier) LIKE LOWER('%" + recherche+ "%')";
            }
                


            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    int id = rdr.GetInt32("Id_PANIER");
                    string nom = rdr.GetString("NomPanier");
                    double prix = rdr.GetDouble("PrixPanier");
                    string desc = rdr.GetString("DescriptionPanier");
                    int categorie = rdr.GetInt32("Id_CATEGORIE");


                    Panier panier = new Panier(id, nom, prix, desc, categorie);
                    panierList.Add(panier);
                }
            }
            return panierList;
        }

        public static Panier GetPanierModif(int IdPanier)
        {
            string query;
            query = "SELECT `Id_PANIER`, `NomPanier`, `PrixPanier`, `DescriptionPanier`, `Id_CATEGORIE` FROM `panier` WHERE Id_Panier="+IdPanier+"";
            int id=0;
            string nom="";
            double prix=0;
            string desc = "";
            int categorie=0;


            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    id = rdr.GetInt32("Id_PANIER");
                    nom = rdr.GetString("NomPanier");
                    prix = rdr.GetDouble("PrixPanier");
                    desc = rdr.GetString("DescriptionPanier");
                    categorie = rdr.GetInt32("Id_CATEGORIE");
                }
            }
            Panier panier = new Panier(id, nom, prix, desc, categorie);
            return panier;
        }


        public static List<Commande> GetPanierCommander(string recherche,int etat)
        {
            List<Commande> commandeList = new List<Commande>();
            string query;
            if (etat == 0)
            {
                if (recherche == "")
                {
                    //query = "SELECT `Id_PANIER`, `NomPanier`, `PrixPanier`, `DescriptionPanier`, `Id_CATEGORIE` FROM `panier`";
                    query = "SELECT panier.Id_PANIER, NomPanier, PrixPanier, DescriptionPanier, Id_CATEGORIE, commande.Id_COMMANDE, commande.DateCommande, commande.id_ETAT, commande.Id_Utilisateur FROM `commande` INNER JOIN type_etat ON commande.id_ETAT = type_etat.id_ETAT INNER JOIN panier ON commande.Id_PANIER = panier.Id_PANIER WHERE commande.Id_UTILISATEUR = '" + Session.Instance.Username + "'";
                }
                else
                {
                    //query = "SELECT `Id_PANIER`, `NomPanier`, `PrixPanier`, `DescriptionPanier`, `Id_CATEGORIE` FROM `panier` WHERE LOWER(NomPanier) LIKE LOWER('%" + recherche + "%') OR LOWER(DescriptionPanier) LIKE LOWER('%" + recherche + "%')";
                    query = "SELECT panier.Id_PANIER, NomPanier, PrixPanier, DescriptionPanier, Id_CATEGORIE, commande.Id_COMMANDE, commande.DateCommande, commande.id_ETAT, commande.Id_Utilisateur FROM `commande` INNER JOIN type_etat ON commande.id_ETAT = type_etat.id_ETAT INNER JOIN panier ON commande.Id_PANIER = panier.Id_PANIER WHERE (commande.Id_UTILISATEUR = '" + Session.Instance.Username + "') AND (LOWER(NomPanier) LIKE LOWER('%" + recherche + "%') OR LOWER(DescriptionPanier) LIKE LOWER('%" + recherche + "%'))";
                }
            }
            else
            {
                if (recherche == "")
                {
                    //query = "SELECT `Id_PANIER`, `NomPanier`, `PrixPanier`, `DescriptionPanier`, `Id_CATEGORIE` FROM `panier`";
                    query = "SELECT panier.Id_PANIER, NomPanier, PrixPanier, DescriptionPanier, Id_CATEGORIE, commande.Id_COMMANDE, commande.DateCommande, commande.id_ETAT, commande.Id_Utilisateur FROM `commande` INNER JOIN type_etat ON commande.id_ETAT = type_etat.id_ETAT INNER JOIN panier ON commande.Id_PANIER = panier.Id_PANIER WHERE commande.Id_UTILISATEUR = '" + Session.Instance.Username + "' AND commande.id_ETAT = " + etat;
                }
                else
                {
                    //query = "SELECT `Id_PANIER`, `NomPanier`, `PrixPanier`, `DescriptionPanier`, `Id_CATEGORIE` FROM `panier` WHERE LOWER(NomPanier) LIKE LOWER('%" + recherche + "%') OR LOWER(DescriptionPanier) LIKE LOWER('%" + recherche + "%')";
                    query = "SELECT panier.Id_PANIER, NomPanier, PrixPanier, DescriptionPanier, Id_CATEGORIE, commande.Id_COMMANDE, commande.DateCommande, commande.id_ETAT, commande.Id_Utilisateur FROM `commande` INNER JOIN type_etat ON commande.id_ETAT = type_etat.id_ETAT INNER JOIN panier ON commande.Id_PANIER = panier.Id_PANIER WHERE (commande.Id_UTILISATEUR = '" + Session.Instance.Username + "') AND (commande.id_ETAT = " + etat + ") AND (LOWER(NomPanier) LIKE LOWER('%" + recherche + "%') OR LOWER(DescriptionPanier) LIKE LOWER('%" + recherche + "%'))";
                }
            }





            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    int id = rdr.GetInt32("Id_PANIER");
                    string nom = rdr.GetString("NomPanier");
                    double prix = rdr.GetDouble("PrixPanier");
                    string desc = rdr.GetString("DescriptionPanier");
                    int categorie = rdr.GetInt32("Id_CATEGORIE");
                    int idCommande = rdr.GetInt32("Id_COMMANDE");
                    DateTime dateCommande = rdr.GetDateTime("DateCommande");
                    int etatCommande = rdr.GetInt32("id_ETAT");
                    string id_Utilisateur = rdr.GetString("Id_Utilisateur");

                    Commande commande = new Commande(id, nom, prix, desc, categorie, idCommande, dateCommande, etatCommande, id_Utilisateur);
                    commandeList.Add(commande);
                }
            }
            return commandeList;
        }


        public static List<Commande> GetPanierCommanderAdmin(string recherche, int etat, string unClient)
        {
            List<Commande> commandeList = new List<Commande>();
            string query;
            if(unClient != "")
            {
                if (etat == 0)
                {
                    if (recherche == "")
                    {
                        //query = "SELECT `Id_PANIER`, `NomPanier`, `PrixPanier`, `DescriptionPanier`, `Id_CATEGORIE` FROM `panier`";
                        query = "SELECT panier.Id_PANIER, NomPanier, PrixPanier, DescriptionPanier, Id_CATEGORIE, commande.Id_COMMANDE, commande.DateCommande, commande.id_ETAT, commande.Id_Utilisateur FROM `commande` INNER JOIN type_etat ON commande.id_ETAT = type_etat.id_ETAT INNER JOIN panier ON commande.Id_PANIER = panier.Id_PANIER WHERE commande.Id_Utilisateur = '"+unClient+"'";
                    }
                    else
                    {
                        //query = "SELECT `Id_PANIER`, `NomPanier`, `PrixPanier`, `DescriptionPanier`, `Id_CATEGORIE` FROM `panier` WHERE LOWER(NomPanier) LIKE LOWER('%" + recherche + "%') OR LOWER(DescriptionPanier) LIKE LOWER('%" + recherche + "%')";
                        query = "SELECT panier.Id_PANIER, NomPanier, PrixPanier, DescriptionPanier, Id_CATEGORIE, commande.Id_COMMANDE, commande.DateCommande, commande.id_ETAT, commande.Id_Utilisateur FROM `commande` INNER JOIN type_etat ON commande.id_ETAT = type_etat.id_ETAT INNER JOIN panier ON commande.Id_PANIER = panier.Id_PANIER WHERE (commande.Id_Utilisateur = '"+unClient+"') AND (LOWER(NomPanier) LIKE LOWER('%" + recherche + "%') OR LOWER(DescriptionPanier) LIKE LOWER('%" + recherche + "%'))";
                    }
                }
                else
                {
                    if (recherche == "")
                    {
                        //query = "SELECT `Id_PANIER`, `NomPanier`, `PrixPanier`, `DescriptionPanier`, `Id_CATEGORIE` FROM `panier`";
                        query = "SELECT panier.Id_PANIER, NomPanier, PrixPanier, DescriptionPanier, Id_CATEGORIE, commande.Id_COMMANDE, commande.DateCommande, commande.id_ETAT, commande.Id_Utilisateur FROM `commande` INNER JOIN type_etat ON commande.id_ETAT = type_etat.id_ETAT INNER JOIN panier ON commande.Id_PANIER = panier.Id_PANIER WHERE commande.Id_Utilisateur = '"+unClient+"' AND commande.id_ETAT = " + etat;
                    }
                    else
                    {
                        //query = "SELECT `Id_PANIER`, `NomPanier`, `PrixPanier`, `DescriptionPanier`, `Id_CATEGORIE` FROM `panier` WHERE LOWER(NomPanier) LIKE LOWER('%" + recherche + "%') OR LOWER(DescriptionPanier) LIKE LOWER('%" + recherche + "%')";
                        query = "SELECT panier.Id_PANIER, NomPanier, PrixPanier, DescriptionPanier, Id_CATEGORIE, commande.Id_COMMANDE, commande.DateCommande, commande.id_ETAT, commande.Id_Utilisateur FROM `commande` INNER JOIN type_etat ON commande.id_ETAT = type_etat.id_ETAT INNER JOIN panier ON commande.Id_PANIER = panier.Id_PANIER WHERE (commande.Id_Utilisateur = '"+unClient+"') AND(commande.id_ETAT = " + etat + ") AND (LOWER(NomPanier) LIKE LOWER('%" + recherche + "%') OR LOWER(DescriptionPanier) LIKE LOWER('%" + recherche + "%'))";
                    }
                }
            }
            else
            {
                if (etat == 0)
                {
                    if (recherche == "")
                    {
                        //query = "SELECT `Id_PANIER`, `NomPanier`, `PrixPanier`, `DescriptionPanier`, `Id_CATEGORIE` FROM `panier`";
                        query = "SELECT panier.Id_PANIER, NomPanier, PrixPanier, DescriptionPanier, Id_CATEGORIE, commande.Id_COMMANDE, commande.DateCommande, commande.id_ETAT, commande.Id_Utilisateur FROM `commande` INNER JOIN type_etat ON commande.id_ETAT = type_etat.id_ETAT INNER JOIN panier ON commande.Id_PANIER = panier.Id_PANIER ";
                    }
                    else
                    {
                        //query = "SELECT `Id_PANIER`, `NomPanier`, `PrixPanier`, `DescriptionPanier`, `Id_CATEGORIE` FROM `panier` WHERE LOWER(NomPanier) LIKE LOWER('%" + recherche + "%') OR LOWER(DescriptionPanier) LIKE LOWER('%" + recherche + "%')";
                        query = "SELECT panier.Id_PANIER, NomPanier, PrixPanier, DescriptionPanier, Id_CATEGORIE, commande.Id_COMMANDE, commande.DateCommande, commande.id_ETAT, commande.Id_Utilisateur FROM `commande` INNER JOIN type_etat ON commande.id_ETAT = type_etat.id_ETAT INNER JOIN panier ON commande.Id_PANIER = panier.Id_PANIER WHERE (LOWER(NomPanier) LIKE LOWER('%" + recherche + "%') OR LOWER(DescriptionPanier) LIKE LOWER('%" + recherche + "%'))";
                    }
                }
                else
                {
                    if (recherche == "")
                    {
                        //query = "SELECT `Id_PANIER`, `NomPanier`, `PrixPanier`, `DescriptionPanier`, `Id_CATEGORIE` FROM `panier`";
                        query = "SELECT panier.Id_PANIER, NomPanier, PrixPanier, DescriptionPanier, Id_CATEGORIE, commande.Id_COMMANDE, commande.DateCommande, commande.id_ETAT, commande.Id_Utilisateur FROM `commande` INNER JOIN type_etat ON commande.id_ETAT = type_etat.id_ETAT INNER JOIN panier ON commande.Id_PANIER = panier.Id_PANIER WHERE commande.id_ETAT = " + etat;
                    }
                    else
                    {
                        //query = "SELECT `Id_PANIER`, `NomPanier`, `PrixPanier`, `DescriptionPanier`, `Id_CATEGORIE` FROM `panier` WHERE LOWER(NomPanier) LIKE LOWER('%" + recherche + "%') OR LOWER(DescriptionPanier) LIKE LOWER('%" + recherche + "%')";
                        query = "SELECT panier.Id_PANIER, NomPanier, PrixPanier, DescriptionPanier, Id_CATEGORIE, commande.Id_COMMANDE, commande.DateCommande, commande.id_ETAT, commande.Id_Utilisateur FROM `commande` INNER JOIN type_etat ON commande.id_ETAT = type_etat.id_ETAT INNER JOIN panier ON commande.Id_PANIER = panier.Id_PANIER WHERE (commande.id_ETAT = " + etat + ") AND (LOWER(NomPanier) LIKE LOWER('%" + recherche + "%') OR LOWER(DescriptionPanier) LIKE LOWER('%" + recherche + "%'))";
                    }
                }
            }





            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    int id = rdr.GetInt32("Id_PANIER");
                    string nom = rdr.GetString("NomPanier");
                    double prix = rdr.GetDouble("PrixPanier");
                    string desc = rdr.GetString("DescriptionPanier");
                    int categorie = rdr.GetInt32("Id_CATEGORIE");
                    int idCommande = rdr.GetInt32("Id_COMMANDE");
                    DateTime dateCommande = rdr.GetDateTime("DateCommande");
                    int etatCommande = rdr.GetInt32("id_ETAT");
                    string id_Utilisateur = rdr.GetString("Id_Utilisateur");

                    Commande commande = new Commande(id, nom, prix, desc, categorie, idCommande, dateCommande, etatCommande,id_Utilisateur);
                    commandeList.Add(commande);
                }
            }
            return commandeList;
        }


        public static List<Utilisateur> GetListUser()
        { 
            List<Utilisateur> UserList = new List<Utilisateur>();

            string query = "SELECT COUNT(commande.Id_COMMANDE) AS nbCommandes, utilisateur.Id_UTILISATEUR " +
                "FROM utilisateur " +
                "INNER JOIN commande ON commande.Id_UTILISATEUR = utilisateur.Id_UTILISATEUR " +
                "GROUP BY utilisateur.Id_UTILISATEUR";

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    string id = rdr.GetString("Id_UTILISATEUR");
                    int nbCommande = rdr.GetInt32("nbCommandes");

                    Utilisateur user = new Utilisateur(id, nbCommande);
                    UserList.Add(user);
                }
            }

            return UserList;
        
        }


            public static void AjouterPanier(string unNom, double unPrix, string uneDesc, int uneCatégorie)
        {
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                string query = "INSERT INTO `panier` (`Id_PANIER`, `NomPanier`, `PrixPanier`, `DescriptionPanier`, `Id_CATEGORIE`) VALUES (NULL, '"+ unNom + "', '"+unPrix+"', '"+uneDesc+"', '"+uneCatégorie+"');";
                cmd.CommandText = query;

                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine("Rows affected: " + rowsAffected);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void ModifierPanier(int unId, string unNom, double unPrix, string uneDesc, int uneCatégorie)
        {
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                string query = "UPDATE `panier` SET `NomPanier` = '"+ unNom + "', `PrixPanier` = '"+ unPrix + "', `DescriptionPanier` = '"+uneDesc+"', `Id_CATEGORIE` = '"+uneCatégorie+"' WHERE `panier`.`Id_PANIER` = "+unId;
                cmd.CommandText = query;

                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine("Rows affected: " + rowsAffected);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }



        public static void Commander(Panier unPanier)
        {
            double unPrix;
            int nbCommandes = 0;
            int remise = 0;
            try
            {
                MySqlCommand cmd1 = conn.CreateCommand();
                string query1 = "SELECT COUNT(commande.Id_COMMANDE) AS nbCommandes, utilisateur.Id_UTILISATEUR FROM commande INNER JOIN utilisateur ON utilisateur.Id_UTILISATEUR = commande.Id_UTILISATEUR WHERE utilisateur.Id_UTILISATEUR = '"+Session.Instance.Username+"'";
                cmd1.CommandText = query1;
                using (MySqlDataReader rdr = cmd1.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        nbCommandes = rdr.GetInt32("nbCommandes");
                        Console.WriteLine("Nombre de commandes : " + nbCommandes);
                    }
                }

                MySqlCommand cmd2 = conn.CreateCommand();
                string query2 = "SELECT `Id_UTILISATEUR`, `RemiseUtilisateur` FROM `utilisateur` WHERE Id_UTILISATEUR = '" + Session.Instance.Username + "'";
                cmd2.CommandText = query2;
                using (MySqlDataReader rdr = cmd2.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        remise = rdr.GetInt32("RemiseUtilisateur");
                        Console.WriteLine("Valeur remise : " + remise.ToString());
                    }
                }

                if (nbCommandes >= 3)
                {
                    double prixPanier = unPanier.GetPrixPanier();
                    Console.WriteLine("Remise : " + Convert.ToString((remise / 100.0)));
                    unPrix = prixPanier - (prixPanier * (remise / 100.0));

                    Console.WriteLine("Prix commande remisé : "+unPrix.ToString());
                }
                else
                {
                    unPrix = unPanier.GetPrixPanier();
                    Console.WriteLine("Prix commande sans remise : " + unPrix.ToString());
                }


                MySqlCommand cmd = conn.CreateCommand();
                DateTime today = DateTime.Today;
                string current_date = today.ToString("yyyy-MM-dd");
                string query = "INSERT INTO `commande` (`Id_COMMANDE`, `DateCommande`, `id_ETAT`, `Id_PANIER`,`PrixCommande`, `Id_UTILISATEUR`) VALUES (NULL, '"+ current_date + "', 1, '"+unPanier.GetId_Panier()+ "',"+unPrix+", '"+Session.Instance.Username+"');";

                cmd.CommandText = query;

                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine("Rows affected: " + rowsAffected);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static double GetPrixCommande()
        {
            double prix = 0;
            MySqlCommand cmd1 = conn.CreateCommand();
            string query1 = "SELECT PrixCommande FROM commande INNER JOIN utilisateur ON utilisateur.Id_UTILISATEUR = commande.Id_UTILISATEUR WHERE utilisateur.Id_UTILISATEUR = '" + Session.Instance.Username + "'";
            cmd1.CommandText = query1;
            using (MySqlDataReader rdr = cmd1.ExecuteReader())
            {
                while (rdr.Read())
                {
                    prix = rdr.GetInt32("nbCommandes");
                    Console.WriteLine("Nombre de commandes : " + prix);
                }
            }
            return prix;
        }

        public static void AnnulerCommande(Commande uneCommande)
        {
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                string query = "DELETE FROM `commande` WHERE Id_PANIER ='" + uneCommande.GetId_Panier() + "' AND Id_UTILISATEUR='" + uneCommande.GetId_Utilisateur() + "'";
                cmd.CommandText = query;

                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine("Rows affected: " + rowsAffected);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        public static void PayerCommande(Commande uneCommande)
        {
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                //string query = "DELETE FROM `commande` WHERE Id_PANIER ='" + uneCommande.GetId_Panier() + "' AND Id_UTILISATEUR='" + Session.Instance.Username + "'";
                string query = "UPDATE `commande` SET `id_ETAT`=2 WHERE Id_PANIER ='" + uneCommande.GetId_Panier() + "' AND Id_UTILISATEUR='" + Session.Instance.Username + "'";
                cmd.CommandText = query;

                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine("Rows affected: " + rowsAffected);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static void PreparerCommande(Commande uneCommande)
        {
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                //string query = "DELETE FROM `commande` WHERE Id_PANIER ='" + uneCommande.GetId_Panier() + "' AND Id_UTILISATEUR='" + Session.Instance.Username + "'";
                string query = "UPDATE `commande` SET `id_ETAT`=3 WHERE Id_PANIER ='" + uneCommande.GetId_Panier() + "' AND Id_UTILISATEUR='" + uneCommande.GetId_Utilisateur() + "'";
                cmd.CommandText = query;

                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine("Rows affected: " + rowsAffected);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        public static bool IsCommander(Panier unPanier)
        {
            int counter = 10;
            MySqlCommand cmd = conn.CreateCommand();
            string query = "SELECT COUNT(Id_COMMANDE) AS NBCOMMANDES FROM `commande` WHERE Id_PANIER ='"+ unPanier.GetId_Panier() + "' AND Id_UTILISATEUR=\""+Session.Instance.Username+"\"";
            cmd.CommandText = query;
            using (MySqlDataReader rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    counter = rdr.GetInt32("NBCOMMANDES");
                }
            }
            if (counter == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public static Dictionary<string, string> VoirProfil(string unUser)
        {
            Dictionary<string, string> userProfile = new Dictionary<string, string>();
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                string query = "SELECT `Id_UTILISATEUR`, `NomUtilisateur`, `PrenomUtilisateur`, `DateNaissanceUtilisateur`, `MailUtilisateur`, `TelUtilisateur` FROM `utilisateur` WHERE Id_UTILISATEUR='" + unUser+"'";

                cmd.CommandText = query;

                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        userProfile.Add("NomUtilisateur", rdr.GetString("NomUtilisateur"));
                        userProfile.Add("PrenomUtilisateur", rdr.GetString("PrenomUtilisateur"));
                        userProfile.Add("DateNaissanceUtilisateur", rdr.GetDateTime("DateNaissanceUtilisateur").ToString("dd-MM-yyyy"));
                        userProfile.Add("MailUtilisateur", rdr.GetString("MailUtilisateur"));
                        userProfile.Add("TelUtilisateur", rdr.GetString("TelUtilisateur"));
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return userProfile;
        }


        public static void ModifierProfil(string idUtilisateur, string nomUtilisateur, string prenomUtilisateur, DateTime dateNaissanceUtilisateur, string mailUtilisateur, string telUtilisateur)
        {
            try
            {
                string formattedDate = dateNaissanceUtilisateur.ToString("yyyy-MM-dd");
                MySqlCommand cmd = conn.CreateCommand();
                string query = "UPDATE `utilisateur` SET `NomUtilisateur` = @nomUtilisateur, `PrenomUtilisateur` = @prenomUtilisateur, `DateNaissanceUtilisateur` = @dateNaissanceUtilisateur, `MailUtilisateur` = @mailUtilisateur, `TelUtilisateur` = @telUtilisateur WHERE `Id_UTILISATEUR` = @idUtilisateur";
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@idUtilisateur", idUtilisateur);
                cmd.Parameters.AddWithValue("@nomUtilisateur", nomUtilisateur);
                cmd.Parameters.AddWithValue("@prenomUtilisateur", prenomUtilisateur);
                cmd.Parameters.AddWithValue("@dateNaissanceUtilisateur", formattedDate);
                cmd.Parameters.AddWithValue("@mailUtilisateur", mailUtilisateur);
                cmd.Parameters.AddWithValue("@telUtilisateur", telUtilisateur);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


    }
}
