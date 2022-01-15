using System;

namespace Arac_Satin_Alimi
{
    class Program
    {

        //public class Marka
        //{
        //    public String markaIsmi { get; set; }
        //}
        public enum KrediCekicem { kredicekilecek = 1, kredicekilmeyecek = 2 }
        public class Firma
        {
            private String FirmaIsmi { get; set; }
            public string ModelIsmi { get; set; }
            public string FirmaIsmiPublic { get { return FirmaIsmi; } set { FirmaIsmi = value; } }
            public string AractamIsmı { get { return String.Concat(FirmaIsmi, " ", ModelIsmi); } set { FirmaIsmi = value; } }
            public static aracversiyonları_fiyatı fiyatListesi;
            public static Mercedes_Arac_versiyonları versiyonları;

            public virtual void Bastir(string[] dizi, int[] dizi2)
            {
                Console.WriteLine("Bastir");
            }

        }
        public static string[] Mercedes_modelleri = {" A Serisi Sedan " + " CLA " + " S Serisi Maybach " + " GLC Coupe " + " Sprinter Servis " + " A Serisi " + " Vito Tourer / Select "
           + " C Serisi Coupe " + " G serisi " + " B Serisi " + " Sprinter Panelvan " + " GLB "};

        public class aracversiyonları_fiyatı : Firma
        {

            public static int[] A_Serisi_Sedan = { 722000, 782000 };
            public static int[] CLA = { 882000, 942000, 2107500 };
            public static int[] S_Serisi_Maybach = { 8625000 };
            public static int[] GLC_Coupe = { 1874500 };
            public static int[] Sprinter_Servis = { 548540, 552250, 562170 };
            public static int[] A_Serisi = { 767000, 2057000 };
            public static int[] Vito_Tourer = { 575350, 584390, 655290 };
            public static int[] C_Serisi_Coupe = { 1147500 };
            public static int[] G_serisi = { 4768000, 6744000 };
            public static int[] B_Serisi = { 725500 };
            public static int[] Sprinter_Panelvan = { 390730, 406270, 427870 };
            public static int[] GLB = { 972500, 1018000, 1058000 };



            // Diziyi Listeyede çevirebilirim.

            public override void Bastir(string[] dizi, int[] dizi2)
            {
                int i = 0;
                foreach (var item in dizi2)
                {
                    Console.WriteLine("Fiyat: ", item);
                    Console.WriteLine();
                }
            }

        }
        struct Tüm_aracların_fiyatı
        {
            public static int[] hepsi = { 722000, 782000, 882000, 942000, 2107500, 8625000, 1874500, 548540, 552250, 562170, 767000, 2057000, 575350, 584390, 655290 , 1147500, 4768000,
           6744000, 725500, 390730, 406270, 427870, 972500, 1018000, 1058000 };
        }
        struct Tüm_aracların_versiyonları
        {
            public static string[] hepsi = { " Progressive A 200+ ", "AMG A200+", " AMG 200 1.4 7G DCT+ ", " AMG 200 4 MATIC 1.4 8G DCT+ ", " Performance AMG 45 S 4MATIC+ ",
       " Inspiration+ S 580 4MATIC "," AMG 300 d 4MATIC "," Minibüs Orta Servis 10+1 ", " Minibüs Servis 15+1 ", "Minibüs Orta Servis 13+1 ", " AMG A 200 Benzinli 163 PS 7G-DCT+ ",
           " AMG Performance A 45 S 4MATIC+ ", " Base (8+1) 136 BG A/T Uzun RWD ", " Base (8+1) 136 BG A/T E. Uzun RWD ", "Pro (8+1) 163 BG A/T Uzun RWD",
       " AMG 200 4MATİC 1.5 184 PS 9G-Tronic "," Magnetic G 400 d 330 BG ", " Performance AMG G 63 585 BG ", " Progressive 180 1.4 136 BG 7G-DCT+ " , " Kamyonet Orta 143 BG 3.5T ",
           " Kamyonet Orta 143 BG 3.5T YT ", " Kamyonet Uzun 150 BG 3.5T "," Progressive 200 4MATIC 163 BG 8G-DCT ", " Progressive 200 4MATIC 163 BG 8G-DCT+ ", " AMG 200 4MATIC 163 BG 8G-DCT " };
        }
        public class Mercedes_Arac_versiyonları : Firma
        {
            public static string[] A_Serisi_Sedan = { " Progressive A 200+ ", "AMG A200+" };
            public static string[] CLA = { " AMG 200 1.4 7G DCT+ ", " AMG 200 4 MATIC 1.4 8G DCT+ ", " Performance AMG 45 S 4MATIC+ " };
            public static string[] S_Serisi_Maybach = { " Inspiration+ S 580 4MATIC " };
            public static string[] GLC_Coupe = { " AMG 300 d 4MATIC " };
            public static string[] Sprinter_Servis = { " Minibüs Orta Servis 10+1 ", " Minibüs Servis 15+1 ", "Minibüs Orta Servis 13+1 " };
            public static string[] A_Serisi = { " AMG A 200 Benzinli 163 PS 7G-DCT+ ", " AMG Performance A 45 S 4MATIC+ " };
            public static string[] Vito_Tourer = { " Base (8+1) 136 BG A/T Uzun RWD ", " Base (8+1) 136 BG A/T E. Uzun RWD ", "Pro (8+1) 163 BG A/T Uzun RWD" };
            public static string[] C_Serisi_Coupe = { " AMG 200 4MATİC 1.5 184 PS 9G-Tronic " };
            public static string[] G_serisi = { " Magnetic G 400 d 330 BG ", " Performance AMG G 63 585 BG " };
            public static string[] B_Serisi = { " Progressive 180 1.4 136 BG 7G-DCT+ " };
            public static string[] Sprinter_Panelvan = { " Kamyonet Orta 143 BG 3.5T ", " Kamyonet Orta 143 BG 3.5T YT ", " Kamyonet Uzun 150 BG 3.5T " };
            public static string[] GLB = { " Progressive 200 4MATIC 163 BG 8G-DCT ", " Progressive 200 4MATIC 163 BG 8G-DCT+ ", " AMG 200 4MATIC 163 BG 8G-DCT " };



            public override void Bastir(string[] dizi, int[] dizi2)
            {
                int i = 0;
                foreach (var item in dizi)
                {
                    Console.WriteLine(i + "- " + item + " Fiyat: " + dizi2[i]);
                    i++;
                }
                Console.WriteLine();
            }
        }
        public const string A_Serisi_Sedan = "1";
        public const string CLA = "2";

        public const string S_Serisi_Maybach = "3";
        public const string GLC_Coupe = "4";
        public const string Sprinter_Servis = "5";
        public const string A_Serisi = "6";
        public const string Vito_Tourer = "7";
        public const string C_Serisi_Coupe = "8";
        public const string G_serisi = "9";
        public const string B_Serisi = "10";
        public const string Sprinter_Panelvan = "11";
        public const string GLB = "12";
        static void Main(string[] args)
        {

            //List<Araba> arabaListe = new List<Araba>();
            //Program program = new Program();
            //String i;
            //do
            //{
            //    Console.WriteLine("İşlemler: 1-) Araba Ekle 2-) Ürün Listele  : (Çıkmak için -1 değerini giriniz)");
            //    i = Console.ReadLine();              
            //    switch (i)
            //    {
            //        case "1":
            //            program.ArabeEkle(arabaListe);
            //            break;
            //        case "2":
            //            break;
            //        default:
            //            break;
            //    }

            //} while (i != "-1");
            Firma mercedesFirması = new Firma();
            Mercedes_Arac_versiyonları test = new Mercedes_Arac_versiyonları();
            mercedesFirması.AractamIsmı = "MERCEDES";
            Console.WriteLine(mercedesFirması.FirmaIsmiPublic);
            Random rnd = new Random();


            int ss = 0;
            int tüm_fiyat = 0;

            int index = 0;
            int fiyat = 0;
            String i;
            Console.WriteLine("İsim ve Soyisim Giriniz: ");
            string isim = Console.ReadLine();
            do
            {
                Console.WriteLine("0-) Çıkış 1-) A Serisi 2-) CLA 3-) S_Serisi_Maybach 4-) GLC_Coupe 5-) Sprinter Servis 6-) A_Serisi 7-) Vito_Tourer 8-) C_Serisi_Coupe 9-) G_serisi 10-) B_Serisi 11-) Sprinter_Panelvan 12-)GLB 13-)Sizin için önerilen araç");
                i = Console.ReadLine();
                switch (i)
                {
                    case A_Serisi_Sedan:
                        Console.WriteLine("Modeller ve Fiyatları: ");
                        test.Bastir(Mercedes_Arac_versiyonları.A_Serisi_Sedan, aracversiyonları_fiyatı.A_Serisi_Sedan);
                        Console.WriteLine("0 dan 1'e kadar değer giriniz: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        mercedesFirması.ModelIsmi = Mercedes_Arac_versiyonları.A_Serisi_Sedan[index];
                        Console.WriteLine(mercedesFirması.AractamIsmı);
                        fiyat = aracversiyonları_fiyatı.A_Serisi_Sedan[index];
                        break;
                    case CLA:
                        Console.WriteLine("Modeller ve Fiyatları: ");
                        test.Bastir(Mercedes_Arac_versiyonları.CLA, aracversiyonları_fiyatı.CLA);
                        Console.WriteLine("0 dan 2'e kadar değer giriniz: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        mercedesFirması.ModelIsmi = Mercedes_Arac_versiyonları.CLA[index];
                        Console.WriteLine(mercedesFirması.AractamIsmı);
                        fiyat = aracversiyonları_fiyatı.CLA[index];
                        break;
                    case S_Serisi_Maybach:
                        Console.WriteLine("Modeller ve Fiyatları: ");
                        test.Bastir(Mercedes_Arac_versiyonları.S_Serisi_Maybach, aracversiyonları_fiyatı.S_Serisi_Maybach);
                        Console.WriteLine(String.Concat("0 dan 0'a kadar değer giriniz: "));
                        index = Convert.ToInt32(Console.ReadLine());
                        mercedesFirması.ModelIsmi = Mercedes_Arac_versiyonları.S_Serisi_Maybach[index];
                        Console.WriteLine(mercedesFirması.AractamIsmı);
                        fiyat = aracversiyonları_fiyatı.GLC_Coupe[index];
                        break;
                    case GLC_Coupe:
                        Console.WriteLine("Modeller ve Fiyatları: ");
                        test.Bastir(Mercedes_Arac_versiyonları.GLC_Coupe, aracversiyonları_fiyatı.GLC_Coupe);
                        Console.WriteLine("0 dan 0'a kadar değer giriniz: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        mercedesFirması.ModelIsmi = Mercedes_Arac_versiyonları.GLC_Coupe[index];
                        Console.WriteLine(mercedesFirması.AractamIsmı);
                        fiyat = aracversiyonları_fiyatı.GLC_Coupe[index];
                        break;
                    case Sprinter_Servis:
                        Console.WriteLine("Modeller ve Fiyatları: ");
                        test.Bastir(Mercedes_Arac_versiyonları.Sprinter_Servis, aracversiyonları_fiyatı.Sprinter_Servis);
                        Console.WriteLine("0 dan 2'ye kadar değer giriniz: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        mercedesFirması.ModelIsmi = Mercedes_Arac_versiyonları.Sprinter_Servis[index];
                        Console.WriteLine(mercedesFirması.AractamIsmı);
                        fiyat = aracversiyonları_fiyatı.Sprinter_Servis[index];
                        break;
                    case A_Serisi:
                        Console.WriteLine("Modeller ve Fiyatları: ");
                        test.Bastir(Mercedes_Arac_versiyonları.A_Serisi, aracversiyonları_fiyatı.A_Serisi);
                        Console.WriteLine("0 dan 1'e kadar değer giriniz: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(String.Concat(Mercedes_Arac_versiyonları.A_Serisi[index]));
                        fiyat = aracversiyonları_fiyatı.Vito_Tourer[index];
                        break;
                    case Vito_Tourer:
                        Console.WriteLine("Modeller ve Fiyatları: ");
                        test.Bastir(Mercedes_Arac_versiyonları.Vito_Tourer, aracversiyonları_fiyatı.Vito_Tourer);
                        Console.WriteLine("0 dan 2'ye kadar değer giriniz: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        mercedesFirması.ModelIsmi = Mercedes_Arac_versiyonları.Vito_Tourer[index];
                        Console.WriteLine(mercedesFirması.AractamIsmı);
                        fiyat = aracversiyonları_fiyatı.Vito_Tourer[index];
                        break;
                    case C_Serisi_Coupe:
                        Console.WriteLine("Modeller ve Fiyatları: ");
                        test.Bastir(Mercedes_Arac_versiyonları.C_Serisi_Coupe, aracversiyonları_fiyatı.C_Serisi_Coupe);
                        Console.WriteLine("0 dan 0'a kadar değer giriniz: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        mercedesFirması.ModelIsmi = Mercedes_Arac_versiyonları.C_Serisi_Coupe[index];
                        Console.WriteLine(mercedesFirması.AractamIsmı);
                        fiyat = aracversiyonları_fiyatı.C_Serisi_Coupe[index];
                        break;
                    case G_serisi:
                        Console.WriteLine("Modeller ve Fiyatları: ");
                        test.Bastir(Mercedes_Arac_versiyonları.G_serisi, aracversiyonları_fiyatı.G_serisi);
                        index = Mercedes_Arac_versiyonları.G_serisi.Length;
                        Console.WriteLine("0 dan 1'e kadar değer giriniz: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        mercedesFirması.ModelIsmi = Mercedes_Arac_versiyonları.G_serisi[index];
                        Console.WriteLine(mercedesFirması.AractamIsmı);
                        fiyat = aracversiyonları_fiyatı.G_serisi[index];
                        break;
                    case B_Serisi:
                        Console.WriteLine("Modeller ve Fiyatları: ");
                        test.Bastir(Mercedes_Arac_versiyonları.B_Serisi, aracversiyonları_fiyatı.B_Serisi);
                        Console.WriteLine("0 dan 0'a kadar değer giriniz: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        mercedesFirması.ModelIsmi = Mercedes_Arac_versiyonları.B_Serisi[index];
                        Console.WriteLine(mercedesFirması.AractamIsmı);
                        fiyat = aracversiyonları_fiyatı.B_Serisi[index];
                        break;
                    case Sprinter_Panelvan:
                        Console.WriteLine("Modeller ve Fiyatları: ");
                        test.Bastir(Mercedes_Arac_versiyonları.Sprinter_Panelvan, aracversiyonları_fiyatı.Sprinter_Panelvan);
                        Console.WriteLine("0 dan 2'ye kadar değer giriniz: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        mercedesFirması.ModelIsmi = Mercedes_Arac_versiyonları.Sprinter_Panelvan[index];
                        Console.WriteLine(mercedesFirması.AractamIsmı);
                        fiyat = aracversiyonları_fiyatı.Sprinter_Panelvan[index];
                        break;
                    case GLB:
                        Console.WriteLine("Modeller ve Fiyatları: ");
                        test.Bastir(Mercedes_Arac_versiyonları.GLB, aracversiyonları_fiyatı.GLB);
                        Console.WriteLine("0 dan 2'ye kadar değer giriniz: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        mercedesFirması.ModelIsmi = Mercedes_Arac_versiyonları.GLB[index];
                        Console.WriteLine(mercedesFirması.AractamIsmı);
                        fiyat = aracversiyonları_fiyatı.GLB[index];
                        break;
                    case "13":
                        ss = rnd.Next(0, Tüm_aracların_versiyonları.hepsi.Length);
                        Console.WriteLine(Tüm_aracların_versiyonları.hepsi[ss]);
                        fiyat = Tüm_aracların_fiyatı.hepsi[ss];
                        break;
                    default:
                        break;
                }
                if (i != "0")
                {
                    Console.WriteLine("---------------------------------------------------"); Console.WriteLine();
                    Console.WriteLine("Yeni bir araç seçmek istemiyorsanız 0'a basınız!!!");
                    Console.WriteLine("---------------------------------------------------"); Console.WriteLine();
                }
            } while (i != "0");
            if (i == "0" && fiyat == 0)
            {
                return;
            }
            int a = aracversiyonları_fiyatı.GLB[index];

            Console.WriteLine(" Mevcut bak" +
                "iyenizi giriniz: ");
            int bakiye = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mevcut bakiyeniz: " + bakiye);
            Console.WriteLine("Aracın fiyatı: " + fiyat);
            Console.WriteLine("Son durumda kalan mevcut bakiye: " + (bakiye - fiyat));



            //aracversiyonları_fiyatı();
            //  bakiye - aracversiyonları_fiyatı;



            string[] araba_markası = { " MERCEDES " + " BMW " + " AUDI " + " PEUGEOT " + " OPEL " + " DACIA " + " FORD " + "CITROEN" };


            //int yabancı_araba = Convert.ToInt16(Console.ReadLine());


            if (bakiye - fiyat < 0)
            {
                Console.WriteLine("Bakiyeniz Yetersiz");
                Console.WriteLine("Kredi çekmek istiyorsanız 1'e basınız , Çıkış yapmak istiyorsanız 2'ye basınız");
                int klavye = Convert.ToInt32(Console.ReadLine());
                if (klavye == Convert.ToInt32(KrediCekicem.kredicekilecek))
                {
                    Console.WriteLine("Kredi işlemleriniz başlatılmıştır. Satın alma işleminiz gerçekleştirilmiştir. İyi Günler " + isim);
                }
                else
                {
                    Console.WriteLine("Talebiniz doğrultusunda işleme devam edilmemektedir. İyi Günler " + isim);
                }
            }
            else
            {
                Console.WriteLine("Bakiyeniz Yeterli, Satın alma gerçekleştirilmiştir. İyi Günler " + isim);
            }

            Console.ReadKey();

        }
    }
}
