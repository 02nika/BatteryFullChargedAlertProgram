using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainVoice.Start(96);
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"D:\nika\my own stuff\musics\alert\Sound.Wav";
            player.Play();

            //ეკრანზე დაინახავს მომხმარებელი - არ იქნება ჩაკეცილ მდგომარეობაში
            this.WindowState = FormWindowState.Minimized;
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread.Sleep(180000);
            Application.Restart();
        }
    }
}
