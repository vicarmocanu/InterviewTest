using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using InterviewModel.Model;

namespace WPFInterviewUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static DistrictSrv.IDistrictService districtSrv = new DistrictSrv.DistrictServiceClient();
        List<DistrictSrv.District> districtList = new List<DistrictSrv.District>();
        private static ServiceReference1.IService1 srvTest = new ServiceReference1.Service1Client();

        public MainWindow()
        {
            InitializeComponent();
           // loadGrid();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Form1 sh = new Form1();
            sh.Show();
        }

    }
}
