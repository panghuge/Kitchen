using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderManager
    {
        public static List<Order> OrderSelet4(int OrderID)
        {
            return OrderService.OrderSelet4(OrderID);
        }
        public static List<OrderDetail> OrderDetailSelet(OrderDetail cart)
        {
            return OrderService.OrderDetailSelet(cart);
        }
        public static List<Order> Select4(int pageIndex, int pageSize)
        {
            return OrderService.Select4(pageIndex, pageSize);
        }
        public static List<Order> Orders(Order order)
        {
            return OrderService.OrderSelet2(order);
        }

        public static List<Order> Select1(int userid)
        {
            return OrderService.Select1(userid);
        }
        public static List<Order> Select()
        {
            return OrderService.Select();
        }
        public static List<Order> Select2()
        {
            return OrderService.Select2();
        }
        public static List<Order> Select3()
        {
            return OrderService.Select3();
        }
        public static List<Order> Select4()
        {
            return OrderService.Select4();
        }
        public static List<Order> Select5()
        {
            return OrderService.Select5();
        }
        public static bool Delete(int id)
        {
            return OrderService.Delete(id);
        }
        public static bool Update3(int id)
        {
            return OrderService.Update3(id);
        }
        public static bool Update4(int id)
        {
            return OrderService.Update4(id);
        }
        public static bool Update5(int id)
        {
            return OrderService.Update5(id);
        }
    }
}
