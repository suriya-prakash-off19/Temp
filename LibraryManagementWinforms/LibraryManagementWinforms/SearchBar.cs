using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace LibraryManagementWinforms
{
    public delegate void TextChangedEventHandler(object sender, EventArgs e);

    public partial class SearchBar : UserControl
    {
        public event TextChangedEventHandler TextChanged;
        private int borderRadius;
        public SearchBar()
        {
            InitializeComponent();
            BackColor = Color.White;
            Txt.TextChanged += TextBox1_TextChanged;
        }
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                Txt.Font = value;
                Invalidate();
            }
        }
        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                Txt.BackColor = value;
                Pict.BackColor = value;
                Invalidate();
            }
        }
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                Txt.ForeColor = value;
            }
        }
        [Category("Curve Radius")]
        public int BorderRadius
        {
            get => borderRadius;
            set => borderRadius = value;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            TextChanged?.Invoke(sender, EventArgs.Empty);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.InterpolationMode = InterpolationMode.High;
            Rectangle rectangle = new Rectangle(0, 0, Width, Height);
            if (BorderRadius > 1)
            {
                using (GraphicsPath PathSurface = graphicsPath(rectangle, BorderRadius))
                using (Pen PenSurface = new Pen(BackColor, BorderRadius))
                {
                    this.Region = new Region(PathSurface);
                    e.Graphics.DrawPath(PenSurface, PathSurface);
                }
                using (GraphicsPath BorderPath = graphicsPath(rectangle, BorderRadius))
                {
                    Region = new Region(BorderPath);
                }
            }
        }

        private GraphicsPath graphicsPath(Rectangle rect, int Radius)
        {
            GraphicsPath path = new GraphicsPath();
            float radius = Radius;
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            return path;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int width = this.Width;
            Pict.Width = (int)(width * 0.19);
            Txt.Width = (int)(width * 0.80);
        }
    }
}
