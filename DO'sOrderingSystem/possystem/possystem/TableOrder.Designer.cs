namespace possystem
{
    partial class frmTableOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableOrder));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.flpTableOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsbtnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 10);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1108, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(152, 22);
            this.toolStripLabel1.Text = "SELECT TABLE | ORDER NO.";
            // 
            // tsbtnClose
            // 
            this.tsbtnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.tsbtnClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnClose.Image")));
            this.tsbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClose.Name = "tsbtnClose";
            this.tsbtnClose.Size = new System.Drawing.Size(23, 22);
            this.tsbtnClose.Click += new System.EventHandler(this.tsbtnClose_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1108, 10);
            this.guna2Panel1.TabIndex = 3;
            // 
            // flpTableOrder
            // 
            this.flpTableOrder.Location = new System.Drawing.Point(6, 42);
            this.flpTableOrder.Name = "flpTableOrder";
            this.flpTableOrder.Size = new System.Drawing.Size(1095, 471);
            this.flpTableOrder.TabIndex = 5;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // frmTableOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1108, 524);
            this.ControlBox = false;
            this.Controls.Add(this.flpTableOrder);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTableOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel flpTableOrder;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}