using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarauntGui
{
    static class Customers
    {
        public static DataClasses1DataContext db;

        public static int getCustomerId(string username, string password)
        {
            return db.CUSTOMERs.Where(cust => cust.CUST_USERNAME == username && cust.CUST_PASSWORD == password).Select(cust => cust.CUST_ID).First();
        }

        public static CUSTOMER getCustomer(int id)
        {
            return db.CUSTOMERs.Where(cust => cust.CUST_ID == id).First();
        }

        public static String getusername(int id)
        {
            return db.CUSTOMERs.Where(customer => customer.CUST_ID == id)
                .Select(customer => customer.CUST_USERNAME).First();
        }

        public static String getCustomerName(int id)
        {
            return getPersonName(db.CUSTOMERs.Where(customer => customer.CUST_ID == id).Select(customer => customer.PERSON_ID).First());
        }

        public static String getPersonName(int personId)
        {
            return db.PERSONs.Where(person => person.PERSON_ID == personId).Select(person => person.FNAME).First() + " " + db.PERSONs.Where(person => person.PERSON_ID == personId).Select(person => person.LNAME).First();
        }

        public static String getCustomerEmail(int id)
        {
            return getPersonEmail(db.CUSTOMERs.Where(customer => customer.CUST_ID == id).Select(customer => customer.PERSON_ID).First());
        }
       
        public static String getPersonEmail(int personId)
        {
            return db.PERSONs.Where(person => person.PERSON_ID == personId).Select(person => person.EMAIL).First();
        }

        public static decimal getCustomerBalance(int id)
        {
            return db.CUSTOMERs.Where(customer => customer.CUST_ID == id).Select(customer => customer.CUST_BALANCE).First();
        }

        // Need to make some of these methods a bit backwards since some attributes are in different tables.
        public static List<ORDER> getOrders(int custId) {
            List<int> orders = getOrderNumbers(custId);
            return db.ORDERs.Where(order => orders.Contains(order.NUMBER)).ToList();
        }

        public static List<ORDER> getOrderInPriceRange(int custId, decimal min, decimal max)
        {
            List<int> orders = getOrderNumbers(custId);
            return db.ORDERs.Where(order => orders.Contains(order.NUMBER) && order.TOTAL > min && order.TOTAL < max).ToList();
        }

        public static List<ORDER_HAS_ITEM> getItemsOrdered(int orderNum)
        {
            return db.ORDER_HAS_ITEMs.Where(order => order.NUMBER == orderNum).ToList();
        }

        public static List<int> getOrderNumbers(int custId) {
            return db.CUSTOMER_HAS_ORDERs.Where(order => order.CUST_ID == custId).Select(order => order.NUMBER).ToList();
        }

        public static List<ORDER> getOrdersInDateRange(int custId, DateTime startDate, DateTime endDate)
        {
            List<int> custHasOrder = getOrderNumbers(custId);
            return db.ORDERs.Where(order => custHasOrder.Contains(order.NUMBER) && Convert.ToDateTime(order.DATE).Date >= startDate && Convert.ToDateTime(order.DATE).Date <= endDate).ToList();
            //return db.ORDERs.Where(order => custHasOrder.Contains(order.NUMBER) && Convert.ToDateTime(order.DATE).Date >= startDate && Convert.ToDateTime(order.DATE).Date <= endDate).ToList();
            Console.WriteLine("test 1");
            //Seem to be accessing CustHasOrder instead of objects within the list
            //return db.ORDERs.Where(order => /*custHasOrder.Contains(order.NUMBER) &&*/ order.DATE.Date > startDate && order.DATE.Date < endDate).ToList();

        }
    }                  
}
