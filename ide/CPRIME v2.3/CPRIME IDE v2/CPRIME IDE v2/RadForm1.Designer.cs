namespace CPRIME_IDE_v2
{
    partial class RadForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anLexicograficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anSintacticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentoPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTxtCode = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.redoBtn = new System.Windows.Forms.Button();
            this.undoBtn = new System.Windows.Forms.Button();
            this.pastBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.compileBtn = new System.Windows.Forms.Button();
            this.cutBtn = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.opnFilebtn = new System.Windows.Forms.Button();
            this.asidemenu = new System.Windows.Forms.Panel();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.asidemenu.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 29);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.ejecutarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = global::CPRIME_IDE_v2.Properties.Resources._new;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = global::CPRIME_IDE_v2.Properties.Resources.open;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click_1);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Image = global::CPRIME_IDE_v2.Properties.Resources.save;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Image = global::CPRIME_IDE_v2.Properties.Resources.saveas;
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como ...";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.pegarToolStripMenuItem1});
            this.editarToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Image = global::CPRIME_IDE_v2.Properties.Resources.copy1;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Image = global::CPRIME_IDE_v2.Properties.Resources.cut;
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.pegarToolStripMenuItem.Text = "Cortar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem1
            // 
            this.pegarToolStripMenuItem1.Image = global::CPRIME_IDE_v2.Properties.Resources.paste;
            this.pegarToolStripMenuItem1.Name = "pegarToolStripMenuItem1";
            this.pegarToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.pegarToolStripMenuItem1.Text = "Pegar";
            this.pegarToolStripMenuItem1.Click += new System.EventHandler(this.pegarToolStripMenuItem1_Click);
            // 
            // ejecutarToolStripMenuItem
            // 
            this.ejecutarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anLexicograficoToolStripMenuItem,
            this.anSintacticoToolStripMenuItem});
            this.ejecutarToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejecutarToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ejecutarToolStripMenuItem.Name = "ejecutarToolStripMenuItem";
            this.ejecutarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ejecutarToolStripMenuItem.Text = "Ejecutar";
            // 
            // anLexicograficoToolStripMenuItem
            // 
            this.anLexicograficoToolStripMenuItem.Name = "anLexicograficoToolStripMenuItem";
            this.anLexicograficoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.anLexicograficoToolStripMenuItem.Text = "An. Lexicografico";
            this.anLexicograficoToolStripMenuItem.Click += new System.EventHandler(this.anLexicograficoToolStripMenuItem_Click);
            // 
            // anSintacticoToolStripMenuItem
            // 
            this.anSintacticoToolStripMenuItem.Name = "anSintacticoToolStripMenuItem";
            this.anSintacticoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.anSintacticoToolStripMenuItem.Text = "An. Sintactico";
            this.anSintacticoToolStripMenuItem.Click += new System.EventHandler(this.anSintacticoToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentoPDFToolStripMenuItem});
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // documentoPDFToolStripMenuItem
            // 
            this.documentoPDFToolStripMenuItem.Image = global::CPRIME_IDE_v2.Properties.Resources.help;
            this.documentoPDFToolStripMenuItem.Name = "documentoPDFToolStripMenuItem";
            this.documentoPDFToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.documentoPDFToolStripMenuItem.Text = "Documento PDF";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(4, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 319);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.tabControl2);
            this.panel4.Location = new System.Drawing.Point(657, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 305);
            this.panel4.TabIndex = 6;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(3, 1);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(157, 283);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(149, 254);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Detalle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.63504F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.36496F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(137, 85);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Linea :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Unnamed";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "1";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Col";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "1";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(149, 254);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Explorador";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 309);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTxtCode);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(644, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sin Nombre";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // richTxtCode
            // 
            this.richTxtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtCode.Location = new System.Drawing.Point(5, 3);
            this.richTxtCode.Name = "richTxtCode";
            this.richTxtCode.Size = new System.Drawing.Size(636, 274);
            this.richTxtCode.TabIndex = 4;
            this.richTxtCode.Text = "";
            this.richTxtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTxtCode_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.redoBtn);
            this.panel3.Controls.Add(this.undoBtn);
            this.panel3.Controls.Add(this.pastBtn);
            this.panel3.Controls.Add(this.searchBtn);
            this.panel3.Controls.Add(this.compileBtn);
            this.panel3.Controls.Add(this.cutBtn);
            this.panel3.Controls.Add(this.copyBtn);
            this.panel3.Controls.Add(this.saveBtn);
            this.panel3.Controls.Add(this.opnFilebtn);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(4, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(833, 30);
            this.panel3.TabIndex = 13;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(352, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Run ";
            // 
            // redoBtn
            // 
            this.redoBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.redoBtn.BackgroundImage = global::CPRIME_IDE_v2.Properties.Resources.small_right_arrow_png_image_68661;
            this.redoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.redoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.redoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redoBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redoBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.redoBtn.Location = new System.Drawing.Point(205, 1);
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.redoBtn.Size = new System.Drawing.Size(30, 26);
            this.redoBtn.TabIndex = 16;
            this.redoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.redoBtn.UseVisualStyleBackColor = false;
            // 
            // undoBtn
            // 
            this.undoBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.undoBtn.BackgroundImage = global::CPRIME_IDE_v2.Properties.Resources.img_109185;
            this.undoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.undoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undoBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undoBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.undoBtn.Location = new System.Drawing.Point(180, 3);
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.undoBtn.Size = new System.Drawing.Size(25, 22);
            this.undoBtn.TabIndex = 15;
            this.undoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.undoBtn.UseVisualStyleBackColor = false;
            // 
            // pastBtn
            // 
            this.pastBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pastBtn.BackgroundImage = global::CPRIME_IDE_v2.Properties.Resources._1486504835_clipboard_copy_delete_minus_paste_remove_81365;
            this.pastBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pastBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pastBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pastBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pastBtn.Location = new System.Drawing.Point(152, 3);
            this.pastBtn.Name = "pastBtn";
            this.pastBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pastBtn.Size = new System.Drawing.Size(25, 22);
            this.pastBtn.TabIndex = 12;
            this.pastBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pastBtn.UseVisualStyleBackColor = false;
            this.pastBtn.Click += new System.EventHandler(this.pastBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.searchBtn.BackgroundImage = global::CPRIME_IDE_v2.Properties.Resources.Search_ballonicon2_svg;
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.searchBtn.Location = new System.Drawing.Point(298, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchBtn.Size = new System.Drawing.Size(25, 22);
            this.searchBtn.TabIndex = 14;
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.button8_Click);
            // 
            // compileBtn
            // 
            this.compileBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.compileBtn.BackgroundImage = global::CPRIME_IDE_v2.Properties.Resources.Play_groen;
            this.compileBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.compileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compileBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compileBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.compileBtn.Location = new System.Drawing.Point(327, 4);
            this.compileBtn.Name = "compileBtn";
            this.compileBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.compileBtn.Size = new System.Drawing.Size(25, 22);
            this.compileBtn.TabIndex = 13;
            this.compileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.compileBtn.UseVisualStyleBackColor = false;
            // 
            // cutBtn
            // 
            this.cutBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cutBtn.BackgroundImage = global::CPRIME_IDE_v2.Properties.Resources.cut;
            this.cutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cutBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cutBtn.Location = new System.Drawing.Point(124, 3);
            this.cutBtn.Name = "cutBtn";
            this.cutBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cutBtn.Size = new System.Drawing.Size(25, 22);
            this.cutBtn.TabIndex = 11;
            this.cutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cutBtn.UseVisualStyleBackColor = false;
            // 
            // copyBtn
            // 
            this.copyBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.copyBtn.BackgroundImage = global::CPRIME_IDE_v2.Properties.Resources.bfa_copy_flat_circle_white_on_ios_orange_gradient_512x512;
            this.copyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.copyBtn.Location = new System.Drawing.Point(96, 3);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.copyBtn.Size = new System.Drawing.Size(25, 22);
            this.copyBtn.TabIndex = 10;
            this.copyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.copyBtn.UseVisualStyleBackColor = false;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.saveBtn.BackgroundImage = global::CPRIME_IDE_v2.Properties.Resources._284010;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.saveBtn.Location = new System.Drawing.Point(40, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveBtn.Size = new System.Drawing.Size(25, 22);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.button1_Click);
            this.saveBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnArch_MouseDown_1);
            this.saveBtn.MouseLeave += new System.EventHandler(this.btnArch_MouseLeave);
            this.saveBtn.MouseHover += new System.EventHandler(this.btn_mousedown);
            this.saveBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnArch_MouseUp);
            // 
            // opnFilebtn
            // 
            this.opnFilebtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.opnFilebtn.BackgroundImage = global::CPRIME_IDE_v2.Properties.Resources._14_512;
            this.opnFilebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.opnFilebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opnFilebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opnFilebtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opnFilebtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.opnFilebtn.Location = new System.Drawing.Point(12, 3);
            this.opnFilebtn.Name = "opnFilebtn";
            this.opnFilebtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opnFilebtn.Size = new System.Drawing.Size(25, 22);
            this.opnFilebtn.TabIndex = 8;
            this.opnFilebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.opnFilebtn.UseVisualStyleBackColor = false;
            this.opnFilebtn.Click += new System.EventHandler(this.opnFilebtn_Click);
            // 
            // asidemenu
            // 
            this.asidemenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.asidemenu.Controls.Add(this.tabControl3);
            this.asidemenu.Controls.Add(this.panel5);
            this.asidemenu.Controls.Add(this.panel3);
            this.asidemenu.Controls.Add(this.panel2);
            this.asidemenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.asidemenu.Location = new System.Drawing.Point(0, 0);
            this.asidemenu.Name = "asidemenu";
            this.asidemenu.Size = new System.Drawing.Size(837, 628);
            this.asidemenu.TabIndex = 0;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage4);
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl3.Location = new System.Drawing.Point(4, 382);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(826, 243);
            this.tabControl3.TabIndex = 0;
            this.tabControl3.Visible = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(818, 214);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "An Lexico";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBoxError);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(818, 214);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "An Sintactico";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 528);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(837, 100);
            this.panel5.TabIndex = 14;
            // 
            // textBoxError
            // 
            this.textBoxError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxError.Location = new System.Drawing.Point(9, 6);
            this.textBoxError.Multiline = true;
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.Size = new System.Drawing.Size(803, 202);
            this.textBoxError.TabIndex = 0;
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.asidemenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RadForm1";
            this.Text = "CPRIME IDE 1.0";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RadForm1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.asidemenu.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem anLexicograficoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentoPDFToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTxtCode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button redoBtn;
        private System.Windows.Forms.Button undoBtn;
        private System.Windows.Forms.Button pastBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button compileBtn;
        private System.Windows.Forms.Button cutBtn;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button opnFilebtn;
        private System.Windows.Forms.Panel asidemenu;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ToolStripMenuItem anSintacticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxError;
    }
}