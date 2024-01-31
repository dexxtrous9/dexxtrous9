using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace possystem
{
    public partial class frmTable : Form
    {
        MySqlConnection cn = new MySqlConnection("server=localhost;database=posresto;uid=root;password=;");
        string table;
        public frmTable()
        {
            InitializeComponent();
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTable.Text))
                {
                    MessageBox.Show("Please input Table!", "CRITICAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Save this Table?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    using (MySqlCommand scm = new MySqlCommand("INSERT INTO posresto.tbltable(tableno) VALUES(@tableno)", cn))
                    {
                        scm.Parameters.AddWithValue("@tableno", txtTable.Text);
                        scm.ExecuteNonQuery();
                    }
                    cn.Close();
                    MessageBox.Show("Table has been Saved!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    LoadTable();
                    btnCancel_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Saving Cancelled!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancel_Click(sender, e);
                }
            }catch (Exception ex)
            {
                txtTable.Clear();
                txtTable.Focus();
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void setButtons()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
        public void LoadTable()
        {
            try
            {
                int i = 0;
                dgvTable.Rows.Clear();
                cn.Open();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * from tbltable", cn))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            i += 1;
                            dgvTable.Rows.Add(i, dr["tableno"].ToString());
                        }
                        dr.Close();
                        cn.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string coln = dgvTable.Columns[e.ColumnIndex].Name;
            if (coln == "colEdit")
            {
                table = dgvTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTable.Text = table;
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
            }
            else if (coln == "colDelete")
            {
                if (MessageBox.Show("Delete this Table?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM tbltable WHERE tableno like'" + dgvTable.Rows[e.RowIndex].Cells[1].Value + "'", cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Table has been Deleted!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTable();
                }
                else
                {
                    MessageBox.Show("Deletion Cancelled!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            table = "";
            btnSave.Enabled = true;
            btnUpdate.Enabled=false;
            txtTable.Clear();
            txtTable.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTable.Text))
                {
                    MessageBox.Show("Please input Table!", "Critical", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Update this Table?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    using (MySqlCommand cm = new MySqlCommand("UPDATE posresto.tbltable SET tableno=@tableno WHERE tableno LIKE @table", cn))
                    {
                        cm.Parameters.AddWithValue("@tableno", txtTable.Text);
                        cm.Parameters.AddWithValue("@table", table);
                        cm.ExecuteNonQuery();
                    }
                    cn.Close();
                    MessageBox.Show("Table has been Updated!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTable();
                    btnCancel_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Updating Cancelled!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancel_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                txtTable.Clear();
                txtTable.Focus();
                cn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
