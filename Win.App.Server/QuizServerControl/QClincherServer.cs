using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Model;
using Microsoft.AspNet.SignalR;

namespace Win.App.Server.QuizServerControl
{
    public partial class QClincherServer : Form
    {
        public QClincherServer()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void QClincherServer_Load(object sender, EventArgs e)
        {
            SetupQuiz();
        }


        private IHubContext _hubContext;
        public IHubContext HubContext
        {
            get
            {
                if (_hubContext == null)
                {
                    _hubContext = GlobalHost.ConnectionManager.GetHubContext<QuizHub>();
                }

                return _hubContext;
            }
        }

        private QuestionManager _questionManager;
        public QuestionManager QuestionManager
        {
            get
            {
                if (_questionManager == null)
                {
                    _questionManager = new QuestionManager();
                }

                return _questionManager;
            }
        }

        private ScoreManager _scoreManager;
        public ScoreManager ScoreManager
        {
            get
            {
                if (_scoreManager == null)
                {
                    _scoreManager = new ScoreManager();
                }

                return _scoreManager;
            }
            set { _scoreManager = value; }
        }



        public void WriteToLog(string logMessage)
        {
            if (listView1.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                    WriteToLog(logMessage)
                ));
                return;
            }
            listView1.Items.Add(logMessage);
        }

        public void UpdateContestantScore()
        {
            if (listView1.InvokeRequired)
            {
                this.Invoke((Action)(UpdateContestantScore));
                return;
            }

            //always clear the list view
            ContestantListView.Items.Clear();

            foreach (var score in ScoreManager.GetContestantScores())
            {
                var listViewItem = new ListViewItem(score.ContestantName);
                listViewItem.SubItems.Add((score.Score ?? 0).ToString("N0"));

                ContestantListView.Items.Add(listViewItem);

            }

        }

        public void UpdateAndReloadScore(string userName, int pointsAdded, int? questionNumber, string answer)
        {
            ScoreManager.UpdateScore(userName, pointsAdded);
            if (questionNumber != null)
            {
                //refresh the tally sheet
                Program.TallySheetScreen.RefreshTallyScore(userName, questionNumber.Value, answer);
            }
            UpdateContestantScore();
        }

        private void SetupQuiz()
        {
            EasyDataGrid.DataSource = QuestionManager.GetQClincherByDifficulty(1);
            UpdateContestantScore();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tabControl = sender as TabControl;
            if (tabControl == null) return;
            var selectedIndex = tabControl.SelectedIndex + 1;
            switch (selectedIndex)
            {
                case 1:
                    EasyDataGrid.DataSource = QuestionManager.GetQClincherByDifficulty(selectedIndex);
                    break;
                case 2:
                    AverageDataGrid.DataSource = QuestionManager.GetQClincherByDifficulty(selectedIndex);
                    break;
                case 3:
                    //TODO: Bind the other difficulty level grid here
                    DifficultDataGrid.DataSource = QuestionManager.GetQClincherByDifficulty(selectedIndex);
                    break;
            }

        }


        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid == null) return;

            if (grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var quiz = grid.Rows[e.RowIndex].DataBoundItem as Clincher;
                HubContext.Clients.All.DisplayQuestion(quiz);
            }

        }

        private void QClincherServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            //because there is a chance the user  close the form by clicking the "X" button
            //and closing the form will dispose that object
            //this form is required on Hub so just hide it
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }
    }
}
