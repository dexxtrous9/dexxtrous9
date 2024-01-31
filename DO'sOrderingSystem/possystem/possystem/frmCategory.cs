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
    public partial class frmCategory : Form
    {
        MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;");
        frmProduct frmp;
        public frmCategory(frmProduct frp)
        {
            InitializeComponent();
            frmp = frp;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void gbtnSave_Click(object sender, EventArgs e)
        {           
            try
            {
                if (string.IsNullOrEmpty(txtCategory.Text))
                {
                    MessageBox.Show("Please input Category!", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Save this Category?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    string insertQuery = "INSERT INTO posresto.tblcategory(category) VALUES('" + txtCategory.Text+ "');";
                    cn.Open();
                    MySqlCommand scmd = new MySqlCommand(insertQuery, cn);
                    MySqlDataReader reader;
                    reader = scmd.ExecuteReader();
                    while(reader.Read())
                     {
                     }
                    cn.Close();
                    MessageBox.Show("Category has been saved!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCategory.Clear();
                    txtCategory.Focus();
                    frmp.LoadCategory();
                }
                else
                {
                    MessageBox.Show("Saving Cancelled!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCategory.Clear();
                    txtCategory.Focus();
                }
                
                
            }
            catch(Exception ex)
            {
                txtCategory.Clear();
                txtCategory.Focus();
                MessageBox.Show(ex.Message);
                cn.Close();
            }
        }
    }
}
