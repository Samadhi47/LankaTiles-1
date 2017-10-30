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
    public partial class RemoveGIN : Form
    {
        public DataTable dt;        
        public RemoveGIN()
        {
            InitializeComponent();
        }

        private void RemoveGIN_Load(object sender, EventArgs e)
        {
            var gin = new GoodIssueNote();
            dt = new DataTable();
            dt = gin.getGIN();
            if (dt.Rows.Count==0)
            {
                MessageBox.Show("There are no Good Issue Notes Currently!");
                this.Close();                         
            }
            else
            {
                GINview.DataSource = dt;
            }
            
        }

        private void btnRemoveGIN_Click(object sender, EventArgs e)
        {
            var gin = new GoodIssueNote();
            int selectedGinId = Convert.ToInt32(GINview.CurrentRow.Cells[0].Value);            
            DialogResult dr = MessageBox.Show("Are You Sure?", "Warning!", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                gin.removeGIN(selectedGinId);
                MessageBox.Show("GIN deleted");
                dt = new DataTable();
                dt = gin.getGIN();
                GINview.DataSource = dt;
            }
            txtName.Clear();
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
                GINview.DataSource = dt;
            }

        }
    }
}
