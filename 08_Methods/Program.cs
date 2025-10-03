using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Geriye değer döndürmeyen metotlar

            //()
            //void

            //void CustomerList()
            //{
            //    Console.WriteLine("berke");
            //    Console.WriteLine("ali");
            //    Console.WriteLine("ahmet");
            //    Console.WriteLine("mehmet");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            #endregion

            #region Geriye değer döndürmeyen paremetreli metotlar

            //void yazdir(string name)
            //{
            //    Console.WriteLine(name);
            //}

            //yazdir("berke");


            //void customerCards(string name, string surName)
            //{
            //    Console.WriteLine($"Müşteri: {name} {surName}");
            //}

            //customerCards("berke", "arslan");
            //customerCards("mehmet", "kaplan");


            //void sum(int s1, int s2, int s3)
            //{
            //    int result = s1 + s2 + s3;
            //    Console.WriteLine(result);
            //}

            //sum(4, 5, 6);
            #endregion

            #region Geriye değer döndüren metotlar

            //string studentCard() 
            //{
            //    string name = "berke";
            //    string surname = "arslan";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(studentCard());
            #endregion

            #region Geriye değer döndüren parametreli metotlar

            //string countryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = $"Ülke {countryName} - Başkent {capital} - Bayrak Rengi {flagColor}";
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adı giriniz : ");
            //x=Console.ReadLine();

            //Console.Write("Başkenti giriniz : ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak renklerini giriniz : ");
            //z = Console.ReadLine();

            //Console.WriteLine(countryCard(x,y,z));


            //int sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    return result;
            //}

            //Console.WriteLine(sum(91, 45, 53));
            //Console.WriteLine(sum(21, 45, 46));
            //Console.WriteLine(sum(51, 54, 97));
            //Console.WriteLine(sum(16, 22, 84));
            #endregion


            #region Örnek Uygulama

            string ExamResult(string name, int e1, int e2, int e3)
            {
                int result = (e1 + e2 + e3) / 3;
                if (result>=50)
                {
                    return $"{name} isimli öğrenci sınavı geçti. Ortalaması : {result}";
                }
                else
                {
                    return $"{name} isimli öğrenci başarısız oldu. Ortalaması : {result}";
                }
            }

            ExamResult("Berke Arslan", 58, 96, 32);
            ExamResult("Mehmet Kaplan", 16, 43, 71);

            Console.WriteLine(ExamResult("Berke Arslan", 58, 96, 32));
            Console.WriteLine(ExamResult("Mehmet Kaplan", 16, 43, 71));

            #endregion



            Console.Read();
        }
    }
}
