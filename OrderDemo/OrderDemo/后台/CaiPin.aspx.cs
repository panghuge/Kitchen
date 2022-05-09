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
    public partial class CaiPin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Show();
            }
        }
        //显示数据
        private void Show()
        {
            this.GridView1.DataSource = FoodManager.Info();
            this.GridView1.DataBind();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            Show();
        }
        //模糊查询
        protected void Button1_Click(object sender, EventArgs e)
        {
            Food f = new Food();
            f.FoodTypeID = int.Parse(DropDownList1.Text);
            List<Food> list = FoodManager.Search(f);
            foreach (Food item in list)
            {

            }
            this.GridView1.DataSource = FoodManager.Search(f);
            this.GridView1.DataBind();
        }
        //删除
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            GridView1.Visible = true;
            //获取行数
            ImageButton imageButton = sender as ImageButton;
            imageButton.ToolTip = "删除";
            GridViewRow row = imageButton.NamingContainer as GridViewRow;
            int id =int.Parse( this.GridView1.Rows[row.RowIndex].Cells[0].Text);
            if (FoodManager.Delete(id))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('删除成功!')</script>");
                Show();//刷新当前页面
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('删除失败!')</script>");
            }
        }
        //查看详情
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            GridView1.Visible = true;
            //获取行数
            ImageButton imageButton = sender as ImageButton;
            GridViewRow row = imageButton.NamingContainer as GridViewRow;
            int id = int.Parse(this.GridView1.Rows[row.RowIndex].Cells[0].Text);
            Response.Redirect("FoodShow.aspx?id=" + id);
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            GridView1.Visible = true;
            //获取行数
            ImageButton imageButton = sender as ImageButton;
            GridViewRow row = imageButton.NamingContainer as GridViewRow;
            int id = int.Parse(this.GridView1.Rows[row.RowIndex].Cells[0].Text);
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //获取编辑行
            this.GridView1.EditIndex = e.NewEditIndex;
            Show();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            this.GridView1.EditIndex = -1;
            Show();
        }
    }
}