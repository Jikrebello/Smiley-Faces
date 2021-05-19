using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smiley_Faces
{
    public partial class Form1 : Form
    {
        readonly Graphics gfx;

        public Form1()
        {
            InitializeComponent();
            gfx = CreateGraphics();
            gfx.Clear(DefaultBackColor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rectangleCenterX = ClientRectangle.Width / 2;
            int rectangleCenterY = ClientRectangle.Height / 2;

            SmileyFace redFace = new SmileyFace(rectangleCenterX + 10, rectangleCenterY + 10, Color.Red, Color.Black);
            SmileyFace blueFace = new SmileyFace(rectangleCenterX - 100, rectangleCenterY, Color.Blue, Color.White);
            SmileyFace greenFace = new SmileyFace(rectangleCenterX + 100, rectangleCenterY, Color.Green, Color.Black);
            SmileyFace yellowFace = new SmileyFace(rectangleCenterX - 50, rectangleCenterY + 100, Color.Yellow, Color.Black);
            SmileyFace orangeFace = new SmileyFace(rectangleCenterX, rectangleCenterY - 100, Color.Orange, Color.Black);
            redFace.Paint(gfx);
            blueFace.Paint(gfx);
            greenFace.Paint(gfx);
            yellowFace.Paint(gfx);
            orangeFace.Paint(gfx);

        }
    }
}
