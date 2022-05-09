using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace OrderDemo.前台
{
    public partial class OrderOK : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Session["id"]);
                Label1.Text = Session["price"].ToString();
            }         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(Session["id"]);
            if (CartManager.UpdateOrder(userid))
            {
                if (CartManager.deleteOrder(userid))
                {
                 
                    Response.Redirect("Index.aspx");
                    Label1.Text = "0";
                }
               
            }
            else
            {
                Response.Write("<script>alert('支付失败！');</script>");
                
            }
        }
    

       
    }
}