using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_entreprise_photocopieur.Classes
{
    internal class ClientDeEntreprise
    {
        #region attribut
        private static int _clientIdGlobal = 0;
        private int _id = 0;
        private string _nom;
        private string _prenom;
        private string _ville;
        private string _rue;
        private int _numeroDeRue;
        private int _departement;
        private List<Photocopieur> _photocopieursLoué;
        #endregion
        #region getter / setter
        public int Id { get => _id; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Ville { get => _ville; set => _ville = value; }
        public string Rue { get => _rue; set => _rue = value; }
        public int NumeroDeRue { get => _numeroDeRue; set => _numeroDeRue = value; }
        public int Departement { get => _departement; set => _departement = value; }
        internal List<Photocopieur>? PhotocopieursLoué { get => _photocopieursLoué; set => _photocopieursLoué = value; }
        #endregion
        #region Constructeur
        public ClientDeEntreprise(string nom, string prenom, string ville, string rue, int numeroDeRue, int departement, List<Photocopieur>? photocopieursLoué)
        {
            _id = _clientIdGlobal++;
            Nom = nom;
            Prenom = prenom;
            Ville = ville;
            Rue = rue;
            NumeroDeRue = numeroDeRue;
            Departement = departement;
            PhotocopieursLoué = photocopieursLoué;
        }
        #endregion
    }
}
