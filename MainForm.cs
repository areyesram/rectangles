using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace areyesram
{
    public partial class MainForm : Form
    {
        private static Rectangle[] _rectangles;
        private Point[] _points;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            _points = Enumerable.Range(0, 200).Select(o => new Point(rnd.Next(100) * 5, rnd.Next(100) * 5)).ToArray();
            _rectangles = Geometry.FindRectangles(_points);
            gridPoints.DataSource = _points;
            gridRectangles.DataSource = _rectangles;
            Invalidate();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            if (_points == null) return;
            var g = Graphics.FromHwnd(pnlCanvas.Handle);
            g.FillRectangle(Brushes.White, pnlCanvas.ClientRectangle);
            g.SmoothingMode = SmoothingMode.HighQuality;
            foreach (var p in _points)
                g.FillEllipse(Brushes.Blue, p.X - 2, p.Y - 2, 5, 5);
            foreach (var r in _rectangles)
                g.DrawRectangle(Pens.Red, r.X1, r.Y1, r.X2 - r.X1 + 1, r.Y2 - r.Y1 + 1);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
