using System;

namespace OOP_Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            //oop örneği olan Inheritance/kalıtım miras alma konusunu ile ilgili örnek anlatım gerçekleştirdik.
            InheritanceMethod();
        }
        private static void InheritanceMethod()
        {//Bu örnekte, Çalışan sınıfı temel sınıf olarak kullanılmış ve Yönetici sınıfı, Çalışan sınıfından miras alınmıştır. Yönetici sınıfı, Çalışan sınıfının özelliklerini ve metotlarını kullanır ve aynı zamanda kendine ait olan SorumluOlduğuAlan özelliği ve ZamYap() metodu vardır.
         //Programı çalıştırdığınızda, çalışanın ve yöneticinin bilgileri yazdırılacak, sonra yöneticiye zam yapıldıktan sonra güncel maaş bilgisi gösterilecektir. Bu örnek, kalıtımın daha somut bir kullanımını göstermektedir.
            
            // Çalışan nesnesi oluşturuyoruz
            Çalışan çalışan1 = new Çalışan();
            çalışan1.Ad = "Ali";
            çalışan1.Departman = "IT";
            çalışan1.Maaş = 5000;

            // Yönetici nesnesi oluşturuyoruz
            Yönetici yönetici1 = new Yönetici();
            yönetici1.Ad = "Ayşe";
            yönetici1.Departman = "Finans";
            yönetici1.Maaş = 8000;
            yönetici1.SorumluOlduğuAlan = "Muhasebe";

            // Çalışan bilgilerini göster
            Console.WriteLine("Çalışan Bilgileri:");
            çalışan1.BilgiGöster();
            Console.WriteLine();

            // Yönetici bilgilerini göster
            Console.WriteLine("Yönetici Bilgileri:");
            yönetici1.BilgiGöster();
            Console.WriteLine("Sorumlu Olduğu Alan: " + yönetici1.SorumluOlduğuAlan);
            Console.WriteLine();

            // Yöneticiye zam yap
            double zamYüzdesi = 10;
            yönetici1.ZamYap(zamYüzdesi);

            // Zam yapıldıktan sonra güncel maaş bilgisi
            Console.WriteLine("Zam Yapıldıktan Sonra Yönetici Maaşı: " + yönetici1.Maaş);

        }
    }
    // Üst sınıf (temel sınıf)
    class Çalışan
    {
        public string Ad { get; set; }
        public string Departman { get; set; }
        public double Maaş { get; set; }

        public void BilgiGöster()
        {
            Console.WriteLine("Ad: " + Ad);
            Console.WriteLine("Departman: " + Departman);
            Console.WriteLine("Maaş: " + Maaş);
        }
    }

    // Alt sınıf (türetilmiş sınıf)
    class Yönetici : Çalışan
    {
        public string SorumluOlduğuAlan { get; set; }

        public void ZamYap(double yüzde)
        {
            Maaş = Maaş + (Maaş * yüzde / 100);
        }
    }
}
