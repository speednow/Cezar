using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSK
{
    class Program
    {
        static void Main(string[] args)
        {
            string Szyfruj;
            string Deszyfruj;
            Szyfruj = Console.ReadLine().ToUpper();
            

            Console.WriteLine(Szyfr(Szyfruj));
            Deszyfruj = Console.ReadLine().ToUpper();

            Console.WriteLine(DeSzyfr(Deszyfruj));
            System.Console.Read();
        }
        static string Szyfr(String tekst)
        {
            char[] text = tekst.ToCharArray();
            int znak_p = 'A';
            int k = 26;
            int k1 = 11;
            int k0 = 17;

            for (int i = 0; i < text.Length; i++)

            {
                char szyfrowany = text[i];
                int a = szyfrowany - znak_p;
                int c = (a * k1 + k0) % k;

                char zaszyfrowanyID = (char)(znak_p + c);
                text[i] = zaszyfrowanyID;
            }

            return new string(text);

        }
        static string DeSzyfr(String tekst)
        {
            char[] text = tekst.ToCharArray();
            long znak_p = 'A';
            long k =  26;
            long k1 = 11;
            long k0 = 17;
            long ro = 12; 

            for (int i = 0; i<text.Length; i++)

            {
                char szyfrowany = text[i];
                long c = szyfrowany - znak_p;
                long a = ((c + (k - k0))*(long)Math.Pow(k1,ro-1)) % k;

                char zaszyfrowanyID = (char)(znak_p + a);
                text[i] = zaszyfrowanyID;
            }

            return new string (text);

        }
    }
}
