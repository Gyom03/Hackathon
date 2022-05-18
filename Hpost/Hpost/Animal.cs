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
        private string TypeFood;
        private int PoidsFood;

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

        public string GetTypeFood()
        {
            return TypeFood;
        }

        public void SetTypeFood(string value)
        {
            TypeFood = value;
        }

        public int GetPoidsFood()
        {
            return PoidsFood;
        }

        public void SetPoidsFood(int value)
        {
            PoidsFood = value;
        }
    }
}
