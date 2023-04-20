namespace HHTRQDChonTuong
{
    partial class FormAHPPA
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
            this.dataGridViewHP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHP
            // 
            this.dataGridViewHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHP.Location = new System.Drawing.Point(12, 3);
            this.dataGridViewHP.Name = "dataGridViewHP";
            this.dataGridViewHP.RowHeadersWidth = 51;
            this.dataGridViewHP.RowTemplate.Height = 29;
            this.dataGridViewHP.Size = new System.Drawing.Size(300, 188);
            this.dataGridViewHP.TabIndex = 0;
            // 
            // FormAHPPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewHP);
            this.Name = "FormAHPPA";
            this.Text = "FormAHPPA";
            this.Load += new System.EventHandler(this.FormAHPPA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHP;
    }
}