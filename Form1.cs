using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Drawing.Printing;

namespace printer_tester
{
    public partial class Body : Form
    {
        public string ip = "";
        public Body()
        {
            InitializeComponent();
        }
        public void Archive_Reader()
        {
            string archivePaths = "C://inetpub/wwwroot/athos/API/athos/config";//caminho declarado como vari�vel para poss�vel implementa��o de sele��o de caminho
            var explorerContent = Directory.GetFiles(archivePaths, ".", SearchOption.AllDirectories)//get files recebe a vari�vel de caminho e faz a consulta
                .Where(extension => extension.EndsWith(".ini"));//abrir diret�rio da api e localizar os arquivos de config do acbr pela extens�o .ini
            foreach (var f in explorerContent)
            {
                Console.WriteLine($"Aquivo de configura��o {explorerContent} encontrado com sucesso");
            }
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            CMD.Text += "";
            Ping ping = new Ping();
            PingReply pingResponse;
            string result;
            pingResponse = ping.Send(ip);
            if (pingResponse.Status == IPStatus.Success)
            {
                result = $"Sucesso a impressora de ip {ip} est� comunicando";
            }
            else
            {
                result = $"Sucesso a impressora de ip {ip} n�o est� comunicando";
            }
            for (int i = 0; i < 10; i++)
            {

                CMD.Text += $"Tester: Testando a impressora de ip {ip}" + Environment.NewLine;
                CMD.SelectionStart = CMD.Text.Length;
                CMD.ScrollToCaret();

            }
            CMD.Text += result + Environment.NewLine;
            CMD.SelectionStart = CMD.Text.Length;
            CMD.ScrollToCaret();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void IpInput_TextChanged(object sender, EventArgs e)
        {
            ip = (string)IpInput.Text;
        }
    }
}
