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
    public partial class basketfrm : Form
    {
        mainform a;
        public basketfrm()
        {  
            InitializeComponent();
            this.btnclean.BackColor = System.Drawing.Color.Transparent;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.lbhead.BackColor = System.Drawing.Color.Transparent;
        }
        public basketfrm(mainform a)
        {
            this.a = a;
            InitializeComponent();
            this.btnclean.BackColor = System.Drawing.Color.Transparent;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.lbhead.BackColor = System.Drawing.Color.Transparent;
        }
        private void btnorder_Click(object sender, EventArgs e)
        {
 
            DialogResult resualt = MessageBox.Show("Покупатель оплатил заказ?", "Покупка", MessageBoxButtons.YesNo);
            if(resualt.ToString()=="yes") MessageBox.Show("Покупка успешна");
            else MessageBox.Show("Покупка не успешна"); 
        }

        private void btnback_Click(object sender, EventArgs e)
        { 
            this.Hide();
            a.Show();
        }

        private void addtobasket_Click(object sender, EventArgs e)
        {
            DialogResult resualt = MessageBox.Show("Покупатель оплатил заказ?", "Покупка", MessageBoxButtons.YesNo);
            if (resualt.ToString()=="Yes")
            {
              DialogResult resualtе = MessageBox.Show("Распечатать чек?", "Чек", MessageBoxButtons.YesNo);
                if (resualtе.ToString() == "Yes")
                { 
                    ClassSerialiaze.SerialiazeToXml<List<Order>>(ref ListOrder1, "bill.xml");
                    BillReport frmReport = new BillReport();
                    frmReport.ShowDialog();
                }
                else MessageBox.Show("Чек не создан!");
                a.f = true;
                a.ListSell.Clear();
                a.comboBox4.Enabled = true;
                a.comboBox6.Enabled = true;
                MessageBox.Show("Покупка успешна"); this.Hide();
                Bill b = new Bill();
                b.Show();
            }
            else MessageBox.Show("Покупка не успешна.Вернитесь на главную страницу, чтобы отменить заказ");
        }
        public List<Order> ListOrder = new List<Order>();
        public List<Order> ListOrder1 = new List<Order>();
        ClassDataBase db = new ClassDataBase();
   
        public void Load_Data()
        {
            string q = @"select b_id, a.kind,a.vid,a.sex,b.count,a.price,b.id_sell,a.price from animals a natural join bill b";
            db.Execute<Order>("zoo.db", q, ref ListOrder);
            
        }
        public void Show_Data()
        {
            int max = ListOrder[0].Id_s;
            for(int i=0;i<ListOrder.Count;i++)
            {
                if(ListOrder[i].Id_s>max)
                {
                    max = ListOrder[i].Id_s;
                }
            }
            double S = 0;
            for (int i = 0; i < ListOrder.Count; i++)
            {
                if (ListOrder[i].Id_s == max)
                {
                    double k= ListOrder[i].Price * ListOrder[i].Count;
                    dvgOrder.Rows.Add(ListOrder[i].Name, ListOrder[i].Vid, ListOrder[i].Sex, ListOrder[i].Count,k, ListOrder[i].Id);
                    S = S + k;
                    Order a = new Order();
                    a.Name = ListOrder[i].Name;
                    a.Vid = ListOrder[i].Vid;
                    a.Sex = ListOrder[i].Sex;
                    a.Count = ListOrder[i].Count;
                    a.Price = k;
                    a.Id = ListOrder[i].Id;
                    a.Sum = S;
                    ListOrder1.Add(a);

                }
        
            }
            textBox1.Text = Convert.ToString(S);
        }
          

        private void basketfrm_Load_1(object sender, EventArgs e)
        {
            Load_Data();
            Show_Data();
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            int id = dvgOrder.CurrentCell.RowIndex;
            string s = @"delete from bill where b_id="+dvgOrder.Rows[id].Cells[5].Value +"";
            db.ExecuteNonQuery("zoo.db",s , 0);
            int k = Convert.ToInt32(dvgOrder.Rows[id].Cells[5].Value);
            int l = 0;
            for(int i=0;i<ListOrder.Count;i++)
            {
                if (ListOrder[i].Id == k)
                    l = i;
            }
            ListOrder.Remove(ListOrder[l]);
            dvgOrder.Rows.Clear();
            Show_Data();

        }

        private void basketfrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
