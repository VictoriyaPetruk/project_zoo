using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zoocurs
{
    public partial class Waybill : Form
    {
        public Waybill()
        {
            InitializeComponent();
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.lbhead.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            DateTime date = new DateTime();
            string dater = date.ToShortDateString();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform f = new mainform();
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public List<ClassWaybill> ListWay = new List<ClassWaybill>();
        public List<ClassSupplier> ListSup = new List<ClassSupplier>();
        public List<Employe> ListEmploye = new List<Employe>();
        public List<ClassAnimals> ListAnimals = new List<ClassAnimals>();
        public List<Wayblilnfo> ListInfo = new List<Wayblilnfo>();
        ClassDataBase db = new ClassDataBase();


        public void Load_Data()
        {
            string q = @"select w.id_w,a.name_s,a.lname_s,f.name_f,w.data_post from staff a natural join waybill w natural join supplier f ";
            db.Execute<ClassWaybill>("zoo.db", q, ref ListWay);
            string r = @"select id_sp, name_f, f_phone, manager, data_c, activ from supplier;";
            db.Execute<ClassSupplier>("zoo.db", r, ref ListSup);
            string k = @"select a.id_s, a.name_s, a.lname_s, a.n_phone, a.stan, a.birthday, v.p_name from staff a join positionn v on a.s_id_p=v.id_p;";
            db.Execute<Employe>("zoo.db", k, ref ListEmploye);
            string l = @"select a.id_a, a.kind, a.vid, a.sex, a.price, v.name_v, a.a_data, a.food, a.count_a  from vaccine v join animals a on a.a_id_v=v.id_v;";
            db.Execute<ClassAnimals>("zoo.db", l, ref ListAnimals);
            string f = @"select w.id_w,a.lname_s,b.name_f,w.data_post,sum(c.count_w),sum(c.price * c.count_w) from staff a natural join waybill w natural join supplier b natural join waybill_animal c group by 1";
            db.Execute<Wayblilnfo>("zoo.db", f, ref ListInfo);
        }
        public void Show_Data()
        {
            for (int i = 0; i < ListInfo.Count; i++)
            {

                dvgWaybill.Rows.Add(ListInfo[i].Name, ListInfo[i].Supplier, ListInfo[i].Data, ListInfo[i].Count,ListInfo[i].Sum);

            }
            for (int i = 0; i < ListSup.Count; i++)
            {
                {
                    
                    cbSup1.Items.Add(ListSup[i].Name);


                }
                
                cbSup1.Text = ListSup[1].Name;
            }
            for(int i=0;i< ListEmploye.Count;i++)
            {
                if (ListEmploye[i].Stan == "працює" && ListEmploye[i].Post != "доглядач за тваринами")
                {
                    cbEmp1.Items.Add(ListEmploye[i].Lname);
                }
            }
          
            cbEmp1.Text = ListEmploye[2].Lname;

            for (int i = 0; i < ListAnimals.Count; i++)
            {
                if (!comboBox3.Items.Contains(ListAnimals[i].Name))
                    comboBox3.Items.Add(ListAnimals[i].Name);
            }
            comboBox3.Text = ListAnimals[0].Name;




        }
        bool f = true;
        private void Waybill_Load(object sender, EventArgs e)
        {
            Load_Data();
            Show_Data();
        }
       public int GetSuplier(string a)
        {    for (int i = 0; i < ListSup.Count; i++)
                if (ListSup[i].Name == a )
                    return ListSup[i].ID;
            return -1;
        }
        public int GetEmploye(string a,string b)
        {
            for (int i = 0; i < ListEmploye.Count; i++)
                if (ListEmploye[i].Name == a && ListEmploye[i].Lname == b )
                    return ListEmploye[i].ID;
            return -1;
        }
        public bool CheckDataEml()
        {
            if (textBox1.Text == "") { MessageBox.Show(@"Колличество -обязательное поле для заполнения. Пожалуйста введите значение", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (textBox5.Text.Trim() == "") { MessageBox.Show(@"Цена-обязательное поле для заполнения. Пожалуйста введите значение", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }

            return true;
        }
        public void AddWaybill()
        { 
            if(f==true)
            {
                ClassWaybill a = new ClassWaybill();
                a.Data = dateTimePicker1.Text;
                a.NameS = comboBox4.Text;
                a.LnameS = cbEmp1.Text;
                a.NameP = cbSup1.Text;
                ListWay.Add(a);
                string q = @"Insert into waybill(id_sp,id_s,data_post) values(" + Convert.ToString(GetSuplier(cbSup1.Text)) + @"," + Convert.ToString(GetEmploye(comboBox4.Text, cbEmp1.Text)) + @",'"+Convert.ToString(dateTimePicker1.Text)+@"')";
                db.ExecuteNonQuery("zoo.db", q, 0);
                ListWay.Clear();
                string y = @"select w.id_w,a.name_s,a.lname_s,f.name_f,w.data_post from staff a natural join waybill w natural join supplier f ";
                db.Execute<ClassWaybill>("zoo.db", y, ref ListWay);

                groupBox2.Visible = true;
                cbSup1.Enabled = false;
                cbEmp1.Enabled = false;
                comboBox4.Enabled = false;
                
            }
        }
        private int GetAnimals(string a, string vid, string sex)
        {
            for (int i = 0; i < ListAnimals.Count; i++)
                if (ListAnimals[i].Name == a && ListAnimals[i].Vid == vid && ListAnimals[i].Sex == sex)
                    return ListAnimals[i].ID;
            return -1;
        }

        public void SaveData()
        { if (CheckDataEml())
            {
                AddWaybill();
                int max = ListWay[0].ID;

                f = false;
                for (int i = 0; i < ListWay.Count; i++)
                {
                    if (ListWay[i].ID > max)
                        max = ListWay[i].ID;
                }
                string q = @"Insert into waybill_animal(id_w,id_a,price,count_w) values(" + max + @"," + Convert.ToString(GetAnimals(comboBox3.Text, comboBox1.Text, comboBox2.Text)) + @"," + Convert.ToDouble(textBox5.Text)  + @"," + Convert.ToInt32(textBox1.Text) + @")";
                string l = @"Update animals a, waybill_animal b  set a.count_a=a.count_a+b.count_w where a.id_a=b.id_a and b.id_w=" + max + ";";
                db.ExecuteNonQuery("zoo.db", q, 0);
                db.ExecuteNonQuery("zoo.db", l, 0);
                MessageBox.Show("Поставка добавлена!");
            }
        }
        double s = 0;
        int k = 0;
        private void addtobasket_Click(object sender, EventArgs e)
        {   
            SaveData();
            s = s + Convert.ToDouble(textBox2.Text);
            textBox3.Text = Convert.ToString(s);
            k = k + Convert.ToInt32(textBox1.Text);
            textBox4.Text = Convert.ToString(k);
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {  if (textBox5.Text != "")
            {
                try
                {
                    int i = Convert.ToInt32(textBox1.Text);
                    double k = Convert.ToDouble(textBox5.Text);
                    textBox2.Text = Convert.ToString(i * k);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Введите коректные данные","Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox5.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wayblilnfo a = new Wayblilnfo();
            a.Name = cbEmp1.Text;
            a.Supplier = cbSup1.Text;
                a.Data = dateTimePicker1.Text;
                a.Count = Convert.ToInt32(textBox4.Text);
            a.Sum = Convert.ToDouble(textBox3.Text);
            dvgWaybill.Rows.Add(a.Name, a.Supplier, a.Data, a.Count, a.Sum);
            MessageBox.Show("Поставка оформленна!");
            f = true;
            groupBox2.Visible = true;
            cbSup1.Enabled = true;
            cbEmp1.Enabled = true;
            comboBox4.Enabled = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            textBox1.Text = "";
            textBox5.Text = "";

            for (int i = 0; i < ListAnimals.Count; i++)
            {
                if (ListAnimals[i].Name == comboBox3.Text)
                {
                    if (!comboBox1.Items.Contains(ListAnimals[i].Vid))
                    {  comboBox1.Items.Add(ListAnimals[i].Vid); comboBox1.Text = ListAnimals[i].Vid; }
                }

            }
        }

        private void cbEmp1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            for (int i = 0; i < ListEmploye.Count; i++)
            {
                if (ListEmploye[i].Lname == cbEmp1.Text)
                {
                   comboBox4.Items.Add(ListEmploye[i].Name); comboBox4.Text = ListEmploye[i].Name;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox5.Text = "";
        }

        private void label20_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Waybill_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
