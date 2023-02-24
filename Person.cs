using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWinStilqn
{
    internal class Person
    {
        private string name;
        private string prezime;
        private string familiq;
        private int egn;
        private string pol;
        private string sfera;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Prezime
        { 
          get { return prezime; } 
          set { prezime = value; }
        }
        public string Familiq
        {
            get { return familiq; }
            set { familiq = value; }
        }
        public int Egn
        { 
            get { return egn; }
            set { egn = value; }
        }
        public string Pol
        {
            get { return pol; }
            set { pol = value; }
        }
        public string Sfera
        {
            get { return sfera; }
            set{ sfera = value;}
        }
    }
}
