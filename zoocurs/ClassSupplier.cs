using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoocurs
{
   public class ClassSupplier
    {
        private int id;
        private string name;
        private string phone;
        private string pib;
        private string data;
        private char activ;
        public int ID { get { return id; } }
        public string Name { set { name = value; } get { return name; } }
        public string Phone { set { phone = value; } get { return phone; } }
        public string Pib{ set { pib = value; } get { return pib; } }
        public string Data { set { data = value; } get { return data; } }
        public char Activ { set { activ = value; } get { return activ; } }
        public ClassSupplier() { id = -1; name = ""; }
        public ClassSupplier(string info)
        {
            info = info.Trim();
            if (info.Length > 2)
            {
                string[] val = info.Split('!');
                id = Convert.ToInt32(val[0]);
                name = val[1];
                phone = val[2];
                pib = val[3];
                data = val[4];
                activ = Convert.ToChar(val[5]);
            }
        }
    }
}
