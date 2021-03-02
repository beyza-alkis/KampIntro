using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention - isimlendirme kuralı (metodların ilk harfi büyük yazılır)
        //syntax - yazım şekilleri
        //Product tipi, urun isimlendirme
        public void Ekle(Product urun)
        {
            Console.WriteLine("Bilgilendirme: Sepete Eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokDurumu)
        {
            Console.WriteLine("Bilgilendirme: Sepete Eklendi : " + urunAdi);
        }
    }
}
