using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int counter =0;

            ArrayList numberList = new ArrayList();
            ArrayList primeNumbers = new ArrayList();
            ArrayList Numbers = new ArrayList();

            for (int i=0;i<20;i++) 
            
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number>=0 && Int32.TryParse(number.ToString(),out int sayi)) numberList.Add(number);
                
            }
            foreach (var item in numberList) 
            {
                for (int j=2;j<Convert.ToInt32(item);j++)
                
                {
                    if (Convert.ToInt32(item) % j == 0) counter++;
                }

                if (counter>1) { Numbers.Add(Convert.ToInt32(item)); }
                else primeNumbers.Add(Convert.ToInt32(item));
                counter = 0;

            }


            Numbers.Sort();
            primeNumbers.Sort();

            Console.WriteLine("Asal Sayılar : ");
            foreach (var item in primeNumbers) Console.WriteLine(item.ToString());
            Console.WriteLine("Asal Olmayan Sayılar : ");
            Numbers.Sort();
            foreach (var item in Numbers) Console.WriteLine(item.ToString());
            Console.ReadKey();
        }
    }
}
