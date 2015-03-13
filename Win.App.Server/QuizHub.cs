using System;
using System.Threading.Tasks;
using App.Model;
using Microsoft.AspNet.SignalR;


namespace Win.App.Server
{
    public class QuizHub : Hub
    {


        public override Task OnConnected()
        {
            var userName = Context.QueryString["user_name"];

            var message = string.Format("Connected user : {0}", userName);
            Program.MainForm.WriteToLog(message);

            Program.MainForm.UpdateAndReloadScore(userName, 0, null, string.Empty);//we might even aler the UI to refresh the score
            Program.frmQuizL2Server.UpdateAndReloadScore(userName, 0, null, string.Empty);
            Program.frmQuizL3Server.UpdateAndReloadScore(userName, 0, null, string.Empty);
            Program.frmQClincherServer.UpdateAndReloadScore(userName, 0, null, string.Empty);

            return base.OnConnected();
        }



        public void QuestionAnswered(QuizL1 quiz, string userName)
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
               Program.MainForm.UpdateAndReloadScore(userName, 1, quiz.QuestionNumber, answer);//we might even aler the UI to refresh the score
            }
            else
            {
                Program.MainForm.UpdateAndReloadScore(userName, 0, quiz.QuestionNumber, answer);//we might even aler the UI to refresh the score
                
            }


            //NOTE: i guess there is no need for this log
            var message = string.Format("{0} from {1} correct: {2}", answer, userName, correctAnswer);
            Program.MainForm.WriteToLog(message);

        }

        public void QuestionAnsweredQL2(QuizL2 quiz, string userName)
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
               Program.frmQuizL2Server.UpdateAndReloadScore(userName, 1, quiz.QuestionNumber, answer);//we might even aler the UI to refresh the score
            }
            else
            {
                Program.frmQuizL2Server.UpdateAndReloadScore(userName, 0, quiz.QuestionNumber, answer);//we might even aler the UI to refresh the score
                
            }

            //NOTE: i guess there is no need for this log
            var message = string.Format("{0} from {1} correct: {2}", answer, userName, correctAnswer);
            Program.frmQuizL2Server.WriteToLog(message);


        }

        public void QuestionAnsweredQL3(QuizL3 quiz, string userName)
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
                Program.frmQuizL3Server.UpdateAndReloadScore(userName, 1, quiz.QuestionNumber, answer);//we might even aler the UI to refresh the score
            }
            else
            {
                Program.frmQuizL3Server.UpdateAndReloadScore(userName, 0, quiz.QuestionNumber, answer);//we might even aler the UI to refresh the score

            }

            //NOTE: i guess there is no need for this log
            var message = string.Format("{0} from {1} correct: {2}", answer, userName, correctAnswer);
            Program.frmQuizL3Server.WriteToLog(message);


        }

        public void QuestionAnsweredQClincher(Clincher quiz, string userName)
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
                Program.frmQClincherServer.UpdateAndReloadScore(userName, 1, quiz.QuestionNumber, answer);//we might even aler the UI to refresh the score
            }
            else
            {
                Program.frmQClincherServer.UpdateAndReloadScore(userName, 0, quiz.QuestionNumber, answer);//we might even aler the UI to refresh the score

            }

            //NOTE: i guess there is no need for this log
            var message = string.Format("{0} from {1} correct: {2}", answer, userName, correctAnswer);
            Program.frmQClincherServer.WriteToLog(message);


        }

        

    }
}