using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Food
    {
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public int FoodTypeID { get; set; }
        public decimal Price { get; set; }
        public string PicUrl { get; set; }
        public int SalesVolume { get; set; }
        public DateTime AddDate { get; set; }
        public string Desc { get; set; }
        public string FoodTypeName { get; set; }
    }
}
