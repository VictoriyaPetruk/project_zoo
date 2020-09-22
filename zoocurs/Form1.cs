using MySql.Data.MySqlClient;
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
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
            this.lblog.BackColor = System.Drawing.Color.Transparent;
            this.lbpas.BackColor = System.Drawing.Color.Transparent;
            this.pbuser.BackColor = System.Drawing.Color.Transparent;
            this.pBlock.BackColor = System.Drawing.Color.Transparent;
        }

       

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btsign_Click(object sender, EventArgs e)
        {
            LogIn();
        }

       
        private void LogIn()
        {
            string loginuser = tblog.Text;
            string passuser = tbpas.Text;
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `enter` WHERE `login`=@log AND `password`=@pas", db.getconn());
            command.Parameters.Add("@log", MySqlDbType.VarChar).Value = loginuser;
            command.Parameters.Add("@pas", MySqlDbType.VarChar).Value = passuser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                this.Hide();
                mainform f = new mainform();
                f.Show();

            }
            else MessageBox.Show("Такого пользователя нет в системе или неверный пароль", "Ошибка входа",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Autorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
