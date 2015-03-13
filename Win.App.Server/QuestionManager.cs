using System;
using System.Collections.Generic;
using System.Linq;
using App.Model;
using Win.App.Server.DataSource;

namespace Win.App.Server
{
    public class QuestionManager
    {

        


        /// <summary>
        /// Gets the quizes by difficulty.
        /// </summary>
        /// <param name="difficultyLevel">The difficulty level.</param>
        /// <returns></returns>
        public List<QuizL1> GetQuizL1ByDifficulty(int difficultyLevel)
        {
            using (var context = new QuizBeeEntities())
            {
                return context.QuizL1.Where(m => m.DifficultyLevel == difficultyLevel).ToList();
                
            }
        }

        public List<QuizL2> GetQuizL2ByDifficulty(int difficultyLevel)
        {
            using (var context = new QuizBeeEntities())
            {
                return context.QuizL2.Where(m => m.DifficultyLevel == difficultyLevel).ToList();
            }
        }

        public List<QuizL3> GetQuizL3ByDifficulty(int difficultyLevel)
        {
            using (var context = new QuizBeeEntities())
            {
                return context.QuizL3.Where(m => m.DifficultyLevel == difficultyLevel).ToList();
            }
        }

        public List<Clincher> GetQClincherByDifficulty(int difficultyLevel)
        {
            using (var context = new QuizBeeEntities())
            {
                return context.Clinchers.Where(m => m.DifficultyLevel == difficultyLevel).ToList();
            }
        }

        public List<GQuiz> GetGQuizByDifficulty(int difficultyLevel)
        {
            using (var context = new QuizBeeEntities())
            {
                return context.GQuizs.Where(m => m.DifficultyLevel == difficultyLevel).ToList();
            }
        }


        public string GetQuestionByQuestionNumber(int questionNumber)
        {
            using (var context = new QuizBeeEntities())
            {
                //look for all table with question number
                //if found just exit immidiately
                var quizL1 = context.QuizL1.FirstOrDefault(m => m.QuestionNumber == questionNumber);
                if (quizL1 != null)
                {
                    return string.Format("{0} - {1}", quizL1.QuestionNumber, quizL1.Questions);
                }


                //continue looking for next level if the question number does not exist from previous table
                var quizL2 = context.QuizL2.FirstOrDefault(m => m.QuestionNumber == questionNumber);
                if (quizL2 != null)
                {
                    return string.Format("{0} - {1}", quizL2.QuestionNumber, quizL2.Questions);
                }

                //continue looking for next level if the question number does not exist from previous table
                var quizL3 = context.QuizL3.FirstOrDefault(m => m.QuestionNumber == questionNumber);
                if (quizL3 != null)
                {
                    return string.Format("{0} - {1}", quizL3.QuestionNumber, quizL3.Questions);
                }

                //continue looking for next level if the question number does not exist from previous table
                var quizClincher = context.Clinchers.FirstOrDefault(m => m.QuestionNumber == questionNumber);
                if (quizClincher != null)
                {
                    return string.Format("{0} - {1}", quizClincher.QuestionNumber, quizClincher.Questions);
                }

                //continue looking for next level if the question number does not exist from previous table
                var quizGeneric = context.GQuizs.FirstOrDefault(m => m.QuestionNumber == questionNumber);
                if (quizGeneric != null)
                {
                    return string.Format("{0} - {1}", quizGeneric.QuestionNumber, quizGeneric.Questions);
                }


                throw new InvalidOperationException("The question number does not exist now!");
            }

        }


    }
}