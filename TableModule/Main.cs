using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPatterns {
    //
    public partial class Main:Form {
        //Members

        //Interface
        public Main() {
            //Constructor
            InitializeComponent();
        }

        private void OnFormLoad(object sender,EventArgs e) {
            //Event handler for form load event
            Recordset rs = new SalesOrderTableGateway().ReadSalesOrders();
            this.mRecordset.SalesOrderTable.Clear();
            this.mRecordset.SalesOrderTable.Merge(rs.SalesOrderTable);
        }

        private void OnSalesOrderSelected(object sender,EventArgs e) {
            if(this.grdSalesOrders.SelectedRows.Count > 0) {
                int id = Convert.ToInt32(this.grdSalesOrders.SelectedRows[0].Cells[0].Value);
                Recordset rs = new SalesOrderDetailTableGateway().ReadSalesOrderDetails(id);
                this.mRecordset.SalesOrderDetailTable.Clear();
                this.mRecordset.SalesOrderDetailTable.Merge(rs.SalesOrderDetailTable);
            }
        }

        private void OnItemClicked(object sender,EventArgs e) {
            //Event handler for menu/toolbar clicks
        }

        private void OnUserAddedRow(object sender,DataGridViewRowEventArgs e) {
            System.Diagnostics.Debug.WriteLine("OnUserAddedRow()");
        }
        private void OnCellEndEdit(object sender,DataGridViewCellEventArgs e) {
            System.Diagnostics.Debug.WriteLine("OnCellEndEdit()");
        }
        private void OnCellValueChanged(object sender,DataGridViewCellEventArgs e) {
            System.Diagnostics.Debug.WriteLine("OnCellValueChanged()");
        }
        private void OnUserDeletedRow(object sender,DataGridViewRowEventArgs e) {
            System.Diagnostics.Debug.WriteLine("OnUserDeletedRow()");
        }
        private void OnUserDeletingRow(object sender,DataGridViewRowCancelEventArgs e) {
            System.Diagnostics.Debug.WriteLine("OnUserDeletingRow()");
        }
        private void OnRowLeave(object sender,DataGridViewCellEventArgs e) {
            System.Diagnostics.Debug.WriteLine("OnRowLeave()");
        }
        private void OnRowsAdded(object sender,DataGridViewRowsAddedEventArgs e) {
            System.Diagnostics.Debug.WriteLine("OnRowsAdded()");
        }
        private void OnRowValidated(object sender,DataGridViewCellEventArgs e) {
            System.Diagnostics.Debug.WriteLine("OnRowValidated()");
        }
        private void OnRowValidating(object sender,DataGridViewCellCancelEventArgs e) {
            System.Diagnostics.Debug.WriteLine("OnRowValidating()");
        }
        private void OnDefaultValuesNeeded(object sender,DataGridViewRowEventArgs e) {
            System.Diagnostics.Debug.WriteLine("OnDefaultValuesNeeded()");
            e.Row.Cells["SalesOrderID"].Value = this.grdSalesOrders.SelectedRows[0].Cells["SalesOrderID"].Value;
        }
    }
}
