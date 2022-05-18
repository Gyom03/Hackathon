using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hpost
{
    internal class Frigo
    {
        // attribut de la classe
        private int Temp;
        private int TimeConserv;

        //get et set
        public int GetTemp()
        {
            return Temp;
        }

        public void SetTemp(int value)
        {
            Temp = value;
        }

        public int GetTimeConserv()
        {
            return TimeConserv;
        }

        public void SetTimeConserv(int value)
        {
            TimeConserv = value;
        }
    }
}
