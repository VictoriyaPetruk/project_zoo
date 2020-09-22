using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoocurs
{
  public  class InfoSell
    { 
        private string date;
        private string name;
        private string vid;
        private int count;
        private double sum;

        public string Date { set { date = value; } get { return date; } }
        public string Name { set { name = value; } get { return name; } }
        public string Vid { set { vid = value; } get { return vid; } }
        public int Count { set { count = value; } get { return count; } }
        public double Sum { set { sum = value; } get { return sum; } }
        public InfoSell()
        {
            date=""; name = ""; vid = ""; count = -1; sum = -1;
        }
        public InfoSell(string info)
        {
            info = info.Trim();
            if (info.Length > 2)
            {
                string[] val = info.Split('!');
                date = val[0];
                name = val[1];
                vid = val[2];
                count = Convert.ToInt32(val[3]);
                sum = Convert.ToDouble(val[4]);
          
            }
        }
    }
}
