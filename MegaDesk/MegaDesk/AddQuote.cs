using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        // Master price controls intended to come from elsewhere, but here for now
        public const decimal BASE_PRICE              = 200;
        public const decimal PRICE_PER_SQUARE_INCH   = 1;
        public const decimal PRICE_PER_DRAWER        = 50;
        public const decimal MATERIAL_PRICE_OAK      = 200;
        public const decimal MATERIAL_PRICE_LAMINATE = 100;
        public const decimal MATERIAL_PRICE_PINE     = 50;
        public const decimal MATERIAL_PRICE_ROSEWOOD = 300;
        public const decimal MATERIAL_PRICE_VENEER   = 125;
        public const decimal SURFACE_PRICING_FLOOR   = 1000;
        public const decimal SHIPPING_TIER_1_FLOOR   = 0;
        public const decimal SHIPPING_TIER_2_FLOOR   = 1000;
        public const decimal SHIPPING_TIER_3_FLOOR   = 2000;

        // Toggle for form validation
        private bool performValidation = false;

        // Toggle for dnyamic quote updates
        private bool performDynamicUpdates = false;

        private Dictionary<DesktopMaterial, decimal> materialPrices;
        private Dictionary<string, decimal[]> shippingRates;
        private Dictionary<string, decimal[]> numericUpDownBounds;
        private DeskQuote deskQuote;

        public AddQuote()
        {
            InitializeComponent();

            // Initialize collection of materials and prices
            materialPrices = new Dictionary<DesktopMaterial, decimal>();
            materialPrices.Add(DesktopMaterial.Laminate, MATERIAL_PRICE_LAMINATE);
            materialPrices.Add(DesktopMaterial.Oak,      MATERIAL_PRICE_OAK);
            materialPrices.Add(DesktopMaterial.Pine,     MATERIAL_PRICE_PINE);
            materialPrices.Add(DesktopMaterial.Rosewood, MATERIAL_PRICE_ROSEWOOD);
            materialPrices.Add(DesktopMaterial.Veneer,   MATERIAL_PRICE_VENEER);

            // Initialize shipping rates
            shippingRates = new Dictionary<string, decimal[]>();
            shippingRates.Add("Normal - 14 Days", new decimal[] { 0, 0, 0 });
            shippingRates.Add("Rush - 7 Days",    new decimal[] { 30, 35, 40 });
            shippingRates.Add("Rush - 5 Days",    new decimal[] { 40, 50, 60 });
            shippingRates.Add("Rush - 3 Days",    new decimal[] { 60, 70, 80 });

            // Initialize the collection of NumericUpDowns and MIN, MAX for validation
            numericUpDownBounds = new Dictionary<string, decimal[]>();
            numericUpDownBounds.Add(deskWidth.Name, new decimal[] { Desk.WIDTH_MIN, Desk.WIDTH_MAX });
            numericUpDownBounds.Add(deskDepth.Name, new decimal[] { Desk.DEPTH_MIN, Desk.DEPTH_MAX });
            numericUpDownBounds.Add(deskDrawerCount.Name, new decimal[] { Desk.DRAWER_MIN, Desk.DRAWER_MAX });

            deskQuote = new DeskQuote(PRICE_PER_SQUARE_INCH, PRICE_PER_DRAWER, BASE_PRICE, SURFACE_PRICING_FLOOR);

            Console.WriteLine(deskQuote.ToString());

            // Set basic form fields to current desk values
            this.customerName.Text     = deskQuote.CustomerName;
            this.deskWidth.Value       = deskQuote.Desk.Width;
            this.deskDepth.Value       = deskQuote.Desk.Depth;
            this.deskDrawerCount.Value = deskQuote.Desk.DrawerCount;

            // Populate the materials list and set it to current desk value
            List<DesktopMaterial> materials = new List<DesktopMaterial>(this.materialPrices.Keys);
            populateComboBox<DesktopMaterial>(materials, this.deskMaterial);
            this.deskMaterial.SelectedIndex = deskMaterial.FindString(deskQuote.Desk.Material.ToString());

            // Populate the shipping method list and default to "normal"
            List<string> shippingMethodNames = new List<string>(this.shippingRates.Keys);
            populateComboBox<string>(shippingMethodNames, this.shippingMethod);
            setShippingMethod(shippingRates.Keys.First(), shippingRates.Values.First()[0]);
            this.shippingMethod.SelectedIndex = shippingMethod.FindString(deskQuote.Shipping.Key);

            // Update the quote display based on the initial values
            updateQuoteDisplay();

            // AFter initial field sets, allow dynamic updates
            performDynamicUpdates = true;
        }

        private void populateComboBox<T>(List<T> list, ComboBox comboBox)
        {
            foreach (T item in list)
            {
                comboBox.Items.Add(item.ToString());
            }
        }

        // Gets the material selection from the drop-down and returns the matching enum
        private DesktopMaterial getMaterialChoice()
        {
            DesktopMaterial materialChoice;
            Enum.TryParse(this.deskMaterial.GetItemText(this.deskMaterial.SelectedItem), out materialChoice);
            return materialChoice;
        }

        // Gets the shipping selection from the drop-down and returns a key value pair of method and cost
        private KeyValuePair<string, decimal> getShippingDetails()
        {
            KeyValuePair<string, decimal> shippingDetails;
            string selection;
            decimal cost;
            decimal deskSurfaceArea;
            
            selection = this.shippingMethod.GetItemText(this.shippingMethod.SelectedItem);

            deskSurfaceArea = deskWidth.Value * deskDepth.Value;

            if (deskSurfaceArea < SHIPPING_TIER_2_FLOOR)
                cost = shippingRates[selection][0];
            else if (deskSurfaceArea < SHIPPING_TIER_3_FLOOR)
                cost = shippingRates[selection][1];
            else
                cost = shippingRates[selection][2];

            shippingDetails = new KeyValuePair<string, decimal>(selection, cost);

            return shippingDetails;
        }

        // Updates the DeskQuote and child Desk object with the values from the form
        private void updateDeskConfiguration()
        {

            this.deskQuote.CustomerName = this.customerName.Text;
            this.deskQuote.Desk.Width = this.deskWidth.Value;
            this.deskQuote.Desk.Depth = this.deskDepth.Value;
            this.deskQuote.Desk.DrawerCount = Decimal.ToInt32(this.deskDrawerCount.Value);
            this.deskQuote.Desk.Material = getMaterialChoice();
            this.deskQuote.MaterialCost = materialPrices[this.deskQuote.Desk.Material];
            this.deskQuote.Shipping = getShippingDetails();
        }

        // Updates the running calculation display based on selections from the form fields
        private void updateQuoteDisplay()
        {
            decimal sizeQuote;
            decimal sizeOverageQuote;
            decimal sizeCostQuote;
            decimal drawerCostQuote;
            decimal materialCostQuote;
            decimal shippingCostQuote;
            decimal totalCostQuote;

            sizeQuote = deskWidth.Value * deskDepth.Value;

            if (sizeQuote <= SURFACE_PRICING_FLOOR)
                sizeOverageQuote = 0;
            else
                sizeOverageQuote = sizeQuote - SURFACE_PRICING_FLOOR;

            sizeCostQuote = sizeOverageQuote * PRICE_PER_SQUARE_INCH;

            drawerCostQuote = deskDrawerCount.Value * PRICE_PER_DRAWER;

            materialCostQuote = materialPrices[getMaterialChoice()];

            shippingCostQuote = getShippingDetails().Value;

            totalCostQuote = BASE_PRICE + sizeCostQuote + drawerCostQuote + materialCostQuote + shippingCostQuote;

            totalSizeLabel.Text = (deskWidth.Value * deskDepth.Value).ToString();
            basePriceLabel.Text = formatToCurrency(BASE_PRICE);
            baseSizeLabel.Text = SURFACE_PRICING_FLOOR.ToString();
            costPerInchLabel.Text = formatToCurrency(PRICE_PER_SQUARE_INCH);
            sizeOverageLabel.Text = sizeOverageQuote.ToString();
            sizeCostLabel.Text = formatToCurrency(sizeCostQuote);
            pricePerDrawerLabel.Text = formatToCurrency(PRICE_PER_DRAWER);
            drawerCostLabel.Text = formatToCurrency(drawerCostQuote);
            materialCostLabel.Text = formatToCurrency(materialCostQuote);
            shippingCostLabel.Text = formatToCurrency(shippingCostQuote);
            totalCostLabel.Text = formatToCurrency(totalCostQuote);
        }

        // Helper method to convert decimals to text with US currency formatting
        private string formatToCurrency(decimal value)
        {
            return string.Format("{0:0.00}", value);
        }

        // Helper method to set a shipping method selection in the dropdown
        private void setShippingMethod(string methodName, decimal cost)
        {
            deskQuote.Shipping = new KeyValuePair<string, decimal>(methodName, cost);
        }

        // Cancel button click event to close the form without saving
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel this quote?", "Cancel", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        // Save button event click event to initiate validation and update the quote objects
        private void Save_Click(object sender, EventArgs e)
        {
            // Toggle this to enable error event triggers
            performValidation = true;

            // If validate children returns true, fields are valid, 
            // proceed with operations, otherwise do nothing
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                try 
                {
                    updateDeskConfiguration();
                    MessageBox.Show("Quote Saved", "Success", MessageBoxButtons.OK);
                    Console.WriteLine("ORDER SUBMITTED:" + this.deskQuote.ToString());
                    DisplayQuote displayQuote = new DisplayQuote(deskQuote);
                    displayQuote.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to update the desk configuration, will not save. See the application logs for details.", "Error", MessageBoxButtons.OK);
                    Console.WriteLine(ex);
                }
            }
            else
            {
                MessageBox.Show("You're INVALID!", "Error", MessageBoxButtons.OK);
            }

            // Disable validating events again to allow free-form editing
            performValidation = false;
        }

        // Generic value change event to update the quote on any field update
        private void quoteFormField_ValueChanged(object sender, EventArgs e)
        {
            //
            if (performDynamicUpdates)
                updateQuoteDisplay();
        }

        // Generic numeric updown validating event to confirm value is within bounds
        private void numericUpDown_Validating(object sender, CancelEventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            string boxName = numericUpDown.Name;
            decimal valueMin = numericUpDownBounds[boxName][0];
            decimal valueMax = numericUpDownBounds[boxName][1];

            if (performValidation == true)
            {
                if (numericUpDown.Value < valueMin || numericUpDown.Value > valueMax)
                {
                    e.Cancel = true;
                    errorProvider.SetError(numericUpDown, $"The range must be between {valueMin} and {valueMax}");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(numericUpDown, null);
                }
            }
        }

        // Generic textbox validating event to confirm text fields are not empty
        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // We override validation behavior to avoid validation on change,
            // locking in the user to the field until they provide a valid value
            if (performValidation == true)
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    e.Cancel = true;
                    errorProvider.SetError(textBox, "Please provide a value");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider.SetError(textBox, null);
                }
            }
        }
    }
}
