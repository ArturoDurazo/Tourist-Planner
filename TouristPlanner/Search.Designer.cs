namespace TouristPlanner
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            this.cbx_start = new System.Windows.Forms.ComboBox();
            this.cbx_end = new System.Windows.Forms.ComboBox();
            this.gbx_transportChoice = new System.Windows.Forms.GroupBox();
            this.rdl_bothCars = new System.Windows.Forms.RadioButton();
            this.rdl_publicCar = new System.Windows.Forms.RadioButton();
            this.rdl_privateCar = new System.Windows.Forms.RadioButton();
            this.gbx_searchCriteria = new System.Windows.Forms.GroupBox();
            this.rdl_cost = new System.Windows.Forms.RadioButton();
            this.rdl_distance = new System.Windows.Forms.RadioButton();
            this.rdl_time = new System.Windows.Forms.RadioButton();
            this.btn_shortestRoute = new System.Windows.Forms.Button();
            this.btn_alternateRoute = new System.Windows.Forms.Button();
            this.lbx_cost = new System.Windows.Forms.ListBox();
            this.lbx_end = new System.Windows.Forms.ListBox();
            this.lbx_start = new System.Windows.Forms.ListBox();
            this.lbx_transport = new System.Windows.Forms.ListBox();
            this.lbx_time = new System.Windows.Forms.ListBox();
            this.lbx_distance = new System.Windows.Forms.ListBox();
            this.txt_totalDistance = new System.Windows.Forms.TextBox();
            this.txt_totalTime = new System.Windows.Forms.TextBox();
            this.txt_totalCost = new System.Windows.Forms.TextBox();
            this.lbl_totals = new System.Windows.Forms.Label();
            this.pbx_map = new System.Windows.Forms.PictureBox();
            this.lbl_transportChoice = new System.Windows.Forms.Label();
            this.lbl_start2 = new System.Windows.Forms.Label();
            this.lbl_end2 = new System.Windows.Forms.Label();
            this.lbl_distance = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.gbx_transportChoice.SuspendLayout();
            this.gbx_searchCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_map)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Location = new System.Drawing.Point(12, 23);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(83, 13);
            this.lbl_start.TabIndex = 0;
            this.lbl_start.Text = "Ciudad de Inicio";
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Location = new System.Drawing.Point(12, 50);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(110, 13);
            this.lbl_end.TabIndex = 1;
            this.lbl_end.Text = "Ciudad donde termina";
            // 
            // cbx_start
            // 
            this.cbx_start.FormattingEnabled = true;
            this.cbx_start.Location = new System.Drawing.Point(128, 20);
            this.cbx_start.Name = "cbx_start";
            this.cbx_start.Size = new System.Drawing.Size(473, 21);
            this.cbx_start.TabIndex = 2;
            // 
            // cbx_end
            // 
            this.cbx_end.FormattingEnabled = true;
            this.cbx_end.Location = new System.Drawing.Point(128, 47);
            this.cbx_end.Name = "cbx_end";
            this.cbx_end.Size = new System.Drawing.Size(473, 21);
            this.cbx_end.TabIndex = 3;
            // 
            // gbx_transportChoice
            // 
            this.gbx_transportChoice.Controls.Add(this.rdl_bothCars);
            this.gbx_transportChoice.Controls.Add(this.rdl_publicCar);
            this.gbx_transportChoice.Controls.Add(this.rdl_privateCar);
            this.gbx_transportChoice.Location = new System.Drawing.Point(610, 13);
            this.gbx_transportChoice.Name = "gbx_transportChoice";
            this.gbx_transportChoice.Size = new System.Drawing.Size(146, 100);
            this.gbx_transportChoice.TabIndex = 4;
            this.gbx_transportChoice.TabStop = false;
            this.gbx_transportChoice.Text = "Medio de Transporte";
            // 
            // rdl_bothCars
            // 
            this.rdl_bothCars.AutoSize = true;
            this.rdl_bothCars.Location = new System.Drawing.Point(16, 65);
            this.rdl_bothCars.Name = "rdl_bothCars";
            this.rdl_bothCars.Size = new System.Drawing.Size(57, 17);
            this.rdl_bothCars.TabIndex = 2;
            this.rdl_bothCars.TabStop = true;
            this.rdl_bothCars.Text = "Ambos";
            this.rdl_bothCars.UseVisualStyleBackColor = true;
            // 
            // rdl_publicCar
            // 
            this.rdl_publicCar.AutoSize = true;
            this.rdl_publicCar.Location = new System.Drawing.Point(16, 42);
            this.rdl_publicCar.Name = "rdl_publicCar";
            this.rdl_publicCar.Size = new System.Drawing.Size(113, 17);
            this.rdl_publicCar.TabIndex = 1;
            this.rdl_publicCar.TabStop = true;
            this.rdl_publicCar.Text = "Transporte público";
            this.rdl_publicCar.UseVisualStyleBackColor = true;
            // 
            // rdl_privateCar
            // 
            this.rdl_privateCar.AutoSize = true;
            this.rdl_privateCar.Location = new System.Drawing.Point(16, 19);
            this.rdl_privateCar.Name = "rdl_privateCar";
            this.rdl_privateCar.Size = new System.Drawing.Size(86, 17);
            this.rdl_privateCar.TabIndex = 0;
            this.rdl_privateCar.TabStop = true;
            this.rdl_privateCar.Text = "Auto rentado";
            this.rdl_privateCar.UseVisualStyleBackColor = true;
            // 
            // gbx_searchCriteria
            // 
            this.gbx_searchCriteria.Controls.Add(this.rdl_cost);
            this.gbx_searchCriteria.Controls.Add(this.rdl_distance);
            this.gbx_searchCriteria.Controls.Add(this.rdl_time);
            this.gbx_searchCriteria.Location = new System.Drawing.Point(792, 13);
            this.gbx_searchCriteria.Name = "gbx_searchCriteria";
            this.gbx_searchCriteria.Size = new System.Drawing.Size(138, 100);
            this.gbx_searchCriteria.TabIndex = 5;
            this.gbx_searchCriteria.TabStop = false;
            this.gbx_searchCriteria.Text = "Criterio de búsqueda";
            // 
            // rdl_cost
            // 
            this.rdl_cost.AutoSize = true;
            this.rdl_cost.Location = new System.Drawing.Point(17, 65);
            this.rdl_cost.Name = "rdl_cost";
            this.rdl_cost.Size = new System.Drawing.Size(52, 17);
            this.rdl_cost.TabIndex = 3;
            this.rdl_cost.TabStop = true;
            this.rdl_cost.Text = "Costo";
            this.rdl_cost.UseVisualStyleBackColor = true;
            // 
            // rdl_distance
            // 
            this.rdl_distance.AutoSize = true;
            this.rdl_distance.Location = new System.Drawing.Point(17, 42);
            this.rdl_distance.Name = "rdl_distance";
            this.rdl_distance.Size = new System.Drawing.Size(69, 17);
            this.rdl_distance.TabIndex = 2;
            this.rdl_distance.TabStop = true;
            this.rdl_distance.Text = "Distancia";
            this.rdl_distance.UseVisualStyleBackColor = true;
            // 
            // rdl_time
            // 
            this.rdl_time.AutoSize = true;
            this.rdl_time.Location = new System.Drawing.Point(17, 19);
            this.rdl_time.Name = "rdl_time";
            this.rdl_time.Size = new System.Drawing.Size(60, 17);
            this.rdl_time.TabIndex = 1;
            this.rdl_time.TabStop = true;
            this.rdl_time.Text = "Tiempo";
            this.rdl_time.UseVisualStyleBackColor = true;
            // 
            // btn_shortestRoute
            // 
            this.btn_shortestRoute.Location = new System.Drawing.Point(965, 23);
            this.btn_shortestRoute.Name = "btn_shortestRoute";
            this.btn_shortestRoute.Size = new System.Drawing.Size(126, 34);
            this.btn_shortestRoute.TabIndex = 6;
            this.btn_shortestRoute.Text = "Ruta más corta";
            this.btn_shortestRoute.UseVisualStyleBackColor = true;
            this.btn_shortestRoute.Click += new System.EventHandler(this.btn_shortestRoute_Click);
            // 
            // btn_alternateRoute
            // 
            this.btn_alternateRoute.Location = new System.Drawing.Point(965, 77);
            this.btn_alternateRoute.Name = "btn_alternateRoute";
            this.btn_alternateRoute.Size = new System.Drawing.Size(126, 34);
            this.btn_alternateRoute.TabIndex = 7;
            this.btn_alternateRoute.Text = "Ruta alterna";
            this.btn_alternateRoute.UseVisualStyleBackColor = true;
            this.btn_alternateRoute.Click += new System.EventHandler(this.btn_alternateRoute_Click);
            // 
            // lbx_cost
            // 
            this.lbx_cost.FormattingEnabled = true;
            this.lbx_cost.Location = new System.Drawing.Point(1031, 156);
            this.lbx_cost.Name = "lbx_cost";
            this.lbx_cost.Size = new System.Drawing.Size(60, 277);
            this.lbx_cost.TabIndex = 10;
            // 
            // lbx_end
            // 
            this.lbx_end.FormattingEnabled = true;
            this.lbx_end.Location = new System.Drawing.Point(818, 156);
            this.lbx_end.Name = "lbx_end";
            this.lbx_end.Size = new System.Drawing.Size(75, 277);
            this.lbx_end.TabIndex = 11;
            // 
            // lbx_start
            // 
            this.lbx_start.FormattingEnabled = true;
            this.lbx_start.Location = new System.Drawing.Point(724, 156);
            this.lbx_start.Name = "lbx_start";
            this.lbx_start.Size = new System.Drawing.Size(88, 277);
            this.lbx_start.TabIndex = 12;
            // 
            // lbx_transport
            // 
            this.lbx_transport.FormattingEnabled = true;
            this.lbx_transport.Location = new System.Drawing.Point(610, 156);
            this.lbx_transport.Name = "lbx_transport";
            this.lbx_transport.Size = new System.Drawing.Size(108, 277);
            this.lbx_transport.TabIndex = 13;
            // 
            // lbx_time
            // 
            this.lbx_time.FormattingEnabled = true;
            this.lbx_time.Location = new System.Drawing.Point(965, 156);
            this.lbx_time.Name = "lbx_time";
            this.lbx_time.Size = new System.Drawing.Size(60, 277);
            this.lbx_time.TabIndex = 14;
            // 
            // lbx_distance
            // 
            this.lbx_distance.FormattingEnabled = true;
            this.lbx_distance.Location = new System.Drawing.Point(899, 156);
            this.lbx_distance.Name = "lbx_distance";
            this.lbx_distance.Size = new System.Drawing.Size(60, 277);
            this.lbx_distance.TabIndex = 15;
            // 
            // txt_totalDistance
            // 
            this.txt_totalDistance.Location = new System.Drawing.Point(899, 440);
            this.txt_totalDistance.Name = "txt_totalDistance";
            this.txt_totalDistance.Size = new System.Drawing.Size(60, 20);
            this.txt_totalDistance.TabIndex = 16;
            // 
            // txt_totalTime
            // 
            this.txt_totalTime.Location = new System.Drawing.Point(965, 440);
            this.txt_totalTime.Name = "txt_totalTime";
            this.txt_totalTime.Size = new System.Drawing.Size(60, 20);
            this.txt_totalTime.TabIndex = 17;
            // 
            // txt_totalCost
            // 
            this.txt_totalCost.Location = new System.Drawing.Point(1031, 440);
            this.txt_totalCost.Name = "txt_totalCost";
            this.txt_totalCost.Size = new System.Drawing.Size(60, 20);
            this.txt_totalCost.TabIndex = 18;
            // 
            // lbl_totals
            // 
            this.lbl_totals.AutoSize = true;
            this.lbl_totals.Location = new System.Drawing.Point(836, 443);
            this.lbl_totals.Name = "lbl_totals";
            this.lbl_totals.Size = new System.Drawing.Size(42, 13);
            this.lbl_totals.TabIndex = 19;
            this.lbl_totals.Text = "Totales";
            // 
            // pbx_map
            // 
            this.pbx_map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_map.ErrorImage = null;
            this.pbx_map.Location = new System.Drawing.Point(1, 93);
            this.pbx_map.Name = "pbx_map";
            this.pbx_map.Size = new System.Drawing.Size(600, 400);
            this.pbx_map.TabIndex = 20;
            this.pbx_map.TabStop = false;
            this.pbx_map.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx_map_Paint);
            // 
            // lbl_transportChoice
            // 
            this.lbl_transportChoice.AutoSize = true;
            this.lbl_transportChoice.Location = new System.Drawing.Point(607, 140);
            this.lbl_transportChoice.Name = "lbl_transportChoice";
            this.lbl_transportChoice.Size = new System.Drawing.Size(105, 13);
            this.lbl_transportChoice.TabIndex = 21;
            this.lbl_transportChoice.Text = "Medio de Transporte";
            // 
            // lbl_start2
            // 
            this.lbl_start2.AutoSize = true;
            this.lbl_start2.Location = new System.Drawing.Point(721, 140);
            this.lbl_start2.Name = "lbl_start2";
            this.lbl_start2.Size = new System.Drawing.Size(32, 13);
            this.lbl_start2.TabIndex = 22;
            this.lbl_start2.Text = "Inicia";
            // 
            // lbl_end2
            // 
            this.lbl_end2.AutoSize = true;
            this.lbl_end2.Location = new System.Drawing.Point(815, 140);
            this.lbl_end2.Name = "lbl_end2";
            this.lbl_end2.Size = new System.Drawing.Size(45, 13);
            this.lbl_end2.TabIndex = 23;
            this.lbl_end2.Text = "Termina";
            // 
            // lbl_distance
            // 
            this.lbl_distance.AutoSize = true;
            this.lbl_distance.Location = new System.Drawing.Point(896, 140);
            this.lbl_distance.Name = "lbl_distance";
            this.lbl_distance.Size = new System.Drawing.Size(51, 13);
            this.lbl_distance.TabIndex = 24;
            this.lbl_distance.Text = "Distancia";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(962, 140);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(42, 13);
            this.lbl_time.TabIndex = 25;
            this.lbl_time.Text = "Tiempo";
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Location = new System.Drawing.Point(1028, 140);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(34, 13);
            this.lbl_cost.TabIndex = 26;
            this.lbl_cost.Text = "Costo";
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 515);
            this.Controls.Add(this.lbl_cost);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_distance);
            this.Controls.Add(this.lbl_end2);
            this.Controls.Add(this.lbl_start2);
            this.Controls.Add(this.lbl_transportChoice);
            this.Controls.Add(this.pbx_map);
            this.Controls.Add(this.lbl_totals);
            this.Controls.Add(this.txt_totalCost);
            this.Controls.Add(this.txt_totalTime);
            this.Controls.Add(this.txt_totalDistance);
            this.Controls.Add(this.lbx_distance);
            this.Controls.Add(this.lbx_time);
            this.Controls.Add(this.lbx_transport);
            this.Controls.Add(this.lbx_start);
            this.Controls.Add(this.lbx_end);
            this.Controls.Add(this.lbx_cost);
            this.Controls.Add(this.btn_alternateRoute);
            this.Controls.Add(this.btn_shortestRoute);
            this.Controls.Add(this.gbx_searchCriteria);
            this.Controls.Add(this.gbx_transportChoice);
            this.Controls.Add(this.cbx_end);
            this.Controls.Add(this.cbx_start);
            this.Controls.Add(this.lbl_end);
            this.Controls.Add(this.lbl_start);
            this.Name = "Busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda";
            this.Load += new System.EventHandler(this.Search_Load);
            this.gbx_transportChoice.ResumeLayout(false);
            this.gbx_transportChoice.PerformLayout();
            this.gbx_searchCriteria.ResumeLayout(false);
            this.gbx_searchCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_map)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.ComboBox cbx_start;
        private System.Windows.Forms.ComboBox cbx_end;
        private System.Windows.Forms.GroupBox gbx_transportChoice;
        private System.Windows.Forms.RadioButton rdl_bothCars;
        private System.Windows.Forms.RadioButton rdl_publicCar;
        private System.Windows.Forms.RadioButton rdl_privateCar;
        private System.Windows.Forms.GroupBox gbx_searchCriteria;
        private System.Windows.Forms.RadioButton rdl_cost;
        private System.Windows.Forms.RadioButton rdl_distance;
        private System.Windows.Forms.RadioButton rdl_time;
        private System.Windows.Forms.Button btn_shortestRoute;
        private System.Windows.Forms.Button btn_alternateRoute;
        private System.Windows.Forms.ListBox lbx_cost;
        private System.Windows.Forms.ListBox lbx_end;
        private System.Windows.Forms.ListBox lbx_start;
        private System.Windows.Forms.ListBox lbx_transport;
        private System.Windows.Forms.ListBox lbx_time;
        private System.Windows.Forms.ListBox lbx_distance;
        private System.Windows.Forms.TextBox txt_totalDistance;
        private System.Windows.Forms.TextBox txt_totalTime;
        private System.Windows.Forms.TextBox txt_totalCost;
        private System.Windows.Forms.Label lbl_totals;
        private System.Windows.Forms.PictureBox pbx_map;
        private System.Windows.Forms.Label lbl_transportChoice;
        private System.Windows.Forms.Label lbl_start2;
        private System.Windows.Forms.Label lbl_end2;
        private System.Windows.Forms.Label lbl_distance;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_cost;
    }
}