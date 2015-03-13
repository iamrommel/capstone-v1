using System;
using System.Collections.Generic;
using System.Linq;
using App.Model;
using Win.App.Server.DataSource;

namespace Win.App.Server
{
    public class QuestionManager
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
            
        }


        /// <summary>
        /// Gets the quizes by difficulty.
        /// </summary>
        /// <param name="difficultyLevel">The difficulty level.</param>
        /// <returns></returns>
        public List<QuizL1> GetQuizL1ByDifficulty(int difficultyLevel)
        {
            return Context.QuizL1.Where(m => m.DifficultyLevel == difficultyLevel).ToList();
        }

        public List<QuizL2> GetQuizL2ByDifficulty(int difficultyLevel)
        {
            return Context.QuizL2.Where(m => m.DifficultyLevel == difficultyLevel).ToList();
        }

        public List<QuizL3> GetQuizL3ByDifficulty(int difficultyLevel)
        {
            return Context.QuizL3.Where(m => m.DifficultyLevel == difficultyLevel).ToList();
        }

        public List<Clincher> GetQClincherByDifficulty(int difficultyLevel)
        {
            return Context.Clinchers.Where(m => m.DifficultyLevel == difficultyLevel).ToList();
        }

        public List<GQuiz> GetGQuizByDifficulty(int difficultyLevel)
        {
            return Context.GQuizs.Where(m => m.DifficultyLevel == difficultyLevel).ToList();
        }


        public string GetQuestionByQuestionNumber(int questionNumber)
        {
            //look for all table with question number
            //if found just exit immidiately
            var quizL1 = Context.QuizL1.FirstOrDefault(m => m.QuestionNumber == questionNumber);
            if (quizL1 != null)
            {
                return string.Format("{0} - {1}", quizL1.QuestionNumber, quizL1.Questions);
            }


            //continue looking for next level if the question number does not exist from previous table
            var quizL2 = Context.QuizL2.FirstOrDefault(m => m.QuestionNumber == questionNumber);
            if (quizL2 != null)
            {
                return string.Format("{0} - {1}", quizL2.QuestionNumber, quizL2.Questions);
            }

            //continue looking for next level if the question number does not exist from previous table
            var quizL3 = Context.QuizL3.FirstOrDefault(m => m.QuestionNumber == questionNumber);
            if (quizL3 != null)
            {
                return string.Format("{0} - {1}", quizL3.QuestionNumber, quizL3.Questions);
            }

            //continue looking for next level if the question number does not exist from previous table
            var quizClincher = Context.Clinchers.FirstOrDefault(m => m.QuestionNumber == questionNumber);
            if (quizClincher != null)
            {
                return string.Format("{0} - {1}", quizClincher.QuestionNumber, quizClincher.Questions);
            }

            //continue looking for next level if the question number does not exist from previous table
            var quizGeneric = Context.GQuizs.FirstOrDefault(m => m.QuestionNumber == questionNumber);
            if (quizGeneric != null)
            {
                return string.Format("{0} - {1}", quizGeneric.QuestionNumber, quizGeneric.Questions);
            }


            throw new InvalidOperationException("The question number does not exist now!");

        }


    }
}