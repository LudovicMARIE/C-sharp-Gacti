using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace VVA
{
    public class Utilisateur
    {
        private string id;
        private int nbCommande;

        public Utilisateur(string unId, int nbCommande)
        {
            this.id = unId;
            this.nbCommande = nbCommande;
        }

        public string GetIdUtilisateur()
        {
            return this.id;
        }
        public int GetRemiseUtilisateur()
        {
            return this.nbCommande;
        }


        public override string ToString()
        {
            return this.id + " / " + this.nbCommande;
        }
    }
}
