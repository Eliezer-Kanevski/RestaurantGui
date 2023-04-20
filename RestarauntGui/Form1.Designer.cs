namespace RestarauntGui
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
            this.ItemNumberTxtBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.masterDataSet = new RestarauntGui.masterDataSet();
            this.customerLoginBox = new System.Windows.Forms.GroupBox();
            this.welcomeMessageLable = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.welcomeMessage = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.customerPassword = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.customerUsername = new System.Windows.Forms.TextBox();
            this.balanceAmount = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.GroupBox();
            this.PayActionButton = new System.Windows.Forms.Button();
            this.EnterAmountTxtBx = new System.Windows.Forms.TextBox();
            this.EnterAmountLabel = new System.Windows.Forms.Label();
            this.payBalanceButton = new System.Windows.Forms.Button();
            this.yourBalanceLbl = new System.Windows.Forms.Label();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.ItemQuantityTxtBx = new System.Windows.Forms.TextBox();
            this.ItemNumberLbl = new System.Windows.Forms.Label();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.AddItemAction = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iTEMIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iTEMTableAdapter = new RestarauntGui.masterDataSetTableAdapters.ITEMTableAdapter();
            this.PlaceOrderButton = new System.Windows.Forms.Button();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.ViewAllOrdersListView = new System.Windows.Forms.ListView();
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaymentStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViewAllOrdersButton = new System.Windows.Forms.Button();
            this.ExitViewOrdersButton = new System.Windows.Forms.Button();
            this.ViewOrdersInCostRangeButton = new System.Windows.Forms.Button();
            this.MaxCostLbl = new System.Windows.Forms.Label();
            this.MinCostLbl = new System.Windows.Forms.Label();
            this.MaxCostTxtBox = new System.Windows.Forms.TextBox();
            this.MinCostTxtBox = new System.Windows.Forms.TextBox();
            this.EnterViewOrdersInRangeButton = new System.Windows.Forms.Button();
            this.ViewOrdersInRangeListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExitViewInRangeButton = new System.Windows.Forms.Button();
            this.OrdersInDateRangeButton = new System.Windows.Forms.Button();
            this.StartDateTxtBox = new System.Windows.Forms.TextBox();
            this.EndDateTxtBox = new System.Windows.Forms.TextBox();
            this.StartDateLbl = new System.Windows.Forms.Label();
            this.EndDateLbl = new System.Windows.Forms.Label();
            this.ExitViewOrderDateRangeButton = new System.Windows.Forms.Button();
            this.ViewOrderDateRangeButton = new System.Windows.Forms.Button();
            this.ViewOrdersInDateRangeListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            this.customerLoginBox.SuspendLayout();
            this.Balance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemNumberTxtBox
            // 
            this.ItemNumberTxtBox.Location = new System.Drawing.Point(388, 38);
            this.ItemNumberTxtBox.Name = "ItemNumberTxtBox";
            this.ItemNumberTxtBox.Size = new System.Drawing.Size(92, 20);
            this.ItemNumberTxtBox.TabIndex = 0;
            this.ItemNumberTxtBox.Visible = false;
            this.ItemNumberTxtBox.WordWrap = false;
            this.ItemNumberTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerLoginBox
            // 
            this.customerLoginBox.Controls.Add(this.welcomeMessageLable);
            this.customerLoginBox.Controls.Add(this.logoutButton);
            this.customerLoginBox.Controls.Add(this.welcomeMessage);
            this.customerLoginBox.Controls.Add(this.loginButton);
            this.customerLoginBox.Controls.Add(this.customerPassword);
            this.customerLoginBox.Controls.Add(this.textBox4);
            this.customerLoginBox.Controls.Add(this.textBox3);
            this.customerLoginBox.Controls.Add(this.customerUsername);
            this.customerLoginBox.Location = new System.Drawing.Point(12, 12);
            this.customerLoginBox.Name = "customerLoginBox";
            this.customerLoginBox.Size = new System.Drawing.Size(182, 155);
            this.customerLoginBox.TabIndex = 9;
            this.customerLoginBox.TabStop = false;
            this.customerLoginBox.Text = "Customer login";
            this.customerLoginBox.Enter += new System.EventHandler(this.customerLoginBox_Enter);
            // 
            // welcomeMessageLable
            // 
            this.welcomeMessageLable.AutoSize = true;
            this.welcomeMessageLable.Location = new System.Drawing.Point(15, 118);
            this.welcomeMessageLable.Name = "welcomeMessageLable";
            this.welcomeMessageLable.Size = new System.Drawing.Size(55, 13);
            this.welcomeMessageLable.TabIndex = 19;
            this.welcomeMessageLable.Text = "Welcome ";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.logoutButton.Location = new System.Drawing.Point(92, 76);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(48, 23);
            this.logoutButton.TabIndex = 15;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // welcomeMessage
            // 
            this.welcomeMessage.AutoSize = true;
            this.welcomeMessage.Location = new System.Drawing.Point(15, 131);
            this.welcomeMessage.Name = "welcomeMessage";
            this.welcomeMessage.Size = new System.Drawing.Size(0, 13);
            this.welcomeMessage.TabIndex = 18;
            // 
            // loginButton
            // 
            this.loginButton.AccessibleName = "loginButton";
            this.loginButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.loginButton.Location = new System.Drawing.Point(18, 76);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(48, 23);
            this.loginButton.TabIndex = 13;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // customerPassword
            // 
            this.customerPassword.Location = new System.Drawing.Point(80, 39);
            this.customerPassword.Name = "customerPassword";
            this.customerPassword.Size = new System.Drawing.Size(85, 20);
            this.customerPassword.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox4.Location = new System.Drawing.Point(18, 39);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(56, 13);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "Password:";
            this.textBox4.UseWaitCursor = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox3.Location = new System.Drawing.Point(18, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(56, 13);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "Username:";
            this.textBox3.UseWaitCursor = true;
            // 
            // customerUsername
            // 
            this.customerUsername.Location = new System.Drawing.Point(80, 17);
            this.customerUsername.Name = "customerUsername";
            this.customerUsername.Size = new System.Drawing.Size(85, 20);
            this.customerUsername.TabIndex = 9;
            // 
            // balanceAmount
            // 
            this.balanceAmount.AutoSize = true;
            this.balanceAmount.Location = new System.Drawing.Point(89, 31);
            this.balanceAmount.Name = "balanceAmount";
            this.balanceAmount.Size = new System.Drawing.Size(34, 13);
            this.balanceAmount.TabIndex = 19;
            this.balanceAmount.Text = "$0.00";
            this.balanceAmount.Click += new System.EventHandler(this.balanceAmount_Click);
            // 
            // Balance
            // 
            this.Balance.Controls.Add(this.PayActionButton);
            this.Balance.Controls.Add(this.EnterAmountTxtBx);
            this.Balance.Controls.Add(this.EnterAmountLabel);
            this.Balance.Controls.Add(this.payBalanceButton);
            this.Balance.Controls.Add(this.yourBalanceLbl);
            this.Balance.Controls.Add(this.balanceAmount);
            this.Balance.Location = new System.Drawing.Point(12, 192);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(182, 144);
            this.Balance.TabIndex = 20;
            this.Balance.TabStop = false;
            this.Balance.Text = "Customer Balance";
            this.Balance.Enter += new System.EventHandler(this.Balance_Enter);
            // 
            // PayActionButton
            // 
            this.PayActionButton.BackColor = System.Drawing.Color.LimeGreen;
            this.PayActionButton.Location = new System.Drawing.Point(27, 119);
            this.PayActionButton.Name = "PayActionButton";
            this.PayActionButton.Size = new System.Drawing.Size(101, 24);
            this.PayActionButton.TabIndex = 24;
            this.PayActionButton.Text = "Pay";
            this.PayActionButton.UseVisualStyleBackColor = false;
            this.PayActionButton.Visible = false;
            this.PayActionButton.Click += new System.EventHandler(this.PayActionButton_Click);
            // 
            // EnterAmountTxtBx
            // 
            this.EnterAmountTxtBx.Location = new System.Drawing.Point(120, 94);
            this.EnterAmountTxtBx.Name = "EnterAmountTxtBx";
            this.EnterAmountTxtBx.Size = new System.Drawing.Size(56, 20);
            this.EnterAmountTxtBx.TabIndex = 23;
            this.EnterAmountTxtBx.Visible = false;
            // 
            // EnterAmountLabel
            // 
            this.EnterAmountLabel.AutoSize = true;
            this.EnterAmountLabel.Location = new System.Drawing.Point(15, 97);
            this.EnterAmountLabel.Name = "EnterAmountLabel";
            this.EnterAmountLabel.Size = new System.Drawing.Size(102, 13);
            this.EnterAmountLabel.TabIndex = 22;
            this.EnterAmountLabel.Text = "Enter amount to pay";
            this.EnterAmountLabel.Visible = false;
            this.EnterAmountLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // payBalanceButton
            // 
            this.payBalanceButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.payBalanceButton.Location = new System.Drawing.Point(18, 61);
            this.payBalanceButton.Name = "payBalanceButton";
            this.payBalanceButton.Size = new System.Drawing.Size(96, 33);
            this.payBalanceButton.TabIndex = 21;
            this.payBalanceButton.Text = "Make a payment";
            this.payBalanceButton.UseVisualStyleBackColor = false;
            this.payBalanceButton.Click += new System.EventHandler(this.payBalanceButton_Click);
            // 
            // yourBalanceLbl
            // 
            this.yourBalanceLbl.AutoSize = true;
            this.yourBalanceLbl.Location = new System.Drawing.Point(15, 31);
            this.yourBalanceLbl.Name = "yourBalanceLbl";
            this.yourBalanceLbl.Size = new System.Drawing.Size(73, 13);
            this.yourBalanceLbl.TabIndex = 20;
            this.yourBalanceLbl.Text = "Your balance:";
            this.yourBalanceLbl.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // AddItemButton
            // 
            this.AddItemButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddItemButton.Location = new System.Drawing.Point(250, 30);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(104, 34);
            this.AddItemButton.TabIndex = 21;
            this.AddItemButton.Text = "Click to add item to order";
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Visible = false;
            this.AddItemButton.Click += new System.EventHandler(this.addItemBotton);
            // 
            // ItemQuantityTxtBx
            // 
            this.ItemQuantityTxtBx.Location = new System.Drawing.Point(507, 38);
            this.ItemQuantityTxtBx.Name = "ItemQuantityTxtBx";
            this.ItemQuantityTxtBx.Size = new System.Drawing.Size(71, 20);
            this.ItemQuantityTxtBx.TabIndex = 22;
            this.ItemQuantityTxtBx.Visible = false;
            this.ItemQuantityTxtBx.WordWrap = false;
            this.ItemQuantityTxtBx.TextChanged += new System.EventHandler(this.ItemQuantityTxtBx_TextChanged);
            // 
            // ItemNumberLbl
            // 
            this.ItemNumberLbl.AutoSize = true;
            this.ItemNumberLbl.Location = new System.Drawing.Point(385, 12);
            this.ItemNumberLbl.Name = "ItemNumberLbl";
            this.ItemNumberLbl.Size = new System.Drawing.Size(95, 13);
            this.ItemNumberLbl.TabIndex = 23;
            this.ItemNumberLbl.Text = "Enter Item Number";
            this.ItemNumberLbl.Visible = false;
            this.ItemNumberLbl.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Location = new System.Drawing.Point(504, 12);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(74, 13);
            this.QuantityLbl.TabIndex = 24;
            this.QuantityLbl.Text = "Enter Quantity";
            this.QuantityLbl.Visible = false;
            // 
            // AddItemAction
            // 
            this.AddItemAction.BackColor = System.Drawing.Color.Bisque;
            this.AddItemAction.Location = new System.Drawing.Point(603, 32);
            this.AddItemAction.Name = "AddItemAction";
            this.AddItemAction.Size = new System.Drawing.Size(76, 32);
            this.AddItemAction.TabIndex = 25;
            this.AddItemAction.Text = "Add";
            this.AddItemAction.UseVisualStyleBackColor = false;
            this.AddItemAction.Visible = false;
            this.AddItemAction.Click += new System.EventHandler(this.AddItemAction_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iTEMIDDataGridViewTextBoxColumn,
            this.iNAMEDataGridViewTextBoxColumn,
            this.iDESCRIPTIONDataGridViewTextBoxColumn,
            this.iPRICEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.iTEMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(253, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(426, 336);
            this.dataGridView1.TabIndex = 27;
            // 
            // iTEMIDDataGridViewTextBoxColumn
            // 
            this.iTEMIDDataGridViewTextBoxColumn.DataPropertyName = "ITEM_ID";
            this.iTEMIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iTEMIDDataGridViewTextBoxColumn.Name = "iTEMIDDataGridViewTextBoxColumn";
            // 
            // iNAMEDataGridViewTextBoxColumn
            // 
            this.iNAMEDataGridViewTextBoxColumn.DataPropertyName = "I_NAME";
            this.iNAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.iNAMEDataGridViewTextBoxColumn.Name = "iNAMEDataGridViewTextBoxColumn";
            // 
            // iDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.iDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "I_DESCRIPTION";
            this.iDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            this.iDESCRIPTIONDataGridViewTextBoxColumn.Name = "iDESCRIPTIONDataGridViewTextBoxColumn";
            // 
            // iPRICEDataGridViewTextBoxColumn
            // 
            this.iPRICEDataGridViewTextBoxColumn.DataPropertyName = "I_PRICE";
            this.iPRICEDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.iPRICEDataGridViewTextBoxColumn.Name = "iPRICEDataGridViewTextBoxColumn";
            // 
            // iTEMBindingSource
            // 
            this.iTEMBindingSource.DataMember = "ITEM";
            this.iTEMBindingSource.DataSource = this.masterDataSet;
            // 
            // iTEMTableAdapter
            // 
            this.iTEMTableAdapter.ClearBeforeFill = true;
            // 
            // PlaceOrderButton
            // 
            this.PlaceOrderButton.Location = new System.Drawing.Point(702, 32);
            this.PlaceOrderButton.Name = "PlaceOrderButton";
            this.PlaceOrderButton.Size = new System.Drawing.Size(74, 31);
            this.PlaceOrderButton.TabIndex = 28;
            this.PlaceOrderButton.Text = "Place order";
            this.PlaceOrderButton.UseVisualStyleBackColor = true;
            this.PlaceOrderButton.Visible = false;
            this.PlaceOrderButton.Click += new System.EventHandler(this.PlaceOrderButton_Click);
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Location = new System.Drawing.Point(782, 32);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(75, 32);
            this.ClearCartButton.TabIndex = 29;
            this.ClearCartButton.Text = "Clear cart";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            this.ClearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // ViewAllOrdersListView
            // 
            this.ViewAllOrdersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Number,
            this.Date,
            this.OrderStatus,
            this.PaymentStatus,
            this.Total});
            this.ViewAllOrdersListView.HideSelection = false;
            this.ViewAllOrdersListView.Location = new System.Drawing.Point(253, 102);
            this.ViewAllOrdersListView.Name = "ViewAllOrdersListView";
            this.ViewAllOrdersListView.Size = new System.Drawing.Size(426, 336);
            this.ViewAllOrdersListView.TabIndex = 30;
            this.ViewAllOrdersListView.UseCompatibleStateImageBehavior = false;
            this.ViewAllOrdersListView.View = System.Windows.Forms.View.Details;
            this.ViewAllOrdersListView.Visible = false;
            this.ViewAllOrdersListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Number
            // 
            this.Number.Text = "Number";
            this.Number.Width = 71;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 70;
            // 
            // OrderStatus
            // 
            this.OrderStatus.Text = "Order status";
            this.OrderStatus.Width = 80;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.Text = "Payment Status";
            this.PaymentStatus.Width = 95;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            // 
            // ViewAllOrdersButton
            // 
            this.ViewAllOrdersButton.Location = new System.Drawing.Point(702, 102);
            this.ViewAllOrdersButton.Name = "ViewAllOrdersButton";
            this.ViewAllOrdersButton.Size = new System.Drawing.Size(75, 23);
            this.ViewAllOrdersButton.TabIndex = 31;
            this.ViewAllOrdersButton.Text = "View orders";
            this.ViewAllOrdersButton.UseVisualStyleBackColor = true;
            this.ViewAllOrdersButton.Visible = false;
            this.ViewAllOrdersButton.Click += new System.EventHandler(this.ViewAllOrdersButton_Click);
            // 
            // ExitViewOrdersButton
            // 
            this.ExitViewOrdersButton.Location = new System.Drawing.Point(792, 102);
            this.ExitViewOrdersButton.Name = "ExitViewOrdersButton";
            this.ExitViewOrdersButton.Size = new System.Drawing.Size(75, 23);
            this.ExitViewOrdersButton.TabIndex = 32;
            this.ExitViewOrdersButton.Text = "Exit view";
            this.ExitViewOrdersButton.UseVisualStyleBackColor = true;
            this.ExitViewOrdersButton.Visible = false;
            this.ExitViewOrdersButton.Click += new System.EventHandler(this.ExitViewOrdersButton_Click);
            // 
            // ViewOrdersInCostRangeButton
            // 
            this.ViewOrdersInCostRangeButton.Location = new System.Drawing.Point(702, 169);
            this.ViewOrdersInCostRangeButton.Name = "ViewOrdersInCostRangeButton";
            this.ViewOrdersInCostRangeButton.Size = new System.Drawing.Size(165, 29);
            this.ViewOrdersInCostRangeButton.TabIndex = 33;
            this.ViewOrdersInCostRangeButton.Text = "My orders in cost range";
            this.ViewOrdersInCostRangeButton.UseVisualStyleBackColor = true;
            this.ViewOrdersInCostRangeButton.Visible = false;
            this.ViewOrdersInCostRangeButton.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // MaxCostLbl
            // 
            this.MaxCostLbl.AutoSize = true;
            this.MaxCostLbl.Location = new System.Drawing.Point(793, 211);
            this.MaxCostLbl.Name = "MaxCostLbl";
            this.MaxCostLbl.Size = new System.Drawing.Size(74, 13);
            this.MaxCostLbl.TabIndex = 37;
            this.MaxCostLbl.Text = "Maximum cost";
            this.MaxCostLbl.Visible = false;
            this.MaxCostLbl.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // MinCostLbl
            // 
            this.MinCostLbl.AutoSize = true;
            this.MinCostLbl.Location = new System.Drawing.Point(699, 211);
            this.MinCostLbl.Name = "MinCostLbl";
            this.MinCostLbl.Size = new System.Drawing.Size(71, 13);
            this.MinCostLbl.TabIndex = 36;
            this.MinCostLbl.Text = "Minimum cost";
            this.MinCostLbl.Visible = false;
            this.MinCostLbl.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // MaxCostTxtBox
            // 
            this.MaxCostTxtBox.Location = new System.Drawing.Point(796, 227);
            this.MaxCostTxtBox.Name = "MaxCostTxtBox";
            this.MaxCostTxtBox.Size = new System.Drawing.Size(71, 20);
            this.MaxCostTxtBox.TabIndex = 35;
            this.MaxCostTxtBox.Visible = false;
            this.MaxCostTxtBox.WordWrap = false;
            this.MaxCostTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // MinCostTxtBox
            // 
            this.MinCostTxtBox.Location = new System.Drawing.Point(702, 227);
            this.MinCostTxtBox.Name = "MinCostTxtBox";
            this.MinCostTxtBox.Size = new System.Drawing.Size(68, 20);
            this.MinCostTxtBox.TabIndex = 34;
            this.MinCostTxtBox.Visible = false;
            this.MinCostTxtBox.WordWrap = false;
            this.MinCostTxtBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // EnterViewOrdersInRangeButton
            // 
            this.EnterViewOrdersInRangeButton.Location = new System.Drawing.Point(702, 263);
            this.EnterViewOrdersInRangeButton.Name = "EnterViewOrdersInRangeButton";
            this.EnterViewOrdersInRangeButton.Size = new System.Drawing.Size(68, 23);
            this.EnterViewOrdersInRangeButton.TabIndex = 38;
            this.EnterViewOrdersInRangeButton.Text = "Enter";
            this.EnterViewOrdersInRangeButton.UseVisualStyleBackColor = true;
            this.EnterViewOrdersInRangeButton.Visible = false;
            this.EnterViewOrdersInRangeButton.Click += new System.EventHandler(this.EnterViewOrdersInRangeButton_Click);
            // 
            // ViewOrdersInRangeListView
            // 
            this.ViewOrdersInRangeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ViewOrdersInRangeListView.HideSelection = false;
            this.ViewOrdersInRangeListView.Location = new System.Drawing.Point(253, 102);
            this.ViewOrdersInRangeListView.Name = "ViewOrdersInRangeListView";
            this.ViewOrdersInRangeListView.Size = new System.Drawing.Size(426, 336);
            this.ViewOrdersInRangeListView.TabIndex = 39;
            this.ViewOrdersInRangeListView.UseCompatibleStateImageBehavior = false;
            this.ViewOrdersInRangeListView.View = System.Windows.Forms.View.Details;
            this.ViewOrdersInRangeListView.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Number";
            this.columnHeader1.Width = 71;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Order status";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Payment Status";
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total";
            // 
            // ExitViewInRangeButton
            // 
            this.ExitViewInRangeButton.Location = new System.Drawing.Point(792, 263);
            this.ExitViewInRangeButton.Name = "ExitViewInRangeButton";
            this.ExitViewInRangeButton.Size = new System.Drawing.Size(75, 23);
            this.ExitViewInRangeButton.TabIndex = 40;
            this.ExitViewInRangeButton.Text = "Exit view";
            this.ExitViewInRangeButton.UseVisualStyleBackColor = true;
            this.ExitViewInRangeButton.Visible = false;
            this.ExitViewInRangeButton.Click += new System.EventHandler(this.ExitViewInRangeButton_Click);
            // 
            // OrdersInDateRangeButton
            // 
            this.OrdersInDateRangeButton.Location = new System.Drawing.Point(702, 320);
            this.OrdersInDateRangeButton.Name = "OrdersInDateRangeButton";
            this.OrdersInDateRangeButton.Size = new System.Drawing.Size(164, 30);
            this.OrdersInDateRangeButton.TabIndex = 41;
            this.OrdersInDateRangeButton.Text = "My orders in date range";
            this.OrdersInDateRangeButton.UseVisualStyleBackColor = true;
            this.OrdersInDateRangeButton.Visible = false;
            this.OrdersInDateRangeButton.Click += new System.EventHandler(this.OrdersInDateRangeButton_Click);
            // 
            // StartDateTxtBox
            // 
            this.StartDateTxtBox.Location = new System.Drawing.Point(702, 387);
            this.StartDateTxtBox.Name = "StartDateTxtBox";
            this.StartDateTxtBox.Size = new System.Drawing.Size(68, 20);
            this.StartDateTxtBox.TabIndex = 42;
            this.StartDateTxtBox.Visible = false;
            // 
            // EndDateTxtBox
            // 
            this.EndDateTxtBox.Location = new System.Drawing.Point(796, 387);
            this.EndDateTxtBox.Name = "EndDateTxtBox";
            this.EndDateTxtBox.Size = new System.Drawing.Size(71, 20);
            this.EndDateTxtBox.TabIndex = 43;
            this.EndDateTxtBox.Visible = false;
            // 
            // StartDateLbl
            // 
            this.StartDateLbl.AutoSize = true;
            this.StartDateLbl.Location = new System.Drawing.Point(702, 368);
            this.StartDateLbl.Name = "StartDateLbl";
            this.StartDateLbl.Size = new System.Drawing.Size(53, 13);
            this.StartDateLbl.TabIndex = 44;
            this.StartDateLbl.Text = "Start date";
            this.StartDateLbl.Visible = false;
            // 
            // EndDateLbl
            // 
            this.EndDateLbl.AutoSize = true;
            this.EndDateLbl.Location = new System.Drawing.Point(796, 368);
            this.EndDateLbl.Name = "EndDateLbl";
            this.EndDateLbl.Size = new System.Drawing.Size(50, 13);
            this.EndDateLbl.TabIndex = 45;
            this.EndDateLbl.Text = "End date";
            this.EndDateLbl.Visible = false;
            // 
            // ExitViewOrderDateRangeButton
            // 
            this.ExitViewOrderDateRangeButton.Location = new System.Drawing.Point(792, 415);
            this.ExitViewOrderDateRangeButton.Name = "ExitViewOrderDateRangeButton";
            this.ExitViewOrderDateRangeButton.Size = new System.Drawing.Size(75, 23);
            this.ExitViewOrderDateRangeButton.TabIndex = 47;
            this.ExitViewOrderDateRangeButton.Text = "Exit view";
            this.ExitViewOrderDateRangeButton.UseVisualStyleBackColor = true;
            this.ExitViewOrderDateRangeButton.Visible = false;
            this.ExitViewOrderDateRangeButton.Click += new System.EventHandler(this.ExitViewOrderDateRangeButton_Click);
            // 
            // ViewOrderDateRangeButton
            // 
            this.ViewOrderDateRangeButton.Location = new System.Drawing.Point(702, 415);
            this.ViewOrderDateRangeButton.Name = "ViewOrderDateRangeButton";
            this.ViewOrderDateRangeButton.Size = new System.Drawing.Size(68, 23);
            this.ViewOrderDateRangeButton.TabIndex = 46;
            this.ViewOrderDateRangeButton.Text = "Enter";
            this.ViewOrderDateRangeButton.UseVisualStyleBackColor = true;
            this.ViewOrderDateRangeButton.Visible = false;
            this.ViewOrderDateRangeButton.Click += new System.EventHandler(this.ViewOrderDateRangeButton_Click);
            // 
            // ViewOrdersInDateRangeListView
            // 
            this.ViewOrdersInDateRangeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.ViewOrdersInDateRangeListView.HideSelection = false;
            this.ViewOrdersInDateRangeListView.Location = new System.Drawing.Point(253, 102);
            this.ViewOrdersInDateRangeListView.Name = "ViewOrdersInDateRangeListView";
            this.ViewOrdersInDateRangeListView.Size = new System.Drawing.Size(426, 336);
            this.ViewOrdersInDateRangeListView.TabIndex = 48;
            this.ViewOrdersInDateRangeListView.UseCompatibleStateImageBehavior = false;
            this.ViewOrdersInDateRangeListView.View = System.Windows.Forms.View.Details;
            this.ViewOrdersInDateRangeListView.Visible = false;
            this.ViewOrdersInDateRangeListView.SelectedIndexChanged += new System.EventHandler(this.ViewOrdersInDateRangeListView1_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Number";
            this.columnHeader6.Width = 71;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Date";
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Order status";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Payment Status";
            this.columnHeader9.Width = 95;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(893, 508);
            this.Controls.Add(this.ViewOrdersInDateRangeListView);
            this.Controls.Add(this.ExitViewOrderDateRangeButton);
            this.Controls.Add(this.ViewOrderDateRangeButton);
            this.Controls.Add(this.EndDateLbl);
            this.Controls.Add(this.StartDateLbl);
            this.Controls.Add(this.EndDateTxtBox);
            this.Controls.Add(this.StartDateTxtBox);
            this.Controls.Add(this.OrdersInDateRangeButton);
            this.Controls.Add(this.ExitViewInRangeButton);
            this.Controls.Add(this.ViewOrdersInRangeListView);
            this.Controls.Add(this.EnterViewOrdersInRangeButton);
            this.Controls.Add(this.MaxCostLbl);
            this.Controls.Add(this.MinCostLbl);
            this.Controls.Add(this.MaxCostTxtBox);
            this.Controls.Add(this.MinCostTxtBox);
            this.Controls.Add(this.ViewOrdersInCostRangeButton);
            this.Controls.Add(this.ExitViewOrdersButton);
            this.Controls.Add(this.ViewAllOrdersButton);
            this.Controls.Add(this.ViewAllOrdersListView);
            this.Controls.Add(this.ClearCartButton);
            this.Controls.Add(this.PlaceOrderButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddItemAction);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.ItemNumberLbl);
            this.Controls.Add(this.ItemQuantityTxtBx);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.customerLoginBox);
            this.Controls.Add(this.ItemNumberTxtBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            this.Text = "Restaraunt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            this.customerLoginBox.ResumeLayout(false);
            this.customerLoginBox.PerformLayout();
            this.Balance.ResumeLayout(false);
            this.Balance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ItemNumberTxtBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.GroupBox customerLoginBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox customerPassword;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox customerUsername;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label welcomeMessage;
        private System.Windows.Forms.Label balanceAmount;
        private System.Windows.Forms.GroupBox Balance;
        private System.Windows.Forms.Label yourBalanceLbl;
        private System.Windows.Forms.Label welcomeMessageLable;
        private System.Windows.Forms.Label EnterAmountLabel;
        private System.Windows.Forms.Button payBalanceButton;
        private System.Windows.Forms.TextBox EnterAmountTxtBx;
        private System.Windows.Forms.Button PayActionButton;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.TextBox ItemQuantityTxtBx;
        private System.Windows.Forms.Label ItemNumberLbl;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.Button AddItemAction;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource iTEMBindingSource;
        private masterDataSetTableAdapters.ITEMTableAdapter iTEMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTEMIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button PlaceOrderButton;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.ListView ViewAllOrdersListView;
        private System.Windows.Forms.Button ViewAllOrdersButton;
        private System.Windows.Forms.Button ExitViewOrdersButton;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader OrderStatus;
        private System.Windows.Forms.ColumnHeader PaymentStatus;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Button ViewOrdersInCostRangeButton;
        private System.Windows.Forms.Label MaxCostLbl;
        private System.Windows.Forms.Label MinCostLbl;
        private System.Windows.Forms.TextBox MaxCostTxtBox;
        private System.Windows.Forms.TextBox MinCostTxtBox;
        private System.Windows.Forms.Button EnterViewOrdersInRangeButton;
        private System.Windows.Forms.ListView ViewOrdersInRangeListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button ExitViewInRangeButton;
        private System.Windows.Forms.Button OrdersInDateRangeButton;
        private System.Windows.Forms.TextBox StartDateTxtBox;
        private System.Windows.Forms.TextBox EndDateTxtBox;
        private System.Windows.Forms.Label StartDateLbl;
        private System.Windows.Forms.Label EndDateLbl;
        private System.Windows.Forms.Button ExitViewOrderDateRangeButton;
        private System.Windows.Forms.Button ViewOrderDateRangeButton;
        private System.Windows.Forms.ListView ViewOrdersInDateRangeListView;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}

