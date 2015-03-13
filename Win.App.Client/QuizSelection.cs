using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.App.Client
{
    public partial class QuizSelection : Form
    {
        public QuizSelection()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnJPIA_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void btnLPU_Click(object sender, EventArgs e)
        {
            GForm frm2 = new GForm();
            this.Hide();
            frm2.Show();
        }
    }
}
