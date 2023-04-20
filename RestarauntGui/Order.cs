using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarauntGui
{
    static class Order
    {
        public static DataClasses1DataContext db;

        public static decimal maxBalance = 150;

        public static decimal getBalance(int customerId)
        {
            return db.CUSTOMERs.Where(cust => cust.CUST_ID == customerId).Select(cust => cust.CUST_BALANCE).First();
        }


        public static bool makePayment(int customerId, decimal amount)
        {
            if(amount < 0) { return false; }
            CUSTOMER customer = Customers.getCustomer(customerId);
            customer.CUST_BALANCE -= amount;
            db.SubmitChanges();
            return true;
        }

        public static bool addItemtoOrder(int itemId, int quantity, Dictionary<int, int> orderList)
        {
            if (quantity < 1) return false;

            if (orderList.ContainsKey(itemId))
            {
                orderList[itemId] += quantity;
                return true;
            }
            else { orderList.Add(itemId, quantity); return true; }
        }

        public static bool removeItemFromOrder(int itemId, Dictionary<int, int> orderList)
        {
            if (!orderList.ContainsKey(itemId)) return false;

            orderList.Remove(itemId);
            return true;
        }

        public static bool canOrder(int custID, decimal orderTotal)
        {
            CUSTOMER customer = Customers.getCustomer(custID);

            return customer.CUST_BALANCE + orderTotal <= maxBalance;

        }

        public static int generateOrderNumber()
        {
            return db.ORDERs.OrderByDescending(order => order.NUMBER).Select(order => order.NUMBER).First() + 1;

        }

        public static void createCustomerHasOrder(int orderNumber, CUSTOMER customer, int customerID)
        {
            CUSTOMER_HAS_ORDER addCustomerHasOrder = new CUSTOMER_HAS_ORDER()
            {
                CUST_ID = customerID,
                ID = db.CUSTOMER_HAS_ORDERs.OrderByDescending(order => order.ID).Select(order => order.ID).First() + 1,
                NUMBER = orderNumber,
            };
            db.SubmitChanges();
        }

        public static void createOrderHasItems(int orderNumber, Dictionary<int, int> orderList)
        {
            ORDER_HAS_ITEM addOrderItems = new ORDER_HAS_ITEM();
            foreach (var item in orderList)
            {
                addOrderItems = new ORDER_HAS_ITEM()
                {
                    ID = db.ORDER_HAS_ITEMs.OrderByDescending(order => order.ID).Select(order => order.ID).First() + 1,
                    NUMBER = orderNumber,
                    M_ID = Items.CurrentMenu,
                    ITEM_ID = item.Key,
                    QUANTITY = item.Value
                };
                db.ORDER_HAS_ITEMs.InsertOnSubmit(addOrderItems);
                db.SubmitChanges();

            }
        }

        public static void addOrder(decimal total, int orderNumber)
        {
            ORDER addOrder = new ORDER()
            {
                NUMBER = orderNumber,
                // datetime.now may cause issues with format returned
                DATE = DateTime.Now,
                ORDER_STATUS = "Placed order",
                PAYMENT_STATUS = "Unpaid",
                TOTAL = total
            };
            db.SubmitChanges();
        }

        public static void addBalance(int customerID, decimal total)
        {
            CUSTOMER currentCustomer = db.CUSTOMERs.Where(customer => customer.CUST_ID == customerID).First();

            currentCustomer.CUST_BALANCE = currentCustomer.CUST_BALANCE + total;
            db.SubmitChanges();
        }

        public static bool placeOrder(int custID, Dictionary<int, int> orderList)
        {
             
            CUSTOMER customer = Customers.getCustomer(custID);
            if(canOrder(custID, Items.orderTotal(orderList)))
            {
                
                int orderNumber = generateOrderNumber();
                
                createCustomerHasOrder(orderNumber, customer, custID);
                // something went wrong before this


                decimal total = Items.orderTotal(orderList);

                addOrder(total, orderNumber);
                addBalance(custID, total);
                return true;   
            }
            return false;
 
        }
    }
}
        