using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcBlogSitesi.Models
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategori = new List<Kategori>()
            {
                new Kategori(){KategoriAd ="C#"},
                new Kategori(){KategoriAd ="PHP"},
                new Kategori(){KategoriAd ="Java"},
               
            };

            foreach (var item in kategori)
            {
                context.Kategoris.Add(item);
            }

            context.SaveChanges();

            var makale = new List<Makale>()
            {
                new Makale(){Baslik="C# Dilindeki Temel Veri Türleri", Aciklama="C Eğitimi: C Programlama dili UNIX işletim sistemleri üzerinde sistem programlama yapabilmek için 1970 yılında geliştirilmiştir. C dili en eski programlama dillerinden biri olmasına rağmen; programcılar arasında popülerliğini korumuştur. C programlama dili derlenen bir dildir.", Resim = "blog.png",YayinTarihi=Convert.ToDateTime("2022-08-23") , Goruntulenme=0, Onay=true ,KategoriId=1,KullaniciAd="melisalpkaya"} ,
                new Makale(){Baslik="PHP Dilindeki Temel Veri Türleri", Aciklama="aaaaaaaabbbbbbb", Resim = "blog-2.png",YayinTarihi=Convert.ToDateTime("2022-08-21 ") , Goruntulenme=0, Onay=true ,KategoriId=2,KullaniciAd="denizalpkaya"},
                new Makale(){Baslik="Java Dilindeki Temel Veri Türleri", Aciklama="aaaaaaaabbbbbbbcccccc", Resim = "blog-3.png",YayinTarihi=Convert.ToDateTime("2022-08-20 ") , Goruntulenme=0, Onay=true ,KategoriId=3,KullaniciAd="denizalpkaya"},
               
            };

            foreach (var item in makale)
            {
                context.Makales.Add(item);
            }
            context.SaveChanges();
            base.Seed(context);
        }

    }
}