using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public string[] historialfiles = new String[10];
        public string tabselect { get; set; }

        List<string> listfileopen = new List<string>();


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
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "cprime files (*.cprime)|*.cprime";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            int i = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (String files in openFileDialog1.FileNames)
                {

                    string fname = files.Substring(files.LastIndexOf("\\") + 1);
                    if (verificarExistencia(fname))
                    {
                        MessageBox.Show("El Arhivo '"+fname+"' ya fue abierto.");
                    }
                    else
                    {
                        historialfiles[i] = files;
                        listfileopen.Add(files);
                        newTab(fname);
                        using (FileStream fileStream = File.OpenRead(files))
                        using (StreamReader streamReader = new StreamReader(fileStream))
                        {
                            string fileContent = streamReader.ReadToEnd();
                            RichTextBox rtb = tabControl1.SelectedTab.Controls[0] as RichTextBox;
                            rtb.Clear();
                            rtb.Text = fileContent;
                        }
                        i++;
                    }
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
            Edit_Cut_MenuItem_Click(sender, e);
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
            int indice = tabControl1.SelectedIndex;
            string tabsel = tabControl1.TabPages[indice].ToString();
            RichTextBox rtb = tabControl1.SelectedTab.Controls[0] as RichTextBox;
            save(rtb);
        }

        public void save(RichTextBox rtb)
        {
            tabselect = tabControl1.SelectedTab.Text;
            foreach (string i in listfileopen)
            {
                if (i.Contains(tabselect))
                {
                    this.pathname = i;
                    break;
                }
            }
            if (File.Exists(pathname))
            {
                rtb.SaveFile(pathname, RichTextBoxStreamType.PlainText);
            }
        }


        public bool verificarExistencia(string fname)
        {
            bool flag = false;
            foreach (String i in listfileopen)
            {
                if (!String.IsNullOrEmpty(i))
                {
                    if (i.Contains(fname))
                    {
                        flag = true;
                    }
                }
            } 
            return flag;
        }

        public string getFullPath(string fname)
        {
            string file = "";
            foreach (String i in listfileopen)
            {
                if (!String.IsNullOrEmpty(i))
                {
                    if (i.Contains(fname))
                    {
                        file = i;
                    }
                }
            }
            return file;
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
            Edit_Paste_MenuItem_Click(sender, e);
        }


        private void Edit_Paste_MenuItem_Click(object sender, EventArgs e)
        {

            if (tabControl1.TabCount > 0)
            {   
                int indice = tabControl1.SelectedIndex;
                string tabsel = tabControl1.TabPages[indice].ToString();
                RichTextBox rtb = tabControl1.SelectedTab.Controls[0] as RichTextBox;
                //var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];

                if (Clipboard.ContainsText())
                {
                    String str = Clipboard.GetText();
                    rtb.Paste();
                }
            }
        }


        private void pastBtn_Click(object sender, EventArgs e)
        {
            Edit_Paste_MenuItem_Click(sender, e);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void rtb_TextChanged(object sender, EventArgs e)
        {
            string[] reservadas = { "public", "class", "if", "else", "switch", "case", "default", "break", "while", "for", "int", "float", "string", "char", "bool", "false", "true", "control", "step", "new", "exc", "print", "read", "cadena", "accesometodo", "vstring", "strlng", "searchc", "replace", "parsef", "parimpar", "vint", "vfloat", "cutdecimal", "aproxcut", "partdec", "potencia", "seno", "coseno", "tangente", "pi", "factorial", "raizcuad", "combinacion", "permutacion", "residuodiv", "vabsoluto", "void" };

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

            if(getFullPath(tabControl1.SelectedTab.Text) != null)
            {
                string exe = "analizadorlexico.exe " + getFullPath(tabControl1.SelectedTab.Text); //ubicacion archivo de prueba para compilador osea el que abriste
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
                        //Console.WriteLine(fila.Length);
                        Class1 cl = new Class1();
                        cl.token = fila[0];
                        cl.valor = fila[1];
                        cl.filcol = fila[2];
                        li.Add(cl);
                        //Console.WriteLine(i);
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

            string exe = "ultimatds.exe " + getFullPath(tabControl1.SelectedTab.Text); //ubicacion archivo de prueba para compilador osea el que abriste
            System.Diagnostics.ProcessStartInfo procfile = new System.Diagnostics.ProcessStartInfo("cmd", "/c" + exe);
            procfile.RedirectStandardOutput = true;
            procfile.UseShellExecute = false;
            procfile.CreateNoWindow = true;

            procfile.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procfile;
            proc.Start();

            string result = proc.StandardOutput.ReadToEnd();

            Console.WriteLine(result);

            if (String.IsNullOrEmpty(result))
            {
                MessageBox.Show("Ocurrio un error con el ejecutable...");
            }
            if (result.Contains("OK"))
            {
                dataGridViewSintactico.Rows.Add("Analisis Terminado con exito...", null);
            }
            else
            {
                string parseResult = "";

                if (result[result.Length - 1].Equals('\n'))
                {
                    Console.WriteLine("El archivo tiene salto demas...REMOVIENDO...");
                    parseResult = result.Remove(result.Length - 1);
                    Console.WriteLine("Nuevo resultado: " + parseResult);
                }
                    //dataGridViewSintactico.Rows.Add(linea[0], Int32.Pase(linea[1]));
                    string[] lineasErrores = parseResult.Split('\n');

                    Console.WriteLine(lineasErrores);
                    Console.WriteLine(lineasErrores.Length);

                    tabControl3.Visible = true;
                    dataGridViewSintactico.Rows.Clear();
                    dataGridViewSintactico.Refresh();

                    foreach (String i in lineasErrores)
                    {
                        string[] linea = i.Split('~');
                        dataGridViewSintactico.Rows.Add(linea[0], int.Parse(linea[1])-2);
                    }
            }
        }
               
                              
                    //rtb.SelectionStart = 0;
                    //rtb.Focus();

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newTab("Sin nombre"+ " " + (tabControl1.TabCount + 1).ToString());
        }

        public void newTab(string nametab)
        {
            string title = nametab;
            TabPage myTabPage = new TabPage(title);
            tabControl1.TabPages.Add(myTabPage);
            RichTextBox r = new RichTextBox();
            r.Height = 274;
            r.Width = 636;
            r.Name = "rtbCode";
            r.Font = new Font("Consolas", 10);
            r.TextChanged += new System.EventHandler(this.rtb_TextChanged);
            r.SelectionChanged += new System.EventHandler(rtb_SelectionChanged);
            myTabPage.Controls.Add(r);
            tabControl1.SelectTab(myTabPage);
        }


        public void HighlightLine(int index, Color color)
        {
            RichTextBox richTextBox = tabControl1.SelectedTab.Controls[0] as RichTextBox;

            richTextBox.SelectAll();
            richTextBox.SelectionBackColor = richTextBox.BackColor;
            var lines = richTextBox.Lines;
            if (index < 0 || index >= lines.Length)
            return;
            var start = richTextBox.GetFirstCharIndexFromLine(index);  // Get the 1st char index of the appended text
            var length = lines[index].Length;
            richTextBox.Select(start, length);                 // Select from there to the end
            richTextBox.SelectionBackColor = color;
        }

        private void lineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rtb = tabControl1.SelectedTab.Controls[0] as RichTextBox;
            Random r = new Random();
            int line = r.Next(0, rtb.Lines.Count()); //for ints
            HighlightLine(line, Color.PaleVioletRed);
        }

        private void dataGridViewSintactico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSintactico[e.ColumnIndex, e.RowIndex].GetType() == typeof(DataGridViewLinkCell))
            {
                HighlightLine(Convert.ToInt32(dataGridViewSintactico.SelectedCells[0].Value), Color.PaleVioletRed);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (tabControl1.TabCount != 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea guardar cambios?", "Cerrar archivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                int indice = tabControl1.SelectedIndex;
                string tabsel = "";
                tabsel = tabControl1.SelectedTab.Text;
                RichTextBox rtb = tabControl1.SelectedTab.Controls[0] as RichTextBox;
                if (dialogResult == DialogResult.Yes)
                {
                    save(rtb);
                    tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                    listfileopen.Remove(getFullPath(tabsel));
                }
                else if (dialogResult == DialogResult.No)
                {
                    tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                    listfileopen.Remove(getFullPath(tabsel));
                }
            }
            else
            {
                MessageBox.Show("No hay archivo que cerrar.","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button2,"Cerrar Arhivo Actual");
        }

        private void documentoPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String filename = Application.StartupPath + "\\Diagramas.pdf";
            if (File.Exists(filename))
            {
                Process.Start(filename);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                int indice = tabControl1.SelectedIndex;
                string tabsel = tabControl1.TabPages[indice].ToString();
                RichTextBox rtb = tabControl1.SelectedTab.Controls[0] as RichTextBox;
                Utility.HighlightText(rtb, rtb.Text, Color.White,Color.Black);
                MessageBox.Show("");
            }
            else
            {
                int indice = tabControl1.SelectedIndex;
                string tabsel = tabControl1.TabPages[indice].ToString();
                RichTextBox rtb = tabControl1.SelectedTab.Controls[0] as RichTextBox;
                Utility.HighlightText(rtb,textBox1.Text, Color.Yellow,Color.Red);
            }  
        }

        private void richTxtCode_TextChanged_1(object sender, EventArgs e)
        {
            ///MessageBox.Show("CAMBIO ALGO");
        }

        private void cutBtn_Click(object sender, EventArgs e)
        {
            Edit_Cut_MenuItem_Click(sender, e);
        }

        private void Edit_Cut_MenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                int indice = tabControl1.SelectedIndex;
                string tabsel = tabControl1.TabPages[indice].ToString();
                RichTextBox rtb = tabControl1.SelectedTab.Controls[0] as RichTextBox;

                //var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                if (rtb.SelectedText != "")
                {
                    if (Clipboard.ContainsText())
                    {
                        Clipboard.Clear();
                        Clipboard.SetText(rtb.SelectedText);
                        rtb.SelectedText = "";
                    }
                    else
                    {
                        Clipboard.SetText(rtb.SelectedText);
                        rtb.SelectedText = "";
                    }
                }
            }
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                int indice = tabControl1.SelectedIndex;
                string tabsel = tabControl1.TabPages[indice].ToString();
                RichTextBox rtb = tabControl1.SelectedTab.Controls[0] as RichTextBox;

                if (!(String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(txtReplace.Text)))
                {
                    rtb.Text = rtb.Text.Replace(textBox1.Text, txtReplace.Text);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(txtReplace.Text)))
            {
                textBox1.Text = "";
                txtReplace.Text = "";
            }
        }
    }
}
