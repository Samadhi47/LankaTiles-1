using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LankaTiles
{
    class GoodIssueNote
    {
        public DataTable dt;
        public Database db;
        private string GINID;
        private string customer;
        private string itemType;
        private int qty;
        private int date;

        public void addGIN(string query1)
        {
          
        }
        public void verifyGIN() { }

        public void removeGIN(int GINid)
        {
            string query = "delete from GIN where GINID = " + GINid + "";
            string dropTable = "drop table GIN" + GINid + " ";
            db = new Database();  
            db.inserUpdateDelete(query);
            db.inserUpdateDelete(dropTable);
        }

        public DataTable searchGIN(string search)
        {
            string query = "select * from GIN where name LIKE '%" + search + "%'";
            db = new Database();
            dt = db.select(query);    
            return dt;            
        }

        public DataTable getGIN()
        {
            string query = "select * from GIN";
            db = new Database();
            dt = db.select(query);
            return dt;
        }
    }
}
