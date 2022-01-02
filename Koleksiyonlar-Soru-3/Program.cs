using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string sesli = "aeıioöuü";

            ArrayList sesliHarfler = new ArrayList();
            ArrayList girilenSesliHarfler = new ArrayList();
            ArrayList Metin = new ArrayList();


            for (int i = 0; i < sesli.Length; i++)
            {
                sesliHarfler.Add(sesli[i]);
            }


            string metin = Console.ReadLine();

            for (int i = 0; i < metin.Length; i++)
            {
                Metin.Add(metin[i]);
            }

            foreach (var item in sesliHarfler)
            {
                if ( Metin.Contains(item)) { girilenSesliHarfler.Add(item); }                
            }

            sesliHarfler.Sort();

            foreach (var item in girilenSesliHarfler)
            {
                Console.WriteLine(item);
            }







        }
    }
}
