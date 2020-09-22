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
    public partial class Animals : Form
    {
        public Animals()
        {
            InitializeComponent();
          
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.lbhead.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
        
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy-MM-dd";
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "yyyy-MM-dd";
            DateTime date = new DateTime();
            string dater = date.ToShortDateString();
              this.groupBox4.BackColor = System.Drawing.Color.Transparent;
        }
        public List<ClassVaccine> ListclassVac = new List<ClassVaccine>();
        public List<ClassAnimals> ListAnimals = new List<ClassAnimals>();
        ClassDataBase db = new ClassDataBase();
        public void Load_Data()
        {
            string q = @"select id_v, name_v, v_data from vaccine";
            db.Execute<ClassVaccine>("zoo.db", q, ref ListclassVac);
            string r = @"select a.id_a, a.kind, a.vid, a.sex, a.price, v.name_v, a.a_data, a.food, a.count_a from vaccine v join animals a on a.a_id_v=v.id_v;";
            db.Execute<ClassAnimals>("zoo.db", r, ref ListAnimals);
        }
        public void Show_Data()
        {
            for (int i = 0; i < ListclassVac.Count; i++)
            {
                {
                    if (!cbVacin.Items.Contains(ListclassVac[i].Name))
                    {
                        cbVacin.Items.Add(ListclassVac[i].Name);
                      
                    }
                    if (!cbVacin1.Items.Contains(ListclassVac[i].Name))
                    {
                        cbVacin1.Items.Add(ListclassVac[i].Name);
                    }
                }
                cbVacin.Text = ListclassVac[1].Name;
                cbVacin1.Text = ListclassVac[1].Name;
               
            }
           
           for(int i=0;i<ListAnimals.Count;i++)
            {
                dvgAnimals.Rows.Add(ListAnimals[i].Name, ListAnimals[i].Vid, ListAnimals[i].Sex, ListAnimals[i].Price);
            }
          
            for (int i = 0; i <ListAnimals.Count; i++)
            {
                if (!cbanimals.Items.Contains(ListAnimals[i].Name))
                {
                    cbanimals.Items.Add(ListAnimals[i].Name);
                }
            }
            for (int i = 0; i < ListAnimals.Count; i++)
            {
                if (!comboBox2.Items.Contains(ListAnimals[i].Name))
                {
                    comboBox2.Items.Add(ListAnimals[i].Name);
                }
            }
            comboBox2.Text = ListAnimals[1].Name;
           
           
        }

        private void Animals_Load(object sender, EventArgs e)
        {
            Load_Data();
            Show_Data();
        }
        public bool CheckDataEml()
        {
            if (textBox1.Text.Trim() == "") { MessageBox.Show(@"Питание-обязательное поле для заполнения. Пожалуйста введите значение", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (textBox2.Text.Trim() == "") { MessageBox.Show(@"Цена-обязательное поле для заполнения. Пожалуйста введите значение", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            return true;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Today)
            {
                MessageBox.Show("Вы не можете ввести дату больше сегодняшней");
                dateTimePicker1.Value = DateTime.Today;
            }

        }
        private int getIDVaccine(string post)
        {
            for (int i = 0; i < ListclassVac.Count; i++)
                if (ListclassVac[i].Name == post) return ListclassVac[i].ID;
            return -1;
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform f = new mainform();
            f.Show();
        }
        public void SaveDatatoDB()
        {
            if (CheckDataEml())
            {
             ClassAnimals a = new ClassAnimals();
                a.Name = comboBox2.Text;
                a.Vid= comboBox3.Text;
                a.Sex = comboBox4.Text;
                try
                {
                    a.Price = Convert.ToDouble(textBox2.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Введите коректные данные","Сообщение об ошибке",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    textBox2.Text = "";
                  
                }
                    a.Vaccine = cbVacin1.Text;
                a.Data_p= dateTimePicker1.Text;
                a.Food = textBox1.Text;
                a.Presence = 0;
                ListAnimals.Add(a);
                string q = @"Insert into animals(kind,vid,sex,price,a_id_v,a_data,food,count_a) values('" + a.Name + @"', '" + a.Vid + @"', '" + a.Sex + @"', " + a.Price + @", " + Convert.ToString(getIDVaccine(cbVacin1.Text)) + @", '"+Convert.ToString(a.Data_p) + @"', '" + a.Food+ @"', '" +a.Presence+ @"')";
                db.ExecuteNonQuery("zoo.db", q, 0);
                dvgAnimals.Rows.Add(a.Name, a.Vid, a.Sex, a.Price);

            }
        }
        
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value > DateTime.Today)
            {
                MessageBox.Show("Вы не можете ввести дату больше сегодняшней");
                dateTimePicker2.Value = DateTime.Today;
            }
        }

        private void addtobasket_Click(object sender, EventArgs e)
        {
            SaveDatatoDB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           ClassVaccine p = new ClassVaccine();
            p.Name = cbVacin.Text;
            p.Data = dateTimePicker2.Text;
            ListclassVac.Add(p);
            string q = @"INSERT INTO vaccine (name_v,v_data) VALUES ('" + p.Name+@"', '"+p.Data + @"');";
            db.ExecuteNonQuery("zoo.db", q, 0);
            cbVacin.Items.Add(p.Name);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            
            for (int i = 0; i < ListAnimals.Count; i++)
            { if (ListAnimals[i].Name == comboBox2.Text)
                {
                    if (!comboBox3.Items.Contains(ListAnimals[i].Vid))
                    {
                        comboBox3.Text = ListAnimals[i].Vid; comboBox3.Items.Add(ListAnimals[i].Vid);
                    }
                }

            }
          

        }


      

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker4.Value > DateTime.Today)
            {
                MessageBox.Show("Вы не можете ввести дату больше сегодняшней");
                dateTimePicker4.Value = DateTime.Today;
            }
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker3.Value > DateTime.Today)
            {
                MessageBox.Show("Вы не можете ввести дату больше сегодняшней");
                dateTimePicker3.Value = DateTime.Today;
            }
        }
       
        private void cbanimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            double max = 0;
            double min = ListAnimals[0].Price;
            for (int i = 0; i < ListAnimals.Count; i++)
            {      
                if (ListAnimals[i].Name == cbanimals.Text)
                {  
                    if (ListAnimals[i].Price>=max)
                    { max = ListAnimals[i].Price; }
                   if (!comboBox1.Items.Contains(ListAnimals[i].Vid))
                    {
                        comboBox1.Items.Add(ListAnimals[i].Vid);
                        
                    }

                }
            }
            min = max;
                for (int i = 0; i < ListAnimals.Count; i++)
            {
                if (ListAnimals[i].Name == cbanimals.Text)
                {
                    if (ListAnimals[i].Price <= min)
                    {
                        min = ListAnimals[i].Price;
                    }
                }
            }
                textBox4.Text = Convert.ToString(max);
                textBox3.Text = Convert.ToString(min);
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            dvgAnimals.Rows.Clear();
            for (int i=0;i<ListAnimals.Count;i++)
            {
               
                if (ListAnimals[i].Checkfind(cbanimals.Text, comboBox1.Text, textBox3.Text.Trim(), textBox4.Text.Trim(), dateTimePicker3.Text, dateTimePicker4.Text) == true)
                {
                   
                    dvgAnimals.Rows.Add(ListAnimals[i].Name, ListAnimals[i].Vid, ListAnimals[i].Sex, ListAnimals[i].Price);
                }
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cbanimals.Items.Clear();
            dvgAnimals.Rows.Clear();
            comboBox1.Items.Clear();
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker4.Value = DateTime.Today;
            DateTime d = new DateTime(2020, 04, 20);
            dateTimePicker3.Value = d;
            for (int i = 0; i < ListAnimals.Count; i++)
            {
                if (!cbanimals.Items.Contains(ListAnimals[i].Name))
                { cbanimals.Items.Add(ListAnimals[i].Name); }
                dvgAnimals.Rows.Add(ListAnimals[i].Name, ListAnimals[i].Vid, ListAnimals[i].Sex, ListAnimals[i].Price, ListAnimals[i].Vaccine, ListAnimals[i].Data_p, ListAnimals[i].Food, ListAnimals[i].Presence);
            }
        }

       


        private int GetAnimals(string a, string vid, string sex)
        {
            for (int i = 0; i < ListAnimals.Count; i++)
                if (ListAnimals[i].Name == a && ListAnimals[i].Vid == vid && ListAnimals[i].Sex == sex)
                    return ListAnimals[i].ID;
            return -1;
        }
        bool f = true;
        private void button4_Click(object sender, EventArgs e)
        {  if (f == true)
            {   int id= dvgAnimals.CurrentCell.RowIndex;
                groupBox4.Visible = true;
                string s = Convert.ToString(dvgAnimals.Rows[id].Cells[0].Value);
                string b = Convert.ToString(dvgAnimals.Rows[id].Cells[1].Value);
                string a = Convert.ToString(dvgAnimals.Rows[id].Cells[2].Value);
                int k = GetAnimals(s,b,a);
                for (int i = 0; i < ListAnimals.Count; i++)
                {
                    if (k == ListAnimals[i].ID)
                    { dataGridView1.Rows.Add(ListAnimals[i].Vaccine, ListAnimals[i].Data_p, ListAnimals[i].Food, ListAnimals[i].Presence); break; };
                }
                f = false;
            }
            else
            {
                groupBox4.Visible = false;
                dataGridView1.Rows.Clear();
                f = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = dvgAnimals.CurrentCell.RowIndex;
            
            string s = Convert.ToString(dvgAnimals.Rows[id].Cells[0].Value);
            string b = Convert.ToString(dvgAnimals.Rows[id].Cells[1].Value);
            string a = Convert.ToString(dvgAnimals.Rows[id].Cells[2].Value);
            string c = Convert.ToString(dataGridView1.Rows[0].Cells[3].Value);
            
            int k = GetAnimals(s, b, a);
            if (comboBox5.Text != "")
            {
                int r = Convert.ToInt32(comboBox5.Text);
                if (r < Convert.ToInt32(c))
                {
                    string l = @"Update animals a set a.count_a=a.count_a-" + r + " where a.id_a=" + k + ";";
                    db.ExecuteNonQuery("zoo.db", l, 0);
                    MessageBox.Show("Животные списались. Обновите страницу для просмотра!");
                }
                else MessageBox.Show("Выбранное колличество перевышает существующие!");
            }
            else MessageBox.Show("Введите колличество!");
        }

        

       

        private void button6_Click(object sender, EventArgs e)
        {
            Animals a = new Animals();
            this.Hide();
            a.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Animals_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cbVacin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Today)
            {
                MessageBox.Show("Вы не можете ввести дату больше сегодняшней");
                dateTimePicker1.Value = DateTime.Today;
            }
        }
    }
}
