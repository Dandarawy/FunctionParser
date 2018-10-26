using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FunctionPlotter;
using FunctionParser;
using System.Diagnostics;

namespace FunctionParserAndPlotterTester
{
    public partial class Form1 : Form
    {
        Plotter plotter;

        //variables for mouse panning
        private bool isDown;
        private Point lastPoint;
        private Point currPoint;

        List<ExpressionGraphData> graphs = new List<ExpressionGraphData>(); 
        
        public Form1()
        {
            InitializeComponent();
            plotter = new Plotter(60, 60, new Point(50, picBox_graph.Height - 50));
            plotter.GridColor = Color.FromArgb(200, 200, 200);
            plotter.GridWidth = 1;
            plotter.XAxisSubDashesPerUnit = 1;
            UpdateGraphs();
            picBox_graph.MouseWheel += PicBox_graph_MouseWheel;
        }

        private void PicBox_graph_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                plotter.XPixelsPerUnit *= 2;
                plotter.YPixelsPerUnit *= 2;
            }
            else
            {
                if (plotter.XPixelsPerUnit > 2)
                    plotter.XPixelsPerUnit /= 2;
                if (plotter.YPixelsPerUnit > 2)
                    plotter.YPixelsPerUnit /= 2;
            }
            UpdateGraphs();
            picBox_graph.Invalidate();
        }

        void UpdateGraphs()
        {       
            plotter.Curves.Clear();
            for (int i = 0; i < graphs.Count; i++)
            {
                if (graphs[i].Shown)
                {
                    graphs[i].Curve.Points.Clear();
                    plotter.Curves.Add(graphs[i].Curve);
                    float resolution = graphs[i].Resolution > 0 ? graphs[i].Resolution : plotter.XResolution;
                    for (float x = 0; x >= plotter.GetMinX(); x -= resolution)
                    {
                        PointF point = new PointF(x, (float)graphs[i].Expression.CalculateValue(new double[] { x }));
                        Debug.WriteLine(point);
                        graphs[i].Curve.Points.Add(point);
                    }
                    graphs[i].Curve.Points.Reverse();
                    for (float x = resolution; x <= plotter.GetMaxX(picBox_graph.Width); x += resolution)
                    {
                        graphs[i].Curve.Points.Add(new PointF(x, (float)graphs[i].Expression.CalculateValue(new double[] { x })));
                    }
                }
            }
        }
        private void FilterHiddenGraphs()
        {
            plotter.Curves.Clear();
            for (int i = 0; i < graphs.Count; i++)
            {
                if (graphs[i].Shown)
                {
                    plotter.Curves.Add(graphs[i].Curve);
                }
            }
        }
        private void picBox_graph_Paint(object sender, PaintEventArgs e)
        {
            plotter.DrawGridandAxes(e.Graphics, picBox_graph.Width, picBox_graph.Height);
            plotter.DrawCurves(e.Graphics);
        }
        private void picBox_graph_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            lastPoint = e.Location;
        }
        private void picBox_graph_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                currPoint = e.Location;
                int deltaX = currPoint.X - lastPoint.X;
                int deltaY = currPoint.Y - lastPoint.Y;
                plotter.Center = new Point(plotter.Center.X + deltaX, plotter.Center.Y + deltaY);
                lastPoint = currPoint;
                UpdateGraphs();
                picBox_graph.Invalidate();
            }
        }
        private void picBox_graph_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }
        
        private void lst_functions_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            graphs[e.Item.Index].Shown = e.Item.Checked;
            FilterHiddenGraphs();
            picBox_graph.Invalidate();
        }

        private void btn_AddFunction_Click(object sender, EventArgs e)
        {
            frm_AddFunction addFuncForm = new frm_AddFunction();
            if(addFuncForm.ShowDialog()== DialogResult.OK)
            {
                addFuncForm.ExpressionGraph.Shown = true;
                graphs.Add(addFuncForm.ExpressionGraph);
                UpdateGraphs();
                picBox_graph.Invalidate();
                ListViewItem func = new ListViewItem(addFuncForm.ExpressionGraph.Expression.Value);
                func.ForeColor = addFuncForm.ExpressionGraph.Curve.CurveColor;
                func.Checked = true;
                lst_functions.Items.Add(func);
            }
        }
    }
    public class ExpressionGraphData
    {
        public Expression Expression { get; set; }
        public float Resolution { get; set; }
        public Curve Curve { get; set; }
        public bool Shown { get; set; }
    }
}
