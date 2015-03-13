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
       

        public void UpdateGTallySheet(string contestName, int questionNumber, string answerKey)
        {
            using (var context = new QuizBeeEntities())
            {
                //look for the tally sheet by contestant and question number
                var tallySheet = context.GTallySheet.FirstOrDefault(m => m.ContestantName == contestName && m.QuestionNumber == questionNumber);


                if (tallySheet == null)
                {
                    //if the tallysheet is null, then create a new instance of tallysheet
                    tallySheet = context.GTallySheet.Create();
                }

                tallySheet.ContestantName = contestName; //set the name
                tallySheet.Answer = answerKey;
                tallySheet.QuestionNumber = questionNumber;

                context.GTallySheet.AddOrUpdate(tallySheet); //this will add if it does not exist or just update if exists
                context.SaveChanges(); //save the changes on database
                
            }

        }

        public List<string> GetContestants()
        {
            using (var context = new QuizBeeEntities())
            {
                //get only the unique contestants from the tallysheet table
                var result =
                    context.GTallySheet.OrderBy(m => m.ContestantName).Select(m => m.ContestantName).Distinct().ToList();

                return result;
            }
        }

        public List<int> GetQuestionNumbers()
        {
            using (var context = new QuizBeeEntities())
            {
                var result =
                    context.GTallySheet.OrderBy(m => m.QuestionNumber).Select(m => m.QuestionNumber).Distinct().ToList();

                return result;
            }

        }
    }
}
