using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string ad = "Busra";
            // Print(isim:ad);
            //isim yerine ad parametresini verdiğimi göstermek için kullnaılmaktadır.
            //Print2("ali","ayse","ahmet","veli");

            int x = 0;
            int y = 0;

            // Artir(x); 
            //Değer ile çağırmada ekrana x in değeri 5 yazar
            //Artir(ref x);
            //Ref ile çağırmada x in değeri değil alanı verildiği için yapılan değişiklikler o alana kaydedilir.
            Console.WriteLine("Sayi giriniz");
            //try catch ile giriş verisi kontrol edilerek hata durumunda girilen veri değerlerinin hatalı olduğunun bildirimi yapılır.
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayi giriniz");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(x+y);
            }
            catch(FormatException)//girilen veri tip hatası için kullanılır
            {
                Console.WriteLine("Hatalı giris yaptınız");
            }
            catch (OverflowException)//İstenen tipin veri aralığını aşması durumunda ortaya çıkacak olan bhata durumudur.
            {
                Console.WriteLine("İstenen değer sınırını aşmaktadır.");
            }
            //Hatalı boş string döndürülmesi durumunda olabilecek durum
            SelamVer("");

            //Console.WriteLine(x);
            Console.Read();

        }
        /*static void Print(string isim)
        {
            //isim değerini merhabadan sonra görebilmek için {0} kullanılıyor            
            Console.WriteLine("Merhaba {0}",isim);

        }*/

        /*static void Print2(params string[] isimler)
        {
            //isimler değeri istenilen boyutta olabilir param sayesinde istenilen boyutta veri alınabilir. 
            foreach(var item in isimler)
            {
                Console.WriteLine( item);
            }
            

        }*/
        /*static void Artir(ref int sayi)
        {
            sayi = sayi + 1;

        }*/

        static void SelamVer(string isim)
        {
            if(string.IsNullOrEmpty(isim))
            {
                //Hatalı giriş durumunda ekrana verilecek hata mesajı durumu
                throw new Exception("İsim bilgisi giriniz");
            }
            Console.WriteLine("Hoşgeldin: {0}",isim);
        }
            



    }
}
