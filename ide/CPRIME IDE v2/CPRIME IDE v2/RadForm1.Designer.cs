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
            this.asidemenu = new System.Windows.Forms.Panel();
            this.archPanel = new System.Windows.Forms.Panel();
            this.nuevoBtn = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnOpenArch = new System.Windows.Forms.Button();
            this.compPanel = new System.Windows.Forms.Panel();
            this.regCompButton = new System.Windows.Forms.Button();
            this.compilarBtn = new System.Windows.Forms.Button();
            this.compBtn = new System.Windows.Forms.Button();
            this.btnEtapas = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnArch = new System.Windows.Forms.Button();
            this.navbar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.closeLabel = new System.Windows.Forms.Label();
            this.richTxtCode = new System.Windows.Forms.RichTextBox();
            this.asidemenu.SuspendLayout();
            this.archPanel.SuspendLayout();
            this.compPanel.SuspendLayout();
            this.navbar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // asidemenu
            // 
            this.asidemenu.BackColor = System.Drawing.Color.DarkSlateGray;
            this.asidemenu.Controls.Add(this.archPanel);
            this.asidemenu.Controls.Add(this.compPanel);
            this.asidemenu.Controls.Add(this.compBtn);
            this.asidemenu.Controls.Add(this.btnEtapas);
            this.asidemenu.Controls.Add(this.btnEdit);
            this.asidemenu.Controls.Add(this.btnArch);
            this.asidemenu.Controls.Add(this.navbar);
            this.asidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.asidemenu.Font = new System.Drawing.Font("Microsoft MHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asidemenu.Location = new System.Drawing.Point(0, 0);
            this.asidemenu.Name = "asidemenu";
            this.asidemenu.Size = new System.Drawing.Size(169, 453);
            this.asidemenu.TabIndex = 0;
            this.asidemenu.Paint += new System.Windows.Forms.PaintEventHandler(this.asidemenu_Paint);
            // 
            // archPanel
            // 
            this.archPanel.Controls.Add(this.nuevoBtn);
            this.archPanel.Controls.Add(this.btnReg);
            this.archPanel.Controls.Add(this.btnOpenArch);
            this.archPanel.Font = new System.Drawing.Font("Microsoft MHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archPanel.Location = new System.Drawing.Point(0, 77);
            this.archPanel.Name = "archPanel";
            this.archPanel.Size = new System.Drawing.Size(169, 213);
            this.archPanel.TabIndex = 7;
            this.archPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // nuevoBtn
            // 
            this.nuevoBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.nuevoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nuevoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevoBtn.Font = new System.Drawing.Font("Microsoft MHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevoBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nuevoBtn.Location = new System.Drawing.Point(-1, 48);
            this.nuevoBtn.Name = "nuevoBtn";
            this.nuevoBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nuevoBtn.Size = new System.Drawing.Size(169, 48);
            this.nuevoBtn.TabIndex = 6;
            this.nuevoBtn.Text = "        ->Nuevo archivo";
            this.nuevoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevoBtn.UseVisualStyleBackColor = false;
            this.nuevoBtn.MouseLeave += new System.EventHandler(this.btnArch_MouseLeave);
            this.nuevoBtn.MouseHover += new System.EventHandler(this.btn_mousedown);
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Microsoft MHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReg.Location = new System.Drawing.Point(-1, 96);
            this.btnReg.Name = "btnReg";
            this.btnReg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReg.Size = new System.Drawing.Size(169, 48);
            this.btnReg.TabIndex = 5;
            this.btnReg.Text = "        <-Regresar";
            this.btnReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            this.btnReg.MouseLeave += new System.EventHandler(this.btnArch_MouseLeave);
            this.btnReg.MouseHover += new System.EventHandler(this.btn_mousedown);
            // 
            // btnOpenArch
            // 
            this.btnOpenArch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnOpenArch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenArch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenArch.Font = new System.Drawing.Font("Microsoft MHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenArch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenArch.Location = new System.Drawing.Point(0, 0);
            this.btnOpenArch.Name = "btnOpenArch";
            this.btnOpenArch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOpenArch.Size = new System.Drawing.Size(169, 48);
            this.btnOpenArch.TabIndex = 4;
            this.btnOpenArch.Text = "        ->Abrir Archivo";
            this.btnOpenArch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenArch.UseVisualStyleBackColor = false;
            this.btnOpenArch.Click += new System.EventHandler(this.button1_Click_1);
            this.btnOpenArch.MouseLeave += new System.EventHandler(this.btnArch_MouseLeave);
            this.btnOpenArch.MouseHover += new System.EventHandler(this.btn_mousedown);
            // 
            // compPanel
            // 
            this.compPanel.Controls.Add(this.regCompButton);
            this.compPanel.Controls.Add(this.compilarBtn);
            this.compPanel.Location = new System.Drawing.Point(0, 173);
            this.compPanel.Name = "compPanel";
            this.compPanel.Size = new System.Drawing.Size(169, 146);
            this.compPanel.TabIndex = 8;
            // 
            // regCompButton
            // 
            this.regCompButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.regCompButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regCompButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regCompButton.Font = new System.Drawing.Font("Microsoft MHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regCompButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.regCompButton.Location = new System.Drawing.Point(0, 48);
            this.regCompButton.Name = "regCompButton";
            this.regCompButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.regCompButton.Size = new System.Drawing.Size(169, 48);
            this.regCompButton.TabIndex = 5;
            this.regCompButton.Text = "        <-Regresar";
            this.regCompButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regCompButton.UseVisualStyleBackColor = false;
            this.regCompButton.Click += new System.EventHandler(this.regCompButton_Click);
            this.regCompButton.MouseLeave += new System.EventHandler(this.btnArch_MouseLeave);
            this.regCompButton.MouseHover += new System.EventHandler(this.btn_mousedown);
            // 
            // compilarBtn
            // 
            this.compilarBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.compilarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compilarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compilarBtn.Font = new System.Drawing.Font("Microsoft MHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compilarBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.compilarBtn.Location = new System.Drawing.Point(0, 0);
            this.compilarBtn.Name = "compilarBtn";
            this.compilarBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.compilarBtn.Size = new System.Drawing.Size(169, 48);
            this.compilarBtn.TabIndex = 4;
            this.compilarBtn.Text = "        ->Analizar";
            this.compilarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.compilarBtn.UseVisualStyleBackColor = false;
            this.compilarBtn.Click += new System.EventHandler(this.compilarBtn_Click);
            this.compilarBtn.MouseLeave += new System.EventHandler(this.btnArch_MouseLeave);
            this.compilarBtn.MouseHover += new System.EventHandler(this.btn_mousedown);
            // 
            // compBtn
            // 
            this.compBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.compBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.compBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compBtn.Font = new System.Drawing.Font("Microsoft MHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.compBtn.Location = new System.Drawing.Point(0, 125);
            this.compBtn.Name = "compBtn";
            this.compBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.compBtn.Size = new System.Drawing.Size(169, 48);
            this.compBtn.TabIndex = 8;
            this.compBtn.Text = "      An. Lexicografico";
            this.compBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.compBtn.UseVisualStyleBackColor = false;
            this.compBtn.Click += new System.EventHandler(this.compBtn_Click);
            this.compBtn.MouseLeave += new System.EventHandler(this.btnArch_MouseLeave);
            this.compBtn.MouseHover += new System.EventHandler(this.btn_mousedown);
            // 
            // btnEtapas
            // 
            this.btnEtapas.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEtapas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEtapas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtapas.Font = new System.Drawing.Font("Microsoft MHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtapas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEtapas.Location = new System.Drawing.Point(1, 173);
            this.btnEtapas.Name = "btnEtapas";
            this.btnEtapas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEtapas.Size = new System.Drawing.Size(169, 48);
            this.btnEtapas.TabIndex = 6;
            this.btnEtapas.Text = "      Etapas";
            this.btnEtapas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEtapas.UseVisualStyleBackColor = false;
            this.btnEtapas.Click += new System.EventHandler(this.btnEtapas_Click);
            this.btnEtapas.MouseLeave += new System.EventHandler(this.btnArch_MouseLeave);
            this.btnEtapas.MouseHover += new System.EventHandler(this.btn_mousedown);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft MHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Location = new System.Drawing.Point(0, 77);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEdit.Size = new System.Drawing.Size(169, 48);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "      Editar";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnArch_MouseLeave);
            this.btnEdit.MouseHover += new System.EventHandler(this.btn_mousedown);
            // 
            // btnArch
            // 
            this.btnArch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnArch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArch.Font = new System.Drawing.Font("Microsoft MHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnArch.Location = new System.Drawing.Point(0, 29);
            this.btnArch.Name = "btnArch";
            this.btnArch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnArch.Size = new System.Drawing.Size(169, 48);
            this.btnArch.TabIndex = 3;
            this.btnArch.Text = "      Archivo";
            this.btnArch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArch.UseVisualStyleBackColor = false;
            this.btnArch.Click += new System.EventHandler(this.button1_Click);
            this.btnArch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnArch_MouseDown_1);
            this.btnArch.MouseLeave += new System.EventHandler(this.btnArch_MouseLeave);
            this.btnArch.MouseHover += new System.EventHandler(this.btn_mousedown);
            this.btnArch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnArch_MouseUp);
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.DarkOrange;
            this.navbar.Controls.Add(this.label1);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(169, 29);
            this.navbar.TabIndex = 2;
            this.navbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft MHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPRIME IDE v1.0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.aboutLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.closeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(169, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 29);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::CPRIME_IDE_v2.Properties.Resources.application_go_run_512;
            this.pictureBox4.Location = new System.Drawing.Point(241, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::CPRIME_IDE_v2.Properties.Resources.saveF;
            this.pictureBox3.Location = new System.Drawing.Point(206, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(21, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::CPRIME_IDE_v2.Properties.Resources.paste__1_;
            this.pictureBox2.Location = new System.Drawing.Point(170, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::CPRIME_IDE_v2.Properties.Resources.copyfile;
            this.pictureBox1.Location = new System.Drawing.Point(131, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Run";
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.ForeColor = System.Drawing.Color.Black;
            this.aboutLabel.Location = new System.Drawing.Point(583, 4);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(15, 16);
            this.aboutLabel.TabIndex = 6;
            this.aboutLabel.Text = "?";
            this.aboutLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft MHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Code Editor";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.ForeColor = System.Drawing.Color.Black;
            this.closeLabel.Location = new System.Drawing.Point(611, 4);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(16, 16);
            this.closeLabel.TabIndex = 4;
            this.closeLabel.Text = "X";
            this.closeLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // richTxtCode
            // 
            this.richTxtCode.Location = new System.Drawing.Point(175, 35);
            this.richTxtCode.Name = "richTxtCode";
            this.richTxtCode.Size = new System.Drawing.Size(620, 406);
            this.richTxtCode.TabIndex = 4;
            this.richTxtCode.Text = "";
            this.richTxtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTxtCode_KeyDown);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 453);
            this.Controls.Add(this.richTxtCode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.asidemenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RadForm1";
            this.Text = "CPRIME IDE 1.0";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RadForm1_KeyDown);
            this.asidemenu.ResumeLayout(false);
            this.archPanel.ResumeLayout(false);
            this.compPanel.ResumeLayout(false);
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel asidemenu;
        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnEtapas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Panel archPanel;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnOpenArch;
        private System.Windows.Forms.Panel compPanel;
        private System.Windows.Forms.Button regCompButton;
        private System.Windows.Forms.Button compilarBtn;
        private System.Windows.Forms.Button compBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button nuevoBtn;
        private System.Windows.Forms.RichTextBox richTxtCode;
    }
}