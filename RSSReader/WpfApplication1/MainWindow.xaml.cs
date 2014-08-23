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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace RSSReader
{
    /// <summary>
    /// MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            initialRssFeeds();
        }

        private void initialRssFeeds()
        {
            RSSFeedDAO rssFeedDAO = new RSSFeedDAO();
            try
            {
                foreach (RSSFeed item in rssFeedDAO.getRSSFeeds())
                {
                    item.parseLink();
                    rssFeadTree.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DataBase Connection Error");
            }
        }

        private void addClick(object sender, RoutedEventArgs e)
        {
            AddDlg addDlg = new AddDlg();
            addDlg.Owner = this;
            addDlg.ShowDialog();
            if (addDlg.DialogResult == true)
            {
                RSSFeed rssFeedAdd;
                try
                {
                    rssFeedAdd = new RSSFeed(addDlg.rssAddr);
                    rssFeedAdd.parseLink();
                    rssFeadTree.Items.Add(rssFeedAdd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "RSS Parsing Error");
                    return;
                }

                try
                {
                    RSSFeedDAO rssFeedDAO = new RSSFeedDAO();
                    rssFeedDAO.insertRSSFeed(rssFeedAdd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "DataBase Connection Error");
                }
            }
        }

        private void rssFeadSelected(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            RSSFeed feed = (RSSFeed) rssFeadTree.SelectedItem;
            if (feed == null)
                rssItemList.ItemsSource = null;
            else
                rssItemList.ItemsSource = feed.rssFeadList;
        }

        private void deleteClick(object sender, RoutedEventArgs e)
        {
            try
            {
                RSSFeedDAO rssFeedDAO = new RSSFeedDAO();
                rssFeedDAO.deleteRSSFeed((RSSFeed) rssFeadTree.SelectedItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DataBase Connection Error");
                return;
            }
            rssFeadTree.Items.Remove(rssFeadTree.SelectedItem);
        }

        private void refreshClick(object sender, RoutedEventArgs e)
        {
            foreach (RSSFeed rssFeed in rssFeadTree.Items)
            {
                rssFeed.parseLink();
            }
            RSSFeed feed = (RSSFeed)rssFeadTree.SelectedItem;
            if (feed == null)
                rssItemList.ItemsSource = null;
            else
                rssItemList.ItemsSource = feed.rssFeadList;
        }

        private void flyoutClick(object sender, RoutedEventArgs e)
        {
            var flyout = this.Flyouts.Items[0] as Flyout;
            if (flyout == null)
            {
                return;
            }
            
            flyout.IsOpen = !flyout.IsOpen;
        }
    }
}
