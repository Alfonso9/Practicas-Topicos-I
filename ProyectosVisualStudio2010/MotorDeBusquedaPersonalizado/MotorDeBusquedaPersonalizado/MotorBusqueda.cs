using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;
using System.Collections;

namespace MotorDeBusquedaPersonalizado
{
    class MotorBusqueda
    {
        WebClient wcGetQuery = new WebClient();

        public MotorBusqueda() 
        {            
        }

        public void getQuery(String uri, ListView lv) 
        {
            String sSearch = "https://www.googleapis.com/customsearch/v1?key=AIzaSyDYojLmU-21oDbhw7O4AkA-IS4l7CiZNvE&cx=004708402497314794835:ybl5ime8gve&q=" + uri;
            String queryResultToJSON = wcGetQuery.DownloadString(sSearch);
            Dictionary<String, Object> queryResultToObject = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<Dictionary<String, Object>>(queryResultToJSON);            
            ArrayList ldItems = new ArrayList();            
            Object values;
            if (queryResultToObject.ContainsKey("items"))
            {
                queryResultToObject.TryGetValue("items", out values);
                ldItems = (ArrayList)values;

                foreach (Dictionary<String, Object> d in ldItems)
                {
                    Object valuestitle, valueslink;
                    d.TryGetValue("title", out valuestitle);
                    d.TryGetValue("link", out valueslink);
                    ListViewItem item1 = new ListViewItem(valuestitle.ToString());
                    item1.SubItems.Add(valueslink.ToString());
                    //Add the items to the ListView.
                    lv.Items.AddRange(new ListViewItem[] { item1 });                            
                }
            }
            
            
        }
    }
}
