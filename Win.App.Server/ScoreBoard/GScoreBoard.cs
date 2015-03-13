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
    public partial class GScoreBoard : Form
    {
        public GScoreBoard()
        {
            InitializeComponent();
        }

        private void gContestantScoreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gContestantScoreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quizBeeDataSet);

        }

        private void GScoreBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizBeeDataSet.GContestantScore' table. You can move, or remove it, as needed.
            this.gContestantScoreTableAdapter.Fill(this.quizBeeDataSet.GContestantScore);

        }
    }
}
