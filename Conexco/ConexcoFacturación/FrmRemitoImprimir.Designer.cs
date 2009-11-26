namespace ConexcoFacturación
{
    partial class FrmRemitoImprimir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRemitoImprimir));
            this.RemitoImpresionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConexcoImpresionDataSet = new ConexcoFacturación.ConexcoImpresionDataSet();
            this.RemitoLineaImpresionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerRemito = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RemitoImpresionTableAdapter = new ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.RemitoImpresionTableAdapter();
            this.RemitoLineaImpresionTableAdapter = new ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.RemitoLineaImpresionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RemitoImpresionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConexcoImpresionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemitoLineaImpresionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RemitoImpresionBindingSource
            // 
            this.RemitoImpresionBindingSource.DataMember = "RemitoImpresion";
            this.RemitoImpresionBindingSource.DataSource = this.ConexcoImpresionDataSet;
            // 
            // ConexcoImpresionDataSet
            // 
            this.ConexcoImpresionDataSet.DataSetName = "ConexcoImpresionDataSet";
            this.ConexcoImpresionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RemitoLineaImpresionBindingSource
            // 
            this.RemitoLineaImpresionBindingSource.DataMember = "RemitoLineaImpresion";
            this.RemitoLineaImpresionBindingSource.DataSource = this.ConexcoImpresionDataSet;
            // 
            // reportViewerRemito
            // 
            this.reportViewerRemito.AutoSize = true;
            reportDataSource1.Name = "ConexcoImpresionDataSet_RemitoImpresion";
            reportDataSource1.Value = this.RemitoImpresionBindingSource;
            reportDataSource2.Name = "ConexcoImpresionDataSet_RemitoLineaImpresion";
            reportDataSource2.Value = this.RemitoLineaImpresionBindingSource;
            this.reportViewerRemito.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerRemito.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerRemito.LocalReport.ReportEmbeddedResource = "ConexcoFacturación.Reportes.RemitoImpresion.rdlc";
            this.reportViewerRemito.Location = new System.Drawing.Point(13, 13);
            this.reportViewerRemito.Name = "reportViewerRemito";
            this.reportViewerRemito.ShowBackButton = false;
            this.reportViewerRemito.ShowCredentialPrompts = false;
            this.reportViewerRemito.ShowFindControls = false;
            this.reportViewerRemito.ShowPageNavigationControls = false;
            this.reportViewerRemito.Size = new System.Drawing.Size(743, 463);
            this.reportViewerRemito.TabIndex = 1;
            // 
            // RemitoImpresionTableAdapter
            // 
            this.RemitoImpresionTableAdapter.ClearBeforeFill = true;
            // 
            // RemitoLineaImpresionTableAdapter
            // 
            this.RemitoLineaImpresionTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRemitoImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 488);
            this.Controls.Add(this.reportViewerRemito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRemitoImprimir";
            this.Text = "Impresión de Remito";
            this.Load += new System.EventHandler(this.FrmRemitoImprimir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RemitoImpresionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConexcoImpresionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemitoLineaImpresionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerRemito;
        private System.Windows.Forms.BindingSource RemitoImpresionBindingSource;
        private ConexcoImpresionDataSet ConexcoImpresionDataSet;
        private System.Windows.Forms.BindingSource RemitoLineaImpresionBindingSource;
        private ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.RemitoImpresionTableAdapter RemitoImpresionTableAdapter;
        private ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.RemitoLineaImpresionTableAdapter RemitoLineaImpresionTableAdapter;
    }
}