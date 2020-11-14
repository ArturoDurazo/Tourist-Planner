
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouristPlanner
{
    public partial class Search : Form
    {
        List<int> nodePrivateCost = new List<int>();
        List<int> nodePublicCost = new List<int>();
        List<int> nodePrivateTime = new List<int>();
        List<int> nodePublicTime = new List<int>();
        List<int> nodeDistance = new List<int>();
        bool costPrivateSelected = false;

        int numberNodes = 0;
        int numberEdges = 0;

        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            applyLanguage();
            getComboBoxes();
        }

        private void btn_shortestRoute_Click(object sender, EventArgs e)
        {
            if (!cbx_start.SelectedItem.Equals(cbx_end.SelectedItem))
            {
                bool alternate = false;
                resetLbx();
                buildGraph(alternate);
            }
            else
            {
                MessageBox.Show(Resources.StringResources.busqueda_mismo);
            }  
        }

        private void btn_alternateRoute_Click(object sender, EventArgs e)
        {
            if (!cbx_start.SelectedItem.Equals(cbx_end.SelectedItem))
            {
                bool alternate = true;
                resetLbx();
                buildGraph(alternate);
            }
            else
            {
                MessageBox.Show(Resources.StringResources.busqueda_mismo);
            }   
        }

        void resetLbx()
        {
            lbx_transport.Items.Clear();
            lbx_time.Items.Clear();
            lbx_distance.Items.Clear();
            lbx_cost.Items.Clear();
            lbx_start.Items.Clear();
            lbx_end.Items.Clear();
            txt_totalCost.Clear();
            txt_totalTime.Clear();
            txt_totalDistance.Clear();
        }

        void buildGraph(bool alternate)
        {
            if (rdl_distance.Checked)
            {
                runGraph(nodeDistance, alternate);
                
                if (rdl_privateCar.Checked)
                {
                    lbx_transport.Items.Add(Resources.StringResources.busqueda_privadoSeleccionado);
                }
                else if (rdl_publicCar.Checked)
                {
                    lbx_transport.Items.Add(Resources.StringResources.busqueda_publicoSeleccionado);
                }
                else
                {
                    lbx_transport.Items.Add(Resources.StringResources.busqueda_ambosSeleccionado);
                }
                return;
            }
            if (rdl_privateCar.Checked)
            {
                lbx_transport.Items.Add(Resources.StringResources.busqueda_privadoSeleccionado);
                if (rdl_time.Checked)
                {
                    runGraph(nodePrivateTime, alternate);            
                }
                else //cost
                {
                    runGraph(nodePrivateCost, alternate);
                }
            }
            else if (rdl_publicCar.Checked)
            {
                lbx_transport.Items.Add(Resources.StringResources.busqueda_publicoSeleccionado);
                if (rdl_time.Checked)
                {
                    runGraph(nodePublicTime, alternate);
                }
                else //cost
                {
                    runGraph(nodePublicCost, alternate);
                }
            }
            else //both
            {
                if (rdl_time.Checked)
                {
                    int total = runGraph(nodePrivateTime, alternate);
                    
                    int total2 = runGraph(nodePublicTime, alternate);
                    resetLbx();
                    if(total < total2)
                    {
                        costPrivateSelected = true;
                        lbx_transport.Items.Add(Resources.StringResources.busqueda_privadoSeleccionado);
                        runGraph(nodePrivateTime, alternate);
                        costPrivateSelected = false;
                    }
                    else
                    {
                        lbx_transport.Items.Add(Resources.StringResources.busqueda_publicoSeleccionado);
                        runGraph(nodePublicTime, alternate);  
                    }
                }
                else //cost
                {
                    int total = runGraph(nodePrivateCost, alternate);

                    int total2 = runGraph(nodePublicCost, alternate);

                    resetLbx();
                    if (total < total2)
                    {
                        costPrivateSelected = true;
                        lbx_transport.Items.Add(Resources.StringResources.busqueda_privadoSeleccionado);
                        runGraph(nodePrivateCost, alternate);
                        costPrivateSelected = false;
                    }
                    else
                    {
                        lbx_transport.Items.Add(Resources.StringResources.busqueda_publicoSeleccionado);
                        runGraph(nodePublicCost, alternate);
                    }
                }
            }
        }

        private void pbx_map_Paint(object sender, PaintEventArgs e)
        {
            //get a dictionary with Name of the city and its coordinates
            Dictionary<string, Tuple<int, int>> coordDic = new Dictionary<string, Tuple<int, int>>();
            //get a dictionary with the id of the node and its coordinates
            Dictionary<int, Tuple<int, int>> idDic = new Dictionary<int, Tuple<int, int>>();

            string str = Properties.Settings.Default.Database1ConnectionString;
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Ciudad, coord_x, coord_y, IdNodo FROM Nodo", cnn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Tuple<int, int> coordTuple = new Tuple<int, int>((int)rdr[1], (int)rdr[2]);
                coordDic.Add(rdr[0].ToString(), coordTuple);
                idDic.Add((int)rdr[3], coordTuple);
            }
            rdr.Close();
            cnn.Close();
            Graphics grafica = this.pbx_map.CreateGraphics();
            //vertex
            foreach (KeyValuePair<string, Tuple<int, int>> item in coordDic)
            {
                string city = item.Key;
                city = char.ToUpper(city[0]) + city.Substring(1);
                e.Graphics.DrawString(city, new Font("Arial", 10), System.Drawing.Brushes.Black, new Point(item.Value.Item1-15, item.Value.Item2-20));
                SolidBrush brush = new SolidBrush(Color.Black);
                e.Graphics.FillEllipse(brush, item.Value.Item1-5, item.Value.Item2-5, 10, 10);
            }
            ////get a dictionary with Name of the city and its starting and ending nodes (IDs)
            Dictionary<string, Tuple<int, int>> edgesDic = new Dictionary<string, Tuple<int, int>>();
            SqlConnection cnn2 = new SqlConnection(str);
            cnn2.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT Carretera, IdNodoInicial, IdNodoFinal FROM Arista", cnn2);
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            while (rdr2.Read())
            {
                Tuple<int, int> edgesTuple = new Tuple<int, int>((int)rdr2[1], (int)rdr2[2]);
                edgesDic.Add(rdr2[0].ToString(), edgesTuple);
            }

            foreach (KeyValuePair<string, Tuple<int, int>> item in edgesDic)
            {
                string Carretera = item.Key;
                Carretera = char.ToUpper(Carretera[0]) + Carretera.Substring(1);
                int idStartingNode = item.Value.Item1;
                int idEndingNode = item.Value.Item2;
                e.Graphics.DrawLine(System.Drawing.Pens.Black, idDic[idStartingNode].Item1, idDic[idStartingNode].Item2,
                    idDic[idEndingNode].Item1, idDic[idEndingNode].Item2);
            }
        }

        void applyLanguage()
        {
            this.Text = Resources.StringResources.busquedaTitle;
            lbl_start.Text = Resources.StringResources.busqueda_inicio;
            lbl_end.Text = Resources.StringResources.busqueda_termina;
            gbx_transportChoice.Text = Resources.StringResources.busqueda_medioTransporte;
            rdl_privateCar.Text = Resources.StringResources.busqueda_privado;
            rdl_publicCar.Text = Resources.StringResources.busqueda_publico;
            rdl_bothCars.Text = Resources.StringResources.busqueda_ambos;
            gbx_searchCriteria.Text = Resources.StringResources.busqueda_criterio;
            rdl_time.Text = Resources.StringResources.busqueda_tiempo;
            rdl_distance.Text = Resources.StringResources.busqueda_distancia;
            rdl_cost.Text = Resources.StringResources.busqueda_costo;
            lbl_transportChoice.Text = Resources.StringResources.busqueda_lbl_transporte;
            lbl_start2.Text = Resources.StringResources.busqueda_lbl_inicia;
            lbl_end2.Text = Resources.StringResources.busqueda_lbl_termina;
            lbl_distance.Text = Resources.StringResources.busqueda_lbl_distancia;
            lbl_time.Text = Resources.StringResources.busqueda_lbl_tiempo;
            lbl_cost.Text = Resources.StringResources.busqueda_lbl_costo;
            lbl_totals.Text = Resources.StringResources.busqueda_totales;
            btn_shortestRoute.Text = Resources.StringResources.busqueda_rutaCorta;
            btn_alternateRoute.Text = Resources.StringResources.busqueda__rutaAlterna;
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
                cbx_start.Items.Add(city);
                cbx_end.Items.Add(city);
            }
        }

        void getNodes(undirectedGraph gu, List<int> nodeNumbers)
        {
            string str = Properties.Settings.Default.Database1ConnectionString ;

            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT IdNodo FROM NODO order by IdNodo", cnn);

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                nodeNumbers.Add((int)rdr[0]);
                numberNodes++;
            }
            rdr.Close();
            gu.init(numberNodes);
        }

        void getEdges(undirectedGraph gu, List<int> initialNode, List<int> finalNode)
        {
            string str = Properties.Settings.Default.Database1ConnectionString;

            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT IdNodoInicial, IdNodoFinal, Costo_camion, Costo_privado" +
                ", Tiempo_camion, Tiempo_privado, Distancia FROM Arista", cnn);

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                initialNode.Add((int)rdr[0]);
                finalNode.Add((int)rdr[1]);
                nodePublicCost.Add((int)rdr[2]);
                nodePrivateCost.Add((int)rdr[3]);
                nodePublicTime.Add((int)rdr[4]);
                nodePrivateTime.Add((int)rdr[5]);
                nodeDistance.Add((int)rdr[6]);
                numberEdges++;
            }
            rdr.Close();
        }

        void undirectedGraph(List<int> weight, undirectedGraph gu, List<int> nodeNumbers, List<int> initialNode, List<int> finalNode)
        {
            for (int i = 0; i < numberNodes; i++)
            {
                gu.insertVertex(nodeNumbers[i].ToString());
            }
            for (int i = 0; i < numberEdges; i++)
            {
                gu.insertEdge(initialNode[i].ToString(), finalNode[i].ToString(), weight[i]);
            }
        }

        int getIdFromName(string cityName)
        {
            string str = Properties.Settings.Default.Database1ConnectionString;
            int idNode = 0;

            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT IdNodo FROM NODO WHERE Ciudad = " + "'" + cityName + "'", cnn);

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                idNode = (int)rdr[0];
            }
            rdr.Close();
            return idNode;
        }

        int runGraph(List<int> choiceWeight, bool alternate)
        {
            //create graph and its connections.
            undirectedGraph gu = new undirectedGraph();
            List<int> nodeNumbers = new List<int>();
            List<int> initialNode = new List<int>();
            List<int> finalNode = new List<int>();
            getNodes(gu, nodeNumbers);
            getEdges(gu, initialNode, finalNode);
            undirectedGraph(choiceWeight, gu, nodeNumbers, initialNode, finalNode);
            int startingNode = getIdFromName(cbx_start.Text);
            int endingNode = getIdFromName(cbx_end.Text);
            //get the shortest route into the string.
            string kek = gu.dijkstra(startingNode, endingNode);
            numberEdges = 0;
            numberNodes = 0;


            //split the string, first is TOTAL cost, the rest are nodes. The split is done with ','
            char delimeter = ','; 
            string[] costAndNodes = kek.Split(delimeter);

            if (alternate)
            {
                alternatePath(gu, startingNode, endingNode);
                return Int32.Parse(costAndNodes[0]);
            }

            //make a dictionary with Ids and cities
            Dictionary<string, string> idCities = new Dictionary<string, string>();
            string str = Properties.Settings.Default.Database1ConnectionString;
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT IdNodo,Ciudad FROM NODO", cnn);

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                idCities.Add(rdr[0].ToString(), rdr[1].ToString());
            }
            rdr.Close();
            cnn.Close();

            List<string> startNode = new List<string>();
            List<string> endNode = new List<string>();
            //populate the start and end boxes
            for (int i = 1; i < costAndNodes.Length - 2; i++)
            {
                lbx_start.Items.Add(idCities[costAndNodes[i]]);
                startNode.Add(costAndNodes[i]);
            }
            for (int i = 2; i < costAndNodes.Length - 1; i++)
            {
                lbx_end.Items.Add(idCities[costAndNodes[i]]);
                endNode.Add(costAndNodes[i]);
            }

            //now calculate the cost
            Dictionary<Tuple<string, string>, string> costPublic = new Dictionary<Tuple<string, string>, string>();
            Dictionary<Tuple<string, string>, string> costPrivate = new Dictionary<Tuple<string, string>, string>();
            Dictionary<Tuple<string, string>, string> timePublic = new Dictionary<Tuple<string, string>, string>();
            Dictionary<Tuple<string, string>, string> timePrivate = new Dictionary<Tuple<string, string>, string>();
            Dictionary<Tuple<string, string>, string> distance = new Dictionary<Tuple<string, string>, string>();
            int totalCostPublic = 0, totalCostPrivate = 0, totalTimePublic = 0, totalTimePrivate = 0, totalDistance = 0;
            List<int> shortestRoute = new List<int>();
            //meter costAndNodes
            for(int i = 1; i < costAndNodes.Length-1; i++)
            {
                shortestRoute.Add(Int32.Parse(costAndNodes[i]));
            }

            if (rdl_privateCar.Checked)
            {
                for (int i = 1; i < shortestRoute.Count; i++)
                {
                    cnn = new SqlConnection(str);
                    cnn.Open();
                    cmd = new SqlCommand("SELECT IdNodoInicial, IdNodoFinal, Costo_privado, " +
                        "Tiempo_privado, Distancia FROM Arista WHERE (IdNodoInicial = " + shortestRoute[i - 1] + " AND " + "IdNodoFinal = " + shortestRoute[i] +
                            ") OR (IdNodoFinal = " + shortestRoute[i - 1] + " AND " + "IdNodoInicial = " + shortestRoute[i] + ")", cnn);

                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Tuple<string, string> nodesTuple = new Tuple<string, string>(rdr[0].ToString(), rdr[1].ToString());
                        Tuple<string, string> nodesTuple2 = new Tuple<string, string>(rdr[1].ToString(), rdr[0].ToString());

                        costPrivate.Add(nodesTuple, rdr[2].ToString());
                        costPrivate.Add(nodesTuple2, rdr[2].ToString());
                        totalCostPrivate += (int)rdr[2];

                        timePrivate.Add(nodesTuple, rdr[3].ToString());
                        timePrivate.Add(nodesTuple2, rdr[3].ToString());
                        totalTimePrivate += (int)rdr[3];

                        distance.Add(nodesTuple, rdr[4].ToString());
                        distance.Add(nodesTuple2, rdr[4].ToString());
                        totalDistance += (int)rdr[4];
                    }
                    rdr.Close();
                    cnn.Close();
                }
                for (int i = 0; i < costAndNodes.Length - 3; i++)
                {
                    Tuple<string, string> nodesTuple = new Tuple<string, string>(startNode[i], endNode[i]);
                    lbx_time.Items.Add(timePrivate[nodesTuple]);
                    txt_totalTime.Text = totalTimePrivate.ToString();

                    lbx_cost.Items.Add(costPrivate[nodesTuple]);
                    txt_totalCost.Text = totalCostPrivate.ToString();

                    lbx_distance.Items.Add(distance[nodesTuple]);
                    txt_totalDistance.Text = totalDistance.ToString();
                }
            }
            else if(rdl_publicCar.Checked)//camion
            {
                for (int i = 1; i < shortestRoute.Count; i++)
                {
                    cnn = new SqlConnection(str);
                    cnn.Open();
                    cmd = new SqlCommand("SELECT IdNodoInicial, IdNodoFinal, Costo_camion, Tiempo_camion, " +
                        "Distancia FROM Arista WHERE (IdNodoInicial = " + shortestRoute[i - 1] + " AND " + "IdNodoFinal = " + shortestRoute[i] +
                            ") OR (IdNodoFinal = " + shortestRoute[i - 1] + " AND " + "IdNodoInicial = " + shortestRoute[i] + ")", cnn);

                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Tuple<string, string> nodesTuple = new Tuple<string, string>(rdr[0].ToString(), rdr[1].ToString());
                        Tuple<string, string> nodesTuple2 = new Tuple<string, string>(rdr[1].ToString(), rdr[0].ToString());
                        costPublic.Add(nodesTuple, rdr[2].ToString());
                        costPublic.Add(nodesTuple2, rdr[2].ToString());
                        totalCostPublic += (int)rdr[2];

                        timePublic.Add(nodesTuple, rdr[3].ToString());
                        timePublic.Add(nodesTuple2, rdr[3].ToString());
                        totalTimePublic += (int)rdr[3];

                        distance.Add(nodesTuple, rdr[4].ToString());
                        distance.Add(nodesTuple2, rdr[4].ToString());
                        totalDistance += (int)rdr[4];
                    }
                    rdr.Close();
                    cnn.Close();
                }
                for (int i = 0; i < costAndNodes.Length - 3; i++)
                {
                    Tuple<string, string> nodesTuple = new Tuple<string, string>(startNode[i], endNode[i]);
                    lbx_time.Items.Add(timePublic[nodesTuple]);
                    txt_totalTime.Text = totalTimePublic.ToString();

                    lbx_cost.Items.Add(costPublic[nodesTuple]);
                    txt_totalCost.Text = totalCostPublic.ToString();

                    lbx_distance.Items.Add(distance[nodesTuple]);
                    txt_totalDistance.Text = totalDistance.ToString();
                }
            }
            else
            {
                if(costPrivateSelected)
                {
                    for (int i = 1; i < shortestRoute.Count; i++)
                    {
                        cnn = new SqlConnection(str);
                        cnn.Open();
                        cmd = new SqlCommand("SELECT IdNodoInicial, IdNodoFinal, Costo_privado, " +
                            "Tiempo_privado, Distancia FROM Arista WHERE (IdNodoInicial = " + shortestRoute[i - 1] + " AND " + "IdNodoFinal = " + shortestRoute[i] +
                                ") OR (IdNodoFinal = " + shortestRoute[i - 1] + " AND " + "IdNodoInicial = " + shortestRoute[i] + ")", cnn);

                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            Tuple<string, string> nodesTuple = new Tuple<string, string>(rdr[0].ToString(), rdr[1].ToString());
                            Tuple<string, string> nodesTuple2 = new Tuple<string, string>(rdr[1].ToString(), rdr[0].ToString());

                            costPrivate.Add(nodesTuple, rdr[2].ToString());
                            costPrivate.Add(nodesTuple2, rdr[2].ToString());
                            totalCostPrivate += (int)rdr[2];

                            timePrivate.Add(nodesTuple, rdr[3].ToString());
                            timePrivate.Add(nodesTuple2, rdr[3].ToString());
                            totalTimePrivate += (int)rdr[3];

                            distance.Add(nodesTuple, rdr[4].ToString());
                            distance.Add(nodesTuple2, rdr[4].ToString());
                            totalDistance += (int)rdr[4];
                        }
                        rdr.Close();
                        cnn.Close();
                    }
                    for (int i = 0; i < costAndNodes.Length - 3; i++)
                    {
                        Tuple<string, string> nodesTuple = new Tuple<string, string>(startNode[i], endNode[i]);
                        lbx_time.Items.Add(timePrivate[nodesTuple]);
                        txt_totalTime.Text = totalTimePrivate.ToString();

                        lbx_cost.Items.Add(costPrivate[nodesTuple]);
                        txt_totalCost.Text = totalCostPrivate.ToString();

                        lbx_distance.Items.Add(distance[nodesTuple]);
                        txt_totalDistance.Text = totalDistance.ToString();
                    }
                }
                else
                {
                    for (int i = 1; i < shortestRoute.Count; i++)
                    {
                        cnn = new SqlConnection(str);
                        cnn.Open();
                        cmd = new SqlCommand("SELECT IdNodoInicial, IdNodoFinal, Costo_camion, Tiempo_camion, " +
                            "Distancia FROM Arista WHERE (IdNodoInicial = " + shortestRoute[i - 1] + " AND " + "IdNodoFinal = " + shortestRoute[i] +
                                ") OR (IdNodoFinal = " + shortestRoute[i - 1] + " AND " + "IdNodoInicial = " + shortestRoute[i] + ")", cnn);

                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            Tuple<string, string> nodesTuple = new Tuple<string, string>(rdr[0].ToString(), rdr[1].ToString());
                            Tuple<string, string> nodesTuple2 = new Tuple<string, string>(rdr[1].ToString(), rdr[0].ToString());
                            costPublic.Add(nodesTuple, rdr[2].ToString());
                            costPublic.Add(nodesTuple2, rdr[2].ToString());
                            totalCostPublic += (int)rdr[2];

                            timePublic.Add(nodesTuple, rdr[3].ToString());
                            timePublic.Add(nodesTuple2, rdr[3].ToString());
                            totalTimePublic += (int)rdr[3];

                            distance.Add(nodesTuple, rdr[4].ToString());
                            distance.Add(nodesTuple2, rdr[4].ToString());
                            totalDistance += (int)rdr[4];
                        }
                        rdr.Close();
                        cnn.Close();
                    }
                    for (int i = 0; i < costAndNodes.Length - 3; i++)
                    {
                        Tuple<string, string> nodesTuple = new Tuple<string, string>(startNode[i], endNode[i]);
                        lbx_time.Items.Add(timePublic[nodesTuple]);
                        txt_totalTime.Text = totalTimePublic.ToString();

                        lbx_cost.Items.Add(costPublic[nodesTuple]);
                        txt_totalCost.Text = totalCostPublic.ToString();

                        lbx_distance.Items.Add(distance[nodesTuple]);
                        txt_totalDistance.Text = totalDistance.ToString();
                    }
                }
            }    
            return Int32.Parse(costAndNodes[0]);
        }

        void alternatePath(undirectedGraph gu, int startingNode, int endingNode)
        {
            List<int> alternateRoute = new List<int>();
            alternateRoute = gu.findAlternate(startingNode, endingNode);

            //make a dictionary with Ids and cities
            Dictionary<string, string> idCities = new Dictionary<string, string>();
            string str = Properties.Settings.Default.Database1ConnectionString;
            SqlConnection cnn = new SqlConnection(str);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT IdNodo,Ciudad FROM NODO", cnn);

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                idCities.Add(rdr[0].ToString(), rdr[1].ToString());
            }
            rdr.Close();
            cnn.Close();

            List<string> startNode = new List<string>();
            List<string> endNode = new List<string>();
            //populate the start and end boxes
            for(int i = 0; i < alternateRoute.Count() - 1; i++) //0 1 2 3 4
            {
                lbx_start.Items.Add(idCities[alternateRoute[i].ToString()]);
                startNode.Add(alternateRoute[i].ToString());
            }
            for (int i = 1; i < alternateRoute.Count(); i++)
            {
                lbx_end.Items.Add(idCities[alternateRoute[i].ToString()]);
                endNode.Add(alternateRoute[i].ToString());
            }

            //now calculate the cost
            Dictionary<Tuple<string, string>, string> costPublic = new Dictionary<Tuple<string, string>, string>();
            Dictionary<Tuple<string, string>, string> costPrivate = new Dictionary<Tuple<string, string>, string>();
            Dictionary<Tuple<string, string>, string> timePublic = new Dictionary<Tuple<string, string>, string>();
            Dictionary<Tuple<string, string>, string> timePrivate = new Dictionary<Tuple<string, string>, string>();
            Dictionary<Tuple<string, string>, string> distance = new Dictionary<Tuple<string, string>, string>();
            int totalCostPublic = 0, totalCostPrivate = 0, totalTimePublic = 0, totalTimePrivate = 0, totalDistance = 0;

            if (rdl_privateCar.Checked)
            {
                for (int i = 1; i < alternateRoute.Count; i++)
                {
                    cnn = new SqlConnection(str);
                    cnn.Open();
                    cmd = new SqlCommand("SELECT IdNodoInicial, IdNodoFinal, Costo_privado, " +
                        "Tiempo_privado, Distancia FROM Arista WHERE (IdNodoInicial = " + alternateRoute[i - 1] + " AND " + "IdNodoFinal = " + alternateRoute[i] +
                            ") OR (IdNodoFinal = " + alternateRoute[i - 1] + " AND " + "IdNodoInicial = " + alternateRoute[i] + ")", cnn);

                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Tuple<string, string> nodesTuple = new Tuple<string, string>(rdr[0].ToString(), rdr[1].ToString());
                        Tuple<string, string> nodesTuple2 = new Tuple<string, string>(rdr[1].ToString(), rdr[0].ToString());

                        costPrivate.Add(nodesTuple, rdr[2].ToString());
                        costPrivate.Add(nodesTuple2, rdr[2].ToString());
                        totalCostPrivate += (int)rdr[2];

                        timePrivate.Add(nodesTuple, rdr[3].ToString());
                        timePrivate.Add(nodesTuple2, rdr[3].ToString());
                        totalTimePrivate += (int)rdr[3];

                        distance.Add(nodesTuple, rdr[4].ToString());
                        distance.Add(nodesTuple2, rdr[4].ToString());
                        totalDistance += (int)rdr[4];
                    }
                    rdr.Close();
                    cnn.Close();
                }
                for (int i = 0; i < alternateRoute.Count - 1; i++)
                {
                    Tuple<string, string> nodesTuple = new Tuple<string, string>(startNode[i], endNode[i]);
                    lbx_time.Items.Add(timePrivate[nodesTuple]);
                    txt_totalTime.Text = totalTimePrivate.ToString();

                    lbx_cost.Items.Add(costPrivate[nodesTuple]);
                    txt_totalCost.Text = totalCostPrivate.ToString();

                    lbx_distance.Items.Add(distance[nodesTuple]);
                    txt_totalDistance.Text = totalDistance.ToString();
                }
            }
            else if(rdl_publicCar.Checked)
            {
                for (int i = 1; i < alternateRoute.Count; i++)
                {
                    cnn = new SqlConnection(str);
                    cnn.Open();
                    cmd = new SqlCommand("SELECT IdNodoInicial, IdNodoFinal, Costo_camion, Tiempo_camion, " +
                        "Distancia FROM Arista WHERE (IdNodoInicial = " + alternateRoute[i - 1] + " AND " + "IdNodoFinal = " + alternateRoute[i] +
                            ") OR (IdNodoFinal = " + alternateRoute[i - 1] + " AND " + "IdNodoInicial = " + alternateRoute[i] + ")", cnn);

                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Tuple<string, string> nodesTuple = new Tuple<string, string>(rdr[0].ToString(), rdr[1].ToString());
                        Tuple<string, string> nodesTuple2 = new Tuple<string, string>(rdr[1].ToString(), rdr[0].ToString());
                        costPublic.Add(nodesTuple, rdr[2].ToString());
                        costPublic.Add(nodesTuple2, rdr[2].ToString());
                        totalCostPublic += (int)rdr[2];

                        timePublic.Add(nodesTuple, rdr[3].ToString());
                        timePublic.Add(nodesTuple2, rdr[3].ToString());
                        totalTimePublic += (int)rdr[3];

                        distance.Add(nodesTuple, rdr[4].ToString());
                        distance.Add(nodesTuple2, rdr[4].ToString());
                        totalDistance += (int)rdr[4];
                    }
                    rdr.Close();
                    cnn.Close();
                }
                for (int i = 0; i < alternateRoute.Count - 1; i++)
                {
                    Tuple<string, string> nodesTuple = new Tuple<string, string>(startNode[i], endNode[i]);
                    lbx_time.Items.Add(timePublic[nodesTuple]);
                    txt_totalTime.Text = totalTimePublic.ToString();

                    lbx_cost.Items.Add(costPublic[nodesTuple]);
                    txt_totalCost.Text = totalCostPublic.ToString();

                    lbx_distance.Items.Add(distance[nodesTuple]);
                    txt_totalDistance.Text = totalDistance.ToString();
                }
            }  
        }
    }
}
