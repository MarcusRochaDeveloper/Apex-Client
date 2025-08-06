using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ApexClientV2
{
    public partial class CadSplash : Form
    {
        private float angulo = 0;
        private int duracao;
        private Stopwatch cronometro;

        public CadSplash(int duracaoMs)
        {
            InitializeComponent();
            this.duracao = duracaoMs;

            Loading.Image = Properties.Resources.icons8_loading_50;

            cronometro = new Stopwatch();
            cronometro.Start();

            Tempo.Interval = 60;
            Tempo.Tick += Timer_Tick;
            Tempo.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            angulo += 15;
            Loading.Image = RotacionarImagem(Properties.Resources.icons8_loading_50, angulo);

            if (cronometro.ElapsedMilliseconds >= duracao)
            {
                Tempo.Stop();
                cronometro.Stop();

                CadLicensa principal = new CadLicensa();
                principal.Show();
                this.Hide();
            }
        }
        private Image RotacionarImagem(Image img, float angulo)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            bmp.SetResolution(img.HorizontalResolution, img.VerticalResolution);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.TranslateTransform(img.Width / 2, img.Height / 2);
                g.RotateTransform(angulo);
                g.TranslateTransform(-img.Width / 2, -img.Height / 2);
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, new Point(0, 0));
            }

            return bmp;
        }
    }
}