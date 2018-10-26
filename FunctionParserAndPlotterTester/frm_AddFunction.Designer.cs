namespace FunctionParserAndPlotterTester
{
    partial class frm_AddFunction
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_expression = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_graphColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbo_dashStyle = new System.Windows.Forms.ComboBox();
            this.cmbo_lineWidth = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbo_pointSize = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lst_plottingType = new System.Windows.Forms.CheckedListBox();
            this.txt_resolution = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "F(x) = ";
            // 
            // txt_expression
            // 
            this.txt_expression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_expression.Location = new System.Drawing.Point(137, 26);
            this.txt_expression.Name = "txt_expression";
            this.txt_expression.Size = new System.Drawing.Size(260, 26);
            this.txt_expression.TabIndex = 1;
            this.txt_expression.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Color:";
            // 
            // btn_graphColor
            // 
            this.btn_graphColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_graphColor.BackColor = System.Drawing.Color.Black;
            this.btn_graphColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_graphColor.Location = new System.Drawing.Point(137, 81);
            this.btn_graphColor.Name = "btn_graphColor";
            this.btn_graphColor.Size = new System.Drawing.Size(256, 28);
            this.btn_graphColor.TabIndex = 3;
            this.btn_graphColor.UseVisualStyleBackColor = false;
            this.btn_graphColor.Click += new System.EventHandler(this.btn_graphColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dash Style:";
            // 
            // cmbo_dashStyle
            // 
            this.cmbo_dashStyle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbo_dashStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbo_dashStyle.FormattingEnabled = true;
            this.cmbo_dashStyle.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cmbo_dashStyle.Location = new System.Drawing.Point(137, 137);
            this.cmbo_dashStyle.Name = "cmbo_dashStyle";
            this.cmbo_dashStyle.Size = new System.Drawing.Size(260, 27);
            this.cmbo_dashStyle.TabIndex = 5;
            this.cmbo_dashStyle.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbo_dashStyle_DrawItem);
            this.cmbo_dashStyle.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.cmbo_dashStyle_MeasureItem);
            // 
            // cmbo_lineWidth
            // 
            this.cmbo_lineWidth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbo_lineWidth.FormattingEnabled = true;
            this.cmbo_lineWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbo_lineWidth.Location = new System.Drawing.Point(137, 188);
            this.cmbo_lineWidth.Name = "cmbo_lineWidth";
            this.cmbo_lineWidth.Size = new System.Drawing.Size(260, 28);
            this.cmbo_lineWidth.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Line Width:";
            // 
            // cmbo_pointSize
            // 
            this.cmbo_pointSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbo_pointSize.FormattingEnabled = true;
            this.cmbo_pointSize.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "15",
            "20"});
            this.cmbo_pointSize.Location = new System.Drawing.Point(137, 236);
            this.cmbo_pointSize.Name = "cmbo_pointSize";
            this.cmbo_pointSize.Size = new System.Drawing.Size(260, 28);
            this.cmbo_pointSize.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 244);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Point Size:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 293);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Plotting Type:";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Ok.Location = new System.Drawing.Point(309, 440);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(88, 31);
            this.btn_Ok.TabIndex = 12;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(200, 440);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(88, 31);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // lst_plottingType
            // 
            this.lst_plottingType.CheckOnClick = true;
            this.lst_plottingType.FormattingEnabled = true;
            this.lst_plottingType.Items.AddRange(new object[] {
            "Continuous Graph",
            "Points",
            "Impulses"});
            this.lst_plottingType.Location = new System.Drawing.Point(137, 283);
            this.lst_plottingType.Name = "lst_plottingType";
            this.lst_plottingType.Size = new System.Drawing.Size(260, 67);
            this.lst_plottingType.TabIndex = 14;
            this.lst_plottingType.SelectedIndexChanged += new System.EventHandler(this.lst_plottingType_SelectedIndexChanged);
            // 
            // txt_resolution
            // 
            this.txt_resolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_resolution.Location = new System.Drawing.Point(137, 370);
            this.txt_resolution.Name = "txt_resolution";
            this.txt_resolution.Size = new System.Drawing.Size(260, 26);
            this.txt_resolution.TabIndex = 16;
            this.txt_resolution.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 376);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Resolution";
            // 
            // frm_AddFunction
            // 
            this.AcceptButton = this.btn_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(409, 483);
            this.Controls.Add(this.txt_resolution);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lst_plottingType);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbo_pointSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbo_lineWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbo_dashStyle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_graphColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_expression);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AddFunction";
            this.Text = "Add Function";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_expression;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_graphColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbo_dashStyle;
        private System.Windows.Forms.ComboBox cmbo_lineWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbo_pointSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.CheckedListBox lst_plottingType;
        private System.Windows.Forms.TextBox txt_resolution;
        private System.Windows.Forms.Label label7;
    }
}