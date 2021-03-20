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
            Random rnd = new Random();
            string birlestir = string.Empty;
            Dictionary<byte, byte> dict = new Dictionary<byte, byte>();
            for (; ; )
            {
                var t = Convert.ToByte(rnd.Next(1, 9).ToString());
                if (!dict.ContainsKey(t))
                {
                    dict.Add(t, t);
                    birlestir += t;
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

          if(! utils.ipucu(sayi.ToString(), txtSayi.Text, txtSayi, hata))
            { return; }
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
            for (; ; )
            {
                var t = Convert.ToByte(rnd.Next(1, 9).ToString());
                if (!dict.ContainsKey(t))
                {
                    dict.Add(t, t);
                    birlestir += t;
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
