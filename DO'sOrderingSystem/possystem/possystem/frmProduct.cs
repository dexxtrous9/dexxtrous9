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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Web.UI.WebControls;
using Org.BouncyCastle.Asn1.Cmp;
using System.Data.SqlClient;

namespace possystem
{
    public partial class frmProduct : Form
    {
        MySqlConnection cn = new MySqlConnection("server=localhost;database=posresto;uid=root;password=;");
        frmProductList frmp;
        public frmProduct(frmProductList fpl)
        {
            InitializeComponent();
            frmp = fpl;
        }
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label3_Click(object sender, EventArgs e){}
     
        private void gbtnAdd_Click(object sender, EventArgs e)
        {
            using (frmCategory frc = new frmCategory(this))
            {
                frc.ShowDialog();
            }
            LoadCategory();
        }

        private void gbtnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg|*.jpg|Png|*.png|Bmp|*.bmp|Gif|*.gif|Ico|*.ico",
                Multiselect = false,
                Title = "Select Image"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    System.Drawing.Image img = System.Drawing.Image.FromFile(ofd.FileName);
                    pictureBox1.BackgroundImage = img;
                    openFileDialog1.FileName = ofd.FileName;
                }
            }
        }
        public void LoadCategory()
        {
            try{
                cmbCategory.Items.Clear();
                {
                cn.Open();
                using (MySqlCommand cm = new MySqlCommand("SELECT * from tblcategory", cn))
                {
                    using (MySqlDataReader dr = cm.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            cmbCategory.Items.Add(dr["category"].ToString());
                        }
                        dr.Close();
                        cn.Close();
                        }
                }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string txtid
        {
            get { return txtID.Text; }
            set { txtID.Text = value; }
        }
        public string txtdes
        {
            get { return txtDesc.Text; }
            set { txtDesc.Text = value; }
        }
        public string txtpr
        {
            get { return txtPrice.Text; }
            set { txtPrice.Text = value; }
        }
        public string cmcat
        {
            get { return cmbCategory.Text; }
            set { cmbCategory.Text = value; }
        }
        public bool cbx
        {
            get { return cbWeight.Checked; }
            set { cbWeight.Checked = value; }
        }
        public string cmsts
        {
            get { return cmbStatus.Text; }
            set { cmbStatus.Text = value; }
        }
        public PictureBox pic
        {
            get
            {
                return pictureBox1;
            }
        }
        public void setButtons()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
        public void setButtons2()
        {
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
        }
        void Clear()
        {
            txtDesc.Clear();
            txtID.Text = "[AUTO]";
            txtPrice.Clear();
            pictureBox1.BackgroundImage= null;
            cmbCategory.Text = "";
            cmbStatus.Text = "";
            setButtons();
            txtDesc.Focus();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {         
            try
            {
                if (openFileDialog1.FileName == "openFileDialog1")
                {
                    MessageBox.Show("Please select image", "CRITICAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(txtDesc.Text) || string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("Please input data", "CRITICAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(cmbCategory.Text) || string.IsNullOrEmpty(cmbStatus.Text))
                {
                    MessageBox.Show("Please select data from the list", "CRITICAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Save this Product?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MemoryStream mstream = new MemoryStream();
                    pictureBox1.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] arrImage = mstream.GetBuffer();

                    string insertQuery = "INSERT INTO posresto.tblproduct(description, price, category, weight, image) VALUES(@description, @price, @category, @weight, @image)";
                    cn.Open();
                    MySqlCommand scmd = new MySqlCommand(insertQuery, cn);
                    scmd.Parameters.AddWithValue("@description", txtDesc.Text);
                    scmd.Parameters.AddWithValue("@price", Convert.ToDouble(txtPrice.Text));
                    scmd.Parameters.AddWithValue("@category", cmbCategory.Text);
                    scmd.Parameters.AddWithValue("@weight", cbWeight.Checked.ToString());
                    scmd.Parameters.AddWithValue("@image", arrImage);
                    scmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been Saved!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    frmp.LoadRecords();
                }
            }
            catch (Exception ex)
            {
                Clear();
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
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
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cmbCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        public static byte[] ImageToBytes(System.Drawing.Image userImage)//converting image from my picturebox into byte
        {
            using (MemoryStream ms = new MemoryStream())
            using (Bitmap tempImage = new Bitmap(userImage))
            {
                tempImage.Save(ms, userImage.RawFormat);
                return ms.ToArray();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtDesc.Text) || string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("Please input data", "CRITICAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(cmbCategory.Text) || string.IsNullOrEmpty(cmbStatus.Text))
                {
                    MessageBox.Show("Please select data from the list", "CRITICAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Update this Product?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    byte[] arrImage = ImageToBytes(pictureBox1.BackgroundImage);

                    string updateQuery = "UPDATE posresto.tblproduct SET description=@description, price=@price, category=@category, weight=@weight, image=@image WHERE id=@id";
                    cn.Open();
                    using (MySqlCommand scmd = new MySqlCommand(updateQuery, cn))
                    {
                        scmd.Parameters.AddWithValue("@description", txtDesc.Text);
                        scmd.Parameters.AddWithValue("@price", Convert.ToDouble(txtPrice.Text));
                        scmd.Parameters.AddWithValue("@category", cmbCategory.Text);
                        scmd.Parameters.AddWithValue("@weight", cbWeight.Checked.ToString());
                        scmd.Parameters.AddWithValue("@image", arrImage);
                        scmd.Parameters.AddWithValue("@id", txtID.Text);
                        scmd.ExecuteNonQuery();
                    }
                    cn.Close();
                    MessageBox.Show("Product has been Updated!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    frmp.LoadRecords();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Updating Cancelled!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }
    }
 }

