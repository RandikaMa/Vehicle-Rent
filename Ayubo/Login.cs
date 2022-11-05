using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ayubo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='ayubo';username=root;password=root");

        MySqlDataAdapter adapter;

        DataTable table = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("SELECT `name`, `password` FROM `user` WHERE `name` = '" + user_name.Text + "' AND `password` = '" + pass.Text + "'", connection);
            adapter.Fill(table);

            if (table.Rows.Count <= 0)
            {
                panel1.Height = 0;
                msg.ForeColor = Color.Red;
                msg.Text = "Username Or Password Are Invalid";
                timer1.Start();
            }
            else
            {
                panel1.Height = 0;
                msg.ForeColor = Color.Green;
                msg.Text = "Login Successfully";
                timer1.Start();
            }

            table.Clear();
        }
      

        private void user_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            timer2.Start();
            this.Hide();
            FormMain fm = new FormMain();
            fm.ShowDialog();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (panel1.Height != 100)
            {
                panel1.Height = panel1.Height + 5;
                if (panel1.Height == 100)
                {
                    timer1.Stop();
                    
                }
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (panel1.Height != 0)
            {
                panel1.Height = panel1.Height - 5;
                if (panel1.Height == 0)
                {
                    timer2.Stop();
                }
            }
        }
    }
}
