using ClassLibrary1.Model.Entities;
using displayProduit.ViewModels.common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.BusinessLayer;

namespace displayProduit.ViewModels
{
    /// <summary>
    /// ViewModel permettant de gérer une liste de DetailProduitViewModel
    /// Hérite de BaseViewModel
    /// </summary>
    public class ListeProduitViewModel : BaseViewModel
    {
        #region Variables

        private ObservableCollection<DetailProduitViewModel> _produits = null;
        private DetailProduitViewModel _selectedProduit;
        private string _search;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ListeProduitViewModel()
        {
            AlimenterProduits();
        }

        private void AlimenterProduits(string texte = "")
        {
            // on appelle le mock pour initialiser une liste de produits
            _produits = new ObservableCollection<DetailProduitViewModel>();
            List<Produit> result = null;

            if (string.IsNullOrWhiteSpace(texte))
            {
                result = Manager.Instance().GetListeProduit();
            }
            else
            {
                result = Manager.Instance().GetListeProduitByCode(texte);
            }

            foreach (Produit p in result)
            {
                _produits.Add(new DetailProduitViewModel(p));
            }

            if (_produits != null && _produits.Count > 0)
                _selectedProduit = _produits.ElementAt(0);
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Obtient ou définit une collection de DetailProduitViewModel (Observable)
        /// </summary>
        public ObservableCollection<DetailProduitViewModel> Produits
        {
            get { return _produits; }
            set
            {
                _produits = value;
                OnPropertyChanged("Produits");
            }
        }

        /// <summary>
        /// Obtient ou défini le produit en cours de sélection dans la liste de DetailProduitViewModel
        /// </summary>
        public DetailProduitViewModel SelectedProduit
        {
            get { return _selectedProduit; }
            set
            {
                _selectedProduit = value;
                OnPropertyChanged("SelectedProduit");
            }
        }

        public string Search
        {
            get { return _search; }
            set
            {
                _search = value;
                AlimenterProduits(_search);
                OnPropertyChanged("Search");
                OnPropertyChanged("Produits");
                OnPropertyChanged("SelectedProduit");

            }
        }

        #endregion
    }
}