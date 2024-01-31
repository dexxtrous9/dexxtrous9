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
namespace possystem
{
    public partial class frmQty : Form
    {
        MySqlConnection cn = new MySqlConnection("server=localhost;database=posresto;uid=root;password=;");
        MySqlCommand cmd = new MySqlCommand();
        frmMain frmm;
        string id;
        double price;
        public frmQty(frmMain frmmn)
        {
            InitializeComponent();
            frmm = frmmn;
        }

        private void frmQty_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }


        public void AddToCart(string id, double price, bool weight)
        {
            try
            {
                if(weight==false)
                {
                    lblQty.Text = "QUANTITY";
                } else
                {
                    lblQty.Text = "WEIGHT";
                }
                this.price = price;
                this.id = id;
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((int)e.KeyChar)
            {
                case 48: // '0'
                case 49: // '1'
                case 50: // '2'
                case 51: // '3'
                case 52: // '4'
                case 53: // '5'
                case 54: // '6'
                case 55: // '7'
                case 56: // '8'
                case 57: // '9'
                case 46: // '.'
                case 8:  // Backspace
                case 13:
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void frmQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                string sdate = DateTime.Now.ToString("yyyy-MM-dd");
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO tblcart (transno, pid, price, tdate, tableno, qty) VALUES(@transno, @pid, @price, @tdate, @tableno, @qty)", cn))
                {
                    cmd.Parameters.AddWithValue("@transno", frmm.lbltrnsno);
                    cmd.Parameters.AddWithValue("@pid", id);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@tdate", sdate);
                    cmd.Parameters.AddWithValue("@tableno", frmm.lbltblno);
                    cmd.Parameters.AddWithValue("@qty", Convert.ToDouble(txtQty.Text));
                    cmd.ExecuteNonQuery();
                }
                cn.Close();

                cn.Open();
                cmd = new MySqlCommand("UPDATE tblcart SET total = price * qty", cn);
                cmd.ExecuteNonQuery();
                
                cn.Close();
                this.Dispose();
                frmm.LoadCart();
            }
        }
    }
}
