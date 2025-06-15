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
            // Readline sadece string veri tipini alır, bu yüzden string olarak tanımlanmalıdır.
            Console.WriteLine("Ornek 1 ");
            Console.Write("İsim bilgisi girin ");
            string isim = Console.ReadLine(); // Kullanıcıdan isim girişi alınır.
            Console.Write("Soyisim bilgisi girin ");
            string soyisim = Console.ReadLine(); // Kullanıcıdan soyisim girişi alınır.
            Console.Write("Yas bilgisini giriniz :");
            string yasStr = Console.ReadLine(); // Kullanıcıdan yaş girişi alınır.

            Console.WriteLine("\nMerhaba " + isim + " " + soyisim + ", yaşınız: " + yasStr); // Kullanıcıya merhaba mesajı yazdırılır.
            Console.ReadLine(); // Konsolun kapanmaması için kullanıcıdan bir tuşa basması beklenir.

            byte sayi1= 255; // byte veri tipi, 0-255 aralığında tam sayıları saklar.
            // yas veri tipi byte olarak tanımlanabilir, ancak bu durumda yaşın 0-255 aralığında olması gerekir.
            sbyte yas = 25; // byte veri tipi, 0-255 aralığında tam sayıları saklar.
            short sayi2 = 32767; // short veri tipi, -32768 ile 32767 aralığında tam sayıları saklar.
            int sayi3 = 2147483647; // int veri tipi, -2147483648 ile 2147483647 aralığında tam sayıları saklar.
            long sayi4 = 9223372036854775807L; // long veri tipi, -9223372036854775808 ile 9223372036854775807 aralığında tam sayıları saklar. L eki, long veri tipini belirtir.
            float sayi5 = 3.40282347E+38F; // float veri tipi, ondalıklı sayıları saklar. F eki, float veri tipini belirtir.
            double sayi6 = 1.7976931348623157E+308; // double veri tipi, ondalıklı sayıları saklar.
            ushort sayi7 = 65535; // ushort veri tipi, 0-65535 aralığında tam sayıları saklar.
            ulong sayi8 = 18446744073709551615UL; // ulong veri tipi, 0-18446744073709551615 aralığında tam sayıları saklar. UL eki, ulong veri tipini belirtir.
            float sayi9 = 3.40282347E+38F; // float veri tipi, ondalıklı sayıları saklar. F eki, float veri tipini belirtir.
            double sayi10 = 1.7976931348623157E+308; // double veri tipi, ondalıklı sayıları saklar.
            char karakter = 'A'; // char veri tipi, tek bir karakteri saklar.
            string metin = "Merhaba Dünya"; // string veri tipi, metin verilerini saklar.
            decimal fiyat = 99.99m; // decimal veri tipi, ondalıklı sayıları saklar. m eki, decimal veri tipini belirtir.
            bool isActive = true; // bool veri tipi, doğru veya yanlış değerlerini saklar.
            var tarih = DateTime.Now; // DateTime veri tipi, tarih ve saat verilerini saklar. Şu anki tarih ve saat bilgisi alınır.
            Console.WriteLine(tarih); // Konsola tarih ve saat bilgisi yazdırılır.
            DateTime dogumTarihi = new DateTime(1998, 5, 1); // DateTime veri tipi, tarih ve saat verilerini saklar. Belirli bir tarih oluşturulur.
            object nesne = "Bu bir nesnedir"; // object veri tipi, herhangi bir veri tipini saklayabilir. Farklı veri tiplerini tek bir değişkende tutmak için kullanılır.
            // Degiskenler tamamı object veri tipinden türemiştir. Bu nedenle, farklı veri tiplerini tek bir değişkende tutmak için object veri tipi kullanılabilir.
            // Değişkenler atası objectir.
            // var , int , short, datetime, bool, string, char, long sık kullanınlar.
            int number; // Default değeri 0'dır.
            bool isActive2; // Default değeri false'dur.
            string name; // Default değeri null'dur.
            DateTime currentDate; // Default değeri 1/1/0001 12:00:00 AM'dir.
            long telefonNumarasi; // Default değeri 0'dır.

        }
    }
}
