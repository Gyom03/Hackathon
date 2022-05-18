using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hpost
{
    internal class User
    {
        //attribut
        private string _name;
        private string _password;
        //get set
        public string GetName()
        {
            return _name;
        }
        public void SetName(string value)
        {
            _name = value;
        }
        public string GetPassword()
        {
            return _password;
        }
        public void SetPassword(string value)
        {
            _password = value;
        }
        //constructeur
        public User(string nom, string mdp)
        {
            SetName(nom);
            SetPassword(mdp);
        }
    }
}
