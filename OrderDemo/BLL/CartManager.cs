using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CartManager
    {
        public static List<Cart> GWC(int id)
        {
            return CartService.GWC(id);
        }
        //添加购物车
        public static bool insertGWC(Cart mf)
        {
            return CartService.insertGWC(mf);
        }
        //查询添加的菜品是否已存在购物车
        public static List<Cart> selectGWC(int userid, int foodid)
        {
            return CartService.selectGWC(userid, foodid);
        }
        //查购物车内菜品数量
        public static int selectGWCcount(int userid, int foodid)
        {
            return CartService.selectGWCcount(userid, foodid);
        }
        //修改购物车菜品添加数量
        public static bool updateGWC(int count, int userid, int foodid)
        {
            return CartService.updateGWC(count, userid, foodid);
        }
        //当某个菜品的数量等于0时，删除这条数据
        public static bool deleteFoodcount(int userid, int foodid)
        {
            return CartService.deleteFoodcount(userid, foodid);
        }
        //计算购物车内菜品总价
        public static decimal Sum(int userid)
        {
            return CartService.Sum(userid);
        }
        public static bool UpdateOrder(int userid) {
            return CartService.UpdateOrder(userid);
        }
        public static bool innerOrder(int userid, string name, string address, string phone, Double price, DateTime date, int orderstate) {

            return CartService.innerOrder(userid,name,address,phone,price,date,orderstate);
        }
        public static bool deleteOrder(int userid)
        {
            return CartService.deleteOrder(userid);
        }
    }
}
