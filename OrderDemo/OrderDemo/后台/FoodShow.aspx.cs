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
    public partial class FoodShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                List<Food> list = FoodManager.FoodseletID(id);
                foreach (Food item in list)
                {
                    Label1.Text = Convert.ToString(item.FoodID);
                    Label2.Text = Convert.ToString(item.FoodName);
                    Label3.Text = Convert.ToString(item.FoodTypeName);
                    Label5.Text = Convert.ToString(item.AddDate);
                    Label6.Text = Convert.ToString(item.SalesVolume);
                    Label7.Text = Convert.ToString(item.Desc);
                    Image1.ImageUrl = "..\\img\\home1.jpg";
                }
            }
        }
    }
}