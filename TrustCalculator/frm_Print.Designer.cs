namespace TrustCalculator
{
    partial class frm_Print
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource11 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TrustDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TrustCalculatorDataSet = new TrustCalculator.TrustCalculatorDataSet();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryIIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryIIIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryIVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryDetailIIIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryDetailIIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryDetailIVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoryDetailVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TrustDetailTableAdapter = new TrustCalculator.TrustCalculatorDataSetTableAdapters.TrustDetailTableAdapter();
            this.DataTable1TableAdapter = new TrustCalculator.TrustCalculatorDataSetTableAdapters.DataTable1TableAdapter();
            this.CategoryIITableAdapter = new TrustCalculator.TrustCalculatorDataSetTableAdapters.CategoryIITableAdapter();
            this.CategoryIIITableAdapter = new TrustCalculator.TrustCalculatorDataSetTableAdapters.CategoryIIITableAdapter();
            this.CategoryIVTableAdapter = new TrustCalculator.TrustCalculatorDataSetTableAdapters.CategoryIVTableAdapter();
            this.CategoryVTableAdapter = new TrustCalculator.TrustCalculatorDataSetTableAdapters.CategoryVTableAdapter();
            this.CategoryDetailTableAdapter = new TrustCalculator.TrustCalculatorDataSetTableAdapters.CategoryDetailTableAdapter();
            this.CategoryDetailIIITableAdapter = new TrustCalculator.TrustCalculatorDataSetTableAdapters.CategoryDetailIIITableAdapter();
            this.CategoryDetailIITableAdapter = new TrustCalculator.TrustCalculatorDataSetTableAdapters.CategoryDetailIITableAdapter();
            this.CategoryDetailIVTableAdapter = new TrustCalculator.TrustCalculatorDataSetTableAdapters.CategoryDetailIVTableAdapter();
            this.CategoryDetailVTableAdapter = new TrustCalculator.TrustCalculatorDataSetTableAdapters.CategoryDetailVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TrustDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrustCalculatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryIIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryIIIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryIVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDetailIIIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDetailIIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDetailIVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDetailVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapCollapsed = true;
            reportDataSource1.Name = "TrustDetail";
            reportDataSource1.Value = this.TrustDetailBindingSource;
            reportDataSource2.Name = "CategoryI";
            reportDataSource2.Value = this.DataTable1BindingSource;
            reportDataSource3.Name = "CategoryII";
            reportDataSource3.Value = this.CategoryIIBindingSource;
            reportDataSource4.Name = "CategoryIII";
            reportDataSource4.Value = this.CategoryIIIBindingSource;
            reportDataSource5.Name = "CategoryIV";
            reportDataSource5.Value = this.CategoryIVBindingSource;
            reportDataSource6.Name = "CategoryV";
            reportDataSource6.Value = this.CategoryVBindingSource;
            reportDataSource7.Name = "CategoryDetail";
            reportDataSource7.Value = this.CategoryDetailBindingSource;
            reportDataSource8.Name = "CategoryDetailIII";
            reportDataSource8.Value = this.CategoryDetailIIIBindingSource;
            reportDataSource9.Name = "CategoryDetailII";
            reportDataSource9.Value = this.CategoryDetailIIBindingSource;
            reportDataSource10.Name = "CategoryDetailIV";
            reportDataSource10.Value = this.CategoryDetailIVBindingSource;
            reportDataSource11.Name = "CategoryDetailV";
            reportDataSource11.Value = this.CategoryDetailVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource11);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrustCalculator.Portfolio_ReviewReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reportViewer1.PromptAreaCollapsed = true;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(684, 711);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.WaitControlDisplayAfter = 10;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // TrustDetailBindingSource
            // 
            this.TrustDetailBindingSource.DataMember = "TrustDetail";
            this.TrustDetailBindingSource.DataSource = this.TrustCalculatorDataSet;
            // 
            // TrustCalculatorDataSet
            // 
            this.TrustCalculatorDataSet.DataSetName = "TrustCalculatorDataSet";
            this.TrustCalculatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.TrustCalculatorDataSet;
            // 
            // CategoryIIBindingSource
            // 
            this.CategoryIIBindingSource.DataMember = "CategoryII";
            this.CategoryIIBindingSource.DataSource = this.TrustCalculatorDataSet;
            // 
            // CategoryIIIBindingSource
            // 
            this.CategoryIIIBindingSource.DataMember = "CategoryIII";
            this.CategoryIIIBindingSource.DataSource = this.TrustCalculatorDataSet;
            // 
            // CategoryIVBindingSource
            // 
            this.CategoryIVBindingSource.DataMember = "CategoryIV";
            this.CategoryIVBindingSource.DataSource = this.TrustCalculatorDataSet;
            // 
            // CategoryVBindingSource
            // 
            this.CategoryVBindingSource.DataMember = "CategoryV";
            this.CategoryVBindingSource.DataSource = this.TrustCalculatorDataSet;
            // 
            // CategoryDetailBindingSource
            // 
            this.CategoryDetailBindingSource.DataMember = "CategoryDetail";
            this.CategoryDetailBindingSource.DataSource = this.TrustCalculatorDataSet;
            // 
            // CategoryDetailIIIBindingSource
            // 
            this.CategoryDetailIIIBindingSource.DataMember = "CategoryDetailIII";
            this.CategoryDetailIIIBindingSource.DataSource = this.TrustCalculatorDataSet;
            // 
            // CategoryDetailIIBindingSource
            // 
            this.CategoryDetailIIBindingSource.DataMember = "CategoryDetailII";
            this.CategoryDetailIIBindingSource.DataSource = this.TrustCalculatorDataSet;
            // 
            // CategoryDetailIVBindingSource
            // 
            this.CategoryDetailIVBindingSource.DataMember = "CategoryDetailIV";
            this.CategoryDetailIVBindingSource.DataSource = this.TrustCalculatorDataSet;
            // 
            // CategoryDetailVBindingSource
            // 
            this.CategoryDetailVBindingSource.DataMember = "CategoryDetailV";
            this.CategoryDetailVBindingSource.DataSource = this.TrustCalculatorDataSet;
            // 
            // TrustDetailTableAdapter
            // 
            this.TrustDetailTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // CategoryIITableAdapter
            // 
            this.CategoryIITableAdapter.ClearBeforeFill = true;
            // 
            // CategoryIIITableAdapter
            // 
            this.CategoryIIITableAdapter.ClearBeforeFill = true;
            // 
            // CategoryIVTableAdapter
            // 
            this.CategoryIVTableAdapter.ClearBeforeFill = true;
            // 
            // CategoryVTableAdapter
            // 
            this.CategoryVTableAdapter.ClearBeforeFill = true;
            // 
            // CategoryDetailTableAdapter
            // 
            this.CategoryDetailTableAdapter.ClearBeforeFill = true;
            // 
            // CategoryDetailIIITableAdapter
            // 
            this.CategoryDetailIIITableAdapter.ClearBeforeFill = true;
            // 
            // CategoryDetailIITableAdapter
            // 
            this.CategoryDetailIITableAdapter.ClearBeforeFill = true;
            // 
            // CategoryDetailIVTableAdapter
            // 
            this.CategoryDetailIVTableAdapter.ClearBeforeFill = true;
            // 
            // CategoryDetailVTableAdapter
            // 
            this.CategoryDetailVTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(684, 711);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Print";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Portfolio Review Report";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrustDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrustCalculatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryIIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryIIIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryIVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDetailIIIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDetailIIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDetailIVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryDetailVBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TrustDetailBindingSource;
        private TrustCalculatorDataSet TrustCalculatorDataSet;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private System.Windows.Forms.BindingSource CategoryIIBindingSource;
        private System.Windows.Forms.BindingSource CategoryIIIBindingSource;
        private System.Windows.Forms.BindingSource CategoryIVBindingSource;
        private System.Windows.Forms.BindingSource CategoryVBindingSource;
        private System.Windows.Forms.BindingSource CategoryDetailBindingSource;
        private System.Windows.Forms.BindingSource CategoryDetailIIIBindingSource;
        private System.Windows.Forms.BindingSource CategoryDetailIIBindingSource;
        private System.Windows.Forms.BindingSource CategoryDetailIVBindingSource;
        private System.Windows.Forms.BindingSource CategoryDetailVBindingSource;
        private TrustCalculatorDataSetTableAdapters.TrustDetailTableAdapter TrustDetailTableAdapter;
        private TrustCalculatorDataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private TrustCalculatorDataSetTableAdapters.CategoryIITableAdapter CategoryIITableAdapter;
        private TrustCalculatorDataSetTableAdapters.CategoryIIITableAdapter CategoryIIITableAdapter;
        private TrustCalculatorDataSetTableAdapters.CategoryIVTableAdapter CategoryIVTableAdapter;
        private TrustCalculatorDataSetTableAdapters.CategoryVTableAdapter CategoryVTableAdapter;
        private TrustCalculatorDataSetTableAdapters.CategoryDetailTableAdapter CategoryDetailTableAdapter;
        private TrustCalculatorDataSetTableAdapters.CategoryDetailIIITableAdapter CategoryDetailIIITableAdapter;
        private TrustCalculatorDataSetTableAdapters.CategoryDetailIITableAdapter CategoryDetailIITableAdapter;
        private TrustCalculatorDataSetTableAdapters.CategoryDetailIVTableAdapter CategoryDetailIVTableAdapter;
        private TrustCalculatorDataSetTableAdapters.CategoryDetailVTableAdapter CategoryDetailVTableAdapter;



    }
}