namespace DesignPatterns {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.grdSalesOrders = new System.Windows.Forms.DataGridView();
            this.salesOrderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revisionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onlineOrderFlagDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.salesOrderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseOrderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipToAddressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billToAddressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditCardApprovalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxAmtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowguidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRecordset = new DesignPatterns.Recordset();
            this.grdSalesOrderDetails = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.msFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.salesOrderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesOrderDetailIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowguidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSalesOrders = new System.Windows.Forms.BindingSource(this.components);
            this.bsSalesOrderDetails = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRecordset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesOrderDetails)).BeginInit();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSalesOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSalesOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSalesOrders
            // 
            this.grdSalesOrders.AutoGenerateColumns = false;
            this.grdSalesOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSalesOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesOrderIDDataGridViewTextBoxColumn,
            this.revisionNumberDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.shipDateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.onlineOrderFlagDataGridViewCheckBoxColumn,
            this.salesOrderNumberDataGridViewTextBoxColumn,
            this.purchaseOrderNumberDataGridViewTextBoxColumn,
            this.accountNumberDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.shipToAddressIDDataGridViewTextBoxColumn,
            this.billToAddressIDDataGridViewTextBoxColumn,
            this.shipMethodDataGridViewTextBoxColumn,
            this.creditCardApprovalCodeDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn,
            this.taxAmtDataGridViewTextBoxColumn,
            this.freightDataGridViewTextBoxColumn,
            this.totalDueDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.rowguidDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn});
            this.grdSalesOrders.DataMember = "SalesOrderTable";
            this.grdSalesOrders.DataSource = this.mRecordset;
            this.grdSalesOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSalesOrders.Location = new System.Drawing.Point(0, 24);
            this.grdSalesOrders.MultiSelect = false;
            this.grdSalesOrders.Name = "grdSalesOrders";
            this.grdSalesOrders.Size = new System.Drawing.Size(676, 280);
            this.grdSalesOrders.TabIndex = 0;
            this.grdSalesOrders.SelectionChanged += new System.EventHandler(this.OnSalesOrderSelected);
            // 
            // salesOrderIDDataGridViewTextBoxColumn
            // 
            this.salesOrderIDDataGridViewTextBoxColumn.DataPropertyName = "SalesOrderID";
            this.salesOrderIDDataGridViewTextBoxColumn.HeaderText = "SalesOrderID";
            this.salesOrderIDDataGridViewTextBoxColumn.Name = "salesOrderIDDataGridViewTextBoxColumn";
            this.salesOrderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // revisionNumberDataGridViewTextBoxColumn
            // 
            this.revisionNumberDataGridViewTextBoxColumn.DataPropertyName = "RevisionNumber";
            this.revisionNumberDataGridViewTextBoxColumn.HeaderText = "RevisionNumber";
            this.revisionNumberDataGridViewTextBoxColumn.Name = "revisionNumberDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            // 
            // shipDateDataGridViewTextBoxColumn
            // 
            this.shipDateDataGridViewTextBoxColumn.DataPropertyName = "ShipDate";
            this.shipDateDataGridViewTextBoxColumn.HeaderText = "ShipDate";
            this.shipDateDataGridViewTextBoxColumn.Name = "shipDateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // onlineOrderFlagDataGridViewCheckBoxColumn
            // 
            this.onlineOrderFlagDataGridViewCheckBoxColumn.DataPropertyName = "OnlineOrderFlag";
            this.onlineOrderFlagDataGridViewCheckBoxColumn.HeaderText = "OnlineOrderFlag";
            this.onlineOrderFlagDataGridViewCheckBoxColumn.Name = "onlineOrderFlagDataGridViewCheckBoxColumn";
            // 
            // salesOrderNumberDataGridViewTextBoxColumn
            // 
            this.salesOrderNumberDataGridViewTextBoxColumn.DataPropertyName = "SalesOrderNumber";
            this.salesOrderNumberDataGridViewTextBoxColumn.HeaderText = "SalesOrderNumber";
            this.salesOrderNumberDataGridViewTextBoxColumn.Name = "salesOrderNumberDataGridViewTextBoxColumn";
            // 
            // purchaseOrderNumberDataGridViewTextBoxColumn
            // 
            this.purchaseOrderNumberDataGridViewTextBoxColumn.DataPropertyName = "PurchaseOrderNumber";
            this.purchaseOrderNumberDataGridViewTextBoxColumn.HeaderText = "PurchaseOrderNumber";
            this.purchaseOrderNumberDataGridViewTextBoxColumn.Name = "purchaseOrderNumberDataGridViewTextBoxColumn";
            // 
            // accountNumberDataGridViewTextBoxColumn
            // 
            this.accountNumberDataGridViewTextBoxColumn.DataPropertyName = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.HeaderText = "AccountNumber";
            this.accountNumberDataGridViewTextBoxColumn.Name = "accountNumberDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // shipToAddressIDDataGridViewTextBoxColumn
            // 
            this.shipToAddressIDDataGridViewTextBoxColumn.DataPropertyName = "ShipToAddressID";
            this.shipToAddressIDDataGridViewTextBoxColumn.HeaderText = "ShipToAddressID";
            this.shipToAddressIDDataGridViewTextBoxColumn.Name = "shipToAddressIDDataGridViewTextBoxColumn";
            // 
            // billToAddressIDDataGridViewTextBoxColumn
            // 
            this.billToAddressIDDataGridViewTextBoxColumn.DataPropertyName = "BillToAddressID";
            this.billToAddressIDDataGridViewTextBoxColumn.HeaderText = "BillToAddressID";
            this.billToAddressIDDataGridViewTextBoxColumn.Name = "billToAddressIDDataGridViewTextBoxColumn";
            // 
            // shipMethodDataGridViewTextBoxColumn
            // 
            this.shipMethodDataGridViewTextBoxColumn.DataPropertyName = "ShipMethod";
            this.shipMethodDataGridViewTextBoxColumn.HeaderText = "ShipMethod";
            this.shipMethodDataGridViewTextBoxColumn.Name = "shipMethodDataGridViewTextBoxColumn";
            // 
            // creditCardApprovalCodeDataGridViewTextBoxColumn
            // 
            this.creditCardApprovalCodeDataGridViewTextBoxColumn.DataPropertyName = "CreditCardApprovalCode";
            this.creditCardApprovalCodeDataGridViewTextBoxColumn.HeaderText = "CreditCardApprovalCode";
            this.creditCardApprovalCodeDataGridViewTextBoxColumn.Name = "creditCardApprovalCodeDataGridViewTextBoxColumn";
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            // 
            // taxAmtDataGridViewTextBoxColumn
            // 
            this.taxAmtDataGridViewTextBoxColumn.DataPropertyName = "TaxAmt";
            this.taxAmtDataGridViewTextBoxColumn.HeaderText = "TaxAmt";
            this.taxAmtDataGridViewTextBoxColumn.Name = "taxAmtDataGridViewTextBoxColumn";
            // 
            // freightDataGridViewTextBoxColumn
            // 
            this.freightDataGridViewTextBoxColumn.DataPropertyName = "Freight";
            this.freightDataGridViewTextBoxColumn.HeaderText = "Freight";
            this.freightDataGridViewTextBoxColumn.Name = "freightDataGridViewTextBoxColumn";
            // 
            // totalDueDataGridViewTextBoxColumn
            // 
            this.totalDueDataGridViewTextBoxColumn.DataPropertyName = "TotalDue";
            this.totalDueDataGridViewTextBoxColumn.HeaderText = "TotalDue";
            this.totalDueDataGridViewTextBoxColumn.Name = "totalDueDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // rowguidDataGridViewTextBoxColumn
            // 
            this.rowguidDataGridViewTextBoxColumn.DataPropertyName = "rowguid";
            this.rowguidDataGridViewTextBoxColumn.HeaderText = "rowguid";
            this.rowguidDataGridViewTextBoxColumn.Name = "rowguidDataGridViewTextBoxColumn";
            this.rowguidDataGridViewTextBoxColumn.Visible = false;
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.HeaderText = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            this.modifiedDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // mRecordset
            // 
            this.mRecordset.DataSetName = "Recordset";
            this.mRecordset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdSalesOrderDetails
            // 
            this.grdSalesOrderDetails.AutoGenerateColumns = false;
            this.grdSalesOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSalesOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesOrderIDDataGridViewTextBoxColumn1,
            this.salesOrderDetailIDDataGridViewTextBoxColumn,
            this.orderQtyDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.unitPriceDiscountDataGridViewTextBoxColumn,
            this.lineTotalDataGridViewTextBoxColumn,
            this.rowguidDataGridViewTextBoxColumn1,
            this.modifiedDateDataGridViewTextBoxColumn1});
            this.grdSalesOrderDetails.DataMember = "SalesOrderDetailTable";
            this.grdSalesOrderDetails.DataSource = this.mRecordset;
            this.grdSalesOrderDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdSalesOrderDetails.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdSalesOrderDetails.Location = new System.Drawing.Point(0, 172);
            this.grdSalesOrderDetails.MultiSelect = false;
            this.grdSalesOrderDetails.Name = "grdSalesOrderDetails";
            this.grdSalesOrderDetails.Size = new System.Drawing.Size(676, 132);
            this.grdSalesOrderDetails.TabIndex = 1;
            this.grdSalesOrderDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellEndEdit);
            this.grdSalesOrderDetails.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellValueChanged);
            this.grdSalesOrderDetails.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.OnDefaultValuesNeeded);
            this.grdSalesOrderDetails.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnRowLeave);
            this.grdSalesOrderDetails.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.OnRowsAdded);
            this.grdSalesOrderDetails.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnRowValidated);
            this.grdSalesOrderDetails.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.OnRowValidating);
            this.grdSalesOrderDetails.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.OnUserAddedRow);
            this.grdSalesOrderDetails.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.OnUserDeletedRow);
            this.grdSalesOrderDetails.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.OnUserDeletingRow);
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 169);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(676, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFile,
            this.msHelp});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(676, 24);
            this.msMain.TabIndex = 3;
            this.msMain.Text = "menuStrip1";
            this.msMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnItemClicked);
            // 
            // msFile
            // 
            this.msFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFileExit});
            this.msFile.Name = "msFile";
            this.msFile.Size = new System.Drawing.Size(37, 20);
            this.msFile.Text = "&File";
            // 
            // msFileExit
            // 
            this.msFileExit.Name = "msFileExit";
            this.msFileExit.Size = new System.Drawing.Size(92, 22);
            this.msFileExit.Text = "E&xit";
            this.msFileExit.Click += new System.EventHandler(this.OnItemClicked);
            // 
            // msHelp
            // 
            this.msHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msHelpAbout});
            this.msHelp.Name = "msHelp";
            this.msHelp.Size = new System.Drawing.Size(44, 20);
            this.msHelp.Text = "&Help";
            // 
            // msHelpAbout
            // 
            this.msHelpAbout.Name = "msHelpAbout";
            this.msHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.msHelpAbout.Text = "&About";
            this.msHelpAbout.Click += new System.EventHandler(this.OnItemClicked);
            // 
            // salesOrderIDDataGridViewTextBoxColumn1
            // 
            this.salesOrderIDDataGridViewTextBoxColumn1.DataPropertyName = "SalesOrderID";
            this.salesOrderIDDataGridViewTextBoxColumn1.HeaderText = "SalesOrderID";
            this.salesOrderIDDataGridViewTextBoxColumn1.Name = "salesOrderIDDataGridViewTextBoxColumn1";
            this.salesOrderIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // salesOrderDetailIDDataGridViewTextBoxColumn
            // 
            this.salesOrderDetailIDDataGridViewTextBoxColumn.DataPropertyName = "SalesOrderDetailID";
            this.salesOrderDetailIDDataGridViewTextBoxColumn.HeaderText = "SalesOrderDetailID";
            this.salesOrderDetailIDDataGridViewTextBoxColumn.Name = "salesOrderDetailIDDataGridViewTextBoxColumn";
            this.salesOrderDetailIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderQtyDataGridViewTextBoxColumn
            // 
            this.orderQtyDataGridViewTextBoxColumn.DataPropertyName = "OrderQty";
            this.orderQtyDataGridViewTextBoxColumn.HeaderText = "OrderQty";
            this.orderQtyDataGridViewTextBoxColumn.Name = "orderQtyDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // unitPriceDiscountDataGridViewTextBoxColumn
            // 
            this.unitPriceDiscountDataGridViewTextBoxColumn.DataPropertyName = "UnitPriceDiscount";
            this.unitPriceDiscountDataGridViewTextBoxColumn.HeaderText = "UnitPriceDiscount";
            this.unitPriceDiscountDataGridViewTextBoxColumn.Name = "unitPriceDiscountDataGridViewTextBoxColumn";
            // 
            // lineTotalDataGridViewTextBoxColumn
            // 
            this.lineTotalDataGridViewTextBoxColumn.DataPropertyName = "LineTotal";
            this.lineTotalDataGridViewTextBoxColumn.HeaderText = "LineTotal";
            this.lineTotalDataGridViewTextBoxColumn.Name = "lineTotalDataGridViewTextBoxColumn";
            // 
            // rowguidDataGridViewTextBoxColumn1
            // 
            this.rowguidDataGridViewTextBoxColumn1.DataPropertyName = "rowguid";
            this.rowguidDataGridViewTextBoxColumn1.HeaderText = "rowguid";
            this.rowguidDataGridViewTextBoxColumn1.Name = "rowguidDataGridViewTextBoxColumn1";
            this.rowguidDataGridViewTextBoxColumn1.ReadOnly = true;
            this.rowguidDataGridViewTextBoxColumn1.Visible = false;
            // 
            // modifiedDateDataGridViewTextBoxColumn1
            // 
            this.modifiedDateDataGridViewTextBoxColumn1.DataPropertyName = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn1.HeaderText = "ModifiedDate";
            this.modifiedDateDataGridViewTextBoxColumn1.Name = "modifiedDateDataGridViewTextBoxColumn1";
            this.modifiedDateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.modifiedDateDataGridViewTextBoxColumn1.Visible = false;
            // 
            // bsSalesOrders
            // 
            this.bsSalesOrders.DataMember = "SalesOrderTable";
            this.bsSalesOrders.DataSource = this.mRecordset;
            // 
            // bsSalesOrderDetails
            // 
            this.bsSalesOrderDetails.DataMember = "SalesOrderDetailTable";
            this.bsSalesOrderDetails.DataSource = this.mRecordset;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 304);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.grdSalesOrderDetails);
            this.Controls.Add(this.grdSalesOrders);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "Main";
            this.Text = "TransactionScript";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mRecordset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalesOrderDetails)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSalesOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSalesOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdSalesOrders;
        private Recordset mRecordset;
        private System.Windows.Forms.DataGridView grdSalesOrderDetails;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem msFile;
        private System.Windows.Forms.ToolStripMenuItem msHelp;
        private System.Windows.Forms.ToolStripMenuItem msFileExit;
        private System.Windows.Forms.ToolStripMenuItem msHelpAbout;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revisionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn onlineOrderFlagDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseOrderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipToAddressIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billToAddressIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardApprovalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxAmtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesOrderDetailIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowguidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bsSalesOrders;
        private System.Windows.Forms.BindingSource bsSalesOrderDetails;
    }
}

