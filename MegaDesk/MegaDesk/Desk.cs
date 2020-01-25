using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
    public class Desk
    {
        // Desk configuration boundaries
        public const decimal WIDTH_MIN = 24;
        public const decimal WIDTH_MAX = 96;
        public const decimal DEPTH_MIN = 12;
        public const decimal DEPTH_MAX = 48;
        public const int DRAWER_MIN = 0;
        public const int DRAWER_MAX = 7;

        // Private properties
        private decimal width;
        private decimal depth;
        private int drawerCount;

        // Public properties
        public DesktopMaterial Material { get; set; }

        // Default constructor sets values to the least expensive opitons
        public Desk()
        {
            this.Width = WIDTH_MIN;
            this.Depth = DEPTH_MIN;
            this.DrawerCount = DRAWER_MIN;
            this.Material = DesktopMaterial.Pine;
        }

        public Desk(decimal width, decimal depth, int drawerCount, DesktopMaterial material)
        {
            this.Width = width;
            this.Depth = depth;
            this.DrawerCount = drawerCount;
            this.Material = material;
        }

        // Accessor for width
        public decimal Width
        {
            get
            {
                return width;
            }

            set
            {
                if (value >= WIDTH_MIN && value <= WIDTH_MAX)
                {
                    width = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        // Accessor for depth
        public decimal Depth
        {
            get
            {
                return depth;
            }

            set
            {
                if (value >= DEPTH_MIN && value <= DEPTH_MAX)
                {
                    depth = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        // Accessor for drawerCount
        public int DrawerCount
        {
            get
            {
                return drawerCount;
            }

            set
            {
                if (value >= DRAWER_MIN && value <= DRAWER_MAX)
                {
                    drawerCount = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        // Calculated property for surface area
        public decimal SurfaceArea
        {
            get 
            { 
                return this.Width * this.Depth;
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("\n{\n");
            str.Append("    Object:   Desk\n");
            str.Append("    Width:    " + this.Width + "\n");
            str.Append("    Depth:    " + this.Depth + "\n");
            str.Append("    Drawers:  " + this.DrawerCount + "\n");
            str.Append("    Material: " + this.Material + "\n");
            str.Append("}\n");

            return str.ToString();
        }
    }
}
