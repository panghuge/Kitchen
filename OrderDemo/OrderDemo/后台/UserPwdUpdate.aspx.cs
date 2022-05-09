using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace OrderDemo.后台
{
    public partial class UserPwdUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox4.Text = Session["name"] as string;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserInfos user = new UserInfos();
            user.Password = TextBox1.Text;
            user.UserName = Label1.Text;
            user.UserTypeID = 1;
            List<UserInfos> list = UserManager.Search1(user);
            foreach (UserInfos item in list)
            {
                UserInfos users = new UserInfos();
                users.UserID = item.UserID;
                users.UserName = TextBox4.Text;
                users.Password = TextBox2.Text;
                users.UserTypeID = 1;
                if (UserManager.Update(users))
                {
                    Response.Write("<script>alert('修改成功!')</script>");
                }
                else
                {
                    Response.Write("<script>alert('修改失败!')</script>");
                }
            }
        }
    }
}