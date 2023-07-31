using System;

namespace OOP_Lesson_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bu örnekte, Hayvan sınıfı temel sınıf olarak kullanılmış ve Kus sınıfı, Hayvan sınıfından miras alınmıştır. Kus sınıfı, Hayvan sınıfının özelliklerini ve metotlarını kullanır ve aynı zamanda kendine ait olan Renk özelliği ve Ucmak() metodu vardır.

            // Programı çalıştırdığınızda, kartalın türü, yaşı ve rengi yazdırılacak, ardından kartalın ses çıkaracağı ve uçacağı ifade edilecektir.Bu, kalıtımın nasıl çalıştığını gösteren temel bir örnektir.
            // Alt sınıftan bir nesne oluşturuyoruz
            Kus kartal = new Kus();
            kartal.Tur = "Kartal";
            kartal.Yas = 5;
            kartal.Renk = "Kahverengi";

            // Miras alınan üst sınıfın özelliğini kullanıyoruz
            Console.WriteLine("Tür: " + kartal.Tur);
            Console.WriteLine("Yaş: " + kartal.Yas);

            // Alt sınıfa ait özelliği kullanıyoruz
            Console.WriteLine("Renk: " + kartal.Renk);

            // Miras alınan üst sınıfın metotunu çağırıyoruz
            kartal.SesCikar();

            // Alt sınıfa ait metodu çağırıyoruz
            kartal.Ucmak();
            Console.ReadKey();
        }
    }
    // Üst sınıf (temel sınıf)
    class Hayvan
    {
        public string Tur { get; set; }
        public int Yas { get; set; }

        public void SesCikar()
        {
            Console.WriteLine("Hayvan ses çıkarıyor...");
        }
    }

    // Alt sınıf (türetilmiş sınıf)
    class Kus : Hayvan
    {
        public string Renk { get; set; }

        public void Ucmak()
        {
            Console.WriteLine("Kuş uçuyor...");
        }
    }
}
