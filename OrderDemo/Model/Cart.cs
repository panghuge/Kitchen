using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Cart
    {
        public int CartID { get; set; }
        public int UserID { get; set; }
        public int FoodID { get; set; }
        public int Count { get; set; }
        public string FoodName { get; set; }

        public double Price { get; set; }
        public string PicUrl { get; set; }
    }
}
