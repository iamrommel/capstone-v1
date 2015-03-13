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
    public partial class MainScreen2 : Form
    {
        public MainScreen2()
        {
            InitializeComponent();
        }

        private void quizLevel1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Program.MainForm.Show();

        }

        private void level1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddQuizLevel1 frmQuizL1 = new AddQuizLevel1();
            frmQuizL1.Show();
        }

        private void level2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddQuizLevel2 frmQuizL2 = new AddQuizLevel2();
            frmQuizL2.Show();
        }

        private void level3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddQuizLevel3 frmQuizL3 = new AddQuizLevel3();
            frmQuizL3.Show();
        }

        private void clincherRoundToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddQuizClincher frmQuizClincher = new AddQuizClincher();
            frmQuizClincher.Show();
        }

        private void quizLevel2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //QuizL2Server frmQL2Server = new QuizL2Server();
            //frmQL2Server.Show();

            Program.frmQuizL2Server.Show();
        }

        private void quizLevel3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //QuizServerControl.QuizL3Server frmQL3Server = new QuizServerControl.QuizL3Server();
            //frmQL3Server.Show();

            Program.frmQuizL3Server.Show();
        }

        private void clincherRoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //QuizServerControl.QClincherServer frmQClincher = new QuizServerControl.QClincherServer();
            //frmQClincher.Show();

            Program.frmQClincherServer.Show();
        }

        private void level1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddQuizLevel1 frmQuizL1 = new AddQuizLevel1();
            frmQuizL1.Show();
        }

        private void level2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddQuizLevel2 frmQuizL2 = new AddQuizLevel2();
            frmQuizL2.Show();
        }

        private void level3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddQuizLevel3 frmQuizL3 = new AddQuizLevel3();
            frmQuizL3.Show();
        }

        private void clincherRoundToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddQuizClincher frmQuizClincher = new AddQuizClincher();
            frmQuizClincher.Show();
        }

        private void scoreBoardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ScoreBoard.ScoreBoard frmScoreBoard = new ScoreBoard.ScoreBoard();
            frmScoreBoard.Show();
        }

        private void MainScreen2_Load(object sender, EventArgs e)
        {

        }

        private void RegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Participants frmParticipants = new Participants();
            frmParticipants.Show();
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

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void HelpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About aboutfrm = new About();
            aboutfrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen MScreen = new MainScreen();
            MScreen.Show();
        }

        private void participantsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Participants frmParticipants = new Participants();
            frmParticipants.Show();
        }

        private void tallySheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.TallySheetScreen.Show();
        }
    }
}
