using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoocurs
{
   public class ClassPost
    {
        private int id;
        private string name;
        public int ID { get { return id; } }
        public string Name { set { name = value; } get { return name; } }
        public ClassPost() { id = -1;name = ""; }
        public ClassPost(string info) { info = info.Trim();
        if(info.Length>2)
            {
                string[] val = info.Split('!');
                id = Convert.ToInt32(val[0]);
                name = val[1];
            }
        }
    }
}
