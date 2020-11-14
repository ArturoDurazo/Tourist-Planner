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
using TouristPlanner;

namespace TouristPlanner
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
       
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            applylanguage();
        }

        private void CityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            City f2 = new City();
            f2.Show();
        }

        private void RouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Route f2 = new Route();
            f2.Show();
        }

        private void InformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Information f2 = new Information(this);
            f2.Show();
        }

        public void applylanguage()
        {
            this.Text = Resources.StringResources.menuTitle_Planeacion;
            mapaToolStripMenuItem.Text = Resources.StringResources.menu_mapa;
            ciudadToolStripMenuItem.Text = Resources.StringResources.menu_ciudad;
            rutaToolStripMenuItem.Text = Resources.StringResources.menu_ruta;
            busquedaToolStripMenuItem.Text = Resources.StringResources.menu_busquedas;
            informaciToolStripMenuItem.Text = Resources.StringResources.menu_informacion;
            salirToolStripMenuItem.Text = Resources.StringResources.menu_salir;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search f2 = new Search();
            f2.Show();
        }
    }
}
