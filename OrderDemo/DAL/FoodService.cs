using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FoodService
    {
        //Food显示查询
        public static List<Food> SelectFood(int id)
        {
           
            List<Food> list = new List<Food>();
            string sql = "select * from Food where FoodTypeID=" + id;
            SqlDataReader dr = DBhelper.reader(sql);
            while (dr.Read())
            {
                Food s = new Food();
                s.FoodID = Convert.ToInt32(dr["FoodID"]);
                s.FoodName = Convert.ToString(dr["FoodName"]);
                s.FoodTypeID = Convert.ToInt32(dr["FoodTypeID"]);
                s.Price = Convert.ToInt32(dr["Price"]);
                s.PicUrl = Convert.ToString(dr["PicUrl"]);
                s.SalesVolume = Convert.ToInt32(dr["SalesVolume"]);
                s.AddDate = Convert.ToDateTime(dr["AddDate"]);
                s.Desc = Convert.ToString(dr["Desc"]);
                list.Add(s);
            }
            dr.Close();
            return list;
        }
        //显示查询
        public static List<Food> Select()
        {
            List<Food> list = new List<Food>();
            string sql = "select *,(select FoodTypeName from FoodType B where B.FoodTypeID=A.FoodTypeID) FoodTypeName from Food A";
            SqlDataReader dr = DBhelper.reader(sql);
            while (dr.Read())
            {
                Food s = new Food();
                s.FoodID = Convert.ToInt32(dr["FoodID"]);
                s.FoodName = Convert.ToString(dr["FoodName"]).Trim();
                s.FoodTypeID = Convert.ToInt32(dr["FoodTypeID"]);
                s.Price = Convert.ToDecimal(dr["Price"]);
                s.PicUrl = Convert.ToString(dr["PicUrl"]).Trim();
                s.SalesVolume = Convert.ToInt32(dr["SalesVolume"]);
                s.AddDate = Convert.ToDateTime(dr["AddDate"]);
                s.Desc = Convert.ToString(dr["Desc"]).Trim();
                s.FoodTypeName = Convert.ToString(dr["FoodTypeName"]).Trim();
                list.Add(s);
            }
            dr.Close();
            return list;
        }
        //显示查询
        public static List<Food> SelectId(int id)
        {
            List<Food> list = new List<Food>();
            string sql = "select *,(select FoodTypeName from FoodType B where B.FoodTypeID=A.FoodTypeID) FoodTypeName from Food A where FoodId="+id;
            SqlDataReader dr = DBhelper.reader(sql);
            while (dr.Read())
            {
                Food s = new Food();
                s.FoodID = Convert.ToInt32(dr["FoodID"]);
                s.FoodName = Convert.ToString(dr["FoodName"]).Trim();
                s.FoodTypeID = Convert.ToInt32(dr["FoodTypeID"]);
                s.Price = Convert.ToDecimal(dr["Price"]);
                s.PicUrl = Convert.ToString(dr["PicUrl"]).Trim();
                s.SalesVolume = Convert.ToInt32(dr["SalesVolume"]);
                s.AddDate = Convert.ToDateTime(dr["AddDate"]);
                s.Desc = Convert.ToString(dr["Desc"]).Trim();
                s.FoodTypeName = Convert.ToString(dr["FoodTypeName"]).Trim();
                list.Add(s);
            }
            dr.Close();
            return list;
        }
        //条件查询
        public static List<Food> Select(Food food)
        {
            string sql = "select *,(select FoodTypeName from FoodType B where B.FoodTypeID=A.FoodTypeID) FoodTypeName from Food A";
            string where = " WHERE 1=1";
            if (food.FoodTypeID.ToString() != "")
            {
                where += "AND FoodTypeID LIKE '%" + food.FoodTypeID + "%'";
            }
            sql += where;
            List<Food> list = new List<Food>();
            SqlDataReader dr = DBhelper.reader(sql);
            while (dr.Read())
            {
                Food s = new Food();
                s.FoodID = Convert.ToInt32(dr["FoodID"]);
                s.FoodName = Convert.ToString(dr["FoodName"]).Trim();
                s.FoodTypeID = Convert.ToInt32(dr["FoodTypeID"]);
                s.Price = Convert.ToDecimal(dr["Price"]);
                s.PicUrl = Convert.ToString(dr["PicUrl"]).Trim();
                s.SalesVolume = Convert.ToInt32(dr["SalesVolume"]);
                s.AddDate = Convert.ToDateTime(dr["AddDate"]);
                s.Desc = Convert.ToString(dr["Desc"]).Trim();
                s.FoodTypeName = Convert.ToString(dr["FoodTypeName"]).Trim();
                list.Add(s);
            }
            dr.Close();
            return list;
        }
        //增加
        public static bool Insert(Food food)
        {
            string sql = "insert  food (FoodName,FoodTypeID,Price,PicUrl,SalesVolume,AddDate,[Desc]) values ('" + food.FoodName + "','" + food.FoodTypeID + "','" + food.Price + "','" + food.PicUrl + "','" + food.SalesVolume + "','" + food.AddDate + "','" + food.Desc + "')";
            return DBhelper.ExecuteNonQuery(sql);
        }
        //修改
        public static bool Update(Food food)
        {
            string sql = "update food set FoodName='" + food.FoodName + "',FoodTypeID='" + food.FoodTypeID + "',Price='" + food.Price + "',PicUrl='" + food.PicUrl + "',SalesVolume='" + food.SalesVolume + "',AddDate='" + food.AddDate + "',Desc='" + food.Desc + "' where FoodID='" + food.FoodID + "'";
            return DBhelper.ExecuteNonQuery(sql);
        }
        //删除
        public static bool Delete(int FoodID)
        {
            string sql = "delete from food where FoodID=" + FoodID;
            return DBhelper.ExecuteNonQuery(sql);
        }
    }
}
