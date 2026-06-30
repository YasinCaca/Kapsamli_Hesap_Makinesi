using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Security.Cryptography;

namespace formsdeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private async void button3_Click(object sender, EventArgs e)  //butona basılınca 6 uzun yazılar çıkaran cmd penceresi açıp bilgisayarı kapatır. biraz göz korkutucu ama açılan pencerelerde sadece sistemdeki dosyaları sayıyor.
        {
            Process.Start("cmd.exe", "/k" + " cd.. & cd.. & cd.. & cd.. & cd.. & color a & dir /s");
            await Task.Delay(200);
            Process.Start("cmd.exe", "/k" + " cd.. & cd.. & cd.. & cd.. & cd.. & color c & dir /s");
            await Task.Delay(200);
            Process.Start("cmd.exe", "/k" + " cd.. & cd.. & cd.. & cd.. & cd.. & color a & dir /s");
            await Task.Delay(200);
            Process.Start("cmd.exe", "/k" + " cd.. & cd.. & cd.. & cd.. & cd.. & color c & dir /s");
            await Task.Delay(200);
            Process.Start("cmd.exe", "/k" + " cd.. & cd.. & cd.. & cd.. & cd.. & color a & dir /s");
            await Task.Delay(200);
            Process.Start("cmd.exe", "/k" + " cd.. & cd.. & cd.. & cd.. & cd.. & color c & dir /s");
            await Task.Delay(300);
            Process.Start("cmd.exe", "/k" + " shutdown /s /t 0");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        [DllImport("user32.dll")]
        static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        private void opencmd(int x, int y, int width, int height)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/k echo & cd.. & cd.. & cd.. & cd.. & cd.. & color a & dir /s";
            psi.WindowStyle = ProcessWindowStyle.Normal;
            Process proc = Process.Start(psi);
            Thread.Sleep(100);
            MoveWindow(proc.MainWindowHandle, x, y, width, height, true);
        }

        private void button4_Click(object sender, EventArgs e)    //rastgele konumda ve boyutta 10 cmd penceresi açar
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++) { 
                int x = rand.Next(0,1200);
                int y = rand.Next(0, 700);
                int width = rand.Next(300, 700);
                int height = rand.Next(200, 500);
                opencmd(x, y, width, height);
            }

        }
    }
}
