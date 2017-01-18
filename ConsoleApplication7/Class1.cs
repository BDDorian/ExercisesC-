using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    // Ma classe que je veux mettre
    class Heros
    {
        private string nom;
        private string prenom;
        private int age;
        private short level;
        private string classe;
        private string race;

        //Constructeurs
     
        public Heros()
        {
            this.nom = "";
        }

        // Mutateurs

        public void setnom(string nom)
        {
            this.nom = nom;
        }


        // Accesseurs

        public string getnom()
        {
            return this.nom;
        }

        // Nos propres méthodes

        public void affichernom()
        {
            Console.WriteLine("Le nom du personnage  est:" + this.nom);
        }

    }
}
    