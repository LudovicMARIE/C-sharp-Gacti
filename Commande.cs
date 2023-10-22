using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVA
{
    public class Commande : Panier
    {
        private int id_Commande;
        private DateTime dateCommande;
        private int etatCommande;
        private string id_Utilisateur;

        public Commande(int unId, string unNom, double unPrix, string uneDesc, int uneCategorie, int idCommande, DateTime dateCommande, int etatCommande, string id_Utilisateur)
            : base(unId, unNom, unPrix, uneDesc, uneCategorie)
        {
            this.id_Commande = idCommande;
            this.dateCommande = dateCommande;
            this.etatCommande = etatCommande;
            this.id_Utilisateur = id_Utilisateur;
        }

        //public double GetPrixCommande()
        //{
        //    return  
        //}

        public string GetId_Utilisateur() { return id_Utilisateur; }
        public int GetIdCommande(){  return id_Commande;}
        public DateTime GetDateCommande(){  return dateCommande;}
        public int GetEtatCommande(){  return etatCommande;}
        
        public override string ToString()
        {
            return this.GetNomPanier() + " / " + this.GetPrixPanier() + "€" + " / " + this.GetDescriptionPanier() + " / " + this.GetId_Utilisateur();
        }
    }
}
