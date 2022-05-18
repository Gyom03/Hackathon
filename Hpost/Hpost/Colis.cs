using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hpost
{
    internal class Colis
    {
        // attribut de la classe
        private int NumCommande;
        private int Poids;
        private int Prix;
        private int Volume;
        private string NomEnvoyeur;
        private int EmplacementX;
        private int EmplacementY;
        private bool LivraisonExpress;
        private string DeliveryAdress;
        private object Image;
        private bool Special;
        private string State;

        //get et set
        public int GetNumCommande()
        {
            return GetNumCommande();
        }

        public void SetNumCommande(int value)
        {
            SetNumCommande(value);
        }

        public int GetPoids()
        {
            return GetPoids();
        }

        public void SetPoids(int value)
        {
            SetPoids(value);
        }

        public int GetPrix()
        {
            return GetPrix();
        }

        public void SetPrix(int value)
        {
            SetPrix(value);
        }

        public int GetVolume()
        {
            return GetVolume();
        }

        public void SetVolume(int value)
        {
            SetVolume(value);
        }

        public string GetNomEnvoyeur()
        {
            return GetNomEnvoyeur();
        }

        public void SetNomEnvoyeur(string value)
        {
            SetNomEnvoyeur(value);
        }

        public int GetEmplacementX()
        {
            return GetEmplacementX();
        }

        public void SetEmplacementX(int value)
        {
            SetEmplacementX(value);
        }

        public int GetEmplacementY()
        {
            return GetEmplacementY();
        }

        public void SetEmplacementY(int value)
        {
            SetEmplacementY(value);
        }

        public bool GetLivraisonExpress()
        {
            return GetLivraisonExpress();
        }

        public void SetLivraisonExpress(bool value)
        {
            SetLivraisonExpress(value);
        }

        public string GetDeliveryAdress()
        {
            return GetDeliveryAdress();
        }

        public void SetDeliveryAdress(string value)
        {
            SetDeliveryAdress(value);
        }

        public object GetImage()
        {
            return GetImage();
        }

        public void SetImage(object value)
        {
            SetImage(value);
        }

        public bool GetSpecial()
        {
            return GetSpecial();
        }

        public void SetSpecial(bool value)
        {
            SetSpecial(value);
        }

        public string GetState()
        {
            return GetState();
        }

        public void SetState(string value)
        {
            SetState(value);
        }

        //constructeur
        public Colis(int poids, int prix, int volume, string nomEnvoyeur, bool livraisonExpress, string deliveryAdress, object image, bool special)
        {
            SetDeliveryAdress(deliveryAdress);
            SetLivraisonExpress(livraisonExpress);
            SetImage(image);
            SetNomEnvoyeur(nomEnvoyeur);
            SetPoids(poids);
            SetSpecial(special);
            SetVolume(volume);
            SetPrix(prix);
        }


    }
}
