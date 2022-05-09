using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrderDemo.后台
{
    public partial class OrderTrueShow : System.Web.UI.Page
    {
        public int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                id = Convert.ToInt32(Request.QueryString["id"]);
                List<Order> list = OrderManager.OrderSelet4(id);
                foreach (Order item in list)
                {
                    Label1.Text = item.RealName;
                    Label2.Text = item.phone;
                    Label3.Text = item.Address;
                    Label4.Text = item.Totle.ToString();
                }
                show();
            }
        }
        public void show() {
            OrderDetail o = new OrderDetail();
            o.OrderID = id;
            this.Repeater1.DataSource =OrderManager.OrderDetailSelet(o);
            this.DataBind();
        }
    }
}