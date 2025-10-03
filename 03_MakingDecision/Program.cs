using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if else

            //Console.WriteLine("Lütfen şifre giriniz");
            //string password;
            //password = Console.ReadLine();

            //if (password == "1234") 
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}



            //string capital, country;
            //Console.WriteLine("Başkenti giriniz");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi giriniz");
            //country = Console.ReadLine();

            //if (capital=="ankara" & country=="türkiye")
            //{
            //    Console.WriteLine("Veriler doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı veri");
            //}


            //int number;
            //Console.WriteLine("Sayıyı giriniz");
            //number = int.Parse(Console.ReadLine());
            //if (number==5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış");
            //}


            //int exam1, exam2, exam3, average;
            //string result ="";

            //Console.Write("Sınav 1 : ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2 : ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3 : ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması : " + average);

            //Console.WriteLine(result);



            //string city;
            //Console.Write("Lütfen şehir giriniz : ");
            //city = Console.ReadLine();

            //if (city=="adana" | city == "istanbul" | city == "ankara" | city == "bursa")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}


            //Console.Write("Kullanıcı adı giriniz : ");
            //string username;
            //username = Console.ReadLine();

            //if (username!="admin")
            //{
            //    Console.WriteLine("Hatalı kullanıcı adı");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}
            #endregion


            #region Mod işlemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.WriteLine("1. Sayıyı giriniz : ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. Sayıyı giriniz : ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number % number2;
            //Console.WriteLine("1. Sayının 2. Sayıya bölümünden kalan : "+result);


            //Console.Write("Lütfen sayıyı giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());

            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}
            #endregion

            #region Char değişkenleriyle karar yapıları
            //char team ;
            //Console.Write("Lütfen takım sembolünü giriniz (F/G/B) : ");
            //team = char.Parse(Console.ReadLine());

            //if (team=='F' | team=='f')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team=='G' | team == 'g') 
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'B' | team == 'b')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** CSharp Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("----------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("----------------------");

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi : ");
            //menuItem = Console.ReadLine();

            //if (menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasulye Pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Ezogelin Çorbası");
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Pizzalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Akdeniz Pizza");
            //    Console.WriteLine("2- Margaritha");
            //    Console.WriteLine("3- Tavuklu");
            //    Console.WriteLine("----------Pizzalar----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Ayran");
            //    Console.WriteLine("3- Su");
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Triliçe");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Sütlaç");
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //}
            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız : ");
            //int monthNumber;
            //monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber) 
            //{
            //    case 1:Console.Write("Ocak"); break;
            //    case 2:Console.Write("Şubat"); break;
            //    case 3:Console.Write("Mart"); break;
            //    case 4:Console.Write("Nisan"); break;
            //    case 5:Console.Write("Mayıs"); break;
            //    case 6:Console.Write("Haziran"); break;
            //    case 7:Console.Write("Temmuz"); break;
            //    case 8:Console.Write("Ağustos"); break;
            //    case 9:Console.Write("Eylül"); break;
            //    case 10:Console.Write("Ekim"); break;
            //    case 11:Console.Write("Kasım"); break;
            //    case 12:Console.Write("Aralık"); break;
            //    default:Console.Write("Hatalı veri girişi");break;

            //}
            #endregion

            #region Hesap Makinesi

            //int number1, number2, number3, result;
            //char symbol;

            //Console.Write("1. Sayıyı giriniz : ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sayıyı giriniz : ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Yapmak istediğiniz işlemi giriniz(+,-,/,*) : ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol) 
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Sayıların toplamı : " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Sayıların farkı : " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Sayıların çarpımı : " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Sayıların bölümü : " + result);
            //        break;
            //}

            #endregion

            Console.Read();
        }
    }
}
