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

namespace PratikumWeek13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtPlayer = new DataTable();
        int PosisiSekarang = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "select p.player_id,p.player_name, date_format(p.birthdate,'%W, %M %d, %Y') as 'BirthDate' ,n.nation as 'Nationality',t.team_name as 'TeamName',p.team_number from player p, team t, nationality n where p.team_id = t.team_id and p.nationality_id = n.nationality_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);
            cb_nation.DataSource = dtPlayer;
            
            cb_nation.ValueMember = "Nationality";
            cb_nation.DisplayMember = "Nationality";
            cb_team.DataSource = dtPlayer;
            
            cb_team.ValueMember = "TeamName";
            cb_team.DisplayMember = "TeamName";

            dtp_birthdate.CustomFormat ="dddd, MMMM dd, yyyy";
            dtp_birthdate.Format = DateTimePickerFormat.Custom;
            lokasi(0);
        }

        public void lokasi(int Posisi)
        {
            
            tb_playerID.Text = dtPlayer.Rows[Posisi][0].ToString();
            tb_Name.Text = dtPlayer.Rows[Posisi][1].ToString();
            dtp_birthdate.Text = dtPlayer.Rows[Posisi][2].ToString();
            cb_nation.Text = dtPlayer.Rows[Posisi][3].ToString();
            cb_team.Text = dtPlayer.Rows[Posisi][4].ToString();
            nud_TeamNumber.Text = dtPlayer.Rows[Posisi][5].ToString();
            //if()
                
            PosisiSekarang = Posisi;
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            lokasi(0);
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                lokasi(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < dtPlayer.Rows.Count - 1)
            {
                PosisiSekarang++;
                lokasi(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            lokasi(dtPlayer.Rows.Count - 1);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
            if(lbl_avail.Text == "Not Available")
            {
                MessageBox.Show("Team Number Sama");
            }
            else
            {
                sqlConnect.Open();
                sqlQuery = "UPDATE player p, team t, nationality n SET p.player_id = '" + tb_playerID.Text + " ',  p.player_name = '" + tb_Name.Text + "',  BirthDate = '" + dtp_birthdate.Text + "',  n.nation = '" + cb_nation.Text + "', t.team_name = '" + cb_team.Text + "',p.team_number = '" + nud_TeamNumber.Text + "' WHERE p.team_id = t.team_id and p.nationality_id = n.nationality_id and player_id = '" + tb_playerID.Text + "'; ";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                DataTable dtPlayer = new DataTable();
                sqlConnect.Close();
                MessageBox.Show("Data telah terupdate");
            }
           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nud_TeamNumber_ValueChanged(object sender, EventArgs e)
        {
           // if(nud_TeamNumber.Value == nud_TeamNumber.Value)
           // {
           //   lbl_avail.Text == "Not Available";
           // }
           // else 
           // {
           //    lbl_avail.Text == "Available";
           // }
        }
    }
}
