using System;
using System.Collections.Generic;
using System.IO;
namespace TP2
{
    public class Donnees
    {
        public Donnees()
        {
        }

        public List<Compte> comptes;
        public int userConnected;

        public void changePassword()
        {
            string newPassword;
            Console.Write("Mot de passe :");
            newPassword = Console.ReadLine();
        }

        public void exportData()
        {
            using (StreamWriter stream = new StreamWriter("data.csv"))
            {
                for (int i = 0; i < comptes.Count; i++)
                {
                    var newLine = string.Format("{0},{1},{2},{3},{4}", comptes[i].Nom, comptes[i].Prenom, comptes[i].Mail, comptes[i].Password, comptes[i].Identifiant);
                    stream.Write(newLine);
                }
            }
        }

        public void importData()
        {
            if (File.Exists("data.csv"))
            {
                using (StreamReader fluxlecture = File.OpenText("data.csv"))
                {
                    while (!fluxlecture.EndOfStream)
                    {
                        string line = fluxlecture.ReadLine();
                        string[] myLine = new string[4];
                        myLine = line.Split(",");
                    }
                }
            }
        }

        public void connect()
        {
            Console.WriteLine("connect");
        }

        public void disconnect()
        {
            Console.WriteLine("Disconnect");
        }
    }
}
