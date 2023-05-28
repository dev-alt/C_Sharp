using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ToiOhomaiMarketPlace
{
    public partial class MarketForm : Form
    {
        // private variables
        
        private string _title, _condition, _description;
        private double _price; 
        public List<MarketPlace> marketplace = new List<MarketPlace>(); // Dynamic marketplace List object
        private readonly Random _rc = new Random(); // Random number generator




        public MarketForm() 
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is called when the user clicks the Add button.
        /// </summary>
        private void LoadListings()
        {
            lsbListings.Items.Clear();
            lsbListings.Items.Add("Name \t Price \t Condition \t Description");
            lsbListings.Items.Add("-----------------------------------------------------------------------");
            foreach (MarketPlace item in marketplace) // Loop through List with foreach
            {
                lsbListings.Items.Add(item.MarketListingInfo());
            }
        }


        /// <summary>
        /// This method is used to populate the marketplace list with random items.
        /// </summary>
        private void DefaultListings() 
        {
            // Preload listings
            marketplace.Add(new MarketPlace("Friendly cat") { ListingTitle = "Cat", ListingPrice = 35.56, Condition = "New" });
            marketplace.Add(new MarketPlace("Old painting") { ListingTitle = "Painting", ListingPrice = 667.56, Condition = "Old" });
            marketplace.Add(new MarketPlace("Broken bookshelf") { ListingTitle = "Bookshelf", ListingPrice = 7.56, Condition = "Acceptable" });
            marketplace.Add(new MarketPlace("Brand new table") { ListingTitle = "Table", ListingPrice = 1832.56, Condition = "New" });
            marketplace.Add(new MarketPlace("Tiger Mask") { ListingTitle = "Tiger Mask", ListingPrice = 58.56, Condition = "Good" });

        }


        /// <summary>
        /// This method is called when the user clicks the Add button.
        /// </summary>
        private void defaultListingBtn_Click(object sender, EventArgs e)
        {
            panelSelected.Height = defaultListingBtn.Height;
            panelSelected.Top = defaultListingBtn.Top;
            tabControlGroup.SelectTab(tabDefault); // Select the default tab
        }

        private void propertyListingBtn_Click(object sender, EventArgs e) 
        {
            panelSelected.Height = propertyListingBtn.Height;
            panelSelected.Top = propertyListingBtn.Top;
            tabControlGroup.SelectTab(tabProperty); // Select the property tab
        }

        private void carListingBtn_Click(object sender, EventArgs e)
        {
            panelSelected.Height = carListingBtn.Height;
            panelSelected.Top = carListingBtn.Top;
            tabControlGroup.SelectTab(tabCar); // Select the car tab
        }

        /// <summary>
        /// This method is called when the form loads
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            DefaultListings();
            LoadListings();
        }
        


        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete the selected item in listbox and remove from list and ask user
            if ((lsbListings.Items.Count > 0) && (lsbListings.SelectedIndex >= 1)) 
            { 
                if (MessageBox.Show(@"Are you sure to delete?", @"Remove List", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    marketplace.RemoveAt(lsbListings.SelectedIndex - 2); // Remove item from List
                    LoadListings();
                    MessageBox.Show(@"Entry has been removed"); // Display message saying entry has been deleted
                }
            }
            else
            {
                MessageBox.Show(@"Please select an entry to delete");
            }

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {

            //clear all items from listbox and list
            if (lsbListings.Items.Count > 0)
            {
                if (MessageBox.Show(@"Are you sure to remove all entries", @"Remove List", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) // Asks user if they want to remove
                {
                    lsbListings.Items.Clear();
                    marketplace.Clear();
                    MessageBox.Show(@"All entries have been removed");
                }
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            //change the background colour of all panels to a random colour    
            panelLeft.BackColor = System.Drawing.Color.FromArgb(_rc.Next(256), _rc.Next(256), _rc.Next(256));
            panelBottom.BackColor = System.Drawing.Color.FromArgb(_rc.Next(256), _rc.Next(256), _rc.Next(256));
            panelTopLeft.BackColor = System.Drawing.Color.FromArgb(_rc.Next(256), _rc.Next(256), _rc.Next(256));
            tabShow.BackColor = System.Drawing.Color.FromArgb(_rc.Next(256), _rc.Next(256), _rc.Next(256));
            tabControlGroup.BackColor = System.Drawing.Color.FromArgb(_rc.Next(256), _rc.Next(256), _rc.Next(256));
            tabProperty.BackColor = System.Drawing.Color.FromArgb(_rc.Next(256), _rc.Next(256), _rc.Next(256));
            tabDefault.BackColor = System.Drawing.Color.FromArgb(_rc.Next(256), _rc.Next(256), _rc.Next(256));
            tabCar.BackColor = System.Drawing.Color.FromArgb(_rc.Next(256), _rc.Next(256), _rc.Next(256));
        }

        private void showListingsBtn_Click(object sender, EventArgs e)
        {
            panelSelected.Height = showListingsBtn.Height;
            panelSelected.Top = showListingsBtn.Top;
            tabControlGroup.SelectTab(tabShow); // Select the show tab
        }

        private void btnAddDefault_Click(object sender, EventArgs e)
        {
            // Add a new item to the list
            if (txtTitleDefault.Text == "")
            {
                MessageBox.Show(@"Please enter title of your product"); // Error message if user does not enter a title
            }
            else
            {
                if (!txtPriceDefault.Text.All(char.IsDigit)) // Checks if the user entered a number
                {
                    MessageBox.Show(@"Please enter a valid price");
                }
                else
                {
                    if (cboConditionDefault.SelectedIndex == -1)
                    {
                        MessageBox.Show(@"Please select the condition");
                    }
                    else
                    {
                        if (txtDescDefault.Text == "")
                        {
                            MessageBox.Show(@"Please enter a description");
                        }
                        else
                        {
                            
                            _title = txtTitleDefault.Text;
                            _price = Convert.ToDouble(txtPriceDefault.Text);
                            _condition = cboConditionDefault.Text;
                            _description = txtDescDefault.Text;

                            // add object to the list
                            marketplace.Add(new MarketPlace(_description) { ListingTitle = _title, ListingPrice = _price, Condition = _condition });
                            //show in listbox
                            LoadListings();
                            //show massage when item is added
                            MessageBox.Show($@"{_title} successfully added");
                            //switch to show tab
                            tabControlGroup.SelectTab(tabShow);
                        }
                    }
                }
            }
        }
    }
}