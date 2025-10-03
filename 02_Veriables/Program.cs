using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.16;
            //Console.WriteLine(number);


            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fİyatı : " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fİyatı : " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fİyatı : " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fİyatı : " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fİyatı : " + tomatoPrice + " TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Alışverişin toplam tutarı : "+shoppingTotalPrice);

            #endregion

            #region Char Değişkenler
            // ''
            //char symbol;
            //symbol = 'B';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişleri String Değişkenleri


            //Console.WriteLine("**** CSarp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string ad, soyad, semt, sehir, yas, kimlik;
            //Console.Write("Yolcu Adı: ");
            //ad = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //soyad = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("----------------------");
            //Console.WriteLine("Yolcu : "+ad + " "+  soyad);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler 

            //int ayakkabi, pc, sandalye, tv;
            //ayakkabi = 1000;
            //pc = 20000;
            //sandalye = 5000;
            //tv = 12000;

            //int aAdet, pAdet, sAdet, tAdet;

            //Console.Write("Aldığınız ayakkabı adedini giriniz : ");
            //aAdet = int.Parse(Console.ReadLine());
            //Console.Write("Aldığınız pc adedini giriniz : ");
            //pAdet = int.Parse(Console.ReadLine());
            //Console.Write("Aldığınız sandalye adedini giriniz : ");
            //sAdet = int.Parse(Console.ReadLine());
            //Console.Write("Aldığınız tv adedini giriniz : ");
            //tAdet = int.Parse(Console.ReadLine());

            //int totalPrice = ayakkabi * aAdet + pc * pAdet + sandalye * sAdet + tv * tAdet;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar : "+totalPrice);




            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1. Sınav Notunu Giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunu Giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunu Giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalama : " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyetinizi Seçiniz(E/K) : ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet : " + gender);



            #endregion


            Console.Read();
        }
    }
}
