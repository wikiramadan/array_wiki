using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,c;
            string[] nama = new string[5];
            string[] kelas = new string[5];
            string[] jurusan = new string[5];
            string[] alamat = new string[5];
            string[] status = new string[5];

            for (i = 0; i < 5 ; i++)
            {
                c = i + i;
                Console.WriteLine("input " + c);
                Console.WriteLine("==============");
                Console.Write("nama    : ");
                nama[i] = Console.ReadLine();
                Console.Write("kelas    : ");
                kelas[i] = Console.ReadLine();
                Console.Write("jurusan    : ");
                jurusan[i] = Console.ReadLine();
                Console.Write(" alamat   : ");
                alamat[i] = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(" data telah dimasukan tekan sembarangan untuk menampilkan");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(" Berikut ini data siswa yg dimasukan");
            Console.WriteLine("======================================");
            Console.WriteLine();
            Console.WriteLine("+---------------------------------------+");
            Console.WriteLine("| No | Nama Siswa | Kelas | Jurusan |");
            Console.WriteLine("+-------------------------------------+");
            for (i = 0; i < 5 ; i++)
            {
                c = i + i;
                Console.WriteLine("| " + c + " | " + nama[i] + "      | " + kelas[i] + "      | " + jurusan[i] + "    | " + alamat[i] + " | ");
            }
            Console.WriteLine("+----------------------------------+");
            Console.WriteLine();
            Console.WriteLine("Tekan enter untuk keluar");
            Console.ReadLine();
        } 
    }
}