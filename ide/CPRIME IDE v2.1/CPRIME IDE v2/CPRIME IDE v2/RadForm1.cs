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

        string path;

        private void RadForm1_Load(object sender, EventArgs e)
        {
            saveBtn.FlatAppearance.BorderSize = 0;
            opnFilebtn.FlatAppearance.BorderSize = 0;
            copyBtn.FlatAppearance.BorderSize = 0;
            cutBtn.FlatAppearance.BorderSize = 0;
            pastBtn.FlatAppearance.BorderSize = 0;
            undoBtn.FlatAppearance.BorderSize = 0;
            redoBtn.FlatAppearance.BorderSize = 0;
            compileBtn.FlatAppearance.BorderSize = 0;
            searchBtn.FlatAppearance.BorderSize = 0;
            //btnEdit.FlatAppearance.BorderSize = 0;
            //btnFormato.FlatAppearance.BorderSize = 0;
            //btnEtapas.FlatAppearance.BorderSize = 0;
            //btnReg.FlatAppearance.BorderSize = 0;
            //btnOpenArch.FlatAppearance.BorderSize = 0;
            //compBtn.FlatAppearance.BorderSize = 0;
            //CompButton.FlatAppearance.BorderSize = 0;
            //nuevoBtn.FlatAppearance.BorderSize = 0;
            //archPanel.Visible = false;
            //compPanel.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                            this.path = openFileDialog1.FileName.ToString();
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
            
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            //archPanel.Visible = false;
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
            //archPanel.Visible = false;
            //compPanel.Visible = true;
        }

        private void regCompButton_Click(object sender, EventArgs e)
        {
            // compPanel.Visible = false;
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
            //MessageBox.Show("Algun dia servira el Ejecutar");
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

        private void richTxtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void documentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirArch();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirArch();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void opnFilebtn_Click(object sender, EventArgs e)
        {
            AbrirArch();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }
        static StreamReader leer;
        static StreamWriter escribir;
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTxtCode.Text == "")
            {
                MessageBox.Show("Primero abra un archivo");
            }
            else
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
            
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            if (richTxtCode.SelectedText.ToString() != null)
            {
                Clipboard.SetText(richTxtCode.SelectedText, TextDataFormat.UnicodeText);

            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTxtCode.SelectedText.ToString() != null)
            {
                Clipboard.SetText(richTxtCode.SelectedText, TextDataFormat.UnicodeText);

            }
        }

        private void pegarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTxtCode.Text = richTxtCode.Text + Clipboard.GetText();
        }

        private void pastBtn_Click(object sender, EventArgs e)
        {
            richTxtCode.Text = richTxtCode.Text + Clipboard.GetText();
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void richTxtCode_TextChanged_1(object sender, EventArgs e)
        {

            int index = richTxtCode.SelectionStart;
            int line = richTxtCode.GetLineFromCharIndex(index) ;
            int firstChar = richTxtCode.GetFirstCharIndexFromLine(line);
            int col = index - firstChar;
            label9.Text = (line + 1).ToString();
            label11.Text = (col + 1).ToString();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void anLexicograficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string exe = "analizadorlexico.exe " + this.path; //ubicacion archivo de prueba para compilador osea el que abriste
            System.Diagnostics.ProcessStartInfo procfile = new System.Diagnostics.ProcessStartInfo("cmd", "/c" + exe);
            procfile.RedirectStandardOutput = true;
            procfile.UseShellExecute = false;
            procfile.CreateNoWindow = true;

            procfile.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procfile;
            proc.Start();

            string result = proc.StandardOutput.ReadToEnd();

            string result2 = result.Remove(result.Length - 1);

            String[] arrL = result2.Split('\n');
            if (String.IsNullOrEmpty(result))
            {
                MessageBox.Show("Ocurrio un error, intente de nuevo...");
            }
            else
            {

                List<Class1> li = new List<Class1>();
                foreach (String i in arrL)
                {
                    String[] fila = i.Split('|');
                    Console.WriteLine(fila.Length);
                    Class1 cl = new Class1();
                    cl.token = fila[0];
                    cl.valor = fila[1];
                    cl.filcol = fila[2];
                    li.Add(cl);
                    Console.WriteLine(i);
                }
                dataGridView1.DataSource = li;
            }
        }

       

    }
}
