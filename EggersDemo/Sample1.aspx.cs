using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Drawing.Imaging;


namespace EggersDemo
{
    public partial class Sample1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // We generate a new bitmap and // draw an ellipse on it
            Bitmap oCanvas = new Bitmap(200, 150);
            Graphics g = Graphics.FromImage(oCanvas);
            g.Clear(Color.White);
            g.DrawEllipse(Pens.Red, 10, 10, 150, 100);

            // Now, we only need to send it // to the client
            Response.ContentType = "image/jpeg";
            oCanvas.Save(Response.OutputStream, ImageFormat.Jpeg);
            Response.End();

            // Cleanup
            g.Dispose();
            oCanvas.Dispose();
        }
    }
}