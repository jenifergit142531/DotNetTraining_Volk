using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SQLCacheProject
{
    public partial class CustomerForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime timestart = DateTime.Now;
            if (!IsPostBack)
            {
                Reload();
                DateTime timeloaded = DateTime.Now;
                TimeSpan timeelapsed = timeloaded.Subtract(timestart);
                Label5.Text = "database";
                Label4.Text = GridView1.Rows.Count.ToString();
                Label6.Text = timeelapsed.TotalMilliseconds.ToString() + "milliseconds" +
                    "(" + timeelapsed.Seconds.ToString() + "  sec)";

            }
        }

        public void CacheItemRemovedCallback(string key, object value, CacheItemRemovedReason reason)
        {
            string CS = ConfigurationManager.ConnectionStrings["StoreConnnectionString"].ConnectionString;
            lock (this)
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("sp_getcustomers", con);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    CacheItemRemovedCallback onCacheItem = new CacheItemRemovedCallback(CacheItemRemovedCallback);

                    SqlCacheDependency sqlDependency = new SqlCacheDependency("store", "customers");
                    Cache.Insert("customerdata", ds, sqlDependency, DateTime.Now.AddHours(24), Cache.NoSlidingExpiration,
                        CacheItemPriority.Default, onCacheItem);
                    return;
                }
            }
        }

        private void Reload()
        {
            string CS = ConfigurationManager.ConnectionStrings["StoreConnnectionString"].ConnectionString;
            lock (this)
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("sp_getcustomers", con);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    sda.Fill(ds);

                    CacheItemRemovedCallback onCacheItem = new CacheItemRemovedCallback(CacheItemRemovedCallback);

                    SqlCacheDependency sqlDependency = new SqlCacheDependency("store", "customers");
                    Cache.Insert("customerdata", ds, sqlDependency, DateTime.Now.AddHours(24), Cache.NoSlidingExpiration,
                        CacheItemPriority.Default, onCacheItem);

                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime timestart = DateTime.Now;
            if (Cache["customerdata"] != null)
            {
                GridView1.DataSource = (DataSet)Cache["customerdata"];
                GridView1.DataBind();

                DateTime timeloaded = DateTime.Now;
                TimeSpan timeelapsed = timeloaded.Subtract(timestart);
                Label5.Text = "cache";
                Label4.Text = GridView1.Rows.Count.ToString();
                Label6.Text = timeelapsed.TotalMilliseconds.ToString() + "milliseconds" +
                    "(" + timeelapsed.Seconds.ToString() + "  sec)";

            }
            else
            {
                Reload();
                DateTime timeloaded = DateTime.Now;
                TimeSpan timeelapsed = timeloaded.Subtract(timestart);
                Label5.Text = "database";
                Label4.Text = GridView1.Rows.Count.ToString();
                Label6.Text = timeelapsed.TotalMilliseconds.ToString() + "milliseconds" +
                    "(" + timeelapsed.Seconds.ToString() + "  sec)";
            }
        }
    }
}