
namespace GYM_HCI.Forms
{
    partial class AbonementsInfoForAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label видLabel;
            System.Windows.Forms.Label количество_занятийLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbonementsInfoForAdmin));
            this.pinigin907aDataSet1 = new GYM_HCI.pinigin907aDataSet1();
            this.абонементыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.абонементыTableAdapter = new GYM_HCI.pinigin907aDataSet1TableAdapters.АбонементыTableAdapter();
            this.tableAdapterManager = new GYM_HCI.pinigin907aDataSet1TableAdapters.TableAdapterManager();
            this.абонементыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.абонементыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.абонементыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видTextBox = new System.Windows.Forms.TextBox();
            this.количество_занятийTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            видLabel = new System.Windows.Forms.Label();
            количество_занятийLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pinigin907aDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.абонементыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.абонементыBindingNavigator)).BeginInit();
            this.абонементыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.абонементыDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // видLabel
            // 
            видLabel.AutoSize = true;
            видLabel.Location = new System.Drawing.Point(486, 128);
            видLabel.Name = "видLabel";
            видLabel.Size = new System.Drawing.Size(29, 13);
            видLabel.TabIndex = 4;
            видLabel.Text = "Вид:";
            // 
            // количество_занятийLabel
            // 
            количество_занятийLabel.AutoSize = true;
            количество_занятийLabel.Location = new System.Drawing.Point(486, 154);
            количество_занятийLabel.Name = "количество_занятийLabel";
            количество_занятийLabel.Size = new System.Drawing.Size(113, 13);
            количество_занятийLabel.TabIndex = 6;
            количество_занятийLabel.Text = "Количество занятий:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(486, 180);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 8;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // pinigin907aDataSet1
            // 
            this.pinigin907aDataSet1.DataSetName = "pinigin907aDataSet1";
            this.pinigin907aDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // абонементыBindingSource
            // 
            this.абонементыBindingSource.DataMember = "Абонементы";
            this.абонементыBindingSource.DataSource = this.pinigin907aDataSet1;
            // 
            // абонементыTableAdapter
            // 
            this.абонементыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = GYM_HCI.pinigin907aDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АбонементыTableAdapter = this.абонементыTableAdapter;
            // 
            // абонементыBindingNavigator
            // 
            this.абонементыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.абонементыBindingNavigator.BindingSource = this.абонементыBindingSource;
            this.абонементыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.абонементыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.абонементыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.абонементыBindingNavigatorSaveItem});
            this.абонементыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.абонементыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.абонементыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.абонементыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.абонементыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.абонементыBindingNavigator.Name = "абонементыBindingNavigator";
            this.абонементыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.абонементыBindingNavigator.Size = new System.Drawing.Size(748, 25);
            this.абонементыBindingNavigator.TabIndex = 0;
            this.абонементыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // абонементыBindingNavigatorSaveItem
            // 
            this.абонементыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.абонементыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("абонементыBindingNavigatorSaveItem.Image")));
            this.абонементыBindingNavigatorSaveItem.Name = "абонементыBindingNavigatorSaveItem";
            this.абонементыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.абонементыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.абонементыBindingNavigatorSaveItem.Click += new System.EventHandler(this.абонементыBindingNavigatorSaveItem_Click);
            // 
            // абонементыDataGridView
            // 
            this.абонементыDataGridView.AutoGenerateColumns = false;
            this.абонементыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.абонементыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.абонементыDataGridView.DataSource = this.абонементыBindingSource;
            this.абонементыDataGridView.Location = new System.Drawing.Point(12, 90);
            this.абонементыDataGridView.Name = "абонементыDataGridView";
            this.абонементыDataGridView.Size = new System.Drawing.Size(444, 220);
            this.абонементыDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Вид";
            this.dataGridViewTextBoxColumn2.HeaderText = "Вид";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Количество занятий";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество занятий";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn4.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // видTextBox
            // 
            this.видTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.абонементыBindingSource, "Вид", true));
            this.видTextBox.Location = new System.Drawing.Point(605, 125);
            this.видTextBox.Name = "видTextBox";
            this.видTextBox.Size = new System.Drawing.Size(100, 20);
            this.видTextBox.TabIndex = 5;
            // 
            // количество_занятийTextBox
            // 
            this.количество_занятийTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.абонементыBindingSource, "Количество занятий", true));
            this.количество_занятийTextBox.Location = new System.Drawing.Point(605, 151);
            this.количество_занятийTextBox.Name = "количество_занятийTextBox";
            this.количество_занятийTextBox.Size = new System.Drawing.Size(100, 20);
            this.количество_занятийTextBox.TabIndex = 7;
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.абонементыBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(605, 177);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(100, 20);
            this.стоимостьTextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Абонементы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(485, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Введите информацию:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 45);
            this.button2.TabIndex = 12;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AbonementsInfoForAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 414);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(видLabel);
            this.Controls.Add(this.видTextBox);
            this.Controls.Add(количество_занятийLabel);
            this.Controls.Add(this.количество_занятийTextBox);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(this.абонементыDataGridView);
            this.Controls.Add(this.абонементыBindingNavigator);
            this.Name = "AbonementsInfoForAdmin";
            this.Text = "AbonementsInfo";
            this.Load += new System.EventHandler(this.AbonementsInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pinigin907aDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.абонементыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.абонементыBindingNavigator)).EndInit();
            this.абонементыBindingNavigator.ResumeLayout(false);
            this.абонементыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.абонементыDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pinigin907aDataSet1 pinigin907aDataSet1;
        private System.Windows.Forms.BindingSource абонементыBindingSource;
        private pinigin907aDataSet1TableAdapters.АбонементыTableAdapter абонементыTableAdapter;
        private pinigin907aDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator абонементыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton абонементыBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView абонементыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox видTextBox;
        private System.Windows.Forms.TextBox количество_занятийTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}