namespace TrustCalculator
{
    partial class TrustList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrustList));
            this.dgv_Detail = new System.Windows.Forms.DataGridView();
            this.txt_TrustName = new System.Windows.Forms.TextBox();
            this.lbl_trustName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Detail
            // 
            this.dgv_Detail.AllowUserToAddRows = false;
            this.dgv_Detail.AllowUserToDeleteRows = false;
            this.dgv_Detail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Detail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Detail.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_Detail.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgv_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Detail.Location = new System.Drawing.Point(54, 123);
            this.dgv_Detail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_Detail.Name = "dgv_Detail";
            this.dgv_Detail.ReadOnly = true;
            this.dgv_Detail.RowHeadersVisible = false;
            this.dgv_Detail.Size = new System.Drawing.Size(845, 302);
            this.dgv_Detail.TabIndex = 0;
            this.dgv_Detail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Detail_CellClick);
            this.dgv_Detail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Detail_CellContentClick);
            // 
            // txt_TrustName
            // 
            this.txt_TrustName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TrustName.Location = new System.Drawing.Point(332, 73);
            this.txt_TrustName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_TrustName.Name = "txt_TrustName";
            this.txt_TrustName.Size = new System.Drawing.Size(224, 26);
            this.txt_TrustName.TabIndex = 1;
            // 
            // lbl_trustName
            // 
            this.lbl_trustName.AutoSize = true;
            this.lbl_trustName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_trustName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_trustName.Location = new System.Drawing.Point(185, 76);
            this.lbl_trustName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_trustName.Name = "lbl_trustName";
            this.lbl_trustName.Size = new System.Drawing.Size(118, 19);
            this.lbl_trustName.TabIndex = 2;
            this.lbl_trustName.Text = "Name of the Trust";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(580, 73);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrustList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(981, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_trustName);
            this.Controls.Add(this.txt_TrustName);
            this.Controls.Add(this.dgv_Detail);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TrustList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trust Detail";
            this.Load += new System.EventHandler(this.TrustList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Detail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Detail;
        private System.Windows.Forms.TextBox txt_TrustName;
        private System.Windows.Forms.Label lbl_trustName;
        private System.Windows.Forms.Button button1;
    }
}