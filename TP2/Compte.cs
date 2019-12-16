using System;
namespace TP2
{
    public class Compte
    {
        public Compte()
        {
        }

        public string Nom { get; set; }
        public string Prenom { get; set; }

        public struct dateNaissance
        {
            public int jour;
            public int mois;
            public int annee;
        }

        public string Identifiant { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public int NbConnexion { get; set; }

        public string profil;

        public void printInfo()
        {
            Console.WriteLine($"{this.Nom}");
            Console.WriteLine($"{this.Prenom}");
            Console.WriteLine($"{this.Identifiant}");
            Console.WriteLine($"{this.Mail}");
            Console.WriteLine("Appuyer pour continuer");
            Console.ReadKey();
            Console.Clear();
        }

        public void editInfo()
        {
            string newNom;
            string newPrenom;
            string newMail;
            Console.Write($"Nom ({this.Nom}) : ");
            newNom = Console.ReadLine();
            Console.Write($"Prenom ({this.Prenom}) : ");
            newPrenom = Console.ReadLine();
            Console.Write($"Mail ({this.Mail}) : ");
            newMail = Console.ReadLine();

            this.Nom = newNom;
            this.Prenom = newPrenom;
            this.Mail = newMail;
            Console.WriteLine("Appuyer pour continuer");
            Console.ReadKey();
            Console.Clear();
        }

        public void changePassword()
        {
            string newPassword = "";
            Console.Write("Mot de passe : ");
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                // Backspace Should Not Work
                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    newPassword += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && newPassword.Length > 0)
                    {
                        newPassword = Password.Substring(0, (newPassword.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("");
                        break;
                    }
                }
            } while (true);
            this.Password = newPassword;
            Console.WriteLine("Appuyer pour continuer");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
