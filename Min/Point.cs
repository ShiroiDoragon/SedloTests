using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedloTests
{
    public class Point
    {
        protected int pX, pY, pV;
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
                return this.pX;
            }
            set
            {
                this.pX = value;
            }
        }
        public int CoordY
        {
            get
            {
                return this.pY;
            }
            set
            {
                this.pY = value;
            }
        }
        public int Value
        {
            get
            {
                return this.pV;
            }
            set
            {
                this.pV = value;
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
