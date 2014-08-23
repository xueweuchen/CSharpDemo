using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;

namespace RSSReader
{
    class RSSFeed
    {
        public string title;
        public string description;
        public string link;
        public List<RSSItem> rssFeadList { get; set; }

        public RSSFeed()
        {
            rssFeadList = new List<RSSItem>();
        }

        public RSSFeed(string url)
        {
            rssFeadList = new List<RSSItem>();
            link = url;
        }

        public void parseLink()
        {
            rssFeadList = new List<RSSItem>();
            XmlReader reader = XmlReader.Create(link);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            title = feed.Title.Text;
            description = feed.Description.Text;
            foreach (SyndicationItem item in feed.Items)
            {
                RSSItem rssItem = new RSSItem();
                rssItem.title = item.Title.Text;
                rssItem.description = item.Summary.Text;
                rssItem.link = item.Id;
                rssFeadList.Add(rssItem);
            }
        }

        public override string ToString()
        {
            return this.title;
        }
    }

    class RSSItem
    {
        public string title { get; set; }
        public string description { get; set; }
        public string link { get; set; }
        public RSSItem()
        {

        }

        public override string ToString()
        {
            return this.title;
        }
    }
}