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
    public partial class frmTableOrder : Form
    {
        MySqlConnection cn = new MySqlConnection("server=localhost;database=posresto;uid=root;password=;");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dr;
        Button btnTable = new Button();
        string table = "";
        frmMain frmm = new frmMain();
        public frmTableOrder(frmMain frmmn)
        {
            InitializeComponent();
            frmm = frmmn;
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void LoadTable()
        {
            cn.Open();
            cmd = new MySqlCommand("SELECT * from vwtable", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                btnTable = new Button();
                btnTable.Width = 150;
                btnTable.Height = 40;
                if (Convert.ToDouble(dr["bill"].ToString()) > 1)
                {
                    btnTable.Text = dr["tableno"].ToString() + " - ₱" + dr["bill"].ToString();
                    btnTable.BackColor = Color.FromArgb(224, 67, 67);
                }
                else
                {
                    btnTable.Text = dr["tableno"].ToString();
                    btnTable.BackColor = Color.FromArgb(114, 40, 9);
                }
                btnTable.Tag = dr["tableno"].ToString();
                btnTable.FlatStyle = FlatStyle.Flat;
                btnTable.ForeColor = Color.FromArgb(248, 246, 240);
                btnTable.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btnTable.Cursor = Cursors.Hand;
                btnTable.TextAlign = ContentAlignment.MiddleLeft;

                flpTableOrder.Controls.Add(btnTable);
                btnTable.Click += getTable_Click;
            }
            dr.Close();
            cn.Close();
        }
        public void getTable_Click(object sender, EventArgs e)
        {
            table = ((Button)sender).Text;
            frmm.lbltblno = table;
            frmm.GetOrder();
            this.Dispose();
        }
    }
}
