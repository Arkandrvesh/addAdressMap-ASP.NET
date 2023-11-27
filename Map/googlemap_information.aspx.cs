using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class googlemap_information : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //You must specify Google Map API Key for this component. You can obtain this key from http://code.google.com/apis/maps/signup.html
            //For samples to run properly, set GoogleAPIKey in Web.Config file.
            GoogleMapForASPNet1.GoogleMapObject.APIKey = ConfigurationManager.AppSettings["GoogleAPIKey"];

            //Specify width and height for map. You can specify either in pixels or in percentage relative to it's container.
            GoogleMapForASPNet1.GoogleMapObject.Width = "800px"; // You can also specify percentage(e.g. 80%) here
            GoogleMapForASPNet1.GoogleMapObject.Height = "400px";

            //Specify initial Zoom level.
            GoogleMapForASPNet1.GoogleMapObject.ZoomLevel = 14;

            //Specify Center Point for map. Map will be centered on this point.
            GoogleMapForASPNet1.GoogleMapObject.CenterPoint = new GooglePoint("1", Convert.ToDouble(GridView1.Rows[0].Cells[1].Text), Convert.ToDouble(GridView1.Rows[0].Cells[2].Text));

            GoogleMapForASPNet1.GoogleMapObject.MapType = GoogleMapType.SATELLITE_MAP;


            markers();
        }
    }

    private void markers()
    {
        for (int i = 0; GridView1.Rows.Count > i; i++)

        {
            GooglePoint GP+i= new GooglePoint();
            GP + i.ID = GridView1.Rows[i].Cells[0].Text;
            GP + i.Latitude = Convert.ToDouble(GridView1.Rows[i].Cells[1].Text);
            GP + i.Longitude =Convert.ToDouble( GridView1.Rows[i].Cells[2].Text);
            GP + i.InfoHTML = GridView1.Rows[i].Cells[3].Text;
            GP + i.PointStatus = "sssssss";
            GoogleMapForASPNet1.GoogleMapObject.Points.Add(GP1);

            ///GP.IconImage = "icons/pushpin-blue.png";
        }
    }
}