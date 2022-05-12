using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_HCI.Forms
{
    public partial class Login : Form
    {
        string strConn = Classes.StrConnection.strConn;
        SqlConnection connection = new SqlConnection(Classes.StrConnection.strConn);
        int a = 0;
        static public string LoginInfo = "";
        public int LoginUser()
        {
            int TypeOfUser = cbTypeOfUser.SelectedIndex;
            int newProdID = 0;
            string sql = "select count(*)from [Данные авторизации] where [Логин] = '" + tbLogin.Text + "' and [Пароль] = '" + tbPass.Text + "'and [Тип пользователя] = '" + TypeOfUser + "'";
            using (SqlConnection conn = new SqlConnection(strConn))

            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    newProdID = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            //MessageBox.Show(newProdID.ToString());
            return (int)newProdID;
        }
        public void logins()
        {
            connection.Open();
            string sqlCommand = "select [Тип пользователя] from [Данные авторизации] where [Логин] = '" + tbLogin.Text + "' and [Пароль] = '" + tbPass.Text + "'";
            using (SqlConnection connection = new SqlConnection(strConn));
            SqlCommand command = new SqlCommand(sqlCommand,     connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) // если есть данные
            {

                while (reader.Read())
                {
                    a = reader.GetInt32(0);
                      
                }
            }
            int c = LoginUser() + a;
            if (c == 1)
            {
                LoginInfo = tbLogin.Text;
                UserForm newForm = new UserForm();
                newForm.Show();
                this.Close();

            }
            else 
                if (c == 2)
            {
                LoginInfo = tbLogin.Text;
                TrainerForm newForm = new TrainerForm();
                newForm.Show();
                this.Close();

            }
            else
                if (c == 3)
            {
                LoginInfo = tbLogin.Text;
                AdminForm newForm = new AdminForm();
                newForm.Show();
                this.Close();
            }
            else
                
            {
                MessageBox.Show("Введите корректные данные");
                return;
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (tbPass.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            logins();

        }
    }
    
}
