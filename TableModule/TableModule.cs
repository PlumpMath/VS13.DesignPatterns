using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace DesignPatterns {
    //
    public abstract class TableModule {
        //Members
        protected DataTable mTable=null;
        
        //Interface
        public TableModule(DataSet ds, string tableName) { 
            //Constructor
            this.mTable = ds.Tables[tableName];
        }
    }
    public class SalesOrderTableModule {
        //Members
        private Recordset.SalesOrderTableDataTable mSalesOrder=null;

        //Interface
        public SalesOrderTableModule(Recordset salesOrder) {
            //Constructor
            this.mSalesOrder = salesOrder.SalesOrderTable;
        }
        public Recordset.SalesOrderTableRow this[int salesOrderID] { get { return (Recordset.SalesOrderTableRow)this.mSalesOrder.Select("SalesOrderID='" + salesOrderID + "'")[0]; } }
        public void Update(int salesOrderID,decimal subTotal,decimal taxAmt,decimal freight) {
            Recordset.SalesOrderTableRow salesOrder = this[salesOrderID];
            salesOrder.SubTotal = subTotal;
            salesOrder.TaxAmt = taxAmt;
            salesOrder.Freight = freight;
        }
        //public void AddSalesOrderItem() {
        //    SalesOrderDetailTableModule salesOrderDetail = new SalesOrderDetailTableModule(salesOrder);
        //    salesOrderDetail.Insert(salesOrder);
        //}
        //public void UpdateSalesOrderItem() {
        //    SalesOrderDetailTableModule salesOrderDetail = new SalesOrderDetailTableModule(salesOrder);
        //}
        //public void RemoveSalesOrderItem() {
        //    SalesOrderDetailTableModule salesOrderDetail = new SalesOrderDetailTableModule(salesOrder);
        //}
    }

    public class SalesOrderDetailTableModule {
        //Members
        protected Recordset.SalesOrderDetailTableDataTable mSalesOrderDetail=null;

        //Interface        
        public SalesOrderDetailTableModule(Recordset salesOrderDetail) {
            //Constructor
            this.mSalesOrderDetail = salesOrderDetail.SalesOrderDetailTable;
        }
        public Recordset.SalesOrderDetailTableRow this[int salesOrderDetailID] { get { return (Recordset.SalesOrderDetailTableRow)this.mSalesOrderDetail.Select("SalesOrderDetailID='" + salesOrderDetailID + "'")[0]; } }
        public void Insert(int salesOrderID,short orderQty,int productID,decimal unitPrice,decimal unitPriceDiscount,decimal lineTotal) {
            Recordset.SalesOrderDetailTableRow salesOrderItem = this.mSalesOrderDetail.NewSalesOrderDetailTableRow();
            salesOrderItem.SalesOrderID = salesOrderID;
            salesOrderItem.OrderQty = orderQty;
            salesOrderItem.ProductID = productID;
            salesOrderItem.UnitPrice = unitPrice;
            salesOrderItem.UnitPriceDiscount = unitPriceDiscount;
            salesOrderItem.LineTotal = lineTotal;
            this.mSalesOrderDetail.AddSalesOrderDetailTableRow(salesOrderItem);
        }
        public void Update(int salesOrderDetailID,short orderQty) {
            Recordset.SalesOrderDetailTableRow salesOrderItem = this[salesOrderDetailID];
            salesOrderItem.OrderQty = orderQty;
        }
        public void Delete(int salesOrderDetailID) {
            Recordset.SalesOrderDetailTableRow salesOrderItem = this[salesOrderDetailID];
            salesOrderItem.Delete();
        }
    }
}
