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
    public partial class OrderXq : System.Web.UI.Page
    {
        public int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Session["id"]);
            if (!IsPostBack)
            {
                Show(id);
            }
        }
        private void Show(int id)
        {
            Repeater1.DataSource = OrderManager.Select1(id);
            Repeater1.DataBind();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            int d = 0;
            switch (DropDownList1.Text)
            {
                case "未付款":
                    d = 1;
                    break;
                case "已付款":
                    d = 2;
                    break;
                case "已接单":
                    d = 3;
                    break;
                case "派送中":
                    d = 4;
                    break;
                case "已完成":
                    d = 5;
                    break;
            }
            Order o = new Order();
            o.OrderState = d;
            o.Userid = id;
            this.Repeater1.DataSource = OrderManager.Orders(o);
            this.Repeater1.DataBind();
        }
        protected void Repeater1_ItemCreated(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                //判断Button是否存在
                if (e.Item.FindControl("ImageButton2") != null)
                {
                    //如果存在，把对象转换为Button。
                    ImageButton imageButton = (ImageButton)e.Item.FindControl("ImageButton2");
                }
            }
        }

        protected void images_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            //判断HiddenField是否存在
            if (button.NamingContainer.FindControl("HiddenField1") != null)
            {
                //存在，把对象转换为HiddenField控件
                HiddenField hf = (HiddenField)button.NamingContainer.FindControl("HiddenField1");
                //取出HiddenField的Value值。
                int ids = Convert.ToInt32(hf.Value);
                bool runt = OrderManager.Delete(ids);
                if (runt)
                {
                    Response.Write("<script>alert('取消成功')</script>");
                }
                else
                {
                    Response.Write("<script>alert('取消失败，请检查')</script>");
                }
                Show(id);
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton button = (ImageButton)sender;
            //判断HiddenField是否存在
            if (button.NamingContainer.FindControl("HiddenField1") != null)
            {
                //存在，把对象转换为HiddenField控件
                HiddenField hf = (HiddenField)button.NamingContainer.FindControl("HiddenField1");
                //取出HiddenField的Value值。
                int ids = Convert.ToInt32(hf.Value);
                Response.Redirect("OrderXqShow.aspx?id=" + ids);
            }
        }
    }
}