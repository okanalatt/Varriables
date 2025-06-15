using System.Collections.Specialized;

namespace Varriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Değişkenler, programlama dillerinde veri saklamak için kullanılır.
                Değişkenler, bir isimle ilişkilendirilmiş bir bellek alanını temsil eder ve bu alanda farklı veri türlerinde değerler saklanabilir.
            Değişken tnaımlaması şu şekildedir:
                veri_türü değişken_adı = başlangıç_değeri;
            1.Metinsel Veri tipli değişkenler
                string isim = "Ahmet"; // string veri tipi, metin verilerini saklar.
                string soyisim = "yılmaz"; // string veri tipi, metin verilerini saklar.
                char karakter = 'A'; // char veri tipi, tek bir karakteri saklar.
                string tamIsim = isim + " " + soyisim; // string veri tipi, metin verilerini saklar. Burada isim ve soyisim değişkenleri birleştirilerek tam isim oluşturuluyor.
            2.Sayısal Veri tipli değişkenler:
                int yas = 25; // int veri tipi, tam sayıları saklar.
                double maas = 2500.50; // double veri tipi, ondalıklı sayıları saklar.
                decimal fiyat = 99.99m; // decimal veri tipi, ondalıklı sayıları saklar. m eki, decimal veri tipini belirtir.
                long telefonNumarasi = 1234567890L; // long veri tipi, büyük tam sayıları saklar. L eki, long veri tipini belirtir.
            3.Boole Veri tipli değişkenler:
                bool evliMi = true; // bool veri tipi, doğru veya yanlış değerlerini saklar.
                bool isActive = false; // bool veri tipi, doğru veya yanlış değerlerini saklar.
            4.Tarih ve Saat Veri tipli değişkenler:
                DateTime dogumTarihi = new DateTime(1998, 5, 1); // DateTime veri tipi, tarih ve saat verilerini saklar.
                DateTime simdi = DateTime.Now; // DateTime veri tipi, geçerli tarih ve saat bilgisini saklar.
            5.Nesne Veri tipli değişkenler:
                object nesne = "Bu bir nesnedir"; // object veri tipi, herhangi bir veri tipini saklayabilir. Farklı veri tiplerini tek bir değişkende tutmak için kullanılır.
                object sayiNesnesi = 42; // object veri tipi, herhangi bir veri tipini saklayabilir. Farklı veri tiplerini tek bir değişkende tutmak için kullanılır.
                object tarihNesnesi = new DateTime(2023, 10, 1); // object veri tipi, herhangi bir veri tipini saklayabilir. Farklı veri tiplerini tek bir değişkende tutmak için kullanılır.
                
                Runtime: Çalışma anında işlev görür. Uygulama sona erdiğinde hayatları sona ermektedir.
             */

            //string isim = "Ahmet"; // string veri tipi, metin verilerini saklar.
            //isim= "Mehmet";
            //Console.WriteLine(isim); // Konsola isim değişkeninin değeri yazdırılır.

            //Console.WriteLine(isim+"isim gir");
            //String ad=Console.ReadLine(); // Kullanıcıdan isim girişi alınır.
            //Console.WriteLine("Merhaba " + ad); // Kullanıcıya merhaba mesajı yazdırılır.
            //Console.WriteLine("bir hata olustu tekrar ısım gir");
            //ad=Console.ReadLine(); // Kullanıcıdan tekrar isim girişi alınır.   
            //Console.WriteLine("Merhaba " + ad); // Kullanıcıya tekrar merhaba mesajı yazdırılır.
            //Console.Read();

            // Kodu düzene sokmak için CTRL + K + D tuşlarına basabilirsiniz.
            // Açıklama satırlarını kaldırmak için CTRL + K + C tuşlarına basabilirsiniz.
            Console.WriteLine("Ornek 1 ");
            Console.Write("İsim bilgisi girin ");
            string isim = Console.ReadLine(); // Kullanıcıdan isim girişi alınır.
            Console.Write("Soyisim bilgisi girin ");
            string soyisim = Console.ReadLine(); // Kullanıcıdan soyisim girişi alınır.
            Console.Write("Yas bilgisini giriniz :");
            string yasStr = Console.ReadLine(); // Kullanıcıdan yaş girişi alınır.

            Console.WriteLine("\nMerhaba " + isim + " " + soyisim + ", yaşınız: " + yasStr); // Kullanıcıya merhaba mesajı yazdırılır.
            Console.ReadLine(); // Konsolun kapanmaması için kullanıcıdan bir tuşa basması beklenir.
        }
    }
}
