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
using Updater.gRPCService.Impl;

namespace UpdateTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async Task<string> GetResponse(string url)
        {
            UpdateService service = new UpdateService();
            var result = await service.GetStringAsync(url);
            return result;
        }

        private async void BtnRequest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.txtContent.Text = await GetResponse(txtUrl.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
