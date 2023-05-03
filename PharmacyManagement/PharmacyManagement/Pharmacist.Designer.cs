﻿namespace PharmacyManagement
{
    partial class Pharmacist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pharmacist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnSellMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedValidityCheck = new Guna.UI2.WinForms.Guna2Button();
            this.btnModifyMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddMedicine = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashbord = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_P_SellMedicine1 = new PharmacyManagement.PharmacistUC.UC_P_SellMedicine();
            this.uC_P_MedicineValidityCheck1 = new PharmacyManagement.PharmacistUC.UC_P_MedicineValidityCheck();
            this.uC_P_UpdateMedicine1 = new PharmacyManagement.PharmacistUC.UC_P_UpdateMedicine();
            this.uC_P_ViewMedicines1 = new PharmacyManagement.PharmacistUC.UC_P_ViewMedicines();
            this.uC_P_AddMedicine1 = new PharmacyManagement.PharmacistUC.UC_P_AddMedicine();
            this.uC_P_Dashbord1 = new PharmacyManagement.PharmacistUC.UC_P_Dashbord();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnSellMedicine);
            this.panel1.Controls.Add(this.btnMedValidityCheck);
            this.panel1.Controls.Add(this.btnModifyMedicine);
            this.panel1.Controls.Add(this.btnViewMedicine);
            this.panel1.Controls.Add(this.btnAddMedicine);
            this.panel1.Controls.Add(this.btnDashbord);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 768);
            this.panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLogOut.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogOut.Location = new System.Drawing.Point(12, 604);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(263, 45);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Çıkış";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSellMedicine
            // 
            this.btnSellMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSellMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSellMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnSellMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSellMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSellMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSellMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSellMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnSellMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSellMedicine.ForeColor = System.Drawing.Color.White;
            this.btnSellMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnSellMedicine.Image")));
            this.btnSellMedicine.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSellMedicine.Location = new System.Drawing.Point(12, 544);
            this.btnSellMedicine.Name = "btnSellMedicine";
            this.btnSellMedicine.Size = new System.Drawing.Size(263, 45);
            this.btnSellMedicine.TabIndex = 7;
            this.btnSellMedicine.Text = "İlaç Sat";
            this.btnSellMedicine.Click += new System.EventHandler(this.btnSellMedicine_Click);
            // 
            // btnMedValidityCheck
            // 
            this.btnMedValidityCheck.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMedValidityCheck.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMedValidityCheck.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnMedValidityCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedValidityCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedValidityCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedValidityCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedValidityCheck.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnMedValidityCheck.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMedValidityCheck.ForeColor = System.Drawing.Color.White;
            this.btnMedValidityCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnMedValidityCheck.Image")));
            this.btnMedValidityCheck.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMedValidityCheck.Location = new System.Drawing.Point(12, 484);
            this.btnMedValidityCheck.Name = "btnMedValidityCheck";
            this.btnMedValidityCheck.Size = new System.Drawing.Size(263, 45);
            this.btnMedValidityCheck.TabIndex = 6;
            this.btnMedValidityCheck.Text = "İlaç Geçerlilik Kontrolü";
            this.btnMedValidityCheck.Click += new System.EventHandler(this.btnMedValidityCheck_Click);
            // 
            // btnModifyMedicine
            // 
            this.btnModifyMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnModifyMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnModifyMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnModifyMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModifyMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModifyMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModifyMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModifyMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnModifyMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnModifyMedicine.ForeColor = System.Drawing.Color.White;
            this.btnModifyMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyMedicine.Image")));
            this.btnModifyMedicine.ImageSize = new System.Drawing.Size(30, 30);
            this.btnModifyMedicine.Location = new System.Drawing.Point(12, 424);
            this.btnModifyMedicine.Name = "btnModifyMedicine";
            this.btnModifyMedicine.Size = new System.Drawing.Size(263, 45);
            this.btnModifyMedicine.TabIndex = 5;
            this.btnModifyMedicine.Text = "İlaç Düzenle";
            this.btnModifyMedicine.Click += new System.EventHandler(this.btnModifyMedicine_Click);
            // 
            // btnViewMedicine
            // 
            this.btnViewMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnViewMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnViewMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnViewMedicine.ForeColor = System.Drawing.Color.White;
            this.btnViewMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMedicine.Image")));
            this.btnViewMedicine.ImageSize = new System.Drawing.Size(30, 30);
            this.btnViewMedicine.Location = new System.Drawing.Point(12, 364);
            this.btnViewMedicine.Name = "btnViewMedicine";
            this.btnViewMedicine.Size = new System.Drawing.Size(263, 45);
            this.btnViewMedicine.TabIndex = 4;
            this.btnViewMedicine.Text = "İlaç Görüntüle";
            this.btnViewMedicine.Click += new System.EventHandler(this.btnViewMedicine_Click);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddMedicine.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddMedicine.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMedicine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnAddMedicine.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMedicine.Image")));
            this.btnAddMedicine.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddMedicine.Location = new System.Drawing.Point(12, 304);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(263, 45);
            this.btnAddMedicine.TabIndex = 3;
            this.btnAddMedicine.Text = "İlaç Ekle";
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // btnDashbord
            // 
            this.btnDashbord.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashbord.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDashbord.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnDashbord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashbord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashbord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashbord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashbord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnDashbord.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashbord.ForeColor = System.Drawing.Color.White;
            this.btnDashbord.Image = ((System.Drawing.Image)(resources.GetObject("btnDashbord.Image")));
            this.btnDashbord.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDashbord.Location = new System.Drawing.Point(12, 244);
            this.btnDashbord.Name = "btnDashbord";
            this.btnDashbord.Size = new System.Drawing.Size(263, 45);
            this.btnDashbord.TabIndex = 2;
            this.btnDashbord.Text = "Panel";
            this.btnDashbord.Click += new System.EventHandler(this.btnDashbord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eczacı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_P_SellMedicine1);
            this.panel2.Controls.Add(this.uC_P_MedicineValidityCheck1);
            this.panel2.Controls.Add(this.uC_P_UpdateMedicine1);
            this.panel2.Controls.Add(this.uC_P_ViewMedicines1);
            this.panel2.Controls.Add(this.uC_P_AddMedicine1);
            this.panel2.Controls.Add(this.uC_P_Dashbord1);
            this.panel2.Location = new System.Drawing.Point(272, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 768);
            this.panel2.TabIndex = 1;
            // 
            // uC_P_SellMedicine1
            // 
            this.uC_P_SellMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_SellMedicine1.Location = new System.Drawing.Point(1, 0);
            this.uC_P_SellMedicine1.Name = "uC_P_SellMedicine1";
            this.uC_P_SellMedicine1.Size = new System.Drawing.Size(1104, 770);
            this.uC_P_SellMedicine1.TabIndex = 5;
            // 
            // uC_P_MedicineValidityCheck1
            // 
            this.uC_P_MedicineValidityCheck1.BackColor = System.Drawing.Color.White;
            this.uC_P_MedicineValidityCheck1.Location = new System.Drawing.Point(4, 0);
            this.uC_P_MedicineValidityCheck1.Name = "uC_P_MedicineValidityCheck1";
            this.uC_P_MedicineValidityCheck1.Size = new System.Drawing.Size(1104, 770);
            this.uC_P_MedicineValidityCheck1.TabIndex = 4;
            // 
            // uC_P_UpdateMedicine1
            // 
            this.uC_P_UpdateMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_UpdateMedicine1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_UpdateMedicine1.Name = "uC_P_UpdateMedicine1";
            this.uC_P_UpdateMedicine1.Size = new System.Drawing.Size(1104, 770);
            this.uC_P_UpdateMedicine1.TabIndex = 3;
            // 
            // uC_P_ViewMedicines1
            // 
            this.uC_P_ViewMedicines1.BackColor = System.Drawing.Color.White;
            this.uC_P_ViewMedicines1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_ViewMedicines1.Name = "uC_P_ViewMedicines1";
            this.uC_P_ViewMedicines1.Size = new System.Drawing.Size(1104, 770);
            this.uC_P_ViewMedicines1.TabIndex = 2;
            // 
            // uC_P_AddMedicine1
            // 
            this.uC_P_AddMedicine1.BackColor = System.Drawing.Color.White;
            this.uC_P_AddMedicine1.Location = new System.Drawing.Point(9, 0);
            this.uC_P_AddMedicine1.Name = "uC_P_AddMedicine1";
            this.uC_P_AddMedicine1.Size = new System.Drawing.Size(1104, 770);
            this.uC_P_AddMedicine1.TabIndex = 1;
            // 
            // uC_P_Dashbord1
            // 
            this.uC_P_Dashbord1.BackColor = System.Drawing.Color.White;
            this.uC_P_Dashbord1.Location = new System.Drawing.Point(0, 0);
            this.uC_P_Dashbord1.Name = "uC_P_Dashbord1";
            this.uC_P_Dashbord1.Size = new System.Drawing.Size(1104, 770);
            this.uC_P_Dashbord1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.panel2;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this.panel2;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this.panel2;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.TargetControl = this.panel2;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this.panel2;
            // 
            // Pharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pharmacist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacist";
            this.Load += new System.EventHandler(this.Pharmacist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnSellMedicine;
        private Guna.UI2.WinForms.Guna2Button btnMedValidityCheck;
        private Guna.UI2.WinForms.Guna2Button btnModifyMedicine;
        private Guna.UI2.WinForms.Guna2Button btnViewMedicine;
        private Guna.UI2.WinForms.Guna2Button btnAddMedicine;
        private Guna.UI2.WinForms.Guna2Button btnDashbord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private PharmacistUC.UC_P_Dashbord uC_P_Dashbord1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private PharmacistUC.UC_P_AddMedicine uC_P_AddMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private PharmacistUC.UC_P_ViewMedicines uC_P_ViewMedicines1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private PharmacistUC.UC_P_UpdateMedicine uC_P_UpdateMedicine1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private PharmacistUC.UC_P_MedicineValidityCheck uC_P_MedicineValidityCheck1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private PharmacistUC.UC_P_SellMedicine uC_P_SellMedicine1;
    }
}