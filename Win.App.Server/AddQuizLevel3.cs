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
    public partial class AddQuizLevel3 : Form
    {
        public AddQuizLevel3()
        {
            InitializeComponent();
        }

        private void quizL3BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quizL3BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quizBeeDataSet);
            MessageBox.Show("Successfully saved into the database", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void AddQuizLevel3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizBeeDataSet.QuizL3' table. You can move, or remove it, as needed.
            this.quizL3TableAdapter.Fill(this.quizBeeDataSet.QuizL3);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                ==
                System.Windows.Forms.DialogResult.OK)
            {

                quizL3BindingSource.RemoveCurrent();
                MessageBox.Show("Successfully Deleted!");
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

        private void option3TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
