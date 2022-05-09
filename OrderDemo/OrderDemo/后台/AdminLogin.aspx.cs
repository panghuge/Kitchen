using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

namespace OrderDemo.后台
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

            //if (UserManager.CheckUserLogin(txtUser.Text, TextBox2.Text))
            //{
            //    Session["name"] = txtUser.Text;
            //    Session["yzm"] = c1;
            //    Response.Write("<script>alert('"+c1+"')<script>");
            //    Response.Write("<script>alert('登录成功！')<script>");
            //    Response.Redirect("UserPwdUpdate.aspx");
            //}
            //else
            //{
            //    Response.Write("<script>alert('登录失败！请检查')<script>");

            //}
            string usernane = this.txtUser.Text;
            string pwd = this.TextBox2.Text;
            if (txtUser.Text != "" && TextBox2.Text != "")
            {
                if (UserManager.CheckUserLogin(usernane, pwd))
                {
                    Session["name"] = txtUser.Text;
                    Response.Write("<script>alert('登录成功！')<script>");
                    Response.Redirect("UserPwdUpdate.aspx");
                }
                else
                {
                    Session["yzm"] = c1.ToString();
                    Response.Write("<script>alert('"+ Session["yzm"] + "')<script>");
                    Response.Write("<script>alert('用户名或者密码错误!')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('用户名或者密码不能为空!')</script>");
            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}