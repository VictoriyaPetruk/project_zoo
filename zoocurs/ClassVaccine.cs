using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoocurs
{
   public class ClassVaccine
    {
        private int id;
        private string name;
        private string data;
        public int ID { get { return id; } }
        public string Name { set { name = value; } get { return name; } }
        public string Data { set { data = value; } get { return data; } }
        public ClassVaccine() { id = -1; name = ""; }
        public ClassVaccine(string info)
        {
            info = info.Trim();
            if (info.Length > 2)
            {
                string[] val = info.Split('!');
                id = Convert.ToInt32(val[0]);
                name = val[1];
                data = val[2];
            }
        }
    }
}
