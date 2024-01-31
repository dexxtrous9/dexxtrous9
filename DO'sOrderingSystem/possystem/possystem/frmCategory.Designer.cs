namespace possystem
{
    partial class frmCategory
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.gbtnSave = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(316, 10);
            this.guna2Panel1.TabIndex = 3;
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.lblClose.Location = new System.Drawing.Point(251, 13);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(62, 17);
            this.lblClose.TabIndex = 5;
            this.lblClose.Text = "[ CLOSE ]";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "CATEGORY ENTRY";
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.txtCategory.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.txtCategory.Location = new System.Drawing.Point(12, 48);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(288, 25);
            this.txtCategory.TabIndex = 8;
            // 
            // gbtnSave
            // 
            this.gbtnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.gbtnSave.BorderRadius = 15;
            this.gbtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.gbtnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.gbtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.gbtnSave.Location = new System.Drawing.Point(115, 81);
            this.gbtnSave.Name = "gbtnSave";
            this.gbtnSave.Size = new System.Drawing.Size(83, 30);
            this.gbtnSave.TabIndex = 11;
            this.gbtnSave.Text = "Save";
            this.gbtnSave.Click += new System.EventHandler(this.gbtnSave_Click);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(316, 120);
            this.ControlBox = false;
            this.Controls.Add(this.gbtnSave);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategory;
        private Guna.UI2.WinForms.Guna2Button gbtnSave;
    }
}