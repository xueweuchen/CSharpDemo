using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Xml.Serialization;

namespace RSSReader
{
    class RSSFeedDAO
    {
        string strAccessConn;
        OleDbConnection myAccessConn;
        public RSSFeedDAO()
        {
            strAccessConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\rssFeeds.MDB";
            myAccessConn = null;
        }

        public void openConn()
        {
            myAccessConn = new OleDbConnection(strAccessConn);
            myAccessConn.Open();
        }

        public void closeConn()
        {
            myAccessConn.Close();
        }

        public List<RSSFeed> getRSSFeeds()
        {
            this.openConn();

            string strAccessSelect = "SELECT * FROM rssFeeds";

            DataSet myDataSet = new DataSet();
            OleDbCommand myAccessCommand = new OleDbCommand(strAccessSelect, myAccessConn);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(myAccessCommand);

            myDataAdapter.Fill(myDataSet, "rssFeeds");
            this.closeConn();

            DataTable dt = myDataSet.Tables["rssFeeds"];
            List<RSSFeed> rssFeedList = new List<RSSFeed>();
            foreach (DataRow dr in dt.Rows)
            {
                RSSFeed item = new RSSFeed();
                item.title = (string)dr[1];
                item.description = (string)dr[2];
                item.link = (string)dr[3];
                rssFeedList.Add(item);
            }
            return rssFeedList;
        }
        
        public void insertRSSFeed( RSSFeed feed )
        {
            this.openConn();

            string strAccessInsert = "INSERT INTO rssFeeds (title, description, link) VALUES ('" +
                feed.title + "', '" + 
                feed.description + "', '" + 
                feed.link + "')";

            OleDbCommand myAccessCommand = new OleDbCommand(strAccessInsert, myAccessConn);
            myAccessCommand.ExecuteNonQuery();

            this.closeConn();
        }

        public void deleteRSSFeed( RSSFeed feed )
        {
            this.openConn();

            string strAccessDelete = "DELETE FROM rssFeeds WHERE link='" +
                feed.link + "'";

            OleDbCommand myAccessCommand = new OleDbCommand(strAccessDelete, myAccessConn);
            myAccessCommand.ExecuteNonQuery();

            this.closeConn();
        }

    }
}
