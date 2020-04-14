using System;
namespace ResponsiPemrograman2765
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("No \t Nik/Nama  \t Gajibulanan");
            Console.WriteLine("-------------------------------------------");
            Karyawan karyawan = new Karyawan( "190302123","Paijo", 3000000);
            karyawan.getkaryawan1();
            Karyawan karyawan2 = new Karyawan("190302124","jono", 2000000);
            karyawan2.getkaryawan1();

            Console.WriteLine("\n\nAsyiikk kenaikan gaji 10%\n");
            Console.WriteLine("No \t Nik/Nama  \t Gajibulanan");
            Console.WriteLine("-------------------------------------------");
            karyawan.getkaryawan3();
            karyawan2.getkaryawan4();


            Console.ReadKey();
        }
    }
}
