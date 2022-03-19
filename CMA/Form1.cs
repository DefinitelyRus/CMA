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
        private void MainFormShown(object sender, EventArgs e)
        {

        }
        #endregion

        #region Column 1
        private void ChangedCounter11(object sender, EventArgs e)
        {
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

        #region Column 2
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

        #region Column 3
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

        #region Column 4
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
        private void ClickedReset(object sender, EventArgs e)
        {
            PriceLabel.Text = "Php0";
            cart.Clear();

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

            PurchaseButton.Enabled = false;
            ResetButton.Enabled = false;
        }

        private void ClickedPurchase(object sender, EventArgs e)
        {
            Dictionary<MenuItem, int> itemCountContainer = new();
            string outputMsg = "Receipt:\n";
            float total = 0;

            foreach (MenuItem item in cart)
            {
                if (itemCountContainer.ContainsKey(item)) itemCountContainer[item] += 1;
                else itemCountContainer.Add(item, 1);
            }

            foreach (KeyValuePair<MenuItem, int> dict in itemCountContainer)
            {
                outputMsg += "\n"+ dict.Value + "x " + dict.Key.ItemName + " - Php" + dict.Key.Price;
                total += dict.Key.Price * dict.Value;
            }

            outputMsg += "\n\nTotal: Php" + total;

            MessageBox.Show(outputMsg, "Purchase Successful!");
            ClickedReset(sender, e);
        }
        #endregion

        #region Shortcuts
        /// <summary>
        /// Automatically adds/removes items from the internal cart.
        /// </summary>
        private void A2C(int idInt, decimal count)
        {
            Console.WriteLine("Setting count for " + idInt + " to " + count + ".");

            LinkedList<MenuItem> cartCopy = new(cart);
            string IdStr = idInt.ToString();
            int countInt = Convert.ToInt16(count);
            decimal totalPrice = 0;

            cart.Clear();

            int resetCounter = 0;
            foreach (MenuItem item in cartCopy)
            {
                if (item.ID != IdStr)
                {
                    cart.AddLast(item);
                    totalPrice += Convert.ToDecimal(item.Price);
                }
                else resetCounter++;
            }
            Console.WriteLine("Removed " + IdStr + " " + resetCounter + " times.\n");
            
            resetCounter = 0;
            for (int i = 0; i < countInt; i++)
            {
                Console.WriteLine("Index: " + i + "/" + countInt);
                if (count <= 0) break;

                Console.WriteLine("Adding to list...");
                foreach (MenuItem menuItem in menuList)
                {
                    if (menuItem.ID == IdStr)
                    {
                        cart.AddLast(menuItem);
                        totalPrice += Convert.ToDecimal(menuItem.Price);
                    }
                }
            }

            Console.WriteLine("Cart has " + cart.Count + " items.");
            foreach (MenuItem item in cart) Console.Write(item.ID + " ");
            PriceLabel.Text = "Php" + totalPrice.ToString();

            ResetButton.Enabled = true;
            PurchaseButton.Enabled = true;
        }
        #endregion
    }
}