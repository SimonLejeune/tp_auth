using System;
using System.Collections.Generic;

namespace TP2
{
    class Program
    {
        public static Donnees donnees = new Donnees();
        public static List<Compte> comptes = new List<Compte>();

        static void inscription()
        {
            Random random = new Random();
            Compte compte = new Compte();
            string password = "";
            Console.WriteLine("Inscription");
            Console.Write("Nom: ");
            compte.Nom = Console.ReadLine();
            Console.Write("Prenom: ");
            compte.Prenom = Console.ReadLine();
            Console.Write("Adresse Mail: ");
            compte.Mail = Console.ReadLine();
            Console.Write("Mot de passe: ");
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                // Backspace Should Not Work
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                    {
                        password = password.Substring(0, (password.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("");
                        break;
                    }
                }
            } while (true);
            compte.Password = password;
            int num = random.Next(1000, 9999);
            compte.Identifiant += compte.Nom.ToLower().Substring(0, 3);
            compte.Identifiant += compte.Prenom.ToLower().Substring(0, 3);
            compte.Identifiant += num;
            comptes.Add(compte);
            Console.WriteLine("Appuyer pour continuer");
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            comptes = donnees.importData();
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
                        donnees.connect(comptes);
                        break;
                    case '2':
                        Console.Clear();
                        inscription();
                        break;
                    case '3':
                        Console.Write("Sauvegarde en cours");
                        donnees.exportData(comptes);
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
