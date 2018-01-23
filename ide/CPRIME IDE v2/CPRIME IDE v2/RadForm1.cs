using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Security.Permissions.FileIOPermission

namespace CPRIME_IDE_v2
{
    public partial class RadForm1 : Form
    {
        public String pathname { get; set; }
        public RadForm1()
        {
            InitializeComponent();
        }


        private void RadForm1_Load(object sender, EventArgs e)
        {
            btnArch.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.BorderSize = 0;
            //btnFormato.FlatAppearance.BorderSize = 0;
            btnEtapas.FlatAppearance.BorderSize = 0;
            btnReg.FlatAppearance.BorderSize = 0;
            btnOpenArch.FlatAppearance.BorderSize = 0;
            compBtn.FlatAppearance.BorderSize = 0;
            compilarBtn.FlatAppearance.BorderSize = 0;
            regCompButton.FlatAppearance.BorderSize = 0;
            nuevoBtn.FlatAppearance.BorderSize = 0;
            archPanel.Visible = false;
            compPanel.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            archPanel.Visible = true;
            compPanel.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            using (AboutBox1 box = new AboutBox1())
            {
                box.ShowDialog(this);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AbrirArch()
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            //openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            String fname = openFileDialog1.FileName.ToString();
                            this.pathname = openFileDialog1.FileName.ToString();
                            //MessageBox.Show(openFileDialog1.FileName.ToString());
                            using (FileStream fileStream = File.OpenRead(fname))
                            using (StreamReader streamReader = new StreamReader(fileStream))
                            {
                                string fileContent = streamReader.ReadToEnd();
                                richTxtCode.Text = fileContent;
                            }
                            //codeTxt.Text = openFileDialog1.FileName.();
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirArch();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            archPanel.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnArch_MouseDown(object sender, MouseEventArgs e)
        {
            this.ForeColor = Color.Orange;
        }

        private void btn_mousedown(object sender, EventArgs e)
        {
            var oSender = (sender as Button);
            oSender.ForeColor = Color.Orange;
            //btnArch.ForeColor = Color.Orange;
            //btnArch.Font = new Font(btnArch.Font.Name, btnArch.Font.SizeInPoints, FontStyle.Bold);
            //pictureBox1.BackColor = Color.DarkGray;
        }

        private void btnArch_MouseHover(object sender, EventArgs e)
        {
            this.ForeColor = Color.Orange;
        }

        private void btnArch_MouseDown_1(object sender, MouseEventArgs e)
        {

        }

        private void btnArch_MouseLeave(object sender, EventArgs e)
        {
            var oSender = (sender as Button);
            oSender.ForeColor = Color.White;
            //btnArch.ForeColor = Color.White;
            //btnArch.Font = new Font(btnArch.Font.Name, btnArch.Font.SizeInPoints, FontStyle.Regular);
        }

        private void btnArch_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void compBtn_Click(object sender, EventArgs e)
        {
            archPanel.Visible = false;
            compPanel.Visible = true;
        }

        private void regCompButton_Click(object sender, EventArgs e)
        {
            compPanel.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTxtCode.Text);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            richTxtCode.Text = Clipboard.GetText();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void codeTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void analizadorLex()
        {
            anLexico anlexicoF = new anLexico(this.pathname);
            anlexicoF.Show();
        }

        private void compilarBtn_Click(object sender, EventArgs e)
        {
            analizadorLex();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(richTxtCode.SelectedText.ToString() != null)
            {
                Clipboard.SetText(richTxtCode.SelectedText, TextDataFormat.UnicodeText);

            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            richTxtCode.Text = richTxtCode.Text+Clipboard.GetText();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        public void Run()
        {
            MessageBox.Show("Algun dia servira el Ejecutar");
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            Run();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefileD = new SaveFileDialog();
            if(savefileD.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(savefileD.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(richTxtCode.Text);
                    this.pathname = savefileD.FileName.ToString();
                }
            }
        }

        private void richTxtCode_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                SaveFileDialog savefileD = new SaveFileDialog();
                if (savefileD.ShowDialog() == DialogResult.OK)
                {
                    using (Stream s = File.Open(savefileD.FileName, FileMode.CreateNew))
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        sw.Write(richTxtCode.Text);
                        this.pathname = savefileD.FileName.ToString();
                    }
                }
   
            }

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.R)
            {
                Run();

            }

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.N)
            {
                AbrirArch();

            }

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                analizadorLex();

            }
        }

        private void RadForm1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.N)
            {
                AbrirArch();

            }
        }

        private void btnEtapas_Click(object sender, EventArgs e)
        {

        }

        private void asidemenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
