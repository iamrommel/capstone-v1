namespace Win.App.Client
{
    partial class QuizSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizSelection));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLPU = new System.Windows.Forms.Button();
            this.btnJPIA = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExit.Location = new System.Drawing.Point(1245, 621);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 43;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLPU
            // 
            this.btnLPU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLPU.BackgroundImage")));
            this.btnLPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLPU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLPU.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLPU.Location = new System.Drawing.Point(680, 121);
            this.btnLPU.Name = "btnLPU";
            this.btnLPU.Size = new System.Drawing.Size(434, 488);
            this.btnLPU.TabIndex = 42;
            this.btnLPU.UseVisualStyleBackColor = true;
            this.btnLPU.Click += new System.EventHandler(this.btnLPU_Click);
            // 
            // btnJPIA
            // 
            this.btnJPIA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJPIA.BackgroundImage")));
            this.btnJPIA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJPIA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJPIA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnJPIA.Location = new System.Drawing.Point(214, 121);
            this.btnJPIA.Name = "btnJPIA";
            this.btnJPIA.Size = new System.Drawing.Size(450, 488);
            this.btnJPIA.TabIndex = 41;
            this.btnJPIA.UseVisualStyleBackColor = true;
            this.btnJPIA.Click += new System.EventHandler(this.btnJPIA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(340, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(688, 81);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // QuizSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 683);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLPU);
            this.Controls.Add(this.btnJPIA);
            this.Name = "QuizSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Selection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLPU;
        private System.Windows.Forms.Button btnJPIA;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}