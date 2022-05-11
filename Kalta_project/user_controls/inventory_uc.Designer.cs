namespace Kalta_project.user_controls
{
    partial class inventory_uc
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
            this.lbl_inventory = new System.Windows.Forms.Label();
            this.btn_PO_kantor = new System.Windows.Forms.Button();
            this.btn_BPK_proyek = new System.Windows.Forms.Button();
            this.btn_BPK_kantor = new System.Windows.Forms.Button();
            this.brn_breakdown_PO = new System.Windows.Forms.Button();
            this.btn_breakdown_RAP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_inventory
            // 
            this.lbl_inventory.AutoSize = true;
            this.lbl_inventory.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventory.Location = new System.Drawing.Point(43, 23);
            this.lbl_inventory.Name = "lbl_inventory";
            this.lbl_inventory.Size = new System.Drawing.Size(145, 39);
            this.lbl_inventory.TabIndex = 6;
            this.lbl_inventory.Text = "Inventory";
            // 
            // btn_PO_kantor
            // 
            this.btn_PO_kantor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PO_kantor.Location = new System.Drawing.Point(50, 237);
            this.btn_PO_kantor.Name = "btn_PO_kantor";
            this.btn_PO_kantor.Size = new System.Drawing.Size(131, 23);
            this.btn_PO_kantor.TabIndex = 11;
            this.btn_PO_kantor.Text = "PO KANTOR";
            this.btn_PO_kantor.UseVisualStyleBackColor = true;
            // 
            // btn_BPK_proyek
            // 
            this.btn_BPK_proyek.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BPK_proyek.Location = new System.Drawing.Point(202, 169);
            this.btn_BPK_proyek.Name = "btn_BPK_proyek";
            this.btn_BPK_proyek.Size = new System.Drawing.Size(131, 23);
            this.btn_BPK_proyek.TabIndex = 10;
            this.btn_BPK_proyek.Text = "BPK PROYEK";
            this.btn_BPK_proyek.UseVisualStyleBackColor = true;
            // 
            // btn_BPK_kantor
            // 
            this.btn_BPK_kantor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BPK_kantor.Location = new System.Drawing.Point(50, 169);
            this.btn_BPK_kantor.Name = "btn_BPK_kantor";
            this.btn_BPK_kantor.Size = new System.Drawing.Size(131, 23);
            this.btn_BPK_kantor.TabIndex = 9;
            this.btn_BPK_kantor.Text = "BPK KANTOR";
            this.btn_BPK_kantor.UseVisualStyleBackColor = true;
            // 
            // brn_breakdown_PO
            // 
            this.brn_breakdown_PO.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_breakdown_PO.Location = new System.Drawing.Point(202, 97);
            this.brn_breakdown_PO.Name = "brn_breakdown_PO";
            this.brn_breakdown_PO.Size = new System.Drawing.Size(131, 23);
            this.brn_breakdown_PO.TabIndex = 8;
            this.brn_breakdown_PO.Text = "BREAKDOWN PO";
            this.brn_breakdown_PO.UseVisualStyleBackColor = true;
            // 
            // btn_breakdown_RAP
            // 
            this.btn_breakdown_RAP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_breakdown_RAP.Location = new System.Drawing.Point(50, 97);
            this.btn_breakdown_RAP.Name = "btn_breakdown_RAP";
            this.btn_breakdown_RAP.Size = new System.Drawing.Size(131, 23);
            this.btn_breakdown_RAP.TabIndex = 7;
            this.btn_breakdown_RAP.Text = "BREAKDOWN RAP";
            this.btn_breakdown_RAP.UseVisualStyleBackColor = true;
            // 
            // inventory_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_PO_kantor);
            this.Controls.Add(this.btn_BPK_proyek);
            this.Controls.Add(this.btn_BPK_kantor);
            this.Controls.Add(this.brn_breakdown_PO);
            this.Controls.Add(this.btn_breakdown_RAP);
            this.Controls.Add(this.lbl_inventory);
            this.Name = "inventory_uc";
            this.Size = new System.Drawing.Size(542, 317);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_inventory;
        private System.Windows.Forms.Button btn_PO_kantor;
        private System.Windows.Forms.Button btn_BPK_proyek;
        private System.Windows.Forms.Button btn_BPK_kantor;
        private System.Windows.Forms.Button brn_breakdown_PO;
        private System.Windows.Forms.Button btn_breakdown_RAP;
    }
}
