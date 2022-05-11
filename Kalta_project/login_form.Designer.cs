namespace Kalta_project
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_info_login = new System.Windows.Forms.Label();
            this.lbl_welcome_Admin = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_pass_login = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_user_login = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.panel_login_bg = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_copyright = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel_login_bg.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.groupBox1.Controls.Add(this.lbl_info_login);
            this.groupBox1.Controls.Add(this.lbl_welcome_Admin);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.txt_pass_login);
            this.groupBox1.Controls.Add(this.lbl_password);
            this.groupBox1.Controls.Add(this.txt_user_login);
            this.groupBox1.Controls.Add(this.lbl_username);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(260, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 250);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Page";
            // 
            // lbl_info_login
            // 
            this.lbl_info_login.AutoSize = true;
            this.lbl_info_login.ForeColor = System.Drawing.Color.White;
            this.lbl_info_login.Location = new System.Drawing.Point(93, 233);
            this.lbl_info_login.Name = "lbl_info_login";
            this.lbl_info_login.Size = new System.Drawing.Size(0, 13);
            this.lbl_info_login.TabIndex = 8;
            // 
            // lbl_welcome_Admin
            // 
            this.lbl_welcome_Admin.AutoSize = true;
            this.lbl_welcome_Admin.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome_Admin.Location = new System.Drawing.Point(26, 50);
            this.lbl_welcome_Admin.Name = "lbl_welcome_Admin";
            this.lbl_welcome_Admin.Size = new System.Drawing.Size(254, 36);
            this.lbl_welcome_Admin.TabIndex = 6;
            this.lbl_welcome_Admin.Text = "Welcome Admin";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login.Location = new System.Drawing.Point(96, 194);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(155, 23);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_pass_login
            // 
            this.txt_pass_login.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass_login.Location = new System.Drawing.Point(96, 152);
            this.txt_pass_login.Name = "txt_pass_login";
            this.txt_pass_login.Size = new System.Drawing.Size(155, 23);
            this.txt_pass_login.TabIndex = 1;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(37, 156);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password";
            // 
            // txt_user_login
            // 
            this.txt_user_login.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_login.Location = new System.Drawing.Point(96, 107);
            this.txt_user_login.Name = "txt_user_login";
            this.txt_user_login.Size = new System.Drawing.Size(155, 23);
            this.txt_user_login.TabIndex = 0;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(37, 112);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(56, 13);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "Username";
            // 
            // panel_login_bg
            // 
            this.panel_login_bg.BackColor = System.Drawing.Color.Transparent;
            this.panel_login_bg.BackgroundImage = global::Kalta_project.Properties.Resources.more_leaves;
            this.panel_login_bg.Controls.Add(this.label1);
            this.panel_login_bg.Controls.Add(this.lbl_copyright);
            this.panel_login_bg.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_login_bg.Location = new System.Drawing.Point(0, 0);
            this.panel_login_bg.Name = "panel_login_bg";
            this.panel_login_bg.Size = new System.Drawing.Size(254, 266);
            this.panel_login_bg.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 177);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kalta \r\nSoftware \r\nProject";
            // 
            // lbl_copyright
            // 
            this.lbl_copyright.AutoSize = true;
            this.lbl_copyright.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_copyright.Location = new System.Drawing.Point(19, 240);
            this.lbl_copyright.Name = "lbl_copyright";
            this.lbl_copyright.Size = new System.Drawing.Size(190, 13);
            this.lbl_copyright.TabIndex = 7;
            this.lbl_copyright.Text = "Kalta Software Project - Copyright 2022";
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(573, 266);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel_login_bg);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN-LOGIN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_login_bg.ResumeLayout(false);
            this.panel_login_bg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel_login_bg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_info_login;
        private System.Windows.Forms.Label lbl_copyright;
        private System.Windows.Forms.Label lbl_welcome_Admin;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_pass_login;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_user_login;
        private System.Windows.Forms.Label lbl_username;
    }
}

