using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.App.Server
{
    public partial class GTallySheetScreen : Form
    {
        public GTallySheetScreen()
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

        private GTallySheetManager _tallySheetManager;
        public GTallySheetManager TallySheetManager
        {
            get
            {
                if (_tallySheetManager == null)
                {
                    _tallySheetManager = new GTallySheetManager();
                }

                return _tallySheetManager;
            }
            set { _tallySheetManager = value; }
        }


        public void RefreshTallyScore(string userName, int questionNumber, string answer)
        {
            TallySheetManager.UpdateGTallySheet(userName, questionNumber, answer); //update the tallysheet

            SetupColumns();
            SetupData();
        }



        private List<string> _contenstants;
        private void SetupColumns()
        {
            TallySheetListView.Columns.Clear();

            _contenstants = TallySheetManager.GetContestants();


            var counter = 0;
            var header = new ColumnHeader(counter) { Text = "Tally Sheet" };
            TallySheetListView.Columns.Add(header);



            foreach (var contestant in _contenstants)
            {
                counter++;
                header = new ColumnHeader(counter) { Text = contestant };
                TallySheetListView.Columns.Add(header);
            }

        }

        public void SetupData()
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
                    var answer = TallySheetManager.Context.TallySheets
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


        private void GTallySheetScreen_Load(object sender, EventArgs e)
        {
            SetupColumns();
            SetupData();

            TallySheetListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            TallySheetListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void GTallySheetScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //because there is a chance the user  close the form by clicking the "X" button
            //and closing the form will dispose that object
            //this form is required on Hub so just hide it
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }
    }
}
