using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.musteriAdi = "Sadullah";
            musteri1.musteriSoyadi = "Avcı";
            musteri1.musteriIban = "TR 123123123";
            musteri1.musteriSubesi = "Çankaya Şubesi";

            Musteri musteri2 = new Musteri();
            musteri2.musteriAdi = "Emin";
            musteri2.musteriSoyadi = "Dilman";
            musteri2.musteriIban = "TR 321321321";
            musteri2.musteriSubesi = "Kızılay Şubesi";

            Musteri musteri3 = new Musteri();
            musteri3.musteriAdi = "Ece";
            musteri3.musteriSoyadi = "Erdur Bayındır";
            musteri3.musteriIban = "TR 987987987";
            musteri3.musteriSubesi = "Abidinpaşa Şubesi";



            Console.WriteLine("---Yeni Müşteri Kaydı Oluşturulduğunda---");
            Console.WriteLine(" ");

            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager1.Ekle(musteri1);
            Console.WriteLine(" ");
            musteriManager1.Ekle(musteri2);
            Console.WriteLine(" ");
            musteriManager1.Ekle(musteri3);


            Console.WriteLine(" ");
            Console.WriteLine("-----Müşteri Listeleme-----");
            Console.WriteLine(" ");

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {

                Console.WriteLine(musteri.musteriAdi + " " + musteri.musteriSoyadi);
                Console.WriteLine(" ");

            }

            Console.WriteLine(" ");
            Console.WriteLine("-----Müşteri Bilgileri Silme-----");
            Console.WriteLine(" ");


            MusteriManager musteriManager2 = new MusteriManager();
            musteriManager2.Sil(musteri1);
            Console.WriteLine(" ");
            musteriManager2.Sil(musteri2);
            Console.WriteLine(" ");
            musteriManager2.Sil(musteri3);


            Console.WriteLine(" ");
            Console.WriteLine("------Banka Çalışanı Tarafından Müşteri Bilgilerinin Listelenmesi------");
            Console.WriteLine(" ");


            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Adı Soyadı: " + musteri.musteriAdi + " " + musteri.musteriSoyadi);
                Console.WriteLine(" ");
                Console.WriteLine("Şube: " + musteri.musteriSubesi);
                Console.WriteLine(" ");
                Console.WriteLine("Iban No: " + musteri.musteriIban);
                Console.WriteLine(" ");
            }


            Console.WriteLine("--Sayfa Sonu--");



        }
    }
}
