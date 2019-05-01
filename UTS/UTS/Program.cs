using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan Karyawan = new Karyawan();

            Console.WriteLine("No\tNIK\t\tNama\tGaji");
            Karyawan.nama = "Satria";
            Karyawan.nik = "190302123";
            Karyawan.GajiBulanan = 3000000;
            Karyawan.nama2 = "Ryo";
            Karyawan.nik2 = "190302124";
            Karyawan.GajiBulanan2 = 2000000;
            Karyawan.infokar();
            Karyawan.bonus();
            Karyawan.infobon();

            Console.ReadKey();
        }
    }
}
