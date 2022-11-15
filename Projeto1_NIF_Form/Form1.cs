using System;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using System.Text.Json;
namespace Projeto1_NIF_Form
{
    public partial class Form1 : Form
    {
        private readonly string key = "7081912941ec5e7715a8de32ef8213d7";
        public Form1()
        {
            InitializeComponent();
        }
        private async void Gravar_Dados_JSON_Click(object sender, EventArgs e)
        {
            Root example = null;
            string json = "";
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://www.nif.pt/");
                json = await client.GetStringAsync($"?json=1&q={Inserir_NIF.Text}&key={key}");
                json = json.Replace($"{Inserir_NIF.Text}\":", "NIF\":");
                example = JsonSerializer.Deserialize<Root>(json);
                int NIF_Cliente = example.Records.NIF.Nif;
                Inserir_NIF.Text = NIF_Cliente.ToString();
                string Nome_Cliente = example.Records.NIF.Title;
                Inserir_Nome.Text = Nome_Cliente.ToString();
                string Adereço = example.Records.NIF.Address;
                Inserir_Adereço.Text = Adereço.ToString();
                string PC4 = example.Records.NIF.Place.Pc4;
                Inserir_PC4.Text = PC4.ToString();
                string PC3 = example.Records.NIF.Place.Pc3;
                Inserir_PC3.Text = PC3.ToString();
                string Distrito = example.Records.NIF.Geo.Region;
                Inserir_Distrito.Text = Distrito.ToString();
                string Concelho = example.Records.NIF.Geo.County;
                Inserir_Concelho.Text = Concelho.ToString();
                string Freguesia = example.Records.NIF.Geo.Parish;
                Inserir_Freguesia.Text = Freguesia.ToString();
                string Email = example.Records.NIF.Contacts.Email;
                Inserir_Email.Text = Email.ToString();
                string Telefone = example.Records.NIF.Contacts.Phone;
                Inserir_Telefone.Text = Telefone.ToString();
                string Website = example.Records.NIF.Contacts.Website;
                Inserir_Website.Text = Website.ToString();
                string Fax = example.Records.NIF.Contacts.Fax;
                Inserir_Fax.Text = Fax.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (example != null)
            {

            }
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                Inserir_Imagem_URL.Text = openFileDialog1.FileName;
            }
            if (NIFTextEdit.Text == "504213660")
            {
                Imagem_URLHyperLinkEdit.Text = @"E:\12MM\diogo_vieira_16651\Estágio\1ª semana\Dia 1\Projeto1_NIF_Form\Projeto1_NIF_Form\Logos_Empresas\tgn.png";
            }
            else if (NIFTextEdit.Text == "504783661")
            {
                Imagem_URLHyperLinkEdit.Text = @"E:\12MM\diogo_vieira_16651\Estágio\1ª semana\Dia 1\Projeto1_NIF_Form\Projeto1_NIF_Form\Logos_Empresas\sas.png";
            }
            else if (NIFTextEdit.Text == "509442013")
            {
                Imagem_URLHyperLinkEdit.Text = @"E:\12MM\diogo_vieira_16651\Estágio\1ª semana\Dia 1\Projeto1_NIF_Form\Projeto1_NIF_Form\Logos_Empresas\nex.png";
            }
            else
            {
                Imagem_URLHyperLinkEdit.Text = @"E:\12MM\diogo_vieira_16651\Estágio\1ª semana\Dia 1\Projeto1_NIF_Form\Projeto1_NIF_Form\Logos_Empresas\tcm.png";
            }
        }
        private void Gravar_Dados_Entity_Click(object sender, EventArgs e)
        {
            NIFTextEdit.Text = Inserir_NIF.Text;
            NameTextEdit.Text = Inserir_Nome.Text;
            AddressTextEdit.Text = Inserir_Adereço.Text;
            PC4TextEdit.Text = Inserir_PC4.Text;
            PC3TextEdit.Text = Inserir_PC3.Text;
            RegionTextEdit.Text = Inserir_Distrito.Text;
            CountyTextEdit.Text = Inserir_Concelho.Text;
            ParishTextEdit.Text = Inserir_Freguesia.Text;
            EmailHyperLinkEdit.Text = Inserir_Email.Text;
            PhoneTextEdit.Text = Inserir_Telefone.Text;
            WebsiteHyperLinkEdit.Text = Inserir_Website.Text;
            FaxTextEdit.Text = Inserir_Fax.Text;
            Imagem_URLHyperLinkEdit.Text = Inserir_Imagem_URL.Text;
            using (NIFDBEntities ndbe = new NIFDBEntities())
            {
                NIF_Empresa n_e = new NIF_Empresa();
                n_e.NIF = int.Parse(NIFTextEdit.Text);
                n_e.Name = NameTextEdit.Text;
                n_e.Address = AddressTextEdit.Text;
                n_e.PC4 = int.Parse(PC4TextEdit.Text);
                n_e.PC3 = int.Parse(PC3TextEdit.Text);
                n_e.Region = RegionTextEdit.Text;
                n_e.County = CountyTextEdit.Text;
                n_e.Parish = ParishTextEdit.Text;
                n_e.Email = EmailHyperLinkEdit.Text;
                n_e.Phone = int.Parse(PhoneTextEdit.Text);
                n_e.Website = WebsiteHyperLinkEdit.Text;
                n_e.Fax = int.Parse(FaxTextEdit.Text);
                n_e.Imagem_URL = Imagem_URLHyperLinkEdit.Text;
                ndbe.SaveChanges();
            }
        }
    }
}