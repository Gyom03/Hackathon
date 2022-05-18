using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hpost
{
    internal class Animal
    {
        // attribut de la classe
        private int NombreTêtes;
        private string TypeAnimal;

        //get et set
        public int GetNombreTêtes()
        {
            return NombreTêtes;
        }

        public void SetNombreTêtes(int value)
        {
            NombreTêtes = value;
        }

        public string GetTypeAnimal()
        {
            return TypeAnimal;
        }

        public void SetTypeAnimal(string value)
        {
            TypeAnimal = value;
        }

        public Animal(int nombreTete, string typeAnimal)
        {
            SetNombreTêtes(nombreTete);
            SetTypeAnimal(typeAnimal);
        }
    }
}
