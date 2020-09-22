using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoocurs
{
  public  class ClassBill
    {
        private int id;
        private string animals;
        private string vid;
        private string sex;
        private double sale;
        private int count;
        private int id_s;
        public int ID { get { return id; } }
        public string Animals { set { animals = value; } get { return animals; } }
        public string Vid { set { vid = value; } get { return vid; } }
        public string Sex { set { sex = value; } get { return sex; } }
        public double Sale{ set { sale = value; } get { return sale; } }
        public int Count { set { count = value; } get { return count; } }
        public int Id_s { set { id_s = value; } get { return id_s; } }
        public ClassBill()
        {
            id = -1; animals = ""; vid = ""; sale = -1; count = -1; id_s=-1;
        }
        public ClassBill(string info)
        {
            info = info.Trim();
            if (info.Length > 2)
            {
                string[] val = info.Split('!');
                id = Convert.ToInt32(val[0]);
                animals = val[1];
                vid = val[2];
                sale = Convert.ToDouble(val[3]);
                count = Convert.ToInt32(val[4]);
                id_s = Convert.ToInt32(val[5]);
            }
        }
    }
}
