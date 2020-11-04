using System;

namespace kebisaanku
{
    class Program
    {
        static void Main(string[] args)
        {
            umur6Bulan umr6bln = new umur6Bulan();
            umr6bln.tersenyum();

            umur5Tahun umr5thn1 = new umur5Tahun();
            umr5thn1.merangkak();

            umur5Tahun umr5thn2 = new umur5Tahun();
            umr5thn2.Bermain();

            umur18Tahun umr18thn1 = new umur18Tahun();
            umr18thn1.tersenyum();

            umur18Tahun umr18thn2 = new umur18Tahun();
            umr18thn2.Berenang();

            umur18Tahun umr18thn3 = new umur18Tahun();
            umr18thn3.masak();
        }
    }
}
