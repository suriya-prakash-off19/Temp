using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementWinforms
{
    class RoundedPanel : Panel
    {
        private int borderRadius = 0;


        public RoundedPanel()
        {
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
            typeof(RoundedPanel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, this, new object[] { true });
            Size = new Size(100, 32);
            DoubleBuffered = true;
            this.ResizeRedraw = true;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        [Category("Round")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                Invalidate();
            }
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
    }
}
