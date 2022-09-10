using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";
            int pilihan;

            Console.Write("Program Kalkulator Sederhana");
            Console.WriteLine();
            Console.Write("============================");
            Console.WriteLine();
            Console.Write(" Pilih Menu :");
            Console.WriteLine();
            Console.Write("1.Penambahan");
            Console.WriteLine();
            Console.Write("2.Pengurangan");
            Console.WriteLine();
            Console.Write("3.Perkalian");
            Console.WriteLine();
            Console.Write("4.Pembagian");
            Console.WriteLine();

            Console.Write("Pilih Nomor berapa (1-4) = ");
            pilihan = int.Parse(Console.ReadLine());

            if (pilihan == 1 || pilihan == 1)
            {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }

            else if (pilihan == 2 || pilihan == 2)
            {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, Pengurangan(a, b));
            }

            else if (pilihan == 3 || pilihan == 3)
            {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2} ", a, b, Perkalian(a, b));
            }

           else  if (pilihan == 4 || pilihan == 4)
            {
                Console.Write("Inputkan Nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Inputkan Nilai b = ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2} ", a, b, Pembagian(a, b));

            }
            else
            {
                Console.Write("Maaf menu yang anda pilih tidak tersedia");
            }
                Console.WriteLine();
                Console.WriteLine("\nTekan sembarang key untuk keluar...");
                Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a,int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
