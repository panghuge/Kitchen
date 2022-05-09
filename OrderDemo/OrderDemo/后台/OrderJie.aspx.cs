using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace OrderDemo.后台
{
    public partial class OrderJie : System.Web.UI.Page
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
            this.GridView1.DataSource = OrderManager.Select3();
            this.GridView1.DataBind();
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            Show();
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton imageButton = sender as ImageButton;
            GridViewRow row = imageButton.NamingContainer as GridViewRow;
            int id = int.Parse(this.GridView1.Rows[row.RowIndex].Cells[0].Text);
            if (OrderManager.Update4(id))
            {
                Response.Write("<script>alert('派送成功！')</script>");
                Show();
            }
            else
            {
                Response.Write("<script>alert('派送失败！')</script>");
            }
        }
    }
}