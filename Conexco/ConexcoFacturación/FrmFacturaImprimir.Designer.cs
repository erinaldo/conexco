namespace ConexcoFacturación
{
    partial class FrmFacturaImprimir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturaImprimir));
            this.FacturaImpresionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConexcoImpresionDataSet = new ConexcoFacturación.ConexcoImpresionDataSet();
            this.FacturaLineaImpresionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturaImpresionTableAdapter = new ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.FacturaImpresionTableAdapter();
            this.FacturaLineaImpresionTableAdapter = new ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.FacturaLineaImpresionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaImpresionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConexcoImpresionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaLineaImpresionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FacturaImpresionBindingSource
            // 
            this.FacturaImpresionBindingSource.DataMember = "FacturaImpresion";
            this.FacturaImpresionBindingSource.DataSource = this.ConexcoImpresionDataSet;
            // 
            // ConexcoImpresionDataSet
            // 
            this.ConexcoImpresionDataSet.DataSetName = "ConexcoImpresionDataSet";
            this.ConexcoImpresionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FacturaLineaImpresionBindingSource
            // 
            this.FacturaLineaImpresionBindingSource.DataMember = "FacturaLineaImpresion";
            this.FacturaLineaImpresionBindingSource.DataSource = this.ConexcoImpresionDataSet;
            // 
            // reportViewerFactura
            // 
            this.reportViewerFactura.AutoSize = true;
            reportDataSource1.Name = "ConexcoImpresionDataSet_FacturaImpresion";
            reportDataSource1.Value = this.FacturaImpresionBindingSource;
            reportDataSource2.Name = "ConexcoImpresionDataSet_FacturaLineaImpresion";
            reportDataSource2.Value = this.FacturaLineaImpresionBindingSource;
            this.reportViewerFactura.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerFactura.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerFactura.LocalReport.ReportEmbeddedResource = "ConexcoFacturación.Reportes.FacturaImpresion.rdlc";
            this.reportViewerFactura.Location = new System.Drawing.Point(13, 13);
            this.reportViewerFactura.Name = "reportViewerFactura";
            this.reportViewerFactura.ShowBackButton = false;
            this.reportViewerFactura.ShowCredentialPrompts = false;
            this.reportViewerFactura.ShowFindControls = false;
            this.reportViewerFactura.ShowPageNavigationControls = false;
            this.reportViewerFactura.Size = new System.Drawing.Size(743, 463);
            this.reportViewerFactura.TabIndex = 0;
            // 
            // FacturaImpresionTableAdapter
            // 
            this.FacturaImpresionTableAdapter.ClearBeforeFill = true;
            // 
            // FacturaLineaImpresionTableAdapter
            // 
            this.FacturaLineaImpresionTableAdapter.ClearBeforeFill = true;
            // 
            // FrmFacturaImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 488);
            this.Controls.Add(this.reportViewerFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmFacturaImprimir";
            this.Text = "Impresión de Factura A";
            this.Load += new System.EventHandler(this.FrmFacturaImprimir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturaImpresionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConexcoImpresionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaLineaImpresionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerFactura;
        private System.Windows.Forms.BindingSource FacturaImpresionBindingSource;
        private ConexcoImpresionDataSet ConexcoImpresionDataSet;
        private System.Windows.Forms.BindingSource FacturaLineaImpresionBindingSource;
        private ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.FacturaImpresionTableAdapter FacturaImpresionTableAdapter;
        private ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.FacturaLineaImpresionTableAdapter FacturaLineaImpresionTableAdapter;
    }
}