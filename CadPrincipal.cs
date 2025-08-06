using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using ApexClientV2.Forms;

namespace ApexClientV2
{
    public partial class CadPrincipal : Form
    {
        private Button BotaoSelecionado;
        private Panel BarraEsquerdaBotao;
        private Form FormularioSelecionado;
        string caminhoArquivo;
        public string clienteSelecionado;

        // Inicializção
        public CadPrincipal()
        {
            InitializeComponent();
            string documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            caminhoArquivo = Path.Combine(documentos, "clientes.txt");

            AtualizarContadorClientes();

            BarraEsquerdaBotao = new Panel();
            BarraEsquerdaBotao.Size = new Size(7, 60);
            Options.Controls.Add(BarraEsquerdaBotao);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            ArredondarPanel(Panel_Clientes, 20);
            Panel_Clientes.Resize += (s, ev) => ArredondarPanel(Panel_Clientes, 20);
            ArredondarPanel(Panel_Status, 20);
            Panel_Status.Resize += (s, ev) => ArredondarPanel(Panel_Status, 20);
            ArredondarPanel(Panel_Aleatorio, 20);
            Panel_Aleatorio.Resize += (s, ev) => ArredondarPanel(Panel_Aleatorio, 20);
            ArredondarPanel(Panel_Changelog, 20);
            Panel_Changelog.Resize += (s, ev) => ArredondarPanel(Panel_Changelog, 20);
        }
        public void ArredondarPanel(Panel panel, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddLine(raio, 0, panel.Width - raio, 0);
            path.AddArc(panel.Width - raio, 0, raio, raio, 270, 90);
            path.AddLine(panel.Width, raio, panel.Width, panel.Height - raio);
            path.AddArc(panel.Width - raio, panel.Height - raio, raio, raio, 0, 90);
            path.AddLine(panel.Width - raio, panel.Height, raio, panel.Height);
            path.AddArc(0, panel.Height - raio, raio, raio, 90, 90);
            path.AddLine(0, panel.Height - raio, 0, raio);

            path.CloseFigure();
            panel.Region = new Region(path);
        }
        public void ArredondarBotao(Button botao, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddLine(raio, 0, botao.Width - raio, 0);
            path.AddArc(botao.Width - raio, 0, raio, raio, 270, 90);
            path.AddLine(botao.Width, raio, botao.Width, botao.Height - raio);
            path.AddArc(botao.Width - raio, botao.Height - raio, raio, raio, 0, 90);
            path.AddLine(botao.Width - raio, botao.Height, raio, botao.Height);
            path.AddArc(0, botao.Height - raio, raio, raio, 90, 90);
            path.AddLine(0, botao.Height - raio, 0, raio);

            path.CloseFigure();
            botao.Region = new Region(path);
        }
        private void AtivarBotao(object sender)
        {
            if (sender != null)
            {
                DesativarBotao();
                BotaoSelecionado = (Button)sender;
                BotaoSelecionado.BackColor = Color.FromArgb(52, 52, 62); ;
                BotaoSelecionado.Font = new Font("Microsoft Sans Serif", 14);

                BarraEsquerdaBotao.BackColor = Color.FromArgb(72, 72, 82);
                BarraEsquerdaBotao.Location = new Point(0, BotaoSelecionado.Location.Y);
                BarraEsquerdaBotao.Visible = true;
                BarraEsquerdaBotao.BringToFront();

                Hdr_Icon.Image = BotaoSelecionado.Image;
                Hdr_Titulo.Text = BotaoSelecionado.Text.Trim();
            }
        }

        public void AtualizarContadorClientes()
        {
            if (File.Exists(caminhoArquivo))
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                Clientes.Text = linhas.Length.ToString();
            }
            else
            {
                Clientes.Text = "0";
            }
        }

        private void DesativarBotao()
        {
            if (BotaoSelecionado != null)
            {
                BotaoSelecionado.BackColor = Color.FromArgb(32, 32, 42);
                BotaoSelecionado.Font = new Font("Microsoft Sans Serif", 12F);
            }
        }
        private void AbrirFormulario(Form formulario)
        {
            if (FormularioSelecionado != null)
            {
                FormularioSelecionado.Close();
            }

            Inicio.Visible = false;
            FormularioSelecionado = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            Forms.Controls.Add(formulario);
            Forms.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
        }
        public void Reset()
        {
            DesativarBotao();
            BarraEsquerdaBotao.Visible = false;
            Hdr_Titulo.Text = "Inicio";
            Hdr_Icon.Image = Properties.Resources.icons8_home_32;
            FormularioSelecionado.Close();
            Inicio.Visible = true;
        }

        private void Opt_Listar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(caminhoArquivo))
            {
                MessageBox.Show("Arquivo não encontrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] customers = File.ReadAllLines(caminhoArquivo);
            if (customers.Length == 0)
            {
                MessageBox.Show("Nenhum cliente cadastrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListaForm form = new ListaForm();
            form.Principal = this;
            AtivarBotao(sender);
            AbrirFormulario(form);
        }
        private void Opt_Cadastrar_Click(object sender, EventArgs e)
        {
            CadastroForm form = new CadastroForm();
            form.Principal = this;
            AtivarBotao(sender);
            AbrirFormulario(form);
        }
        private void Opt_Editar_Click(object sender, EventArgs e)
        {
            if (!File.Exists(caminhoArquivo))
            {
                MessageBox.Show("Arquivo não encontrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] customers = File.ReadAllLines(caminhoArquivo);
            if (customers.Length == 0)
            {
                MessageBox.Show("Nenhum cliente cadastrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(clienteSelecionado))
            {
                MessageBox.Show("Você precisa selecionar um cliente na lista primeiro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            customers = customers.Where(customer => customer.Contains("Email: " + clienteSelecionado.Trim())).ToArray();
            if (customers.Length == 0)
            {
                MessageBox.Show("Cliente não encontrado!");
                return;
            }

            EditarForm form = new EditarForm();
            string[] dados = customers[0].Split('|');
            string nomeCompletoAntigo = dados[0].Split(new string[] { "Nome:" }, StringSplitOptions.None)[1].Trim();
            string emailAntigo = dados[1].Split(new string[] { "Email:" }, StringSplitOptions.None)[1].Trim();
            string telefoneAntigo = dados[2].Split(new string[] { "Telefone:" }, StringSplitOptions.None)[1].Trim();
            string enderecoAntigo = dados[3].Split(new string[] { "Endereço:" }, StringSplitOptions.None)[1].Trim();
            string[] partesEndereco = enderecoAntigo.Split('-');
            string enderecoAntesDoHifen = partesEndereco.Length > 0 ? partesEndereco[0] : "";
            string estadoSigla = partesEndereco.Length > 1 ? partesEndereco[1].Trim() : "";
            string[] partesVirgulas = enderecoAntesDoHifen.Split(',');
            string rua = partesVirgulas.Length > 0 ? partesVirgulas[0].Trim() : "";
            string numeroAntigo = partesVirgulas.Length > 1 ? partesVirgulas[1].Trim() : "";
            string bairroAntigo = partesVirgulas.Length > 2 ? partesVirgulas[2].Trim() : "";
            string cidadeAntigo = partesVirgulas.Length > 3 ? partesVirgulas[3].Trim() : "";
            string sexoAntigo = dados[4].Split(new string[] { "Sexo:" }, StringSplitOptions.None)[1].Trim();

            foreach (var item in form.EstadoBox.Items)
            {
                string estadoTexto = item.ToString();
                if (estadoTexto.Contains("(" + estadoSigla + ")"))
                {
                    estadoSigla = estadoTexto;
                    break;
                }
            }

            form.OldNameBox.Text = nomeCompletoAntigo;
            form.OldEmailBox.Text = emailAntigo;
            form.OldTelefoneBox.Text = telefoneAntigo;
            form.OldEnderecoBox.Text = rua;
            form.OldNumeroBox.Text = numeroAntigo;
            form.OldBairroBox.Text = bairroAntigo;
            form.OldCidadeBox.Text = cidadeAntigo;
            form.OldEstadoBox.Text = estadoSigla;
            Console.WriteLine("Endereço: " + enderecoAntigo + ", " + estadoSigla);

            if (sexoAntigo == "F")
            {
                form.Feminino.Checked = true;
            }
            else if (sexoAntigo == "M")
            {
                form.Masculino.Checked = true;
            }

            form.Principal = this;
            AtivarBotao(sender);
            AbrirFormulario(form);
        }
        private void Opt_Mensagem_Click(object sender, EventArgs e)
        {
            if (!File.Exists(caminhoArquivo))
            {
                MessageBox.Show("Arquivo não encontrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] customers = File.ReadAllLines(caminhoArquivo);
            if (customers.Length == 0)
            {
                MessageBox.Show("Nenhum cliente cadastrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(clienteSelecionado))
            {
                MessageBox.Show("Você precisa selecionar um cliente na lista primeiro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MensagemForm form = new MensagemForm();
            form.Principal = this;
            AtivarBotao(sender);
            AbrirFormulario(form);
        }
        private void Opt_Sobre_Click(object sender, EventArgs e)
        {
            AtivarBotao(sender);
            AbrirFormulario(new SobreForm());
        }
        private void Opt_Inicio_Click(object sender, EventArgs e)
        {
            Reset();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private async void Opt_Sair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você realmente deseja sair do sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _ = Task.Run(() => MessageBox.Show("Saindo do sistema... Até logo!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information));
                await Task.Delay(1000);
                Application.Exit();
            }
        }

        private void Opt_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Opt_Maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void Opt_Sair_Mouse_Enter(object sender, EventArgs e)
        {
            Opt_Sair.BackColor = Color.Red;
        }

        private void Opt_Sair_Mouse_Left(object sender, EventArgs e)
        {
            Opt_Sair.BackColor = Color.FromArgb(22, 21, 26);
        }

        private void Opt_Minimizar_Mouse_Enter(object sender, EventArgs e)
        {
            Opt_Minimizar.BackColor = Color.FromArgb(52, 51, 56);
        }

        private void Opt_Minimizar_Mouse_Left(object sender, EventArgs e)
        {
            Opt_Minimizar.BackColor = Color.FromArgb(22, 21, 26);
        }
        private void Opt_Maximizar_Mouse_Enter(object sender, EventArgs e)
        {
            Opt_Maximizar.BackColor = Color.FromArgb(52, 51, 56);
        }

        private void Opt_Maximizar_Mouse_Left(object sender, EventArgs e)
        {
            Opt_Maximizar.BackColor = Color.FromArgb(22, 21, 26);
        }
        private void CadPrincipal_Load(object sender, EventArgs e)
        {
            Temporizador.Tick += Temporizador_Tick;
            Temporizador.Start();
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;
            HoraText.Text = $"Agora são {agora:HH:mm} do dia {agora:dd 'de' MMMM}";
        }
    }
}
