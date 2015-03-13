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
    public partial class GMainScreen : Form
    {
        public GMainScreen()
        {
            InitializeComponent();
        }

        private void easyRoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GQuizServerControl.GQuizEasy frmGQuizEasy = new GQuizServerControl.GQuizEasy();
            //frmGQuizEasy.Show();

            Program.frmGQuizEasy.Show();
        }

        private void averageRoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GQuizServerControl.GQuizAverage frmGQuizAverage = new GQuizServerControl.GQuizAverage();
            //frmGQuizAverage.Show();

            Program.frmGQuizAverage.Show();
        }

        private void difficultRoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GQuizServerControl.GQuizDifficult frmGQuizDifficult = new GQuizServerControl.GQuizDifficult();
            //frmGQuizDifficult.Show();

            Program.frmGQuizDifficult.Show();
        }

        private void clincherRoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //GQuizServerControl.GQuizClincher frmGQuizClincher = new GQuizServerControl.GQuizClincher();
            //frmGQuizClincher.Show();

            Program.frmGQuizClincher.Show();
        }

        private void QuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGQuiz frmAddGQuiz = new AddGQuiz();
            frmAddGQuiz.Show();
        }

        private void quizToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            AddGQuiz frmAddGQuiz = new AddGQuiz();
            frmAddGQuiz.Show();
        }

        private void scoreBoardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ScoreBoard.GScoreBoard frmGScore = new ScoreBoard.GScoreBoard();
            frmGScore.Show();
        }

        private void RegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GParticipants frmGParticipants = new GParticipants();
            frmGParticipants.Show();
        }

        private void RestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangePassword().ShowDialog();
        }

        private void restoreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BackupNRestore frmBackupandRestore = new BackupNRestore();
            frmBackupandRestore.Show();
        }

        private void HelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About aboutfrm = new About();
            aboutfrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen MaiScreen = new MainScreen();
            MaiScreen.Show();
        }

        private void participantsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GParticipants frmGParticipants = new GParticipants();
            frmGParticipants.Show();
        }

        private void tallySheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.GTallySheetScreen.Show();
        }

        
    }
}
