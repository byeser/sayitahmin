using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cstech
{
    public static class utils
    {
        /// <summary>
        /// dışarıdan girilecek sayının boş  olma durumu
        /// </summary>
        /// <param name="text">dışarıdan girilecek deger</param>
        /// <param name="hata">hata uyarı </param>
        /// <returns></returns>
        public static bool bos_sayi_kontrolu(TextBox text, ErrorProvider hata)
        {
            if (string.IsNullOrEmpty(text.Text))
            {                
                hata.SetError(text, "Boş bırakılamaz !");//Sayı girilmemişse textbox ın yanında  hata provider ı kırmızı renkte yanıp söner
                return false;
            }
            else
            {
                hata.SetError(text, "");//Dışarıdan girilen sayımız boş değilse hata provider ine boş deger atanır.
                return true;
            }
        }
        /// <summary>
        /// 4 karakterden az sayı girilme , kontrol eder
        /// </summary>
        /// <param name="text">dışarıdan girilecek deger</param>
        /// <param name="hata">hata uyarı </param>
        /// <returns></returns>
        public static bool basamak_sayi_kontrolu(TextBox text, ErrorProvider hata)
        {
            if (text.Text.Length < 4)
            {
                hata.SetError(text, "4 basamaklı sayı giriniz !"); //Dışarıdan girilen sayımızın uzunlugu 4 den küçükse işlem yaptırmadan  hata providerimiz devreye girer ve kırmızı yanıp söner
                return false;
            }
            else
            {
                hata.SetError(text, "");//Dışarıdan girilen sayımızın uzunlugu 4 den küçük değilse hata provider ine boş deger atanır.
                return true;
            }
        }
        /// <summary>
        /// rakamların farklı olma durumunu kontrol eder
        /// </summary>
        /// <param name="sayi">dışarıdan girilen sayı</param>
        /// <returns></returns>
        public static bool farkli_rakamlar(string sayi)
        {
            for (int i = 0; i < sayi.Length; i++)
            {
                for (int j = 0; j < sayi.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (sayi[i] == sayi[j])
                        return false;
                }
            }
            return true;
        }
        /// <summary>
        /// dısarıdan girilen sayının basamak kontrolü için Dictionary a atanır.
        /// </summary>
        /// <param name="sayi">dışarıdan girilen sayı</param>
        /// <returns></returns>
        public static Dictionary<byte, byte> disaridan_girilen_sayi(string sayi)
        {
            Dictionary<byte, byte> txtbasamak = new Dictionary<byte, byte>();//dışarıdan girilen sayımızın basamak degerlerini ve sırasını  Dictionary a atamak için kullanıldı.
            for (byte i = 1; i < sayi.Length + 1; i++)
            {
                if (!txtbasamak.ContainsKey(i)) // Notasyonlar da bulunan arama maliyetini O(1) e düşürmek için ContainsKey ile kontrol edildi ve atama yapıldı
                    txtbasamak.Add(i, new byte()); //bulunan key boş ise key degeri atanır.
                txtbasamak[i] = Convert.ToByte(sayi[i - 1].ToString()); //key e ait deger atanır.                 
            }
            return txtbasamak;
        }
        /// <summary>
        /// oyun puanlama 
        /// </summary>
        /// <param name="random_sayi">rakamları farklı oluşturulan  random sayı</param>
        /// <param name="disaridan_girilen_sayi">dışarıdan girilen rakamları farklı sayı</param>
        /// <returns></returns>
        public static Dictionary<enums.puanlama, int> oyun_puanlama(int random_sayi, string disaridan_girilen_sayi)
        { 
            Dictionary<byte, byte> rndbasamak = new Dictionary<byte, byte>();
            var dict = new Dictionary<enums.puanlama, int>();
            for (byte i = 1; i < random_sayi.ToString().Length + 1; i++)
            {
                if (!rndbasamak.ContainsKey(i))  
                    rndbasamak.Add(i, new byte()); 
                rndbasamak[i] = Convert.ToByte(random_sayi.ToString()[i - 1].ToString());  

                if (utils.disaridan_girilen_sayi(disaridan_girilen_sayi)[i] == rndbasamak[i]) //girilen sayının ve otomatik oluşan sayının basamak değerleri karşılaştırılıyor.
                {
                    if (!dict.ContainsKey(enums.puanlama.arti))
                        dict.Add(enums.puanlama.arti, 0);
                    dict[enums.puanlama.arti] += 1;//iki sayınında basamak değerleri eğitse artı puanı 1 artar
                    continue;//alt döngüye girmede  tekrar asıl döngüsüne gider
                }
                if (utils.disaridan_girilen_sayi(disaridan_girilen_sayi).ContainsValue(Convert.ToByte(random_sayi.ToString()[i - 1].ToString())))
                {
                    if (!dict.ContainsKey(enums.puanlama.eksi))
                        dict.Add(enums.puanlama.eksi, 0);
                    dict[enums.puanlama.eksi] -= 1;
                }
            }
            return dict; 
        }

        public static bool ipucu(string random_sayi, string disaridan_girilen_sayi, TextBox text, ErrorProvider hata)
        {
            for (int i = 0; i < random_sayi.Length; i++)
            {
                for (int j = 0; j < disaridan_girilen_sayi.Length; j++)
                {
                    if (random_sayi[i] == disaridan_girilen_sayi[j])
                    {
                        hata.SetError(text, (j+1)+". sayınız eşleşmektedir. "+ disaridan_girilen_sayi[j].ToString());
                        return true;
                    }
                }
            }
            hata.SetError(text, "Hiç bir basamak eşleşmemektedir.");
            return false;
        }
    }
}
