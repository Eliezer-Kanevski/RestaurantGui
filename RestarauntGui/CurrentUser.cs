using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  INSERT INTO CUSTOMER
	VALUES(1,1,'22-Jan-20','5-JUL-21','ARUKER', 'Aruk',25.36);
INSERT INTO CUSTOMER
	VALUES(2,2,'31-Jan-20','5-JUL-20','Ajohnson','Ajohn',58.14);
INSERT INTO CUSTOMER
	VALUES(3,3,'8-Feb-20','8-FEB-20','Aarlad','Aard',0);
INSERT INTO CUSTOMER
	VALUES(4,4,'30-Dec-20','5-JAN-21','breliger','brel' ,78.99);
INSERT INTO CUSTOMER
	VALUES(5,5,'3-Mar-20','4-JUL-20','bmaroon','Bmar',45.21);
INSERT INTO CUSTOMER
	VALUES(6,6,'20-Jan-2021','6-May-21','sperez','Sper',10.99);
INSERT INTO CUSTOMER
	VALUES(7,7,'25-Jul-20','29-Jul-21','mtrout','Mtrou',18.1);
INSERT INTO CUSTOMER
	VALUES(8,8,,'11-Sep-20','12-Aug-21',,'bharper','Bharp',153.47);
INSERT INTO CUSTOMER
	VALUES(9,9,'28-Feb-21','5-Mar-21','ajudge','Ajud',4.99);
INSERT INTO CUSTOMER
	VALUES(10,10,'11-APR-21','5-May-21','gtorres','Gtore',98.37);
INSERT INTO CUSTOMER
	VALUES(11,11,'22-Jan-21','5-JUL-21','gurshela','Gursh',12.38);
INSERT INTO CUSTOMER
	VALUES(12,12,'29-Jan-20','5-JUL-21','gsanchez','Gsan',148.57);
INSERT INTO CUSTOMER
	VALUES(13,13,'3-Feb-20','5-Jul-21','lvoit','Lvoi',243.21);
INSERT INTO CUSTOMER
	VALUES(14,14,'24-Mar-20','5-JUL-21','lmcholough','Lmchol',122.36);
INSERT INTO CUSTOMER
	VALUES(15,15,'12-Apr-20','5-JUL-21','lwattington','Lwat',110.2);
 */

namespace RestarauntGui
{
    internal class CurrentUser
    {
        public DataClasses1DataContext db;

        public bool IsLoggedIn { get; set; }
        public string UserName { get; set; }
        public string password { get; set; }
        public int UserId { get; set; }

        public bool isUser(string username, string password)
        {
            if (db.CUSTOMERs.Any(cust => cust.CUST_USERNAME == username) && db.CUSTOMERs.Any(cust => cust.CUST_PASSWORD == password))
            {
                UserId = Customers.getCustomerId(username, password);
                IsLoggedIn = true;

                return true;
            }
            return false;
        }


        private Dictionary<int, int> orderList = new Dictionary<int, int>();

        public int getOrderSize()
        {
            return orderList.Count();
        }

        public void emptyOrderList()
        {
            orderList.Clear();
        }

        public void resetDBConncetion(DataClasses1DataContext newDB)
        {
            db = newDB;
            Customers.db = newDB;
            Items.db = newDB;
            Order.db = newDB;
        }

        public CurrentUser(DataClasses1DataContext db)
        {
            this.db = db;
            Customers.db = db;
            Items.db = db;
            Order.db = db;
        }


        public List<String> GetOrder()
        {
            List<String> orderAsList = new List<String>();
            String item;
            foreach (var dish in orderList)
            {
                item = db.ITEMs.Where(items => items.ITEM_ID == dish.Key).Select(items => items.I_NAME).First();
                orderAsList.Add(item + "\t" + dish.Key + "\t" + Items.getItemPrice(dish.Key) * dish.Value);
            }
            return orderAsList;
        }

        public bool placeOrder()
        {
            return Order.placeOrder(UserId, orderList);
        }

        public decimal orderTotal()
        {
            return Items.orderTotal(orderList);
        }

        public void logout()
        {
            IsLoggedIn = false;
        }

        public decimal getBalance()
        {
            return Customers.getCustomerBalance(UserId);
        }

        public string getName()
        {
            return Customers.getusername(UserId);
        }
        public decimal CustomerBalance
        {
            get
            {                
                return getBalance();               
            }
            private set { }
        }

        public bool addItemToOrder(int itemId, int quantity)
        {
            return Order.addItemtoOrder(itemId, quantity, orderList);
        }

        public bool removeItemFromOrder(int itemId, Dictionary<int, int> orderList)
        {
            return Order.removeItemFromOrder(itemId, orderList);
        }

        public List<ORDER> getOrderInPriceRange(decimal min, decimal max)
        {
            return Customers.getOrderInPriceRange(UserId, min, max);
        }

        public List<ORDER_HAS_ITEM> getItemsOrdered(int orderNum)
        {
            return Customers.getItemsOrdered(orderNum);
        }

        public List<int> getOrderNumbers()
        {
            return Customers.getOrderNumbers(UserId);
        }
        
        public List<ORDER> getOrdersInDateRange( DateTime startDate, DateTime endDate)
        {
            return Customers.getOrdersInDateRange(UserId, startDate, endDate);
        }

        public List<ORDER> getOrdersForCustomer()
        {
            return Customers.getOrders(UserId);
        }

    }
}
