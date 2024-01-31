namespace possystem
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.btnTable = new Guna.UI2.WinForms.Guna2Button();
            this.btnProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnPayment = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewOrder = new Guna.UI2.WinForms.Guna2Button();
            this.flpCategory = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewImageColumn();
            this.flpItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTransNo = new System.Windows.Forms.Label();
            this.lblTblNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
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
            this.guna2Panel1.Controls.Add(this.lblTotal);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1400, 46);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(206)))), ((int)(((byte)(133)))));
            this.lblTotal.Location = new System.Drawing.Point(1156, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(244, 46);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(169, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "| CPE204";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "DO\'s POINT OF SALE";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.guna2Panel2.BorderRadius = 20;
            this.guna2Panel2.Controls.Add(this.guna2Button8);
            this.guna2Panel2.Controls.Add(this.guna2Button7);
            this.guna2Panel2.Controls.Add(this.guna2Button6);
            this.guna2Panel2.Controls.Add(this.btnTable);
            this.guna2Panel2.Controls.Add(this.btnProduct);
            this.guna2Panel2.Controls.Add(this.btnCancel);
            this.guna2Panel2.Controls.Add(this.btnPayment);
            this.guna2Panel2.Controls.Add(this.btnNewOrder);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 646);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1400, 54);
            this.guna2Panel2.TabIndex = 1;
            // 
            // guna2Button8
            // 
            this.guna2Button8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.guna2Button8.BorderRadius = 15;
            this.guna2Button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.guna2Button8.Location = new System.Drawing.Point(1230, 6);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(168, 37);
            this.guna2Button8.TabIndex = 7;
            this.guna2Button8.Text = "[F8 - Logout]";
            // 
            // guna2Button7
            // 
            this.guna2Button7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.guna2Button7.BorderRadius = 15;
            this.guna2Button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.guna2Button7.Location = new System.Drawing.Point(1019, 6);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(168, 37);
            this.guna2Button7.TabIndex = 6;
            this.guna2Button7.Text = "[F6 - Sales Report]";
            // 
            // guna2Button6
            // 
            this.guna2Button6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.guna2Button6.BorderRadius = 15;
            this.guna2Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.guna2Button6.Location = new System.Drawing.Point(849, 6);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(168, 37);
            this.guna2Button6.TabIndex = 5;
            this.guna2Button6.Text = "[F6 - Sales Report]";
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // btnTable
            // 
            this.btnTable.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.btnTable.BorderRadius = 15;
            this.btnTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.btnTable.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.btnTable.Location = new System.Drawing.Point(680, 6);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(168, 37);
            this.btnTable.TabIndex = 4;
            this.btnTable.Text = "[F5 - Manage Table]";
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.btnProduct.BorderRadius = 15;
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.btnProduct.Location = new System.Drawing.Point(511, 5);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(168, 37);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "[F4 - Manage Product]";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.Enabled = false;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.btnCancel.Location = new System.Drawing.Point(342, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 37);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "[F3 - Cancel Order]";
            // 
            // btnPayment
            // 
            this.btnPayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.btnPayment.BorderRadius = 15;
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPayment.Enabled = false;
            this.btnPayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.btnPayment.Location = new System.Drawing.Point(173, 7);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(168, 37);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "[F2 - Settle Payment]";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.btnNewOrder.BorderRadius = 15;
            this.btnNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(137)))), ((int)(((byte)(88)))));
            this.btnNewOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.btnNewOrder.Location = new System.Drawing.Point(4, 7);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(168, 37);
            this.btnNewOrder.TabIndex = 0;
            this.btnNewOrder.Text = "[F1 - New Order]";
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // flpCategory
            // 
            this.flpCategory.Location = new System.Drawing.Point(7, 111);
            this.flpCategory.Name = "flpCategory";
            this.flpCategory.Size = new System.Drawing.Size(110, 529);
            this.flpCategory.TabIndex = 2;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToResizeColumns = false;
            this.dgvOrders.AllowUserToResizeRows = false;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.ColumnHeadersHeight = 30;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.colRemove});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(99)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrders.EnableHeadersVisualStyles = false;
            this.dgvOrders.Location = new System.Drawing.Point(827, 111);
            this.dgvOrders.Name = "dgvOrders";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(99)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(562, 529);
            this.dgvOrders.TabIndex = 3;
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "DESCRIPTION";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "PRICE";
            this.Column3.Name = "Column3";
            this.Column3.Width = 64;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "ORDER";
            this.Column4.Name = "Column4";
            this.Column4.Width = 71;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "TOTAL";
            this.Column5.Name = "Column5";
            this.Column5.Width = 67;
            // 
            // colRemove
            // 
            this.colRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRemove.HeaderText = "";
            this.colRemove.Image = ((System.Drawing.Image)(resources.GetObject("colRemove.Image")));
            this.colRemove.Name = "colRemove";
            this.colRemove.Width = 5;
            // 
            // flpItems
            // 
            this.flpItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpItems.Location = new System.Drawing.Point(118, 111);
            this.flpItems.Name = "flpItems";
            this.flpItems.Size = new System.Drawing.Size(700, 529);
            this.flpItems.TabIndex = 4;
            // 
            // lblTransNo
            // 
            this.lblTransNo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(206)))), ((int)(((byte)(133)))));
            this.lblTransNo.Location = new System.Drawing.Point(178, 49);
            this.lblTransNo.Name = "lblTransNo";
            this.lblTransNo.Size = new System.Drawing.Size(229, 30);
            this.lblTransNo.TabIndex = 5;
            this.lblTransNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTblNo
            // 
            this.lblTblNo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTblNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(206)))), ((int)(((byte)(133)))));
            this.lblTblNo.Location = new System.Drawing.Point(178, 78);
            this.lblTblNo.Name = "lblTblNo";
            this.lblTblNo.Size = new System.Drawing.Size(229, 30);
            this.lblTblNo.TabIndex = 6;
            this.lblTblNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.label5.Location = new System.Drawing.Point(8, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "TRANSACTION NO.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(40)))), ((int)(((byte)(9)))));
            this.label6.Location = new System.Drawing.Point(8, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 30);
            this.label6.TabIndex = 7;
            this.label6.Text = "TABLE/ORDER NO.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1400, 700);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTblNo);
            this.Controls.Add(this.lblTransNo);
            this.Controls.Add(this.flpItems);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.flpCategory);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnNewOrder;
        private Guna.UI2.WinForms.Guna2Button btnPayment;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button btnTable;
        private Guna.UI2.WinForms.Guna2Button btnProduct;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private System.Windows.Forms.FlowLayoutPanel flpCategory;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpItems;
        private System.Windows.Forms.Label lblTransNo;
        private System.Windows.Forms.Label lblTblNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn colRemove;
    }
}

