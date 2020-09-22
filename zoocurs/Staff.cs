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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
           
            this.lbhead.BackColor = System.Drawing.Color.Transparent;
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;

            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            DateTime date = new DateTime();
            string dater = date.ToShortDateString();

        }
        public List<ClassPost> ListclassPost = new List<ClassPost>();
        public List<Employe> ListEmploye = new List<Employe>();
        ClassDataBase db = new ClassDataBase();
        public void Load_Data()
        {
            string q = @"select id_p, p_name from positionn";
            db.Execute<ClassPost>("zoo.db", q, ref ListclassPost);
            string r = @"select a.id_s, a.name_s, a.lname_s, a.n_phone, a.stan, a.birthday, v.p_name from staff a join positionn v on a.s_id_p=v.id_p;";
            db.Execute<Employe>("zoo.db", r, ref ListEmploye);
        }
        public void Show_Data()
        {
            for(int i=0;i<ListclassPost.Count;i++)
            {
                { 
                    cbPost1.Items.Add(ListclassPost[i].Name);
                    cbPost2.Items.Add(ListclassPost[i].Name);

                }
               
                cbPost1.Text = ListclassPost[0].Name;
                cbPost2.Text = ListclassPost[0].Name;

            }
            for (int i = 0; i < ListEmploye.Count; i++)
            {
                dvgEmpl.Rows.Add(ListEmploye[i].Name, ListEmploye[i].Lname,  ListEmploye[i].Stan, ListEmploye[i].Post);

             }
           
        }
       
    
        private void btnback_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            mainform f = new mainform();
            f.Show();
        }

     

      public bool CheckDataEml()
        {
            if (textBox1.Text.Trim() == "") { MessageBox.Show(@"Имя-обязательное поле для заполнения. Пожалуйста введите значение", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error);return false; }
                if(textBox2.Text.Trim()=="") { MessageBox.Show(@"Фамилия-обязательное поле для заполнения. Пожалуйста введите значение", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            if (textBox3.Text.Trim()=="") { MessageBox.Show(@"Телефон-обязательное поле для заполнения. Пожалуйста введите значение", "Сообщение об ошибке", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
            return true;
        }
   
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {  
            if (dateTimePicker1.Value > DateTime.Today)
            { MessageBox.Show("Вы не можете ввести дату больше сегодняшней");
                dateTimePicker1.Value = DateTime.Today; }
        
        }
        private int getIDPost(string post)
        {
            for (int i = 0; i < ListclassPost.Count; i++)
                if (ListclassPost[i].Name == post) return ListclassPost[i].ID;
            return -1;
        }
        public  void SaveDatatoDB()
        {
            if(CheckDataEml())
            {
                Employe emp = new Employe();
                emp.Name = textBox1.Text.Trim();
                emp.Lname= textBox2.Text.Trim();
                emp.Phone= textBox3.Text.Trim();
                emp.Stan = comboBox2.Text;
                emp.Data = dateTimePicker1.Text;
                emp.Post = cbPost1.Text;
                ListEmploye.Add(emp);
                string q = @"Insert into staff (name_s,lname_s,n_phone,stan,birthday,s_id_p) values('" + emp.Name + @"', '" + emp.Lname + @"', " + emp.Phone + @", '" + emp.Stan + @"', '" + Convert.ToString(emp.Data) + @"', " + Convert.ToString(getIDPost(cbPost1.Text)) + @")";
                db.ExecuteNonQuery("zoo.db", q, 0);
                dvgEmpl.Rows.Add(emp.Name, emp.Lname, emp.Stan, emp.Post);
               
            }
        }
        private void Staff_Load(object sender, EventArgs e)
        {
            Load_Data();
            Show_Data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassPost p = new ClassPost();
            p.Name = cbPost2.Text;
            ListclassPost.Add(p);
            string q = @"INSERT INTO positionn (p_name) VALUES ('" + p.Name + @"');";
            db.ExecuteNonQuery("zoo.db",q, 0);
            cbPost2.Items.Add(p.Name);
        }

        private void addtobasket_Click(object sender, EventArgs e)
        {
            SaveDatatoDB();
        }

        private void dvgEmpl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private int GetEmploye(string name, string lname)
        {
            for (int i = 0; i < ListEmploye.Count; i++)
            {
                if (ListEmploye[i].Name == name && ListEmploye[i].Lname == lname) return ListEmploye[i].ID;
            }
            return -1;
        }
        bool f = true;
        private void button4_Click(object sender, EventArgs e)
        {
            if (f == true)
            {
                int id = dvgEmpl.CurrentCell.RowIndex;
                groupBox3.Visible = true;
                string s = Convert.ToString(dvgEmpl.Rows[id].Cells[0].Value);
                string b = Convert.ToString(dvgEmpl.Rows[id].Cells[1].Value);
                int k = GetEmploye(s, b);
                for (int i = 0; i < ListEmploye.Count; i++)
                {
                    if (k == ListEmploye[i].ID)
                    { dataGridView1.Rows.Add(ListEmploye[i].Phone, ListEmploye[i].Data); break; };
                }
                f = false;
            }
            else
            {
                groupBox3.Visible = false;
                dataGridView1.Rows.Clear();
                f = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = dvgEmpl.CurrentCell.RowIndex;

            string s = Convert.ToString(dvgEmpl.Rows[id].Cells[0].Value);//имя
            string b = Convert.ToString(dvgEmpl.Rows[id].Cells[1].Value);//фамилия
            int k = GetEmploye(s, b);
            if (comboBox1.Text != "")
            {    string r = comboBox1.Text;
                string l = @"Update staff a set a.stan='" + r + "' where a.id_s=" + k + ";";
                db.ExecuteNonQuery("zoo.db", l, 0);
                MessageBox.Show("Статус сотрудника изменен. Обновите страницу для просмотра!");

            }
            else MessageBox.Show("Введите статус!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Staff a = new Staff();
            this.Hide();
            a.Show();
        }

        private void Staff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
