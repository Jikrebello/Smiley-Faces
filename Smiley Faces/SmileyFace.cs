using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smiley_Faces
{
    class SmileyFace
    {
        public int X;
        public int Y;
        public Color FaceColour;
        public Color SmileColour;

        public SmileyFace(int _x, int _y, Color _faceColour, Color _SmileColour)
        {
            X = _x;
            Y = _y;
            FaceColour = _faceColour;
            SmileColour = _SmileColour;
        }

        public void Paint(Graphics _gfx)
        {
            SolidBrush faceBrush = new SolidBrush(FaceColour);
            SolidBrush smileBrush = new SolidBrush(SmileColour);
            Pen smilePen = new Pen(smileBrush, 2);

            _gfx.FillEllipse(faceBrush, X, Y, 80, 80); // Head
            _gfx.DrawEllipse(smilePen, X + 20, Y + 30, 15, 7); // left eye
            _gfx.DrawEllipse(smilePen, X + 45, Y + 30, 15, 7); //right eye
            _gfx.FillEllipse(smileBrush, X + 25, Y + 31, 5, 5); // left pupils 
            _gfx.FillEllipse(smileBrush, X + 50, Y + 31, 5, 5); // right pupils
            _gfx.DrawArc(smilePen, X + 20, Y + 50, 40, 15, 0, 180); // mouth
        }
    }
}
