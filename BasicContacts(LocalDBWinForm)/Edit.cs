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
    public partial class Edit : Form
    {
        private SqlConnection sqlConnection = null;
        public MainForm Main = new MainForm();
        private int id;

        public Edit(SqlConnection connection, int id)
        {
            InitializeComponent();

            sqlConnection = connection;

            this.id = id;
        }

        private async void btn_Accept_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("UPDATE [Peoples] SET [FirstName] = @FirstName, [Name] = @Name, [SurName] = @SurName, [Email] = @Email, [Age] = @Age, [Phone] = @Phone WHERE [Id] = @Id", sqlConnection);
            sqlCommand.Parameters.AddWithValue("FirstName", tbx_FirstName.Text);
            sqlCommand.Parameters.AddWithValue("Name", tbx_Name.Text);
            sqlCommand.Parameters.AddWithValue("SurName", tbx_SurName.Text);
            sqlCommand.Parameters.AddWithValue("Email", tbx_Email.Text);
            sqlCommand.Parameters.AddWithValue("Age", Convert.ToDateTime(mtbx_Age.Text));
            sqlCommand.Parameters.AddWithValue("Phone", tbx_Phone.Text);
            sqlCommand.Parameters.AddWithValue("Id", id);

            try
            {
                await sqlCommand.ExecuteNonQueryAsync();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                await Main.Update();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void Edit_Load(object sender, EventArgs e)
        {
            //We create a substitution of rows from the database into fields by id
            SqlCommand sqlCommand = new SqlCommand("SELECT [FirstName], [Name], [SurName], [Email], [Age], [Phone] FROM [Peoples] WHERE id = @id", sqlConnection);
            sqlCommand.Parameters.AddWithValue("id", id);

            SqlDataReader sqlDataReader = null;

            try
            {
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();

                while (await sqlDataReader.ReadAsync())
                {
                    tbx_FirstName.Text = Convert.ToString(sqlDataReader["FirstName"]);
                    tbx_Name.Text = Convert.ToString(sqlDataReader["Name"]);
                    tbx_SurName.Text = Convert.ToString(sqlDataReader["SurName"]);
                    tbx_Email.Text = Convert.ToString(sqlDataReader["Email"]);
                    mtbx_Age.Text = Convert.ToString(sqlDataReader["Age"]);
                    tbx_Phone.Text = Convert.ToString(sqlDataReader["Phone"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlDataReader != null && !sqlDataReader.IsClosed)
                {
                    sqlDataReader.Close();
                }
            }
        }
    }
}
