using System;
using System.Threading.Tasks;
using App.Model;
using Microsoft.AspNet.SignalR;


namespace Win.App.Server
{
    public class GQuizHub : Hub
    {

        public override Task OnConnected()
        {
            var userName = Context.QueryString["user_name"];

            var message = string.Format("Connected user : {0}", userName);
            Program.frmGQuizEasy.WriteToLog(message);
            Program.frmGQuizAverage.WriteToLog(message);
            Program.frmGQuizDifficult.WriteToLog(message);
            Program.frmGQuizClincher.WriteToLog(message);

            Program.frmGQuizEasy.UpdateAndReloadGScore(userName, 0, null, string.Empty);//we might even aler the UI to refresh the score
            Program.frmGQuizAverage.UpdateAndReloadGScore(userName, 0, null, string.Empty);
            Program.frmGQuizDifficult.UpdateAndReloadGScore(userName, 0, null, string.Empty);
            Program.frmGQuizClincher.UpdateAndReloadGScore(userName, 0, null, string.Empty);

            return base.OnConnected();
        }

        public void QuestionAnsweredGQuizEasy(GQuiz quiz, string userName)
        {

            var answer = string.Empty;
            var correctAnswer = string.Empty;
            if (!string.IsNullOrEmpty(quiz.Option1)) answer = quiz.Option1;
            if (!string.IsNullOrEmpty(quiz.Option2)) answer = quiz.Option2;
            if (!string.IsNullOrEmpty(quiz.Option3)) answer = quiz.Option3;
            if (!string.IsNullOrEmpty(quiz.Option4)) answer = quiz.Option4;

            if (!string.IsNullOrEmpty(quiz.AnswerKey)) correctAnswer = quiz.AnswerKey;

            if (answer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                Program.frmGQuizEasy.UpdateAndReloadGScore(userName, 1, quiz.QuestionNumber, answer);//we might even aler the UI to refresh the score
            }
            else
            {
                Program.frmGQuizEasy.UpdateAndReloadGScore(userName, 0, quiz.QuestionNumber, answer);
            }

            //NOTE: i guess there is no need for this log
            var message = string.Format("{0} from {1} correct: {2}", answer, userName, correctAnswer);
            Program.frmGQuizEasy.WriteToLog(message);
        }

        public void QuestionAnsweredGQuizAverage(GQuiz quiz, string userName)
        {

            var answer = string.Empty;
            var correctAnswer = string.Empty;
            if (!string.IsNullOrEmpty(quiz.Option1)) answer = quiz.Option1;
            if (!string.IsNullOrEmpty(quiz.Option2)) answer = quiz.Option2;
            if (!string.IsNullOrEmpty(quiz.Option3)) answer = quiz.Option3;
            if (!string.IsNullOrEmpty(quiz.Option4)) answer = quiz.Option4;

            if (!string.IsNullOrEmpty(quiz.AnswerKey)) correctAnswer = quiz.AnswerKey;

            if (answer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                Program.frmGQuizAverage.UpdateAndReloadGScore(userName, 1, quiz.QuestionNumber, answer);//we might even aler the UI to refresh the score
            }
            else
            {
                Program.frmGQuizAverage.UpdateAndReloadGScore(userName, 0, quiz.QuestionNumber, answer);
            }

            //NOTE: i guess there is no need for this log
            var message = string.Format("{0} from {1} correct: {2}", answer, userName, correctAnswer);
            Program.frmGQuizAverage.WriteToLog(message);
        }

        public void QuestionAnsweredGQuizDifficult(GQuiz quiz, string userName)
        {

            var answer = string.Empty;
            var correctAnswer = string.Empty;
            if (!string.IsNullOrEmpty(quiz.Option1)) answer = quiz.Option1;
            if (!string.IsNullOrEmpty(quiz.Option2)) answer = quiz.Option2;
            if (!string.IsNullOrEmpty(quiz.Option3)) answer = quiz.Option3;
            if (!string.IsNullOrEmpty(quiz.Option4)) answer = quiz.Option4;

            if (!string.IsNullOrEmpty(quiz.AnswerKey)) correctAnswer = quiz.AnswerKey;

            if (answer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                Program.frmGQuizDifficult.UpdateAndReloadGScore(userName, 1, quiz.QuestionNumber, answer);//we might even aler the UI to refresh the score
            }
            else
            {
                Program.frmGQuizDifficult.UpdateAndReloadGScore(userName, 0, quiz.QuestionNumber, answer);
            }

            //NOTE: i guess there is no need for this log
            var message = string.Format("{0} from {1} correct: {2}", answer, userName, correctAnswer);
            Program.frmGQuizDifficult.WriteToLog(message);
        }

        public void QuestionAnsweredGQuizClincher(GQuiz quiz, string userName)
        {

            var answer = string.Empty;
            var correctAnswer = string.Empty;
            if (!string.IsNullOrEmpty(quiz.Option1)) answer = quiz.Option1;
            if (!string.IsNullOrEmpty(quiz.Option2)) answer = quiz.Option2;
            if (!string.IsNullOrEmpty(quiz.Option3)) answer = quiz.Option3;
            if (!string.IsNullOrEmpty(quiz.Option4)) answer = quiz.Option4;

            if (!string.IsNullOrEmpty(quiz.AnswerKey)) correctAnswer = quiz.AnswerKey;

            if (answer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                Program.frmGQuizClincher.UpdateAndReloadGScore(userName, 1, quiz.QuestionNumber, answer);//we might even aler the UI to refresh the score
            }
            else
            {
                Program.frmGQuizClincher.UpdateAndReloadGScore(userName, 0, quiz.QuestionNumber, answer);
            }

            //NOTE: i guess there is no need for this log
            var message = string.Format("{0} from {1} correct: {2}", answer, userName, correctAnswer);
            Program.frmGQuizClincher.WriteToLog(message);
        }



    }
}
