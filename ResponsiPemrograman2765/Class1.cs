using System;

namespace ResponsiPemrograman2765
{
    class Karyawan
    {
        public string Nama { get; set; }
        public string Nik { get; set; }
        public double  Gajibulanan { get; set; }

        public Karyawan(string nik= "0", string nama="kosong",  double gajibulanan = 0)
        {
            Nama = nama;
            Nik = nik;
            if (gajibulanan < 0) { gajibulanan = 0; }
            

            Gajibulanan = gajibulanan;
        }


        public void getkaryawan1()
        {
            Console.WriteLine("1. \t {0} {1} \t {2}", Nik, Nama , Gajibulanan);
        }
        public void getkaryawan2()
        {
            Console.WriteLine("2. \t {0} {1} \t {2}", Nik, Nama, Gajibulanan);
        }
        public void getkaryawan3()
        {
            Console.WriteLine("1. \t {0} {1} \t {2}", Nik, Nama, Gajibulanan=Gajibulanan+(0.1*Gajibulanan));
        }
        public void getkaryawan4()
        {
            Console.WriteLine("2. \t {0} {1} \t {2}", Nik, Nama, Gajibulanan = Gajibulanan + (0.1 * Gajibulanan));
        }
    }
}
