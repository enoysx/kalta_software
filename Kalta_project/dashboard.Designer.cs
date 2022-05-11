namespace Kalta_project
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_dash_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_container = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_invent = new System.Windows.Forms.Button();
            this.btn_dash_cost_control = new System.Windows.Forms.Button();
            this.btn_management = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_dash_container = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_container.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.btn_dash_logout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 39);
            this.panel1.TabIndex = 0;
            // 
            // btn_dash_logout
            // 
            this.btn_dash_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dash_logout.FlatAppearance.BorderSize = 0;
            this.btn_dash_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_dash_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_dash_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dash_logout.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dash_logout.ForeColor = System.Drawing.Color.White;
            this.btn_dash_logout.Location = new System.Drawing.Point(728, 8);
            this.btn_dash_logout.Name = "btn_dash_logout";
            this.btn_dash_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_dash_logout.TabIndex = 2;
            this.btn_dash_logout.Text = "Logout";
            this.btn_dash_logout.UseVisualStyleBackColor = true;
            this.btn_dash_logout.Click += new System.EventHandler(this.btn_dash_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kalta Software Project";
            // 
            // panel_container
            // 
            this.panel_container.Controls.Add(this.panel_dash_container);
            this.panel_container.Controls.Add(this.flowLayoutPanel1);
            this.panel_container.Controls.Add(this.menuStrip1);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 39);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(815, 358);
            this.panel_container.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btn_invent
            // 
            this.btn_invent.FlatAppearance.BorderSize = 0;
            this.btn_invent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_invent.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invent.Location = new System.Drawing.Point(3, 61);
            this.btn_invent.Name = "btn_invent";
            this.btn_invent.Size = new System.Drawing.Size(161, 23);
            this.btn_invent.TabIndex = 4;
            this.btn_invent.Text = "Inventory";
            this.btn_invent.UseVisualStyleBackColor = true;
            // 
            // btn_dash_cost_control
            // 
            this.btn_dash_cost_control.FlatAppearance.BorderSize = 0;
            this.btn_dash_cost_control.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dash_cost_control.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dash_cost_control.Location = new System.Drawing.Point(3, 3);
            this.btn_dash_cost_control.Name = "btn_dash_cost_control";
            this.btn_dash_cost_control.Size = new System.Drawing.Size(161, 23);
            this.btn_dash_cost_control.TabIndex = 2;
            this.btn_dash_cost_control.Text = "Cost Contol";
            this.btn_dash_cost_control.UseVisualStyleBackColor = true;
            this.btn_dash_cost_control.Click += new System.EventHandler(this.btn_dash_cost_control_Click);
            // 
            // btn_management
            // 
            this.btn_management.FlatAppearance.BorderSize = 0;
            this.btn_management.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_management.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_management.Location = new System.Drawing.Point(3, 32);
            this.btn_management.Name = "btn_management";
            this.btn_management.Size = new System.Drawing.Size(161, 23);
            this.btn_management.TabIndex = 3;
            this.btn_management.Text = "Management";
            this.btn_management.UseVisualStyleBackColor = true;
            this.btn_management.Click += new System.EventHandler(this.btn_management_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.btn_dash_cost_control);
            this.flowLayoutPanel1.Controls.Add(this.btn_management);
            this.flowLayoutPanel1.Controls.Add(this.btn_invent);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(168, 334);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panel_dash_container
            // 
            this.panel_dash_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dash_container.Location = new System.Drawing.Point(168, 24);
            this.panel_dash_container.Name = "panel_dash_container";
            this.panel_dash_container.Size = new System.Drawing.Size(647, 334);
            this.panel_dash_container.TabIndex = 9;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 397);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dashboard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Button btn_dash_logout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_dash_cost_control;
        private System.Windows.Forms.Button btn_management;
        private System.Windows.Forms.Button btn_invent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panel_dash_container;
    }
}