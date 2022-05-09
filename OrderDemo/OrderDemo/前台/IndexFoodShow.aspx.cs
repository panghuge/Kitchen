using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using Model;

namespace OrderDemo.前台
{
    public partial class IndexFoodShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                show();
            }
        }


        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("IndexFoodShow.aspx?FoodTypeID=2");
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Response.Redirect("IndexFoodShow.aspx?FoodTypeID=3");
        }

        protected void Unnamed_Click2(object sender, EventArgs e)
        {
            Response.Redirect("IndexFoodShow.aspx?FoodTypeID=4");
        }

        protected void Unnamed_Click3(object sender, EventArgs e)
        {
            Response.Redirect("IndexFoodShow.aspx?FoodTypeID=5");
        }

        protected void Unnamed_Click4(object sender, EventArgs e)
        {
            Response.Redirect("IndexFoodShow.aspx?FoodTypeID=6");
        }

        protected void Unnamed_Click5(object sender, EventArgs e)
        {
            Response.Redirect("IndexFoodShow.aspx?FoodTypeID=1");
        }
      
        public void show()
        {
            //菜品类型切换
            int id = Convert.ToInt32(Request.QueryString["FoodTypeID"]);
            if (Request.QueryString["FoodTypeID"] == null)
            {

            }
            else
            {
                Repeater1.DataSource = FoodManager.SelectFood(id);
                Repeater1.DataBind();
            }
            //购物车内容显示
            if (Session["id"] != null)
            {
                List<Cart> lit = CartManager.GWC(Convert.ToInt32(Session["id"]));
                //重新绑定repeater刷新数据
                rpgwc.DataSource = lit;
                rpgwc.DataBind();
                if (lit.Count > 0)
                {
                    Label1.Text = Convert.ToString(CartManager.Sum(Convert.ToInt32(Session["id"])));
                }
                else
                {
                    Label1.Text = "0";
                }
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {            
            //获取到登陆的用户ID
            int userid = Convert.ToInt32(Session["id"]);
            //获取到当前点击的按钮
            Button bt = (Button)sender;
            //获取点击的菜品ID
            int cpid = Convert.ToInt32(bt.ToolTip);
            //查询该用户的购物车信息，判断当前要加入购物车的菜品是否已经添加过
            List<Cart> list = CartManager.selectGWC(userid, cpid);
            //如果list的数量等于1，说明购物车中有此菜品
            if (list.Count == 1)
            {
                //有此菜品，那么就要查出当前要添加的菜品在购物车中的数量
                int count = CartManager.selectGWCcount(userid, cpid);
                //在原先数量的基础上+1
                count += 1;
                //修改购物车中当前菜品的数量
                if (CartManager.updateGWC(count, userid, cpid))
                {
                    //重新绑定repeater刷新数据
                    rpgwc.DataSource = CartManager.GWC(Convert.ToInt32(Session["id"]));
                    rpgwc.DataBind();
                    Label1.Text = Convert.ToString(CartManager.Sum(Convert.ToInt32(Session["id"])));
                }
                else
                {
                    Response.Write("<script>alert('加入购物车失败');</script>");
                }
            }
            else if (list.Count == 0)//如果list的数量等于0，说明购物车中没有此菜品
            {
                //把用户ID、菜品ID、菜品数量赋给insertFood
                Cart insertFood = new Cart();
                insertFood.UserID = userid;
                insertFood.FoodID = cpid;
                insertFood.Count = 1;
                //判断是否添加成功
                if (CartManager.insertGWC(insertFood))
                {
                    //重新绑定repeater刷新数据
                    rpgwc.DataSource = CartManager.GWC(Convert.ToInt32(Session["id"]));
                    rpgwc.DataBind();
                    Label1.Text = Convert.ToString(CartManager.Sum(Convert.ToInt32(Session["id"])));
                }
                else
                {
                    Response.Write("<script>alert('加入购物车失败');</script>");
                }


            }



        }
        protected void btnjian_Click(object sender, EventArgs e)
        {
            //获取到登陆的用户ID
            int userid = Convert.ToInt32(Session["id"]);
            //获取到当前点击的按钮
            Button bt = (Button)sender;
            //获取点击的菜品ID
            int cpid = Convert.ToInt32(bt.ToolTip);
            //有此菜品，那么就要查出当前要添加的菜品在购物车中的数量
            int count = CartManager.selectGWCcount(userid, cpid);
            //在原先数量的基础上+1
            count -= 1;
            //修改购物车中当前菜品的数量
            if (CartManager.updateGWC(count, userid, cpid))
            {
                //修改完再次查询数量
                count = CartManager.selectGWCcount(userid, cpid);
                //如果数量等于0，则删除这条数据
                if (count == 0)
                {
                    if (CartManager.deleteFoodcount(userid, cpid))
                    {
                        List<Cart> lit = CartManager.GWC(Convert.ToInt32(Session["id"]));

                        //重新绑定repeater刷新数据
                        rpgwc.DataSource =lit;
                        rpgwc.DataBind();
                        if (lit.Count>0)
                        {
                            Label1.Text = Convert.ToString(CartManager.Sum(Convert.ToInt32(Session["id"])));
                        }
                        else
                        {
                            Label1.Text = "0";
                        }
                       
                    }
                    else
                    {
                        Response.Write("<script>alert('哦！！！出错了');</script>");
                    }
                }
                else
                {
                    //重新绑定repeater刷新数据
                    rpgwc.DataSource = CartManager.GWC(Convert.ToInt32(Session["id"]));
                    rpgwc.DataBind();
                    Label1.Text = Convert.ToString(CartManager.Sum(Convert.ToInt32(Session["id"])));
                }
            }
            else
            {
                Response.Write("<script>alert('加入购物车失败');</script>");
            }

        }
        //加号
        protected void btnjia_Click(object sender, EventArgs e)
        {
            //获取到登陆的用户ID
            int userid = Convert.ToInt32(Session["id"]);
            //获取到当前点击的按钮
            Button bt = (Button)sender;
            //获取点击的菜品ID
            int cpid = Convert.ToInt32(bt.ToolTip);
            //有此菜品，那么就要查出当前要添加的菜品在购物车中的数量
            int count = CartManager.selectGWCcount(userid, cpid);
            //在原先数量的基础上+1
            count += 1;
            //修改购物车中当前菜品的数量
            if (CartManager.updateGWC(count, userid, cpid))
            {
                //重新绑定repeater刷新数据
                rpgwc.DataSource = CartManager.GWC(Convert.ToInt32(Session["id"]));
                rpgwc.DataBind();
                Label1.Text = Convert.ToString(CartManager.Sum(Convert.ToInt32(Session["id"])));
            }
            else
            {
                Response.Write("<script>alert('加入购物车失败');</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(Session["id"]);
            Response.Redirect("OrderShow.aspx?id=" + userid);
        }

        protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
}