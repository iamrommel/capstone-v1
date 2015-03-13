namespace Win.App.Server
{
    partial class GTallySheetScreen
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
            this.TallySheetListView = new System.Windows.Forms.ListView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TallySheetListView
            // 
            this.TallySheetListView.AllowColumnReorder = true;
            this.TallySheetListView.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TallySheetListView.FullRowSelect = true;
            this.TallySheetListView.GridLines = true;
            this.TallySheetListView.Location = new System.Drawing.Point(0, 0);
            this.TallySheetListView.Name = "TallySheetListView";
            this.TallySheetListView.Size = new System.Drawing.Size(1001, 470);
            this.TallySheetListView.TabIndex = 10;
            this.TallySheetListView.UseCompatibleStateImageBehavior = false;
            this.TallySheetListView.View = System.Windows.Forms.View.Details;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Firebrick;
            this.btnPrint.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Gold;
            this.btnPrint.Location = new System.Drawing.Point(337, 476);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(333, 39);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "PRINT THIS FORM";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // GTallySheetScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 527);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.TallySheetListView);
            this.Name = "GTallySheetScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tally Sheet Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GTallySheetScreen_FormClosing);
            this.Load += new System.EventHandler(this.GTallySheetScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView TallySheetListView;
        private System.Windows.Forms.Button btnPrint;
    }
}