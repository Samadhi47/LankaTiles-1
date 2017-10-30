using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LankaTiles
{
    public partial class ManageGIN : Form
    {
        DataTable dt, dt1;
        public ManageGIN()
        {
            InitializeComponent();
        }

        private void ManageGIN_Load(object sender, EventArgs e)
        {
            GoodIssueNote gin = new GoodIssueNote();
            dt = new DataTable();
            dt = gin.getGIN();
            dataGridGIN.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var gin = new GoodIssueNote();
            dt = new DataTable();
            dt = gin.searchGIN(txtName.Text);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No data found!");
            }
            else
            {
                dataGridGIN.DataSource = dt;
            }
        }

        private void dataGridGIN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var gin = new GoodIssueNote();
            int selectedGinId = Convert.ToInt32(dataGridGIN.CurrentRow.Cells[0].Value);
            dt1 = new DataTable();
            dt1 = gin.viewReleventGin(selectedGinId);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No GIN Found!");
            }
            else
            {
                dataGridCusName.DataSource = dt1;
            }
        }
    }
}
