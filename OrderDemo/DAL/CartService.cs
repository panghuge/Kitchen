using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CartService
    {
        public static List<Cart> GWC(int id)
        {
            //创建集合用于存储数据库查到的数据返回
            List<Cart> list = new List<Cart>();
            string sql = "select * from Food f left join CartRecord c on f.FoodID=c.FoodID where UserID=" + id;
            //调用DBHelper方法返回reader数据
            SqlDataReader reader = DBhelper.reader(sql);
            while (reader.Read())//循环reader将数据填充到List里面
            {
                Cart mu = new Cart();
                mu.UserID = Convert.ToInt32(reader["UserID"]);
                mu.FoodID = Convert.ToInt32(reader["FoodID"]);
                mu.FoodName = Convert.ToString(reader["FoodName"]);
                mu.Price = Convert.ToDouble(reader["Price"]);
                mu.Count = Convert.ToInt32(reader["Count"]);
                mu.PicUrl = Convert.ToString(reader["PicUrl"]);
                list.Add(mu);
            }
            reader.Close();
            return list;
        }
        //查询添加的菜品是否已存在购物车
        public static List<Cart> selectGWC(int userid, int foodid)
        {
            Cart mf = new Cart();
            List<Cart> list = new List<Cart>();
            string sql = string.Format("select * from CartRecord where UserID={0} and FoodID={1}"
                                        , userid, foodid);
            SqlDataReader reader = DBhelper.reader(sql);
            while (reader.Read())
            {
                Cart m = new Cart();
                m.FoodID = Convert.ToInt32(reader["FoodID"]);
                list.Add(m);
            }
            reader.Close();
            return list;
        }
        //购物车添加
        public static bool insertGWC(Cart mf)
        {
            string sql = string.Format("insert into CartRecord values ({0},{1},{2})"
                                        , mf.UserID
                                        , mf.FoodID
                                        , mf.Count);
            return DBhelper.ExecuteNonQuery(sql);
        }
        //查购物车内菜品数量
        public static int selectGWCcount(int userid, int foodid)
        {
            int count = 0;
            string sql = string.Format("select * from CartRecord where UserID={0} and FoodID={1}"
                                        , userid, foodid);
            SqlDataReader reader = DBhelper.reader(sql);
            while (reader.Read())
            {
                count = Convert.ToInt32(reader["Count"]);
            }
            reader.Close();
            return count;
        }
        //修改购物车菜品数量
        public static bool updateGWC(int count, int userid, int foodid)
        {
            string sql = string.Format("update CartRecord set Count={0} where UserID={1} and FoodID={2}"
                                        , count, userid, foodid);
            return DBhelper.ExecuteNonQuery(sql);
        }
        //当某个菜品的数量等于0时，删除这条数据
        public static bool deleteFoodcount(int userid, int foodid)
        {
            string sql = string.Format("delete from CartRecord where UserID={0} and FoodID={1}"
                                        , userid, foodid);
            return DBhelper.ExecuteNonQuery(sql);
        }

        //计算购物车内菜品总价
        public static decimal Sum(int userid)
        {
            decimal sum = 0;
            string sql = "select SUM(Price*Count) Sumprice from CartRecord c left join Food f on c.FoodID=f.FoodID where UserID=" + userid;
            SqlDataReader reader = DBhelper.reader(sql);
            while (reader.Read())
            {
               sum = Convert.ToDecimal(reader["Sumprice"]);
            }
            reader.Close();
            return sum;
        }
        public static bool UpdateOrder(int userid) {
            string sql = "update [Order] set OrderState=2 where UserID='"+userid+"'";
            return DBhelper.ExecuteNonQuery(sql);
        }
        public static bool innerOrder(int userid,string name,string address,string phone, Double price,DateTime date,int orderstate)
        {
            string sql = string.Format("insert into [Order] values ('{0}','{1}','{2}','{3}','{4}','{5}',{6})"
                                        , userid
                                        , name
                                        , address
                                        ,phone
                                        ,price
                                        ,date
                                        ,orderstate); 
            return DBhelper.ExecuteNonQuery(sql);
        }
        //删除
        public static bool deleteOrder(int userid)
        {
            string sql = "delete CartRecord where UserID='" + userid + "'";
            return DBhelper.ExecuteNonQuery(sql);
        }
    }
}
