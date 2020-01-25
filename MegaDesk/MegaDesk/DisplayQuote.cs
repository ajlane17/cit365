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
    public partial class DisplayQuote : Form
    {

        private DeskQuote deskQuote { get; set; }

        public DisplayQuote(DeskQuote quote)
        {
            InitializeComponent();

            deskQuote = quote;

            updateQuoteDisplay();
        }

        private void updateQuoteDisplay()
        {
            totalSizeLabel.Text = (deskQuote.Desk.SurfaceArea).ToString();
            basePriceLabel.Text = formatToCurrency(deskQuote.BasePrice);
            baseSizeLabel.Text = deskQuote.SurfacePriceFloor.ToString();
            costPerInchLabel.Text = formatToCurrency(deskQuote.PricePerSquareInch);
            sizeOverageLabel.Text = deskQuote.SizeOverage.ToString();
            sizeCostLabel.Text = formatToCurrency(deskQuote.SizeCost);
            pricePerDrawerLabel.Text = formatToCurrency(deskQuote.PricePerDrawer);
            drawerCostLabel.Text = formatToCurrency(deskQuote.DrawerCost);
            materialTypeLabel.Text = deskQuote.Desk.Material.ToString();
            materialCostLabel.Text = formatToCurrency(deskQuote.MaterialCost);
            shippingMethodLabel.Text = deskQuote.Shipping.Key;
            shippingCostLabel.Text = formatToCurrency(deskQuote.Shipping.Value);
            totalCostLabel.Text = formatToCurrency(deskQuote.QuotePrice);
        }

        private string formatToCurrency(decimal value)
        {
            return string.Format("{0:0.00}", value);
        }
    }
}
