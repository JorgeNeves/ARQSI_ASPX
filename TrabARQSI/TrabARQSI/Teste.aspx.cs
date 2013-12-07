using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabARQSI
{
    public partial class Teste : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LogisticaSA.ServiceLogisticaSAClient proxy = new LogisticaSA.ServiceLogisticaSAClient();
            Label1.Text = ""+proxy.custo(int.Parse(TextBox1.Text));


            ShippingAll.servicenamePortTypeClient proxy1 = new ShippingAll.servicenamePortTypeClient();
            Label2.Text = "" + proxy1.custo(int.Parse(TextBox1.Text));
        }
    }
}