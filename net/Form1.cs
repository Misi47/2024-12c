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
using System.IO;

namespace net
{
    public partial class Form1 : Form
    {
        MySqlConnection mysqlConn;
        MySqlAttributeCollection formState;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void mysqlConnect()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "iktat";
            try
            {
                mysqlConn = new MySqlConnection(sb.ToString());
                mysqlConn.Open();
                MessageBox.Show(openSikeres);
                /*
                var formState = formState.Opened;
                buttonSwitch(formState);
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{openNemSikeres}\n{ex.Message}");
            }


        }

    }
}