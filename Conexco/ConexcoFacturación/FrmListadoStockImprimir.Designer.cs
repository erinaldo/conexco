namespace ConexcoFacturación
{
    partial class FrmListadoStockImprimir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoStockImprimir));
            this.ListadoStockActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConexcoDataSet = new ConexcoFacturación.ConexcoDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.listadoStockActualTableAdapter = new ConexcoFacturación.ConexcoDataSetTableAdapters.ListadoStockActualTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoStockActualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConexcoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ListadoStockActualBindingSource
            // 
            this.ListadoStockActualBindingSource.DataMember = "ListadoStockActual";
            this.ListadoStockActualBindingSource.DataSource = this.ConexcoDataSet;
            // 
            // ConexcoDataSet
            // 
            this.ConexcoDataSet.DataSetName = "ConexcoDataSet";
            this.ConexcoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "StockActualDataSet";
            reportDataSource1.Value = this.ListadoStockActualBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConexcoFacturación.Reportes.ListadoStockActual.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(846, 463);
            this.reportViewer1.TabIndex = 0;
            // 
            // listadoStockActualTableAdapter
            // 
            this.listadoStockActualTableAdapter.ClearBeforeFill = true;
            // 
            // FrmListadoStockImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 494);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListadoStockImprimir";
            this.Text = "Listado Stock Actual";
            this.Load += new System.EventHandler(this.FrmListadoStockImprimir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoStockActualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConexcoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ListadoStockActualBindingSource;
        private ConexcoDataSet ConexcoDataSet;
        private ConexcoDataSetTableAdapters.ListadoStockActualTableAdapter listadoStockActualTableAdapter;
    }
}