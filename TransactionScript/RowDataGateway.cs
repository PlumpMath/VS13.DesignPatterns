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
    public class SalesOrderRowGateway {
        //Members
        private int mSalesOrderID=0;
        private byte mRevisionNumber=0;
        private DateTime mOrderDate, mDueDate, mShipDate;
        private byte mStatus=0;
        private bool mOnlineOrderFlag=false;
        private string mSalesOrderNumber="", mPurchaseOrderNumber="", mAccountNumber="";
        private int mCustomerID=0, mShipToAddressID=0, mBillToAddressID=0;
        private string mShipMethod="", mCreditCardApprovalCode="";
        private decimal mSubTotal=0, mTaxAmt=0, mFreight=0, mTotalDue=0;
        private string mComment="";

        private const string USP_SALESORDERS = "uspSalesOrderView",TBL_SALESORDERS = "SalesOrderTable";
        private const string USP_SALESORDER_READ = "uspSalesOrderRead";
        private const string USP_SALESORDER_UPDATE = "uspSalesOrderUpdate";

        //Interface
        public static Recordset ReadSalesOrders() {
            Recordset salesOrders = new Recordset();
            Database db = DatabaseFactory.CreateDatabase("SQLConnection");
            DbCommand cmd = db.GetStoredProcCommand(USP_SALESORDERS,new object[] { });
            DataSet ds = new DataSet();
            db.LoadDataSet(cmd,ds,TBL_SALESORDERS);
            salesOrders.Merge(ds);
            return salesOrders;
        }
        public static SalesOrderRowGateway ReadSalesOrder(int salesOrderID) {
            Recordset salesOrder = new Recordset();
            Database db = DatabaseFactory.CreateDatabase("SQLConnection");
            DbCommand cmd = db.GetStoredProcCommand(USP_SALESORDER_READ,new object[] { salesOrderID });
            DataSet ds = new DataSet();
            db.LoadDataSet(cmd,ds,TBL_SALESORDERS);
            salesOrder.Merge(ds);
            return new SalesOrderRowGateway(salesOrder.SalesOrderTable[0]);
        }

        public SalesOrderRowGateway(): this(null) { }
        public SalesOrderRowGateway(Recordset.SalesOrderTableRow salesOrder) {
            if(salesOrder != null) {
                this.mSalesOrderID = salesOrder.SalesOrderID;
                this.mRevisionNumber = salesOrder.RevisionNumber;
                this.mOrderDate = salesOrder.OrderDate;
                this.mDueDate = salesOrder.DueDate;
                this.mShipDate = salesOrder.ShipDate;
                this.mStatus = salesOrder.Status;
                this.mOnlineOrderFlag = salesOrder.OnlineOrderFlag;
                this.mSalesOrderNumber = salesOrder.SalesOrderNumber;
                this.mPurchaseOrderNumber = salesOrder.PurchaseOrderNumber;
                this.mAccountNumber = salesOrder.AccountNumber;
                this.mCustomerID = salesOrder.CustomerID;
                this.mShipToAddressID = salesOrder.ShipToAddressID;
                this.mBillToAddressID = salesOrder.BillToAddressID;
                this.mShipMethod = salesOrder.ShipMethod;
                this.mCreditCardApprovalCode = salesOrder.CreditCardApprovalCode;
                this.mSubTotal = salesOrder.SubTotal;
                this.mTaxAmt = salesOrder.TaxAmt;
                this.mFreight = salesOrder.Freight;
                this.mTotalDue = salesOrder.TotalDue;
                this.mComment = salesOrder.Comment;
            }
        }
        #region Accessors [Members...]
        public int SalesOrderID { get { return this.mSalesOrderID; } set { this.mSalesOrderID = value; } }
        public byte RevisionNumber { get { return this.mRevisionNumber; } set { this.mRevisionNumber = value; } }
        public DateTime OrderDate { get { return this.mOrderDate; } set { this.mOrderDate = value; } }
        public DateTime DueDate { get { return this.mDueDate; } set { this.mDueDate = value; } }
        public DateTime ShipDate { get { return this.mShipDate; } set { this.mShipDate = value; } }
        public byte Status { get { return this.mStatus; } set { this.mStatus = value; } }
        public bool OnlineOrderFlag { get { return this.mOnlineOrderFlag; } set { this.mOnlineOrderFlag = value; } }
        public string SalesOrderNumber { get { return this.mSalesOrderNumber; } set { this.mSalesOrderNumber = value; } }
        public string PurchaseOrderNumber { get { return this.mPurchaseOrderNumber; } set { this.mPurchaseOrderNumber = value; } }
        public string AccountNumber { get { return this.mAccountNumber; } set { this.mAccountNumber = value; } }
        public int CustomerID { get { return this.mCustomerID; } set { this.mCustomerID = value; } }
        public int ShipToAddressID { get { return this.mShipToAddressID; } set { this.mShipToAddressID = value; } }
        public int BillToAddressID { get { return this.mBillToAddressID; } set { this.mBillToAddressID = value; } }
        public string ShipMethod { get { return this.mShipMethod; } set { this.mShipMethod = value; } }
        public string CreditCardApprovalCode { get { return this.mCreditCardApprovalCode; } set { this.mCreditCardApprovalCode = value; } }
        public decimal SubTotal { get { return this.mSubTotal; } set { this.mSubTotal = value; } }
        public decimal TaxAmt { get { return this.mTaxAmt; } set { this.mTaxAmt = value; } }
        public decimal Freight { get { return this.mFreight; } set { this.mFreight = value; } }
        public decimal TotalDue { get { return this.mTotalDue; } set { this.mTotalDue = value; } }
        public string Comment { get { return this.mComment; } set { this.mComment = value; } }
        #endregion
        public void Update() {
            executeNonQuery(USP_SALESORDER_UPDATE,new object[] { this.mSalesOrderID,this.mSubTotal,this.mTaxAmt,this.mFreight });
        }

        private DataSet fillDataset(string sp,string table,object[] o) {
            //Use the Microsoft Data Application Block
            Database db = DatabaseFactory.CreateDatabase("SQLConnection");
            DbCommand cmd = db.GetStoredProcCommand(sp,o);
            DataSet ds = new DataSet();
            db.LoadDataSet(cmd,ds,table);
            return ds;
        }
        private bool executeNonQuery(string spName,object[] paramValues) {
            //Use the Microsoft Data Application Block
            bool ret=false;
            Database db = DatabaseFactory.CreateDatabase("SQLConnection");
            int i = db.ExecuteNonQuery(spName,paramValues);
            ret = i > 0;
            return ret;
        }
    }

    public class SalesOrderDetailRowGateway {
        //Members
        private int mSalesOrderID=0, mSalesOrderDetailID=0;
        private short mOrderQty=0;
        private int mProductID=0;
        private decimal mUnitPrice=0,mUnitPriceDiscount=0,mLineTotal=0;

        private const string USP_SALESORDERDETAILS = "uspSalesOrderDetailView",TBL_SALESORDERDETAILS = "SalesOrderDetailTable";
        private const string USP_SALESORDERDETAIL_CREATE = "uspSalesOrderDetailCreate";
        private const string USP_SALESORDERDETAIL_READ = "uspSalesOrderDetailRead";
        private const string USP_SALESORDERDETAIL_UPDATE = "uspSalesOrderDetailUpdate";
        private const string USP_SALESORDERDETAIL_DELETE = "uspSalesOrderDetailDelete";

        //Interface
        public static Recordset ReadSalesOrderDetails(int salesOrderID) {
            Recordset salesOrderDetails = new Recordset();
            Database db = DatabaseFactory.CreateDatabase("SQLConnection");
            DbCommand cmd = db.GetStoredProcCommand(USP_SALESORDERDETAILS,new object[] { salesOrderID });
            DataSet ds = new DataSet();
            db.LoadDataSet(cmd,ds,TBL_SALESORDERDETAILS);
            salesOrderDetails.Merge(ds);
            return salesOrderDetails;
        }
        public static SalesOrderDetailRowGateway ReadSalesOrderDetail(int salesOrderDetailID) {
            Recordset salesOrderDetail = new Recordset();
            Database db = DatabaseFactory.CreateDatabase("SQLConnection");
            DbCommand cmd = db.GetStoredProcCommand(USP_SALESORDERDETAIL_READ,new object[] { salesOrderDetailID });
            DataSet ds = new DataSet();
            db.LoadDataSet(cmd,ds,TBL_SALESORDERDETAILS);
            salesOrderDetail.Merge(ds);
            return new SalesOrderDetailRowGateway(salesOrderDetail.SalesOrderDetailTable[0]);
        }
        
        public SalesOrderDetailRowGateway(): this(null) { }
        public SalesOrderDetailRowGateway(Recordset.SalesOrderDetailTableRow salesOrderDetail) {
            if(salesOrderDetail != null) {
                this.mSalesOrderID = salesOrderDetail.SalesOrderID;
                this.mSalesOrderDetailID = salesOrderDetail.SalesOrderDetailID;
                this.mOrderQty = salesOrderDetail.OrderQty;
                this.mProductID = salesOrderDetail.ProductID;
                this.mUnitPrice = salesOrderDetail.UnitPrice;
                this.mUnitPriceDiscount = salesOrderDetail.UnitPriceDiscount;
                this.mLineTotal = salesOrderDetail.LineTotal;
            }
        }
        #region Accessors [Members...]
        public int SalesOrderID { get { return this.mSalesOrderID; } set { this.mSalesOrderID = value; } }
        public int SalesOrderDetailID { get { return this.mSalesOrderDetailID; } set { this.mSalesOrderDetailID = value; } }
        public short OrderQty { get { return this.mOrderQty; } set { this.mOrderQty = value; } }
        public int ProductID { get { return this.mProductID; } set { this.mProductID = value; } }
        public decimal UnitPrice { get { return this.mUnitPrice; } set { this.mUnitPrice = value; } }
        public decimal UnitPriceDiscount { get { return this.mUnitPriceDiscount; } set { this.mUnitPriceDiscount = value; } }
        public decimal LineTotal { get { return this.mLineTotal; } set { this.mLineTotal = value; } }
        #endregion
        public void Insert() {
            executeNonQuery(USP_SALESORDERDETAIL_CREATE,new object[] { this.mSalesOrderID,this.mOrderQty,this.mProductID,this.mUnitPrice,this.mUnitPriceDiscount,this.mLineTotal });
        }
        public void Update() {
            executeNonQuery(USP_SALESORDERDETAIL_UPDATE,new object[] { this.mSalesOrderDetailID,this.mOrderQty });
        }
        public void Delete() {
            executeNonQuery(USP_SALESORDERDETAIL_DELETE,new object[] { this.mSalesOrderDetailID });
        }

        private DataSet fillDataset(string sp,string table,object[] o) {
            //Use the Microsoft Data Application Block
            Database db = DatabaseFactory.CreateDatabase("SQLConnection");
            DbCommand cmd = db.GetStoredProcCommand(sp,o);
            DataSet ds = new DataSet();
            db.LoadDataSet(cmd,ds,table);
            return ds;
        }
        private bool executeNonQuery(string spName,object[] paramValues) {
            //Use the Microsoft Data Application Block
            bool ret=false;
            Database db = DatabaseFactory.CreateDatabase("SQLConnection");
            int i = db.ExecuteNonQuery(spName,paramValues);
            ret = i > 0;
            return ret;
        }
    }
}
