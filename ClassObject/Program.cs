using System;

namespace ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Penerapan Class dan Object\n");

            bangunan rumah = new bangunan();
            bangunan kos = new bangunan();

            rumah.pemilik = "Ari Wicaksono";
            rumah.jenisb = "Rumah";
            rumah.alamat = "Cendrawasih 71";
            rumah.luas = 96;

            rumah.identitas();
            rumah.proses();

            kos.pemilik = "Rangga Tasyim";
            kos.jenisb = "Kos";
            kos.alamat = "Cendrawasih 112";
            kos.luas = 144;

            kos.identitas();
            kos.selesai();

            Console.ReadLine();
        }

    }
}