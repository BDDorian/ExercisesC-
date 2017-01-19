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
            this.prenom = "";
            this.nom = "";
            this.age = 0;
            this.level = 0;
            this.classe = "";
        }

        // Mutateurs

        public void setprenom(string prenom)
        {
            this.prenom = prenom;
        }


        public void setnom(string nom)
        {
            this.nom = nom;
        }

        public void setage(int age)
        {
            this.age = age;
        }

        public void setlevel(short level)
        {
            this.level = level;
        }
        public void setclasse(string classe)
        {
            this.classe = classe;
        }



        // Accesseurs

        public string getprenom()
        {
            return this.prenom;
        }

        public void getnom(string nom)
        {
            this.nom = nom;
        }

        public void getage(int age)
        {
            this.age = age;
        }
        public void getlevel(short level)
        {
            this.level = level;
        }
        public void getclasse(string classe)
        {
            this.classe = classe;
        }

        // Nos propres méthodes



        public void afficheridentite()
        {
            Console.WriteLine("  L'identité du personnage est : " +this.prenom+ " , " +this.nom+ " et a : " +this.age+ ", Niveau: " +this.level+ ", et est un:" +this.classe);
        }
    }
}
    