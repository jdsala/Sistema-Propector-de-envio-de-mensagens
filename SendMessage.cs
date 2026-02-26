using System;
using WhatsAppApi;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace ProjetoMarketing
{
    class SendMessage
    {
        string url = "https://web.whatsapp.com/";
        ChromeDriver driver; Thread th;
        bool start = true;

        public void SendWhatsA(string dgvnumber, string titulo)
        {

            string from = "5545991044049";
            WhatsApp wa = new WhatsApp(from, "CODIGO", "Teste", false, false);

            wa.OnConnectSuccess += () =>
            {
                MessageBox.Show("Connected to WahtsApp...");

                wa.OnLoginSuccess += (phoneNumber, data) =>
                {
                    wa.SendMessage(dgvnumber, titulo);
                    MessageBox.Show("Mensagem enviada!!");
                };

                wa.OnLoginFailed += (data) =>
                {
                    MessageBox.Show("Login Failed : {0}", data);
                };
                wa.Login();
            };

            wa.OnConnectFailed += (ex) =>
            {
                MessageBox.Show("Connection Failed...");
            };
            wa.Connect();
        }
      
    }
}
