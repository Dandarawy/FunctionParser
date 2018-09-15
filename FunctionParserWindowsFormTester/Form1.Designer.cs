namespace FunctionParserWindowsFormTester
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
            this.txt_expr = new System.Windows.Forms.TextBox();
            this.trvw_ParseTree = new System.Windows.Forms.TreeView();
            this.lst_ids = new System.Windows.Forms.ListView();
            this.id_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_addID = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_expr
            // 
            this.txt_expr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expr.Location = new System.Drawing.Point(6, 27);
            this.txt_expr.Name = "txt_expr";
            this.txt_expr.Size = new System.Drawing.Size(465, 26);
            this.txt_expr.TabIndex = 0;
            this.txt_expr.TextChanged += new System.EventHandler(this.txt_expr_TextChanged);
            // 
            // trvw_ParseTree
            // 
            this.trvw_ParseTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvw_ParseTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvw_ParseTree.FullRowSelect = true;
            this.trvw_ParseTree.Location = new System.Drawing.Point(12, 249);
            this.trvw_ParseTree.Name = "trvw_ParseTree";
            this.trvw_ParseTree.Size = new System.Drawing.Size(614, 433);
            this.trvw_ParseTree.TabIndex = 1;
            // 
            // lst_ids
            // 
            this.lst_ids.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id_name,
            this.id_value});
            this.lst_ids.FullRowSelect = true;
            this.lst_ids.GridLines = true;
            this.lst_ids.Location = new System.Drawing.Point(6, 19);
            this.lst_ids.Name = "lst_ids";
            this.lst_ids.Size = new System.Drawing.Size(598, 85);
            this.lst_ids.TabIndex = 3;
            this.lst_ids.UseCompatibleStateImageBehavior = false;
            this.lst_ids.View = System.Windows.Forms.View.Details;
            this.lst_ids.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lst_ids_KeyDown);
            // 
            // id_name
            // 
            this.id_name.Text = "Name";
            this.id_name.Width = 266;
            // 
            // id_value
            // 
            this.id_value.Text = "Value";
            this.id_value.Width = 325;
            // 
            // btn_addID
            // 
            this.btn_addID.Location = new System.Drawing.Point(6, 110);
            this.btn_addID.Name = "btn_addID";
            this.btn_addID.Size = new System.Drawing.Size(75, 23);
            this.btn_addID.TabIndex = 4;
            this.btn_addID.Text = "Add ID";
            this.btn_addID.UseVisualStyleBackColor = true;
            this.btn_addID.Click += new System.EventHandler(this.btn_addID_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(488, 30);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(31, 20);
            this.lbl_result.TabIndex = 5;
            this.lbl_result.Text = "= 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lst_ids);
            this.groupBox1.Controls.Add(this.btn_addID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 142);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function IDs (Variables)";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txt_expr);
            this.groupBox2.Controls.Add(this.lbl_result);
            this.groupBox2.Location = new System.Drawing.Point(12, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 78);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Function";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 694);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trvw_ParseTree);
            this.Name = "Form1";
            this.Text = "Function Evaluator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_expr;
        private System.Windows.Forms.TreeView trvw_ParseTree;
        private System.Windows.Forms.ListView lst_ids;
        private System.Windows.Forms.ColumnHeader id_name;
        private System.Windows.Forms.ColumnHeader id_value;
        private System.Windows.Forms.Button btn_addID;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

