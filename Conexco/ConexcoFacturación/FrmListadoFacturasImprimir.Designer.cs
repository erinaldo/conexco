namespace ConexcoFacturación
{
    partial class FrmListadoFacturasImprimir
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ConexcoDataSet = new ConexcoFacturación.ConexcoDataSet();
            this.ListadoFacturasLineaImpresionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ListadoFacturasLineaImpresionTableAdapter = new ConexcoFacturación.ConexcoDataSetTableAdapters.ListadoFacturasLineaImpresionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ConexcoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoFacturasLineaImpresionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ConexcoDataSet_ListadoFacturasLineaImpresion";
            reportDataSource1.Value = this.ListadoFacturasLineaImpresionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConexcoFacturación.Reportes.ListadoFacturasImpresion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(846, 463);
            this.reportViewer1.TabIndex = 0;
            // 
            // ConexcoDataSet
            // 
            this.ConexcoDataSet.DataSetName = "ConexcoDataSet";
            this.ConexcoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ListadoFacturasLineaImpresionBindingSource
            // 
            this.ListadoFacturasLineaImpresionBindingSource.DataMember = "ListadoFacturasLineaImpresion";
            this.ListadoFacturasLineaImpresionBindingSource.DataSource = this.ConexcoDataSet;
            // 
            // ListadoFacturasLineaImpresionTableAdapter
            // 
            this.ListadoFacturasLineaImpresionTableAdapter.ClearBeforeFill = true;
            // 
            // FrmListadoFacturasImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 494);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmListadoFacturasImprimir";
            this.Text = "Listado Facturas a Imprimir";
            this.Load += new System.EventHandler(this.FrmListadoFacturasImprimir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConexcoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoFacturasLineaImpresionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ListadoFacturasLineaImpresionBindingSource;
        private ConexcoDataSet ConexcoDataSet;
        private ConexcoFacturación.ConexcoDataSetTableAdapters.ListadoFacturasLineaImpresionTableAdapter ListadoFacturasLineaImpresionTableAdapter;
    }
}