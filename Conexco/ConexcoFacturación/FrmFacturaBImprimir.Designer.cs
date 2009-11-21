namespace ConexcoFacturación
{
    partial class FrmFacturaBImprimir
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
            this.reportViewerFacturaB = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ConexcoImpresionDataSet = new ConexcoFacturación.ConexcoImpresionDataSet();
            this.FacturaImpresionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturaImpresionTableAdapter = new ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.FacturaImpresionTableAdapter();
            this.FacturaBLineaImpresionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturaBLineaImpresionTableAdapter = new ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.FacturaBLineaImpresionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ConexcoImpresionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaImpresionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBLineaImpresionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerFacturaB
            // 
            this.reportViewerFacturaB.AutoSize = true;
            reportDataSource1.Name = "ConexcoImpresionDataSet_FacturaImpresion";
            reportDataSource1.Value = this.FacturaImpresionBindingSource;
            reportDataSource2.Name = "ConexcoImpresionDataSet_FacturaBLineaImpresion";
            reportDataSource2.Value = this.FacturaBLineaImpresionBindingSource;
            this.reportViewerFacturaB.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerFacturaB.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerFacturaB.LocalReport.ReportEmbeddedResource = "ConexcoFacturación.Reportes.FacturaBImpresion.rdlc";
            this.reportViewerFacturaB.Location = new System.Drawing.Point(13, 13);
            this.reportViewerFacturaB.Name = "reportViewerFacturaB";
            this.reportViewerFacturaB.ShowBackButton = false;
            this.reportViewerFacturaB.ShowCredentialPrompts = false;
            this.reportViewerFacturaB.ShowFindControls = false;
            this.reportViewerFacturaB.ShowPageNavigationControls = false;
            this.reportViewerFacturaB.Size = new System.Drawing.Size(743, 463);
            this.reportViewerFacturaB.TabIndex = 2;
            // 
            // ConexcoImpresionDataSet
            // 
            this.ConexcoImpresionDataSet.DataSetName = "ConexcoImpresionDataSet";
            this.ConexcoImpresionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FacturaImpresionBindingSource
            // 
            this.FacturaImpresionBindingSource.DataMember = "FacturaImpresion";
            this.FacturaImpresionBindingSource.DataSource = this.ConexcoImpresionDataSet;
            // 
            // FacturaImpresionTableAdapter
            // 
            this.FacturaImpresionTableAdapter.ClearBeforeFill = true;
            // 
            // FacturaBLineaImpresionBindingSource
            // 
            this.FacturaBLineaImpresionBindingSource.DataMember = "FacturaBLineaImpresion";
            this.FacturaBLineaImpresionBindingSource.DataSource = this.ConexcoImpresionDataSet;
            // 
            // FacturaBLineaImpresionTableAdapter
            // 
            this.FacturaBLineaImpresionTableAdapter.ClearBeforeFill = true;
            // 
            // FrmFacturaBImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 488);
            this.Controls.Add(this.reportViewerFacturaB);
            this.Name = "FrmFacturaBImprimir";
            this.Text = "FrmFacturaBImprimir";
            this.Load += new System.EventHandler(this.FrmFacturaBImprimir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConexcoImpresionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaImpresionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBLineaImpresionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerFacturaB;
        private System.Windows.Forms.BindingSource FacturaImpresionBindingSource;
        private ConexcoImpresionDataSet ConexcoImpresionDataSet;
        private System.Windows.Forms.BindingSource FacturaBLineaImpresionBindingSource;
        private ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.FacturaImpresionTableAdapter FacturaImpresionTableAdapter;
        private ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.FacturaBLineaImpresionTableAdapter FacturaBLineaImpresionTableAdapter;

    }
}