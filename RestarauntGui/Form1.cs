using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestarauntGui
{
    public partial class Form1 : Form
    {
        CurrentUser currentUser;
        public Form1()
        {

            InitializeComponent();
            
            /*try
            {
                using (var dataBaseConnection = new DataClasses1DataContext())
                {
                    //DisplayItemsDataGridView1.DataSource = Items.getItems();

                    Items.db = dataBaseConnection;
                    var items = Items.getItemsObj();
                    var itemName = Items.getItemName();


                    ListViewItem itemsToDisplay = new ListViewItem(items.ToString());
                    foreach (var item in items)
                    {
                        listView1.Items.Add(item.ITEM_ID.ToString() + ", " + item.I_NAME + ", " + item.I_DESCRIPTION + ", " + item.I_PRICE.ToString());
                        
                    }
                }
            }

            catch
            {
                MessageBox.Show("Did not upload items");
            }

            */

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.ITEM' table. You can move, or remove it, as needed.
            this.iTEMTableAdapter.Fill(this.masterDataSet.ITEM);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String username = customerUsername.Text;
            String password = customerPassword.Text;
            using (var dataBaseConnection = new DataClasses1DataContext())
            {
                currentUser = new CurrentUser(dataBaseConnection);

                if (currentUser.isUser(username, password))
                {
                    customerLoginBox.Visible = true;
                    welcomeMessageLable.Text = "Welcome " + currentUser.getName() + "!";
                    balanceAmount.Text = "$" + currentUser.CustomerBalance.ToString();
                    AddItemButton.Visible = true;

                    OrdersInDateRangeButton.Visible = true;
                    ViewAllOrdersButton.Visible = true;
                    ViewOrdersInCostRangeButton.Visible = true;
                    //balanceDueAmountLbl.Text = "$" + userSession.getCurrentUsersBalanceDue() ?? "0.00";
                    //DisplayItemsDataGridView1_CellContentClick(sender, e);
                }
                else
                {
                    //errorMessageLbl.Visible = true;
                    welcomeMessageLable.Text = "Invalid user, try again ";
                }
            }
            
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            using (var dataBaseConnection = new DataClasses1DataContext())
            {
                currentUser = null;
                customerUsername.Text = "";
                customerPassword.Text = "";
                welcomeMessageLable.Text = "";
                balanceAmount.Text = "$0.00";

                EnterAmountLabel.Visible = false;
                EnterAmountTxtBx.Visible = false;
                PayActionButton.Visible = false;
                PlaceOrderButton.Visible = false;

                //            listViewItemsInCart.Items.Clear();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customerLoginBox_Enter(object sender, EventArgs e)
        {

        }

        private void Balance_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void balanceAmount_Click(object sender, EventArgs e)
        {

        }

        private void payBalanceButton_Click(object sender, EventArgs e)
        {
            using (var dataBaseConnection = new DataClasses1DataContext())
            {
                if (currentUser != null) 
                {
                    EnterAmountLabel.Visible = true;
                    EnterAmountTxtBx.Visible = true;
                    PayActionButton.Visible = true;
                }
            }
                
        }

        private void PayActionButton_Click(object sender, EventArgs e)
        {
            using (var dataBaseConnection = new DataClasses1DataContext())
            {
                currentUser.resetDBConncetion(dataBaseConnection);
                try { 

                    decimal amount = Convert.ToDecimal(EnterAmountTxtBx.Text);
                    if(amount <= 0) 
                    { 
                        MessageBox.Show("Payment must be greater than 0"); 
                        return; 
                    }
                    Order.makePayment(currentUser.UserId, amount);
                    balanceAmount.Text = "$" + currentUser.CustomerBalance;
                    EnterAmountTxtBx.Visible = false;
                    EnterAmountTxtBx.Text = "";
                    PayActionButton.Visible = false;

                }

                catch
                {
                    MessageBox.Show("Incomplete, please enter a number");
                }
            }
        }

        private void addItemBotton(object sender, EventArgs e)
        {
            ItemNumberTxtBox.Visible = true;
            ItemNumberLbl.Visible = true;
            QuantityLbl.Visible = true;
            ItemQuantityTxtBx.Visible = true;
            AddItemAction.Visible = true;
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void AddItemAction_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                using (var dataBaseConnection = new DataClasses1DataContext())
                {
                    currentUser.resetDBConncetion(dataBaseConnection);
                    try
                    {

                        currentUser.addItemToOrder(Convert.ToInt32(ItemNumberTxtBox.Text), Convert.ToInt32(ItemQuantityTxtBx.Text));          
                        MessageBox.Show("Item succesfully added.");
                        PlaceOrderButton.Visible = true;
                    }
                    catch
                    {
                        MessageBox.Show("Item not added, try again.");
                    }
                    ItemNumberTxtBox.Text = "";
                    ItemQuantityTxtBx.Text = "";
                }
            }
        }

        private void ItemQuantityTxtBx_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlaceOrderButton_Click(object sender, EventArgs e)
        {
            if(currentUser != null)
            {
                using (var dataBaseConnection = new DataClasses1DataContext())
                {
                    currentUser.resetDBConncetion(dataBaseConnection);
                    try
                    {
                        if (currentUser.placeOrder())
                        {
                            MessageBox.Show("Order successfully placed.");
                            balanceAmount.Text = "$" + currentUser.CustomerBalance.ToString();
                            clearCart();
                        }

                        else
                        {
                            if(currentUser.getOrderSize() < 1)
                            {
                                MessageBox.Show("Add an item to your order before placing your order.");
                            }
                            if(currentUser.orderTotal() + currentUser.CustomerBalance > Order.maxBalance)
                            {
                                MessageBox.Show("Your order surpasses your maximum balance allowed, please pay your balance before making another order.");
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Something went wrong, try again.");
                    }
                }
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            clearCart();
        }

        public void clearCart()
        {
            if(currentUser != null)
            {
                currentUser.emptyOrderList();
                MessageBox.Show("Cart emptied successfully.");
            }
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void ViewAllOrdersButton_Click(object sender, EventArgs e)
        {
            using (var dataBaseConnection = new DataClasses1DataContext())
            {
                currentUser.resetDBConncetion(dataBaseConnection);
                ViewAllOrdersListView.Items.Clear();

                var orderList = currentUser.getOrdersForCustomer();
                foreach (var order in orderList)
                {
                    var row = new String[] { order.NUMBER.ToString(), order.DATE.ToString(), order.ORDER_STATUS, order.PAYMENT_STATUS, order.TOTAL.ToString() };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = order;
                    ViewAllOrdersListView.Items.Add(lvi);
                }
               
                ExitViewOrdersButton.Visible = true;
                ViewAllOrdersListView.Visible = true;
                ViewOrdersInDateRangeListView.Visible = false;
                ViewOrdersInRangeListView.Visible = false;
            }
        }

        private void ExitViewOrdersButton_Click(object sender, EventArgs e)
        {
            ViewAllOrdersListView.Visible = false;

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            MinCostLbl.Visible = true;
            MinCostTxtBox.Visible = true;
            MaxCostLbl.Visible = true;
            MaxCostTxtBox.Visible = true;
            EnterViewOrdersInRangeButton.Visible = true;
        }

        private void EnterViewOrdersInRangeButton_Click(object sender, EventArgs e)
        {
            using (var dataBaseConnection = new DataClasses1DataContext())
            {
                currentUser.resetDBConncetion(dataBaseConnection);
                ViewOrdersInRangeListView.Items.Clear();

                var orderList = currentUser.getOrderInPriceRange(Convert.ToDecimal(MinCostTxtBox.Text), Convert.ToDecimal(MaxCostTxtBox.Text));
                foreach (var order in orderList)
                {
                    var row = new String[] { order.NUMBER.ToString(), order.DATE.ToString(), order.ORDER_STATUS, order.PAYMENT_STATUS, order.TOTAL.ToString() };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = order;
                    ViewOrdersInRangeListView.Items.Add(lvi);
                }


                ExitViewOrdersButton.Visible = true;
                ViewOrdersInRangeListView.Visible = true;
                MaxCostTxtBox.Text = "";
                MinCostTxtBox.Text = "";
                ExitViewInRangeButton.Visible = true;
                ViewAllOrdersListView.Visible = false;
                ViewOrdersInDateRangeListView.Visible = false;
            }
        }

        private void ExitViewInRangeButton_Click(object sender, EventArgs e)
        {
            ViewOrdersInRangeListView.Visible = false;
        }

        private void OrdersInDateRangeButton_Click(object sender, EventArgs e)
        {
            StartDateLbl.Visible = true;
            StartDateTxtBox.Visible = true;
            EndDateLbl.Visible = true;
            EndDateTxtBox.Visible = true;
            ViewOrderDateRangeButton.Visible = true;
        }

        private void ViewOrderDateRangeButton_Click(object sender, EventArgs e)
        {
            using (var dataBaseConnection = new DataClasses1DataContext())
            {
                try
                {
                    currentUser.resetDBConncetion(dataBaseConnection);
                    ViewOrdersInRangeListView.Items.Clear();

                    var orderList = currentUser.getOrdersInDateRange(Convert.ToDateTime(StartDateTxtBox.Text).Date, Convert.ToDateTime(EndDateTxtBox.Text).Date);
                    foreach (var order in orderList)
                    {
                        var row = new String[] { order.NUMBER.ToString(), order.DATE.ToString(), order.ORDER_STATUS, order.PAYMENT_STATUS, order.TOTAL.ToString() };
                        var lvi = new ListViewItem(row);
                        lvi.Tag = order;
                        ViewOrdersInRangeListView.Items.Add(lvi);
                    }


                    ViewOrdersInDateRangeListView.Visible = true;
                    ExitViewOrderDateRangeButton.Visible = true;
                    EndDateTxtBox.Text = "";
                    StartDateTxtBox.Text = "";
                    ViewAllOrdersListView.Visible = false;
                    ViewOrdersInRangeListView.Visible = false;
                }

                catch
                {
                    MessageBox.Show("Please enter your date in the form - MM/DD/YYYY");
                }
                
            }

            
        }

        private void ViewOrdersInDateRangeListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ExitViewOrderDateRangeButton_Click(object sender, EventArgs e)
        {
            ViewOrdersInDateRangeListView.Visible = false;
        }

        /*
        private void DisplayItemsDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                using (var dataBaseConnection = new DataClasses1DataContext())
                {
                    //DisplayItemsDataGridView1.DataSource = Items.getItems();

                    Items.db = new DataClasses1DataContext();
                    var items = Items.getItemsObj();
                    var itemName = Items.getItemName();


                    ListViewItem itemsToDisplay = new ListViewItem(items.ToString());
                    foreach (var item in items)
                    {
                        listView1.Items.Add(item.ITEM_ID.ToString() + ", " + item.I_NAME + ", " + item.I_DESCRIPTION + ", " + item.I_PRICE.ToString());
                    }
                }
            }

            catch
            {
                MessageBox.Show("Did not upload items");
            }
            
        }

        */



        /*
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var dataBaseConnection = new DataClasses1DataContext())
                {
                    //DisplayItemsDataGridView1.DataSource = Items.getItems();

                    Items.db = dataBaseConnection;
                    var items = Items.getItemsObj();
                    var itemName = Items.getItemName();


                    ListViewItem itemsToDisplay = new ListViewItem(items.ToString());
                    foreach (var item in items)
                    {
                        listView1.Items.Add(item.ITEM_ID.ToString() + ", " + item.I_NAME + ", " + item.I_DESCRIPTION + ", " + item.I_PRICE.ToString());
                    }
                }
            }

            catch
            {
                MessageBox.Show("Did not upload items");
            }
        }
        */
    }
}
