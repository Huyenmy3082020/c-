namespace BaiTapLonQuanLiBanHang
{
    partial class MatHang
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
            this.dataGridViewdsMatHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdsMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewdsMatHang
            // 
            this.dataGridViewdsMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdsMatHang.Location = new System.Drawing.Point(68, 203);
            this.dataGridViewdsMatHang.Name = "dataGridViewdsMatHang";
            this.dataGridViewdsMatHang.RowHeadersWidth = 62;
            this.dataGridViewdsMatHang.RowTemplate.Height = 28;
            this.dataGridViewdsMatHang.Size = new System.Drawing.Size(746, 312);
            this.dataGridViewdsMatHang.TabIndex = 0;
            this.dataGridViewdsMatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewdsMatHang_CellContentClick);
            // 
            // MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.dataGridViewdsMatHang);
            this.Name = "MatHang";
            this.Text = "MatHang";
            this.Load += new System.EventHandler(this.MatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdsMatHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewdsMatHang;
    }
}