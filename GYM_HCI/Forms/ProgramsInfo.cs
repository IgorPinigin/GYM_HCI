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
    public partial class ProgramsInfo : Form
    {
        public ProgramsInfo()
        {
            InitializeComponent();
        }

        private void программыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.программыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pinigin907aDataSet3);

        }

        private void ProgramsInfo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pinigin907aDataSet3.Программы". При необходимости она может быть перемещена или удалена.
            this.программыTableAdapter.Fill(this.pinigin907aDataSet3.Программы);

        }
    }
}
