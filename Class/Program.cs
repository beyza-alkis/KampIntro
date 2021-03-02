using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ethan";
            int yas = 21;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursEgitmeni = "Berkay Bilgin";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursEgitmeni = "Kerem Varış";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursEgitmeni +" : " + kurs1.KursAdi);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 }; // böyle yazarsak içinde kurs tutabiliriz

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.KursEgitmeni + " : " + kurs.KursAdi);
            }

            
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
