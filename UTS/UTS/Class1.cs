using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS
{
    class Karyawan
    {
        public string nik { get; set; }
        public string nama { get; set; }
        public int GajiBulanan { get; set; }


        public string nik2 { get; set; }
        public string nama2 { get; set; }
        public int GajiBulanan2 { get; set; }

        public void infokar()
        {
            Console.WriteLine("1\t{0}\t{1}\t{2}", nik, nama, GajiBulanan);
            Console.WriteLine("2\t{0}\t{1}\t{2}", nik2, nama2, GajiBulanan2);
        }

        public void bonus()
        {
            if (GajiBulanan < 0)
            {
                GajiBulanan = 0;
            }
            else if (GajiBulanan2 < 0)
            {
                GajiBulanan2 = 0;
            }

            Console.WriteLine();
            Console.WriteLine("Hore Kenaikan Gaji 10%");
        }

        public void infobon()
        {
            Console.WriteLine("1\t{0}\t{1}\t{2}", nik, nama, GajiBulanan*1.1 );
            Console.WriteLine("1\t{0}\t{1}\t{2}", nik2, nama2, GajiBulanan2*1.1 );
        }
    }
}
