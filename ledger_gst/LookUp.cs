using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ledger_gst
{
    public partial class LookUp : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ledgerDB;User ID=sa;Password=12345;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        // dateEdit에 현재 날짜, 현재 날짜 - 한달 전 불러오는 방법

        public LookUp()
        {
            InitializeComponent();
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                textEdit1.Text = string.Empty;
                //데이터베이스 연결 끝
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        // 수입 -> 최종 금액에서 플러스
        // 지출 -> 최종 금액에서 마이너스 
        // 하는 방법 LEFT OUTER  JOIN 쓰면 될 것 같은데 쿼리를 어떻게 짜야 할지 모르겠음 or 
        // 수입 테이블 지출 테이블 따로 만들어야 하나?

        void FillDataGridView()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Q_LEDGER_LOOKUP", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@p_dates", dateEdit1.DateTime);
            da.SelectCommand.Parameters.AddWithValue("@p_datee", dateEdit2.DateTime);
            da.SelectCommand.Parameters.AddWithValue("@p_context", textEdit1.Text.Trim());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            //dataGridView1.Columns[0].Visible = false;
            con.Close();
        }

     

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("D_LEDGER_REGISTER", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_Num", dataGridView1.CurrentRow.Cells[0].Value.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("DELETE Successfully");
                FillDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
