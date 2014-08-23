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
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace RSSReader
{
    /// <summary>
    /// AddDlg.xaml 的交互逻辑
    /// </summary>
    public partial class AddDlg : MetroWindow
    {
        public string rssAddr;

        public AddDlg()
        {
            InitializeComponent();
        }

        private void ok_click(object sender, RoutedEventArgs e)
        {
            rssAddr = rssURL.Text;
            this.DialogResult = true;
        }

        private void cancel_click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}