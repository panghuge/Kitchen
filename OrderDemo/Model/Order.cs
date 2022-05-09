using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Order
    {
        public int id { get; set; }
        public int Userid { get; set; }
        public string RealName { get; set; }
        public string Address { get; set; }
        public string phone { get; set; }
        public DateTime DateCreate { get; set; }
        public decimal Totle { get; set; }
        public int OrderState { get; set; }
    }
}
