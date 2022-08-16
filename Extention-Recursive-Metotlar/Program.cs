using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extention_Recursive_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Recursive özyinelemeli metotlar
            //3^4 = 3*3*3*3


            int result = 1;
            for( int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);

            Console.WriteLine("***************************************************");

            Islemler ınstance = new Islemler();
            int sonuc = ınstance.Expo(3, 4);
            Console.WriteLine(sonuc);

            Console.WriteLine("******************************************************");

            //Extention Metotlar
            string ifade = "Yunus Emre Başer";
            bool sonuc2 = ifade.CheckSpaces();
            Console.WriteLine(sonuc2);
            if (sonuc2)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }

            Console.WriteLine("*****************************************************");

            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            Console.WriteLine("*****************************************************");

            int[] dizi = { 1, 5, 8, 6, 7, 9, 2 };
            dizi.SortedArray();
            dizi.EkranaYazdir();

            Console.WriteLine("*****************************************************");

            int sayi = 55;
            Console.WriteLine(sayi.isEvenNumber());

            Console.WriteLine("******************************************************");

            Console.WriteLine(ifade.GetFirstCharacter());




        }
    }

    class Islemler
    {
        public int Expo(int sayi, int üs)
        {
            if (üs < 2)
                return sayi;
            return Expo(sayi, üs - 1) * sayi;

            //Expo(3,4)
            //Expo(3,3) * 3
            //Expo(3,2) * 3 * 3
            //Expo(3,1) * 3 * 3 *3
            //3 * 3 * 3 * 3 = 3^4 = 81
        }
    }

    public static class Extention
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(' ');
            return string.Join("", dizi);

        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortedArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool isEvenNumber(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }
    }
}
