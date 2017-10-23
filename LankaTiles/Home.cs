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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addTIN.Visible = true;
            viewTin.Visible = true;

            addTon.Visible = false;
            viewTon.Visible = false;
            updateTon.Visible = false;
            removeTon.Visible = false;

            addGin.Visible = false;
            removeGin.Visible = false;
            viewGin.Visible = false;

            viewGrn.Visible = false;
            addGrn.Visible = false;

            report1.Visible = false;
            report2.Visible = false;
            report3.Visible = false;
            report4.Visible = false;

            stockBal.Visible = false;
            uncollect.Visible = false;

            addInvoice.Visible = false;
            viewInvoice.Visible = false;
            removeInvoce.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addTIN.Visible = false;
            viewTin.Visible = false;

            addTon.Visible = true;
            viewTon.Visible = true;
            updateTon.Visible = true;
            removeTon.Visible = true;

            addGin.Visible = false;
            removeGin.Visible = false;
            viewGin.Visible = false;

            viewGrn.Visible = false;
            addGrn.Visible = false;

            report1.Visible = false;
            report2.Visible = false;
            report3.Visible = false;
            report4.Visible = false;

            stockBal.Visible = false;
            uncollect.Visible = false;

            addInvoice.Visible = false;
            viewInvoice.Visible = false;
            removeInvoce.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addTIN.Visible = false;
            viewTin.Visible = false;

            addTon.Visible = false;
            viewTon.Visible = false;
            updateTon.Visible = false;
            removeTon.Visible = false;

            addGin.Visible = true;
            removeGin.Visible = true;
            viewGin.Visible = true;

            viewGrn.Visible = false;
            addGrn.Visible = false;

            report1.Visible = false;
            report2.Visible = false;
            report3.Visible = false;
            report4.Visible = false;

            stockBal.Visible = false;
            uncollect.Visible = false;

            addInvoice.Visible = false;
            viewInvoice.Visible = false;
            removeInvoce.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addTIN.Visible = false;
            viewTin.Visible = false;

            addTon.Visible = false;
            viewTon.Visible = false;
            updateTon.Visible = false;
            removeTon.Visible = false;

            addGin.Visible = false;
            removeGin.Visible = false;
            viewGin.Visible = false;

            viewGrn.Visible = true;
            addGrn.Visible = true;

            report1.Visible = false;
            report2.Visible = false;
            report3.Visible = false;
            report4.Visible = false;

            stockBal.Visible = false;
            uncollect.Visible = false;

            addInvoice.Visible = false;
            viewInvoice.Visible = false;
            removeInvoce.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addTIN.Visible = false;
            viewTin.Visible = false;

            addTon.Visible = false;
            viewTon.Visible = false;
            updateTon.Visible = false;
            removeTon.Visible = false;

            addGin.Visible = false;
            removeGin.Visible = false;
            viewGin.Visible = false;

            viewGrn.Visible = false;
            addGrn.Visible = false;

            report1.Visible = true;
            report2.Visible = true;
            report3.Visible = true;
            report4.Visible = true;

            stockBal.Visible = false;
            uncollect.Visible = false;

            addInvoice.Visible = false;
            viewInvoice.Visible = false;
            removeInvoce.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addTIN.Visible = false;
            viewTin.Visible = false;

            addTon.Visible = false;
            viewTon.Visible = false;
            updateTon.Visible = false;
            removeTon.Visible = false;

            addGin.Visible = false;
            removeGin.Visible = false;
            viewGin.Visible = false;

            viewGrn.Visible = false;
            addGrn.Visible = false;

            report1.Visible = false;
            report2.Visible = false;
            report3.Visible = false;
            report4.Visible = false;

            stockBal.Visible = true;
            uncollect.Visible = true;

            addInvoice.Visible = false;
            viewInvoice.Visible = false;
            removeInvoce.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addTIN.Visible = false;
            viewTin.Visible = false;

            addTon.Visible = false;
            viewTon.Visible = false;
            updateTon.Visible = false;
            removeTon.Visible = false;

            addGin.Visible = false;
            removeGin.Visible = false;
            viewGin.Visible = false;

            viewGrn.Visible = false;
            addGrn.Visible = false;

            report1.Visible = false;
            report2.Visible = false;
            report3.Visible = false;
            report4.Visible = false;

            stockBal.Visible = false;
            uncollect.Visible = false;

            addInvoice.Visible = true;
            viewInvoice.Visible = true;
            removeInvoce.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
