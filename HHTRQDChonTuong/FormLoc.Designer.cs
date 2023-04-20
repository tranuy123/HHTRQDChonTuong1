namespace HHTRQDChonTuong
{
    partial class FormLoc
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
            this.dataGridViewDSTr = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelNganh = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownHP1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHP2 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDownDiem2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkedListBoxNganh = new System.Windows.Forms.CheckedListBox();
            this.buttonLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSTr)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelNganh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDSTr
            // 
            this.dataGridViewDSTr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSTr.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDSTr.Name = "dataGridViewDSTr";
            this.dataGridViewDSTr.RowHeadersWidth = 51;
            this.dataGridViewDSTr.RowTemplate.Height = 29;
            this.dataGridViewDSTr.Size = new System.Drawing.Size(808, 536);
            this.dataGridViewDSTr.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelNganh);
            this.groupBox1.Location = new System.Drawing.Point(826, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 536);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // panelNganh
            // 
            this.panelNganh.Controls.Add(this.buttonLuu);
            this.panelNganh.Controls.Add(this.button1);
            this.panelNganh.Controls.Add(this.numericUpDownHP1);
            this.panelNganh.Controls.Add(this.numericUpDownHP2);
            this.panelNganh.Controls.Add(this.comboBox1);
            this.panelNganh.Controls.Add(this.numericUpDownDiem2);
            this.panelNganh.Controls.Add(this.numericUpDown1);
            this.panelNganh.Controls.Add(this.checkedListBoxNganh);
            this.panelNganh.Location = new System.Drawing.Point(6, 26);
            this.panelNganh.Name = "panelNganh";
            this.panelNganh.Size = new System.Drawing.Size(838, 504);
            this.panelNganh.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDownHP1
            // 
            this.numericUpDownHP1.Location = new System.Drawing.Point(11, 391);
            this.numericUpDownHP1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownHP1.Name = "numericUpDownHP1";
            this.numericUpDownHP1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownHP1.TabIndex = 5;
            this.numericUpDownHP1.ValueChanged += new System.EventHandler(this.numericUpDownHP1_ValueChanged);
            // 
            // numericUpDownHP2
            // 
            this.numericUpDownHP2.Location = new System.Drawing.Point(242, 391);
            this.numericUpDownHP2.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownHP2.Name = "numericUpDownHP2";
            this.numericUpDownHP2.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownHP2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // numericUpDownDiem2
            // 
            this.numericUpDownDiem2.Location = new System.Drawing.Point(242, 317);
            this.numericUpDownDiem2.Name = "numericUpDownDiem2";
            this.numericUpDownDiem2.Size = new System.Drawing.Size(150, 27);
            this.numericUpDownDiem2.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 317);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkedListBoxNganh
            // 
            this.checkedListBoxNganh.FormattingEnabled = true;
            this.checkedListBoxNganh.Location = new System.Drawing.Point(0, 102);
            this.checkedListBoxNganh.Name = "checkedListBoxNganh";
            this.checkedListBoxNganh.Size = new System.Drawing.Size(368, 158);
            this.checkedListBoxNganh.TabIndex = 0;
            // 
            // buttonLuu
            // 
            this.buttonLuu.Location = new System.Drawing.Point(259, 443);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(133, 47);
            this.buttonLuu.TabIndex = 2;
            this.buttonLuu.Text = "button2";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // FormLoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewDSTr);
            this.Name = "FormLoc";
            this.Text = "FormLoc";
            this.Load += new System.EventHandler(this.FormLoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSTr)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelNganh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDSTr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBoxNganh;
        private System.Windows.Forms.Panel panelNganh;
        private System.Windows.Forms.NumericUpDown numericUpDownDiem2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDownHP1;
        private System.Windows.Forms.NumericUpDown numericUpDownHP2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLuu;
    }
}