namespace ApexClientV2
{
    partial class CadPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadPrincipal));
            Options = new Panel();
            Opt_Sobre = new Button();
            Opt_Mensagem = new Button();
            Opt_Editar = new Button();
            Opt_Cadastrar = new Button();
            Opt_Listar = new Button();
            Logo_Panel = new Panel();
            Opt_Inicio = new PictureBox();
            Header = new Panel();
            Hdr_Titulo = new Label();
            Opt_Minimizar = new PictureBox();
            Opt_Maximizar = new PictureBox();
            Opt_Sair = new PictureBox();
            Hdr_Icon = new PictureBox();
            Forms = new Panel();
            Inicio = new Panel();
            Panel_Aleatorio = new Panel();
            EmBreve = new Label();
            Panel_Status = new Panel();
            Status = new Label();
            SatusLabel = new Label();
            Panel_Changelog = new Panel();
            UpdatesLabel = new Label();
            Update8 = new Label();
            Update7 = new Label();
            Update5 = new Label();
            Update4 = new Label();
            Update3 = new Label();
            Update2 = new Label();
            Update1 = new Label();
            Panel_Clientes = new Panel();
            Clientes = new Label();
            ClienteLabel = new Label();
            ApexIcon = new PictureBox();
            Direitos = new Label();
            HoraText = new Label();
            BemVindoText = new Label();
            Temporizador = new System.Windows.Forms.Timer(components);
            Options.SuspendLayout();
            Logo_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Opt_Inicio).BeginInit();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Opt_Minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Opt_Maximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Opt_Sair).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Hdr_Icon).BeginInit();
            Forms.SuspendLayout();
            Inicio.SuspendLayout();
            Panel_Aleatorio.SuspendLayout();
            Panel_Status.SuspendLayout();
            Panel_Changelog.SuspendLayout();
            Panel_Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ApexIcon).BeginInit();
            SuspendLayout();
            // 
            // Options
            // 
            Options.BackColor = Color.FromArgb(32, 32, 42);
            Options.Controls.Add(Opt_Sobre);
            Options.Controls.Add(Opt_Mensagem);
            Options.Controls.Add(Opt_Editar);
            Options.Controls.Add(Opt_Cadastrar);
            Options.Controls.Add(Opt_Listar);
            Options.Controls.Add(Logo_Panel);
            Options.Dock = DockStyle.Left;
            Options.Location = new Point(0, 0);
            Options.Name = "Options";
            Options.Size = new Size(220, 600);
            Options.TabIndex = 0;
            // 
            // Opt_Sobre
            // 
            Opt_Sobre.Cursor = Cursors.Hand;
            Opt_Sobre.Dock = DockStyle.Bottom;
            Opt_Sobre.FlatAppearance.BorderSize = 0;
            Opt_Sobre.FlatStyle = FlatStyle.Flat;
            Opt_Sobre.Font = new Font("Microsoft Sans Serif", 12F);
            Opt_Sobre.ForeColor = Color.Gainsboro;
            Opt_Sobre.Image = Properties.Resources.icons8_info_popup_32;
            Opt_Sobre.ImageAlign = ContentAlignment.MiddleLeft;
            Opt_Sobre.Location = new Point(0, 540);
            Opt_Sobre.Name = "Opt_Sobre";
            Opt_Sobre.Padding = new Padding(12, 0, 0, 0);
            Opt_Sobre.Size = new Size(220, 60);
            Opt_Sobre.TabIndex = 7;
            Opt_Sobre.Text = "   Sobre";
            Opt_Sobre.TextAlign = ContentAlignment.MiddleLeft;
            Opt_Sobre.TextImageRelation = TextImageRelation.ImageBeforeText;
            Opt_Sobre.UseVisualStyleBackColor = true;
            Opt_Sobre.Click += Opt_Sobre_Click;
            // 
            // Opt_Mensagem
            // 
            Opt_Mensagem.Cursor = Cursors.Hand;
            Opt_Mensagem.Dock = DockStyle.Top;
            Opt_Mensagem.FlatAppearance.BorderSize = 0;
            Opt_Mensagem.FlatStyle = FlatStyle.Flat;
            Opt_Mensagem.Font = new Font("Microsoft Sans Serif", 12F);
            Opt_Mensagem.ForeColor = Color.Gainsboro;
            Opt_Mensagem.Image = Properties.Resources.icons8_letter_32;
            Opt_Mensagem.ImageAlign = ContentAlignment.MiddleLeft;
            Opt_Mensagem.Location = new Point(0, 280);
            Opt_Mensagem.Name = "Opt_Mensagem";
            Opt_Mensagem.Padding = new Padding(12, 0, 0, 0);
            Opt_Mensagem.Size = new Size(220, 60);
            Opt_Mensagem.TabIndex = 4;
            Opt_Mensagem.Text = "   Mensagem";
            Opt_Mensagem.TextAlign = ContentAlignment.MiddleLeft;
            Opt_Mensagem.TextImageRelation = TextImageRelation.ImageBeforeText;
            Opt_Mensagem.UseVisualStyleBackColor = true;
            Opt_Mensagem.Click += Opt_Mensagem_Click;
            // 
            // Opt_Editar
            // 
            Opt_Editar.Cursor = Cursors.Hand;
            Opt_Editar.Dock = DockStyle.Top;
            Opt_Editar.FlatAppearance.BorderSize = 0;
            Opt_Editar.FlatStyle = FlatStyle.Flat;
            Opt_Editar.Font = new Font("Microsoft Sans Serif", 12F);
            Opt_Editar.ForeColor = Color.Gainsboro;
            Opt_Editar.Image = Properties.Resources.icons8_edit_32;
            Opt_Editar.ImageAlign = ContentAlignment.MiddleLeft;
            Opt_Editar.Location = new Point(0, 220);
            Opt_Editar.Name = "Opt_Editar";
            Opt_Editar.Padding = new Padding(12, 0, 0, 0);
            Opt_Editar.Size = new Size(220, 60);
            Opt_Editar.TabIndex = 3;
            Opt_Editar.Text = "   Editar";
            Opt_Editar.TextAlign = ContentAlignment.MiddleLeft;
            Opt_Editar.TextImageRelation = TextImageRelation.ImageBeforeText;
            Opt_Editar.UseVisualStyleBackColor = true;
            Opt_Editar.Click += Opt_Editar_Click;
            // 
            // Opt_Cadastrar
            // 
            Opt_Cadastrar.Cursor = Cursors.Hand;
            Opt_Cadastrar.Dock = DockStyle.Top;
            Opt_Cadastrar.FlatAppearance.BorderSize = 0;
            Opt_Cadastrar.FlatStyle = FlatStyle.Flat;
            Opt_Cadastrar.Font = new Font("Microsoft Sans Serif", 12F);
            Opt_Cadastrar.ForeColor = Color.Gainsboro;
            Opt_Cadastrar.Image = Properties.Resources.icons8_sign_up_32;
            Opt_Cadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            Opt_Cadastrar.Location = new Point(0, 160);
            Opt_Cadastrar.Name = "Opt_Cadastrar";
            Opt_Cadastrar.Padding = new Padding(12, 0, 0, 0);
            Opt_Cadastrar.Size = new Size(220, 60);
            Opt_Cadastrar.TabIndex = 2;
            Opt_Cadastrar.Text = "   Cadastrar";
            Opt_Cadastrar.TextAlign = ContentAlignment.MiddleLeft;
            Opt_Cadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            Opt_Cadastrar.UseVisualStyleBackColor = true;
            Opt_Cadastrar.Click += Opt_Cadastrar_Click;
            // 
            // Opt_Listar
            // 
            Opt_Listar.BackColor = Color.FromArgb(32, 32, 42);
            Opt_Listar.Cursor = Cursors.Hand;
            Opt_Listar.Dock = DockStyle.Top;
            Opt_Listar.FlatAppearance.BorderSize = 0;
            Opt_Listar.FlatStyle = FlatStyle.Flat;
            Opt_Listar.Font = new Font("Microsoft Sans Serif", 12F);
            Opt_Listar.ForeColor = Color.Gainsboro;
            Opt_Listar.Image = Properties.Resources.icons8_list_32;
            Opt_Listar.ImageAlign = ContentAlignment.MiddleLeft;
            Opt_Listar.Location = new Point(0, 100);
            Opt_Listar.Name = "Opt_Listar";
            Opt_Listar.Padding = new Padding(12, 0, 0, 0);
            Opt_Listar.Size = new Size(220, 60);
            Opt_Listar.TabIndex = 1;
            Opt_Listar.Text = "   Listar";
            Opt_Listar.TextAlign = ContentAlignment.MiddleLeft;
            Opt_Listar.TextImageRelation = TextImageRelation.ImageBeforeText;
            Opt_Listar.UseVisualStyleBackColor = false;
            Opt_Listar.Click += Opt_Listar_Click;
            // 
            // Logo_Panel
            // 
            Logo_Panel.BackColor = Color.FromArgb(32, 32, 42);
            Logo_Panel.Controls.Add(Opt_Inicio);
            Logo_Panel.Dock = DockStyle.Top;
            Logo_Panel.Location = new Point(0, 0);
            Logo_Panel.Name = "Logo_Panel";
            Logo_Panel.Size = new Size(220, 100);
            Logo_Panel.TabIndex = 1;
            // 
            // Opt_Inicio
            // 
            Opt_Inicio.BackColor = Color.FromArgb(32, 32, 42);
            Opt_Inicio.Image = (Image)resources.GetObject("Opt_Inicio.Image");
            Opt_Inicio.Location = new Point(19, 9);
            Opt_Inicio.Name = "Opt_Inicio";
            Opt_Inicio.Size = new Size(180, 84);
            Opt_Inicio.SizeMode = PictureBoxSizeMode.Zoom;
            Opt_Inicio.TabIndex = 1;
            Opt_Inicio.TabStop = false;
            Opt_Inicio.Click += Opt_Inicio_Click;
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(22, 21, 26);
            Header.Controls.Add(Hdr_Titulo);
            Header.Controls.Add(Opt_Minimizar);
            Header.Controls.Add(Opt_Maximizar);
            Header.Controls.Add(Opt_Sair);
            Header.Controls.Add(Hdr_Icon);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(220, 0);
            Header.Name = "Header";
            Header.Size = new Size(880, 50);
            Header.TabIndex = 1;
            Header.MouseDown += Header_MouseDown;
            // 
            // Hdr_Titulo
            // 
            Hdr_Titulo.AutoSize = true;
            Hdr_Titulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Hdr_Titulo.ForeColor = Color.Gainsboro;
            Hdr_Titulo.Location = new Point(46, 17);
            Hdr_Titulo.Name = "Hdr_Titulo";
            Hdr_Titulo.Size = new Size(46, 20);
            Hdr_Titulo.TabIndex = 1;
            Hdr_Titulo.Text = "Inicio";
            // 
            // Opt_Minimizar
            // 
            Opt_Minimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Opt_Minimizar.Cursor = Cursors.Hand;
            Opt_Minimizar.Image = Properties.Resources.icons8_minimize_32;
            Opt_Minimizar.Location = new Point(783, 15);
            Opt_Minimizar.Name = "Opt_Minimizar";
            Opt_Minimizar.Size = new Size(24, 24);
            Opt_Minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            Opt_Minimizar.TabIndex = 0;
            Opt_Minimizar.TabStop = false;
            Opt_Minimizar.Click += Opt_Minimizar_Click;
            Opt_Minimizar.MouseEnter += Opt_Minimizar_Mouse_Enter;
            Opt_Minimizar.MouseLeave += Opt_Minimizar_Mouse_Left;
            // 
            // Opt_Maximizar
            // 
            Opt_Maximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Opt_Maximizar.Cursor = Cursors.Hand;
            Opt_Maximizar.Image = Properties.Resources.icons8_maximize_32;
            Opt_Maximizar.Location = new Point(813, 15);
            Opt_Maximizar.Name = "Opt_Maximizar";
            Opt_Maximizar.Size = new Size(24, 24);
            Opt_Maximizar.SizeMode = PictureBoxSizeMode.Zoom;
            Opt_Maximizar.TabIndex = 0;
            Opt_Maximizar.TabStop = false;
            Opt_Maximizar.Click += Opt_Maximizar_Click;
            Opt_Maximizar.MouseEnter += Opt_Maximizar_Mouse_Enter;
            Opt_Maximizar.MouseLeave += Opt_Maximizar_Mouse_Left;
            // 
            // Opt_Sair
            // 
            Opt_Sair.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Opt_Sair.Cursor = Cursors.Hand;
            Opt_Sair.Image = Properties.Resources.icons8_shutdown_32;
            Opt_Sair.Location = new Point(843, 15);
            Opt_Sair.Name = "Opt_Sair";
            Opt_Sair.Size = new Size(24, 24);
            Opt_Sair.SizeMode = PictureBoxSizeMode.Zoom;
            Opt_Sair.TabIndex = 0;
            Opt_Sair.TabStop = false;
            Opt_Sair.Click += Opt_Sair_Click;
            Opt_Sair.MouseEnter += Opt_Sair_Mouse_Enter;
            Opt_Sair.MouseLeave += Opt_Sair_Mouse_Left;
            // 
            // Hdr_Icon
            // 
            Hdr_Icon.Image = Properties.Resources.icons8_home_32;
            Hdr_Icon.Location = new Point(19, 15);
            Hdr_Icon.Name = "Hdr_Icon";
            Hdr_Icon.Size = new Size(24, 24);
            Hdr_Icon.SizeMode = PictureBoxSizeMode.Zoom;
            Hdr_Icon.TabIndex = 0;
            Hdr_Icon.TabStop = false;
            // 
            // Forms
            // 
            Forms.BackColor = Color.Silver;
            Forms.Controls.Add(Inicio);
            Forms.Dock = DockStyle.Fill;
            Forms.Location = new Point(220, 50);
            Forms.Name = "Forms";
            Forms.Size = new Size(880, 550);
            Forms.TabIndex = 2;
            // 
            // Inicio
            // 
            Inicio.BackColor = Color.FromArgb(22, 21, 26);
            Inicio.Controls.Add(Panel_Aleatorio);
            Inicio.Controls.Add(Panel_Status);
            Inicio.Controls.Add(Panel_Changelog);
            Inicio.Controls.Add(Panel_Clientes);
            Inicio.Controls.Add(ApexIcon);
            Inicio.Controls.Add(Direitos);
            Inicio.Controls.Add(HoraText);
            Inicio.Controls.Add(BemVindoText);
            Inicio.Dock = DockStyle.Fill;
            Inicio.Location = new Point(0, 0);
            Inicio.Name = "Inicio";
            Inicio.Size = new Size(880, 550);
            Inicio.TabIndex = 0;
            // 
            // Panel_Aleatorio
            // 
            Panel_Aleatorio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Panel_Aleatorio.BackColor = Color.FromArgb(33, 32, 38);
            Panel_Aleatorio.Controls.Add(EmBreve);
            Panel_Aleatorio.Location = new Point(593, 95);
            Panel_Aleatorio.Name = "Panel_Aleatorio";
            Panel_Aleatorio.Size = new Size(265, 126);
            Panel_Aleatorio.TabIndex = 2;
            // 
            // EmBreve
            // 
            EmBreve.AutoSize = true;
            EmBreve.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmBreve.ForeColor = Color.DarkGray;
            EmBreve.Location = new Point(26, 44);
            EmBreve.Name = "EmBreve";
            EmBreve.Size = new Size(218, 42);
            EmBreve.TabIndex = 0;
            EmBreve.Text = "Em breve...";
            EmBreve.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel_Status
            // 
            Panel_Status.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel_Status.BackColor = Color.FromArgb(33, 32, 38);
            Panel_Status.Controls.Add(Status);
            Panel_Status.Controls.Add(SatusLabel);
            Panel_Status.Location = new Point(307, 95);
            Panel_Status.Name = "Panel_Status";
            Panel_Status.Size = new Size(265, 126);
            Panel_Status.TabIndex = 2;
            // 
            // Status
            // 
            Status.Anchor = AnchorStyles.None;
            Status.AutoSize = true;
            Status.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Status.ForeColor = Color.LimeGreen;
            Status.Location = new Point(46, 53);
            Status.Name = "Status";
            Status.Size = new Size(168, 55);
            Status.TabIndex = 0;
            Status.Text = "Online";
            Status.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SatusLabel
            // 
            SatusLabel.AutoSize = true;
            SatusLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SatusLabel.ForeColor = Color.LightGray;
            SatusLabel.Location = new Point(17, 15);
            SatusLabel.Name = "SatusLabel";
            SatusLabel.Size = new Size(163, 24);
            SatusLabel.TabIndex = 0;
            SatusLabel.Text = "Status do Sistema:";
            // 
            // Panel_Changelog
            // 
            Panel_Changelog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel_Changelog.BackColor = Color.FromArgb(33, 32, 38);
            Panel_Changelog.Controls.Add(UpdatesLabel);
            Panel_Changelog.Controls.Add(Update8);
            Panel_Changelog.Controls.Add(Update7);
            Panel_Changelog.Controls.Add(Update5);
            Panel_Changelog.Controls.Add(Update4);
            Panel_Changelog.Controls.Add(Update3);
            Panel_Changelog.Controls.Add(Update2);
            Panel_Changelog.Controls.Add(Update1);
            Panel_Changelog.Location = new Point(19, 238);
            Panel_Changelog.Name = "Panel_Changelog";
            Panel_Changelog.Size = new Size(839, 256);
            Panel_Changelog.TabIndex = 2;
            // 
            // UpdatesLabel
            // 
            UpdatesLabel.AutoSize = true;
            UpdatesLabel.BackColor = Color.FromArgb(33, 32, 38);
            UpdatesLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdatesLabel.ForeColor = Color.LightGray;
            UpdatesLabel.Location = new Point(15, 3);
            UpdatesLabel.Name = "UpdatesLabel";
            UpdatesLabel.Size = new Size(116, 24);
            UpdatesLabel.TabIndex = 0;
            UpdatesLabel.Text = "Atualizações";
            // 
            // Update8
            // 
            Update8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Update8.AutoSize = true;
            Update8.Font = new Font("Microsoft Sans Serif", 15.75F);
            Update8.ForeColor = Color.White;
            Update8.Location = new Point(38, 216);
            Update8.Name = "Update8";
            Update8.Size = new Size(262, 25);
            Update8.TabIndex = 0;
            Update8.Text = "Versão do .Net melhorada";
            // 
            // Update7
            // 
            Update7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Update7.AutoSize = true;
            Update7.Font = new Font("Microsoft Sans Serif", 15.75F);
            Update7.ForeColor = Color.White;
            Update7.Location = new Point(38, 186);
            Update7.Name = "Update7";
            Update7.Size = new Size(160, 25);
            Update7.TabIndex = 0;
            Update7.Text = "+ Novos icones";
            // 
            // Update5
            // 
            Update5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Update5.AutoSize = true;
            Update5.Font = new Font("Microsoft Sans Serif", 15.75F);
            Update5.ForeColor = Color.White;
            Update5.Location = new Point(38, 156);
            Update5.Name = "Update5";
            Update5.Size = new Size(352, 25);
            Update5.TabIndex = 0;
            Update5.Text = "+ Nova tela de login para empresas";
            // 
            // Update4
            // 
            Update4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Update4.AutoSize = true;
            Update4.Font = new Font("Microsoft Sans Serif", 15.75F);
            Update4.ForeColor = Color.White;
            Update4.Location = new Point(38, 126);
            Update4.Name = "Update4";
            Update4.Size = new Size(225, 25);
            Update4.TabIndex = 0;
            Update4.Text = "+ Nova tela de licença";
            // 
            // Update3
            // 
            Update3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Update3.AutoSize = true;
            Update3.Font = new Font("Microsoft Sans Serif", 15.75F);
            Update3.ForeColor = Color.White;
            Update3.Location = new Point(38, 96);
            Update3.Name = "Update3";
            Update3.Size = new Size(319, 25);
            Update3.TabIndex = 0;
            Update3.Text = "+ Nova Interface do menu inicial";
            // 
            // Update2
            // 
            Update2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Update2.AutoSize = true;
            Update2.Font = new Font("Microsoft Sans Serif", 15.75F);
            Update2.ForeColor = Color.White;
            Update2.Location = new Point(38, 66);
            Update2.Name = "Update2";
            Update2.Size = new Size(469, 25);
            Update2.TabIndex = 0;
            Update2.Text = "Função de excluir cliente agora fica junto à lista";
            // 
            // Update1
            // 
            Update1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Update1.AutoSize = true;
            Update1.Font = new Font("Microsoft Sans Serif", 15.75F);
            Update1.ForeColor = Color.White;
            Update1.Location = new Point(38, 36);
            Update1.Name = "Update1";
            Update1.Size = new Size(282, 25);
            Update1.TabIndex = 0;
            Update1.Text = "+ Nova Interface no Sistema";
            // 
            // Panel_Clientes
            // 
            Panel_Clientes.BackColor = Color.FromArgb(33, 32, 38);
            Panel_Clientes.Controls.Add(Clientes);
            Panel_Clientes.Controls.Add(ClienteLabel);
            Panel_Clientes.Location = new Point(19, 95);
            Panel_Clientes.Name = "Panel_Clientes";
            Panel_Clientes.Size = new Size(265, 126);
            Panel_Clientes.TabIndex = 2;
            // 
            // Clientes
            // 
            Clientes.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clientes.ForeColor = Color.MediumSlateBlue;
            Clientes.Location = new Point(15, 53);
            Clientes.Name = "Clientes";
            Clientes.Size = new Size(233, 55);
            Clientes.TabIndex = 0;
            Clientes.Text = "120";
            Clientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ClienteLabel
            // 
            ClienteLabel.AutoSize = true;
            ClienteLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClienteLabel.ForeColor = Color.LightGray;
            ClienteLabel.Location = new Point(15, 15);
            ClienteLabel.Name = "ClienteLabel";
            ClienteLabel.Size = new Size(152, 24);
            ClienteLabel.TabIndex = 0;
            ClienteLabel.Text = "Total de clientes:";
            // 
            // ApexIcon
            // 
            ApexIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ApexIcon.BackColor = Color.FromArgb(22, 21, 26);
            ApexIcon.Image = Properties.Resources.apexiconv2;
            ApexIcon.Location = new Point(798, 21);
            ApexIcon.Name = "ApexIcon";
            ApexIcon.Size = new Size(60, 60);
            ApexIcon.SizeMode = PictureBoxSizeMode.Zoom;
            ApexIcon.TabIndex = 1;
            ApexIcon.TabStop = false;
            ApexIcon.Click += Opt_Inicio_Click;
            // 
            // Direitos
            // 
            Direitos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Direitos.AutoSize = true;
            Direitos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Direitos.ForeColor = Color.Silver;
            Direitos.Location = new Point(19, 510);
            Direitos.Name = "Direitos";
            Direitos.Size = new Size(318, 20);
            Direitos.TabIndex = 0;
            Direitos.Text = "© Apex Client. Todos os direitos reservados.";
            // 
            // HoraText
            // 
            HoraText.AutoSize = true;
            HoraText.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HoraText.ForeColor = Color.FromArgb(153, 153, 153);
            HoraText.Location = new Point(19, 58);
            HoraText.Name = "HoraText";
            HoraText.Size = new Size(306, 24);
            HoraText.TabIndex = 0;
            HoraText.Text = "Agora são 01:40 do dia 10 de Maio.";
            HoraText.TextAlign = ContentAlignment.MiddleLeft;
            HoraText.UseMnemonic = false;
            // 
            // BemVindoText
            // 
            BemVindoText.AutoSize = true;
            BemVindoText.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BemVindoText.ForeColor = Color.Gainsboro;
            BemVindoText.Location = new Point(19, 21);
            BemVindoText.Name = "BemVindoText";
            BemVindoText.Size = new Size(308, 37);
            BemVindoText.TabIndex = 0;
            BemVindoText.Text = "Olá, seja bem vindo.";
            BemVindoText.TextAlign = ContentAlignment.MiddleLeft;
            BemVindoText.UseMnemonic = false;
            // 
            // Temporizador
            // 
            Temporizador.Enabled = true;
            Temporizador.Interval = 1000;
            // 
            // CadPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 21, 26);
            ClientSize = new Size(1100, 600);
            Controls.Add(Forms);
            Controls.Add(Header);
            Controls.Add(Options);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1116, 639);
            Name = "CadPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            TransparencyKey = Color.FromArgb(255, 128, 0);
            Load += CadPrincipal_Load;
            Options.ResumeLayout(false);
            Logo_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Opt_Inicio).EndInit();
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Opt_Minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Opt_Maximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Opt_Sair).EndInit();
            ((System.ComponentModel.ISupportInitialize)Hdr_Icon).EndInit();
            Forms.ResumeLayout(false);
            Inicio.ResumeLayout(false);
            Inicio.PerformLayout();
            Panel_Aleatorio.ResumeLayout(false);
            Panel_Aleatorio.PerformLayout();
            Panel_Status.ResumeLayout(false);
            Panel_Status.PerformLayout();
            Panel_Changelog.ResumeLayout(false);
            Panel_Changelog.PerformLayout();
            Panel_Clientes.ResumeLayout(false);
            Panel_Clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ApexIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Options;
        private PictureBox Opt_Inicio;
        private Button Opt_Listar;
        private Button Opt_Sobre;
        private Button Opt_Mensagem;
        private Button Opt_Editar;
        private Button Opt_Cadastrar;
        private Panel Logo_Panel;
        private Panel Header;
        private PictureBox Hdr_Icon;
        private Label Hdr_Titulo;
        private Panel Forms;
        private PictureBox Opt_Sair;
        private PictureBox Opt_Maximizar;
        private PictureBox Opt_Minimizar;
        private Panel Inicio;
        private Label HoraText;
        private Label BemVindoText;
        private Label Update8;
        private Label Update4;
        private Label Update7;
        private Label Update2;
        private Label Update5;
        private Label Update3;
        private Label Update1;
        private System.Windows.Forms.Timer Temporizador;
        private Label Direitos;
        private PictureBox ApexIcon;
        private Panel Panel_Aleatorio;
        private Panel Panel_Status;
        private Panel Panel_Changelog;
        private Panel Panel_Clientes;
        private Label Clientes;
        private Label ClienteLabel;
        private Label UpdatesLabel;
        private Label EmBreve;
        private Label Status;
        private Label SatusLabel;
    }
}
