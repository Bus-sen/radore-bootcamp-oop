using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Insan
{  //başlangıç scope

    //propertise
    //access modifiers datatype değişkenadi
    public string adi = "ibrahim123";//alfanümerik 
    public string soyadi;
    //tam sayısal verileri saklamamızı 
    public int yas = 0;
    //küsüratlı kesirli sayıları saklayabiliriz
    public double maas = 0.0;
    //true yada false şeklide 
    public bool cinsiyet = false;

    //metotlar 2 ye ayrılırlar
    //geriye değer ve değer döndürmeyen şeklinde

    //access modifiers metodun dönüştipi metodadi()  {   }
    public void uyu(string isim)
    {
        Console.WriteLine(isim + " uyuyor");
    }

    public void Ebevyn(string isim, string soyisim)
    {
        Console.WriteLine(isim + " " + soyisim);
    }

    //boş constructor
    // Class ismi ile aynı ve geri dönüş tipi olmayan metodlara constructor denir
    public Insan()
    {

    }
    //parametre alan constructor 
    public Insan(string adi, string soyadi)
    {
        this.adi = adi;
        this.soyadi = soyadi;
    }

    public Insan(string adi, string soyadi, int yas, double maas, bool cinsiyet)
    {
        this.adi = adi;
        this.soyadi = soyadi;
        this.yas = yas;
        this.maas = maas;
        this.cinsiyet = cinsiyet;
    }


} //bitiş scope



