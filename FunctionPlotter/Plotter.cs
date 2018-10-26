using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FunctionPlotter
{
    public class Plotter
    {
        
        List<Curve> curves = new List<Curve>();
        /// <summary>
        /// List of curves that will be plotted by this plotter
        /// </summary>
        public List<Curve> Curves { get { return curves; } }

        /// <summary>
        /// The size of x unit in pixels
        /// </summary>
        public float XPixelsPerUnit { get; set; }
        /// <summary>
        /// The size of y unit in pixels
        /// </summary>
        public float YPixelsPerUnit { get; set; }

        /// <summary>
        /// Axes center position in drawing canvas
        /// </summary>
        public Point Center { get; set; }
        
        /// <summary>
        /// The dash style of the x and y axes
        /// </summary>
        public DashStyle AxesStyle { get; set; }
        /// <summary>
        /// The line width of the Axes
        /// </summary>
        public float AxesWidth { get; set; }

        /// <summary>
        /// Number of units per grid square in x axes
        /// </summary>
        public int XGridUnitsPerSquare { get; set; }
        /// <summary>
        /// Number of units per grid square in y axis
        /// </summary>
        public int YGridUnitsPerSquare { get; set; }

        /// <summary>
        /// The dash style of grid lines
        /// </summary>
        public DashStyle GridStyle { get; set; }
        /// <summary>
        /// Line width of the grid
        /// </summary>
        public float GridWidth { get; set; }
        /// <summary>
        /// Color of grid lines
        /// </summary>
        public Color GridColor { get; set; }
        /// <summary>
        /// Enable grid drawing
        /// </summary>
        public bool GridEnabled { get; set; }

        // X-Axis properties
        /// <summary>
        /// The color of x axis
        /// </summary>
        public Color XAxisColor { get; set; }

        /// <summary>
        /// Enable dashes that represent the unit location on x axis
        /// </summary>
        public bool XAxisDashEnable { get; set; }
        /// <summary>
        /// Color of the x axis dashes
        /// </summary>
        public Color XAxisDashColor { get; set; }
        /// <summary>
        /// Width of x axis dashes
        /// </summary>
        public float XAxisDashWidth { get; set; }
        /// <summary>
        /// Height of  x axis dashes
        /// </summary>
        public float XAxisDashHeight { get; set; }

        /// <summary>
        /// Enable small dashes on x axis 
        /// </summary>
        public bool XAxisSubDashEnable { get; set; }
        /// <summary>
        /// Number of small dashes per unit on x axis
        /// </summary>
        public int XAxisSubDashesPerUnit { get; set; }
        /// <summary>
        /// The color of x axis unit dashes
        /// </summary>
        public Color XAxisSubDashColor { get; set; }
        /// <summary>
        /// Width of x axis unit dashes
        /// </summary>
        public float XAxisSubDashWidth { get; set; }
        /// <summary>
        /// Height of x axis unit dashes
        /// </summary>
        public float XAxisSubDashHeight { get; set; }


        // Y-Axis properties
        public Color YAxisColor { get; set; }

        public bool YAxisDashEnable { get; set; }
        public Color YAxisDashColor { get; set; }
        public float YAxisDashWidth { get; set; }
        public float YAxisDashHeight { get; set; }
        
        public bool YAxisSubDashEnable { get; set; }
        public int YAxisSubDashesPerUnit { get; set; }
        public Color YAxisSubDashColor { get; set; }
        public float YAxisSubDashWidth { get; set; }
        public float YAxisSubDashHeight { get; set; }
        
        public float XResolution
        {
            get { return 1 / XPixelsPerUnit; }
        }

        public Plotter(float xPixelsPerUnit, float yPixelsPerUnit, Point center, Color axesColor)
        {
            this.XPixelsPerUnit = xPixelsPerUnit;
            this.YPixelsPerUnit = yPixelsPerUnit;
            this.Center = center;
            
            this.XAxisSubDashesPerUnit = 0;
            this.YAxisSubDashesPerUnit = 0;

            AxesWidth = 1;
            XAxisColor = YAxisColor = XAxisDashColor = YAxisDashColor = XAxisSubDashColor = YAxisSubDashColor = axesColor;

            XGridUnitsPerSquare = YGridUnitsPerSquare = 1;

            GridWidth = 1;
            GridColor = Color.Black;
            GridEnabled = true;

            XAxisDashWidth = 1;
            XAxisDashHeight = 5;
            XAxisDashEnable = true;

            YAxisDashWidth = 1;
            YAxisDashHeight = 5;
            YAxisDashEnable = true;


            XAxisSubDashWidth = 1;
            XAxisSubDashHeight = 3;
            XAxisSubDashEnable = true;

            YAxisSubDashWidth = 1;
            YAxisSubDashHeight = 3;
            YAxisSubDashEnable = true;
            

        }
        public Plotter(float xPixelsPerUnit, float yPixelsPerUnit, Point center) : this(xPixelsPerUnit, yPixelsPerUnit, center, Color.Black)
        {

        }
        public void DrawGridandAxes(Graphics g, int width, int height)
        {
            //Draw Grid
            #region Draw Grid
            if (GridEnabled)
            {
                using (Pen gridPen = new Pen(GridColor))
                {
                    gridPen.Width = GridWidth;
                    gridPen.DashStyle = GridStyle;
                    int seed = (int)Math.Round(YGridUnitsPerSquare * YPixelsPerUnit);
                    int i = Center.Y - seed;
                    for (; i > 0; i -= seed)
                    {

                        g.DrawLine(gridPen, 0, i, width, i);//draw the upper horizontal half
                    }
                    for (i = Center.Y + seed; i < height; i += seed)
                    {
                        g.DrawLine(gridPen, 0, i, width, i);//draw the lower  half
                    }
                    seed = (int)Math.Round(XGridUnitsPerSquare * XPixelsPerUnit);
                    i = Center.X - seed;
                    for (; i > 0; i -= seed)
                    {

                        g.DrawLine(gridPen, i, 0, i, height);//draw the left vertical half
                    }
                    for (i = Center.X + seed; i < width; i += seed)
                    {
                        g.DrawLine(gridPen, i, 0, i, height);//draw the right  half
                    }
                }

            }
            #endregion
            //Draw Axes
            #region Draw Axes
            using (Pen p = new Pen(XAxisColor))
            {
                p.Width = AxesWidth;
                p.DashStyle = AxesStyle;
                g.DrawLine(p, Center.X, Center.Y, width, Center.Y);
                g.DrawLine(p, Center.X, Center.Y, 0, Center.Y);
            }
            using (Pen p = new Pen(YAxisColor))
            {
                p.Width = AxesWidth;
                p.DashStyle = AxesStyle;
                g.DrawLine(p, Center.X, Center.Y, Center.X, 0);
                g.DrawLine(p, Center.X, Center.Y, Center.X, height );
            }
            #endregion
            //Draw Axes Dashes
            #region Draw Axes dashes

            //draw subDashes X-axis
            if (XAxisSubDashEnable & (XAxisSubDashesPerUnit > 0))
            {
                using (Pen xDashPen = new Pen(XAxisSubDashColor))
                {
                    xDashPen.Width = XAxisSubDashWidth;
                    int xSegment = (int)Math.Round((XPixelsPerUnit));

                    int subDashStart = (Center.Y - (int)(AxesWidth / 2) - (int)((XAxisSubDashHeight - AxesWidth) / 2));//the segment of the dash right and lift the axis
                    int subDashEnd = subDashStart + (int)XAxisSubDashHeight - 1;
                    int subDashSeed = xSegment / (XAxisSubDashesPerUnit+1);
                    int i = Center.X - subDashSeed;
                    for (; i > 0; i -= subDashSeed)
                    {
                        if ((i - Center.X) % xSegment == 0) continue;
                        g.DrawLine(xDashPen, i, subDashStart, i, subDashEnd);//draw the upper y-axis half
                    }
                    for (i = Center.X + subDashSeed; i < width; i += subDashSeed)
                    {
                        if ((i - Center.X) % xSegment == 0) continue;
                        g.DrawLine(xDashPen, i, subDashStart, i, subDashEnd);//draw the lower y-axis  half
                    }
                }
            }
            if (YAxisSubDashEnable & (YAxisSubDashesPerUnit > 0))
            {
                using (Pen yDashPen = new Pen(YAxisSubDashColor))
                {
                    yDashPen.Width = YAxisSubDashWidth;

                    int ySegment = (int)Math.Round(YPixelsPerUnit);

                    int subDashStart = (Center.X - (int)(AxesWidth / 2) - (int)((YAxisSubDashHeight - AxesWidth) / 2));//the segment of the dash right and lift the axis
                    int subDashEnd = subDashStart + (int)YAxisSubDashHeight - 1;
                    int subDashSeed = ySegment / (YAxisSubDashesPerUnit+1);

                    int i = Center.Y - subDashSeed;

                    for (; i > 0; i -= subDashSeed)
                    {
                        if ((i - Center.Y) % ySegment == 0) continue;
                        g.DrawLine(yDashPen, subDashEnd, i, subDashStart, i);//draw the upper y-axis half
                    }
                    for (i = Center.Y + subDashSeed; i < height; i += subDashSeed)
                    {
                        if ((i - Center.Y) % ySegment == 0) continue;
                        g.DrawLine(yDashPen, subDashStart, i, subDashEnd, i);//draw the lower y-axis  half
                    }
                }
            }
            if (XAxisDashEnable)
            {
                using (Pen xDashPen = new Pen(XAxisDashColor))
                {
                    xDashPen.Width = XAxisDashWidth;

                    int seed = (int)Math.Round((XPixelsPerUnit));
                    int i = Center.X - seed;
                    int dashStart = (Center.Y - (int)(AxesWidth / 2) - (int)((XAxisDashHeight - AxesWidth) / 2));//the segment of the dash right and lift the axis
                    int dashEnd = dashStart + (int)XAxisDashHeight - 1;
                    for (; i > 0; i -= seed)
                    {
                        g.DrawLine(xDashPen, i, dashStart, i, dashEnd);//draw the upper y-axis half
                    }

                    for (i = Center.X + seed; i < width; i += seed)
                    {
                        g.DrawLine(xDashPen, i, dashStart, i, dashEnd);//draw the lower y-axis  half
                    }
                }
            }
            if (YAxisDashEnable)
            {
                using (Pen yDashPen = new Pen(YAxisDashColor))
                {
                    yDashPen.Width = YAxisDashWidth;

                    int seed = (int)Math.Round(YPixelsPerUnit);
                    int i = Center.Y - seed;
                    int dashStart = (int)(Center.X - (int)(AxesWidth / 2) - ((YAxisDashHeight - AxesWidth) / 2));//the segment of the dash right and lift the axis
                    int dashEnd = dashStart + (int)YAxisDashHeight - 1;
                    for (; i > 0; i -= seed)
                    {
                        g.DrawLine(yDashPen, dashStart, i, dashEnd, i);//draw the upper y-axis half
                    }
                    for (i = Center.Y + seed; i < height; i += seed)
                    {
                        g.DrawLine(yDashPen, dashStart, i, dashEnd, i);//draw the lower y-axis  half
                    }
                }
            }

            #endregion

        }
        public void DrawCurves(Graphics g)
        {
            g.TranslateTransform(Center.X, Center.Y);
            g.ScaleTransform(1, -1);
            foreach (Curve curve in curves)
            {
                if ((curve.PlottingType & PlotType.ContineuosCurve) == PlotType.ContineuosCurve)
                    DrawConCurve(g, curve);
                if ((curve.PlottingType & PlotType.DiscretePoints) == PlotType.DiscretePoints)
                    DrawPoints(g, curve);
                if ((curve.PlottingType & PlotType.Impulses) == PlotType.Impulses)
                    DrawImpulse(g, curve);
            }
            g.ResetTransform();
        }
        private void DrawImpulse(Graphics g, Curve curve)
        {
            using (Pen p = new Pen(curve.CurveColor))
            {
                p.Width = curve.LineWidth;
                p.DashStyle = curve.DashStyle;
                for (int i = 0; i < curve.Points.Count; i++)
                {
                    g.DrawLine(p, curve[i].X * XPixelsPerUnit, curve[i].Y * YPixelsPerUnit, curve[i].X * XPixelsPerUnit, 0);//0 because we have transform the coordinate
                }
            }
        }
        private void DrawPoints(Graphics g, Curve curve)
        {
            SmoothingMode currentMode = g.SmoothingMode;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (Brush b = new SolidBrush(curve.CurveColor))
            {
                float halfPointSize = curve.PointSize / 2;
                for (int i = 0; i < curve.Points.Count; i++)
                {
                    g.FillEllipse(b, (curve[i].X * XPixelsPerUnit)- halfPointSize, (curve[i].Y * YPixelsPerUnit) - halfPointSize, curve.PointSize, curve.PointSize);
                }
            }
            g.SmoothingMode = currentMode;
        }
        private void DrawConCurve(Graphics g, Curve curve)
        {
            using (Pen p = new Pen(curve.CurveColor))
            {
                p.DashStyle = curve.DashStyle;
                p.Width = curve.LineWidth;
                SmoothingMode mode = g.SmoothingMode;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                for (int i = 0; i < curve.Points.Count - 1; i++)
                {
                    try
                    {
                        g.DrawLine(p, curve[i].X * XPixelsPerUnit, curve[i].Y * YPixelsPerUnit, curve[i + 1].X * XPixelsPerUnit, curve[i + 1].Y * YPixelsPerUnit);
                    }
                    catch (Exception ex)
                    {
                        //if the point is out of drawable range just ignore it
                    }
                }

                //this should be more efficient, but we need to handle the NAN and infinity values
                //g.DrawLines(p, curve.GetScaledPoints(XPixelsPerUnit, YPixelsPerUnit));

                g.SmoothingMode = mode;
            }
        }
        public PointF GetActualPoint(Point p)
        {
            //return the actual human interface point using the representational point in the canvas
            PointF res = new PointF((p.X - Center.X) * XPixelsPerUnit, (Center.Y - p.Y) * YPixelsPerUnit);
            return res;
        }
        public PointF GetRepresentaionalPoint(PointF p)
        {
            //return the position of (drawer point) on the canvas
            PointF res = new PointF(p.X / XPixelsPerUnit + Center.X, Center.Y - p.Y / YPixelsPerUnit);
            return res;
        }
        public float GetMinX()
        {
            return (0 - Center.X) / XPixelsPerUnit;
        }
        public float GetMaxX(float canvasWidth)
        {
            return (canvasWidth - Center.X) / XPixelsPerUnit;
        }
        

    }
    [Flags]
    public enum PlotType
    {
        ContineuosCurve = 1,
        DiscretePoints = 2,
        Impulses = 4,

    }
    public class Curve
    {
        public Color CurveColor { get; set; }
        public List<PointF> Points  { get; set; }
        public DashStyle DashStyle { get; set; }
        public float LineWidth { get; set; }
        public PlotType PlottingType { get; set; }
        public float PointSize { get; set; }
        public Curve(Color color,PlotType plottingType)
        {
            CurveColor = color;
            PlottingType = plottingType;
            LineWidth = 1.0f;
            PointSize = 2.0f;
            Points = new List<PointF>(800);
        }
        public PointF this[int index] { get { return Points[index]; } }
        public PointF[] GetScaledPoints(float xs,float ys)
        {
            PointF[] points = new PointF[Points.Count];
            for(int i=0;i<Points.Count;i++)
            {
                points[i] = new PointF(Points[i].X * xs, Points[i].Y * ys);
            }
            return points;
        }
        public float? GetY(double x)
        {
            foreach (PointF p in Points)
                if (p.X == x) return p.Y;
            return null;
        }
    }
}
