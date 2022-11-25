using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color uiColor = Color.LimeGreen;
        int uiThickness = 2;

        Pen uiPen;
        
        private void GameView_Paint(object sender, PaintEventArgs e)
        {
            uiPen = new Pen(uiColor, uiThickness);

            GameView_DrawBorder(sender, e);
            for (int i = 0; i < n; i++)
            {
                e.Graphics.DrawEllipse(uiPen, new Rectangle(new Point(100 + 100 * i, 100), new Size(50, 50)));
            }
        }

        private void GameView_DrawBorder(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(uiPen,
                new Rectangle(uiThickness / 2, uiThickness / 2,
                              gameView.Width - uiThickness, gameView.Height - uiThickness));
        }
    }
}
