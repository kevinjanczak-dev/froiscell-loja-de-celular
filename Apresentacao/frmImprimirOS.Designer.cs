﻿namespace Apresentacao
{
    partial class frmImprimirOS
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
            this.reportImprimir = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportImprimir
            // 
            this.reportImprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportImprimir.LocalReport.ReportEmbeddedResource = "Apresentacao.Relatorios.OrdemServicoFolha.rdlc";
            this.reportImprimir.Location = new System.Drawing.Point(10, 60);
            this.reportImprimir.Name = "reportImprimir";
            this.reportImprimir.ServerReport.BearerToken = null;
            this.reportImprimir.Size = new System.Drawing.Size(636, 349);
            this.reportImprimir.TabIndex = 0;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // frmImprimirOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 419);
            this.Controls.Add(this.reportImprimir);
            this.Name = "frmImprimirOS";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 10);
            this.Resizable = false;
            this.Text = "Imprimir OS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmImprimirOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportImprimir;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}