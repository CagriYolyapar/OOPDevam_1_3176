using OOPDevam_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOPDevam_1
{
    public partial class Form1 : Form
    {

        /*
         
            Eger C#'ta oldugunu kesin bildiginiz bir yapıyı veya bir kodu intellisen getirmiyorsa bunun sebebi using alanında ilgili kütüphanenin ekli olmamasıdır...Böyle bir durumda ctrl+. tus kombinasyonuna basıp tooltip'ten cıkan using ifadesini eklemeniz gerekir... Veya ilgili yapının namespace'ini using tarafını yazabilirsiniz...

        Belirli senaryolarda ctrl+.'ya bastıgınızda bile ilgili tooltip'te using secenegi gelmeyebilir ve siz o kodun oldugundan eminsinizdir...Bu durumda Solution'daki ilgili projenizin referanslarına dikkat etmeniz gerekir...Cünkü o referans olmadan using ifadesi kütüphane icin gelmez...



        Class

        1 => Bir class'ın nesi vardır : Properties

        Bir sınıfın özelliklerini belirleyebilmek icin ona "Bu sınıfın nesi vardır" sorusunu sormalıyız...Bu sorunun cevabı bize o sınıfın property'lerini (özelliklerini) verecektir. Varsayalım ki bir Bilgisayar class'ınız var...Bu class'ın neleri oldugunu görmek icin sorudan alınan cevap : 
        ekran kartı, ana kartı, işlemcisi, ram, hdd,ssd

        primitive type(ilkel tip) : Tek bir deger ile temsil edilebilen yapılardır

        Bir class özelliklerinde

        Kitap Class'ı

        Ismi                          string (primitive type gibi davranır)
        SayfaSayisi                    int (primitive)
        Yazar                          Yazar(kompleks) class

        ***Properties Bitis
        *
        *
        *
        2 => Bu class ne yapar : Metotlar

        Class'larla konusurken sormanız gereken ikinci soru bu class ne yapar sorusudur

        Bir class'ın icerisinde hangi metotların yazılacagını anlamak icin onun görevlerini bilmek gerekir...Bu class ne yapabilir...Cevap size metotları verecektir...

         
         
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region TercihEdilmeyenSyntax

            //Tercih edilmez cünkü asagıdaki kodlarda Yazar nesnesine ulasmanın tek yolunun kitaptan gecmesini zorunlu kılıyoruz

            //Kitap k = new Kitap();
            //k.Isim = "Kuzgun";
            //k.SayfaSayisi = 100;



            //k.Yazari = new Yazar(); //Böylece k nesnesinin Yazari isimli property'sine bir Yazar nesnesi olusturup atıyoruz...
            //k.Yazari.Isim = "Edgar Allan";
            //k.Yazari.SoyIsim = "Poe";
            //k.Yazari.DogumYeri = "Amerika Birlesik Devletleri";

            //MessageBox.Show(k.Yazari.Isim); 

            #endregion

            //Profesyonel Yazım Tarzı : 

            Yazar y = new Yazar();
            y.Isim = "Edgar Allan";
            y.SoyIsim = "Poe";
            y.DogumYeri = "Amerika Birlesik Devletleri";

            Kitap k1 = new Kitap();
            k1.Isim = "Kuzgun";
            k1.SayfaSayisi = 100;

            k1.Yazari = y; //bu noktada k1 nesnemizin Yazari özelligine Yazar tipindeki y nesnesini atayarak o ilgili kitap nesnemizin Yazarını tanımasını saglıyoruz...




            //MessageBox.Show(y.BilgiGoster()); //Gördügünüz üzere hic kitap nesnesine ulasmadan bagımsız bir şekilde Yazar nesnemize ulasabiliyoruz

            //MessageBox.Show(k1.BilgiGoster());  //Aynı şekilde kitabımızın da yazarı belli olmus oluyor




        }

        //Bir Personel yapısı olusturun...Isim,SoyIsim ve TCKNo özellikleri olsun...Bir de BilgiGoster davranısı olsun...Isim, Soyisim ve TCKNo textbox'lardan alınsın...Yarat butonuna basıldıgında yeni bir personel yaratın (ismini ve soyismini ve kimligini textboxlardan alarak)...Sonra da yaratılan personel'in bilgilerini ListBox'a ekleyin...

        public void PersonelEkle(string isim,string soyIsim,string kimlik)
        {
            Personel p = new Personel();
            p.Isim = isim;
            p.SoyIsim = soyIsim;
            p.TCKNo = kimlik;
            LstSonuc.Items.Add(p.BilgiGoster());
        }

        private void BtnYarat_Click(object sender, EventArgs e)
        {
            PersonelEkle(TxtIsim.Text, TxtSoyIsim.Text, TxtKimlik.Text);
        }
    }
}
