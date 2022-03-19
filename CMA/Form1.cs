using CMA_BackendLib;

namespace CMA
{
    public partial class MainForm : Form
    {
        #region Declaration & Initialization
        public LinkedList<MenuItem> menuList = new();
        public LinkedList<MenuItem> cart = new();
        
        public MainForm()
        {
            //Adds 16 MENUITEM presets to the menuList.
            menuList.AddLast(new MenuItem("11", "Big Math", 95));
            menuList.AddLast(new MenuItem("12", "Soo Lit\'", 50));
            menuList.AddLast(new MenuItem("13", "Crisping Lacson", 65));
            menuList.AddLast(new MenuItem("14", "Green Minded", 80));

            menuList.AddLast(new MenuItem("21", "Cheese with Benefits", 60));
            menuList.AddLast(new MenuItem("22", "Baby Q", 50));
            menuList.AddLast(new MenuItem("23", "Soury not Sorry", 50));
            menuList.AddLast(new MenuItem("24", "Soo Lit\' Fries", 40));

            menuList.AddLast(new MenuItem("31", "Ice tea teh\'", 25));
            menuList.AddLast(new MenuItem("32", "Juice cool ord\'", 25));
            menuList.AddLast(new MenuItem("33", "Creamy BJ", 35));
            menuList.AddLast(new MenuItem("34", "Soy Lit\'", 35));

            menuList.AddLast(new MenuItem("41", "Sarahmel Sundae", 29));
            menuList.AddLast(new MenuItem("42", "Chocoleni Sundae", 29));
            menuList.AddLast(new MenuItem("43", "Isko-kies and Cream", 40));
            menuList.AddLast(new MenuItem("44", "Pakyo-gurt\'", 35));

            //Required method for Designer support. DO NOT MODIFY.
            InitializeComponent();
        }
        #endregion

        #region Column 1 - Burgers
        //Items are sorted by columns. This one is for Burgers.

        //This function is called when the corresponding counter is called.
        //Since each menu item has its own counter assigned to it,
        //A2C(...) will have to be called multiple times with different inputs.
        private void ChangedCounter11(object sender, EventArgs e)
        {
            /*
             * A2C(...) is short for "Add to Cart".
             * 
             * 11 is the ID for the "Big Math" MENUITEM. Each MENUITEM will have their own unique ID.
             * menuCounter11.Value gets the this item's counter's value.
             */
            A2C(11, menuCounter11.Value);
        }

        private void ChangedCounter12(object sender, EventArgs e)
        {
            A2C(12, menuCounter12.Value);
        }

        private void ChangedCounter13(object sender, EventArgs e)
        {
            A2C(13, menuCounter13.Value);
        }

        private void ChangedCounter14(object sender, EventArgs e)
        {
            A2C(14, menuCounter14.Value);
        }
        #endregion

        #region Column 2 - Fries
        private void ChangedCounter21(object sender, EventArgs e)
        {
            A2C(21, menuCounter21.Value);
        }

        private void ChangedCounter22(object sender, EventArgs e)
        {
            A2C(22, menuCounter22.Value);
        }

        private void ChangedCounter23(object sender, EventArgs e)
        {
            A2C(23, menuCounter23.Value);
        }

        private void ChangedCounter24(object sender, EventArgs e)
        {
            A2C(24, menuCounter24.Value);
        }
        #endregion

        #region Column 3 - Drinks
        private void ChangedCounter31(object sender, EventArgs e)
        {
            A2C(31, menuCounter31.Value);
        }

        private void ChangedCounter32(object sender, EventArgs e)
        {
            A2C(32, menuCounter32.Value);
        }

        private void ChangedCounter33(object sender, EventArgs e)
        {
            A2C(33, menuCounter33.Value);
        }

        private void ChangedCounter34(object sender, EventArgs e)
        {
            A2C(34, menuCounter34.Value);
        }
        #endregion

        #region Column 4 - Desserts
        private void ChangedCounter41(object sender, EventArgs e)
        {
            A2C(41, menuCounter41.Value);
        }

        private void ChangedCounter42(object sender, EventArgs e)
        {
            A2C(42, menuCounter42.Value);
        }

        private void ChangedCounter43(object sender, EventArgs e)
        {
            A2C(43, menuCounter43.Value);
        }

        private void ChangedCounter44(object sender, EventArgs e)
        {
            A2C(44, menuCounter44.Value);
        }
        #endregion

        #region Clickables
        //This function is called when the Reset button is clicked.
        private void ClickedReset(object sender, EventArgs e)
        {
            //Sets the PriceLabel's Text to display "Php0".
            PriceLabel.Text = "Php0";

            //Empties the internal cart.
            cart.Clear();

            //Sets each counter's value to 0.
            menuCounter11.Value = 0;
            menuCounter12.Value = 0;
            menuCounter13.Value = 0;
            menuCounter14.Value = 0;
            menuCounter21.Value = 0;
            menuCounter22.Value = 0;
            menuCounter23.Value = 0;
            menuCounter24.Value = 0;
            menuCounter31.Value = 0;
            menuCounter32.Value = 0;
            menuCounter33.Value = 0;
            menuCounter34.Value = 0;
            menuCounter41.Value = 0;
            menuCounter42.Value = 0;
            menuCounter43.Value = 0;
            menuCounter44.Value = 0;

            //Makes Purchase and Reset buttons NOT clickable.
            PurchaseButton.Enabled = false;
            ResetButton.Enabled = false;
        }

        //This function is called when the Purchase button is clicked.
        private void ClickedPurchase(object sender, EventArgs e)
        {
            //Creates a DICTIONARY. This will let the app keep track of MENUITEMs and INTs as a grouped pair.
            Dictionary<MenuItem, int> itemCountContainer = new();

            string outputMsg = "Receipt:\n"; //The STRING that will be displayed on the pop-up.
            float total = 0; //Total price of all the MENUITEMs.

            //For each MENUITEM in cart List...
            foreach (MenuItem item in cart)
            {
                //If itemCountContainer contains that MENUITEM...
                //Set that MENUITEM's pair's value to +1 its original value.
                if (itemCountContainer.ContainsKey(item)) itemCountContainer[item] += 1;

                //Else, add a new pair into the DICTIONARY, using that MENUITEM and value to 1 as default.
                else itemCountContainer.Add(item, 1);
            }

            //For each PAIR in the itemCountContainer DICTIONARY...
            foreach (KeyValuePair<MenuItem, int> pair in itemCountContainer)
            {
                //Add this string to the outputMsg.
                outputMsg += "\n"+ pair.Value + "x " + pair.Key.ItemName + " - Php" + pair.Key.Price;

                //Accumulate the total with the MENUITEM's Price x the PAIR's Value.
                total += pair.Key.Price * pair.Value;
            }

            //Add the total to the outputMsg.
            outputMsg += "\n\nTotal: Php" + total;

            //Displays the pop-up message.
            MessageBox.Show(outputMsg, "Purchase Successful!");

            //Calls ClickedReset(...).
            ClickedReset(sender, e);
        }
        #endregion

        #region Shortcuts
        /// <summary>
        /// Automatically adds/removes items from the internal cart.
        /// </summary>
        /// <param name="idInt">The ID of the target MenuItem listed in menuList.</param>
        /// <param name="count">A number set from PriceLabel's Value.</param>
        private void A2C(int idInt, decimal count)
        {
            Console.WriteLine("Setting count for " + idInt + " to " + count + ".");

            LinkedList<MenuItem> cartCopy = new(cart); //Creates a new empty list "cartCopy"
            string id = idInt.ToString(); //Converts idInt to STRING, then assigns it to a new variable "id".
            int countInt = Convert.ToInt16(count); //Converts count DECIMAL into an INT.
            decimal totalPrice = 0; //Keeps track of the total price.

            //Clears the cart LIST.
            cart.Clear();

            //This FOREACH loop will only include items other than the target item.
            //For each MENUITEM in cartCopy LIST...
            foreach (MenuItem item in cartCopy)
            {
                //If MENUITEM's ID is not the same as input ID...
                if (item.ID != id)
                {
                    //Add the MENUITEM to the cart LIST.
                    cart.AddLast(item);

                    //Accumulate the MENUITEM Price to totalPrice.
                    totalPrice += Convert.ToDecimal(item.Price);
                }
            }

            //This FOREACH loop readds the target item X times.
            //For X times... (based on the counter value)
            for (int i = 0; i < countInt; i++)
            {
                //For each MENUITEM in menuList List...
                foreach (MenuItem menuItem in menuList)
                {
                    //If the MENUITEM's ID is the same as input ID...
                    if (menuItem.ID == id)
                    {
                        //Add the MENUITEM to the cart LIST.
                        cart.AddLast(menuItem);

                        //Accumulate the MENUITEM Price to totalPrice.
                        totalPrice += Convert.ToDecimal(menuItem.Price);
                    }
                }
            }

            //Changes the PriceLabel's text to display "PhpXXX..."
            PriceLabel.Text = "Php" + totalPrice.ToString();

            //Makes the Reset and Purchase buttons clickable.
            ResetButton.Enabled = true;
            PurchaseButton.Enabled = true;
        }
        #endregion
    }
}