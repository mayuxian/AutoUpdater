using System;
using System.Collections.Generic;
using System.IO;
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
using Path = System.IO.Path;
using AutoUpdater.Modules;
using Ma.ConfigManager;
using Ma.Bootstrapper;
using AutoUpdater;

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

            //Bootstrapper.Load();
        }

        private async Task<string> GetResponse(string url)
        {
            GrpcService service = new GrpcService();
            var result = await service.GetStringAsync(url);
            return result;
        }

        private async Task<Stream> GetStreamResponse(string url, string content)
        {
            GrpcService service = new GrpcService();
            var result = await service.GetStreamAsync(url, content);
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
            }
        }

        private async void BtnDownload_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var filePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, txtDownloadFilePath.Text.Trim()));
                File.Delete(filePath);

                var stream = await this.GetStreamResponse(txtUrl.Text.Trim(), txtDownloadFilePath.Text.Trim());
                using (stream)
                {
                    using (var reader = new StreamReader(stream))
                    {
                        File.AppendAllText(filePath, reader.ReadToEnd());
                    }
                }
                tbDownloadInfo.Text = "下载成功";
            }
            catch (Exception ex)
            {
                tbDownloadInfo.Text = "下载失败";
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGetConfig_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ConfigManager.Load();
                txtConfigValue.Text = ConfigManager.GetConfig(txtConfigKey.Text.Trim());
            }
            catch (Exception ex)
            {
                txtConfigValue.Text = ex.Message;
                //throw;
            }
        }

        private void BtnCheckUpdate_Click(object sender, RoutedEventArgs e)
        {
            ConfigManager.Load();
            AutoUpdater.AutoUpdater autoUpdater = new AutoUpdater.AutoUpdater();
            autoUpdater.Start();
        }
    }
}
