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
    public partial class Route : Form
    {
        public Route()
        {
            InitializeComponent();
        }

        private void Route_Load(object sender, EventArgs e)
        { 
            applyLanguage();
            getComboBoxes();
        }

        void getComboBoxes()
        {
            string str = Properties.Settings.Default.Database1ConnectionString;
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Ciudad FROM Nodo", cnn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                string city = rdr[0].ToString();
                city = char.ToUpper(city[0]) + city.Substring(1);
                cbx_startingCity.Items.Add(city);
                cbx_endingCity.Items.Add(city);
            }
            rdr.Close();
            cnn.Close();

            cbx_listedRoutes.Items.Add("N/A");
            cnn = new SqlConnection(str);
            cnn.Open();
            cmd = new SqlCommand("SELECT Carretera FROM Arista", cnn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cbx_listedRoutes.Items.Add(rdr[0].ToString().ToUpper());
            }
            
        }

        void applyLanguage()
        {
            this.Text = Resources.StringResources.rutaTitle;
            lbl_routeName.Text = Resources.StringResources.ruta_nombreRuta;
            lbl_start.Text = Resources.StringResources.ruta_ciudadInicio;
            lbl_end.Text = Resources.StringResources.ruta_ciudadTermina;
            lbl_listedRoutes.Text = Resources.StringResources.rutas_existentes;
            lbl_distance.Text = Resources.StringResources.ruta_distancia;
            gbx_private.Text = Resources.StringResources.ruta_autoPrivado;
            lbl_timePrivate.Text = Resources.StringResources.ruta_tiempoPrivado;
            lbl_costPrivate.Text = Resources.StringResources.ruta_costoPrivado;
            gbx_public.Text = Resources.StringResources.ruta_transportePublico;
            lbl_timePublic.Text = Resources.StringResources.ruta_tiempoPublico;
            lbl_costPublic.Text = Resources.StringResources.ruta_costoPublico;
            btn_addRoute.Text = Resources.StringResources.ruta_altaRuta;
            btn_deleteRoute.Text = Resources.StringResources.ruta_bajaRuta;
            btn_changeRoute.Text = Resources.StringResources.ruta_cambiarRuta;

        }

        private void btn_addRoute_Click(object sender, EventArgs e)
        {
            string routeName = txt_routeName.Text.ToLower();
            string initialCity = cbx_startingCity.SelectedItem.ToString();
            string finalCity = cbx_endingCity.SelectedItem.ToString();
            int distance = Int32.Parse(txt_Distance.Text);
            int timePrivate = Int32.Parse(txt_timePrivateCar.Text);
            int costPrivate = Int32.Parse(txt_costPrivateCar.Text);
            int timePublic = Int32.Parse(txt_timePublicCar.Text);
            int costPublic = Int32.Parse(txt_costPublicCar.Text);
            

            int initialCityNode = 0;
            int finalCityNode = 0;

            string str = Properties.Settings.Default.Database1ConnectionString;
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT idNodo FROM Nodo WHERE Ciudad = " + "'"+ initialCity + "'", cnn);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                initialCityNode = (int)rdr[0];
            }       
            
            SqlConnection cnn2 = new SqlConnection(str);
            cnn2.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT idNodo FROM Nodo WHERE Ciudad = " + "'" + finalCity + "'", cnn2);
            SqlDataReader rdr2 = cmd2.ExecuteReader();

            while (rdr2.Read())
            {
                finalCityNode = (int)rdr2[0];
            }
            Console.WriteLine(finalCityNode);

            string str3 = Properties.Settings.Default.Database1ConnectionString;

            SqlConnection cnn3 = new SqlConnection(str3);
            cnn3.Open();
            SqlCommand cmd3 = new SqlCommand("INSERT INTO Arista(idNodoInicial,idNodoFinal,Carretera," +
                "Costo_camion,Costo_privado,Tiempo_camion,Tiempo_privado,Distancia) " +
                "VALUES(" + initialCityNode + "," + finalCityNode + "," + "'" + routeName + "'" + "," + 
                costPublic + "," + costPrivate + "," + timePublic + "," + timePrivate + "," + distance + ");", cnn3);
            try
            {
                cmd3.ExecuteNonQuery();
                MessageBox.Show(Resources.StringResources.box_rutaAgregada);
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.StringResources.box_noDuplicates);
            }
            cnn3.Close();
            this.Close();


        }

        private void btn_deleteRoute_Click(object sender, EventArgs e)
        {
            string toDelete = cbx_listedRoutes.Text.ToLower();
            string str = Properties.Settings.Default.Database1ConnectionString;
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Arista WHERE Carretera = " + "'" + toDelete + "'" + ";", cnn);

            cmd.ExecuteNonQuery();
            MessageBox.Show(Resources.StringResources.box_rutaElminada);
 
            this.Close();

        }

        private void btn_changeRoute_Click(object sender, EventArgs e)
        {
            string toChange = cbx_listedRoutes.Text;
            string startingCity = cbx_startingCity.SelectedItem.ToString().ToLower();
            string endingCity = cbx_endingCity.SelectedItem.ToString().ToLower();
            int busCost = Int32.Parse(txt_costPublicCar.Text);
            int privateCost = Int32.Parse(txt_costPrivateCar.Text);
            int busTime = Int32.Parse(txt_timePublicCar.Text);
            int privateTime = Int32.Parse(txt_timePrivateCar.Text);
            int distance = Int32.Parse(txt_Distance.Text);

            Dictionary<string, int> citiesId = new Dictionary<string, int>();
            string str2 = Properties.Settings.Default.Database1ConnectionString;
            SqlConnection cnn2 = new SqlConnection(str2);
            cnn2.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT IdNodo, Ciudad FROM Nodo", cnn2);
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            while (rdr2.Read())
            {
                citiesId.Add(rdr2[1].ToString().ToLower(), (int)rdr2[0]);
            }
            rdr2.Close();
            cnn2.Close();

            int idStarting = citiesId[startingCity];
            int idEnding = citiesId[endingCity];

            string str = Properties.Settings.Default.Database1ConnectionString;
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Arista SET IdNodoInicial = " + idStarting + "," + "IdNodoFinal = " + idEnding + "," + 
                "Carretera = " + "'" + toChange + "'" + "," + "Costo_camion = " + busCost + ","
                + "Costo_privado = " + privateCost + "," + "Tiempo_camion = " + busTime + "," + "Tiempo_privado = " +
                privateTime + "," + "Distancia = " + distance
                + "WHERE Carretera = " + "'" + toChange + "'" + ";", cnn); 
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(Resources.StringResources.box_rutaEditada);
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.StringResources.box_aristaDuplicada);
            }
                
            this.Close();

        }

        private void cbx_listedRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_routeName.Enabled = false;
            if (cbx_listedRoutes.SelectedItem.ToString() == "N/A")
            {
                txt_routeName.Enabled = true;
            }
        }
    }
}
