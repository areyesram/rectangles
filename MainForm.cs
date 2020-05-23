using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using areyesram.Properties;

namespace areyesram
{
    public partial class MainForm : Form
    {
        private const int GridSize = 1000;          //TODO: Configurable
        private const int NumberOfPoints = 5000;    //TODO: Configurable
        private int _method = 1;
        private static Rectangle[] _rectangles;
        private static Point[] _points;

        public MainForm()
        {
            var image = new[] { Resources.m1, Resources.m2, Resources.m3, Resources.m4 };
            InitializeComponent();
            foreach (var mnu in new[] { mnuMethod1, mnuMethod2, mnuMethod3 })
            {
                mnu.Click += (sender, e) =>
                {
                    var m = (string)((ToolStripItem)sender).Tag;
                    _method = int.Parse(m);
                    mnuMethod.Image = image[_method - 1];
                };
            }
        }

        private void FindRectangles()
        {
            var finder = Geometry.Factory.GetFinder(_method);
            var t0 = DateTime.Now;
            _rectangles = finder.FindRectangles(_points);
            var t1 = (DateTime.Now - t0).TotalMilliseconds / 1000;
            statusLabel.Text = $"{_rectangles.Length} rectángulos encontrados en {t1:N2} s.";
            Application.DoEvents();
            gridPoints.DataSource = _points;
            gridRectangles.DataSource = _rectangles;
            RefreshPicture();
        }

        private void RefreshPicture()
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

        private void btnRandom_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            _points = Enumerable.Range(0, NumberOfPoints)
                .Select(o => new Point(rnd.Next(GridSize), rnd.Next(GridSize)))
                .ToArray();
            _rectangles = new Rectangle[0];
            RefreshPicture();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //TODO: FileOpenDialog
            _points = File.ReadAllLines(@"data\sample.csv")
                .Select(o =>
                {
                    var a = o.Split(',');
                    return new Point(int.Parse(a[0]), int.Parse(a[1]));
                })
                .ToArray();
            RefreshPicture();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FindRectangles();
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            //TODO: SaveAsFileDialog
            File.WriteAllLines(@"data\points.csv", _points.Select(o => o.X + "," + o.Y).ToArray());
        }
    }
}