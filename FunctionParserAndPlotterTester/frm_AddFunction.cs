using System;
using System.Windows.Forms;
using FunctionParser;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace FunctionParserAndPlotterTester
{
    public partial class frm_AddFunction : Form
    {
        public ExpressionGraphData ExpressionGraph { get; set; }
        public frm_AddFunction()
        {
            InitializeComponent();
            SetInitialValues();
           }

        private void SetInitialValues()
        {
            cmbo_lineWidth.SelectedIndex = 0;
            cmbo_pointSize.SelectedIndex = 0;
            cmbo_dashStyle.SelectedIndex = 0;
            lst_plottingType.SetItemChecked(0, true);
            ExpressionGraph = new ExpressionGraphData();
            ExpressionGraph.Curve = new FunctionPlotter.Curve(System.Drawing.Color.Black, FunctionPlotter.PlotType.ContineuosCurve);

        }

        private void btn_graphColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog()== DialogResult.OK)
            {
                btn_graphColor.BackColor = colorDialog.Color;
                ExpressionGraph.Curve.CurveColor= colorDialog.Color;
            }
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            ExpressionGraph.Expression =new Expression( txt_expression.Text,new string[] { "x" },null);
            ExpressionGraph.Curve.CurveColor = btn_graphColor.BackColor;
            ExpressionGraph.Curve.LineWidth = int.Parse(cmbo_lineWidth.SelectedItem.ToString());
            ExpressionGraph.Curve.PointSize = int.Parse(cmbo_pointSize.SelectedItem.ToString());
            ExpressionGraph.Curve.DashStyle = (DashStyle)cmbo_dashStyle.SelectedIndex ;
            ExpressionGraph.Resolution = float.Parse(txt_resolution.Text);
            for(int i=0;i< lst_plottingType.CheckedIndices.Count;i++)
            {
                int checkedIndex = lst_plottingType.CheckedIndices[i];
                ExpressionGraph.Curve.PlottingType |= (FunctionPlotter.PlotType)(1 << checkedIndex);
            }

        }

        private void lst_plottingType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbo_dashStyle_DrawItem(object sender, DrawItemEventArgs e)
        {
            DashStyle style = (DashStyle)e.Index;
            using (Pen p = new Pen(Color.Black, 2))
            {
                e.DrawBackground();
                p.DashStyle = style;
                Point start = new Point(e.Bounds.X,e.Bounds.Top+e.Bounds.Height / 2);
                Point end = new Point(e.Bounds.X + e.Bounds.Width, e.Bounds.Top + e.Bounds.Height / 2);
                e.Graphics.DrawLine(p, start,end);
                e.DrawFocusRectangle();
            }
        }

        private void cmbo_dashStyle_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemWidth = 350;
            e.ItemHeight = 25;
        }
    }
}
