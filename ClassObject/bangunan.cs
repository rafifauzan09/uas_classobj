using System;

namespace ClassObject
{
    public class bangunan
    {
        //properties
        public string pemilik { get; set; }
        public int luas { get; set; }
        public string alamat { get; set; }
        public string jenisb { get; set; }

        //method
        public void identitas()
        {
            Console.WriteLine("Nama Pemilik : {0}", pemilik);
            Console.WriteLine("Luas Bangunan : {0}m2", luas);
            Console.WriteLine("Alamat : {0}", alamat);
        }

        public void proses()
        {
            Console.WriteLine("\n{0} {1}, sedang dalam pembangunan\n\n",jenisb, pemilik);
        }
        public void selesai()
        {
            Console.WriteLine("\n{0} {1},selesai dibangun\n\n",jenisb, pemilik);
        }
    }
}