using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public int Quatity { get; set; }
        public decimal UnitPrice { get; set; }
        public string PicUrl { get; set; }
    }
}
