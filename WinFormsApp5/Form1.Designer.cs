namespace WinFormsApp5
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tytul = new System.Windows.Forms.TextBox();
            this.rezyser = new System.Windows.Forms.TextBox();
            this.aktorrr = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Tytuł = new System.Windows.Forms.ColumnHeader();
            this.Reżyser = new System.Windows.Forms.ColumnHeader();
            this.Data = new System.Windows.Forms.ColumnHeader();
            this.Aktor = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usunWybraneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tytuł:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reżyser:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data premiery:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Główny aktor(ka):";
            // 
            // tytul
            // 
            this.tytul.Location = new System.Drawing.Point(101, 29);
            this.tytul.Name = "tytul";
            this.tytul.Size = new System.Drawing.Size(187, 23);
            this.tytul.TabIndex = 4;
            // 
            // rezyser
            // 
            this.rezyser.Location = new System.Drawing.Point(101, 62);
            this.rezyser.Name = "rezyser";
            this.rezyser.Size = new System.Drawing.Size(187, 23);
            this.rezyser.TabIndex = 5;
            // 
            // aktorrr
            // 
            this.aktorrr.Location = new System.Drawing.Point(459, 62);
            this.aktorrr.Name = "aktorrr";
            this.aktorrr.Size = new System.Drawing.Size(200, 23);
            this.aktorrr.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(459, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tytuł,
            this.Reżyser,
            this.Data,
            this.Aktor});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(42, 152);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(627, 220);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Tytuł
            // 
            this.Tytuł.Text = "Tytuł";
            this.Tytuł.Width = 250;
            // 
            // Reżyser
            // 
            this.Reżyser.Text = "Reżyser";
            this.Reżyser.Width = 125;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 125;
            // 
            // Aktor
            // 
            this.Aktor.Text = "Aktor";
            this.Aktor.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usunWybraneToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 48);
            this.contextMenuStrip1.UseWaitCursor = true;
            // 
            // usunWybraneToolStripMenuItem
            // 
            this.usunWybraneToolStripMenuItem.Name = "usunWybraneToolStripMenuItem";
            this.usunWybraneToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.usunWybraneToolStripMenuItem.Text = "Usun wybrane";
            this.usunWybraneToolStripMenuItem.Click += new System.EventHandler(this.usunWybraneToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(443, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Zapisz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(558, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 33);
            this.button3.TabIndex = 11;
            this.button3.Text = "Zamknij";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.aktorrr);
            this.Controls.Add(this.rezyser);
            this.Controls.Add(this.tytul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tytul;
        private TextBox rezyser;
        private TextBox aktorrr;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private ListView listView1;
        private ColumnHeader Tytuł;
        private ColumnHeader Reżyser;
        private ColumnHeader Data;
        private ColumnHeader Aktor;
        private Button button2;
        private Button button3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem usunWybraneToolStripMenuItem;
    }
}