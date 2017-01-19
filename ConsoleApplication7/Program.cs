using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {

            Heros Clad = new Heros();
            Clad.setprenom(" Clad ");
            Clad.setnom(" Strife ");
            Clad.setage(22);
            Clad.setlevel(1);
            Clad.setclasse("Soldier");

            Heros Sephiroth = new Heros();
            Sephiroth.setprenom(" Sephiroth ");
            Sephiroth.setnom("Inconnu");
            Sephiroth.setage(99);
            Sephiroth.setlevel(30);
            Sephiroth.setclasse("Inconnu");

            Heros Barrett = new Heros();
            Barrett.setprenom(" Barrett ");
            Barrett.setnom(" Wallace ");
            Barrett.setage(35);
            Barrett.setlevel(1);
            Barrett.setclasse("Avalanche");
        
            Heros Tifa = new Heros();
            Tifa.setprenom(" Tifa ");
            Tifa.setnom(" Lockheart ");
            Tifa.setage(21);
            Tifa.setlevel(1);
            Tifa.setclasse("Avalanche");

            Clad.afficheridentite();
            Sephiroth.afficheridentite();
            Barrett.afficheridentite();
            Tifa.afficheridentite();
           
        }
    }
}
