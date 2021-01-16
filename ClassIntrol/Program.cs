using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs
            {
                KursAdi = "Ivır Zıvır",
                Egitmen = "Engin",
                IzlenmeOrani = 100
            };

            Kurs[] kurslar = new Kurs[] { kurs1 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
