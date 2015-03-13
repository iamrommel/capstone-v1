namespace Win.App.Server
{
    partial class TallyPrint
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QuizBeeDataSet = new Win.App.Server.QuizBeeDataSet();
            this.TallySheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TallySheetTableAdapter = new Win.App.Server.QuizBeeDataSetTableAdapters.TallySheetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QuizBeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TallySheetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TallySheetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Win.App.Server.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1305, 489);
            this.reportViewer1.TabIndex = 0;
            // 
            // QuizBeeDataSet
            // 
            this.QuizBeeDataSet.DataSetName = "QuizBeeDataSet";
            this.QuizBeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TallySheetBindingSource
            // 
            this.TallySheetBindingSource.DataMember = "TallySheet";
            this.TallySheetBindingSource.DataSource = this.QuizBeeDataSet;
            // 
            // TallySheetTableAdapter
            // 
            this.TallySheetTableAdapter.ClearBeforeFill = true;
            // 
            // TallyPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 489);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TallyPrint";
            this.Text = "Tally Printing";
            this.Load += new System.EventHandler(this.TallyPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuizBeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TallySheetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TallySheetBindingSource;
        private QuizBeeDataSet QuizBeeDataSet;
        private QuizBeeDataSetTableAdapters.TallySheetTableAdapter TallySheetTableAdapter;
    }
}