using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderService
    {
        public static List<OrderDetail> OrderDetailSelet(OrderDetail cart)
        {
            List<OrderDetail> list = new List<OrderDetail>();
            string sql = "select * from OrderDetail where OrderID=" + cart.OrderID;
            SqlDataReader sqr = DBhelper.reader(sql);
            while (sqr.Read())
            {
                OrderDetail c = new OrderDetail();
                c.OrderDetailID = Convert.ToInt32(sqr["OrderDetailID"]);
                c.OrderID = Convert.ToInt32(sqr["OrderID"]);
                c.FoodID = Convert.ToInt32(sqr["FoodID"]);
                c.FoodName = Convert.ToString(sqr["FoodName"]);
                c.Quatity = Convert.ToInt32(sqr["Quatity"]);
                c.UnitPrice = Convert.ToDecimal(sqr["UnitPrice"]);
                c.PicUrl = Convert.ToString(sqr["PicUrl"]);
                list.Add(c);
            }
            sqr.Close();
            return list;
        }

        public static List<Order> OrderSelet4(int OrderID)
        {
            List<Order> list = new List<Order>();
            string sql = "";
            sql = "select OrderID,UserID, RealName,Address,Phone,Totle,DateCreate,OrderState from [Order] where OrderID=" + OrderID;
            SqlDataReader sqr = DBhelper.reader(sql);
            while (sqr.Read())
            {
                Order c = new Order();
                c.id = Convert.ToInt32(sqr["OrderID"]);
                c.Userid = Convert.ToInt32(sqr["UserID"]);
                c.RealName = Convert.ToString(sqr["RealName"]);
                c.Address = Convert.ToString(sqr["Address"]);
                c.phone = Convert.ToString(sqr["Phone"]);
                c.Totle = Convert.ToDecimal(sqr["Totle"]);
                c.OrderState = Convert.ToInt32(sqr["OrderState"]);
                c.DateCreate = Convert.ToDateTime(sqr["DateCreate"]);
                list.Add(c);
            }
            sqr.Close();
            return list;
        }

        public static List<Order> OrderSelet2(Order Order)
        {
            List<Order> list = new List<Order>();
            string sql = "";
            if (Order.OrderState != 0)
            {
                sql = "select OrderID, RealName,Totle,DateCreate,OrderState from [Order] where OrderState = " + Order.OrderState + " and UserID = " + Order.Userid;
            }
            else
            {
                sql = "select OrderID, RealName,Totle,DateCreate,OrderState from [Order] where UserID=" + Order.Userid;
            }

            SqlDataReader sqr = DBhelper.reader(sql);
            while (sqr.Read())
            {
                Order c = new Order();
                c.id = Convert.ToInt32(sqr["OrderID"]);
                c.RealName = Convert.ToString(sqr["RealName"]);
                c.Totle = Convert.ToDecimal(sqr["Totle"]);
                c.OrderState = Convert.ToInt32(sqr["OrderState"]);
                c.DateCreate = Convert.ToDateTime(sqr["DateCreate"]);
                list.Add(c);
            }
            sqr.Close();
            return list;
        }
        public static List<Order> Select4(int pageIndex, int pageSize)
        {
            List<Order> list = new List<Order>();
            string sql = string.Format("select * from [Order] order by OrderID offset {0} rows fetch next {1} rows only", pageIndex, pageSize);
            SqlDataReader dr = DBhelper.reader(sql);
            while (dr.Read())
            {
                Order s = new Order();
                s.id = Convert.ToInt32(dr["OrderID"]);
                s.DateCreate = Convert.ToDateTime(dr["DateCreate"]);
                s.Totle = Convert.ToDecimal(dr["Totle"]);
                s.OrderState = Convert.ToInt32(dr["OrderState"]);
                list.Add(s);
            }
            dr.Close();
            return list;
        }
        public static List<Order> Select1(int userid)
        {
            List<Order> list = new List<Order>();
            string sql = "select OrderID,DateCreate,Totle,OrderState from [Order] where UserID=" + userid + "";
            SqlDataReader dr = DBhelper.reader(sql);
            while (dr.Read())
            {
                Order s = new Order();
                s.id = Convert.ToInt32(dr["OrderID"]);
                s.DateCreate = Convert.ToDateTime(dr["DateCreate"]);
                s.Totle = Convert.ToDecimal(dr["Totle"]);
                s.OrderState = Convert.ToInt32(dr["OrderState"]);
                list.Add(s);
            }
            dr.Close();
            return list;
        }
        public static List<Order> Select()
        {
            List<Order> list = new List<Order>();
            string sql = "select OrderID,RealName,DateCreate,Totle from [Order] where OrderState = 2";
            SqlDataReader dr = DBhelper.reader(sql);
            while (dr.Read())
            {
                Order s = new Order();
                s.id = Convert.ToInt32(dr["OrderID"]);
                s.RealName = Convert.ToString(dr["RealName"]).Trim();
                s.DateCreate = Convert.ToDateTime(dr["DateCreate"]);
                s.Totle = Convert.ToDecimal(dr["Totle"]);
                list.Add(s);
            }
            dr.Close();
            return list;
        }
        public static List<Order> Select2()
        {
            List<Order> list = new List<Order>();
            string sql = "select OrderID,RealName,DateCreate,Totle from [Order] where OrderState = 1";
            SqlDataReader dr = DBhelper.reader(sql);
            while (dr.Read())
            {
                Order s = new Order();
                s.id = Convert.ToInt32(dr["OrderID"]);
                s.RealName = Convert.ToString(dr["RealName"]).Trim();
                s.DateCreate = Convert.ToDateTime(dr["DateCreate"]);
                s.Totle = Convert.ToDecimal(dr["Totle"]);
                list.Add(s);
            }
            dr.Close();
            return list;
        }
        public static List<Order> Select3()
        {
            List<Order> list = new List<Order>();
            string sql = "select OrderID,RealName,DateCreate,Totle from [Order] where OrderState = 3";
            SqlDataReader dr = DBhelper.reader(sql);
            while (dr.Read())
            {
                Order s = new Order();
                s.id = Convert.ToInt32(dr["OrderID"]);
                s.RealName = Convert.ToString(dr["RealName"]).Trim();
                s.DateCreate = Convert.ToDateTime(dr["DateCreate"]);
                s.Totle = Convert.ToDecimal(dr["Totle"]);
                list.Add(s);
            }
            dr.Close();
            return list;
        }
        public static List<Order> Select4()
        {
            List<Order> list = new List<Order>();
            string sql = "select OrderID,RealName,DateCreate,Totle from [Order] where OrderState = 4";
            SqlDataReader dr = DBhelper.reader(sql);
            while (dr.Read())
            {
                Order s = new Order();
                s.id = Convert.ToInt32(dr["OrderID"]);
                s.RealName = Convert.ToString(dr["RealName"]).Trim();
                s.DateCreate = Convert.ToDateTime(dr["DateCreate"]);
                s.Totle = Convert.ToDecimal(dr["Totle"]);
                list.Add(s);
            }
            dr.Close();
            return list;
        }
        public static List<Order> Select5()
        {
            List<Order> list = new List<Order>();
            string sql = "select OrderID,RealName,DateCreate,Totle from [Order] where OrderState = 5";
            SqlDataReader dr = DBhelper.reader(sql);
            while (dr.Read())
            {
                Order s = new Order();
                s.id = Convert.ToInt32(dr["OrderID"]);
                s.RealName = Convert.ToString(dr["RealName"]).Trim();
                s.DateCreate = Convert.ToDateTime(dr["DateCreate"]);
                s.Totle = Convert.ToDecimal(dr["Totle"]);
                list.Add(s);
            }
            dr.Close();
            return list;
        }
        public static bool Delete(int id)
        {
            string sql = "delete [Order] where OrderID='" + id + "'";
            return DBhelper.ExecuteNonQuery(sql);
        }
        public static bool Update3(int id)
        {
            string sql = "update [Order] set OrderState=3 where OrderID=" + id;
            return DBhelper.ExecuteNonQuery(sql);
        }
        public static bool Update4(int id)
        {
            string sql = "update [Order] set OrderState=4 where OrderID=" + id;
            return DBhelper.ExecuteNonQuery(sql);
        }
        public static bool Update5(int id)
        {
            string sql = "update [Order] set OrderState=5 where OrderID=" + id;
            return DBhelper.ExecuteNonQuery(sql);
        }
    }
}
