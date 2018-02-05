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
        public string pathname { get; set; }

        public RadForm1()
        {
            InitializeComponent();
        }

        private void RadForm1_Load(object sender, EventArgs e)
        {
            this.richTxtCode.TextChanged += new System.EventHandler(this.rtb_TextChanged);
            this.richTxtCode.SelectionChanged += new System.EventHandler(this.rtb_SelectionChanged);

            saveBtn.FlatAppearance.BorderSize = 0;
            opnFilebtn.FlatAppearance.BorderSize = 0;
            copyBtn.FlatAppearance.BorderSize = 0;
            cutBtn.FlatAppearance.BorderSize = 0;
            pastBtn.FlatAppearance.BorderSize = 0;
            undoBtn.FlatAppearance.BorderSize = 0;
            redoBtn.FlatAppearance.BorderSize = 0;
            compileBtn.FlatAppearance.BorderSize = 0;
            searchBtn.FlatAppearance.BorderSize = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.pathname != null)
            {
                MessageBox.Show(pathname);
                using (Stream s = File.OpenWrite(this.pathname))                
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(richTxtCode.Text);
                    MessageBox.Show("Cambios guardados");
                }
            }
            else
            {
                SaveFileDialog savefileD = new SaveFileDialog();
                if (savefileD.ShowDialog() == DialogResult.OK)
                using (Stream s = File.Create(savefileD.FileName))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(richTxtCode.Text);
                    this.pathname = Path.GetFullPath(savefileD.FileName);
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

            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "cprime files (*.cprime)|*.cprime";
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
                            this.pathname = Path.GetFullPath(openFileDialog1.FileName);
                            using (FileStream fileStream = File.OpenRead(fname))
                            using (StreamReader streamReader = new StreamReader(fileStream))
                            {
                                string fileContent = streamReader.ReadToEnd();
                                RichTextBox rtb = tabControl1.SelectedTab.Controls[0] as RichTextBox;
                                rtb.Clear();                               
                                rtb.Text = fileContent;
                                rtb.SelectionStart = 0;
                                rtb.Focus();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                tabControl1.SelectedTab.Text = Path.GetFileName(this.pathname);
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
            tabPage1.Text = Path.GetFileName(this.pathname);
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

        void nuevoTab()
        {
           // tabControl1.TabPages.Insert();
        }


        private void abrirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AbrirArch();
            nuevoTab();
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
            tabPage1.Text = Path.GetFileName(this.pathname);

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

        private void rtb_TextChanged(object sender, EventArgs e)
        {
            string[] reservadas = { "public", "class", "if", "else", "switch", "case", "default", "break", "while", "for", "int", "float", "string", "char", "bool", "false", "true", "control", "step", "new", "exc", "print", "read", "cadena", "accesometodo", "vstring", "strlng", "searchc", "replace", "parsef", "parimpar", "vint", "vfloat", "cutdecimal", "aproxcut", "partdec", "potencia", "seno", "coseno", "tangente", "pi", "factorial", "raizcuad", "combinacion", "permutacion", "residuodiv", "vabsoluto", "void" };

            RichTextBox rtb = tabControl1.SelectedTab.Controls[0] as RichTextBox;

            foreach (string palabra in reservadas)
            {
                this.CheckKeyword(palabra, Color.CadetBlue, 0);
            }


        }


        private void rtb_SelectionChanged(object sender, EventArgs e)
        {
            RichTextBox rtb = tabControl1.SelectedTab.Controls[0] as RichTextBox;

            int index = rtb.SelectionStart;
            int line = rtb.GetLineFromCharIndex(index);
            int firstChar = rtb.GetFirstCharIndexFromLine(line);
            int col = index - firstChar;
            label9.Text = (line + 1).ToString();
            label11.Text = (col + 1).ToString();
        }

        private void CheckKeyword(string word, Color color, int startIndex)
        {
            RichTextBox rtb = tabControl1.SelectedTab.Controls[0] as RichTextBox;
            if (rtb.Text.Contains(word))
            {
                int index = -1;
                int selectStart = rtb.SelectionStart;

                while ((index = rtb.Text.IndexOf(word, (index + 1))) != -1)
                {
                    rtb.Select((index + startIndex), word.Length);
                    rtb.SelectionColor = color;
                    rtb.Select(selectStart, 0);
                    rtb.SelectionColor = Color.Black;
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void anLexicograficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.pathname != null)
            {
                string exe = "analizadorlexico.exe " + this.pathname; //ubicacion archivo de prueba para compilador osea el que abriste
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
                tabControl3.Visible = true;
            }
            else
            {
                MessageBox.Show("El archivo debe guardarse antes de realizar algun analisis");
            }
            
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefileD = new SaveFileDialog();
            if (savefileD.ShowDialog() == DialogResult.OK)
            {              
                using (Stream s = File.OpenWrite(this.pathname))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(richTxtCode.Text);
                    this.pathname = savefileD.FileName.ToString();
                }
            }
            tabPage1.Text = Path.GetFileName(this.pathname);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            if(this.pathname != null)
            {
                tabPage1.Text = Path.GetFileName(this.pathname);
            }
        }

        private void anSintacticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl3.Visible = true;
            if (this.pathname != null)
            {
                string exe = "parser_v1.exe " + this.pathname; //ubicacion archivo de prueba para compilador osea el que abriste
                System.Diagnostics.ProcessStartInfo procfile = new System.Diagnostics.ProcessStartInfo("cmd", "/c" + exe);
                procfile.RedirectStandardOutput = true;
                procfile.UseShellExecute = false;
                procfile.CreateNoWindow = true;

                procfile.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procfile;
                proc.Start();

                string result = proc.StandardOutput.ReadToEnd();

                textBoxError.Text = result;
            }

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = "Sin Nombre " + (tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            tabControl1.TabPages.Add(myTabPage);
            
            RichTextBox r = new RichTextBox();
            
            r.Height = 274;
            r.Width = 636;
            r.Name = "rtbCode";
            r.TextChanged += new System.EventHandler(this.rtb_TextChanged);
            r.SelectionChanged += new System.EventHandler(rtb_SelectionChanged);

            myTabPage.Controls.Add(r);



            tabControl1.SelectTab(myTabPage);
            
            
        }
    }
}
