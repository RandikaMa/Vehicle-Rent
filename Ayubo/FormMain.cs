using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Ayubo
{
    public partial class FormMain : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='ayubo';username=root;password=root");

        MySqlDataAdapter adapter;

        DataTable table = new DataTable();
        MySqlDataAdapter adapterB;

        DataTable tableB = new DataTable();
       

        DataTable tableC = new DataTable();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rtn_dt_Click(object sender, EventArgs e)
        {

        }

        private void rnt_dt_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            lbl_vhcl.Items.Clear();
            pckge.Items.Clear();
            adapter = new MySqlDataAdapter("SELECT vehicle_no FROM vehicle", connection);
            adapter.Fill(table);
            
            foreach(DataRow dr in table.Rows)
            {
                lbl_vhcl.Items.Add(dr["vehicle_no"].ToString());
            }
            adapterB = new MySqlDataAdapter("SELECT name FROM package", connection);
            adapterB.Fill(tableB);

            foreach (DataRow drt in tableB.Rows)
            {
                pckge.Items.Add(drt["name"].ToString());
            }
        }

        private void nic_Click(object sender, EventArgs e)
        {

        }
        
        
        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();


            string query = "INSERT INTO total_rent (vehicle_no,package,customer_name,total_price,rent_date,return_date) VALUES (@lbl_vhcl,@pckge,@cusnm,@tot,@rntdt,@rtrndt)";
            string query2 = "INSERT INTO customer (name,nic,address,phone) VALUES (@cusnm,@cus_nic,@cus_add,@cus_tp)";
            
            if(pckge.Text == "Day tour")
            {
                daycal();
            }else if(pckge.Text == "Long tour")
            {
                longcal();
            }
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@lbl_vhcl",lbl_vhcl.Text);
            cmd.Parameters.AddWithValue("@pckge", pckge.Text);
            cmd.Parameters.AddWithValue("@cusnm",cusnm.Text);
            cmd.Parameters.AddWithValue("@tot", "");
            cmd.Parameters.AddWithValue("@rntdt", Convert.ToDateTime(rntdt.Text));
            cmd.Parameters.AddWithValue("@rtrndt", Convert.ToDateTime(rtrndt.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Added");

            MySqlCommand cmd2 = new MySqlCommand(query2, connection);
            cmd2.Parameters.AddWithValue("@cusnm", cusnm.Text);
            cmd2.Parameters.AddWithValue("@cus_nic", cus_nic.Text);
            cmd2.Parameters.AddWithValue("@cus_add", cus_add.Text);
            cmd2.Parameters.AddWithValue("@cus_tp", cus_tp.Text);
            cmd2.ExecuteNonQuery();

            adapter = new MySqlDataAdapter("SELECT `vehicle_no`,`package`,`customer_name` FROM total_rent", connection);
           
         
            

            connection.Close();
        }
        public void daycal()
        {
            adapter = new MySqlDataAdapter("SELECT * FROM package WHERE `name` = '" + pckge.Text + "'", connection);
            adapter.Fill(tableC);
            int ext = 0;
            int waiting = 0;
            foreach (DataRow drt in tableC.Rows)
            {
                var day = drt["package_price"];
                var mxkmm = drt["max_km"];
                var exprce = drt["extra_price_per_km"];
                int end = int.Parse(endkm.Text);

                int start = int.Parse(strtkm.Text);

                int extrcal, maximKM, priceperKM, Total;

                maximKM = int.Parse(mxkm.Text);
                priceperKM = int.Parse(PriceKM.Text);
                extrcal = maximKM * priceperKM;
                int totalKM = end - start;
                if (end > 50)
                {
                   
                    ext = (totalKM - 50) * 50;
                }
                Total = extrcal + waiting + extrcal;
                totchrge.Text = Total.ToString();
                waitingchrge.Text = waiting.ToString();
                extrachrge.Text = ext.ToString();
                
            }
            
            
        }

        public void longcal()
        {
            adapter = new MySqlDataAdapter("SELECT * FROM package WHERE `name` = '" + pckge.Text + "'", connection);
            adapter.Fill(tableC);
            int ext = 0;
            int waiting = 0;
            foreach (DataRow drt in tableC.Rows)
            {
                var day = drt["package_price"];
                var mxkmm = drt["max_km"];
                var exprce = drt["extra_price_per_km"];
                int end = int.Parse(endkm.Text);

                int start = int.Parse(strtkm.Text);

                int extrcal, maximKM, priceperKM, Total;

                maximKM = int.Parse(mxkm.Text);
                priceperKM = int.Parse(PriceKM.Text);
                extrcal = maximKM * priceperKM;
                int totalKM = end - start;
                if (end > 100)
                {

                    ext = (totalKM - 100) * 100;
                }
                Total = extrcal + waiting + extrcal;
                totchrge.Text = Total.ToString();
                waitingchrge.Text = waiting.ToString();
                extrachrge.Text = ext.ToString();

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
