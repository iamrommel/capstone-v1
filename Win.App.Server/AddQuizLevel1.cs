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
    public partial class AddQuizLevel1 : Form
    {
        public AddQuizLevel1()
        {
            InitializeComponent();
        }

        private void quizL1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quizL1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quizBeeDataSet);
            MessageBox.Show("Successfully saved into the database", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void AddQuizLevel1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizBeeDataSet.QuizL1' table. You can move, or remove it, as needed.
            this.quizL1TableAdapter.Fill(this.quizBeeDataSet.QuizL1);

        }

        private void quizL1BindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                ==
                System.Windows.Forms.DialogResult.OK)
            {

                quizL1BindingSource.RemoveCurrent();
                MessageBox.Show("Successfully Deleted");
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
