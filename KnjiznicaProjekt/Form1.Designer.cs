namespace KnjiznicaProjekt
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oSTALOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.najpopularnijeKnjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nevraćeneKnjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posuđeneKnjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popularBooksRichTextBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::KnjiznicaProjekt.Properties.Resources.sutterlin_g7ce574d83_1280;
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.popularBooksRichTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(778, 474);
            this.splitContainer1.SplitterDistance = 389;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 59);
            this.label2.TabIndex = 5;
            this.label2.Text = "„Ne vjeruj nikome tko nije ponio knjigu sa sobom.” – Lemony Snicket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Knjižnica";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(117, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 63);
            this.button3.TabIndex = 2;
            this.button3.Text = "Transakcije";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(117, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "Korisnici";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(117, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Knjige";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tan;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oSTALOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(389, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oSTALOToolStripMenuItem
            // 
            this.oSTALOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.najpopularnijeKnjigeToolStripMenuItem,
            this.nevraćeneKnjigeToolStripMenuItem,
            this.posuđeneKnjigeToolStripMenuItem});
            this.oSTALOToolStripMenuItem.Name = "oSTALOToolStripMenuItem";
            this.oSTALOToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.oSTALOToolStripMenuItem.Text = "OSTALO";
            // 
            // najpopularnijeKnjigeToolStripMenuItem
            // 
            this.najpopularnijeKnjigeToolStripMenuItem.BackColor = System.Drawing.Color.Tan;
            this.najpopularnijeKnjigeToolStripMenuItem.Name = "najpopularnijeKnjigeToolStripMenuItem";
            this.najpopularnijeKnjigeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.najpopularnijeKnjigeToolStripMenuItem.Text = "Najpopularnije knjige";
            this.najpopularnijeKnjigeToolStripMenuItem.Click += new System.EventHandler(this.najpopularnijeKnjigeToolStripMenuItem_Click);
            // 
            // nevraćeneKnjigeToolStripMenuItem
            // 
            this.nevraćeneKnjigeToolStripMenuItem.BackColor = System.Drawing.Color.Tan;
            this.nevraćeneKnjigeToolStripMenuItem.Name = "nevraćeneKnjigeToolStripMenuItem";
            this.nevraćeneKnjigeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.nevraćeneKnjigeToolStripMenuItem.Text = "Nevraćene knjige";
            this.nevraćeneKnjigeToolStripMenuItem.Click += new System.EventHandler(this.nevraćeneKnjigeToolStripMenuItem_Click);
            // 
            // posuđeneKnjigeToolStripMenuItem
            // 
            this.posuđeneKnjigeToolStripMenuItem.BackColor = System.Drawing.Color.Tan;
            this.posuđeneKnjigeToolStripMenuItem.Name = "posuđeneKnjigeToolStripMenuItem";
            this.posuđeneKnjigeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.posuđeneKnjigeToolStripMenuItem.Text = "Posuđene knjige";
            this.posuđeneKnjigeToolStripMenuItem.Click += new System.EventHandler(this.posuđeneKnjigeToolStripMenuItem_Click);
            // 
            // popularBooksRichTextBox
            // 
            this.popularBooksRichTextBox.BackColor = System.Drawing.Color.AntiqueWhite;
            this.popularBooksRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.popularBooksRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popularBooksRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.popularBooksRichTextBox.MaximumSize = new System.Drawing.Size(385, 474);
            this.popularBooksRichTextBox.MinimumSize = new System.Drawing.Size(385, 474);
            this.popularBooksRichTextBox.Name = "popularBooksRichTextBox";
            this.popularBooksRichTextBox.ReadOnly = true;
            this.popularBooksRichTextBox.Size = new System.Drawing.Size(385, 474);
            this.popularBooksRichTextBox.TabIndex = 0;
            this.popularBooksRichTextBox.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 474);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(794, 513);
            this.MinimumSize = new System.Drawing.Size(794, 513);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naslovna";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox popularBooksRichTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oSTALOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem najpopularnijeKnjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nevraćeneKnjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posuđeneKnjigeToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

