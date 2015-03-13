using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Win.App.Server.DataSource;

namespace Win.App.Server
{
    public partial class TallySheetScreen : Form
    {
        public TallySheetScreen()
        {
            InitializeComponent();
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
            set { _questionManager = value; }
        }

        private TallySheetManager _tallySheetManager;
        public TallySheetManager TallySheetManager
        {
            get
            {
                if (_tallySheetManager == null)
                {
                    _tallySheetManager = new TallySheetManager();
                }

                return _tallySheetManager;
            }
            set { _tallySheetManager = value; }
        }


        public void RefreshTallyScore(string userName, int questionNumber, string answer)
        {
            TallySheetManager.UpdateTallySheet(userName, questionNumber, answer); //update the tallysheet

            SetupColumns();
            SetupData();
        }


        
        private List<string> _contenstants;
        private void SetupColumns()
        {
            TallySheetListView.Columns.Clear();
            
            _contenstants = TallySheetManager.GetContestants();
        

            var counter = 0;
            var header = new ColumnHeader(counter) { Text = "Tally Sheet"};
            TallySheetListView.Columns.Add(header);



            foreach (var contestant in _contenstants)
            {
                counter++;
                header = new ColumnHeader(counter) { Text = contestant};
                TallySheetListView.Columns.Add(header);
            }

        }

        public void SetupData()
        {
            using (var ctx = new QuizBeeEntities())
            {
                TallySheetListView.Items.Clear();
                var questionNNumbers = TallySheetManager.GetQuestionNumbers();

                foreach (var questionNumber in questionNNumbers)
                {
                    var questionString = QuestionManager.GetQuestionByQuestionNumber(questionNumber);
                    //set this as the row header
                    var listViewItem = TallySheetListView.Items.Add(questionString);

                    //get the answer by question number and by 
                    foreach (var contenstant in _contenstants)
                    {
                        var answer = ctx.TallySheets
                            .FirstOrDefault(m => m.ContestantName == contenstant && m.QuestionNumber == questionNumber);

                        if (answer == null)
                        {
                            listViewItem.SubItems.Add("NO ANSWER");
                        }
                        else
                        {
                            listViewItem.SubItems.Add(answer.Answer);
                        }

                    }
                }
            }
          

        }

        private void TallySheetScreen_FormClosing(object sender, FormClosingEventArgs e)
        {

            //because there is a chance the user  close the form by clicking the "X" button
            //and closing the form will dispose that object
            //this form is required on Hub so just hide it
            this.Hide();
            e.Cancel = true; // this cancels the close event.

        }

        private void TallySheetScreen_Load(object sender, System.EventArgs e)
        {
            SetupColumns();
            SetupData();

            TallySheetListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            TallySheetListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            TallyPrint frmTallyPrint = new TallyPrint();
            frmTallyPrint.Show();
        }


    }
}
