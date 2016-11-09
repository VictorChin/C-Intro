using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mod3
{
    public struct Resolution
    {
        private int _width;
        private int _height;

        public int Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

        public Resolution(int width, int height)
        {
            throw new System.NotImplementedException();
        }
    }
}