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
    public partial class UserShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                List<UserInfos> list = UserManager.Searchs(id);
                foreach (UserInfos item in list)
                {
                    Label1.Text = Convert.ToString(item.UserName);
                    Label2.Text = Convert.ToString(item.UserTypeID);
                    Label3.Text = Convert.ToString(item.RealName);
                    Label4.Text = Convert.ToString(item.Sex);
                    Label5.Text = Convert.ToString(item.Phone);
                    Label6.Text = Convert.ToString(item.Address);
                }
            }
        }
    }
}