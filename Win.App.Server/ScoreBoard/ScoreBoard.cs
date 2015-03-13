using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.App.Server.ScoreBoard
{
    public partial class ScoreBoard : Form
    {
        public ScoreBoard()
        {
            InitializeComponent();
        }

        private void contestantScoreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contestantScoreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quizBeeDataSet);

        }

        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizBeeDataSet.ContestantScore' table. You can move, or remove it, as needed.
            this.contestantScoreTableAdapter.Fill(this.quizBeeDataSet.ContestantScore);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap print = new Bitmap(this.contestantScoreDataGridView.Width, this.contestantScoreDataGridView.Height);
            contestantScoreDataGridView.DrawToBitmap(print, new Rectangle(0, 0, this.contestantScoreDataGridView.Width, this.contestantScoreDataGridView.Height));
            e.Graphics.DrawImage(print, 0, 0);

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
