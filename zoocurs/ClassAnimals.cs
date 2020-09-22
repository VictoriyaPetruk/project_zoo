using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zoocurs
{
    public class ClassAnimals
    {
        private int id;
        private string name;
        private string vid;
        private string sex;
        private double price;
        private string vaccine;
        private string data_p;
        private string food;
        private int presence;
        public int ID { get { return id; } }
        public string Name { set { name = value; } get { return name; } }
        public string Vid { set { vid = value; } get { return vid; } }
        public string Sex { set { sex = value; } get { return sex; } }
        public double Price { set { price = value; } get { return price; } }
        public string Vaccine { set { vaccine = value; } get { return vaccine; } }
        public string Data_p { set { data_p = value; } get { return data_p; } }
        public string Food { set { food = value; } get { return food; } }
        public int Presence { set { presence = value; } get { return presence; } }
        public ClassAnimals() { id = -1; name = ""; vid = ""; sex = ""; price =0; data_p = ""; food= ""; presence = -1; }
        public ClassAnimals(string info)
        {
            info = info.Trim();
            if (info.Length > 2)
            {
                string[] val = info.Split('!');
                id = Convert.ToInt32(val[0]);
                name = val[1];
                vid = val[2];
                sex = val[3];
                price = Convert.ToDouble(val[4]);
                vaccine = val[5];
                data_p =val[6];
                food = val[7];
                presence = Convert.ToInt32(val[8]);
            }
        }
        public bool Checkfind(string animals, string vid, string p1, string p2, string d1, string d2)
        {
            bool k = true;

            if (this.Name == animals || animals == "") k = true;
            else return false;
            if (this.Vid == vid || vid == "") k = true;
            else return false;
            if ((p1 == "") && (p2 == "")) k = true;
            else

                if (p1 == "")
            {
                if (this.Price <= Convert.ToDouble(p2)) k = true;
                else return false;
            }
            else
                 if (p2 == "")
                 {
                if (this.Price >= Convert.ToDouble(p1)) k = true;
                else return false;
                  }
            else if ((this.Price >= Convert.ToDouble(p1)) && (this.Price <= Convert.ToDouble(p2))) k = true;
            else return false;
                    
            if ((Convert.ToDateTime(this.Data_p) >= Convert.ToDateTime(d1)) && (Convert.ToDateTime(this.Data_p) <= Convert.ToDateTime(d2)) || (d1 == "" && d2 == ""))
                k = true;
            else return false;


            return k;
        }

    }
}
