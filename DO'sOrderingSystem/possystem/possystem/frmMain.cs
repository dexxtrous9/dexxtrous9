using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Google.Protobuf.WellKnownTypes;
using Mysqlx.Crud;
namespace possystem
{
    public partial class frmMain : Form
    {
        MySqlConnection cn = new MySqlConnection("server=localhost;database=posresto;uid=root;password=;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;
        Button btnCategory = new Button();
        PictureBox pic = new PictureBox();
        Label lblDesc,lblPrice = new Label();
        string _filter = "";
        public frmMain()
        {
            InitializeComponent();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                Connection.dataSource();
                LoadCateg();
                LoadMenu();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public string lbltblno
        {
            get { return lblTblNo.Text; }
            set { lblTblNo.Text = value; }
        }
        public string lbltrnsno
        {
            get { return lblTransNo.Text; }
            set { lblTransNo.Text = value; }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            using (frmProductList fpl = new frmProductList())
            {
                fpl.LoadRecords();
                fpl.ShowDialog();
            }
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            using(frmTable ftbl = new frmTable())
            {
                ftbl.LoadTable();
                ftbl.setButtons();
                ftbl.ShowDialog();
            }
        }

        public void LoadMenu()
        {
            flpItems.AutoScroll = true;
            flpItems.Controls.Clear();
            cn.Open();
            cmd = new MySqlCommand("SELECT image, id, description, price, weight, status FROM tblproduct WHERE category like '"+_filter+"%' order by description", cn);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {   //For Picture
                long len = dr.GetBytes(0, 0, null, 0, 0);
                byte[] array = new byte[(int)len];
                dr.GetBytes(0, 0, array, 0, (int)len);
                pic = new PictureBox();
                pic.Width = 110;
                pic.Height = 110;
                pic.BackgroundImageLayout = ImageLayout.Stretch;
                MemoryStream ms = new MemoryStream(array);
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(ms);
                pic.BackgroundImage = bitmap;
                pic.Tag = dr["id"].ToString();
                
                //For Description
                lblDesc = new Label();
                lblDesc.BackColor = Color.FromArgb(182, 144, 128);
                lblDesc.ForeColor = Color.FromArgb(248, 246, 240);
                lblDesc.TextAlign = ContentAlignment.MiddleCenter;
                lblDesc.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                lblDesc.Text = dr["description"].ToString();
                lblDesc.Dock = DockStyle.Bottom;
                lblDesc.Cursor = Cursors.Hand;
                lblDesc.Tag = dr["description"].ToString();

                //For Price
                lblPrice = new Label();
                lblPrice.BackColor = Color.Empty;
                lblPrice.ForeColor = Color.FromArgb(114, 40, 9);
                lblPrice.TextAlign = ContentAlignment.MiddleCenter;
                lblPrice.Font = new Font("Consolas", 8, FontStyle.Bold);
                lblPrice.Text = dr["price"].ToString();
                lblPrice.Dock = DockStyle.Top;
                lblPrice.Cursor = Cursors.Hand;
                lblPrice.AutoSize = true;
                lblPrice.Tag = dr["price"].ToString();

                pic.Controls.Add(lblPrice);
                pic.Controls.Add(lblDesc);
                flpItems.Controls.Add(pic);

                pic.Click += select_Click;
                lblDesc.Click += select_Click;
                lblPrice.Click += select_Click;
            }
            dr.Close();
            cn.Close();
        }

        public void select_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblTblNo.Text))
            {
                MessageBox.Show("Please select a new order first", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                double price = 0.0;
                bool weight=false;
                string id = ((Control)sender).Tag.ToString();

                cn.Open();
                using (cmd = new MySqlCommand("SELECT * FROM tblproduct where id LIKE '" + id + "'", cn))
                {
                 dr = cmd.ExecuteReader();
                   if (dr.Read())
                   {
                        price = Convert.ToDouble(dr["price"]);
                        weight = Convert.ToBoolean(dr["weight"]);
                    }                  
                }
                dr.Close();
                cn.Close();
                frmQty frmq = new frmQty(this);
                frmq.AddToCart(id, price, weight);
                frmq.ShowDialog();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Critical", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadCart()
        {
            double _total = 0.0;
            dgvOrders.Rows.Clear();
            cn.Open();
            cmd = new MySqlCommand("SELECT c.id, p.description, c.price, c.qty, c.total FROM tblcart AS c INNER JOIN tblproduct AS p ON p.id = c.pid WHERE c.transno LIKE '" + lblTransNo.Text + "'", cn);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                _total += Convert.ToDouble(dr["total"].ToString());
                dgvOrders.Rows.Add(dr["id"].ToString(), dr["description"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["total"].ToString());
            }

            dr.Close();
            cn.Close();
            lblTotal.Text = _total.ToString("#,##0.00");

            if (dgvOrders.Rows.Count < 1)
            {
                btnPayment.Enabled = false;
                btnCancel.Enabled = false;
            }
            else
            {
                btnPayment.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        public void LoadCateg()
        {
            cn.Open();
            cmd = new MySqlCommand("SELECT * from tblcategory", cn);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                btnCategory = new Button();
                btnCategory.Width = 100;
                btnCategory.Height = 40;
                btnCategory.Text = dr["category"].ToString();
                btnCategory.FlatStyle = FlatStyle.Flat;
                btnCategory.BackColor = Color.FromArgb(114, 40, 9);
                btnCategory.ForeColor = Color.FromArgb(248, 246, 240);
                btnCategory.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btnCategory.Cursor = Cursors.Hand;
                btnCategory.TextAlign = ContentAlignment.MiddleLeft;
                flpCategory.Controls.Add(btnCategory);

                btnCategory.Click += filter_Click;
            }
            dr.Close();
            cn.Close();
        }
        public void filter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblTblNo.Text))
            {
                MessageBox.Show("Please select a New Order first!", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _filter = ((Button)sender).Text.ToString();
            LoadMenu();
        }
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            lblTransNo.Text = GetTransNo();
            frmTableOrder frmt = new frmTableOrder(this);
            frmt.LoadTable();
            frmt.ShowDialog();
            LoadCart();
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = dgvOrders.Columns[e.ColumnIndex].Name;

            if (colname == "colRemove")
            {
                if (MessageBox.Show("Remove this item?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new MySqlCommand("DELETE FROM tblcart WHERE id LIKE '" + dgvOrders.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item removed from the cart!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCart();
                }
                else
                {
                    MessageBox.Show("Removing Cancelled!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public string GetTransNo()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                cn.Open();
                cmd = new MySqlCommand("SELECT * FROM tblcart WHERE transno LIKE '" + sdate + "%' ORDER BY id DESC", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return (long.Parse(dr["transno"].ToString()) + 1).ToString();
                }
                else
                {
                    return sdate + "0001";
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "CRITICAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
            finally
            {
                dr.Close();
                cn.Close();
            }
        }

        public void GetOrder()
        {/////////ERROR IN THIS PART
            bool found = false;
            string tno = string.Empty;

            cn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblcart WHERE tableno LIKE '" + lblTblNo.Text + "'", cn);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                found = true;
                tno = dr["transno"].ToString();
            }

            dr.Close();
            cn.Close();

            if (found)
            {
                lblTransNo.Text = tno;
                LoadCart();
            }
        }
    }
}
