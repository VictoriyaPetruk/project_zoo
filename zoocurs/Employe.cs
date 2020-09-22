using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoocurs
{
   public class Employe
    {
        private int id;
        private string name;
        private string lname;
        private string phone;
        private string stan;
        private string data_b;
        private string post;
        public int ID { get { return id; } }
        public string Name { set { name = value; } get { return name; } }
        public string Lname { set { lname = value; } get { return lname; } }
        public string Phone { set { phone = value; } get { return phone; } }
        public string Stan { set { stan = value; } get { return stan; } }
        public string Data { set { data_b = value; } get { return data_b; } }
        public string Post { set { post = value; } get { return post; } }
        public Employe() { id = -1; name = "";lname = "";phone = "";stan = ""; data_b = "";post = ""; }
        public Employe(string info)
        {
            info = info.Trim();
            if (info.Length > 2)
            {
                string[] val = info.Split('!');
                id = Convert.ToInt32(val[0]);
                name = val[1];
                lname = val[2];
                phone = val[3];
                stan = val[4];
                data_b = val[5];
                post = val[6];
         
            }
        }

    }
}
