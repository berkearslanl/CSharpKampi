using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For döngüsü
            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 3; i <= 50; i += 3) 
            //{
            //    Console.WriteLine(i);
            //}


            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz : ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}
            #endregion

            #region For döngüsü ile karar yapıları

            //for (int i = 0; i <=100; i++)
            //{
            //    if (i % 5 == 0)
            //        Console.WriteLine(i);

            //}


            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("-----------");
            //Console.WriteLine(totalValue);


            //int count = 0;

            //for(int i = 1; i<=50; i++)
            //{
            //    if(i %7==0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);


            //1-2-4-8-16-32...

            //int bakteri = 1;

            //for (int i = 1; i <= 24; i++) //saati tutuyor
            //{
            //    bakteri *= 2;
            //    Console.WriteLine(i + ". Saat Sonunda: " + bakteri);
            //}

            #endregion

            #region While döngüsü

            /*
                 while(şart)
                   {
                       işlemler
                   }
            */

            //int i = 1;
            //while (i <= 10) 
            //{
            //    Console.WriteLine("Merhaba döngüler");
            //    i++;
            //}


            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Örnek Soru
            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            Console.Write("Sayıyı Giriniz : ");
            int number = int.Parse(Console.ReadLine());
            int birler, onlar, yüzler, toplam;

            birler = number % 10; //456 % 10 = 6
            onlar = (number % 100) / 10;
            yüzler = number / 100; //456 / 100 = 4.56 int olduğu için ==> 4

            Console.WriteLine(birler + "-" + onlar + "-" + yüzler);

            toplam = birler + onlar + yüzler;
            Console.WriteLine(toplam);

            #endregion










            Console.Read();
        }
    }
}
