using System;

namespace Loginscreen
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string user;
            string pass;

            do {
                Console.WriteLine("Lütfen giriş bilgilerinizi giriniz");
                Console.Write("Kullanıcı Adı: ");
                user = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Şifre: ");
                pass = Console.ReadLine();


            } while (user != "admin" && pass != "123");

            Console.WriteLine("Giriş Başarılı \n Devam etmek için bir tuşa basınız.");
            Console.ReadKey();

          

        }
    }
}
