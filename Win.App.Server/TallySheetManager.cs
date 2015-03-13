using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Win.App.Server.DataSource;

namespace Win.App.Server
{
    public class TallySheetManager
    {



        public void UpdateTallySheet(string contestName, int questionNumber, string answerKey)
        {

            using (var ctx = new QuizBeeEntities())
            {
                //look for the tally sheet by contestant and question number
                var tallySheet = ctx.TallySheets.FirstOrDefault(m => m.ContestantName == contestName && m.QuestionNumber == questionNumber);


                if (tallySheet == null)
                {
                    //if the tallysheet is null, then create a new instance of tallysheet
                    tallySheet = ctx.TallySheets.Create();
                }

                tallySheet.ContestantName = contestName; //set the name
                tallySheet.Answer = answerKey;
                tallySheet.QuestionNumber = questionNumber;


                ctx.TallySheets.AddOrUpdate(tallySheet); //this will add if it does not exist or just update if exists
                ctx.SaveChanges(); //save the changes on database
            }



        }

        public List<string> GetContestants()
        {

            using (var ctx = new QuizBeeEntities())
            {
                //get only the unique contestants from the tallysheet table
                var result = ctx.TallySheets.OrderBy(m => m.ContestantName).Select(m => m.ContestantName).Distinct().ToList();

                return result;

            }
        }

        public List<int> GetQuestionNumbers()
        {
            using (var ctx = new QuizBeeEntities())
            {
                var result =
                    ctx.TallySheets.OrderBy(m => m.QuestionNumber).Select(m => m.QuestionNumber).Distinct().ToList();

                return result;
            }

        }
    }
}