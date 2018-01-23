using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRIME_IDE_v2
{
    public partial class anLexico : Form
    {
        String path;
        public anLexico()
        {
            InitializeComponent();
        }

        public anLexico(String pathname)
        {
            this.path = pathname;               //aca esta la ubicacion del arch
            InitializeComponent();
        }

        public void analizando()
        {
            txtResultToken.Text = "";
            //string ubicacion = "D:\\UCA\\Compiladores\\ExampleLexico\\LenguajePL\\ejemplo1.pas";

            string exe = "cprime.exe " + this.path; //ubicacion archivo de prueba para compilador osea el que abriste
            System.Diagnostics.ProcessStartInfo procfile = new System.Diagnostics.ProcessStartInfo("cmd", "/c" + exe);
            procfile.RedirectStandardOutput = true;
            procfile.UseShellExecute = false;
            procfile.CreateNoWindow = true;

            procfile.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procfile;
            proc.Start();

            string result = proc.StandardOutput.ReadToEnd();
            string formatresult = result.Replace("\n","\r\n");
            string formtresulttab = formatresult.Replace("|", "\t\t");
            txtResultToken.Text = formtresulttab;//control para mostrarlo el resultado de consola 
            Console.WriteLine(result);
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void anLexico_Load(object sender, EventArgs e)
        {
            MessageBox.Show("An. lexicografico para archivo ubicado en "+this.path);

            analizando();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
