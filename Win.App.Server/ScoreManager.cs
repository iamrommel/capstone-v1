using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using App.Model;
using Win.App.Server.DataSource;

namespace Win.App.Server
{
    public class ScoreManager
    {


       

        /// <summary>
        /// This wil update score of hte contestant on the database,
        /// If it does not exists (use the contestant name to check it's existence), it will create a new entry
        /// </summary>
        /// <param name="contestName">Name of the contest.</param>
        /// <param name="pointsAdded">The points added.</param>
        public void UpdateScore(string contestName, int pointsAdded)
        {
            using (var context = new QuizBeeEntities())
            {

                //look for the user
                var contestantScore = context.ContestantScores.FirstOrDefault(m => m.ContestantName == contestName);


                if (contestantScore == null)
                {
                    //if contestantScore null, then this is not yes in the database
                    //then we should add it.

                    contestantScore = context.ContestantScores.Create(); //create the instance of contestant score
                    contestantScore.ContestantName = contestName; //set the name
                    contestantScore.Score = pointsAdded; //set the score
                }
                else
                {
                    //but if it exists
                    //then just update the score
                    var newScore = contestantScore.Score + pointsAdded;
                        //get first the previous score then add the pointsadded
                    contestantScore.Score = newScore; //set the new score

                }

                context.ContestantScores.AddOrUpdate(contestantScore);
                    //this will add if it does not exist or just update if exists
                context.SaveChanges(); //save the changes on database

            }


        }

        /// <summary>
        /// Gets the current contestants score that is currently stored in database
        /// </summary>
        /// <returns></returns>
        public List<ContestantScore> GetContestantScores()
        {
            using (var context = new QuizBeeEntities())
            {
                return context.ContestantScores.ToList();
            }
        }



        public void UpdateScoreG(string contestName, int pointsAdded)
        {
            using (var context = new QuizBeeEntities())
            {

                //look for the user
                var contestantScore = context.GContestantScores.FirstOrDefault(m => m.ContestantName == contestName);


                if (contestantScore == null)
                {
                    //if contestantScore null, then this is not yes in the database
                    //then we should add it.

                    contestantScore = context.GContestantScores.Create(); //create the instance of contestant score
                    contestantScore.ContestantName = contestName; //set the name
                    contestantScore.Score = pointsAdded; //set the score
                }
                else
                {
                    //but if it exists
                    //then just update the score
                    var newScore = contestantScore.Score + pointsAdded;
                        //get first the previous score then add the pointsadded
                    contestantScore.Score = newScore; //set the new score

                }

                context.GContestantScores.AddOrUpdate(contestantScore);
                    //this will add if it does not exist or just update if exists
                context.SaveChanges(); //save the changes on database

            }

        }


        public List<GContestantScore> GetGContestantScores()
        {
            using (var context = new QuizBeeEntities())
            {
                return context.GContestantScores.ToList();
            }
        }

    }
}
