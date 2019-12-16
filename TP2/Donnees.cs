using System;
using System.IO;
using System.Collections.Generic;

namespace TP2
{
    public class Donnees
    {
        public Donnees()
        {
        }

        public int userConnected;

        public void changePassword(Compte compte)
        {
            string newPassword = "";
            Console.Write("Nouveau mot de passe :");
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
                        newPassword = newPassword.Substring(0, (newPassword.Length - 1));
                        Console.Write("\b \b");
                    }
                    else if (key.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("");
                        break;
                    }
                }
            } while (true);
            compte.Password = newPassword;
        }

        public void exportData(List<Compte> comptes)
        {
            using (StreamWriter stream = new StreamWriter("data.csv"))
            {
                for (int i = 0; i < comptes.Count; i++)
                {
                    var newLine = string.Format("{0},{1},{2},{3},{4}", comptes[i].Nom, comptes[i].Prenom, comptes[i].Mail, comptes[i].Password, comptes[i].Identifiant);
                    stream.WriteLine(newLine);
                }
            }
        }

        public List<Compte> importData()
        {
            List<Compte> comptes = new List<Compte>();
            if (File.Exists("data.csv"))
            {
                using (StreamReader fluxlecture = File.OpenText("data.csv"))
                {
                    while (!fluxlecture.EndOfStream)
                    {
                        Compte compte = new Compte();
                        string line = fluxlecture.ReadLine();
                        string[] myLine = new string[5];
                        myLine = line.Split(",");
                        compte.Nom = myLine[0];
                        compte.Prenom = myLine[1];
                        compte.Mail = myLine[2];
                        compte.Password = myLine[3];
                        compte.Identifiant = myLine[4];
                        comptes.Add(compte);
                    }
                }
            }
            return comptes;
        }

        public void connect(List<Compte> comptes)
        {
            string addressMail;
            string password = "";
            Console.WriteLine("Connexion");
            Console.Write("Adresse mail: ");
            addressMail = Console.ReadLine();
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
            for (int i = 0; i < comptes.Count; i++)
            {
                if (comptes[i].Mail == addressMail)
                {
                    if (comptes[i].Password == password)
                    {
                        Console.WriteLine("Connexion success");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        comptes[i].NbConnexion += 1;
                        connectedMenu(comptes[i]);
                        break;
                    } else
                    {
                        Console.WriteLine("Bad password");
                    }
                }
            }
            Console.Clear();
        }

        public void disconnect()
        {
            Console.WriteLine("Disconnect");
        }

        public void connectedMenu(Compte compte)
        {
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("1. Print info");
                Console.WriteLine("2. Edit info");
                Console.WriteLine("3. Change password");
                Console.WriteLine("4. Disconnect");
                char key = Console.ReadKey().KeyChar;
                switch (key)
                {
                    case '1':
                        Console.Clear();
                        compte.printInfo();
                        break;
                    case '2':
                        Console.Clear();
                        compte.editInfo();
                        break;
                    case '3':
                        Console.Clear();
                        compte.changePassword();
                        break;
                    case '4':
                        Console.Clear();
                        disconnect();
                        exit = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
