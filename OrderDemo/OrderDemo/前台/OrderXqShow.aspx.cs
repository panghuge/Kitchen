using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrderDemo.前台
{
    public partial class OrderXqShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Show();
            }
        }
        private void Show()
        {
            int id = Convert.ToInt32(Session["id"]);
            TextBox1.Text = Session["User"].ToString();
            TextBox2.Text = Session["address"].ToString();
            TextBox3.Text = Session["phone"].ToString();
            Label1.Text = Convert.ToString(CartManager.Sum(Convert.ToInt32(Session["id"])));
            List<Cart> list = CartManager.GWC(id);
            int num = list.Count;
            this.Repeater1.DataSource = list;
            this.DataBind();
        }
    }
}