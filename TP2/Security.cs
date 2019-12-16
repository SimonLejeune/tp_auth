using System;
using System.Linq;

namespace TP2
{
    public class Security
    {
        public Security()
        {
        }

        string initialDictionnary;
        string cryptDictionnary;
        string keyCrypt;

        void cryptDictionnaryGen()
        {
            Console.WriteLine("cryptDictionnaryGen");
        }

        public string crypt(string password)
        {
            int key = 42;
            key = key % 37;
            string parag = password.ToUpper();
            char[] text = parag.ToCharArray();
            int j = text.Length - 1;
            int k = alpha.Length - 1;
            char[] text3 = new char[text.Length];
            for (int i = 0; i <= j; i++)
            {
                char text2 = text[i];
                int n = Array.IndexOf(alpha, text2);
                int f = n + key;
                if (f > k)
                {
                    f = f - k;
                }
                text3[i] = alpha[f];
            }
            string fin = new string(text3);
            return(fin);
        }

        public string decrypt(string password)
        {
            int key = 42;
            key = key % 37;
            string parag = password.ToUpper();
            char[] text = parag.ToCharArray();
            int j = text.Length - 1;
            int k = alpha.Length - 1;
            char[] text3 = new char[text.Length];
            for (int i = 0; i <= j; i++)
            {
                char text2 = text[i];
                int n = Array.IndexOf(alpha, text2);
                int f = n - key;
                if (f < 0)
                {
                    f = f + k;
                }
                text3[i] = alpha[f];
            }
            string fin = new string(text3);
            return (fin.ToLower());
        }
        static char[] alpha = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '5', '6', '7', '8', '9', '0', ' ', '.', ',', '?' };
    }
}
