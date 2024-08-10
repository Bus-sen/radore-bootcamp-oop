// See https://aka.ms/new-console-template for more information
using Radore.Classes;
using Radore_OOP.Abstract_Classes;
using Radore_OOP.AbstractClasses;
using Radore_OOP.Classes;
using Radore_OOP.Constructors;
using Radore_OOP.Constructors2;
using Radore_OOP.Solid.kotu;
using System.Collections;
using System.Reflection.Metadata;
using System.Reflection;
using Radore_OOP.Odevler.Odev1;
using Radore_OOP.Odevler.Odev2;
using Radore_OOP.Odevler.Odev3;
using Radore_OOP.Solid.iyi;
using Radore_OOP.Solid;
using Radore_OOP.Overrides;

/*
//ClassIsmi nesneAdi = new ClassAdi();
Insan i = new Insan();
i.adi = "büşra";
i.soyadi = "şen";
i.yas = 24;
i.maas = 3.14;
i.cinsiyet = true;
i.uyu(i.adi);

//constructor kullanarak oluşturursak
Insan i2 = new Insan("kübra", "şen");
Insan i3 = new Insan("aslı", "demirel", 23, 3.14, false);

//Araba
Araba a = new Araba();
a.marka = "bmw";
a.model = "x5";
a.kapiSayisi = 4;
a.pencereSayisi = 4;
a.Git(a.marka, a.model);

//Anne
Anne k = new Anne();
k.adi = "kevser";
k.soyadi = "şen";
k.Ebevyn(k.adi, k.soyadi);
k.oku(k.adi);
k.yaz(k.adi);

//Baba
Baba b = new Baba();
b.adi = "lütfi";
b.soyadi = "şen";
b.Ebevyn(b.adi, b.soyadi);
b.oku(b.adi);
b.dinle(b.adi);

//Cocuk
Cocuk c = new Cocuk();
c.adi = "büşra";
c.soyadi = "şen";
c.Ebevyn(c.adi, c.soyadi);

AkilliCocuk ak = new AkilliCocuk();
//ak.adSoyadSifat("Hakan", "Yılmaz", "Akıllıdır");
ak.adi = "Hakan";
ak.soyadi = "Yılmaz";
ak.oku(ak.adi);
ak.dinle(ak.adi);
ak.yaz(ak.adi);

UsluCocuk us = new UsluCocuk();
us.adi = "Mehmet";
us.soyadi = "Yıldız";
us.sifat = "Usludur";
//us.adSoyadSifat(us.adi, us.soyadi, us.sifat);
us.dinle("Mehmet");
us.yaz(us.adi);

Matematik m = new Matematik();
int gelenDeger = m.topla(5, 5);
Console.WriteLine("toplam: " + gelenDeger);
*/

/*
//------------- ODEV1 ---------------
GenelMudur gm = new GenelMudur();
gm.maas = 80000;
gm.Calisanlar(gm.unvan, gm.maas);
Mudur md = new Mudur();
md.maas = 60000;
md.Calisanlar(md.unvan, md.maas);
Programci pr = new Programci();
pr.maas = 40000;
pr.Calisanlar(pr.unvan, pr.maas);
Stajyer s = new Stajyer();
s.maas = 5000;
s.Calisanlar(s.unvan, s.maas);
//Maaşların toplamı
Console.WriteLine("Maaşların toplamı: " + (md.maas + gm.maas + pr.maas + s.maas));
*/

/*
// ----- ODEV1 ÇÖZÜM -----
GenelMud gm = new GenelMud();
Mud md = new Mud();
Programc pg = new Programc();
Stajyr s = new Stajyr();

double toplamMaas = 0.0;
toplamMaas += gm.maasinizNedir();
toplamMaas += md.maasinizNedir();
toplamMaas += pg.maasinizNedir();
toplamMaas += s.maasinizNedir();
Console.WriteLine(toplamMaas);

//----- constructor ------
Goz goz = new Goz("kahverengi");
Kulak kulak = new Kulak("geniş");
Burun burun = new Burun("kemerli");
Kafa kafa = new Kafa(goz, kulak, burun);
YeniInsan yeni = new YeniInsan("büşra", "şen", kafa);
yeni.randevuKayit();

//constructor2 (SORU1)
Marka marka = new Marka("BMW");
Model model = new Model("x5");
Kapi kapi = new Kapi(4);
Pencere pencere = new Pencere(4);

Kasa kasa = new Kasa(marka, model, kapi, pencere, "Sedan");
YeniAraba yeniAraba = new YeniAraba(kasa, 2000000.0);
yeniAraba.siparisVer();

//------ diziler ------
//1.yöntem
string[] gunler = new string[7];
gunler[0] = "pazartesi";
gunler[1] = "salı";
gunler[2] = "çarşamba";
gunler[3] = "perşembe";
gunler[4] = "cuma";
gunler[5] = "cumartesi";
gunler[6] = "pazar";
for (int x = 0; x < gunler.Length; x++)
{
    Console.WriteLine(gunler[x]);
}

//2.yöntem
int[] sayilar = { 2, 4, 6, 7, 9, 11, 22, 33, 44, 55, 66 };
int toplam = 0;
for (int y = 0; y < sayilar.Length; y++)
{
    toplam = toplam + sayilar[y];
}
Console.WriteLine("Toplam: " + toplam);

//(SORU2)
Calisan[] calisanlar = { gm, md, pg, s };
double maasToplam = 0.0;
for (int z = 0; z < calisanlar.Length; z++)
{
    maasToplam += calisanlar[z].maasinizNedir();
}
Console.WriteLine("Toplam maaş: " + maasToplam);

//------ Arraylist ------
ArrayList liste = new ArrayList();
liste.Add("büşra");
liste.Add(10);
liste.Add(1.95);
liste.Insert(0, i); //ilk sıraya ekler
if (liste.Contains("büşra"))
{
    Console.WriteLine("ilgili kişi listede var");
}
else
{
    Console.WriteLine("ilgili kişi listede yok");
}

//generic classlar boxing ve unboxing işlemlerin performans kaybını da engeller
List<int> list = new List<int>(); //yalnızca int tipinde değişken olabilir

//(SORU3)
List<Personel> personelListesi = new List<Personel>();
Personel p1 = new Personel("büşra", "şen", 5000.0);
Personel p2 = new Personel("hakan", "yılmaz", 4000.0);
Personel p3 = new Personel("metin", "yıldız", 7000.0);
personelListesi.Add(p1);
personelListesi.Add(p2);
personelListesi.Add(p3);
double personelMaas = 0.0;

foreach (Personel personel in personelListesi)
{
    Console.WriteLine("Personel adı: " + personel.adi + " Soyadı: " + personel.soyadi + " Maaşı: " + personel.maas);
    personelMaas += personel.maas;
}
Console.WriteLine("Toplam maaş: " + personelMaas);

// --- logger
// kotu durum:
DbLog dbLog = new DbLog();
XmlLog xmlLog = new XmlLog();
JsonLog jsonLog = new JsonLog();
Logger logger = new Logger(dbLog, xmlLog, jsonLog);
logger.LogKaydet(LogType.Db, "303 nolu hata kodu oluştu"); 

// iyi durum (ODEV3 COZUM):
DbLog2 dbLog2 = new DbLog2();
XmlLog2 xmlLog2 = new XmlLog2();
Logger logger = new Logger(xmlLog2);
logger.LogKaydet("303 nolu hata kodu oluştu");

//------ ODEV2 ------
Bmw bmw = new Bmw();
bmw.uc("bmw");
bmw.yuz("bmw");
bmw.git("bmw");
Mercedes mrc = new Mercedes();
mrc.uc("mercedes");
mrc.yuz("mercedes");
Porsche prs  = new Porsche();
prs.git("porsche");
double toplamBenzin = 0.0;
toplamBenzin += bmw.benzinHarca();
toplamBenzin += mrc.benzinHarca();
toplamBenzin += prs.benzinHarca();
Console.WriteLine("Toplam harcanan benzin: " +toplamBenzin);

//------ ODEV3 ------
O_DbLog o_DbLog = new O_DbLog();
O_XmlLog o_XmlLog = new O_XmlLog();
O_JsonLog o_JsonLog = new O_JsonLog();
O_LogType o_LogType = new O_LogType();
Logger2 logger2 = new Logger2(o_LogType, o_JsonLog);
logger2.LogKayit(O_LogType.Json, "303 nolu hata kodu oluştu");
*/

Child c = new Child();
c.yaz();
