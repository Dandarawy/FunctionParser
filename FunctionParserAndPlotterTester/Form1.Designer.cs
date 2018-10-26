namespace FunctionParserAndPlotterTester
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBox_graph = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_AddFunction = new System.Windows.Forms.Button();
            this.lst_functions = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.picBox_graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBox_graph
            // 
            this.picBox_graph.BackColor = System.Drawing.Color.White;
            this.picBox_graph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox_graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox_graph.Location = new System.Drawing.Point(0, 0);
            this.picBox_graph.Name = "picBox_graph";
            this.picBox_graph.Size = new System.Drawing.Size(695, 674);
            this.picBox_graph.TabIndex = 0;
            this.picBox_graph.TabStop = false;
            this.picBox_graph.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_graph_Paint);
            this.picBox_graph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_graph_MouseDown);
            this.picBox_graph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_graph_MouseMove);
            this.picBox_graph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_graph_MouseUp);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_AddFunction);
            this.splitContainer1.Panel1.Controls.Add(this.lst_functions);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picBox_graph);
            this.splitContainer1.Size = new System.Drawing.Size(952, 674);
            this.splitContainer1.SplitterDistance = 253;
            this.splitContainer1.TabIndex = 2;
            // 
            // btn_AddFunction
            // 
            this.btn_AddFunction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_AddFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddFunction.Location = new System.Drawing.Point(0, 615);
            this.btn_AddFunction.Name = "btn_AddFunction";
            this.btn_AddFunction.Size = new System.Drawing.Size(253, 59);
            this.btn_AddFunction.TabIndex = 1;
            this.btn_AddFunction.Text = "Add Function";
            this.btn_AddFunction.UseVisualStyleBackColor = true;
            this.btn_AddFunction.Click += new System.EventHandler(this.btn_AddFunction_Click);
            // 
            // lst_functions
            // 
            this.lst_functions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_functions.CheckBoxes = true;
            this.lst_functions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lst_functions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_functions.FullRowSelect = true;
            this.lst_functions.GridLines = true;
            this.lst_functions.Location = new System.Drawing.Point(3, 3);
            this.lst_functions.Name = "lst_functions";
            this.lst_functions.Size = new System.Drawing.Size(250, 616);
            this.lst_functions.TabIndex = 0;
            this.lst_functions.UseCompatibleStateImageBehavior = false;
            this.lst_functions.View = System.Windows.Forms.View.Details;
            this.lst_functions.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lst_functions_ItemChecked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Functions";
            this.columnHeader1.Width = 238;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 674);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Plotter";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_graph)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_graph;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lst_functions;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btn_AddFunction;
    }
}

