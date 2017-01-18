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
            Heros Sephiroth = new Heros();
            Heros Barrett = new Heros();
            Heros Tifa = new Heros();

            Clad.affichernom();
            Sephiroth.affichernom();
            Barrett.affichernom();
            Tifa.affichernom();
        }
    }
}
