using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dizilere giriş

            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü [ElemanSayısı] 

            //string[] colors = new string[4];

            //colors[0] = "Kırmızı";
            //colors[1] = "Mavi";
            //colors[2] = "Sarı";
            //colors[3] = "Beyaz";

            //Console.WriteLine(colors[2]);

            #endregion

            #region Örnekler

            //int[] numbers = { 4, 85, 96, 74, 125, 635, 488, 520, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //dizideki en büyük değeri bulma
            //int[] myArray = { 47, 85, 96, 25, 163, 854, 297, 816 };

            //int maxnumber = myArray[0];

            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i]>maxnumber)
            //    {
            //        maxnumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxnumber);
            #endregion

            #region Dizi metotları
            //sıralama
            //int[] members = { 85, 63, 25, 1, 54, 96, 378, 21 };
            //Array.Sort(members);
            //for(int i = 0; i < members.Length; i++)
            //{
            //    Console.WriteLine(members[i]);
            //}

            //diziyi tersten sıralama(yazılış sırasına göre)
            //int[] members = { 85, 63, 25, 1, 54, 96, 378, 21 };
            //Array.Reverse(members);
            //for (int i = 0; i < members.Length; i++)
            //{
            //    Console.WriteLine(members[i]);
            //}

            //istenilen değerin kaçıncı indexte olduğunu gösterir
            //string[] customer = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customer,"merve");

            //Console.WriteLine(index);

            //max ve min değerini bulma
            //int[] numbers = { 25, 16, 35, 27, 95, 123, 456, 6, 28 };
            //Console.WriteLine("En büyük eleman :"+numbers.Max() + " En küçük eleman :"+numbers.Min());

            #endregion

            #region Kullanıcıdan değer alma

            //string[] cities = new string[5];

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehri Giriniz : "); // dolar işareti "" arasında + ya gerek duymadan yazdırma yapar
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-----------------");
            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //dizideki elemanların toplamı
            //int[] numbers = { 10, 20, 30, 40, 50, 25, 25 };
            //int toplam = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    toplam += numbers[i];
            //}
            //Console.WriteLine(toplam);


            //dizideki tek ve çift sayıları ayrı ayrı alma

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };
            
            //Console.WriteLine("Çift sayılar");
            //Console.WriteLine("-------------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%2==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }    
            //}

            //Console.WriteLine();
            //Console.WriteLine("Tek sayılar");
            //Console.WriteLine("-------------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion



            Console.Read();
        }
    }
}
