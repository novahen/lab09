using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g374_l09_Tsvetkov_Zhukov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g374_Tsvetkov_ZhukovDataSet.l09_Planets' table. You can move, or remove it, as needed.
            this.l09_PlanetsTableAdapter.Fill(this.g374_Tsvetkov_ZhukovDataSet.l09_Planets);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=sql.wsr;Initial Catalog=g374_Tsvetkov_Zhukov;Persist Security Info=True;User ID=student;Password=student";
            SqlConnection con = new SqlConnection(constr); //подключение к БД
            con.Open();

            string sql = "SELECT PlanetName, DistanceFromSun FROM l09_Planets;";
            SqlCommand cmd = new SqlCommand(sql, con); //Выполнение запроса на выборку данных

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read()) //Чтение результатов
            {
                string name = rdr.GetString(0);
                float dist = (float) rdr.GetDouble(1);

                MessageBox.Show(name + " " + dist.ToString());
            }
            rdr.Close();

            con.Close();
        }

       
    }
}
