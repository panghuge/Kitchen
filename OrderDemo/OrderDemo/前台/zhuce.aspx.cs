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
    public partial class zhuce : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sex = RadioButton1.Checked ? RadioButton1.Text : RadioButton2.Text;
            UserInfos u = new UserInfos()
            {
                UserName = TextBox1.Text.ToString().Trim(),
                Password = TextBox2.Text.ToString().Trim(),
                RealName = TextBox4.Text.ToString().Trim(),
                Sex = sex.ToString().Trim(),
                UserTypeID = 2,
                Phone = TextBox6.Text,
                Address = TextBox7.Text
            };
            bool result = UserManager.Add(u);
            if (result)
            {
                Response.Write("<script>alert('注册成功!')</script>");
            }
            else
            {
                Response.Write("<script>alert('注册失败!')</script>");
            }
        }
    }
}