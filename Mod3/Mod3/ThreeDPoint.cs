using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mod3
{
    public struct ThreeDPoint
    {
        private int _x;
        private int _y;
        private int _z;

        public ThreeDPoint(int x, int y, int z)
        {
            throw new System.NotImplementedException();
        }

        public int X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }

        public int Z
        {
            get
            {
                return _z;
            }

            set
            {
                _z = value;
            }
        }
    }
}