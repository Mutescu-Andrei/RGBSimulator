namespace Prob3
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
            this.culoare = new System.Windows.Forms.PictureBox();
            this.et_Albastru = new System.Windows.Forms.PictureBox();
            this.et_Verde = new System.Windows.Forms.PictureBox();
            this.et_Rosu = new System.Windows.Forms.PictureBox();
            this.albastru = new System.Windows.Forms.VScrollBar();
            this.verde = new System.Windows.Forms.VScrollBar();
            this.rosu = new System.Windows.Forms.VScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.culoare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.et_Albastru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.et_Verde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.et_Rosu)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // culoare
            // 
            this.culoare.BackColor = System.Drawing.Color.SlateBlue;
            this.culoare.Location = new System.Drawing.Point(565, 69);
            this.culoare.Name = "culoare";
            this.culoare.Size = new System.Drawing.Size(186, 285);
            this.culoare.TabIndex = 0;
            this.culoare.TabStop = false;
            // 
            // et_Albastru
            // 
            this.et_Albastru.BackColor = System.Drawing.Color.Blue;
            this.et_Albastru.Location = new System.Drawing.Point(373, 377);
            this.et_Albastru.Name = "et_Albastru";
            this.et_Albastru.Size = new System.Drawing.Size(50, 20);
            this.et_Albastru.TabIndex = 1;
            this.et_Albastru.TabStop = false;
            // 
            // et_Verde
            // 
            this.et_Verde.BackColor = System.Drawing.Color.Lime;
            this.et_Verde.Location = new System.Drawing.Point(196, 377);
            this.et_Verde.Name = "et_Verde";
            this.et_Verde.Size = new System.Drawing.Size(50, 20);
            this.et_Verde.TabIndex = 2;
            this.et_Verde.TabStop = false;
            // 
            // et_Rosu
            // 
            this.et_Rosu.BackColor = System.Drawing.Color.Red;
            this.et_Rosu.Location = new System.Drawing.Point(46, 377);
            this.et_Rosu.Name = "et_Rosu";
            this.et_Rosu.Size = new System.Drawing.Size(50, 20);
            this.et_Rosu.TabIndex = 3;
            this.et_Rosu.TabStop = false;
            // 
            // albastru
            // 
            this.albastru.Location = new System.Drawing.Point(373, 90);
            this.albastru.Maximum = 255;
            this.albastru.Name = "albastru";
            this.albastru.Size = new System.Drawing.Size(40, 250);
            this.albastru.TabIndex = 4;
            this.albastru.Scroll += new System.Windows.Forms.ScrollEventHandler(this.albastru_Scroll);
            // 
            // verde
            // 
            this.verde.Location = new System.Drawing.Point(196, 90);
            this.verde.Maximum = 255;
            this.verde.Name = "verde";
            this.verde.Size = new System.Drawing.Size(40, 250);
            this.verde.TabIndex = 5;
            this.verde.Scroll += new System.Windows.Forms.ScrollEventHandler(this.verde_Scroll);
            // 
            // rosu
            // 
            this.rosu.Location = new System.Drawing.Point(46, 90);
            this.rosu.Maximum = 255;
            this.rosu.Name = "rosu";
            this.rosu.Size = new System.Drawing.Size(40, 250);
            this.rosu.TabIndex = 6;
            this.rosu.Scroll += new System.Windows.Forms.ScrollEventHandler(this.rosu_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iesireToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rosu);
            this.Controls.Add(this.verde);
            this.Controls.Add(this.albastru);
            this.Controls.Add(this.et_Rosu);
            this.Controls.Add(this.et_Verde);
            this.Controls.Add(this.et_Albastru);
            this.Controls.Add(this.culoare);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.culoare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.et_Albastru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.et_Verde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.et_Rosu)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox culoare;
        private System.Windows.Forms.PictureBox et_Albastru;
        private System.Windows.Forms.PictureBox et_Verde;
        private System.Windows.Forms.PictureBox et_Rosu;
        private System.Windows.Forms.VScrollBar albastru;
        private System.Windows.Forms.VScrollBar verde;
        private System.Windows.Forms.VScrollBar rosu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
    }
}

