using doan3_codefirst1.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan3_codefirst1.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBQLB myDB = new DBQLB();
            //var result = from c in db.NHA_XUAT_BANs select new {MaNXB = c.MaNXB, sach = c.SACHes.Count};
            var result = from c in myDB.SACHes select new { c.MaSach, c.MaNXB, c.NHA_XUAT_BAN.TenNXB };
            //var result = from c in db.SACHes where c.MaNXB == "NXB1" select c;
            dataGridView1.DataSource = result.ToList();
            CreateDB s = new CreateDB();
        }
    }
}
