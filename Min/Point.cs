using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedloTests
{
    public class Point
    {
        public Point (int coordx, int coordy, int value)
        {
            CoordX = coordx;
            CoordY = coordy;
            Value = value;
        }

        public int CoordX 
        {
            get
            {
                return this.CoordX;
            }
            set
            {
                this.CoordX = value;
            }
        }
        public int CoordY
        {
            get
            {
                return this.CoordY;
            }
            set
            {
                this.CoordY = value;
            }
        }
        public int Value
        {
            get
            {
                return this.Value;
            }
            set
            {
                this.Value = value;
            }
        }

        public double HashPoint
        {
            get
            {
                var hash = (this.CoordX + this.CoordY * 100 + (double)(this.Value / 151.0));
                return hash;
            }
        }
    }
}
