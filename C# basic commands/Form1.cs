


namespace vari_yapilari_kod_bolumuÇ
{
    public partial class Form1 : Form
    {
        int a;
        int b = 7;
        char c;
        float d;
        double k;
        string deger = "nevü";
        int sayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //fnk_mesaj();
            double sayi1 = 9;
            double sayi2 = 8;

            //Matematiksel Operatörler + - * / %-> mod alma 

            double toplam = sayi1 + sayi2;
            double fark = sayi1 - sayi2;
            double carp = sayi1 * sayi2;
            double bolum = sayi1 / sayi2;
            double modu = sayi1 % sayi2;

            txt_o3_1.Focus();

           

            //Mantýksal operatörler 
            // == != < > >= =<
            // && -> ve  || -> veya

            //MessageBox.Show("Kod Yazmaya Baþlýyoruz");
            //MessageBox.Show(Convert.ToString(modu));

            Random rnd = new Random();
            sayi = rnd.Next(100);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            int sayi1 = 8;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bilgi = Convert.ToInt32( txt_o1.Text);

            MessageBox.Show(Convert.ToString(bilgi));

            txt_o1.Clear();
            //txt_o1.Text="";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ahmet = Convert.ToInt32(txt_o2_1.Text);
            int mehmet = Convert.ToInt32(txt_o2_2.Text);
            int toplam = ahmet + mehmet;

            MessageBox.Show(Convert.ToString(toplam));
            lbl_o2.Text =Convert.ToString( toplam);
            txt_o2_3.Text = Convert.ToString(toplam);
        }

         private void button3_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txt_o3_1.Text);
            double sayi2 = Convert.ToDouble(txt_o3_2.Text);
            double tpl = sayi1 + sayi2;
            txt_o3_3.Text = Convert.ToString(tpl);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txt_o3_1.Text);
            double sayi2 = Convert.ToDouble(txt_o3_2.Text);
            double tpl = sayi1 - sayi2;
            txt_o3_3.Text = Convert.ToString(tpl);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txt_o3_1.Text);
            double sayi2 = Convert.ToDouble(txt_o3_2.Text);
            double tpl = sayi1 * sayi2;
            txt_o3_3.Text = Convert.ToString(tpl);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txt_o3_1.Text);
            double sayi2 = Convert.ToDouble(txt_o3_2.Text);
            double tpl = sayi1 / sayi2;
            txt_o3_3.Text = Convert.ToString(tpl);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txt_o3_1.Text);
            double sayi2 = Convert.ToDouble(txt_o3_2.Text);
            double tpl = sayi1 % sayi2;
            txt_o3_3.Text = Convert.ToString(tpl);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // if yapýsý
            //1. mimari
            if (false)
            {
                MessageBox.Show("if içersindeyiz");
            }

            //2. mimari
            if (false)
            {
                MessageBox.Show("if içersindeyiz");
            }
            else
            {
                MessageBox.Show("else blogu içerisindeyiz");
            }

            //3. mimari
            if (3<2)
            {

            }
            else if (6>3)
            {
                MessageBox.Show("6>3 içerisindeyiz");
            }
            else if (2<7)
            {
                MessageBox.Show("2<7 içerisindeyiz");
            }
            else { 
            
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int veri1 = Convert.ToInt32(txt_o4_1.Text);
            int veri2 = Convert.ToInt32(txt_o4_2.Text);

            if (veri1 < veri2)
            {
                MessageBox.Show("Küçük Sayý :" + veri1);
            }
            else if (veri1 > veri2)
            {
                MessageBox.Show("Küçük Sayý :" + veri2);
            }
            else
            {
                MessageBox.Show("Sayýlar Eþittir");
            }


        }

        private void button10_Click(object sender, EventArgs e)
        {
            //KULLANICININ GÝRMÝÞ OLDUGU DEGERÝN TEK MÝ ÇÝFT MÝ
            //OLDUGUNU BULAN VE SONUCU MESAJ OLARAK VEREN PROG.

            if (txt_o5.Text != "")
            {
                int sayi = Convert.ToInt32(txt_o5.Text);

                if (sayi % 2 == 0)
                {
                    MessageBox.Show("Deger Çifttir");
                }
                else 
                {
                    MessageBox.Show("Deger Tektir");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Deger Giriniz!");
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //For döngüsü

            for (int i=0; i<5; i=i+1)//(i++)
            {
                MessageBox.Show(Convert.ToString(i));
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            /*ALGORÝTMA
            1 - Baþla
            2 - toplam=0;sayac=0;
            3- toplam=toplam+sayac;
            4- sayac=sayac+1;
            5- eger sayac<11 -> 3. adýma dön
            6- toplamý yazýdr
            7- Bitir.
            */

            int toplam = 0;
            for (int i=1; i<11; i=i+1)//0-11 arasýnda sayýlarý elde etmemizi saglar
            {
                toplam = toplam + i;
            }
            MessageBox.Show("Toplamýn sonucu:" + toplam);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            // 0 ile kullanýcýnýn girmiþ oldugu deger ARASINDAKÝ
            // sayýlarýn toplamýný bulan ve sonucu mesaj olarak veren
            //programý yazýnýz

            if (txt_o7.Text!="")
            {
                int sayi = Convert.ToInt32(txt_o7.Text);
                int tpl = 0;
                
                for (int i=0; i<sayi; i=i+1)
                {
                    tpl = tpl + i;
                }

                MessageBox.Show("Toplam sonucu : "+tpl);
            }
            else
            {
                MessageBox.Show("Lütfen bir sayý giriniz");
            }

            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            /*
             Kullanýcýnýn girmiþ oldugu 2 deger arasýndaki sayýlarýn 
                toplamýný bulan programý yazýnýz
             */
            if ( (txt_o8_1.Text!="") && (txt_o8_2.Text!="") )
            {
                int sayi1 = Convert.ToInt32(txt_o8_1.Text);
                int sayi2 = Convert.ToInt32(txt_o8_2.Text);
                int sayi_kucuk = 0;
                int sayi_buyuk = 0;
                int toplam = 0;
                if (sayi1 < sayi2)
                {
                    sayi_kucuk = sayi1;
                    sayi_buyuk = sayi2;
                }
                else
                {
                    sayi_kucuk = sayi2;
                    sayi_buyuk = sayi1;
                }

                for (int i=(sayi_kucuk+1); i<sayi_buyuk; i=i+1 )
                {
                    toplam = toplam + i;
                }

                MessageBox.Show("Sonuç:"+toplam);
            }
            else
            {
                MessageBox.Show("Eksik bilgi girildi");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            /*
             Kullanýcýnýn girmiþ oldugu degerler arasýnda kaç tane
            çift sayý oldugunu bulan ve sonucu bir textbox' a yazdýran
            programý yazýnýz
             */

            if ( (txt_o9_1.Text=="") || (txt_o9_2.Text==""))
            {
                MessageBox.Show("Eksik bilgi girildi");
            }
            else
            {
                int sayi1 = Convert.ToInt32(txt_o9_1.Text);
                int sayi2 = Convert.ToInt32(txt_o9_2.Text);

                int sayi_kucuk = 0;
                int sayi_buyuk = 0;

                if (sayi1<sayi2)
                {
                    sayi_kucuk = sayi1;
                    sayi_buyuk = sayi2;
                }
                else
                {
                    sayi_kucuk = sayi2;
                    sayi_buyuk = sayi1;
                }

                int sayac = 0;
                for (int i=(sayi_kucuk+1); i<sayi_buyuk; i=i+1)
                {
                    if (i%2==0)//çifttir
                    {
                        sayac = sayac + 1;
                    }
                }

                txt_o9_3.Text = Convert.ToString(sayac);

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int rastgele_sayi = rnd.Next(50,100);

            MessageBox.Show(Convert.ToString(rastgele_sayi));
            
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // Sayý Tahmin Oyunu yapmanýzý istiyorum
            /*
             Kullanýcý programýn tutmuþ olduðu sayýyý tahmin etmeye çalýþacak
            program kullanýcýyý daha yüksek bir sayý girin veya daha küçük 
            bir sayý girin þeklinde yönetecek. Kullanýcý sayýyý dogru tahmin
            ettiðinde tebrikler kazandýnýz diyecek (0-100 arasýnda)
             */

            if (txt_o10.Text != "")
            {
              
                int tahmin = Convert.ToInt32(txt_o10.Text);

                if (sayi < tahmin)
                {
                    MessageBox.Show("Lütfen küçük bir sayý girin");
                }
                else if (sayi > tahmin)
                {
                    MessageBox.Show("Lütfen büyük bir sayý girin");
                }
                else
                {
                    MessageBox.Show("Tebrikler");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir sayý giriniz");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Random r2 = new Random();

            sayi = r2.Next(100);    
        }

        private void button19_Click(object sender, EventArgs e)
        {
            /*Kullanýcýnýn girmiþ olduðu 2 deger arasýnda 
             5' e bölünen sayýlarýn ortalamasýný bulan programý
            while döngüsü ile hesaplayýnýz ve mesaj olarak veriniz?*/

            if (txt_o11_1.Text != "" && txt_o11_2.Text != "")
            {
                int sayi1 = Convert.ToInt32(txt_o11_1.Text);
                int sayi2 = Convert.ToInt32(txt_o11_2.Text);

                int sayi_k = 0;
                int sayi_b = 0;

                if (sayi1 < sayi2)
                {
                    sayi_k = sayi1;
                    sayi_b = sayi2;
                }
                else
                {
                    sayi_k = sayi2;
                    sayi_b = sayi1;
                }

                double toplam = 0;
                double sayac = 0;
                sayi_k = sayi_k + 1;
                while (sayi_k<sayi_b)
                {

                    if (sayi_k % 5 == 0)
                    {
                        toplam = toplam + sayi_k;
                        sayac = sayac + 1;
                    }

                    sayi_k = sayi_k + 1;
                }

                double sonuc = toplam / sayac;

                MessageBox.Show("Ortalama:"+sonuc);


            }
            else
            {
                MessageBox.Show("Deger giriniz");
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            //WHILE YAPISI
            int i = 0;
            while (i<5)
            {
                MessageBox.Show(Convert.ToString(i));
                i=i + 1;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            int[] dizi1 = {1, 4, 6, 8, 9};
            string[] dizi2 = { "akif", "nevü" };

            //MessageBox.Show(Convert.ToString(dizi1[1]));
            //MessageBox.Show(dizi2[0]);

            dizi1[0] = 8;

            for (int i = 0; i < 5; i++)
            {
                //MessageBox.Show(Convert.ToString(dizi1[i]));
            }

            int[] dizi_3 = new int[5];
            string[] dizi_4 = new string[6];

            dizi_3[0] = 8;
            dizi_3[1] = 2;
            dizi_3[2] = 4;
            dizi_3[3] = 8;
            dizi_3[4] = 10;

            int boyut = dizi_3.Length;

            MessageBox.Show(Convert.ToString(boyut));
        }

        private void button22_Click(object sender, EventArgs e)
        {
            /*1 ile 100 arasý rastgele elemanlardan oluþan 
             5 elemanlý bir dizi oluþturun dizi elemanlarýný mesaj
            olarak yazdýrýn?*/

            int[] dizi = new int[5];

            Random rnd = new Random();

            for (int i=0; i<dizi.Length;i=i+1)
            {
                dizi[i] = rnd.Next(0, 100);                
            }

            for (int j = 0; j < dizi.Length;j++)
            {
                MessageBox.Show(Convert.ToString(dizi[j]));
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            /* kullanýcýnýn girmiþ oldugu degerler arasýnda 
            yine kullanýcýnýn girmiþ oldugu deger kadar
            rastgele elemanlardan oluþan bir dizi oluþturun?*/

            if (txt_o12_1.Text != "" && txt_o12_2.Text != "" && txt_o12_3.Text != "")
            {
                int sayi1 =Convert.ToInt32( txt_o12_1.Text);
                int sayi2 = Convert.ToInt32(txt_o12_2.Text);
                int boyut = Convert.ToInt32(txt_o12_3.Text);

                int[] dizi = new int[boyut];
                Random rnd = new Random();

                int k_sayi = 0;
                int b_sayi = 0;

                if (sayi1 < sayi2)
                {
                    k_sayi = sayi1;
                    b_sayi = sayi2;
                }
                else
                {
                    k_sayi = sayi2;
                    b_sayi = sayi1;
                }

                lb_o12.Items.Clear();//listbox içerisindeki elemanlarý temizler
                
                for (int i=0;i<dizi.Length;i++)
                {
                    dizi[i] = rnd.Next((k_sayi+1), b_sayi);
                    lb_o12.Items.Add(dizi[i]);
                }

            }
            else
            {
                MessageBox.Show("Eksik bilgi girildi");
            }

        }

        private void button24_Click(object sender, EventArgs e)
        {
            /*Kullanýcýnýn girmiþ oldugu degerler arasýnda
             yine kullanýcýnýn girmiþ oldugu deger kadar
            rastgele çift elemanlardan oluþan dizinin ortalamasýný
            bulan programý yazýnýz? dizi elemanlarý listbox'da 
            listelenecek. Sonuç bir textbox' a yazdýrýlacak*/

            if (txt_o13_1.Text != "" && txt_o13_2.Text != "" && txt_o13_3.Text != "")
            {
                int sayi1 = Convert.ToInt32(txt_o13_1.Text);
                int sayi2 = Convert.ToInt32(txt_o13_2.Text);
                int boyut = Convert.ToInt32(txt_o13_3.Text);
                int[] dizi = new int[boyut];
                int sayi_b = 0;
                int sayi_k = 0;

                if (sayi1 < sayi2)
                {
                    sayi_k = sayi1;
                    sayi_b = sayi2;
                }
                else
                {
                    sayi_k = sayi2;
                    sayi_b = sayi1;
                }

                Random rnd = new Random();
                double toplam = 0;
                lb_13.Items.Clear();
                for (int i=0;i<dizi.Length;i++)//i=3 için 
                {
                    int r_sayi = rnd.Next((sayi_k + 1), sayi_b);
                    if (r_sayi % 2 == 0)
                    {
                        dizi[i] = r_sayi;
                        toplam = toplam + dizi[i];
                        lb_13.Items.Add(dizi[i]);
                    }
                    else
                    {
                        i = i - 1;
                    }

                }
                double ort = toplam / boyut;

                txt_o13_4.Text = Convert.ToString(ort);

            }
            else
            {
                MessageBox.Show("Eksik bilgi girildi");
            }
        }

        private void groupBox19_Enter(object sender, EventArgs e)
        {

        }

        public void fnk_dizi_ortalama(int sayi1, int sayi2, int boyut)
        {

            int[] dizi = new int[boyut];
            Random rnd = new Random();
            int sayi_b = 0;
            int sayi_k = 0;

            if (sayi1 < sayi2)
            {
                sayi_k = sayi1;
                sayi_b = sayi2;
            }
            else
            {
                sayi_k = sayi2;
                sayi_b = sayi1;
            }

            int varmi = 0;
            lb_14.Items.Clear();
            for (int i = 0; i < boyut; i++)
            {
                int rasgele_sayi = rnd.Next((sayi_k + 1), sayi_b);
                for (int j = 0; j < i; j++)//linear search
                {
                    if (dizi[j] == rasgele_sayi)
                    {
                        varmi = 1;
                    }
                }

                if (varmi == 0)
                {
                    dizi[i] = rasgele_sayi;
                    lb_14.Items.Add(dizi[i]);
                }
                else
                {
                    i = i - 1;
                    varmi = 0;
                }

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            /*Kullanýcýnýn girmiþ oldugu degerler arasýnda
            yine kullanýcýnýn girmiþ oldugu deger kadar rastgele
            tekrar etmeyen elemanlardan oluþan dizinin ortalamasýný
            bulan programý yazýnýz? dizi elemanlarý listbox'da 
            listelenecek. Sonuç bir textbox' a yazdýrýlacak*/
           
            if (txt_o14_1.Text != "" && txt_o14_2.Text != "" && txt_o14_3.Text != "")
            {
                int sayi1 = Convert.ToInt32(txt_o14_1.Text);
                int sayi2 = Convert.ToInt32(txt_o14_2.Text);
                int boyut = Convert.ToInt32(txt_o14_3.Text);

                int[] dizi = new int[boyut];
                Random rnd = new Random();
                int sayi_b = 0;
                int sayi_k = 0;

                if (sayi1 < sayi2)
                {
                    sayi_k = sayi1;
                    sayi_b = sayi2;
                }
                else
                {
                    sayi_k = sayi2;
                    sayi_b = sayi1;
                }

                int varmi = 0;
                lb_14.Items.Clear();
                for (int i=0; i<boyut; i++)
                {
                    int rasgele_sayi = rnd.Next((sayi_k + 1), sayi_b);
                    for (int j=0;j<i; j++)//linear search
                    {
                        if (dizi[j]==rasgele_sayi)
                        {
                            varmi = 1;  
                        }
                    }

                    if (varmi == 0)
                    {
                        dizi[i] = rasgele_sayi;
                        lb_14.Items.Add(dizi[i]);
                    }
                    else
                    {
                        i = i - 1;
                        varmi = 0;
                    }

                }


            }
            else
            {
                MessageBox.Show("Eksik bilgi girildi");
            }
        }

        //FONKSÝYONLAR

        private void fnk_mesaj()
        {
            MessageBox.Show("Fonksiyon içerisindeyiz");
        }

        public void fnk_mesaj_parametreli(string a)//a="akif"
        {
            MessageBox.Show(a);
        }

        //parametre olrak almýþ oldugu 2 degeri toplayan ve sonucu geri gönedren bir fonk.

        public int fnk_topla(int a, int b)//a=5 b=4
        {
            int toplam = a + b;
           // fnk_mesaj_parametreli(Convert.ToString( toplam));
            return toplam;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //fnk_mesaj();
            //fnk_mesaj_parametreli("akif");
            int sonuc= fnk_topla(5, 4);
            fnk_mesaj_parametreli(Convert.ToString(sonuc));
            
        }

        /*parametre olarak almýþ oldugu bir degerin faktörüyelini hesaplayan
         ve sonucu geri gönderen bir fonksiyon yazýnýz ve kullanýnýz*/

        public int fnk_faktoriyel(int a)
        {
            int fk = 1;
            for (int i=1; i<=a;i++)
            {
                fk = fk * i;
            }

            return fk;
        }


        private void button27_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_o15_1.Text);
            int sayi2 = Convert.ToInt32(txt_o15_2.Text);

            int sonuc = fnk_topla(sayi1, sayi2);
            fnk_mesaj_parametreli(Convert.ToString(sonuc));

           //fnk_mesaj_parametreli(Convert.ToString(fnk_topla(sayi1, sayi2)));
        }

        private void button28_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txt_o16.Text);
            int sonuc = fnk_faktoriyel(sayi);
            fnk_mesaj_parametreli(Convert.ToString(sonuc));
        }
        /* Parametre olarak almýþ olduðu degerler arasýndaki
         * 5'e bölünen sayýlarýn ortalamasýný bulan bir fonk. yazýnýz
         ve kullanýnýz*/

        public void fnk_ort_5(int a, int b)
        {
            int sayi_k = 0;
            int sayi_b = 0;

            if (a < b)
            {
                sayi_k = a;
                sayi_b = b;
            }
            else
            {
                sayi_k = b;
                sayi_b = a;
            }

            double toplam = 0;
            double sayac = 0;

            for (int i=(sayi_k+1);i<sayi_b;i++)
            {
                if (i % 5 == 0)
                {
                    toplam = toplam + i;
                    sayac = sayac + 1;
                }
            }

            double ortalama = toplam / sayac;
                               
        }
        /*Parametre olarak almýþ oldugu bir dizinin en küçük 
         degerini bulan ve bu degeri geri gönderen bir fonk. yazýnýz
        kullanýnýz?

        parametre olarak gönderilecek dizi elemanlarý
        kullanýcdan alýnan 2 deger arasýnda rastgele olarak yine
        kullanýcýnýn girmiþ oldugu deger kadardýr

        dizi elemanlarýný bir listbox a yazdýrýn
         */

        public int fnk_dizi_ek(int[] dizi)
        {
            int ek_deger = dizi[0];

            for (int i=0;i<dizi.Length;i++)
            {
                if (ek_deger > dizi[i])
                {
                    ek_deger = dizi[i];
                }
            }
            return ek_deger;
        }

        /*lineer arama yapan bir fonksiyon yazýnýz true/false */

        public bool fnk_lineer_search(int[] dizi, int a)
        {
            bool arama = false;

            for (int i=0; i<dizi.Length; i++)
            {
                if (dizi[i]==a)
                {
                    arama = true;
                }
            }
            return arama;
        }

        /* Parametre olarak almýþ oldugu bir diziyi 
         * küçükten büyüðe sýralayan bir fonksiyon yazýnýz 
         
         yürütme zamaný fonk hesaplayýn
         */
        public int[] fnk_sirala(int[] dizi)
        {
            int min;
            int temp;
            for (int i=0; i<dizi.Length; i++)
            {
                min = i;
                for (int j = i; j < dizi.Length; j++)
                {
                    if (dizi[min] > dizi[j])
                    {
                        min = j;
                    }
                }
                temp = dizi[i];
                dizi[i] = dizi[min];
                dizi[min] = temp;
            }
            return dizi;
        }
        private void button29_Click(object sender, EventArgs e)
        {
            if (txt_o17_1.Text != "" && txt_o17_2.Text != "" && txt_o17_3.Text != "")
            {
                int sayi1 = Convert.ToInt32(txt_o17_1.Text);
                int sayi2 = Convert.ToInt32(txt_o17_2.Text);
                int boyut=Convert.ToInt32(txt_o17_3.Text);

                int sayi_b = 0;
                int sayi_k = 0;

                if (sayi1 < sayi2)
                {
                    sayi_k = sayi1;
                    sayi_b = sayi2;
                }
                else
                {
                    sayi_k = sayi2;
                    sayi_b = sayi1;
                }

                int[] dizi = new int[boyut];
                Random rnd = new Random();
                lb_17.Items.Clear();
                for (int i=0;i<boyut;i++)
                {
                    dizi[i] = rnd.Next((sayi_k + 1), sayi_b);
                    lb_17.Items.Add(dizi[i]);
                }

                int ek = fnk_dizi_ek(dizi);
                txt_o17_4.Text = Convert.ToString(ek);

            }
            else
            {
                MessageBox.Show("Eksik bilgi girildi");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (txt_o18_1.Text != "" && txt_o18_2.Text != "" && txt_o18_3.Text != "")
            {
                int sayi1 = Convert.ToInt32(txt_o18_1.Text);
                int sayi2= Convert.ToInt32(txt_o18_2.Text);
                int boyut = Convert.ToInt32(txt_o18_3.Text);

                lb_18_1.Items.Clear();
                lb_18_2.Items.Clear();

                int[] dizi = new int[boyut];

                int[] dizi_gelen = new int[boyut];
                Random rnd = new Random();

                for (int i=0;i<boyut;i++)
                {
                     dizi[i] = rnd.Next((sayi1 + 1), sayi2);
                    lb_18_1.Items.Add(dizi[i]);
                }
                dizi_gelen = fnk_sirala(dizi);
                for (int j = 0; j < boyut; j++)
                {
                    lb_18_2.Items.Add(dizi_gelen[j]);
                }


                

                
            }
            else
            {
                MessageBox.Show("Eksik bilgi girildi");
            }
        }

        /*Parametre olarak almýþ oldugu  iki dizi 
         * elemanlarýndan en büyük degeri bulan ve 
         * degeri geri gönderen bir fonksiyon yazýnýz 
         * ve kullanýnýz? */

        public int fnk_dizi_karsilastir(int[] dizi1, int[] dizi2)
        {
            int eb = dizi1[0];

            for (int i=0; i<dizi1.Length; i++)
            {
                if (dizi1[i] > eb)
                {
                    eb = dizi1[i];
                }
            }
            //eb içerisinde dizi 1' deki en büyük eleman bulunur

            for (int j=0; j<dizi2.Length; j++)
            {
                if (dizi2[j] > eb)
                {
                    eb = dizi2[j];
                }
            }
            return eb;
        }

        private void groupBox25_Enter(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_o19_1.Text);
            int sayi2 = Convert.ToInt32(txt_o19_2.Text);
            int boyut = Convert.ToInt32(txt_o19_3.Text);
            int[] dizia = new int[boyut];
            int[] dizib = new int[boyut];
            Random rastgele = new Random();

            lb_19_1.Items.Clear();
            lb_19_2.Items.Clear();

            for (int i=0; i<boyut; i++)
            {
                dizia[i] = rastgele.Next(sayi1, sayi2);
                lb_19_1.Items.Add(dizia[i]);
                dizib[i] = rastgele.Next(sayi1, sayi2);
                lb_19_2.Items.Add(dizib[i]);
            }
            int sonuc = fnk_dizi_karsilastir(dizia, dizib);

            txt_o19_4.Text = Convert.ToString(sonuc);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                MessageBox.Show("Ýþaretlendi");
            }
            else
            {
                MessageBox.Show("Ýþaret Kaldýrýldý");
            }

            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Týklandý");
            }

        }

        private void groupBox28_Enter(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (txt_o21.Text != "")
            {
                if (rb_o21_1.Checked == true || rb_o21_2.Checked == true)
                {
                    double sayi = Convert.ToDouble(txt_o21.Text);
                    double sonuc;
                    if (rb_o21_1.Checked == true)

                    {
                        sonuc = sayi * 0.18;
                    }
                    else
                    {
                        sonuc = sayi * 0.25;
                    }
                    MessageBox.Show("Sonuç:"+sonuc);
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Seçim Yapýnýz");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Sayý Giriniz");
            }

        }
    }
}