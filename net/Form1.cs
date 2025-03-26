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
        #region Kapcsolat properties
        private MySqlConnection mysqlConn;
        private MySqlDataReader mySqlDr;
        #endregion kapcsolat properties

        #region Üzenet szövegek
        private string openSikeres = "A kapcsolódás az adatbázishoz sikeres!", openNemSikeres = "A kapcsolódás az adatbázishoz sikertelen!", cantoRead = "Az olvasás sikeres", closeDB = "Az adatbázis lezárva";
        #endregion Üzenet vége
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

        private void button6_Click(object sender, EventArgs e)
        {
            mysqlConn.Close();
            MessageBox.Show(closeDB);
        }
        #region Form és adatbázis állapotai
        private enum FormState
        {
            Closed, //Zárva, nincs csatlakozva
            Opened, //Csatlakozva, nincs olvasás
            Reading, //Olvasás közben
            EditInsert, //Beszúrás
            EditUpdate, //Rekord szerkesztés
        }
        private FormState formstate = FormState.Closed;
        #endregion a Form és az adatbázis állapotai

        #region Gomb feliratai
        private string insBasic = "Beszúrás";
        private string insEdit = "Szerkesztés vége";
        private string updBasic = "Módosítás";
        private string updEdit = "Módisítás vége";
        #endregion Gomb feliratai

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mysqlConnect();
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