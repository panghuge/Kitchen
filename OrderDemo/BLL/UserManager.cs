using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserManager
    {
        //管理员登录判断
        public static bool CheckUserLogin(string userName,string userPwd)
        {
            UserInfos user = UserService.UserSelet(userName);
            if (user == null)
                return false;
            return userPwd == user.Password;
        }
        //用户登录判断
        public static UserInfos CheckedLogin(string userName, string userPwd)
        {
            return UserService.SeletYh(userName, userPwd);
        }
        //查询用户全部信息列表
        public static List<UserInfos> Info()
        {
            return UserService.Select();
        }
        //条件查询
        public static List<UserInfos> Search(UserInfos user)
        {
            return UserService.Select(user);
        }
        //条件查询
        public static List<UserInfos> Searchs(int id)
        {
            return UserService.Selects(id);
        }
        //条件查询(新【修改版】)
        public static List<UserInfos> Search1(UserInfos user)
        {
            return UserService.Select1(user);
        }
        //添加
        public static bool Add(UserInfos userID)
        {
            return UserService.Insert(userID);
        }
        //删除
        public static bool Delete(int userID)
        {
            return UserService.Delete(userID);
        }
        //修改
        public static bool Update(UserInfos userID)
        {
            return UserService.Update(userID);
        }
    }
}
