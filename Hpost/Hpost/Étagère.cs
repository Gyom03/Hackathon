using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hpost
{
    internal class Étagère
    {
        // attribut de la classe
        private int PoidsMax;
        private int VolumeMax;
        private int Colonne;
        private int Ligne;
        private int PoidsTot;
        private int VolumeTot;

        //get et set
        public int GetLigne()
        {
            return GetLigne();
        }

        public void SetLigne(int value)
        {
            SetLigne(value);
        }

        public int GetColonne()
        {
            return GetColonne();
        }

        public void SetColonne(int value)
        {
            SetColonne(value);
        }

        public int GetVolumeMax()
        {
            return GetVolumeMax();
        }

        public void SetVolumeMax(int value)
        {
            SetVolumeMax(value);
        }

        public int GetPoidsMax()
        {
            return GetPoidsMax();
        }

        public void SetPoidsMax(int value)
        {
            SetPoidsMax(value);
        }
        public int GetPoidsTot()
        {
            return GetPoidsTot();
        }

        public void SetPoidsTot(int value)
        {
            SetPoidsTot(value);
        }
        public int GetVolumeTot()
        {
            return GetVolumeTot();
        }

        public void SetVolumeTot(int value)
        {
            SetVolumeTot(value);
        }

        //constructeur
        public Étagère(int poidsMax, int volumeMax, int colonne, int ligne, int poidstot,int volumetot)
        {
            SetColonne(colonne);
            SetLigne(ligne);
            SetPoidsMax(poidsMax);
            SetVolumeMax(volumeMax);
            SetPoidsTot(poidstot);
            SetVolumeTot(volumetot);
        }

        public void Remplissage(int poidstot, int poidsmax,int volumetot, int volumemax)
        {
            if (poidstot > poidsmax || volumetot > volumemax)
            {
                //Dire que le stockage est complet donc il faut changer d'étagère ou refuser l'envoi du colis
            }
            else
            {
                //ajouter le poids et le volume du nouveau colis
            }
        }
    }
}
