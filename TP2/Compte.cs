using System;
namespace TP2
{
    public class Compte
    {
        public Compte()
        {
        }

        private string nom;
        public string Nom
        {
            get
            {
                return this.nom;
            }
            set
            {
                this.nom = value;
            }
        }

        private string prenom;
        public string Prenom
        {
            get
            {
                return this.prenom;
            }
            set
            {
                this.nom = value;
            }
        }

        public struct dateNaissance
        {
            public int jour;
            public int mois;
            public int annee;
        }

        private string identifiant;
        public string Identifiant
        {
            get
            {
                return this.identifiant;
            }
            set
            {
                this.identifiant = value;
            }
        }

        private string password;
        public string Password
        {
            get
            {
                return this.identifiant;
            }
            set
            {
                this.identifiant = value;
            }
        }

        private string mail;
        public string Mail
        {
            get
            {
                return this.mail;
            }
            set
            {
                this.mail = value;
            }
        }

        public int nbConnexion;
        public string profil;

        public void printInfo()
        {
            Console.WriteLine($"{this.nom}");
            Console.WriteLine($"{this.prenom}");
            Console.WriteLine($"{this.identifiant}");
            Console.WriteLine($"{this.mail}");
        }

        public void editInfo()
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

        public void changePassword()
        {
            string newPassword = "";
            Console.Write("Mot de passe");
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
                        newPassword = password.Substring(0, (newPassword.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("");
                        break;
                    }
                }
            } while (true);
            this.password = newPassword;
        }
    }
}
