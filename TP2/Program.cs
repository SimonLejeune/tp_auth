using System;
using System.Collections.Generic;
using System.IO;

namespace TP2
{
    class Compte
    {
        string nom;
        string prenom;

        struct dateNaissance
        {
            public int jour;
            public int mois;
            public int annee;
        }

        string identifiant;
        string password;
        string mail;
        int nbConnexion;
        string profil;

        void printInfo()
        {
            Console.WriteLine($"{this.nom}");
            Console.WriteLine($"{this.prenom}");
            Console.WriteLine($"{this.identifiant}");
            Console.WriteLine($"{this.mail}");
        }

        void editInfo()
        {
            string newNom;
            string newPrenom;
            string newMail;
            Console.Write("Nom :");
            newNom = Console.ReadLine();
            Console.Write("Prenom : ");
            newPrenom = Console.ReadLine();
            Console.Write("Mail : ");
            newMail = Console.ReadLine();

            this.nom = newNom;
            this.prenom = newPrenom;
            this.mail = newMail;
        }

        void changerPassword()
        {
            string newPassword;
            Console.Write("Mot de passe");
            newPassword = Console.ReadLine();

            this.password = newPassword;
        }
    }

    class Donnees
    {
        Compte compte;
        int userConnected;

        void changePassword()
        {
            string newPassword;
            Console.Write("Mot de passe :");
            newPassword = Console.ReadLine();
        }

        void exportData()
        {
            using (StreamWriter stream = new StreamWriter("data.csv"))
            {
                //foreach (KeyValuePair<uint, Client> client in Data_Clients)
                //{
                //    stream.WriteLine($"{client.Key},{client.Value.nom},{client.Value.prenom},{client.Value.solde},{client.Value.depenses}");
                //}
            }
            Environment.Exit(0);
        }

        void importData()
        {
            Console.WriteLine("importData");
        }

        void connect()
        {
            Console.WriteLine("connect");
        }

        void disconnect()
        {
            Console.WriteLine("Disconnect");
        }
    }

    class Security
    {
        string initialDictionnary;
        string cryptDictionnary;
        string keyCrypt;

        void cryptDictionnaryGen()
        {
            Console.WriteLine("cryptDictionnaryGen");
        }

        void crypt()
        {
            Console.WriteLine("crypt");
        }

        void decrypt()
        {
            Console.WriteLine("decrypt");
        }
    }

    class Program
    {
        Compte compte;
        Donnees donnees;
        Security security;

        static void connexion()
        {
            string identifiant;
            string password;
            Console.WriteLine("Connexion");
            Console.Write($"Mail: ");
            identifiant = Console.ReadLine();
            Console.Write("Mot de passe: ");
            password = Console.ReadLine();
            Console.WriteLine("Appuyer pour continuer");
            Console.ReadKey();
            Console.Clear();
        }

        static void inscription()
        {
            string identifiant;
            string password;
            Console.WriteLine("Inscription");
            Console.Write($"Mail: ");
            identifiant = Console.ReadLine();
            Console.Write("Mot de passe: ");
            password = Console.ReadLine();
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
                    case '3':
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
