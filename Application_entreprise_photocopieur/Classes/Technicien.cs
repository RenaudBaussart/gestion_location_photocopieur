using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application_entreprise_photocopieur.Classes
{
    internal class Technicien
    {
        public static int _techIdGlobal = 0;
        private int _id = 0;
        private string _nom;
        private string _prenom;
        private int _departementAction;

        public int Id { get => _id; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public int DepartementAction { get => _departementAction; set => _departementAction = value; }

        public Technicien(string nom, string prenom, int departementAction)
        {
            _id = _techIdGlobal++;
            Nom = nom;
            Prenom = prenom;
            DepartementAction = departementAction;
        }
    }
}
