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
            string archivePaths = "C://inetpub/wwwroot/athos/API/athos/config";//caminho declarado como variável para possível implementação de seleção de caminho
            var explorerContent = Directory.GetFiles(archivePaths, ".", SearchOption.AllDirectories)//get files recebe a variável de caminho e faz a consulta
                .Where(extension => extension.EndsWith(".ini"));//abrir diretório da api e localizar os arquivos de config do acbr pela extensão .ini
            foreach (var f in explorerContent)
            {
                Console.WriteLine($"Aquivo de configuração {explorerContent} encontrado com sucesso");
            }
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            CMD.ResetText();
            Ping ping = new Ping();
            PingReply pingResponse;
            string result;
            pingResponse = ping.Send(ip);
            if (pingResponse.Status == IPStatus.Success)
            {
                result = $"Tester: Sucesso a impressora de ip {ip} está comunicando";
            }
            else
            {
                result = $"Tester: Erro a impressora de ip {ip} não está comunicando";
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

        private void HowToUse_Click(object sender, EventArgs e)
        {
            string message = "Para Utilizar o testador basta inserir o Ip da impressora e logo depois Clicar no botão 'Testar Impressora'\nCriado Por Davi Menezes\ngithub:https://github.com/Lukuko\nLivre Para uso";
            string title = "Como Usar o Programa";
            DialogResult result = MessageBox.Show(message, title);
        }
    }
}
