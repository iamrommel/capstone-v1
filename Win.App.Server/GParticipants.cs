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
    public partial class GParticipants : Form
    {
        public GParticipants()
        {
            InitializeComponent();
        }

        private void gParticipantsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gParticipantsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quizBeeDataSet);
            MessageBox.Show("Successfully saved into the database", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void GParticipants_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizBeeDataSet.GParticipants' table. You can move, or remove it, as needed.
            this.gParticipantsTableAdapter.Fill(this.quizBeeDataSet.GParticipants);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please fill in the required values for the Quiz", "System", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
     ==
     System.Windows.Forms.DialogResult.OK)
            {

               // quizL1BindingSource.RemoveCurrent();
                gParticipantsBindingSource.RemoveCurrent();
                MessageBox.Show("Successfully Deleted!");
            }
            else
            {
                MessageBox.Show("Aborted");
            }
        }
    }
}
