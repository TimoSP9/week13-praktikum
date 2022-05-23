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

namespace week13_praktikum
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=localhost;uid=root;pwd=; database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        public DataTable Data = new DataTable();
        public int tempat = 0;
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "select p.player_id, p.player_name, p.birthdate, n.nation, t.team_name, p.team_number, t.team_id from player p, team t, nationality n where p.nationality_id = n.nationality_id and p.team_id = t.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Data);

            cb_team.DataSource = Data;
            cb_team.ValueMember = "team_name";
            cb_team.DisplayMember = "team_name";

            cb_nation.DataSource = Data;
            cb_nation.ValueMember = "nation";
            cb_nation.DisplayMember = "nation";
            dataaja();
        }
        private void dataaja()
        {
            date_birth.Value = Convert.ToDateTime(Data.Rows[tempat]["birthdate"]);
            tb_playerid.Text = Data.Rows[tempat]["player_id"].ToString();
            tb_playername.Text = Data.Rows[tempat]["player_name"].ToString();
            cb_nation.DisplayMember = Data.Rows[tempat]["nation"].ToString();
            cb_team.DisplayMember = Data.Rows[tempat]["team_name"].ToString();
            num_team.Value = Convert.ToInt16(Data.Rows[tempat]["team_number"]);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        
        private void btn_prev_Click(object sender, EventArgs e)
        {
            tempat--;
            if (tempat < 0)
            {
                tempat = tempat + 1;
                dataaja();
                MessageBox.Show("Data sudah di awal!");
            }
            else
            {
                dataaja();
            }
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            tempat++;
            if (tempat > 858)
            {
                tempat = tempat - 1;
                dataaja();
                MessageBox.Show("Data sudah di akhir!");
            }
            else
            {
                dataaja();
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            try
            {
                tempat = 0;
                dataaja();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data sudah di awal!");
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            try
            {
                tempat = 858;
                dataaja();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data sudah di akhir!");
            }

        }
    }
}
