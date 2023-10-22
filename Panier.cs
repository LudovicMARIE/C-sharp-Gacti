using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVA
{
    public class Panier
    {
        private int id_Panier;
        private string NomPanier;
        private double PrixPanier;
        private string DescriptionPanier;
        private int Id_Categorie;

        public Panier(int unId,string unNom,double unPrix,string uneDesc,int uneCategorie)
        {
            this.id_Panier = unId;
            this.NomPanier = unNom;
            this.PrixPanier = unPrix;
            this.DescriptionPanier = uneDesc;
            this.Id_Categorie = uneCategorie;
        }

        public override string ToString()
        {
            return NomPanier + " / " + PrixPanier +"€" + " / " + DescriptionPanier;
        }

        public int GetId_Panier()
        {
            return id_Panier;
        }

        public string GetNomPanier()
        {
            return NomPanier;
        }

        public double GetPrixPanier()
        {
            return PrixPanier;
        }

        public string GetDescriptionPanier()
        {
            return DescriptionPanier;
        }

        public int GetId_Categorie()
        {
            return Id_Categorie;
        }

    } 
}
