using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ledger_gst
{
    public partial class Item : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ledgerDB;User ID=sa;Password=12345;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
       
        public Item()
        {
            InitializeComponent();
        }

        #region [btnClass] 
        // 조회
        private void btnQ_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtCode.Text = string.Empty;
                //데이터베이스 연결 끝
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            DataRow drToAdd = dt.NewRow();
            dt.Rows.Add(drToAdd);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("D_LEDGER_ITEM", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@mode", "DELETE");
                cmd.Parameters.AddWithValue("@Num", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("DELETE Successfully");
                Reset();
                FillDataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(btnSave.Text == "저장")
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("SP_LEDGER_ITEM", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@mode", "Add");
                    cmd.Parameters.AddWithValue("@Num", 0);
                    cmd.Parameters.AddWithValue("@p_group_code", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@p_sub_code", dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    cmd.Parameters.AddWithValue("@p_sub_name", dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("INSERT Successfully");
                }
                else
                {
                    dataGridView1.ReadOnly = true;
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("SP_LEDGER_ITEM", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@mode", "UPDATE");
                    cmd.Parameters.AddWithValue("@Num", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@p_group_code", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@p_sub_code", txtSub.Text.Trim());
                    cmd.Parameters.AddWithValue("@p_sub_name", txtName.Text.Trim());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("UPDATE Successfully");
                }
                Reset();
                FillDataGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                this.dataGridView1.Update();
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

        }

        #endregion

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtCode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //txtNum.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSub.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //btnSave.Text = "수정";
            btnDelete.Enabled = true;
        }

        void FillDataGridView()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Q_LEDGER_ITEM", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@mode", "Q");
            da.SelectCommand.Parameters.AddWithValue("@contact_code", txtCode.Text.Trim());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            con.Close();
        }
        void Reset()
        {
            txtCode.Text = txtName.Text = txtSub.Text = string.Empty;
            btnSave.Text = "저장";
            btnDelete.Enabled = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
