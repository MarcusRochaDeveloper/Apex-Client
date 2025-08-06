namespace ApexClientV2
{
    partial class CadLicensa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadLicensa));
            LicensaLabel = new Label();
            LicensaEmail = new Panel();
            LicensaBox = new TextBox();
            Continue = new Button();
            Logo = new PictureBox();
            Cancel = new Button();
            Panel_Licensa = new Panel();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            Panel_Licensa.SuspendLayout();
            SuspendLayout();
            // 
            // LicensaLabel
            // 
            LicensaLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LicensaLabel.AutoSize = true;
            LicensaLabel.BackColor = Color.FromArgb(42, 42, 60);
            LicensaLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LicensaLabel.ForeColor = Color.Gainsboro;
            LicensaLabel.Location = new Point(14, 13);
            LicensaLabel.Name = "LicensaLabel";
            LicensaLabel.Size = new Size(279, 20);
            LicensaLabel.TabIndex = 8;
            LicensaLabel.Text = "Digite a chave para liberar sua licença:";
            // 
            // LicensaEmail
            // 
            LicensaEmail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LicensaEmail.BackColor = Color.Gainsboro;
            LicensaEmail.Location = new Point(14, 57);
            LicensaEmail.Name = "LicensaEmail";
            LicensaEmail.Size = new Size(363, 3);
            LicensaEmail.TabIndex = 7;
            // 
            // LicensaBox
            // 
            LicensaBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LicensaBox.BackColor = Color.FromArgb(42, 42, 60);
            LicensaBox.BorderStyle = BorderStyle.None;
            LicensaBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LicensaBox.ForeColor = Color.LightGray;
            LicensaBox.Location = new Point(14, 36);
            LicensaBox.Name = "LicensaBox";
            LicensaBox.Size = new Size(366, 19);
            LicensaBox.TabIndex = 6;
            // 
            // Continue
            // 
            Continue.BackColor = Color.FromArgb(12, 12, 22);
            Continue.FlatAppearance.BorderSize = 0;
            Continue.FlatStyle = FlatStyle.Flat;
            Continue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Continue.ForeColor = Color.Gainsboro;
            Continue.Image = Properties.Resources.icons8_continue_32;
            Continue.ImageAlign = ContentAlignment.MiddleRight;
            Continue.Location = new Point(303, 230);
            Continue.Name = "Continue";
            Continue.Size = new Size(148, 44);
            Continue.TabIndex = 10;
            Continue.Text = "Continuar ";
            Continue.TextAlign = ContentAlignment.MiddleRight;
            Continue.TextImageRelation = TextImageRelation.TextBeforeImage;
            Continue.UseVisualStyleBackColor = false;
            Continue.Click += Continue_Click;
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.apexlogov2;
            Logo.Location = new Point(135, 35);
            Logo.Name = "Logo";
            Logo.Size = new Size(202, 86);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 11;
            Logo.TabStop = false;
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.FromArgb(22, 22, 32);
            Cancel.FlatAppearance.BorderSize = 0;
            Cancel.FlatStyle = FlatStyle.Flat;
            Cancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Cancel.ForeColor = Color.Gainsboro;
            Cancel.Image = Properties.Resources.icons8_cancel_32;
            Cancel.ImageAlign = ContentAlignment.MiddleLeft;
            Cancel.Location = new Point(149, 230);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(148, 44);
            Cancel.TabIndex = 10;
            Cancel.Text = "  Cancelar";
            Cancel.TextAlign = ContentAlignment.MiddleLeft;
            Cancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // Panel_Licensa
            // 
            Panel_Licensa.BackColor = Color.FromArgb(42, 42, 60);
            Panel_Licensa.Controls.Add(LicensaBox);
            Panel_Licensa.Controls.Add(LicensaLabel);
            Panel_Licensa.Controls.Add(LicensaEmail);
            Panel_Licensa.Location = new Point(55, 142);
            Panel_Licensa.Name = "Panel_Licensa";
            Panel_Licensa.Size = new Size(396, 72);
            Panel_Licensa.TabIndex = 12;
            // 
            // CadLicensa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 42);
            ClientSize = new Size(500, 300);
            Controls.Add(Panel_Licensa);
            Controls.Add(Logo);
            Controls.Add(Cancel);
            Controls.Add(Continue);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CadLicensa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadLicensa";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            Panel_Licensa.ResumeLayout(false);
            Panel_Licensa.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LicensaLabel;
        private Panel LicensaEmail;
        private TextBox LicensaBox;
        private Button Continue;
        private PictureBox Logo;
        private Button Cancel;
        private Panel Panel_Licensa;
    }
}