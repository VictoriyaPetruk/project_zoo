using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoocurs
{
   public class Order
    {
        private int id;
        private string name;
        private string vid;
        private string sex;
        private int count;
        private double price;
        private int id_s;
        private double sum;
        public int Id{ set { id = value; } get { return id; } }
        public string Name { set { name = value; } get { return name; } }
        public string Vid { set { vid = value; } get { return vid; } }
        public string Sex { set { sex = value; } get { return sex; } }
        public int Count { set { count = value; } get { return count; } }
       public double Price { set { price = value; } get { return price; } }
        public int Id_s { set { id_s = value; } get { return id_s; } }
        public double Sum { set { sum = value; } get { return sum; } }

        public Order()
        {
            name = ""; vid = ""; sex = ""; count = -1; price = -1; sum = 0;
        }
        public Order(string info)
        {
            info = info.Trim();
            if (info.Length > 2)
            {
                string[] val = info.Split('!');
                id = Convert.ToInt32(val[0]);
                name = val[1];
                vid = val[2];
                sex = val[3];
               count= Convert.ToInt32(val[4]);
                price= Convert.ToDouble(val[5]);
                id_s= Convert.ToInt32(val[6]);
                sum = Convert.ToDouble(val[7]);

            }
        }

    }
}
