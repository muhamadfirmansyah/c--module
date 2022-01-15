using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_Konversi_Waktu
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Double detik, menit, jam;
            int nilai;
            Console.WriteLine("======================");
            Console.WriteLine("Program Konversi Waktu");
            Console.WriteLine("======================");
            Console.Write(" 1.Detik \n 2.Menit Atau \n 3.Jam \nSilahkan Masukan : ");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1: Console.WriteLine("======================");
                    Console.Write("Detik :");
                    detik = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("======================");
                    menit = detik / 60;
                    jam = detik / 3600;
                    Console.WriteLine(detik + " detik adalah " + menit + " menit");
                    Console.WriteLine(detik + " detik adalah " + jam + " jam");
                    break;
                case 2: Console.WriteLine("======================");
                    Console.Write("Menit : ");
                    menit = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("======================");
                    detik = menit * 60;
                    jam = menit / 60;
                    Console.WriteLine(menit + " menit adalah " + jam + " jam");
                    Console.WriteLine(menit + " menit adalah " + detik + " detik");
                    break;
                case 3: Console.WriteLine("======================");
                    Console.Write("Jam : ");
                    jam = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("======================");
                    detik = jam * 3600;
                    menit = jam * 60;
                    Console.WriteLine(jam + " jam adalah " + detik + " detik");
                    Console.WriteLine(jam + " jam adalah " + menit + " menit");
                    break;
                default: Console.WriteLine("Maaf Nomor Pilihan Yang Anda Masukan Salah");
                    break;
            }
            Console.ReadKey();
            Console.WriteLine("=======================================");
            Console.WriteLine("Program By Muhamad Firmansyah | RPL X-2");
            Console.WriteLine("=======================================");
            Console.WriteLine("Silahkan Masukan Penilaian Anda : ");
            nilai = Convert.ToInt32(Console.Read());
            Console.WriteLine("=======================================");
            Console.WriteLine("  (: Terimakasih Atas Penilaiannya :)");
            Console.WriteLine("=======================================");
            Console.ReadKey();
        }
    }
}
