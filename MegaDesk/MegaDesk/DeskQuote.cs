using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class DeskQuote
    {
        // Properties set from master price list
        public decimal PricePerSquareInch { get; }
        public decimal PricePerDrawer { get; }
        public decimal BasePrice { get; }
        public decimal SurfacePriceFloor { get; }
        public decimal MaterialCost { get; set; }
        public KeyValuePair<string, decimal> Shipping { get; set; }

        public int Id { get; }
        public Desk Desk { get; set; }
        public string CustomerName { get; set; }

        public DeskQuote(decimal pricePerSquareInch, decimal pricePerDrawer, decimal basePrice, decimal surfacePriceFloor)
        {
            this.PricePerSquareInch = pricePerSquareInch;
            this.PricePerDrawer = pricePerDrawer;
            this.BasePrice = basePrice;
            this.SurfacePriceFloor = surfacePriceFloor;
            this.MaterialCost = 0;
            this.Shipping = new KeyValuePair<string, decimal>("None", 0);
            this.Desk = new Desk();
            this.CustomerName = "Customer Name";
        }

        // Computed properties
        public decimal DrawerCost
        {
            get
            {
                return PricePerDrawer * Desk.DrawerCount;
            }
        }

        public decimal SizeOverage
        {
            get
            {
                if (Desk.SurfaceArea > SurfacePriceFloor)
                    return (Desk.SurfaceArea - SurfacePriceFloor);
                else
                    return 0;
            }
        }

        public decimal SizeCost
        {
            get
            {
                return SizeOverage * PricePerSquareInch;
            }
        }

        public decimal QuotePrice
        {
            get
            {
                return BasePrice + MaterialCost + DrawerCost + SizeCost;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("\n{\n");
            str.Append("    Object:             DeskQuote\n");
            str.Append("    PricePerSquareInch: " + this.PricePerSquareInch + "\n");
            str.Append("    PricePerDrawer:     " + this.PricePerDrawer + "\n");
            str.Append("    BasePrice:          " + this.BasePrice + "\n");
            str.Append("    SurfacePriceFloor:  " + this.SurfacePriceFloor + "\n");
            str.Append("    MaterialCost:       " + this.MaterialCost + "\n");
            str.Append("    Shipping:           " + this.Shipping + "\n");
            str.Append("    CustomerName:       " + this.CustomerName + "\n");
            str.Append("    Desk:               " + this.Desk.ToString().Replace("\n", "\n    ") + "\n");
            str.Append("}\n");

            return str.ToString();
        }
    }
}
