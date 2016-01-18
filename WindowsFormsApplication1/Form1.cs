using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private static ServiceReference1.IDistrictService sv1 = new ServiceReference1.DistrictServiceClient();
        private static ServiceReference2.IService1 sv2 = new ServiceReference2.Service1Client();



        public Form1()
        {
            InitializeComponent();
            //loadgGridREST();
            //loadGridSOAP();
        }

        public void loadGridSOAP()
        {
            dataGridView1.ColumnCount = 3;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.Columns[0].HeaderCell.Value = "MovieId";
            dataGridView1.Columns[1].HeaderCell.Value = "Name";
            dataGridView1.Columns[2].HeaderCell.Value = "Genre";

            ServiceReference1.District[] returnList = sv1.getAllDistricts();

            foreach (ServiceReference1.District mov in returnList)
            {

                dataGridView1.Rows.Add(new object[] { mov.DistrictId, mov.PrimSalePersonId, mov.Name });
            }
        }
    }
}

      /*  public void loadgGridREST()
        {
            dataGridView2.ColumnCount = 3;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.Columns[0].HeaderCell.Value = "MovieId";
            dataGridView2.Columns[1].HeaderCell.Value = "Name";
            dataGridView2.Columns[2].HeaderCell.Value = "Genre";


            ServiceReference2.District[] returnList = sv2.getAllDistricts();

            foreach (ServiceReference2.District mov in returnList)
            {

                dataGridView2.Rows.Add(new object[] { mov.DistrictId });
            }
        }
    }
}
*/