using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace JLPT_Trainer
{
    public partial class frmSignIn : Form
    {
        List<int> users_id = new List<int>();
        List<string> users_name = new List<string>();
        List<int> users_level = new List<int>();
        int index;

        public frmSignIn()
        {
            InitializeComponent();
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            // https://www.codeproject.com/Articles/1210189/Using-SQLite-in-Csharp-VB-Net#SQLite%20Limitations
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;
            SQLiteDataReader sqlite_datareader;

            sqlite_conn = new SQLiteConnection("Data Source=dict_db.db;Version=3;");
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Users";
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                users_id.Add(sqlite_datareader.GetInt32(0));
                users_name.Add(sqlite_datareader.GetString(1));
                users_level.Add(sqlite_datareader.GetInt32(2));
            }

            sqlite_conn.Close();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            btnCreate.Enabled = false;
            btnSign.Enabled = false;

            int i = 0;
            foreach (string name in users_name)
            {
                if (tbName.Text == name)
                {
                    btnCreate.Enabled = false;
                    btnSign.Enabled = true;
                    index = i;
                    break;
                }
                else
                {
                    btnCreate.Enabled = true;
                    btnSign.Enabled = false;
                }
                i++;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            SQLiteCommand sqlite_cmd;

            sqlite_conn = new SQLiteConnection("Data Source=dict_db.db;Version=3;");
            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = $"INSERT INTO Users (Name, LearningLevel) VALUES ('{tbName.Text}', 5);";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();
            tbName.Clear();
            frmSignIn_Load(sender, e);
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            UserGlobal.UID = users_id[index];
            UserGlobal.Name = users_name[index];
            UserGlobal.Level = users_level[index];
            this.Hide();
        }
    }
}
