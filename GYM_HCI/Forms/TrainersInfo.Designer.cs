
namespace GYM_HCI.Forms
{
    partial class TrainersInfo
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
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label индивидуальные_достиженияLabel;
            System.Windows.Forms.Label вид_деятельностиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainersInfo));
            System.Windows.Forms.Label логинLabel;
            System.Windows.Forms.Label парольLabel;
            System.Windows.Forms.Label тип_пользователяLabel;
            this.pinigin907aDataSet = new GYM_HCI.pinigin907aDataSet();
            this.тренерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тренерTableAdapter = new GYM_HCI.pinigin907aDataSetTableAdapters.ТренерTableAdapter();
            this.tableAdapterManager = new GYM_HCI.pinigin907aDataSetTableAdapters.TableAdapterManager();
            this.данные_авторизацииTableAdapter = new GYM_HCI.pinigin907aDataSetTableAdapters.Данные_авторизацииTableAdapter();
            this.тренерBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.тренерBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.данные_авторизацииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.тренерDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.индивидуальные_достиженияTextBox = new System.Windows.Forms.TextBox();
            this.вид_деятельностиTextBox = new System.Windows.Forms.TextBox();
            this.логинTextBox = new System.Windows.Forms.TextBox();
            this.парольTextBox = new System.Windows.Forms.TextBox();
            this.тип_пользователяComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            индивидуальные_достиженияLabel = new System.Windows.Forms.Label();
            вид_деятельностиLabel = new System.Windows.Forms.Label();
            логинLabel = new System.Windows.Forms.Label();
            парольLabel = new System.Windows.Forms.Label();
            тип_пользователяLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pinigin907aDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тренерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тренерBindingNavigator)).BeginInit();
            this.тренерBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.данные_авторизацииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.тренерDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(571, 96);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 6;
            фИОLabel.Text = "ФИО:";
            // 
            // индивидуальные_достиженияLabel
            // 
            индивидуальные_достиженияLabel.AutoSize = true;
            индивидуальные_достиженияLabel.Location = new System.Drawing.Point(571, 122);
            индивидуальные_достиженияLabel.Name = "индивидуальные_достиженияLabel";
            индивидуальные_достиженияLabel.Size = new System.Drawing.Size(161, 13);
            индивидуальные_достиженияLabel.TabIndex = 8;
            индивидуальные_достиженияLabel.Text = "Индивидуальные достижения:";
            // 
            // вид_деятельностиLabel
            // 
            вид_деятельностиLabel.AutoSize = true;
            вид_деятельностиLabel.Location = new System.Drawing.Point(571, 148);
            вид_деятельностиLabel.Name = "вид_деятельностиLabel";
            вид_деятельностиLabel.Size = new System.Drawing.Size(102, 13);
            вид_деятельностиLabel.TabIndex = 10;
            вид_деятельностиLabel.Text = "Вид деятельности:";
            // 
            // pinigin907aDataSet
            // 
            this.pinigin907aDataSet.DataSetName = "pinigin907aDataSet";
            this.pinigin907aDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // тренерBindingSource
            // 
            this.тренерBindingSource.DataMember = "Тренер";
            this.тренерBindingSource.DataSource = this.pinigin907aDataSet;
            // 
            // тренерTableAdapter
            // 
            this.тренерTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = GYM_HCI.pinigin907aDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Данные_авторизацииTableAdapter = this.данные_авторизацииTableAdapter;
            this.tableAdapterManager.ТренерTableAdapter = this.тренерTableAdapter;
            // 
            // данные_авторизацииTableAdapter
            // 
            this.данные_авторизацииTableAdapter.ClearBeforeFill = true;
            // 
            // тренерBindingNavigator
            // 
            this.тренерBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.тренерBindingNavigator.BindingSource = this.тренерBindingSource;
            this.тренерBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.тренерBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.тренерBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.тренерBindingNavigatorSaveItem});
            this.тренерBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.тренерBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.тренерBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.тренерBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.тренерBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.тренерBindingNavigator.Name = "тренерBindingNavigator";
            this.тренерBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.тренерBindingNavigator.Size = new System.Drawing.Size(893, 25);
            this.тренерBindingNavigator.TabIndex = 0;
            this.тренерBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // тренерBindingNavigatorSaveItem
            // 
            this.тренерBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.тренерBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("тренерBindingNavigatorSaveItem.Image")));
            this.тренерBindingNavigatorSaveItem.Name = "тренерBindingNavigatorSaveItem";
            this.тренерBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.тренерBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.тренерBindingNavigatorSaveItem.Click += new System.EventHandler(this.тренерBindingNavigatorSaveItem_Click);
            // 
            // данные_авторизацииBindingSource
            // 
            this.данные_авторизацииBindingSource.DataMember = "Данные авторизации";
            this.данные_авторизацииBindingSource.DataSource = this.pinigin907aDataSet;
            // 
            // тренерDataGridView
            // 
            this.тренерDataGridView.AutoGenerateColumns = false;
            this.тренерDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.тренерDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.тренерDataGridView.DataSource = this.тренерBindingSource;
            this.тренерDataGridView.Location = new System.Drawing.Point(12, 72);
            this.тренерDataGridView.Name = "тренерDataGridView";
            this.тренерDataGridView.Size = new System.Drawing.Size(544, 220);
            this.тренерDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Логин";
            this.dataGridViewTextBoxColumn2.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn3.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Индивидуальные достижения";
            this.dataGridViewTextBoxColumn4.HeaderText = "Индивидуальные достижения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Вид деятельности";
            this.dataGridViewTextBoxColumn5.HeaderText = "Вид деятельности";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тренерBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(738, 93);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(100, 20);
            this.фИОTextBox.TabIndex = 7;
            // 
            // индивидуальные_достиженияTextBox
            // 
            this.индивидуальные_достиженияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тренерBindingSource, "Индивидуальные достижения", true));
            this.индивидуальные_достиженияTextBox.Location = new System.Drawing.Point(738, 119);
            this.индивидуальные_достиженияTextBox.Name = "индивидуальные_достиженияTextBox";
            this.индивидуальные_достиженияTextBox.Size = new System.Drawing.Size(100, 20);
            this.индивидуальные_достиженияTextBox.TabIndex = 9;
            // 
            // вид_деятельностиTextBox
            // 
            this.вид_деятельностиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.тренерBindingSource, "Вид деятельности", true));
            this.вид_деятельностиTextBox.Location = new System.Drawing.Point(738, 145);
            this.вид_деятельностиTextBox.Name = "вид_деятельностиTextBox";
            this.вид_деятельностиTextBox.Size = new System.Drawing.Size(100, 20);
            this.вид_деятельностиTextBox.TabIndex = 11;
            // 
            // логинLabel
            // 
            логинLabel.AutoSize = true;
            логинLabel.Location = new System.Drawing.Point(571, 227);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(41, 13);
            логинLabel.TabIndex = 11;
            логинLabel.Text = "Логин:";
            // 
            // логинTextBox
            // 
            this.логинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.данные_авторизацииBindingSource, "Логин", true));
            this.логинTextBox.Location = new System.Drawing.Point(738, 220);
            this.логинTextBox.Name = "логинTextBox";
            this.логинTextBox.Size = new System.Drawing.Size(100, 20);
            this.логинTextBox.TabIndex = 12;
            // 
            // парольLabel
            // 
            парольLabel.AutoSize = true;
            парольLabel.Location = new System.Drawing.Point(571, 253);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(48, 13);
            парольLabel.TabIndex = 13;
            парольLabel.Text = "Пароль:";
            // 
            // парольTextBox
            // 
            this.парольTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.данные_авторизацииBindingSource, "Пароль", true));
            this.парольTextBox.Location = new System.Drawing.Point(738, 246);
            this.парольTextBox.Name = "парольTextBox";
            this.парольTextBox.Size = new System.Drawing.Size(100, 20);
            this.парольTextBox.TabIndex = 14;
            // 
            // тип_пользователяLabel
            // 
            тип_пользователяLabel.AutoSize = true;
            тип_пользователяLabel.Location = new System.Drawing.Point(571, 279);
            тип_пользователяLabel.Name = "тип_пользователяLabel";
            тип_пользователяLabel.Size = new System.Drawing.Size(103, 13);
            тип_пользователяLabel.TabIndex = 15;
            тип_пользователяLabel.Text = "Тип пользователя:";
            // 
            // тип_пользователяComboBox
            // 
            this.тип_пользователяComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.данные_авторизацииBindingSource, "Тип пользователя", true));
            this.тип_пользователяComboBox.FormattingEnabled = true;
            this.тип_пользователяComboBox.Location = new System.Drawing.Point(738, 272);
            this.тип_пользователяComboBox.Name = "тип_пользователяComboBox";
            this.тип_пользователяComboBox.Size = new System.Drawing.Size(100, 21);
            this.тип_пользователяComboBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(571, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Личная информация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(571, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Данные входа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Тренеры:";
            // 
            // TrainersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(логинLabel);
            this.Controls.Add(this.логинTextBox);
            this.Controls.Add(парольLabel);
            this.Controls.Add(this.парольTextBox);
            this.Controls.Add(тип_пользователяLabel);
            this.Controls.Add(this.тип_пользователяComboBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(индивидуальные_достиженияLabel);
            this.Controls.Add(this.индивидуальные_достиженияTextBox);
            this.Controls.Add(вид_деятельностиLabel);
            this.Controls.Add(this.вид_деятельностиTextBox);
            this.Controls.Add(this.тренерDataGridView);
            this.Controls.Add(this.тренерBindingNavigator);
            this.Name = "TrainersInfo";
            this.Text = "TrainersInfo";
            this.Load += new System.EventHandler(this.TrainersInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pinigin907aDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тренерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тренерBindingNavigator)).EndInit();
            this.тренерBindingNavigator.ResumeLayout(false);
            this.тренерBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.данные_авторизацииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.тренерDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pinigin907aDataSet pinigin907aDataSet;
        private System.Windows.Forms.BindingSource тренерBindingSource;
        private pinigin907aDataSetTableAdapters.ТренерTableAdapter тренерTableAdapter;
        private pinigin907aDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator тренерBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton тренерBindingNavigatorSaveItem;
        private pinigin907aDataSetTableAdapters.Данные_авторизацииTableAdapter данные_авторизацииTableAdapter;
        private System.Windows.Forms.BindingSource данные_авторизацииBindingSource;
        private System.Windows.Forms.DataGridView тренерDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox индивидуальные_достиженияTextBox;
        private System.Windows.Forms.TextBox вид_деятельностиTextBox;
        private System.Windows.Forms.TextBox логинTextBox;
        private System.Windows.Forms.TextBox парольTextBox;
        private System.Windows.Forms.ComboBox тип_пользователяComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}