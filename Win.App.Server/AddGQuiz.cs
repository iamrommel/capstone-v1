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
    public partial class AddGQuiz : Form
    {
        public AddGQuiz()
        {
            InitializeComponent();
        }

        private void gQuizBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gQuizBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quizBeeDataSet);
            MessageBox.Show("Successfully saved into the database", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void AddGQuiz_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizBeeDataSet.GQuiz' table. You can move, or remove it, as needed.
            this.gQuizTableAdapter.Fill(this.quizBeeDataSet.GQuiz);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                ==
                System.Windows.Forms.DialogResult.OK)
            {

                gQuizBindingSource.RemoveCurrent();
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Aborted");
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please fill in the required values for the Quiz", "System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
    }
}
