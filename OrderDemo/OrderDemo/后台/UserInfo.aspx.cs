using BLL;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrderDemo.后台
{
    public partial class UserInfo : System.Web.UI.Page
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
            this.GridView1.DataSource = UserManager.Info();
            this.GridView1.DataBind();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int ID = int.Parse(this.GridView1.Rows[e.RowIndex].Cells[0].Text);
            if (UserManager.Delete(ID))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('删除成功!')</script>");
                Show();//刷新当前页面
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('删除失败!')</script>");
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            Show();
        }
        //删除
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            GridView1.Visible = true;
            //获取行数
            ImageButton imageButton = sender as ImageButton;
            GridViewRow row = imageButton.NamingContainer as GridViewRow;
            int id = int.Parse(this.GridView1.Rows[row.RowIndex].Cells[0].Text);
            if (UserManager.Delete(id))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('删除成功!')</script>");
                Show();//刷新当前页面
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('删除失败!')</script>");
            }
        }
        //信息详情
        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            GridView1.Visible = true;
            //获取行数
            ImageButton imageButton = sender as ImageButton;
            GridViewRow row = imageButton.NamingContainer as GridViewRow;
            int id = int.Parse(this.GridView1.Rows[row.RowIndex].Cells[0].Text);
            Response.Redirect("UserShow.aspx?id=" + id);
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {

        }
        //模糊查询
        protected void Button1_Click(object sender, EventArgs e)
        {
            UserInfos f = new UserInfos();
            f.UserTypeID = int.Parse(DropDownList1.SelectedValue.ToString());
            List<UserInfos> list = UserManager.Search(f);
            foreach (UserInfos item in list)
            {

            }
            this.GridView1.DataSource = UserManager.Search(f);
            this.GridView1.DataBind();
        }
    }
}