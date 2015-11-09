using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

namespace DesignPatterns {
    //
    public class SalesOrderService {
        //Members
        private bool mUseTableBased=true;

        //Interface
        public SalesOrderService() { }
        public Recordset ViewSalesOrders() {
            if(this.mUseTableBased)
                return new SalesOrderTableGateway().ReadSalesOrders();
            else
                return SalesOrderRowGateway.ReadSalesOrders();
        }
        public Recordset ViewSalesOrderDetails(int salesOrderID) {
            if(this.mUseTableBased)
                return new SalesOrderDetailTableGateway().ReadSalesOrderDetails(salesOrderID);
            else
                return SalesOrderDetailRowGateway.ReadSalesOrderDetails(salesOrderID);
        }
        
        public void AddSalesOrderItem(int salesOrderID,short orderQty,int productID,decimal unitPrice,decimal unitPriceDiscount) {
            //Add a new order detail item; update the sales order
            //Apply a simple business rule
            decimal lineTotal = orderQty * unitPrice * (1 - unitPriceDiscount);

            //Create the TransactionScope to execute the commands, guaranteeing that both commands can commit or roll back as a single unit of work
            using(TransactionScope scope = new TransactionScope()) {
                //insert sales order item and update the sales order
                if(this.mUseTableBased) {
                    new SalesOrderDetailTableGateway().InsertSalesOrderDetail(salesOrderID,orderQty,productID,unitPrice,unitPriceDiscount,lineTotal);
                    Recordset.SalesOrderTableRow salesOrder = new SalesOrderTableGateway().ReadSalesOrder(salesOrderID);
                    decimal subTotal = salesOrder.SubTotal + lineTotal;
                    decimal taxAmt = salesOrder.TaxAmt + (0.05M * lineTotal);
                    decimal freight = salesOrder.Freight;
                    new SalesOrderTableGateway().UpdateSalesOrder(salesOrderID,subTotal,taxAmt,freight);
                }
                else {
                    SalesOrderDetailRowGateway salesOrderDetail = new SalesOrderDetailRowGateway();
                    salesOrderDetail.SalesOrderID = salesOrderID;
                    salesOrderDetail.OrderQty = orderQty;
                    salesOrderDetail.ProductID = productID;
                    salesOrderDetail.UnitPrice = unitPrice;
                    salesOrderDetail.UnitPriceDiscount = unitPriceDiscount;
                    salesOrderDetail.Insert();
                    SalesOrderRowGateway salesOrder = SalesOrderRowGateway.ReadSalesOrder(salesOrderID);
                    salesOrder.SubTotal = salesOrder.SubTotal + lineTotal;
                    salesOrder.TaxAmt = salesOrder.TaxAmt + (0.05M * lineTotal);
                    salesOrder.Freight = salesOrder.Freight;
                    salesOrder.Update();
                }

                //Commits the transaction; if an exception is thrown, Complete is not called and the transaction is rolled back
                scope.Complete();
            }
        }
        public void ChangeSalesOrderItem(int salesOrderDetailID,short orderQty) {
            //Change an existing order detail item            
            //Create the TransactionScope to execute the commands, guaranteeing that both commands can commit or roll back as a single unit of work
            using(TransactionScope scope = new TransactionScope()) {
                //update the sales order item and update the sales order
               if(this.mUseTableBased) {
                    new SalesOrderDetailTableGateway().UpdateSalesOrderDetail(salesOrderDetailID,orderQty);
                    Recordset.SalesOrderDetailTableRow salesOrderDetail = new SalesOrderDetailTableGateway().ReadSalesOrderDetail(salesOrderDetailID);
                    int salesOrderID = salesOrderDetail.SalesOrderID;
                    Recordset.SalesOrderTableRow salesOrder = new SalesOrderTableGateway().ReadSalesOrder(salesOrderID);
                    decimal lineTotal = orderQty * salesOrderDetail.UnitPrice * (1 - salesOrderDetail.UnitPriceDiscount);
                    decimal subTotal = salesOrder.SubTotal + lineTotal;
                    decimal taxAmt = salesOrder.TaxAmt + (0.05M * lineTotal);
                    decimal freight = salesOrder.Freight;
                    new SalesOrderTableGateway().UpdateSalesOrder(salesOrderID,subTotal,taxAmt,freight);
                }
                else {
                    SalesOrderDetailRowGateway salesOrderDetail = SalesOrderDetailRowGateway.ReadSalesOrderDetail(salesOrderDetailID);
                    salesOrderDetail.OrderQty = orderQty;
                    salesOrderDetail.Update();
                    SalesOrderRowGateway salesOrder = SalesOrderRowGateway.ReadSalesOrder(salesOrderDetail.SalesOrderID);
                    decimal lineTotal = orderQty * salesOrderDetail.UnitPrice * (1 - salesOrderDetail.UnitPriceDiscount);
                    salesOrder.SubTotal = salesOrder.SubTotal + lineTotal;
                    salesOrder.TaxAmt = salesOrder.TaxAmt + (0.05M * lineTotal);
                    salesOrder.Freight = salesOrder.Freight;
                    salesOrder.Update();
                }

               //Commits the transaction; if an exception is thrown, Complete is not called and the transaction is rolled back
               scope.Complete();
            }
        }
        public void RemoveSalesOrderItem(int salesOrderDetailID) {
            //Delete an existing order detail item; update the sales order
            //Create the TransactionScope to execute the commands, guaranteeing that both commands can commit or roll back as a single unit of work
            using(TransactionScope scope = new TransactionScope()) {
                //remove the sales order item and update the sales order
                if(this.mUseTableBased) {
                    //delete the sales order detail and update the sales order
                    new SalesOrderDetailTableGateway().DeleteSalesOrderDetail(salesOrderDetailID);
                    Recordset.SalesOrderDetailTableRow salesOrderDetail = new SalesOrderDetailTableGateway().ReadSalesOrderDetail(salesOrderDetailID);
                    int salesOrderID = salesOrderDetail.SalesOrderID;
                    Recordset.SalesOrderTableRow salesOrder = new SalesOrderTableGateway().ReadSalesOrder(salesOrderID);
                    decimal subTotal = salesOrder.SubTotal - salesOrderDetail.LineTotal;
                    decimal taxAmt = salesOrder.TaxAmt - (0.05M * salesOrderDetail.LineTotal);
                    decimal freight = salesOrder.Freight;
                    new SalesOrderTableGateway().UpdateSalesOrder(salesOrderID,subTotal,taxAmt,freight);
                }
                else {
                    SalesOrderDetailRowGateway salesOrderDetail = SalesOrderDetailRowGateway.ReadSalesOrderDetail(salesOrderDetailID);
                    salesOrderDetail.Delete();
                    int salesOrderID = salesOrderDetail.SalesOrderID;
                    SalesOrderRowGateway salesOrder = SalesOrderRowGateway.ReadSalesOrder(salesOrderID);
                    salesOrder.SubTotal = salesOrder.SubTotal - salesOrderDetail.LineTotal;
                    salesOrder.TaxAmt = salesOrder.TaxAmt - (0.05M * salesOrderDetail.LineTotal);
                    salesOrder.Freight = salesOrder.Freight;
                    salesOrder.Update();
                }

                //Commits the transaction; if an exception is thrown, Complete is not called and the transaction is rolled back
                scope.Complete();
            }
        }
    }
}
