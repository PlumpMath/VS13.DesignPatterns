using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace DesignPatterns {
    //
    public class SalesOrderTableGateway {
        //Members
        private const string USP_SALESORDERS = "uspSalesOrderView",TBL_SALESORDERS = "SalesOrderTable";
        private const string USP_SALESORDER_READ = "uspSalesOrderRead";
        private const string USP_SALESORDER_UPDATE = "uspSalesOrderUpdate";
        private const string USP_SALESORDERDETAILS = "uspSalesOrderDetailView",TBL_SALESORDERDETAILS = "SalesOrderDetailTable";

        //Interface
        public SalesOrderTableGateway() { }
        public Recordset ReadSalesOrders() {
            Recordset salesOrders=null;

            //Caching: best to use with master tables not transactional tables
            ObjectCache cache = MemoryCache.Default;
            salesOrders = cache["salesorders"] as Recordset;
            if(salesOrders == null) {
                salesOrders = new Recordset();
                DataSet ds = fillDataset(USP_SALESORDERS,TBL_SALESORDERS,new object[] { });
                salesOrders.Merge(ds);

                //CacheItemPolicy policy = new CacheItemPolicy();
                //policy.ChangeMonitors.Add(new SqlChangeMonitor(new SqlDependency(new SqlCommand())));
                DateTimeOffset policy = new DateTimeOffset(DateTime.Now.AddMinutes(5));
                cache.Set("salesorders",salesOrders,policy);
            }
            return salesOrders;
        }
        public Recordset.SalesOrderTableRow ReadSalesOrder(int salesOrderID) {
            Recordset salesOrder = new Recordset();
            DataSet ds = fillDataset(USP_SALESORDER_READ,TBL_SALESORDERS,new object[] { salesOrderID });
            salesOrder.Merge(ds);
            return salesOrder.SalesOrderTable[0];
        }
        public void UpdateSalesOrder(int salesOrderID,decimal subTotal, decimal taxAmt, decimal freight) {
            executeNonQuery(USP_SALESORDER_UPDATE,new object[] { salesOrderID,subTotal,taxAmt,freight });
        }

        private DataSet fillDataset(string sp,string table,object[] o) {
            //Use the Microsoft Data Application Block
            DataSet ds = new DataSet();
            Database db = DatabaseFactory.CreateDatabase("SQLConnection");
            DbCommand cmd = db.GetStoredProcCommand(sp,o);
            db.LoadDataSet(cmd,ds,table);
            return ds;
        }
        private bool executeNonQuery(string spName,object[] paramValues) {
            //Use the Microsoft Data Application Block
            Database db = DatabaseFactory.CreateDatabase("SQLConnection");
            int i = db.ExecuteNonQuery(spName,paramValues);
            return i > 0;
        }
        private object executeNonQueryWithReturn(string spName,object[] paramValues) {
            //Use the Microsoft Data Application Block
            object ret=null;
            if((paramValues != null) && (paramValues.Length > 0)) {
                Database db = DatabaseFactory.CreateDatabase("SQLConnection");
                DbCommand cmd = db.GetStoredProcCommand(spName,paramValues);
                ret = db.ExecuteNonQuery(cmd);

                //Find the output parameter and return its value
                foreach(DbParameter param in cmd.Parameters) {
                    if((param.Direction == ParameterDirection.Output) || (param.Direction == ParameterDirection.InputOutput)) {
                        ret = param.Value;
                        break;
                    }
                }
            }
            return ret;
        }
    }
    public class SalesOrderDetailTableGateway {
        //Members
        private const string USP_SALESORDERDETAILS = "uspSalesOrderDetailView",TBL_SALESORDERDETAILS = "SalesOrderDetailTable";
        private const string USP_SALESORDERDETAIL_CREATE = "uspSalesOrderDetailCreate";
        private const string USP_SALESORDERDETAIL_READ = "uspSalesOrderDetailRead";
        private const string USP_SALESORDERDETAIL_UPDATE = "uspSalesOrderDetailUpdate";
        private const string USP_SALESORDERDETAIL_DELETE = "uspSalesOrderDetailDelete";

        //Interface
        public SalesOrderDetailTableGateway() { }
        public Recordset ReadSalesOrderDetails(int salesOrderID) {
            Recordset salesOrderDetails = new Recordset();
            DataSet ds = fillDataset(USP_SALESORDERDETAILS,TBL_SALESORDERDETAILS,new object[] { salesOrderID });
            salesOrderDetails.Merge(ds);
            return salesOrderDetails;
        }
        public Recordset.SalesOrderDetailTableRow ReadSalesOrderDetail(int salesOrderDetailID) {
            Recordset salesOrderDetail = new Recordset();
            DataSet ds = fillDataset(USP_SALESORDERDETAIL_READ,TBL_SALESORDERDETAILS,new object[] { salesOrderDetailID });
            salesOrderDetail.Merge(ds);
            return salesOrderDetail.SalesOrderDetailTable[0];
        }
        public void InsertSalesOrderDetail(int salesOrderID,short orderQty,int productID,decimal unitPrice,decimal unitPriceDiscount,decimal lineTotal) {
            executeNonQuery(USP_SALESORDERDETAIL_CREATE,new object[] { salesOrderID,orderQty,productID,unitPrice,unitPriceDiscount,lineTotal });
        }
        public void UpdateSalesOrderDetail(int salesOrderDetailID,short orderQty) {
            executeNonQuery(USP_SALESORDERDETAIL_UPDATE,new object[] { salesOrderDetailID,orderQty });
        }
        public void DeleteSalesOrderDetail(int salesOrderDetailID) {
            executeNonQuery(USP_SALESORDERDETAIL_DELETE,new object[] { salesOrderDetailID });
        }

        private DataSet fillDataset(string sp,string table,object[] o) {
            //Use the Microsoft Data Application Block
            DataSet ds = new DataSet();
            Database db = DatabaseFactory.CreateDatabase("SQLConnection");
            DbCommand cmd = db.GetStoredProcCommand(sp,o);
            db.LoadDataSet(cmd,ds,table);
            return ds;
        }
        private bool executeNonQuery(string spName,object[] paramValues) {
            //Use the Microsoft Data Application Block
            Database db = DatabaseFactory.CreateDatabase("SQLConnection");
            int i = db.ExecuteNonQuery(spName,paramValues);
            return i > 0;
        }
        private object executeNonQueryWithReturn(string spName,object[] paramValues) {
            //Use the Microsoft Data Application Block
            object ret=null;
            if((paramValues != null) && (paramValues.Length > 0)) {
                Database db = DatabaseFactory.CreateDatabase("SQLConnection");
                DbCommand cmd = db.GetStoredProcCommand(spName,paramValues);
                ret = db.ExecuteNonQuery(cmd);

                //Find the output parameter and return its value
                foreach(DbParameter param in cmd.Parameters) {
                    if((param.Direction == ParameterDirection.Output) || (param.Direction == ParameterDirection.InputOutput)) {
                        ret = param.Value;
                        break;
                    }
                }
            }
            return ret;
        }
    }
}
