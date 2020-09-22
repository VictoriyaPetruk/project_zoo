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
    public partial class mainform : Form
    {
        
        public mainform()
        {
            InitializeComponent();
            this.btnbasket.BackColor = System.Drawing.Color.Transparent;
            this.lbcreate.BackColor = System.Drawing.Color.Transparent;
            ToolTip t = new ToolTip();
            t.SetToolTip(btnbasket, "Перейти в корзину");
         
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            DateTime date = new DateTime();
            string dater = date.ToShortDateString();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnbasket_Click(object sender, EventArgs e)
        {
           
            basketfrm b = new basketfrm(this);
            this.Hide();
            b.Show();
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addtobasket_Click(object sender, EventArgs e)
        {
             
            SaveDatatoDB();
            
           
        }

        private void животныеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Animals f = new Animals();
            f.Show();
        }



        private void продажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sell f = new Sell();
            f.Show();
        }

        private void накладнаяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Waybill f = new Waybill();
            f.Show();
        }

        private void информацияПроПоставщиковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supplier f = new Supplier();
            f.Show();
        }



        private void проПриложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aboutapplication f = new Aboutapplication();
            f.Show();
        }




        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnclean_Click(object sender, EventArgs e)
        {

        }

        private void персоналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff f = new Staff();
            f.Show();
        }

        private void животныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Animals f = new Animals();
            f.Show();
        }
        public List<Employe> ListEmploye = new List<Employe>();
        public List<ClassAnimals> ListAnimals = new List<ClassAnimals>();
        public List<ClassSell> ListSell = new List<ClassSell>();
        public List<ClassBill> ListBill = new List<ClassBill>();
        ClassDataBase db = new ClassDataBase();
        public bool f = true;
        public void Load_Data()
        {
            string r = @"select a.id_a, a.kind, a.vid, a.sex, a.price, v.name_v, a.a_data, a.food, a.count_a  from vaccine v join animals a on a.a_id_v=v.id_v;";
            db.Execute<ClassAnimals>("zoo.db", r, ref ListAnimals);
            string q = @"select a.id_s, a.name_s, a.lname_s, a.n_phone, a.stan, a.birthday, v.p_name from staff a join positionn v on a.s_id_p=v.id_p;";
            db.Execute<Employe>("zoo.db", q, ref ListEmploye);
        }

        public void Show_Data()
        {
            for (int i = 0; i < ListAnimals.Count; i++)
            {    
                if(!cbanimals.Items.Contains(ListAnimals[i].Name))
                cbanimals.Items.Add(ListAnimals[i].Name);
            }

            for (int i = 0; i < ListEmploye.Count; i++)
            {  if (ListEmploye[i].Stan == "працює" && ListEmploye[i].Post!= "доглядач за тваринами")
                {
                    comboBox4.Items.Add(ListEmploye[i].Name);
                }
            }

        }
        private void mainform_Load(object sender, EventArgs e)
        {
            Load_Data();
            Show_Data();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbvid.Items.Clear();
            comboBox5.Text = "";
            textBox1.Text = "";

            for (int i = 0; i < ListAnimals.Count; i++)
            {
                if (ListAnimals[i].Name == cbanimals.Text)
                {
                    if (!cbvid.Items.Contains(ListAnimals[i].Vid))
                    {  cbvid.Items.Add(ListAnimals[i].Vid); cbvid.Text = ListAnimals[i].Vid; }
                }

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox6.Items.Clear();
            for (int i = 0; i < ListEmploye.Count; i++)
            {
                if (ListEmploye[i].Name == comboBox4.Text)
                {
                     comboBox6.Items.Add(ListEmploye[i].Lname); comboBox6.Text = ListEmploye[i].Lname;
                }
            }
        }
        public bool CheckDataEml()
        {
            if (textBox1.Text.Trim() == "") { MessageBox.Show(@"Введите все данные.", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (comboBox5.Text == "") { MessageBox.Show(@"Колличество-обязательное поле для заполнения. Пожалуйста введите значение", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
   
            if(cbanimals.Text=="") { MessageBox.Show(@"Название животного-обязательное поле для заполнения. Пожалуйста введите значение", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (comboBox4.Text == "") { MessageBox.Show(@"Соотрудник-обязательное поле для заполнения. Пожалуйста введите значение", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            return true;
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            double k = 1;
            for (int i = 0; i < ListAnimals.Count; i++)
            {
                if (cbanimals.Text == ListAnimals[i].Name && cbvid.Text == ListAnimals[i].Vid && cbsex.Text==ListAnimals[i].Sex)
                {   if (Convert.ToInt32(comboBox5.Text) <= ListAnimals[i].Presence)
                    {
                        k = Convert.ToDouble(comboBox5.Text);
                        k = k * ListAnimals[i].Price;
                        string s = Convert.ToString(k);
                        textBox1.Text = string.Format(s);
                    }
                    else
                    {
                       
                        MessageBox.Show("Такого товара нет в таком колличестве!");

                        textBox1.Text = "";
                        comboBox5.Text = "";
                    }

                }
            }
        }
        private int GetEmploye(string name,string lname)
        {
            for (int i = 0; i < ListEmploye.Count; i++)
            { if (ListEmploye[i].Name == name && ListEmploye[i].Lname==lname) return ListEmploye[i].ID;
            }
            return -1;
        }
        private  int GetAnimals(string a,string vid,string sex)
        { for(int i=0;i<ListAnimals.Count;i++)
             if(ListAnimals[i].Name==a && ListAnimals[i].Vid==vid && ListAnimals[i].Sex==sex)
                    return ListAnimals[i].ID;
              return -1;
        }
       
        public void DataloadSell()
        {
            if (f == true)
            {
                string q = @"select a.id_sell,a.data_sell,b.name_s,b.lname_s from sell a natural join staff b order by a.id_sell desc limit 1;";
                db.Execute<ClassSell>("zoo.db", q, ref ListSell);
            }
           
        }
        public void Sellsave()
        {
            if (f == true)
            {
                ClassSell s = new ClassSell();
                s.Data_s = dateTimePicker1.Text;
                s.EmployeName = comboBox4.Text;
                s.EmployeLname = comboBox6.Text;
                ListSell.Add(s);
                string q = @"Insert into sell(data_sell,id_s) values('" + Convert.ToString(s.Data_s) + @"'," + Convert.ToString(GetEmploye(comboBox4.Text, comboBox6.Text)) + @")";
                db.ExecuteNonQuery("zoo.db", q, 0);

            }

        }
        public void SaveDatatoDB()
        {
            if (CheckDataEml())
            {
               
                ClassBill b = new ClassBill();
                
                    Sellsave();
                    DataloadSell();
                    f = false;
              
                b.Animals = cbanimals.Text;
                b.Vid = cbvid.Text;
                b.Sale = 0;
                b.Sex = cbsex.Text;
                b.Count =Convert.ToInt32( comboBox5.Text);
                b.Id_s = ListSell[1].ID;
                string k= @"Insert into bill(id_a,sale,count,id_sell) values('" + Convert.ToString(GetAnimals(cbanimals.Text, cbvid.Text, cbsex.Text)) + @"'," + b.Sale + @"," + b.Count+@"," + b.Id_s+@")";
                db.ExecuteNonQuery("zoo.db", k, 0);
                string l= @"Update animals a set a.count_a=a.count_a-" + b.Count + " where kind="+ b.Animals + " and vid=" + b.Vid + " and sex=" + b.Sex + ";";
                db.ExecuteNonQuery("zoo.db", l, 0);
                this.comboBox4.Enabled = false;
                this.comboBox6.Enabled = false;
                MessageBox.Show("Животное добавленно в корзину");
                for (int i = 0; i < ListAnimals.Count; i++)
                {
                    if (cbanimals.Text == ListAnimals[i].Name && cbvid.Text == ListAnimals[i].Vid && cbsex.Text == ListAnimals[i].Sex)
                    {
                        ListAnimals[i].Presence -= Convert.ToInt32( comboBox5.Text);
                    }
                }
                comboBox5.Text = "";
                cbanimals.Text = " ";
                cbvid.Text = "";
                textBox1.Text = "";
                button1.Visible = true;
                btnbasket.Enabled = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.comboBox4.Enabled = true;
            this.comboBox6.Enabled = true;
            f = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult resualt = MessageBox.Show("Вы уверены,что хотите удалить заказ?", "Удалить", MessageBoxButtons.YesNo);
            if (resualt.ToString() == "Yes")
            {
                f = true;
                comboBox4.Enabled = true;
                comboBox6.Enabled = true;
                string s = Convert.ToString(ListSell[1].ID);
                string l = @"Update animals a,bill b  set a.count_a=a.count_a+b.count where a.id_a=b.id_a and b.id_sell="+s+";";
                db.ExecuteNonQuery("zoo.db", l, 0);
                string k = @"delete from sell a  where a.id_sell=" + s + ";";
                db.ExecuteNonQuery("zoo.db", k, 0);
                ListSell.Clear();
                MessageBox.Show("Заказ отменен");
                button1.Visible = false;
                btnbasket.Enabled = false;
            }
            //add delete sell and bill
            mainform a= new mainform();
            this.Hide();
            a.Show();
          
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox5.Text = "";
            textBox1.Text = "";
            

        }

        private void menumain_Click(object sender, EventArgs e)
        {

        }

        private void mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
