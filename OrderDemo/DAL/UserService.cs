using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserService
    {

        //管理员登录
        public static UserInfos UserSelet(string userName)
        {
            string sql = "select * from [User] where UserTypeID=1 and UserName='" + userName + "'";
            SqlDataReader sqr = DBhelper.reader(sql);
            UserInfos user =null;
            while (sqr.Read())
            {
                user = new UserInfos();
                user.UserID = Convert.ToInt32(sqr["UserID"]);
                user.UserName = Convert.ToString(sqr["UserName"]);
                user.Password = Convert.ToString(sqr["Password"]);
                user.UserTypeID = Convert.ToInt32(sqr["UserTypeID"]);
                user.Address = Convert.ToString(sqr["Address"]);
                user.RealName = Convert.ToString(sqr["RealName"]);
                user.Sex = Convert.ToString(sqr["Sex"]);
                user.Phone = Convert.ToString(sqr["Phone"]);
            }
            sqr.Close();
            return user;
        }
        //用户登录
        public static UserInfos SeletYh(string userName,string pwd)
        {
            //string sql = "select * from [User] where UserTypeID=2 and UserName=' "+userName +"' and [Password]='"+ pwd + "'";
            string sql = $"select * from [User] where UserTYpeID=2 and UserName= '{userName}' and Password='{pwd}'";

            SqlDataReader sqr = DBhelper.reader(sql);
            UserInfos user = null;
            while (sqr.Read())
            {
                user = new UserInfos();
                user.UserID = Convert.ToInt32(sqr["UserID"]);
                user.UserName = Convert.ToString(sqr["UserName"]);
                user.Password = Convert.ToString(sqr["Password"]);
                user.UserTypeID = Convert.ToInt32(sqr["UserTypeID"]);
                user.Address = Convert.ToString(sqr["Address"]);
                user.RealName = Convert.ToString(sqr["RealName"]);
                user.Sex = Convert.ToString(sqr["Sex"]);
                user.Phone = Convert.ToString(sqr["Phone"]);
            }
            sqr.Close();
            return user;
        }
        //显示查询1
        public static List<UserInfos> Select()
        {
            List<UserInfos> list = new List<UserInfos>();
            string sql = "select *,(select UserTypeName from[UserType] B where B.UserTypeID = A.UserTypeID) UserTypeName from[User] A";
            SqlDataReader dr = DBhelper.reader(sql);
            while (dr.Read())
            {
                UserInfos s = new UserInfos();
                s.UserID = Convert.ToInt32(dr["UserID"]);
                s.UserName = Convert.ToString(dr["UserName"]).Trim();
                s.Password = Convert.ToString(dr["Password"]).Trim();
                s.UserTypeID = Convert.ToInt32(dr["UserTypeID"]);
                s.Address = Convert.ToString(dr["Address"]).Trim(); 
                s.Sex = Convert.ToString(dr["Sex"]).Trim();
                s.RealName = Convert.ToString(dr["RealName"]).Trim();
                s.Phone = Convert.ToString(dr["Phone"]).Trim();
                s.UserTypeName = Convert.ToString(dr["UserTypeName"]).Trim();
                list.Add(s);
            }
            dr.Close();
            return list;
        }
        //显示查询2
        public static List<UserInfos> Selects(int id)
        {
            List<UserInfos> list = new List<UserInfos>();
            string sql = "select *,(select UserTypeName from[UserType] B where B.UserTypeID = A.UserTypeID) UserTypeName from[User] A where UserID="+id;
            SqlDataReader dr = DBhelper.reader(sql);
            while (dr.Read())
            {
                UserInfos s = new UserInfos();
                s.UserID = Convert.ToInt32(dr["UserID"]);
                s.UserName = Convert.ToString(dr["UserName"]).Trim();
                s.Password = Convert.ToString(dr["Password"]).Trim();
                s.UserTypeID = Convert.ToInt32(dr["UserTypeID"]);
                s.Address = Convert.ToString(dr["Address"]).Trim();
                s.Sex = Convert.ToString(dr["Sex"]).Trim();
                s.RealName = Convert.ToString(dr["RealName"]).Trim();
                s.Phone = Convert.ToString(dr["Phone"]).Trim();
                s.UserTypeName = Convert.ToString(dr["UserTypeName"]).Trim();
                list.Add(s);
            }
            dr.Close();
            return list;
        }
        //条件查询
        public static List<UserInfos> Select(UserInfos user)
        {
            string sql = "select *,(select UserTypeName from[UserType] B where B.UserTypeID = A.UserTypeID) UserTypeName from[User] A";
            string where = " WHERE 1=1";
            if (user.RealName != "")
            {
                where += "AND RealName LIKE '%" + user.RealName + "%'";
            }
            sql += where;
            List<UserInfos> list = new List<UserInfos>();
            SqlDataReader dr = DBhelper.reader(sql);
            while (dr.Read())
            {
                UserInfos s = new UserInfos();
                s.UserID = Convert.ToInt32(dr["UserID"]);
                s.UserName = Convert.ToString(dr["UserName"]).Trim();
                s.Password = Convert.ToString(dr["Password"]).Trim();
                s.UserTypeID = Convert.ToInt32(dr["UserTypeID"]);
                s.Address = Convert.ToString(dr["Address"]).Trim(); 
                s.Sex = Convert.ToString(dr["Sex"]).Trim();
                s.RealName = Convert.ToString(dr["RealName"]).Trim();
                s.Phone = Convert.ToString(dr["Phone"]).Trim();
                s.UserTypeName = Convert.ToString(dr["UserTypeName"]).Trim();
                list.Add(s);
            }
            dr.Close();
            return list;
        }

        //条件查询(新【修改版】)
        public static List<UserInfos> Select1(UserInfos user)
        {
            string sql = "select * from [User] where UserTypeID=1 and UserName='" + user.UserName + "' and Password='" + user.Password + "'";
            List<UserInfos> list = new List<UserInfos>();
            SqlDataReader dr = DBhelper.reader(sql);
            while (dr.Read())
            {
                UserInfos s = new UserInfos();
                s.UserID = Convert.ToInt32(dr["UserID"]);
                s.UserName = Convert.ToString(dr["UserName"]).Trim();
                s.Password = Convert.ToString(dr["Password"]).Trim();
                s.UserTypeID = Convert.ToInt32(dr["UserTypeID"]);
                s.Address = Convert.ToString(dr["Address"]).Trim();
                s.Sex = Convert.ToString(dr["Sex"]).Trim();
                s.RealName = Convert.ToString(dr["RealName"]).Trim();
                s.Phone = Convert.ToString(dr["Phone"]).Trim();
                list.Add(s);
            }
            dr.Close();
            return list;
        }
        //增加
        public static bool Insert(UserInfos user)
        {
            string sql = "insert  [User](UserName,Password,UserTypeID,Address,Sex,RealName,Phone)values ('" + user.UserName + "','" + user.Password + "','" + user.UserTypeID + "','" + user.Address + "','" + user.Sex + "','" + user.RealName + "','" + user.Phone + "')";
            return DBhelper.ExecuteNonQuery(sql);
        }
        //修改
        public static bool Update(UserInfos user)
        {
            string sql = "update [User] set UserName='" + user.UserName + "',Password='" + user.Password + "',UserTypeID='"+user.UserTypeID+"' where UserID='" + user.UserID + "'";
            return DBhelper.ExecuteNonQuery(sql);
        }
        //删除
        public static bool Delete(int userID)
        {
            string sql = "delete from [User] where UserID=" + userID;
            return DBhelper.ExecuteNonQuery(sql);
        }
    }
}
