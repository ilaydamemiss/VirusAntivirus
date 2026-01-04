using System;
using System.IO;

namespace VirusYapici
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dosyayı direkt Masaüstüne oluşturacağız ki hoca görsün
            string masaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dosyaAdi = "tehlikeli_dosya.txt";
            string tamYol = Path.Combine(masaustuYolu, dosyaAdi);

            string virusKodu = "VIRUS_KODU_X99";

            Console.WriteLine("Virüs Programı Çalıştı...");

            try
            {
                // Masaüstüne virüslü dosyayı bırak
                File.WriteAllText(tamYol, "Bu dosyanın içinde gizli kod var.\n" + virusKodu);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Masaüstüne virüslü dosya bırakıldı!");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }

            Console.WriteLine("\nKapatmak için Enter'a bas.");
            Console.ReadLine();
        }
    }
}