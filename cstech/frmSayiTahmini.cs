using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cstech
{
    public partial class frmSayiTahmini : Form
    {
        public frmSayiTahmini()
        {
            InitializeComponent();
        }
        int sayi = 0; //Random oluşan 4 basamaklı sayımız.
        /// <summary>
        /// Formun İlk yüklenme Metodu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSayiTahmini_Load(object sender, EventArgs e)
        {
            lblArti.Text = string.Empty;//Sayı girilmemişse artı puan boş atanır.
            lblEksi.Text = string.Empty;//Sayı girilmemişse eksi puan boş atanır.
            Random rnd = new Random();//otomatik sayı oluşturmak için kullanılır.
            string birlestir = string.Empty;
            Dictionary<byte, byte> dict = new Dictionary<byte, byte>();
            byte sayac = 1;
            for (; ; )
            {
                var t = Convert.ToByte(rnd.Next(sayac == 1 ? 1 : 0, 9).ToString());//eger burada sayının ilk basamağı ise 1-9 arası rakam gelir aksi taktirde 0-9 arası rakamlar gelir.
                if (!dict.ContainsKey(t))//üretilen rakam  dictionary de yoksa eklenir.
                {
                    switch (sayac)//basamak sayılarına göre ip ucu kriterleri switch case kullanarak ekrana yazıldı.
                    {
                        case 1://1 rakamın ip uçları
                            lblRakam1.Text = string.Concat("1. Rakam :", string.Join(",", utils.ip_ucu_kriterleri[t.ToString()].ToList()));
                            break;
                        case 2://2 rakamın ip uçları
                            lblRakam2.Text = string.Concat("2. Rakam :", string.Join(",", utils.ip_ucu_kriterleri[t.ToString()].ToList()));
                            break;
                        case 3://3 rakamın ip uçları
                            lblRakam3.Text = string.Concat("3. Rakam :", string.Join(",", utils.ip_ucu_kriterleri[t.ToString()].ToList()));
                            break;
                        case 4://4 rakamın ip uçları
                            lblRakam4.Text = string.Concat("4. Rakam :", string.Join(",", utils.ip_ucu_kriterleri[t.ToString()].ToList()));
                            break;
                    }

                    dict.Add(t, t);//üretilen rakam dictionary ekleniyor
                    birlestir += t;
                    sayac++;
                }
                if (birlestir.Length == 4)
                {
                    sayi = Convert.ToInt32(birlestir);
                    break;
                }
            }
            //this.Text = "Sayı Tahmin Oyunu : " + sayi.ToString();
        }
        /// <summary>
        /// Sadece rakam girilmesi için textbox kontrolü
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        /// <summary>
        /// Oyun Fonksiyonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSayi_Click(object sender, EventArgs e)
        {
            lblArti.Text = string.Empty;//Sayı girilmemişse artı puan boş atanır.
            lblEksi.Text = string.Empty;//Sayı girilmemişse eksi puan boş atanır.

            //boş olma durumu
            if (!utils.bos_sayi_kontrolu(txtSayi, hata))
                return;

            //minimum 4 haneli sayı  kontrolü
            if (!utils.basamak_sayi_kontrolu(txtSayi, hata))
                return;


            var dict_basamak = utils.disaridan_girilen_sayi(txtSayi.Text);

            //Girilen sayının random olarak oluşan sayıya eşitse direk ekrana  bilgi mesajı cıkar ve tplam kazanılan puan ve mesaj yazılır.
            if (sayi.ToString() == txtSayi.Text)
            {
                MessageBox.Show("Dogru sayıyı buldunuz . Tebrikler ...\n\n Sayı   : " + txtSayi.Text + "\n Puan : " + dict_basamak.Values.Sum(x => x).ToString(), "Bilgi");
                return;
            }

            //sayıda aynı rakamlar olma durumu ,
            if (!utils.farkli_rakamlar(txtSayi.Text.ToString()))
            {
                hata.SetError(txtSayi, "Lütfen farklı rakamları giriniz !");
                return;
            }
            else
                hata.SetError(txtSayi, "");

             
            //puan hesaplama
            var puanlama = utils.oyun_puanlama(sayi, txtSayi.Text);
            lblArti.Text = puanlama.ContainsKey(enums.puanlama.arti) ? puanlama[enums.puanlama.arti].ToString() : "0";
            lblEksi.Text = puanlama.ContainsKey(enums.puanlama.eksi) ? puanlama[enums.puanlama.eksi].ToString() : "0";
        }
        /// <summary>
        /// yeni rastgele 4 haneli sayı üretir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYeniSayi_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string birlestir = string.Empty;
            Dictionary<byte, byte> dict = new Dictionary<byte, byte>();
            byte sayac = 1;
            for (; ; )
            {
                var t = Convert.ToByte(rnd.Next(sayac == 1 ? 1 : 0, 9).ToString());//eger burada sayının ilk basamağı ise 1-9 arası rakam gelir aksi taktirde 0-9 arası rakamlar gelir.
                if (!dict.ContainsKey(t))
                {
                    switch (sayac)//basamak sayılarına göre ip ucu kriterleri switch case kullanarak ekrana yazıldı.
                    {
                        case 1://1 rakamın ip uçları
                            lblRakam1.Text = string.Concat("1. Rakam :", string.Join(",", utils.ip_ucu_kriterleri[t.ToString()].ToList()));
                            break;
                        case 2://2 rakamın ip uçları
                            lblRakam2.Text = string.Concat("2. Rakam :", string.Join(",", utils.ip_ucu_kriterleri[t.ToString()].ToList()));
                            break;
                        case 3://3 rakamın ip uçları
                            lblRakam3.Text = string.Concat("3. Rakam :", string.Join(",", utils.ip_ucu_kriterleri[t.ToString()].ToList()));
                            break;
                        case 4://4 rakamın ip uçları
                            lblRakam4.Text = string.Concat("4. Rakam :", string.Join(",", utils.ip_ucu_kriterleri[t.ToString()].ToList()));
                            break;
                    }

                    dict.Add(t, t);
                    birlestir += t;
                    sayac++;
                }
                if (birlestir.Length == 4)
                {
                    sayi = Convert.ToInt32(birlestir);
                    break;
                }
            }
            MessageBox.Show("Oyun için yeni sayı üretildi.");
        }
    }
}
