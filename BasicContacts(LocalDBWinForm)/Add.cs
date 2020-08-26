using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BasicContacts_LocalDBWinForm_
{
    public partial class Add : Form
    {
        private SqlConnection sqlConnection = null;
        public MainForm Main = new MainForm();

        public Add(SqlConnection connection)
        {
            InitializeComponent();

            sqlConnection = connection;
        }

        private async void btn_Accept_Click(object sender, EventArgs e)
        {
            //Create a SQL command
            SqlCommand addPeopleCommand = new SqlCommand("INSERT INTO [Peoples] (FirstName, Name, SurName, Email, Age, Phone) VALUES (@FirstName, @Name, @SurName, @Email, @Age, @Phone)", sqlConnection);
            //add parameters to the variables that we specified in addPeopleCommand
            addPeopleCommand.Parameters.AddWithValue("FirstName", tbx_FirstName.Text);
            addPeopleCommand.Parameters.AddWithValue("Name", tbx_Name.Text);
            addPeopleCommand.Parameters.AddWithValue("SurName", tbx_SurName.Text);
            addPeopleCommand.Parameters.AddWithValue("Email", tbx_Email.Text);
            addPeopleCommand.Parameters.AddWithValue("Age", Convert.ToDateTime(mtbx_Age.Text));
            addPeopleCommand.Parameters.AddWithValue("Phone", tbx_Phone.Text);
            //create a block try-catch-finally
            try
            {
                await addPeopleCommand.ExecuteNonQueryAsync();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //on form 1, call the asynchronous method Update
                await Main.Update();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
