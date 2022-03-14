using System;

namespace Metotlar // Note: actual namespace depends on the project name.
{
            //metotlar aslında fonksiyonlardır.
            //OOP'den sonra metot adını almışlardır.
            //Programı parçalamak için kullanırız.
            //neden parçalarız?
            //Küçük parçalara ayırma don't repeat yourself yani kendimizi tekrar etme drumunu ortadan kaldırır.
            //hem de daha okunabilir bir hal alır.
            //normalde bi işlemi programda bi çok yerde yapabilirim. 
            //bu işlemin revize alması gerektiğinde gidip o kod blogunu yazdığım her yeri değiştirmem gerekir.
            //ve bu çok mantıksız.
            //Metot olarak yazılmış bir işlemde sadece metodu değiştirerek o metotdan beslenerek işlem yapan proseslerinde etkilenmesini
            //sağlamış olurum. Yani zaman maliyetini olabildiğince minimize etmiş olur.
            //hızlı müdahele imkanı verir.
            //metotlar genelde classların içerisinde yazılmaktadır.
            //metot erişimi ise classın instance ını yani, örneğini yazarak olur.

            //erişim belirteci dönüş tipi metotadı(varsa parametre)
            
            //erişim belirteci => private, protected, internal, public
            //private => sadece tanımlandığı blokta erişilebilir.
            //protected => private e artı olarak inheritance alan yerde erişilebilir.
            //internal => sadece mevcut assembly'de erişilebilir.
            //public => referans verildiği taktirde bağlı olduğu proje hariç başka projelerde de erişilebilir.

            //Dönüş tipi
            //geri dönüş tipi yoksa void yazılır.

            //metot adı
            //Metot adı önemlidir. Metotu görmeden ne iş yaptığını anlayabilmem gerekir. Bu sadece metot da değil her şey de çok önemlidir.
    class Program
    {
        static void Main(string[] args)
        {
            
            //bu işlemi metot olarak yapsaydık nasıl yapardık?
            //int a = 2;
            //int b = 3;
            //Console.WriteLine(a+b);
            EkranaYazdir ekranaYazdir = new EkranaYazdir();
            ekranaYazdir.Yazdir("Lütfen bir sayı giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());
            ekranaYazdir.Yazdir("Lütfen bir sayı giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Toplama toplam = new Toplama(); 
            ekranaYazdir.Yazdir("girilen iki sayının toplamı: " + toplam.Toplam(a,b));

        }
        class Toplama
        {
            public int Toplam(int a, int b)
            {
                return a + b;
            }
        }

        class EkranaYazdir
        {
            public void Yazdir(string veri)
            {
                Console.WriteLine(veri);
            }
        }

    }
}
