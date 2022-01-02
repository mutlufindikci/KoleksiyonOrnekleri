using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            ArrayList numberList = new ArrayList();

            for (int i = 0; i < 5; i++)

            {
                n = Convert.ToInt32(Console.ReadLine());
                if (Int32.TryParse(n.ToString(), out int sayi)) numberList.Add(n);

            }

            int sum1 = 0;
            int sum2 = 0;
            double avg1 =0;
            double avg2=0;

            numberList.Reverse();
            Console.WriteLine("En Büyük 3 ");

            for (int i = 0; i < 3; i++) { Console.WriteLine(numberList[i].ToString()); sum1 += Convert.ToInt32(numberList[i].ToString()); }

            avg1 = Convert.ToDouble(sum1) / Convert.ToDouble(3);
            Console.WriteLine("Toplam : " + sum1.ToString());
            Console.WriteLine("Ortalama : "+avg1.ToString());
            Console.WriteLine("En Küçük 3 ");
            numberList.Sort();
            for (int j = 0; j < 3; j++) { Console.WriteLine(numberList[j].ToString()); sum2 += Convert.ToInt32(numberList[j].ToString()); }
            avg2 = Convert.ToDouble(sum2) / Convert.ToDouble(3);
            Console.WriteLine("Toplam : " + sum2.ToString());
            Console.WriteLine("Ortalama : "+avg2.ToString());

            Console.ReadKey();
        }
    }
}
