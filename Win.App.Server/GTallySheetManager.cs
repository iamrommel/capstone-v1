using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Win.App.Server.DataSource;
using System.Data.Entity.Migrations;

namespace Win.App.Server
{
    public class GTallySheetManager
    {
        private QuizBeeEntities _context;
        public QuizBeeEntities Context
        {
            get
            {
                if (_context == null)
                {
                    _context = new QuizBeeEntities();
                }

                return _context;
            }
            set { _context = value; }
        }

        public void UpdateGTallySheet(string contestName, int questionNumber, string answerKey)
        {
            //look for the tally sheet by contestant and question number
            var tallySheet = Context.GTallySheet.FirstOrDefault(m => m.ContestantName == contestName && m.QuestionNumber == questionNumber);


            if (tallySheet == null)
            {
                //if the tallysheet is null, then create a new instance of tallysheet
                tallySheet = Context.GTallySheet.Create();
            }

            tallySheet.ContestantName = contestName; //set the name
            tallySheet.Answer = answerKey;
            tallySheet.QuestionNumber = questionNumber;

            Context.GTallySheet.AddOrUpdate(tallySheet); //this will add if it does not exist or just update if exists
            Context.SaveChanges(); //save the changes on database


        }

        public List<string> GetContestants()
        {
            //get only the unique contestants from the tallysheet table
            var result = Context.GTallySheet.OrderBy(m => m.ContestantName).Select(m => m.ContestantName).Distinct().ToList();

            return result;

        }

        public List<int> GetQuestionNumbers()
        {
            var result = Context.GTallySheet.OrderBy(m => m.QuestionNumber).Select(m => m.QuestionNumber).Distinct().ToList();

            return result;

        }
    }
}
