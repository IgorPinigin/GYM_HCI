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
        SqlConnection connection = new SqlConnection(strConn);

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
            
            string sqlCommand = "select [Администратор] from [Данные авторизации] where [Логин] = '" + textBox1.Text + "' and [Пароль] = '" + textBox2.Text + "'";
            using (SqlConnection connection = new SqlConnection(strConn));
            SqlCommand command = new SqlCommand(sqlCommand,     connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) // если есть данные
            {

                while (reader.Read())
                {
                    if (reader.GetBoolean(0) == true)
                        a = 1;
                }
            }
            int c = countLogins() + a;
            if (c == 1)
            {
                loginkrutoi228 = textBox1.Text;
                Lichka newForm = new Lichka();
                newForm.Show();
                this.Close();

            }
            else
                if (c == 2)
            {
                loginkrutoi228 = textBox1.Text;
                LichkaAdmin newForm = new LichkaAdmin();
                newForm.Show();
                this.Close();
            }
        }
        public Login()
        {
            InitializeComponent();
        }
    }
}
