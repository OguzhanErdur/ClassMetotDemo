using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Ekle (Musteri musteri) 
        {
            Console.WriteLine("Kaydınız Başarıyla Oluşturulmuştur! Hoşgeldiniz " + musteri.musteriAdi + " " + musteri.musteriSoyadi);
        }

        public void Sil (Musteri musteri)
        {

            Console.WriteLine("Sayın "+ musteri.musteriAdi + " " + musteri.musteriSoyadi+ " " + musteri.musteriSubesi + "'nde Yer Alan Bilgileriniz Veri Tabanımızdan Silinmiştir.");

        }

    }


}
