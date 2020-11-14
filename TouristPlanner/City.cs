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


namespace TouristPlanner
{
    public partial class City : Form
    {
        public int nodesInserted = 0;
        public City()
        {
            InitializeComponent();
        }

        private void City_Load(object sender, EventArgs e)
        {
            applyLanguage();
            getComboBoxes();
        }

        void applyLanguage()
        {
            this.Text = Resources.StringResources.ciudadTitle;
            lbl_cityName.Text = Resources.StringResources.ciudad_nombre;
            lbl_loc.Text = Resources.StringResources.ciudad_localizacion;
            lbl_coordx.Text = Resources.StringResources.ciudad_coordX;
            lbl_coordY.Text = Resources.StringResources.ciudad_coordY;
            lbl_existentCities.Text = Resources.StringResources.ciudad_existentes;
            btn_addCity.Text = Resources.StringResources.ciudad_altaCiudad;
            btn_deleteCity.Text = Resources.StringResources.ciudad_bajaCiudad;
            btn_changeCity.Text = Resources.StringResources.ciudad_cambiarDato;

        }

        private void btn_addCity_Click(object sender, EventArgs e)
        {
            string cityName = txt_cityName.Text.ToLower();
            int x = (int)num_x.Value;
            int y = (int)num_y.Value;

            string str = Properties.Settings.Default.Database1ConnectionString;

            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            //insert into db, if unique contraint pops then the catch is activated
            SqlCommand cmd = new SqlCommand("INSERT INTO Nodo(Ciudad,coord_x,coord_y) VALUES(" + "'"+ cityName + "'"+ "," + x + ","+ y + ");", cnn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(Resources.StringResources.box_ciudadAgregada);
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.StringResources.box_noDuplicates);
            }
            cnn.Close();
            this.Close();

        }

        private void btn_deleteCity_Click(object sender, EventArgs e)
        {
            string toDelete = cbx_existentCities.Text.ToLower();
            string str = Properties.Settings.Default.Database1ConnectionString;
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            //select to check if theres a city with that name, if not then error
            SqlCommand cmd = new SqlCommand("DELETE FROM Nodo WHERE Ciudad = " + "'" + toDelete + "'" + ";", cnn);
            //if it exists
            //try delete city, if it has routes catch the exception and tell him to delete route first
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(Resources.StringResources.box_ciudadEliminada);
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.StringResources.box_errorCiudadBorrar);
            }     
            cnn.Close();


            int newCount = 0;
            cnn = new SqlConnection(str);
            cnn.Open();
            cmd = new SqlCommand("SELECT MAX(IdNodo) FROM Nodo;", cnn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                newCount = (int)rdr[0];
            }
            rdr.Close();
            cnn.Close();
            

            cnn = new SqlConnection(str);
            cnn.Open();
            //select to check if theres a city with that name, if not then error
            cmd = new SqlCommand("DBCC CHECKIDENT(Nodo, RESEED," + newCount + ");", cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();

            this.Close();
        }
 
        private void btn_changeCity_Click(object sender, EventArgs e)
        {
            string toChange = cbx_existentCities.Text.ToLower();
            int x = (int)num_x.Value;
            int y = (int)num_y.Value;

            string str = Properties.Settings.Default.Database1ConnectionString;
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            //see if such city exists
            SqlCommand cmd = new SqlCommand("UPDATE Nodo SET coord_x = " + x + ","+ "coord_y = " + y + "WHERE Ciudad = "+ "'" + toChange + "'", cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show(Resources.StringResources.box_ciudadEditada);

            cnn.Close();
            this.Close();

        }

        void getComboBoxes()
        {
            string str = Properties.Settings.Default.Database1ConnectionString;
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Ciudad FROM Nodo", cnn);
            SqlDataReader rdr = cmd.ExecuteReader();
            cbx_existentCities.Items.Add("N/A");
            while (rdr.Read())
            {
                string city = rdr[0].ToString();
                city = char.ToUpper(city[0]) + city.Substring(1);
                cbx_existentCities.Items.Add(city);
            }
            rdr.Close();
            cnn.Close();
        }

        private void cbx_existentCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cityName.Enabled = false;
            if (cbx_existentCities.SelectedItem.ToString() == "N/A")
            {
                txt_cityName.Enabled = true;
            }
        }
    }
}