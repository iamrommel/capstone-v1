﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using App.Model;
using Microsoft.AspNet.SignalR.Client;

namespace Win.App.Client
{
    public partial class GForm : Form
    {

        public IHubProxy QuizHubProxy;

        public async Task StartConnection()
        {

            var ipAddress = ConfigurationManager.AppSettings["ServerIpAddress"];
            var portNumber = ConfigurationManager.AppSettings["ServerPort"];
            var querystringData = new Dictionary<string, string> { { "user_name", UserName } };

            var url = string.Format("http://{0}:{1}", ipAddress, portNumber);

            var hubConnection = new HubConnection(url, querystringData);
            QuizHubProxy = hubConnection.CreateHubProxy("GQuizHub");

            await hubConnection.Start();


        }


        int _timeFrame;

        private string _userName;
        public string UserName
        {
            get
            {
                if (string.IsNullOrEmpty(_userName))
                {
                    _userName = ConfigurationManager.AppSettings["UserName"];
                }

                return _userName;
            }
            set { _userName = value; }

        }

        public GForm()
        {
            InitializeComponent();
        }

        private void GForm_Load(object sender, EventArgs e)
        {
            GetUserName();
            QuizHubProxy.On<GQuiz>("DisplayQuestionG", (quiz) => this.Invoke((Action)(() => DisplayQuestionG(quiz))));
            lblUserName.Text = UserName;
            CorrectLabel.Visible = false;
        }

        private void GetUserName()
        {
            var form = new GRegistration();
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                UserName = form.ContestantNameTextBox.Text;
                StartConnection();
            }

        }

        private GQuiz _currentQuiz;
        public void DisplayQuestionG(GQuiz obj)
        {
            _currentQuiz = obj;
            QuestionLabel.Text = obj.Questions;
            radioButton1.Text = obj.Option1;
            radioButton2.Text = obj.Option2;
            radioButton3.Text = obj.Option3;
            radioButton4.Text = obj.Option4;
            _timeFrame = obj.TimeFrame;
            CorrectLabel.Text = obj.AnswerKey;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            label1.Text = "Answer";

            groupBox1.Enabled = true;
            button1.Enabled = true;
            //On the display of question set the timer on
            SetTimer(true);
        }

        #region Setup Timer

        private int _timeleft;

        private Timer _questionTimer;
        public Timer QuestionTimer
        {
            get
            {
                if (_questionTimer == null)
                {
                    var container = this.Container;
                    if (container != null)
                        _questionTimer = new Timer(container);
                    else
                        _questionTimer = new Timer();

                }
                return _questionTimer;
            }
            set { _questionTimer = value; }
        }

        private void SetTimer(bool isTimerOn)
        {
            QuestionTimer.Interval = 1000;
            QuestionTimer.Tick -= Timer1OnTick;
            QuestionTimer.Tick += Timer1OnTick;

            if (isTimerOn)
            {
                QuestionTimer.Enabled = true;
                QuestionTimer.Start();
                //set the time left as default value
                _timeleft = Convert.ToInt32(_timeFrame);
            }
            else
            {
                QuestionTimer.Enabled = false;
                QuestionTimer.Stop();
            }

        }

        private void Timer1OnTick(object sender, EventArgs eventArgs)
        {
            //because the time can happen so fast, 
            //some hardware that are slow cannot determine if this already happen
            //so we made and ultimate catch that if is less than or equal to zero let the time stop
            //if we catch it only to zero, it will happen once, where as of we use less than it "might" happen several times
            if (_timeleft <= 0)
            {

                QuestionTimer.Stop();
                _timeleft = 0;
                TimerLabel.Text = string.Format("Time Left: {0}", _timeleft);
                //TODO: if the timer stops then do something on the questions
                label1.Text = CorrectLabel.Text;
            }
            else
            {
                TimerLabel.Text = string.Format("Time Left: {0}", _timeleft);
                _timeleft = _timeleft - 1;
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {

            var quiz = new GQuiz()
            {
                Questions = QuestionLabel.Text,
                AnswerKey = CorrectLabel.Text,
                QuestionNumber = _currentQuiz.QuestionNumber
            };


            if (radioButton1.Checked)
            {
                quiz.Option1 = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                quiz.Option2 = radioButton2.Text;

            }
            else if (radioButton3.Checked)
            {
                quiz.Option3 = radioButton3.Text;

            }
            else if (radioButton4.Checked)
            {
                quiz.Option4 = radioButton4.Text;

            }

            QuizHubProxy.Invoke("QuestionAnsweredGQuizEasy", quiz, UserName);
            QuizHubProxy.Invoke("QuestionAnsweredGQuizAverage", quiz, UserName);
            QuizHubProxy.Invoke("QuestionAnsweredGQuizDifficult", quiz, UserName);
            QuizHubProxy.Invoke("QuestionAnsweredGQuizClincher", quiz, UserName);

            
            groupBox1.Enabled = false;
            button1.Enabled = false;
        }



    }
}
