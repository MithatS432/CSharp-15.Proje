using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar__Fonksiyonlar_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;

            // Metot çağırma
            int toplam = Topla(a, b);
            Console.WriteLine($"Toplam: {toplam}");

            // ref kullanımı – değişken değeri dışarıdan alınır ve metotta değiştirilir
            Console.WriteLine($"Önce: a = {a}");
            Arttir(ref a);
            Console.WriteLine($"Sonra: a = {a}");

            // out kullanımı – metot içinde değer atanarak dışarıya çıkarılır
            int sonuc;
            Carp(a, b, out sonuc);
            Console.WriteLine($"Çarpım: {sonuc}");

            // params kullanımı – istenen kadar parametre geçilebilir
            int toplam2 = ToplaParams(1, 2, 3, 4, 5);
            Console.WriteLine($"Toplam (params): {toplam2}");

            // Overloading örneği
            Console.WriteLine($"Topla (2 parametre): {Topla(5, 6)}");
            Console.WriteLine($"Topla (3 parametre): {Topla(1, 2, 3)}");
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }

        static int Topla(int x, int y, int z) // Overload
        {
            return x + y + z;
        }

        static void Arttir(ref int sayi)
        {
            sayi += 1;
        }

        static void Carp(int x, int y, out int sonuc)
        {
            sonuc = x * y;
        }

        static int ToplaParams(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var s in sayilar)
                toplam += s;
            return toplam;
        }
    }
    }

