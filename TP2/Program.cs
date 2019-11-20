using System;

namespace TP2
{
    class Compte
    {
        public string nom;
        public string prenom;

        public struct dateNaissance
        {

        }

        public string identifiant;
        public string password;
        public string mail;
        public int nbConnexion;
        public string profil;

        public static void printInfo()
        {

        }

        public static void editInfo()
        {

        }

        public static void changerPassword()
        {

        }
    }
    class Donnees
    {
        public string compte;
        public int userConnected;

        public static void changePassword()
        {

        }

        public static void exportData()
        {

        }

        public static void importData()
        {

        }

        public static void connect()
        {

        }

        public static void disconnect()
        {

        }
    }

    class Security
    {
        public string initialDictionnary;
        public string cryptDictionnary;
        public string keyCrypt;

        public static void cryptDictionnaryGen()
        {

        }

        public static void crypt()
        {

        }

        public static void decrypt()
        {

        }
    }
    class Program
    {
        public static Compte compte;

        static void connexion()
        {
            Console.WriteLine("Connexion");
            Console.WriteLine("Appuyer pour continuer");
            Console.ReadKey();
            Console.Clear();
        }

        static void inscription()
        {
            Console.WriteLine("Inscription");
            Console.WriteLine("Appuyer pour continuer");
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Connexion");
                Console.WriteLine("2. Inscription");
                Console.WriteLine("3. Quitter");
                char key = Console.ReadKey().KeyChar;
                switch (key)
                {
                    case '1':
                        Console.Clear();
                        connexion();
                        break;
                    case '2':
                        Console.Clear();
                        inscription();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
