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
using System.Configuration;

namespace BasicContacts_LocalDBWinForm_
{
    public partial class MainForm : Form
    {
        private SqlConnection sqlConnection = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PeopleCS"].ConnectionString;

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.Columns.Add("Фамилия");
            listView1.Columns.Add("Имя");
            listView1.Columns.Add("Отчество");
            listView1.Columns.Add("Электронная почта");
            listView1.Columns.Add("Дата рождения");
            listView1.Columns.Add("Телефон");

            await LoadPeoples();
        }
        public async Task Update()
        {
            listView1.Items.Clear();
            await LoadPeoples();
        }
        public async Task LoadPeoples()
        {
            SqlDataReader sqlReader = null;
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Peoples]", sqlConnection);

            try
            {
                sqlReader = await sqlCommand.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    ListViewItem item = new ListViewItem(new string[] {

                        Convert.ToString(sqlReader["FirstName"]),
                        Convert.ToString(sqlReader["Name"]),
                        Convert.ToString(sqlReader["SurName"]),
                        Convert.ToString(sqlReader["Email"]),
                        Convert.ToString(sqlReader["Age"]),
                        Convert.ToString(sqlReader["Phone"]),
                        Convert.ToString(sqlReader["id"]),
                    });

                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null && !sqlReader.IsClosed)
                {
                    sqlReader.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Добавить контакт")
            {
                btn_AddEdit.Text = "Добавить контакт";
            }
            else if (comboBox1.Text == "Изменить контакт")
            {
                btn_AddEdit.Text = "Изменить контакт";
            }
            else if (comboBox1.Text == "Удалить")
            {
                btn_AddEdit.Text = "Удалить";
            }
        }

        private async void btn_AddEdit_Click(object sender, EventArgs e)
        {
            if (btn_AddEdit.Text == "Добавить контакт")
            {

                Add addForm = new Add(sqlConnection);
                addForm.Main = this;

                DialogResult result;
                addForm.ShowDialog();

            }
            else if (btn_AddEdit.Text == "Изменить контакт")
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    Edit editForm = new Edit(sqlConnection, Convert.ToInt32(listView1.SelectedItems[0].SubItems[6].Text));
                    editForm.Main = this;
                    DialogResult result;
                    editForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Вы не выбрали пользователя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btn_AddEdit.Text == "Удалить")
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    DialogResult res = MessageBox.Show("Вы действительно хотите удалить эту строку!", "Удаление строки", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    switch (res)
                    {
                        case DialogResult.Yes:
                            SqlCommand delsqlCommand = new SqlCommand("DELETE FROM [Peoples] WHERE [Id] = @Id", sqlConnection);
                            delsqlCommand.Parameters.AddWithValue("Id", Convert.ToInt32(listView1.SelectedItems[0].SubItems[6].Text)); //Convert.ToInt32(listView1.SelectedItems[0].SubItems[6].Text)

                            try
                            {
                                await delsqlCommand.ExecuteNonQueryAsync();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            listView1.Items.Clear();
                            await LoadPeoples();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали пользователя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lb_Clear_Click(object sender, EventArgs e)
        {
            tbx_Search.Clear();
            lb_Clear.Visible = false;
        }

        private async void tbx_Search_TextChanged(object sender, EventArgs e)
        {
            if (tbx_Search != null)
            {
                lb_Clear.Visible = true;
            }

            List<int> mass = new List<int>();
            foreach (ListViewItem itm in listView1.Items)
            {

                if (itm.SubItems[0].Text.IndexOf(tbx_Search.Text, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    itm.SubItems[1].Text.IndexOf(tbx_Search.Text, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    itm.SubItems[2].Text.IndexOf(tbx_Search.Text, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    itm.SubItems[3].Text.IndexOf(tbx_Search.Text, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    itm.SubItems[4].Text.IndexOf(tbx_Search.Text, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    itm.SubItems[5].Text.IndexOf(tbx_Search.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    mass.Add(itm.Index);
                }
                else
                {
                    listView1.Items.Remove(itm);
                }
            }
            if (tbx_Search.Text == "")
                await Update();
        }
    }
}
