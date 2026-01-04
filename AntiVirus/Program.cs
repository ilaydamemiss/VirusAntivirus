
using System.IO;

namespace Antivirus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Antivirüs Taraması Başlıyor...");

            // Antivirüs de Masaüstüne bakacak
            string taranacakYol = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string taranacakVirus = "VIRUS_KODU_X99";

            // Masaüstündeki tüm .txt dosyalarını bul
            string[] dosyalar = Directory.GetFiles(taranacakYol, "*.txt");
            int bulunan = 0;

            foreach (string dosya in dosyalar)
            {
                string icerik = File.ReadAllText(dosya);

                if (icerik.Contains(taranacakVirus))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"VİRÜS BULUNDU: {Path.GetFileName(dosya)}");

                    File.Delete(dosya); // SİLME İŞLEMİ

                    Console.WriteLine("-> Dosya imha edildi.");
                    Console.ResetColor();
                    bulunan++;
                }
            }

            if (bulunan == 0)
                Console.WriteLine("Masaüstünde virüs bulunamadı.");
            else
                Console.WriteLine($"\nTarama bitti. {bulunan} virüs temizlendi.");

            Console.ReadLine();
        }
    }
}