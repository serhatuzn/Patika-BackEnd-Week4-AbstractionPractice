using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Patika_Abstraction_Practice
{
    // "Calisanlar" (Çalışanlar) soyut sınıfı - Farklı geliştirici türleri için temel sınıf görevi görür.
    public abstract class Calısanlar
    {
        // Çalışanın adını ve soyadını tutan özellikler.
        public string Ad { get; set; }
        public string Soyad { get; set; }

        // Çalışanın adını ve soyadını başlatan kurucu metod (constructor).
        public Calısanlar(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }
        // Alt sınıflarda ezilmesi (override) zorunlu olan soyut görev metodu.
        public abstract void Gorev();
    }

    // "BackEndDeveloper" sınıfı, "Calisanlar" sınıfından türetilmiştir
    public class BackEndDeveloper : Calısanlar
    {
        public BackEndDeveloper(string ad, string soyad) : base(ad, soyad)
        {
        }
        public override void Gorev()
        {
            Console.WriteLine($"Ad : {Ad} || Soyad : {Soyad} || BackEnd Developer olarak çalışıyorum.");
        }
    }

    // "FrontEndDeveloper" sınıfı, "Calisanlar" sınıfından türetilmiştir
    public class FrontEndDeveloper : Calısanlar
    {
        public FrontEndDeveloper(string ad, string soyad) : base(ad, soyad)
        {
        }
        public override void Gorev()
        {
            Console.WriteLine($"Ad : {Ad} || Soyad : {Soyad} || FrontEnd Developer Olarak çalışıyorum.");
        }
    }

    // "SoftwareDeveloper" sınıfı, "Calisanlar" sınıfından türetilmiştir
    public class SoftwareDevleoper : Calısanlar
    {
        public SoftwareDevleoper(string ad, string soyad) : base(ad, soyad)
        {
        }
        public override void Gorev()
        {
            Console.WriteLine($"Ad : {Ad} || Soyad : {Soyad} || Yazılım Geliştirici olarak çalışıyorum.");
        }
    }
}
