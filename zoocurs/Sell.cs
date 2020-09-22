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
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
            
          
            this.btnback.BackColor = System.Drawing.Color.Transparent;
           
            this.lbhead.BackColor = System.Drawing.Color.Transparent;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform f = new mainform();
            f.Show();
        }
        public List<InfoSell> ListInfo = new List<InfoSell>();
        ClassDataBase db = new ClassDataBase();
        public void Load_Data()
        {
            string q = @"select  monthname(s.data_sell),a.kind, a.vid, Sum(b.count),a.price*Sum(b.count) from sell s natural join bill b natural join animals a group by 1,2,3;";
            db.Execute<InfoSell>("zoo.db", q, ref ListInfo);
            
        }
        public void Show_Data()
        {
            for(int i=0;i<ListInfo.Count;i++)
            {
                dataGridView1.Rows.Add(ListInfo[i].Date, ListInfo[i].Name, ListInfo[i].Vid, ListInfo[i].Count, ListInfo[i].Sum);
            }
        }
            private void Sell_Load(object sender, EventArgs e)
        {
            Load_Data();
            Show_Data();
        }

        private void addtobasket_Click(object sender, EventArgs e)
        {
            ClassSerialiaze.SerialiazeToXml<List<InfoSell>>(ref ListInfo, "data.xml");
            SellReport frmReport = new SellReport();
            frmReport.ShowDialog();
        }

        private void Sell_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
