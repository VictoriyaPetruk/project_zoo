using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoocurs
{
  public  class Wayblilnfo
    {
        private int id;
        private string nameS;
        private string supplier;
        private string data;
        private int count;
        private double sum;
        public int Id {  get { return id; } }
        public string Name { set { nameS = value; } get { return nameS; } }
        public string Supplier { set { supplier = value; } get { return supplier; } }
        public string Data { set { data = value; } get { return data; } }
        public int Count { set { count = value; } get { return count; } }
        public double Sum { set { sum = value; } get { return sum; } }
        public Wayblilnfo()
        {
            id = -1; nameS = ""; supplier = ""; data = ""; count = -1; sum = -1;
        }
        public Wayblilnfo(string info)
        {
            info = info.Trim();
            if (info.Length > 2)
            {
                string[] val = info.Split('!');
                id= Convert.ToInt32(val[0]);
                nameS = val[1];
                supplier = val[2];
                data = val[3];
                count = Convert.ToInt32(val[4]);
                sum = Convert.ToDouble(val[5]);
               

            }
        }

    }
}
