namespace RestarauntGui
{
    partial class CUSTOMER_HAS_ORDER
    {
    }

    partial class PERSON
    {
    }

    partial class DataClasses1DataContext
    {
    }

    partial class ORDER_HAS_ITEM
    {
    }
}
/*
 Step 1. User inputs data into input boxes

Step 2. User then clicks on login button to 'trigger' an event

Step 3. your 'event listener' validates the information from the input boxes and requests the data from the database.
i.e 
CurrentUser = myUsers.Where(user => user.username == usernameInputBox.text  
&& user.pass == userPassInput.text).select(//values you want)

4. Use the values you retrieved in the event listener to update the gui. 
This would mean having a designated place where you are going to display the data. 
For example a label that previously didnt have any text gets displayed with a "Welcome {User123}"
 */