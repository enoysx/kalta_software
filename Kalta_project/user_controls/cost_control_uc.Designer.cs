namespace Kalta_project.user_controls
{
    partial class cost_control_uc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_report_grpCtrl = new System.Windows.Forms.TabControl();
            this.breakdown_rap = new System.Windows.Forms.TabPage();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.breakdown_po = new System.Windows.Forms.TabPage();
            this.dgv_breakdown_po_grpCtrl = new System.Windows.Forms.DataGridView();
            this.bpk_kantor = new System.Windows.Forms.TabPage();
            this.dgv_bpk_kantor_grpCtrl = new System.Windows.Forms.DataGridView();
            this.bpk_proyek = new System.Windows.Forms.TabPage();
            this.dgv_bpk_proyek_grpCtrl = new System.Windows.Forms.DataGridView();
            this.po_kantor = new System.Windows.Forms.TabPage();
            this.dgv_po_kantor_grpCtrl = new System.Windows.Forms.DataGridView();
            this.report = new System.Windows.Forms.TabPage();
            this.btn_BPK_proyek = new System.Windows.Forms.Button();
            this.btn_breakdown_RAP = new System.Windows.Forms.Button();
            this.btn_BPK_kantor = new System.Windows.Forms.Button();
            this.btn_PO_kantor = new System.Windows.Forms.Button();
            this.brn_breakdown_PO = new System.Windows.Forms.Button();
            this.input_data = new System.Windows.Forms.GroupBox();
            this.export_report = new System.Windows.Forms.GroupBox();
            this.btn_report = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_report_grpCtrl.SuspendLayout();
            this.breakdown_rap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.breakdown_po.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_breakdown_po_grpCtrl)).BeginInit();
            this.bpk_kantor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bpk_kantor_grpCtrl)).BeginInit();
            this.bpk_proyek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bpk_proyek_grpCtrl)).BeginInit();
            this.po_kantor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_po_kantor_grpCtrl)).BeginInit();
            this.input_data.SuspendLayout();
            this.export_report.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_report_grpCtrl
            // 
            this.dgv_report_grpCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_report_grpCtrl.Controls.Add(this.breakdown_rap);
            this.dgv_report_grpCtrl.Controls.Add(this.breakdown_po);
            this.dgv_report_grpCtrl.Controls.Add(this.bpk_kantor);
            this.dgv_report_grpCtrl.Controls.Add(this.bpk_proyek);
            this.dgv_report_grpCtrl.Controls.Add(this.po_kantor);
            this.dgv_report_grpCtrl.Controls.Add(this.report);
            this.dgv_report_grpCtrl.Location = new System.Drawing.Point(357, 12);
            this.dgv_report_grpCtrl.Name = "dgv_report_grpCtrl";
            this.dgv_report_grpCtrl.SelectedIndex = 0;
            this.dgv_report_grpCtrl.Size = new System.Drawing.Size(594, 408);
            this.dgv_report_grpCtrl.TabIndex = 7;
            // 
            // breakdown_rap
            // 
            this.breakdown_rap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.breakdown_rap.Controls.Add(this.advancedDataGridView1);
            this.breakdown_rap.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakdown_rap.Location = new System.Drawing.Point(4, 22);
            this.breakdown_rap.Name = "breakdown_rap";
            this.breakdown_rap.Padding = new System.Windows.Forms.Padding(3);
            this.breakdown_rap.Size = new System.Drawing.Size(586, 382);
            this.breakdown_rap.TabIndex = 0;
            this.breakdown_rap.Text = "BREAKDOWN RAP";
            this.breakdown_rap.UseVisualStyleBackColor = true;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(2, 2);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.Size = new System.Drawing.Size(580, 379);
            this.advancedDataGridView1.TabIndex = 0;
            this.advancedDataGridView1.TimeFilter = false;
            // 
            // breakdown_po
            // 
            this.breakdown_po.Controls.Add(this.dgv_breakdown_po_grpCtrl);
            this.breakdown_po.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakdown_po.Location = new System.Drawing.Point(4, 22);
            this.breakdown_po.Name = "breakdown_po";
            this.breakdown_po.Padding = new System.Windows.Forms.Padding(3);
            this.breakdown_po.Size = new System.Drawing.Size(586, 382);
            this.breakdown_po.TabIndex = 1;
            this.breakdown_po.Text = "BREAKDOWN PO";
            this.breakdown_po.UseVisualStyleBackColor = true;
            // 
            // dgv_breakdown_po_grpCtrl
            // 
            this.dgv_breakdown_po_grpCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_breakdown_po_grpCtrl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_breakdown_po_grpCtrl.Location = new System.Drawing.Point(0, 0);
            this.dgv_breakdown_po_grpCtrl.Name = "dgv_breakdown_po_grpCtrl";
            this.dgv_breakdown_po_grpCtrl.Size = new System.Drawing.Size(580, 376);
            this.dgv_breakdown_po_grpCtrl.TabIndex = 0;
            // 
            // bpk_kantor
            // 
            this.bpk_kantor.Controls.Add(this.dgv_bpk_kantor_grpCtrl);
            this.bpk_kantor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpk_kantor.Location = new System.Drawing.Point(4, 22);
            this.bpk_kantor.Name = "bpk_kantor";
            this.bpk_kantor.Padding = new System.Windows.Forms.Padding(3);
            this.bpk_kantor.Size = new System.Drawing.Size(586, 382);
            this.bpk_kantor.TabIndex = 2;
            this.bpk_kantor.Text = "BPK KANTOR";
            this.bpk_kantor.UseVisualStyleBackColor = true;
            // 
            // dgv_bpk_kantor_grpCtrl
            // 
            this.dgv_bpk_kantor_grpCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_bpk_kantor_grpCtrl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bpk_kantor_grpCtrl.Location = new System.Drawing.Point(6, 180);
            this.dgv_bpk_kantor_grpCtrl.Name = "dgv_bpk_kantor_grpCtrl";
            this.dgv_bpk_kantor_grpCtrl.Size = new System.Drawing.Size(574, 196);
            this.dgv_bpk_kantor_grpCtrl.TabIndex = 0;
            // 
            // bpk_proyek
            // 
            this.bpk_proyek.Controls.Add(this.dgv_bpk_proyek_grpCtrl);
            this.bpk_proyek.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpk_proyek.Location = new System.Drawing.Point(4, 22);
            this.bpk_proyek.Name = "bpk_proyek";
            this.bpk_proyek.Padding = new System.Windows.Forms.Padding(3);
            this.bpk_proyek.Size = new System.Drawing.Size(586, 382);
            this.bpk_proyek.TabIndex = 3;
            this.bpk_proyek.Text = "BPK PROYEK";
            this.bpk_proyek.UseVisualStyleBackColor = true;
            // 
            // dgv_bpk_proyek_grpCtrl
            // 
            this.dgv_bpk_proyek_grpCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_bpk_proyek_grpCtrl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bpk_proyek_grpCtrl.Location = new System.Drawing.Point(6, 180);
            this.dgv_bpk_proyek_grpCtrl.Name = "dgv_bpk_proyek_grpCtrl";
            this.dgv_bpk_proyek_grpCtrl.Size = new System.Drawing.Size(574, 196);
            this.dgv_bpk_proyek_grpCtrl.TabIndex = 0;
            // 
            // po_kantor
            // 
            this.po_kantor.Controls.Add(this.dgv_po_kantor_grpCtrl);
            this.po_kantor.Location = new System.Drawing.Point(4, 22);
            this.po_kantor.Name = "po_kantor";
            this.po_kantor.Size = new System.Drawing.Size(586, 382);
            this.po_kantor.TabIndex = 4;
            this.po_kantor.Text = "PO KANTOR";
            this.po_kantor.UseVisualStyleBackColor = true;
            // 
            // dgv_po_kantor_grpCtrl
            // 
            this.dgv_po_kantor_grpCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_po_kantor_grpCtrl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_po_kantor_grpCtrl.Location = new System.Drawing.Point(3, 183);
            this.dgv_po_kantor_grpCtrl.Name = "dgv_po_kantor_grpCtrl";
            this.dgv_po_kantor_grpCtrl.Size = new System.Drawing.Size(580, 196);
            this.dgv_po_kantor_grpCtrl.TabIndex = 0;
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(4, 22);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(586, 382);
            this.report.TabIndex = 5;
            this.report.Text = "REPORT";
            this.report.UseVisualStyleBackColor = true;
            // 
            // btn_BPK_proyek
            // 
            this.btn_BPK_proyek.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BPK_proyek.Location = new System.Drawing.Point(158, 80);
            this.btn_BPK_proyek.Name = "btn_BPK_proyek";
            this.btn_BPK_proyek.Size = new System.Drawing.Size(131, 29);
            this.btn_BPK_proyek.TabIndex = 3;
            this.btn_BPK_proyek.Text = "BPK PROYEK";
            this.btn_BPK_proyek.UseVisualStyleBackColor = true;
            // 
            // btn_breakdown_RAP
            // 
            this.btn_breakdown_RAP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_breakdown_RAP.Location = new System.Drawing.Point(6, 34);
            this.btn_breakdown_RAP.Name = "btn_breakdown_RAP";
            this.btn_breakdown_RAP.Size = new System.Drawing.Size(131, 29);
            this.btn_breakdown_RAP.TabIndex = 0;
            this.btn_breakdown_RAP.Text = "BREAKDOWN RAP";
            this.btn_breakdown_RAP.UseVisualStyleBackColor = true;
            // 
            // btn_BPK_kantor
            // 
            this.btn_BPK_kantor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BPK_kantor.Location = new System.Drawing.Point(6, 79);
            this.btn_BPK_kantor.Name = "btn_BPK_kantor";
            this.btn_BPK_kantor.Size = new System.Drawing.Size(131, 29);
            this.btn_BPK_kantor.TabIndex = 2;
            this.btn_BPK_kantor.Text = "BPK KANTOR";
            this.btn_BPK_kantor.UseVisualStyleBackColor = true;
            // 
            // btn_PO_kantor
            // 
            this.btn_PO_kantor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PO_kantor.Location = new System.Drawing.Point(6, 124);
            this.btn_PO_kantor.Name = "btn_PO_kantor";
            this.btn_PO_kantor.Size = new System.Drawing.Size(131, 29);
            this.btn_PO_kantor.TabIndex = 4;
            this.btn_PO_kantor.Text = "PO KANTOR";
            this.btn_PO_kantor.UseVisualStyleBackColor = true;
            // 
            // brn_breakdown_PO
            // 
            this.brn_breakdown_PO.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_breakdown_PO.Location = new System.Drawing.Point(158, 34);
            this.brn_breakdown_PO.Name = "brn_breakdown_PO";
            this.brn_breakdown_PO.Size = new System.Drawing.Size(131, 29);
            this.brn_breakdown_PO.TabIndex = 1;
            this.brn_breakdown_PO.Text = "BREAKDOWN PO";
            this.brn_breakdown_PO.UseVisualStyleBackColor = true;
            // 
            // input_data
            // 
            this.input_data.Controls.Add(this.btn_BPK_proyek);
            this.input_data.Controls.Add(this.export_report);
            this.input_data.Controls.Add(this.btn_breakdown_RAP);
            this.input_data.Controls.Add(this.btn_PO_kantor);
            this.input_data.Controls.Add(this.brn_breakdown_PO);
            this.input_data.Controls.Add(this.btn_BPK_kantor);
            this.input_data.Location = new System.Drawing.Point(3, 12);
            this.input_data.Name = "input_data";
            this.input_data.Size = new System.Drawing.Size(348, 199);
            this.input_data.TabIndex = 9;
            this.input_data.TabStop = false;
            this.input_data.Text = "Input Data";
            // 
            // export_report
            // 
            this.export_report.Controls.Add(this.btn_report);
            this.export_report.Location = new System.Drawing.Point(158, 124);
            this.export_report.Name = "export_report";
            this.export_report.Size = new System.Drawing.Size(158, 66);
            this.export_report.TabIndex = 5;
            this.export_report.TabStop = false;
            this.export_report.Text = "Export Report";
            // 
            // btn_report
            // 
            this.btn_report.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.Location = new System.Drawing.Point(15, 26);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(131, 23);
            this.btn_report.TabIndex = 5;
            this.btn_report.Text = "REPORT";
            this.btn_report.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 190);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cost_control_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.input_data);
            this.Controls.Add(this.dgv_report_grpCtrl);
            this.Name = "cost_control_uc";
            this.Size = new System.Drawing.Size(954, 423);
            this.dgv_report_grpCtrl.ResumeLayout(false);
            this.breakdown_rap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.breakdown_po.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_breakdown_po_grpCtrl)).EndInit();
            this.bpk_kantor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bpk_kantor_grpCtrl)).EndInit();
            this.bpk_proyek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bpk_proyek_grpCtrl)).EndInit();
            this.po_kantor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_po_kantor_grpCtrl)).EndInit();
            this.input_data.ResumeLayout(false);
            this.export_report.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl dgv_report_grpCtrl;
        private System.Windows.Forms.TabPage breakdown_rap;
        private System.Windows.Forms.TabPage breakdown_po;
        private System.Windows.Forms.TabPage bpk_kantor;
        private System.Windows.Forms.DataGridView dgv_bpk_kantor_grpCtrl;
        private System.Windows.Forms.TabPage bpk_proyek;
        private System.Windows.Forms.TabPage po_kantor;
        private System.Windows.Forms.TabPage report;
        private System.Windows.Forms.DataGridView dgv_breakdown_po_grpCtrl;
        private System.Windows.Forms.DataGridView dgv_bpk_proyek_grpCtrl;
        private System.Windows.Forms.DataGridView dgv_po_kantor_grpCtrl;
        private System.Windows.Forms.Button btn_BPK_proyek;
        private System.Windows.Forms.Button btn_breakdown_RAP;
        private System.Windows.Forms.Button btn_BPK_kantor;
        private System.Windows.Forms.Button btn_PO_kantor;
        private System.Windows.Forms.Button brn_breakdown_PO;
        private System.Windows.Forms.GroupBox input_data;
        private System.Windows.Forms.GroupBox export_report;
        private System.Windows.Forms.Button btn_report;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
