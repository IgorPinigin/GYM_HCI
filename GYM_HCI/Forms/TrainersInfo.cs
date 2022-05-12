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
    public partial class TrainersInfo : Form
    {
        public TrainersInfo()
        {
            InitializeComponent();
        }

        private void тренерBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тренерBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pinigin907aDataSet);

        }

        private void TrainersInfo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pinigin907aDataSet.Данные_авторизации". При необходимости она может быть перемещена или удалена.
            this.данные_авторизацииTableAdapter.Fill(this.pinigin907aDataSet.Данные_авторизации);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pinigin907aDataSet.Тренер". При необходимости она может быть перемещена или удалена.
            this.тренерTableAdapter.Fill(this.pinigin907aDataSet.Тренер);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
