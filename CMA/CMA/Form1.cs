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

            InitializeComponent();
        }
        #endregion

        #region Column 1
        private void ChangedCounter11(object sender, EventArgs e)
        {
            a2c(11, menuCounter11.Value);
        }

        private void ChangedCounter12(object sender, EventArgs e)
        {
            a2c(12, menuCounter11.Value);
        }

        private void ChangedCounter13(object sender, EventArgs e)
        {
            a2c(13, menuCounter11.Value);
        }

        private void ChangedCounter14(object sender, EventArgs e)
        {
            a2c(14, menuCounter11.Value);
        }
        #endregion

        #region Column 2
        private void ChangedCounter21(object sender, EventArgs e)
        {
            a2c(21, menuCounter11.Value);
        }

        private void ChangedCounter22(object sender, EventArgs e)
        {
            a2c(22, menuCounter11.Value);
        }

        private void ChangedCounter23(object sender, EventArgs e)
        {
            a2c(23, menuCounter11.Value);
        }

        private void ChangedCounter24(object sender, EventArgs e)
        {
            a2c(24, menuCounter11.Value);
        }
        #endregion

        #region Column 3
        private void ChangedCounter31(object sender, EventArgs e)
        {
            a2c(31, menuCounter11.Value);
        }

        private void ChangedCounter32(object sender, EventArgs e)
        {
            a2c(32, menuCounter11.Value);
        }

        private void ChangedCounter33(object sender, EventArgs e)
        {
            a2c(33, menuCounter11.Value);
        }

        private void ChangedCounter34(object sender, EventArgs e)
        {
            a2c(34, menuCounter11.Value);
        }
        #endregion

        #region Column 4
        private void ChangedCounter41(object sender, EventArgs e)
        {
            a2c(41, menuCounter11.Value);
        }

        private void ChangedCounter42(object sender, EventArgs e)
        {
            a2c(42, menuCounter11.Value);
        }

        private void ChangedCounter43(object sender, EventArgs e)
        {
            a2c(43, menuCounter11.Value);
        }

        private void ChangedCounter44(object sender, EventArgs e)
        {
            a2c(44, menuCounter11.Value);
        }
        #endregion

        #region Clickables
        private void ClickedReset(object sender, EventArgs e)
        {

        }

        private void ClickedPurchase(object sender, EventArgs e)
        {

        }
        #endregion

        private void MainFormShown(object sender, EventArgs e)
        {
            
        }

        #region Shortcuts
        /// <summary>
        /// Automatically adds/removes items from the internal cart.
        /// </summary>
        private void a2c(int idInt, decimal count)
        {
            Console.WriteLine("\nSetting count for " + idInt + " to " + count + ".");
            int countInt = Convert.ToInt16(count);
            string id = idInt.ToString();
            bool print = true;
            decimal totalPrice = 0;

            //Copies the contents of the internal cart. It will crash if you modify a list while using it as an index.
            LinkedList<MenuItem> tempCart = new(cart);

            //For each MenuItem in cart...
            foreach (MenuItem cartItem in tempCart)
            {
                //If item's ID is equal to input ID...
                if (cartItem.ID == id)
                {
                    //Remove item from cart.
                    cart.Remove(cartItem);
                }

                //One-time print.
                if (print)
                {
                    Console.WriteLine("Removed " + cartItem.ItemName + " from the cart.");
                    print = false;
                }

                //This will empty the cart of the target item.
                //They will be added back if count is more than 0.
            }

            //Copies changes back to internal cart.
            cart = new(tempCart);

            Console.WriteLine("Cart Length: " + cart.Count);

            //If count is more than 0...
            if (countInt > 0)
            {
                //For each MenuItem in menuList...
                foreach (MenuItem item in menuList)
                {
                    //If item's ID is equal to input ID...
                    if (item.ID == id)
                    {
                        //For X times...
                        for (int X = 0; X < countInt; X++)
                        {
                            Console.WriteLine("Added " + item.ItemName + " to cart " + (X+1) + " time(s).");

                            //Add MenuItem to cart.
                            cart.AddLast(item);
                        }
                    }
                }
            }

            foreach (MenuItem item in cart)
            {
                totalPrice += Convert.ToDecimal(item.Price);
                Console.WriteLine("Price: " + item.Price + "\nTotal: " + totalPrice);
            }

            PriceLabel.Text = "Php" + totalPrice;
        }
        #endregion
    }
}