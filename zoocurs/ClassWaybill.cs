using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoocurs
{
   public  class ClassWaybill
    {
        private int id;
        private string names;
        private string lnames;
        private string namep;
        private string data;
        public int ID { get { return id; } }
        public string NameS { set { names = value; } get { return names; } }
        public string LnameS { set { lnames = value; } get { return lnames; } }

        public string NameP { set { namep = value; } get { return namep; } }

        public string Data { set { data = value; } get { return data; } }
     

        public ClassWaybill() { id = -1; names = ""; namep = ""; data = "";}
        public ClassWaybill(string info)
        {
            info = info.Trim();
            if (info.Length > 2)
            {
                string[] val = info.Split('!');
                id = Convert.ToInt32(val[0]);
                names = val[1];
                lnames = val[2];
                namep = val[3];
                data= val[4];
              
                
            }
        }
    }
}
