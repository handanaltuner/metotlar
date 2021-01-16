using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyati = 1 5
            string aciklama = "";

            string[]  int Aciklama { get; set; }

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Urun[] urunler = new Urun[] { Urun1, urun2 };

            //type --safe -- tip guvenligi
            foreach (Urun urun in urunler)
            {
                Console.WriteLine("urun.Adi");
                Console.WriteLine("urun.Fiyati");
                Console.WriteLine("urun.Aciklama");
            }


                Console.WriteLine("---------Metotlar---------");
            //instance  - ornek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,8);

        }
    }
}
