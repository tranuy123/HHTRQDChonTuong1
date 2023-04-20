namespace HHTRQDChonTuong
{
    partial class FormAHP
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
            this.dataGridViewTrAHP = new System.Windows.Forms.DataGridView();
            this.dataGridViewTC = new System.Windows.Forms.DataGridView();
            this.textBoxSaiSo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonTT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrAHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTrAHP
            // 
            this.dataGridViewTrAHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrAHP.Location = new System.Drawing.Point(931, 0);
            this.dataGridViewTrAHP.Name = "dataGridViewTrAHP";
            this.dataGridViewTrAHP.RowHeadersWidth = 51;
            this.dataGridViewTrAHP.RowTemplate.Height = 29;
            this.dataGridViewTrAHP.Size = new System.Drawing.Size(739, 350);
            this.dataGridViewTrAHP.TabIndex = 0;
            // 
            // dataGridViewTC
            // 
            this.dataGridViewTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTC.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTC.Name = "dataGridViewTC";
            this.dataGridViewTC.RowHeadersWidth = 51;
            this.dataGridViewTC.RowTemplate.Height = 29;
            this.dataGridViewTC.Size = new System.Drawing.Size(498, 321);
            this.dataGridViewTC.TabIndex = 1;
            this.dataGridViewTC.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTC_CellValueChanged);
            // 
            // textBoxSaiSo
            // 
            this.textBoxSaiSo.Location = new System.Drawing.Point(12, 414);
            this.textBoxSaiSo.Name = "textBoxSaiSo";
            this.textBoxSaiSo.Size = new System.Drawing.Size(125, 27);
            this.textBoxSaiSo.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(493, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(200, 321);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(688, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(190, 321);
            this.dataGridView2.TabIndex = 4;
            // 
            // buttonTT
            // 
            this.buttonTT.Location = new System.Drawing.Point(774, 412);
            this.buttonTT.Name = "buttonTT";
            this.buttonTT.Size = new System.Drawing.Size(94, 29);
            this.buttonTT.TabIndex = 5;
            this.buttonTT.Text = "Tiếp theo";
            this.buttonTT.UseVisualStyleBackColor = true;
            this.buttonTT.Click += new System.EventHandler(this.buttonTT_Click);
            // 
            // FormAHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 753);
            this.Controls.Add(this.buttonTT);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxSaiSo);
            this.Controls.Add(this.dataGridViewTC);
            this.Controls.Add(this.dataGridViewTrAHP);
            this.Name = "FormAHP";
            this.Text = "FormAHP";
            this.Load += new System.EventHandler(this.FormAHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrAHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTrAHP;
        private System.Windows.Forms.DataGridView dataGridViewTC;
        private System.Windows.Forms.TextBox textBoxSaiSo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonTT;
    }
}