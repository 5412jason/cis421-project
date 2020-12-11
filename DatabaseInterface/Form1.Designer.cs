
namespace DatabaseInterface
{
    partial class Form1
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
            this.tabControls = new System.Windows.Forms.TabControl();
            this.inventoryTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sKUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playItAgainSportsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playItAgainSportsDataSet = new DatabaseInterface.PlayItAgainSportsDataSet();
            this.updateInventory = new System.Windows.Forms.Button();
            this.employeeTab = new System.Windows.Forms.TabPage();
            this.updateEmployees = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionsTab = new System.Windows.Forms.TabPage();
            this.updateTransaction = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.transactionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sKUDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rewardsTab = new System.Windows.Forms.TabPage();
            this.updateRewards = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.rewardsIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardsPointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rewardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personTab = new System.Windows.Forms.TabPage();
            this.updatePerson = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.personIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.playItAgainSportsDataSet1 = new DatabaseInterface.PlayItAgainSportsDataSet1();
            this.playItAgainSportsDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new DatabaseInterface.PlayItAgainSportsDataSetTableAdapters.ItemTableAdapter();
            this.employeeTableAdapter = new DatabaseInterface.PlayItAgainSportsDataSetTableAdapters.EmployeeTableAdapter();
            this.personTableAdapter = new DatabaseInterface.PlayItAgainSportsDataSetTableAdapters.PersonTableAdapter();
            this.transactionsTableAdapter = new DatabaseInterface.PlayItAgainSportsDataSetTableAdapters.TransactionsTableAdapter();
            this.rewardsTableAdapter = new DatabaseInterface.PlayItAgainSportsDataSetTableAdapters.RewardsTableAdapter();
            this.tabControls.SuspendLayout();
            this.inventoryTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playItAgainSportsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playItAgainSportsDataSet)).BeginInit();
            this.employeeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.transactionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            this.rewardsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewardsBindingSource)).BeginInit();
            this.personTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playItAgainSportsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playItAgainSportsDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControls
            // 
            this.tabControls.Controls.Add(this.inventoryTab);
            this.tabControls.Controls.Add(this.employeeTab);
            this.tabControls.Controls.Add(this.transactionsTab);
            this.tabControls.Controls.Add(this.rewardsTab);
            this.tabControls.Controls.Add(this.personTab);
            this.tabControls.Location = new System.Drawing.Point(13, 13);
            this.tabControls.Name = "tabControls";
            this.tabControls.SelectedIndex = 0;
            this.tabControls.Size = new System.Drawing.Size(660, 425);
            this.tabControls.TabIndex = 0;
            // 
            // inventoryTab
            // 
            this.inventoryTab.Controls.Add(this.dataGridView1);
            this.inventoryTab.Controls.Add(this.updateInventory);
            this.inventoryTab.Location = new System.Drawing.Point(4, 22);
            this.inventoryTab.Name = "inventoryTab";
            this.inventoryTab.Padding = new System.Windows.Forms.Padding(3);
            this.inventoryTab.Size = new System.Drawing.Size(652, 399);
            this.inventoryTab.TabIndex = 0;
            this.inventoryTab.Text = "Inventory";
            this.inventoryTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sKUDataGridViewTextBoxColumn,
            this.itemCountDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 358);
            this.dataGridView1.TabIndex = 1;
            // 
            // sKUDataGridViewTextBoxColumn
            // 
            this.sKUDataGridViewTextBoxColumn.DataPropertyName = "SKU";
            this.sKUDataGridViewTextBoxColumn.HeaderText = "SKU";
            this.sKUDataGridViewTextBoxColumn.Name = "sKUDataGridViewTextBoxColumn";
            this.sKUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemCountDataGridViewTextBoxColumn
            // 
            this.itemCountDataGridViewTextBoxColumn.DataPropertyName = "ItemCount";
            this.itemCountDataGridViewTextBoxColumn.HeaderText = "ItemCount";
            this.itemCountDataGridViewTextBoxColumn.Name = "itemCountDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.playItAgainSportsDataSetBindingSource;
            // 
            // playItAgainSportsDataSetBindingSource
            // 
            this.playItAgainSportsDataSetBindingSource.DataSource = this.playItAgainSportsDataSet;
            this.playItAgainSportsDataSetBindingSource.Position = 0;
            // 
            // playItAgainSportsDataSet
            // 
            this.playItAgainSportsDataSet.DataSetName = "PlayItAgainSportsDataSet";
            this.playItAgainSportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // updateInventory
            // 
            this.updateInventory.Location = new System.Drawing.Point(6, 370);
            this.updateInventory.Name = "updateInventory";
            this.updateInventory.Size = new System.Drawing.Size(638, 23);
            this.updateInventory.TabIndex = 0;
            this.updateInventory.Text = "Update";
            this.updateInventory.UseVisualStyleBackColor = true;
            this.updateInventory.Click += new System.EventHandler(this.button1_Click);
            // 
            // employeeTab
            // 
            this.employeeTab.Controls.Add(this.updateEmployees);
            this.employeeTab.Controls.Add(this.dataGridView2);
            this.employeeTab.Location = new System.Drawing.Point(4, 22);
            this.employeeTab.Name = "employeeTab";
            this.employeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.employeeTab.Size = new System.Drawing.Size(652, 399);
            this.employeeTab.TabIndex = 1;
            this.employeeTab.Text = "Employees";
            this.employeeTab.UseVisualStyleBackColor = true;
            // 
            // updateEmployees
            // 
            this.updateEmployees.Location = new System.Drawing.Point(8, 370);
            this.updateEmployees.Name = "updateEmployees";
            this.updateEmployees.Size = new System.Drawing.Size(641, 23);
            this.updateEmployees.TabIndex = 1;
            this.updateEmployees.Text = "Update";
            this.updateEmployees.UseVisualStyleBackColor = true;
            this.updateEmployees.Click += new System.EventHandler(this.updateEmployees_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.personIDDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.hireDateDataGridViewTextBoxColumn,
            this.terminationDateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.employeeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(643, 358);
            this.dataGridView2.TabIndex = 0;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personIDDataGridViewTextBoxColumn
            // 
            this.personIDDataGridViewTextBoxColumn.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn.HeaderText = "PersonID";
            this.personIDDataGridViewTextBoxColumn.Name = "personIDDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // hireDateDataGridViewTextBoxColumn
            // 
            this.hireDateDataGridViewTextBoxColumn.DataPropertyName = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.HeaderText = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.Name = "hireDateDataGridViewTextBoxColumn";
            // 
            // terminationDateDataGridViewTextBoxColumn
            // 
            this.terminationDateDataGridViewTextBoxColumn.DataPropertyName = "TerminationDate";
            this.terminationDateDataGridViewTextBoxColumn.HeaderText = "TerminationDate";
            this.terminationDateDataGridViewTextBoxColumn.Name = "terminationDateDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.playItAgainSportsDataSetBindingSource;
            // 
            // transactionsTab
            // 
            this.transactionsTab.Controls.Add(this.updateTransaction);
            this.transactionsTab.Controls.Add(this.dataGridView4);
            this.transactionsTab.Location = new System.Drawing.Point(4, 22);
            this.transactionsTab.Name = "transactionsTab";
            this.transactionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.transactionsTab.Size = new System.Drawing.Size(652, 399);
            this.transactionsTab.TabIndex = 2;
            this.transactionsTab.Text = "Transactions";
            this.transactionsTab.UseVisualStyleBackColor = true;
            // 
            // updateTransaction
            // 
            this.updateTransaction.Location = new System.Drawing.Point(6, 370);
            this.updateTransaction.Name = "updateTransaction";
            this.updateTransaction.Size = new System.Drawing.Size(638, 23);
            this.updateTransaction.TabIndex = 1;
            this.updateTransaction.Text = "Update";
            this.updateTransaction.UseVisualStyleBackColor = true;
            this.updateTransaction.Click += new System.EventHandler(this.updateTransaction_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIDDataGridViewTextBoxColumn,
            this.sKUDataGridViewTextBoxColumn1,
            this.employeeIDDataGridViewTextBoxColumn1,
            this.rewardsIDDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.transactionsBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(6, 6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(638, 358);
            this.dataGridView4.TabIndex = 0;
            // 
            // transactionIDDataGridViewTextBoxColumn
            // 
            this.transactionIDDataGridViewTextBoxColumn.DataPropertyName = "TransactionID";
            this.transactionIDDataGridViewTextBoxColumn.HeaderText = "TransactionID";
            this.transactionIDDataGridViewTextBoxColumn.Name = "transactionIDDataGridViewTextBoxColumn";
            this.transactionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sKUDataGridViewTextBoxColumn1
            // 
            this.sKUDataGridViewTextBoxColumn1.DataPropertyName = "SKU";
            this.sKUDataGridViewTextBoxColumn1.HeaderText = "SKU";
            this.sKUDataGridViewTextBoxColumn1.Name = "sKUDataGridViewTextBoxColumn1";
            // 
            // employeeIDDataGridViewTextBoxColumn1
            // 
            this.employeeIDDataGridViewTextBoxColumn1.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn1.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn1.Name = "employeeIDDataGridViewTextBoxColumn1";
            // 
            // rewardsIDDataGridViewTextBoxColumn
            // 
            this.rewardsIDDataGridViewTextBoxColumn.DataPropertyName = "RewardsID";
            this.rewardsIDDataGridViewTextBoxColumn.HeaderText = "RewardsID";
            this.rewardsIDDataGridViewTextBoxColumn.Name = "rewardsIDDataGridViewTextBoxColumn";
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.playItAgainSportsDataSetBindingSource;
            // 
            // rewardsTab
            // 
            this.rewardsTab.Controls.Add(this.updateRewards);
            this.rewardsTab.Controls.Add(this.dataGridView5);
            this.rewardsTab.Location = new System.Drawing.Point(4, 22);
            this.rewardsTab.Name = "rewardsTab";
            this.rewardsTab.Padding = new System.Windows.Forms.Padding(3);
            this.rewardsTab.Size = new System.Drawing.Size(652, 399);
            this.rewardsTab.TabIndex = 3;
            this.rewardsTab.Text = "Rewards";
            this.rewardsTab.UseVisualStyleBackColor = true;
            // 
            // updateRewards
            // 
            this.updateRewards.Location = new System.Drawing.Point(7, 370);
            this.updateRewards.Name = "updateRewards";
            this.updateRewards.Size = new System.Drawing.Size(637, 23);
            this.updateRewards.TabIndex = 1;
            this.updateRewards.Text = "Update";
            this.updateRewards.UseVisualStyleBackColor = true;
            this.updateRewards.Click += new System.EventHandler(this.updateRewards_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rewardsIDDataGridViewTextBoxColumn1,
            this.personIDDataGridViewTextBoxColumn2,
            this.rewardsPointsDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.rewardsBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(7, 7);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(637, 357);
            this.dataGridView5.TabIndex = 0;
            // 
            // rewardsIDDataGridViewTextBoxColumn1
            // 
            this.rewardsIDDataGridViewTextBoxColumn1.DataPropertyName = "RewardsID";
            this.rewardsIDDataGridViewTextBoxColumn1.HeaderText = "RewardsID";
            this.rewardsIDDataGridViewTextBoxColumn1.Name = "rewardsIDDataGridViewTextBoxColumn1";
            this.rewardsIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // personIDDataGridViewTextBoxColumn2
            // 
            this.personIDDataGridViewTextBoxColumn2.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn2.HeaderText = "PersonID";
            this.personIDDataGridViewTextBoxColumn2.Name = "personIDDataGridViewTextBoxColumn2";
            // 
            // rewardsPointsDataGridViewTextBoxColumn
            // 
            this.rewardsPointsDataGridViewTextBoxColumn.DataPropertyName = "RewardsPoints";
            this.rewardsPointsDataGridViewTextBoxColumn.HeaderText = "RewardsPoints";
            this.rewardsPointsDataGridViewTextBoxColumn.Name = "rewardsPointsDataGridViewTextBoxColumn";
            // 
            // rewardsBindingSource
            // 
            this.rewardsBindingSource.DataMember = "Rewards";
            this.rewardsBindingSource.DataSource = this.playItAgainSportsDataSetBindingSource;
            // 
            // personTab
            // 
            this.personTab.Controls.Add(this.updatePerson);
            this.personTab.Controls.Add(this.dataGridView3);
            this.personTab.Location = new System.Drawing.Point(4, 22);
            this.personTab.Name = "personTab";
            this.personTab.Padding = new System.Windows.Forms.Padding(3);
            this.personTab.Size = new System.Drawing.Size(652, 399);
            this.personTab.TabIndex = 4;
            this.personTab.Text = "Person";
            this.personTab.UseVisualStyleBackColor = true;
            // 
            // updatePerson
            // 
            this.updatePerson.Location = new System.Drawing.Point(6, 370);
            this.updatePerson.Name = "updatePerson";
            this.updatePerson.Size = new System.Drawing.Size(638, 23);
            this.updatePerson.TabIndex = 1;
            this.updatePerson.Text = "Update";
            this.updatePerson.UseVisualStyleBackColor = true;
            this.updatePerson.Click += new System.EventHandler(this.updatePerson_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personIDDataGridViewTextBoxColumn1,
            this.userNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.personBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(640, 358);
            this.dataGridView3.TabIndex = 0;
            // 
            // personIDDataGridViewTextBoxColumn1
            // 
            this.personIDDataGridViewTextBoxColumn1.DataPropertyName = "PersonID";
            this.personIDDataGridViewTextBoxColumn1.HeaderText = "PersonID";
            this.personIDDataGridViewTextBoxColumn1.Name = "personIDDataGridViewTextBoxColumn1";
            this.personIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.playItAgainSportsDataSetBindingSource;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.playItAgainSportsDataSetBindingSource;
            // 
            // playItAgainSportsDataSet1
            // 
            this.playItAgainSportsDataSet1.DataSetName = "PlayItAgainSportsDataSet1";
            this.playItAgainSportsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playItAgainSportsDataSet1BindingSource
            // 
            this.playItAgainSportsDataSet1BindingSource.DataSource = this.playItAgainSportsDataSet1;
            this.playItAgainSportsDataSet1BindingSource.Position = 0;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // rewardsTableAdapter
            // 
            this.rewardsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.tabControls);
            this.Name = "Form1";
            this.Text = "Play it Again Sports";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControls.ResumeLayout(false);
            this.inventoryTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playItAgainSportsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playItAgainSportsDataSet)).EndInit();
            this.employeeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.transactionsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            this.rewardsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewardsBindingSource)).EndInit();
            this.personTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playItAgainSportsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playItAgainSportsDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControls;
        private System.Windows.Forms.TabPage inventoryTab;
        private System.Windows.Forms.TabPage employeeTab;
        private System.Windows.Forms.TabPage transactionsTab;
        private System.Windows.Forms.TabPage rewardsTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updateInventory;
        private System.Windows.Forms.BindingSource playItAgainSportsDataSetBindingSource;
        private PlayItAgainSportsDataSet playItAgainSportsDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private PlayItAgainSportsDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private PlayItAgainSportsDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Button updateEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private System.Windows.Forms.BindingSource playItAgainSportsDataSet1BindingSource;
        private PlayItAgainSportsDataSet1 playItAgainSportsDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage personTab;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource personBindingSource;
        private PlayItAgainSportsDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.Button updatePerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private PlayItAgainSportsDataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.Button updateTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKUDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingSource rewardsBindingSource;
        private PlayItAgainSportsDataSetTableAdapters.RewardsTableAdapter rewardsTableAdapter;
        private System.Windows.Forms.Button updateRewards;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardsIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardsPointsDataGridViewTextBoxColumn;
    }
}

