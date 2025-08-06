using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApexClientV2
{
    public partial class CadLicensa : Form
    {
        private string Licensa = "KEY-1A23-S6U8-910O-12KO";
        public CadLicensa()
        {
            InitializeComponent();
            CadPrincipal principal = new CadPrincipal();
            principal.ArredondarPanel(Panel_Licensa, 20);
            Task.Delay(300);
            principal.ArredondarBotao(Continue, 20);
            principal.ArredondarBotao(Cancel, 20);
        }
        private void Continue_Click(object sender, EventArgs e)
        {
            if (LicensaBox.Text.Trim() == Licensa)
            {
                CadPrincipal principal = new CadPrincipal();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Licença inválida. Verifique a chave e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
