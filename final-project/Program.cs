using System;
using Collection.induk;
using Collection.anak;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Smartphone> hp = new List<Smartphone>();
            List<Laptop> lap = new List<Laptop>();
            List<Tv> t = new List<Tv>();

            int pilihan;
            menu :
            Console.Title = "Final Project Pemrograman 'toko elektronik'";
            Console.Write(" Menu Utama :");
            Console.WriteLine();
            Console.Write("1.Tambah Data Barang");
            Console.WriteLine();
            Console.Write("2.Tampilkan Data Barang");
            Console.WriteLine();
            Console.Write("3.Hapus Data Barang");
            Console.WriteLine();
            Console.Write("4.Cari Data Barang");
            Console.WriteLine();
            Console.Write("5.Edit Data Barang");
           
            Console.WriteLine();

            Console.Write("Pilih Nomor berapa (1-5) = ");
            pilihan = int.Parse(Console.ReadLine());

            if (pilihan == 1 || pilihan == 1)
            {
                Console.WriteLine("Pilih Jenis Barang");
                Console.WriteLine("1. Smartphone");
                Console.WriteLine("2. Laptop");
                Console.WriteLine("3. Televisi");
                Console.Write("Pilih : ");
                int pil = int.Parse(Console.ReadLine());
                if (pil == 1 || pil == 1)
                {
                    Console.WriteLine("                      Smartphone                                ");
                    Console.Write("ID Barang : ");
                    string idhp = Console.ReadLine();
                    Console.Write("Merk Smartphone : ");
                    string merkhp = Console.ReadLine();
                    Console.Write("Prosesor : ");
                    string prosesorhp = Console.ReadLine();
                    Console.Write("RAM : ");
                    string ramhp = Console.ReadLine();
                    Console.Write("Harga : ");
                    double hargahp = Convert.ToDouble(Console.ReadLine());

                    hp.Add(new Smartphone() {ID = idhp, Merk = merkhp, Prosesor= prosesorhp, Ram = ramhp, Harga = hargahp});

                }

                else if (pil == 2 || pil == 2)
                {
                    Console.WriteLine("                      Laptop                                ");
                    Console.Write("ID Barang : ");
                    string idlaptop = Console.ReadLine();
                    Console.Write("Merk Laptop : ");
                    string merklaptop = Console.ReadLine();
                    Console.Write("Prosesor dan Kartu Grafis : ");
                    string prosesorlaptop = Console.ReadLine();
                    Console.Write("RAM : ");
                    string ramlaptop = Console.ReadLine();
                    Console.Write("Harga Laptop : ");
                    double hargalaptop = Convert.ToDouble(Console.ReadLine());

                    lap.Add(new Laptop() {ID = idlaptop, Merk = merklaptop, Prosesor = prosesorlaptop, Ram = ramlaptop, Harga = hargalaptop });
                }

                else if (pil == 3 || pil == 3)
                {
                    Console.WriteLine("                      Televisi                                ");
                    Console.Write("ID Barang : ");
                    string idtv = Console.ReadLine();
                    Console.Write("Merk TV : ");
                    string merktv = Console.ReadLine();
                    Console.Write("Ukuran Layar: ");
                    string ukurantv = Console.ReadLine();
                    Console.Write("Harga  : ");
                    double hargatv = Convert.ToDouble(Console.ReadLine());

                    t.Add(new Tv() {ID = idtv,  Merk = merktv, Ukuran = ukurantv, Harga = hargatv });

                }
                Console.ReadKey(true);
                Console.Clear();
                goto menu;


            }

            else if (pilihan == 2 || pilihan == 2)
            {
                Console.WriteLine("List Data Barang Elektronik");
                int no = 1;
                foreach (Elektronik elektronik in hp)
                {
                    Console.WriteLine("{0}. ID Barang : {1}, Merk Smartphone : {2}, Prosesor: {3}, RAM: {4}, Harga: {5} ",
                    no, elektronik.ID,elektronik.Merk, elektronik.Prosesor,elektronik.Ram, elektronik.Harga );
                    no++;
                }
                foreach (Elektronik elektronik in lap)
                {
                    Console.WriteLine("{0}. ID Barang : {1} Merk laptop : {2}, Prosesor: {3}, RAM: {4},  Harga: {5}",
                    no, elektronik.ID, elektronik.Merk, elektronik.Prosesor,elektronik.Ram, elektronik.Harga);
                    no++;
                }
                foreach (Elektronik elektronik in t)
                {
                    Console.WriteLine("{0}. ID Barang : {1}, Merk TV : {2}, Ukuran Layar : {3}, Harga : {4}",
                    no, elektronik.ID, elektronik.Merk, elektronik.Ukuran, elektronik.Harga);
                    no++;
                }
                Console.ReadKey(true);
                Console.Clear();
                goto menu;

            }
            
            else if(pilihan == 3 || pilihan == 3)
            {
                list();

                Console.WriteLine("Pilihan Hapus Data Barang");
                string hapus;
                Console.Write("Masukan ID Barang Elektronik : ");
                hapus = Console.ReadLine();
                int x = 0;
                foreach(Elektronik elektronik in hp)
                {
                    if (hapus == elektronik.ID)
                    {
                        hp.RemoveAt(x);
                        break;
                    }
                    x++;
                }
                x = 0;
                foreach (Elektronik elektronik in lap)
                {
                    if (hapus == elektronik.ID)
                    {
                        lap.RemoveAt(x);
                        break;
                    }
                    x++;
                }
                x = 0;
                foreach (Elektronik elektronik in t)
                {
                    if (hapus == elektronik.ID)
                    {
                        t.RemoveAt(x);
                        break;
                    }
                    x++;
                }
                Console.ReadKey(true);
                Console.Clear();
                goto menu;
            }
            
            else if(pilihan == 4 || pilihan == 4)
            {
                list();
                Console.WriteLine("Pilihan Cari Data Barang");
                string cari;
                Console.Write("Masukan ID Barang Elektronik : ");
                cari = Console.ReadLine();
                int no = 1;
                foreach (Elektronik elektronik in hp)
                {
                    if (cari == elektronik.ID)
                    Console.WriteLine("{0}. ID Barang : {1}, Merk Smartphone : {2}, Prosesor: {3}, RAM: {4}, Harga: {5} ",
                    no, elektronik.ID,elektronik.Merk, elektronik.Prosesor,elektronik.Ram, elektronik.Harga );
                    no++;
                }
                foreach (Elektronik elektronik in lap)
                {
                    if (cari == elektronik.ID)
                    Console.WriteLine("{0}. ID Barang : {1} Merk laptop : {2}, Prosesor: {3}, RAM: {4},  Harga: {5}",
                    no, elektronik.ID, elektronik.Merk, elektronik.Prosesor,elektronik.Ram, elektronik.Harga);
                    no++;
                };
               foreach (Elektronik elektronik in t)
                {
                    if (cari == elektronik.ID)
                    Console.WriteLine("{0}. ID Barang : {1}, Merk TV : {2}, Ukuran Layar : {3}, Harga : {4}",
                    no, elektronik.ID, elektronik.Merk, elektronik.Ukuran, elektronik.Harga);
                    no++;
                }
                Console.ReadKey(true);
                Console.Clear();
                goto menu;
            }
            
            else if(pilihan == 5 || pilihan == 5)
            {
                list();
                Console.WriteLine("Pilihan Edit Data Barang");
                string edit;
                Console.Write("Masukan ID Barang Elektronik : ");
                edit = Console.ReadLine();

                int x = 0;
                foreach(Elektronik elektronik in hp)
                {
                    
                    if (edit == elektronik.ID)
                    {
                    hp.RemoveAt(x);
                    Console.WriteLine("                      Smartphone                                ");
                    Console.Write("ID Barang : ");
                    string idhp = Console.ReadLine();
                    Console.Write("Merk Smartphone : ");
                    string merkhp = Console.ReadLine();
                    Console.Write("Prosesor : ");
                    string prosesorhp = Console.ReadLine();
                    Console.Write("RAM : ");
                    string ramhp = Console.ReadLine();
                    Console.Write("Harga : ");
                    double hargahp = Convert.ToDouble(Console.ReadLine());

                    hp.Add(new Smartphone() {ID = idhp, Merk = merkhp, Prosesor= prosesorhp, Ram = ramhp, Harga = hargahp});
                    break;
                    }
                    x++;
                }
                x = 0;
                foreach (Elektronik elektronik in lap)
                {
                    if (edit == elektronik.ID)
                    {
                    lap.RemoveAt(x);
                    Console.WriteLine("                      Laptop                                ");
                    Console.Write("ID Barang : ");
                    string idlaptop = Console.ReadLine();
                    Console.Write("Merk Laptop : ");
                    string merklaptop = Console.ReadLine();
                    Console.Write("Prosesor dan Kartu Grafis : ");
                    string prosesorlaptop = Console.ReadLine();
                    Console.Write("RAM : ");
                    string ramlaptop = Console.ReadLine();
                    Console.Write("Harga Laptop : ");
                    double hargalaptop = Convert.ToDouble(Console.ReadLine());

                    lap.Add(new Laptop() {ID = idlaptop, Merk = merklaptop, Prosesor = prosesorlaptop, Ram = ramlaptop, Harga = hargalaptop });
                    break;
                    }
                    x++;
                }
                x = 0;
                foreach (Elektronik elektronik in t)
                {
                    if (edit == elektronik.ID)
                    {
                    t.RemoveAt(x);
                    Console.WriteLine("                      Televisi                                ");
                    Console.Write("ID Barang : ");
                    string idtv = Console.ReadLine();
                    Console.Write("Merk TV : ");
                    string merktv = Console.ReadLine();
                    Console.Write("Ukuran Layar: ");
                    string ukurantv = Console.ReadLine();
                    Console.Write("Harga  : ");
                    double hargatv = Convert.ToDouble(Console.ReadLine());

                    t.Add(new Tv() {ID = idtv,  Merk = merktv, Ukuran = ukurantv, Harga = hargatv });
                    break;
                    }
                    x++;
                }
                Console.ReadKey(true);
                Console.Clear();
                goto menu;
            }

            else
            {
                Console.WriteLine("Terimakasih telah menggunakan Aplikasi ini");
            }

                
            Console.ReadKey(true);
            Console.Clear();

            void list()
            {
                Console.WriteLine("List Data Barang Elektronik");
                int no = 1;
                foreach (Elektronik elektronik in hp)
                {
                    Console.WriteLine("{0}. ID Barang : {1}",
                    no, elektronik.ID);
                    no++;
                }
                foreach (Elektronik elektronik in lap)
                {
                    Console.WriteLine("{0}. ID Barang : {1}",
                    no, elektronik.ID);
                    no++;
                }
                foreach (Elektronik elektronik in t)
                {
                    Console.WriteLine("{0}. ID Barang : {1}",
                    no, elektronik.ID);
                    no++;
                }
            }
            
        }

    }
}