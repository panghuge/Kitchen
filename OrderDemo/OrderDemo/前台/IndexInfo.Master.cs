using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OrderDemo
{
    public partial class IndexInfo : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                show();
                if (Session["User"] != null)
                {
                    UserInfos user = Session["User"] as UserInfos;
                }
            }
        }
        public void show()
        {
            if (Session["boy"] != null)
            {
                this.login.Style.Add("display", "none");
                this.loginUser.Style.Add("display", "block");
                lblMageUser.Text = "你好!" + Session["boy"] + " 先生";
            }
            else if (Session["girl"] != null)
            {
                this.login.Style.Add("display", "none");
                this.loginUser.Style.Add("display", "block");
                lblMageUser.Text = "你好!" + Session["girl"] + " 女士";
            }
            else
            {
                this.login.Style.Add("display", "block");
                this.loginUser.Style.Add("display", "none");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string usernane = this.txtUser.Text;
            string pwd = this.TextBox2.Text;
           

            if (txtUser.Text != "" && TextBox2.Text != "")
            {
                if (txtUser.Text == "Admin")
                {
                    Response.Write("<script>alert('您不能使用管理员账号登录！');</script>");
                }
                else
                {
                    UserInfos user = UserManager.CheckedLogin(usernane, pwd);
                    if (txtUser.Text == user.UserName && TextBox2.Text == user.Password)
                    {
                        this.login.Style.Add("display", "none");
                        this.loginUser.Style.Add("display", "block");
                        if (user.Sex == "男")
                        {
                            lblMageUser.Text = "你好!" + user.RealName + " 先生";
                            Session["boy"] = user.RealName;
                        }
                        else
                        {
                            lblMageUser.Text = "你好!" + user.RealName + " 小姐";
                            Session["girl"] = user.RealName;
                        }
                        Session["User"] = user.RealName;
                        Session["id"] = user.UserID;
                        Session["address"] = user.Address;
                        Session["phone"] = user.Phone;
                    }
                    else
                    {
                        Response.Write("<script>alert('用户名或密码不正确！');</script>");
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('用户名和密码不能为空！');</script>");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["User"] = null;
            txtUser.Text = "";
            TextBox2.Text = "";
            Response.Redirect("Index.aspx");
            this.login.Style.Add("display", "block");
            this.loginUser.Style.Add("display", "none");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("zhuce.aspx");
        }
    }
}