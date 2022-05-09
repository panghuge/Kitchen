using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrderDemo.后台
{
    public partial class OrderTrue : System.Web.UI.Page
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
            this.GridView1.DataSource = OrderManager.Select();
            this.GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            Show();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            GridView1.Visible = true;
            //获取行数
            ImageButton imageButton = sender as ImageButton;
            GridViewRow row = imageButton.NamingContainer as GridViewRow;
            int id = int.Parse(this.GridView1.Rows[row.RowIndex].Cells[0].Text);
            Response.Redirect("OrderTrueShow.aspx?id=" + id);
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            //获取行数
            ImageButton imageButton = sender as ImageButton;
            GridViewRow row = imageButton.NamingContainer as GridViewRow;
            int id = int.Parse(this.GridView1.Rows[row.RowIndex].Cells[0].Text);
            if (OrderManager.Update3(id))
            {
                Response.Write("<script>alert('接单成功！')</script>");
                Show();
            }
            else
            {
                Response.Write("<script>alert('接单失败！')</script>");
            }
        }
    }
}