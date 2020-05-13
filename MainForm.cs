using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace areyesram
{
    public partial class MainForm : Form
    {
        private const int GridSize = 2000;  //TODO: Configurable
        private static Rectangle[] _rectangles;
        private static Point[] _points;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            _points = Enumerable.Range(0, 5000).Select(o => new Point(rnd.Next(2000), rnd.Next(2000))).ToArray();
            FindRectangles();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            _points = File.ReadAllLines(@"data\sample.csv")
                .Select(o =>
                {
                    var a = o.Split(',');
                    return new Point(int.Parse(a[0]), int.Parse(a[1]));
                })
                .ToArray();
            FindRectangles();
        }

        private void FindRectangles()
        {
            var t0 = DateTime.Now;
            _rectangles = Geometry.FindRectangles(_points);
            var t1 = (DateTime.Now - t0).TotalMilliseconds / 1000;
            gridPoints.DataSource = _points;
            gridRectangles.DataSource = _rectangles;
            DrawRectangles();
            Console.WriteLine($"{_rectangles.Length} rectángulos encontrados en {t1:N2} s.");
        }

        private void DrawRectangles()
        {
            if (_points == null) return;
            var bitmap = new Bitmap(GridSize, GridSize);
            var g = Graphics.FromImage(bitmap);
            g.SmoothingMode = SmoothingMode.HighQuality;
            foreach (var p in _points)
                g.FillEllipse(Brushes.Blue, p.X - 1, p.Y - 1, 3, 3);
            foreach (var r in _rectangles)
                g.DrawRectangle(Pens.Red, r.X1, r.Y1, r.X2 - r.X1 + 1, r.Y2 - r.Y1 + 1);
            picCanvas.Image = bitmap;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(@"data\points.csv", _points.Select(o => o.X + "," + o.Y).ToArray());
        }
    }
}
