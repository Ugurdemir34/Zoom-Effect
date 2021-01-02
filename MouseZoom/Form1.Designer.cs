namespace MouseZoom
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resimSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sağDöndürToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solDöndürToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efektlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1443, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1473, 747);
            this.panel1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resimSeçToolStripMenuItem,
            this.ayarToolStripMenuItem,
            this.efektlerToolStripMenuItem,
            this.temizleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1473, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resimSeçToolStripMenuItem
            // 
            this.resimSeçToolStripMenuItem.Name = "resimSeçToolStripMenuItem";
            this.resimSeçToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.resimSeçToolStripMenuItem.Text = "Resim Seç";
            this.resimSeçToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // ayarToolStripMenuItem
            // 
            this.ayarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sağDöndürToolStripMenuItem,
            this.solDöndürToolStripMenuItem});
            this.ayarToolStripMenuItem.Name = "ayarToolStripMenuItem";
            this.ayarToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.ayarToolStripMenuItem.Text = "Ayar";
            // 
            // sağDöndürToolStripMenuItem
            // 
            this.sağDöndürToolStripMenuItem.Name = "sağDöndürToolStripMenuItem";
            this.sağDöndürToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sağDöndürToolStripMenuItem.Text = "Sağ Döndür";
            this.sağDöndürToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // solDöndürToolStripMenuItem
            // 
            this.solDöndürToolStripMenuItem.Name = "solDöndürToolStripMenuItem";
            this.solDöndürToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.solDöndürToolStripMenuItem.Text = "Sol Döndür";
            this.solDöndürToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // efektlerToolStripMenuItem
            // 
            this.efektlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem});
            this.efektlerToolStripMenuItem.Name = "efektlerToolStripMenuItem";
            this.efektlerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.efektlerToolStripMenuItem.Text = "Efektler";
            this.efektlerToolStripMenuItem.Click += new System.EventHandler(this.efektlerToolStripMenuItem_Click);
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.temizleToolStripMenuItem.Text = "Temizle";
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 771);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resimSeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sağDöndürToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solDöndürToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem efektlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
    }
}

