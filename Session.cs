using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VVA
{
    public class Session
    {
        private static Session _instance;

        private Session() { }

        public static Session Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Session();
                }
                return _instance;
            }
        }

        public string Username { get; set; }
        public string NomUtilisateur { get; set; }
        public string PrenomUtilisateur { get; set; }
    }
}
