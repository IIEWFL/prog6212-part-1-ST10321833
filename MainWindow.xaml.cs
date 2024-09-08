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

namespace CMCS

{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            SubmitClaimWindow submitClaimWindow = new SubmitClaimWindow();
            submitClaimWindow.Show();
        }

        private void UploadDocuments_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Document Upload interface will open here.");
        }

        private void ApproveClaims_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim Approval interface for Managers will open here.");
        }

        private void TrackStatus_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim Status Tracking page will open here.");
        }

    }

}
