using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FolderAndFileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string path = @"C:\Users\iarif\OneDrive\Masaüstü\KT\";
            string FolderName = "kt_2";
            Console.WriteLine("Klasör Oluşturmak için bir tuşa basınız.");
            Console.ReadLine();
            if (!Directory.Exists(path+FolderName))
            {
                Directory.CreateDirectory(path + FolderName);
                Console.WriteLine(FolderName+" Adlı klasör oluşturuldu.");
            }
            else
            {
                Console.WriteLine(FolderName+" Adlı klasör var olduğundan oluşturulamadı");
            }
            Console.ReadLine();
            */
            /*
            string path = @"C:\Users\iarif\OneDrive\Masaüstü\KT\";
            string FileName = "yazi.txt";
            if (!File.Exists(path+FileName))
            {
                File.WriteAllText(path + FileName, "Merhaba Arkadaşlar");
            }
            else
            {
                Console.WriteLine("Bu dosya adı zaten var olduğundan oluşturulamıyor.");
            }
            Console.ReadLine();
            */
            string path = @"C:\Users\iarif\OneDrive\Masaüstü\KT\";
            string FileName = "yazi.txt";

            if (File.Exists(path+FileName))
            {
                string okunanVeri = File.ReadAllText(path + FileName);
                Console.WriteLine(okunanVeri);
            }
            else
            {
                Console.WriteLine("Dosya bulunamadı");
            } 



            Console.ReadLine();
        }
    }
}
