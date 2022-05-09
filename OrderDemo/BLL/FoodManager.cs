using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FoodManager
    {

        //查询用户全部信息列表
        public static List<Food> Info()
        {
            return FoodService.Select();
        }
        //条件查询
        public static List<Food> SelectFood(int id)
        {
            return FoodService.SelectFood(id);
        }
        //条件查询
        public static List<Food> Search(Food user)
        {
            return FoodService.Select(user);
        }
        //添加
        public static bool Add(Food userID)
        {
            return FoodService.Insert(userID);
        }

        public static List<Food> FoodseletID(int id)
        {
            return FoodService.SelectId(id);
        }

        //删除
        public static bool Delete(int userID)
        {
            return FoodService.Delete(userID);
        }
        //修改
        public static bool Update(Food userID)
        {
            return FoodService.Update(userID);
        }
    }
}

