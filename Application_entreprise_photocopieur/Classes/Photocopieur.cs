using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_entreprise_photocopieur.Classes
{
    internal class Photocopieur
    {
        #region attribut
        private static int _photocopieuridGlobal = 0;
        private int _id = 0;
        private string _marque;
        private string _model;
        private bool _enPanne;
        #endregion
        #region getter / setter
        public int Id { get => _id; }
        public string Marque { get => _marque; }
        public string Model { get => _model; }
        public bool EnPanne { get => _enPanne; set => _enPanne = value; }
        #endregion
        #region Constructeur
        public Photocopieur(string marque, string model)
        {
            _id = _photocopieuridGlobal++;
            _marque = marque;
            _model = model;
            _enPanne = false;
        }
        #endregion
    }
}
