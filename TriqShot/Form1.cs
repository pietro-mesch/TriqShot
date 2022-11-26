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

        private int nPlanets = 10;

        Color uiColor = Color.LimeGreen;
        int uiThickness = 2;

        Pen uiPen;

        private void GameView_Paint(object sender, PaintEventArgs e)
        {
            uiPen = new Pen(uiColor, uiThickness);

            GameView_DrawBorder(sender, e);
            GameView_DrawPlanets(e);
            GameView_DrawTrajectory(e);
        }

        private void GameView_DrawBorder(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(uiPen,
                new Rectangle(uiThickness / 2, uiThickness / 2,
                              gameView.Width - uiThickness, gameView.Height - uiThickness));
        }
        private void GameView_DrawPlanets(PaintEventArgs e)
        {
            for (int i = 0; i < nPlanets; i++)
            {
                e.Graphics.DrawEllipse(uiPen, new Rectangle(new Point(100 + 100 * i, 100), new Size(50, 50)));
            }
        }

        private void GameView_DrawTrajectory(PaintEventArgs e)
        {
            Random r = new Random();
            int pointsPerCycle = 100;
            int wavelength = r.Next(100, 401);
            int amplitude = r.Next(100, 401);
            Point startingPoint = new Point(50, 50);

            List<Point> points = new List<Point>();
            for (int i = 0; i < nPlanets + 1; i++)
            {
                for (int j = 0; j < pointsPerCycle; j++)
                {
                    points.Add(new Point(i * wavelength + j * wavelength / pointsPerCycle + startingPoint.X,
                                         (int)(Math.Sin(j * 2 * Math.PI / pointsPerCycle) * amplitude) + startingPoint.Y));
                }
            }
            e.Graphics.DrawLines(uiPen, points.ToArray());
        }

        private void btnNewGame_onClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            nPlanets = r.Next(0, 11);
            gameView.Invalidate();
        }
    }
}
