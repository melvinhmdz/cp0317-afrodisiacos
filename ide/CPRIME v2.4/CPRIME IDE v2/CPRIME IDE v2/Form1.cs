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

            string exe = "LenguajePL.exe " + this.path; //ubicacion archivo de prueba para compilador osea el que abriste
            System.Diagnostics.ProcessStartInfo procfile = new System.Diagnostics.ProcessStartInfo("cmd", "/c" + exe);
            procfile.RedirectStandardOutput = true;
            procfile.UseShellExecute = false;
            procfile.CreateNoWindow = true;

            procfile.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procfile;
            proc.Start();

            string result = proc.StandardOutput.ReadToEnd();
            txtResultToken.Text = result;//control para mostrarlo el resultado de consola 
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void anLexico_Load(object sender, EventArgs e)
        {
            MessageBox.Show("An. lexicografico para"+this.path);
            //analizando();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
