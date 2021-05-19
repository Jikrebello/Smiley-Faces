using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smiley_Faces
{
    class CheckerBlock
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;
        public Color BlockColour;
        public Image BlockImage;

        public CheckerBlock(int _x, int _y, int _width, int _height, int _blockColour, int _blockImage)
        {
            X = _x;

        }
    }
}
