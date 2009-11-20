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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ConexcoImpresionDataSet = new ConexcoFacturación.ConexcoImpresionDataSet();
            this.FacturaImpresionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturaImpresionTableAdapter = new ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.FacturaImpresionTableAdapter();
            this.FacturaLineaImpresionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturaLineaImpresionTableAdapter = new ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.FacturaLineaImpresionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ConexcoImpresionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaImpresionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaLineaImpresionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ConexcoImpresionDataSet_FacturaImpresion";
            reportDataSource1.Value = this.FacturaImpresionBindingSource;
            reportDataSource2.Name = "ConexcoImpresionDataSet_FacturaLineaImpresion";
            reportDataSource2.Value = this.FacturaLineaImpresionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConexcoFacturación.Reportes.FacturaImpresion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(743, 463);
            this.reportViewer1.TabIndex = 0;
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
            // FacturaLineaImpresionBindingSource
            // 
            this.FacturaLineaImpresionBindingSource.DataMember = "FacturaLineaImpresion";
            this.FacturaLineaImpresionBindingSource.DataSource = this.ConexcoImpresionDataSet;
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
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmFacturaImprimir";
            this.Text = "FrmFacturaImprimir";
            this.Load += new System.EventHandler(this.FrmFacturaImprimir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConexcoImpresionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaImpresionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaLineaImpresionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturaImpresionBindingSource;
        private ConexcoImpresionDataSet ConexcoImpresionDataSet;
        private System.Windows.Forms.BindingSource FacturaLineaImpresionBindingSource;
        private ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.FacturaImpresionTableAdapter FacturaImpresionTableAdapter;
        private ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.FacturaLineaImpresionTableAdapter FacturaLineaImpresionTableAdapter;
    }
}