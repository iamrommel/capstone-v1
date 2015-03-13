using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Win.App.Server
{
    public partial class BackupNRestore : Form
    {

        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;
        string sql = "";
        String connectionString = "";


        public BackupNRestore()
        {
            InitializeComponent();
        }

        private void BackupNRestore_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            BtnDisconnect.Enabled = false;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {

                connectionString = "Data Source=" + serverSelect.Text + ";" + "Integrated Security=True";
                conn = new SqlConnection(connectionString);
                conn.Open();
                sql = "EXEC sp_databases";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();
                CBdataselection.Items.Clear();
                MessageBox.Show("Connected to the server database !");
                while (reader.Read())
                {
                    CBdataselection.Items.Add(reader[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            BtnConnect.Enabled = false;
            TxtDataSource.Enabled = false;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            BtnDisconnect.Enabled = true;
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            conn.Close();
            TxtDataSource.Enabled = true;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            BtnConnect.Enabled = true;
            BtnDisconnect.Enabled = false;
            MessageBox.Show("Disconnected from the server database !");
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (CBdataselection.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Please Select a Database");
                    return;
                }
                conn = new SqlConnection(connectionString);
                conn.Open();
                sql = "BACKUP DATABASE " + CBdataselection.Text + " TO DISK= '" + txtLocation.Text + "\\" + CBdataselection.Text + ".BAK'";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Sucessfully Databse Backup completed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtLocation.Text = dlg.SelectedPath;
            }
        }

        private void BtnBrowse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup File(*.bak)| *.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtRestore.Text = dlg.FileName;
            }
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (CBdataselection.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Please Select a Database");
                    return;
                }
                conn = new SqlConnection(connectionString);
                conn.Open();
                sql = "Alter Database " + CBdataselection.Text + " Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += "Restore Database " + CBdataselection.Text + " FROM Disk = '" + txtRestore.Text + "' WITH REPLACE";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Successfully Restored");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    
        private void btnBack_Click(object sender, EventArgs e)
        {
            BackupNRestore  BACK1 = new BackupNRestore ();
            BACK1.Hide();


        }

        

    }
}
