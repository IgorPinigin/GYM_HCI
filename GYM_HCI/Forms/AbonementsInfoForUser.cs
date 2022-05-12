using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_HCI.Forms
{
    public partial class AbonementsInfoForUser : Form
    {
        public AbonementsInfoForUser()
        {
            InitializeComponent();
        }

        private void AbonementsInfoForUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pinigin907aDataSet1.Абонементы". При необходимости она может быть перемещена или удалена.
            this.абонементыTableAdapter.Fill(this.pinigin907aDataSet1.Абонементы);

        }
    }
}
