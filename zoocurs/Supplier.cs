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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label4.BackColor = System.Drawing.Color.Transparent;
     
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.lbhead.BackColor = System.Drawing.Color.Transparent;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            DateTime date = new DateTime();
            string dater = date.ToShortDateString();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform f = new mainform();
            f.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public List<ClassSupplier> ListSup = new List<ClassSupplier>();
        ClassDataBase db = new ClassDataBase();
        public void Load_Data()
        {
            string q = @"select id_sp, name_f, f_phone, manager, data_c, activ from supplier;";
            db.Execute<ClassSupplier>("zoo.db", q, ref ListSup);
        }
        public void Show_Data()
        {
            for (int i = 0; i < ListSup.Count; i++)
            {
                dvgSup.Rows.Add( ListSup[i].Name, ListSup[i].Phone, ListSup[i].Pib, ListSup[i].Data, ListSup[i].Activ);

            }
        }
    
            private void Supplier_Load(object sender, EventArgs e)
        {
            Load_Data();
            Show_Data();

        }
        public void SaveDataToDB()
        {
            ClassSupplier a = new ClassSupplier();
           a.Name= textBox1.Text;
            a.Pib = textBox3.Text;
            a.Phone = textBox2.Text;
            a.Data = Convert.ToString(dateTimePicker1.Text);
            a.Activ = '+';
            ListSup.Add(a);
            string q = @"Insert into supplier(name_f,f_phone,manager,data_c,activ) values('" + a.Name + @"', '" + a.Phone + @"', '" + a.Pib + @"', '" + Convert.ToString(a.Data) + @"', '" + a.Activ+ @"')";
            db.ExecuteNonQuery("zoo.db", q, 0);
            dvgSup.Rows.Add(a.Name, a.Phone, a.Pib, a.Data,a.Activ);


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
             if (dateTimePicker1.Value > DateTime.Today)
                {
                    MessageBox.Show("Вы не можете ввести дату больше сегодняшней");
                    dateTimePicker1.Value = DateTime.Today;
                }
        }

        private void addtobasket_Click(object sender, EventArgs e)
        {
            SaveDataToDB();
        }

        private void Supplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
