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
using GYM_HCI.Forms;

namespace GYM_HCI
{
    public partial class Registration : Form
    {
        string strConn = Classes.StrConnection.strConn;
        public void insertData()
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string sql = "insert into [Данные авторизации] values('" + Login.Text + "', '" + Password.Text + "', '0')";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Успешная регистрация");
            }
        }
        public Registration()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            insertData();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Login newForm = new Login();
            newForm.Show();
            
        }
    }
}
