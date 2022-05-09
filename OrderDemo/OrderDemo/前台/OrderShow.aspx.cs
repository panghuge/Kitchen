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
    public partial class OrderShow : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            

            string name = TextBox1.Text;
            string address = TextBox2.Text;
            string phone = TextBox3.Text;
            double price =double.Parse(Label1.Text);
            int id = Convert.ToInt32(Session["id"]);
            int orderstate = 1;
            DateTime date = DateTime.Now.ToLocalTime();
            if (CartManager.innerOrder(id,name,address,phone,price,date,orderstate))
            {
            Session["price"] = Label1.Text;
            Response.Redirect("OrderOK.aspx?=id" + id);
            }
            else
            {

            }
        }
    }
}