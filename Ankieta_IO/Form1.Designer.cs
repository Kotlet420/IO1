namespace Ankieta_IO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Jacek", "Nowak", "123456789", "email@onet.pl" }, -1);
            ListViewItem listViewItem2 = new ListViewItem("Jan");
            menuStrip1 = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            splitContainer1 = new SplitContainer();
            Firmy = new ListBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            Lista = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(950, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(38, 20);
            plikToolStripMenuItem.Text = "Plik";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(103, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += button1_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(950, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += button1_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 49);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(Firmy);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(950, 514);
            splitContainer1.SplitterDistance = 316;
            splitContainer1.TabIndex = 3;
            // 
            // Firmy
            // 
            Firmy.Dock = DockStyle.Fill;
            Firmy.FormattingEnabled = true;
            Firmy.ItemHeight = 15;
            Firmy.Items.AddRange(new object[] { "Firma 1", "Firma 2", "Firma 3", "Firma 4", "Firma 5" });
            Firmy.Location = new Point(0, 0);
            Firmy.Name = "Firmy";
            Firmy.Size = new Size(316, 514);
            Firmy.TabIndex = 0;
            Firmy.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(630, 514);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(622, 486);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dane Firmy";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(622, 486);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Oprogramowanie";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(622, 486);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Ocena Oprogramowania";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 156);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane Adresowe";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Nazwa";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(103, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 49);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 2;
            label2.Text = "NIP";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(103, 80);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 83);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "Regon";
            label3.Click += label3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(6, 168);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(354, 109);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Adres";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Lista);
            groupBox3.Location = new Point(6, 283);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(563, 138);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Dane Kontaktowe";
            // 
            // Lista
            // 
            Lista.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            Lista.Dock = DockStyle.Left;
            Lista.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            Lista.Location = new Point(3, 19);
            Lista.Name = "Lista";
            Lista.Size = new Size(462, 116);
            Lista.TabIndex = 0;
            Lista.UseCompatibleStateImageBehavior = false;
            Lista.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Imię";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nazwisko";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Telefon";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "e-mail";
            columnHeader4.Width = 120;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 563);
            Controls.Add(splitContainer1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Ankieta oprogramownia";
            Load += Form1_Load;
            Click += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private SplitContainer splitContainer1;
        private ListBox Firmy;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ListView Lista;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}