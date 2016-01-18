using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFInterviewUI
{
    public partial class Form1 : Form
    {
        private static ServiceReference1.IService1 srvTest = new ServiceReference1.Service1Client();
        public Form1()
        {
            InitializeComponent();
        }
        public void loadGrid()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.Columns[0].HeaderCell.Value = "id";
            dataGridView1.Columns[1].HeaderCell.Value = "primId";
            dataGridView1.Columns[2].HeaderCell.Value = "Name";
       
            ServiceReference1.District[] returnList = srvTest.getAllDistricts();

            foreach (ServiceReference1.District cust in returnList)
            {
                dataGridView1.Rows.Add(new object[] {cust.DistrictId });
            }
        }
    }    
}
