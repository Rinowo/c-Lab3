using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Atom
    {
        public int AtomN = 0;
        public string AtomSb;
        public string AtomFn;
        public float AtomW;

        public Atom(int AtomN, string AtomSb, string AtomFn, float AtomW)
        {
            this.AtomN = AtomN;
            this.AtomSb = AtomSb;
            this.AtomFn = AtomFn;
            this.AtomW = AtomW;
        }
        
        public Atom() { 
        }

        public void display()
        {
            Console.Write(AtomN + AtomSb + AtomFn + AtomW);
        }
    }

    
}
