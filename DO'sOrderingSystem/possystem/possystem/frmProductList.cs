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
using System.Data.SqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
namespace possystem
{
    public partial class frmProductList : Form
    {
        MySqlConnection cn = new MySqlConnection("server=localhost;database=posresto;uid=root;password=;");
        MySqlCommand cmd = new MySqlCommand();
        public frmProductList()
        {
            InitializeComponent();
        }

        private void tsbtnCreate_Click(object sender, EventArgs e)
        {
            frmProduct fpr = new frmProduct(this);
                fpr.setButtons();
                fpr.LoadCategory();
                fpr.ShowDialog();
        }
        public void LoadRecords() //list the records on datagridview
        {
            try
            {
                int i = 0;
                dgvProdList.Rows.Clear();
                cn.Open();
                cmd = new MySqlCommand("SELECT * from tblproduct", cn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i+=1;
                    dgvProdList.Rows.Add(i, dr["id"].ToString(), dr["description"].ToString(), dr["price"].ToString(), dr["category"].ToString(), dr["weight"], dr["image"], dr["status"].ToString());
                }
                dr.Close();
                cn.Close();
                for (i = 0; i < dgvProdList.Rows.Count; i++)
                {
                    DataGridViewRow r = dgvProdList.Rows[i];
                    r.Height = 90;
                }
                DataGridViewImageColumn imagecol = (DataGridViewImageColumn)dgvProdList.Columns["Column8"];
                imagecol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void dgvProdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string coln = dgvProdList.Columns[e.ColumnIndex].Name;
            if(coln == "colEdit")
            {
                using(frmProduct fprm = new frmProduct(this))
                {
                    cn.Open();
                    cmd = new MySqlCommand("SELECT image from tblproduct WHERE id like '" + dgvProdList.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while(dr.Read())
                    {
                        long len = dr.GetBytes(0, 0, null, 0, 0);
                        byte[] array = new byte[(int)len];
                        dr.GetBytes(0, 0, array, 0, (int)len);
                        using (MemoryStream ms = new MemoryStream(array))
                        {
                            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(ms);
                            fprm.pic.BackgroundImage = bitmap;
                        }
                        fprm.txtid= dgvProdList.Rows[e.RowIndex].Cells[1].Value.ToString();
                        fprm.txtdes = dgvProdList.Rows[e.RowIndex].Cells[2].Value.ToString();
                        fprm.txtpr = dgvProdList.Rows[e.RowIndex].Cells[3].Value.ToString();
                        fprm.cmcat = dgvProdList.Rows[e.RowIndex].Cells[4].Value.ToString();
                        fprm.cbx = Convert.ToBoolean(dgvProdList.Rows[e.RowIndex].Cells[5].Value);
                        fprm.cmsts = dgvProdList.Rows[e.RowIndex].Cells[7].Value.ToString();
                    }
                    dr.Close();
                    cn.Close();
                    fprm.LoadCategory();
                    fprm.setButtons2();
                    fprm.ShowDialog();
                }
            }else if (coln == "colDelete")
            {
                if (MessageBox.Show("Delete this Product?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cmd = new MySqlCommand("DELETE FROM tblproduct WHERE id like'" + dgvProdList.Rows[e.RowIndex].Cells[1].Value + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been Deleted!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }
                else
                {
                    MessageBox.Show("Deletion Cancelled!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
