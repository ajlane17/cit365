using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//This class is very similar to DeskQuote, however it is normalized for viewing in a DataGrid.
//Dan Crosby 2/7/20

namespace MegaDesk
{
    public class DeskQuoteView
    {

        public string CustomerName { get; set; }

        public string Dimensions { get; set;}

        public int DrawerCount { get; set; }

        public string Material { get; set; }

        public string ShippingMethod { get; set; }

        public string QuotePrice { get; set; }

        public DeskQuoteView(DeskQuote dq)
        {
            try
            {
                this.CustomerName = dq.CustomerName;
                this.Dimensions = String.Format("{0:0.}W by {1:0.}D", dq.Desk.Width, dq.Desk.Depth);
                this.DrawerCount = dq.Desk.DrawerCount;
                this.Material = dq.Desk.Material.ToString();
                this.ShippingMethod = dq.Shipping.Key;
                this.QuotePrice = String.Format("${0,10:0.00}", dq.QuotePrice);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error converting DeskQuote ID " + dq.Id + " to a DeskQuoteView.  : " + ex.Message,"MegaDesk 2.0");
                throw;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("CustomerName:  " + this.CustomerName);
            str.Append(" Cost: " + this.QuotePrice.ToString());

            return str.ToString();
        }
    }
}
