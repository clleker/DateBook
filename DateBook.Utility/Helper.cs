using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateBook.Utility
{
    public class Helper
    {
        public static string StringMoney(int money)
        {
            string[] unitsDigit = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] tensDigit = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string result = "";

            if (money < 999999)
            {
                int digit = money % 10;               //Birler
                if (digit != 0)
                {
                    result += unitsDigit[digit - 1];
                }
                digit = (money / 10) % 10;             //onlar
                if (digit != 0)
                {
                    result = tensDigit[digit - 1] + result;
                }
                digit = (money / 100) % 10;     //yüzler
                if (digit != 0)
                {
                    if (unitsDigit[digit - 1] == "Bir")
                        result = " Yüz" + result;
                    else
                        result = unitsDigit[digit - 1] + " Yüz" + result;
                }
                digit = (money / 1000) % 10;      //Binler
                if (digit != 0 && (money / 10000) % 10 == 0)
                {
                    if (unitsDigit[digit - 1] == "Bir")
                        result = " Bin " + result;
                    else
                        result = unitsDigit[digit - 1] + " Bin " + result;

                    if ((money / 100000) % 10 != 0)
                    {
                        result = unitsDigit[digit - 1] + result;
                    }
                }
                digit = (money / 10000) % 10;         //on binler
                if (digit != 0)
                {

                    if ((money / 1000) % 10 != 0)
                        result = tensDigit[digit - 1] + unitsDigit[(money / 1000) % 10 - 1] + " Bin " + result;
                    else
                        result = tensDigit[digit - 1] + " Bin " + result;
                }
                digit = (money / 100000) % 10; // yüz binler
                if (digit != 0)
                {
                    if ((money / 10000) % 10 == 0 && (money / 1000) % 10 == 0)
                    {
                        // binler ve onbinler basamagı sıfır ise
                        if (unitsDigit[digit - 1] == "Bir")
                            result = " yüzbin" + result;
                        else
                            result = unitsDigit[digit - 1] + " Yüzbin " + result;
                    }
                    else
                        result = unitsDigit[digit - 1] + " Yüz" + result;
                }
                return result;
            }
            return "";
        }


        public static void ClearForm(GroupBox grb)
        {
            foreach (var item in grb.Controls)
            {
                if (item is TextBox)
                {
                    (item as TextBox).Text = "";
                }
                else if (item is RichTextBox)
                {
                    (item as RichTextBox).Text = "";
                }
                else if (item is DateTimePicker)
                {
                    (item as DateTimePicker).Value = DateTime.Now;
                }

            }
        }


        public static void Sms()
        {
            try
            {
                SmtpClient client = new SmtpClient(); /*
                 -->SMTP (Simple Mail Transfer Protocol(posta aktarım protokolü))(Elektronik posta gönderme protokolü, bir e-posta göndermek için sunucu ile istemci arasındaki iletişim şeklini           belirleyen protokoldür.) 
                 -->Mail gönderme işini .net'de ister web'te olsun ister masaüstü windows'ta olsun herhangi bir platformda "smtp"  isminde bir class üslenmiştir.
                 -->Bu class "System.Net.Mail" kütüphanesinde yer alır.
                */
                client.Port = 587;
                client.Host = "smtp.gmail.com"; //Hotmailin sunucu adresi

                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("clleker88@gmail.com", "zingo55to");//Credentials(Kullanıcı bilgileri) // yani istemci ag kimlik bilgisi , gönderilecek mail ve şifresi
                client.EnableSsl = true; //SSL(Secure Socet Layer) güvenlik yuva katmanı () sunucu ile istemci arasındaki verileri dogru adrese gönderene kadar şifreleme yapan komutumuz



                MailMessage message = new MailMessage();// Message oluşturmak için using "System.Net.Mail" kütüphanesini implement etmelisiniz
                #region Protocol nedir 
                /*İletişim protokolü veya ağ protokolü, iki ya da daha fazla bilgisayar arasındaki iletişimi sağlamak amacıyla verileri düzenlemeye yarayan, standart olarak kabul edilmiş kurallar dizisidir. İki sistem arasında iletişim için kullanılan dili, yani mesajlaşma kurallarını belirtir.Bu kurallara uyulursa protokol sağlanmış olur ve iletişim gerçekleşir fakat bu kurala uymaz ise iletişim gerçekleşmez.*/
                //Ör:  http protokolü
                #endregion
             
                message.To.Add("clleker88@gmail.com");//Mesajın kime gidecegi
                message.From = new MailAddress("clleker88@gmail.com");
                message.Subject = "Merhaba";
                message.Body = "Mehaba Dünya";
                client.Send(message);

            }
            catch (Exception ex)
            {

                throw;
            }




        }





        public static void WhatsUp(GroupBox grb)
        {





        }


    }
}
