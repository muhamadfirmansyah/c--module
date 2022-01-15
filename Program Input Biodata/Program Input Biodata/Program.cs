using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_Input_Biodata
{
    class Program
    {
        static void Main(string[] args)
        {
            string nama_lengkap, nama_panggilan, alamat, tempat_lahir, telepon;
            int npm, umur;
            Console.WriteLine("=============================");
            Console.WriteLine("Silahkan Masukan Biodata Anda");
            Console.WriteLine("=============================");
            Console.Write("Nama Lengkap     : ");
            nama_lengkap = Console.ReadLine();
            Console.Write("Nama Panggilan   : ");
            nama_panggilan = Console.ReadLine();
            Console.Write("NPM              : ");
            npm = Convert.ToInt32(Console.ReadLine());
            Console.Write("Umur             : ");
            umur = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tempat Lahir     : ");
            tempat_lahir = Console.ReadLine();
            Console.Write("Telepon          : ");
            telepon = Console.ReadLine();
            Console.Write("Alamat           : ");
            alamat = Console.ReadLine();
            Console.WriteLine("=====================================================================================================");
            Console.WriteLine("Assalamu’alaikum.\nLet me introduce my self. My name is " + nama_lengkap + ", but you can call me " + nama_panggilan +".\nMy NPM is " + npm +". I was born in " + tempat_lahir + " and I am " + umur + " years old.\nI am very glad if you want to invite my house in " + alamat + ".\nSo, don’t forget to call me before with the number " + (telepon) + ".\nThank you.");
            Console.WriteLine("=====================================================================================================");
            Console.ReadKey();
        }
    }
}
