using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoocurs
{
    public class ClassSell
    {
        private int id;
        private string data_s;
        string employe;
        string lname_e;
        public int ID { set { id = value; } get { return id; } }
        public string Data_s { set { data_s = value; } get { return data_s; } }
        public string EmployeName { set { employe = value; } get { return employe; } }
        public string EmployeLname { set { lname_e = value; } get { return lname_e; } }
        public ClassSell()
        {
            id = -1; data_s = ""; employe = ""; lname_e = "";
        }

        public ClassSell(string info)
        {
            info = info.Trim();
            if (info.Length > 2)
            {
                string[] val = info.Split('!');
                id = Convert.ToInt32(val[0]);
                data_s = val[1];
                employe = val[2];
                lname_e = val[3];

            }
        }
    }
}
