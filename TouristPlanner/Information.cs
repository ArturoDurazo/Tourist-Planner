using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;


namespace TouristPlanner
{
    public partial class Information : Form
    {
        Menu menu;

        public Information(Menu menu)
        {
            this.menu = menu;
            InitializeComponent();
            var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            lbl_version.Text = String.Format("Version {0}", version);

        }

        private void Information_Load(object sender, EventArgs e)
        {
            applylanguage();
        }

        void applylanguage()
        {
            this.Text = Resources.StringResources.informacionTitle;
            lbl_systemName.Text = Resources.StringResources.info_nombre;
            lbl_language.Text = Resources.StringResources.info_idioma;
        }

        private void cbx_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo((string)cbx_language.SelectedItem);
            applylanguage();

            if (menu != null)
            {
                menu.applylanguage();
            }
        }
    }
}
