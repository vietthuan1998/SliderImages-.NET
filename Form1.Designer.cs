namespace SlideShow
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
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.anh5 = new System.Windows.Forms.PictureBox();
            this.anh2 = new System.Windows.Forms.PictureBox();
            this.anh1 = new System.Windows.Forms.PictureBox();
            this.anh4 = new System.Windows.Forms.PictureBox();
            this.anh3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anh5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anh2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anh4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anh3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrev.Location = new System.Drawing.Point(12, 376);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(495, 376);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(558, 358);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // anh5
            // 
            this.anh5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.anh5.Location = new System.Drawing.Point(185, 377);
            this.anh5.Name = "anh5";
            this.anh5.Size = new System.Drawing.Size(40, 30);
            this.anh5.TabIndex = 4;
            this.anh5.TabStop = false;
            // 
            // anh2
            // 
            this.anh2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.anh2.Location = new System.Drawing.Point(320, 377);
            this.anh2.Name = "anh2";
            this.anh2.Size = new System.Drawing.Size(40, 30);
            this.anh2.TabIndex = 5;
            this.anh2.TabStop = false;
            this.anh2.Click += new System.EventHandler(this.Anh2_Click);
            // 
            // anh1
            // 
            this.anh1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.anh1.Location = new System.Drawing.Point(275, 377);
            this.anh1.Name = "anh1";
            this.anh1.Size = new System.Drawing.Size(40, 30);
            this.anh1.TabIndex = 6;
            this.anh1.TabStop = false;
            // 
            // anh4
            // 
            this.anh4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.anh4.Location = new System.Drawing.Point(230, 377);
            this.anh4.Name = "anh4";
            this.anh4.Size = new System.Drawing.Size(40, 30);
            this.anh4.TabIndex = 7;
            this.anh4.TabStop = false;
            this.anh4.Click += new System.EventHandler(this.Anh4_Click);
            // 
            // anh3
            // 
            this.anh3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.anh3.Location = new System.Drawing.Point(365, 377);
            this.anh3.Name = "anh3";
            this.anh3.Size = new System.Drawing.Size(40, 30);
            this.anh3.TabIndex = 8;
            this.anh3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.anh3);
            this.Controls.Add(this.anh4);
            this.Controls.Add(this.anh1);
            this.Controls.Add(this.anh2);
            this.Controls.Add(this.anh5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anh5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anh2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anh4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anh3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox anh5;
        private System.Windows.Forms.PictureBox anh2;
        private System.Windows.Forms.PictureBox anh1;
        private System.Windows.Forms.PictureBox anh4;
        private System.Windows.Forms.PictureBox anh3;
    }
}

