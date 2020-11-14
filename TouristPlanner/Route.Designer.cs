namespace TouristPlanner
{
    partial class Route
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
            this.lbl_routeName = new System.Windows.Forms.Label();
            this.lbl_start = new System.Windows.Forms.Label();
            this.txt_Distance = new System.Windows.Forms.TextBox();
            this.lbl_distance = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbx_private = new System.Windows.Forms.GroupBox();
            this.txt_costPrivateCar = new System.Windows.Forms.TextBox();
            this.txt_timePrivateCar = new System.Windows.Forms.TextBox();
            this.lbl_costPrivate = new System.Windows.Forms.Label();
            this.lbl_timePrivate = new System.Windows.Forms.Label();
            this.gbx_public = new System.Windows.Forms.GroupBox();
            this.txt_costPublicCar = new System.Windows.Forms.TextBox();
            this.txt_timePublicCar = new System.Windows.Forms.TextBox();
            this.lbl_costPublic = new System.Windows.Forms.Label();
            this.lbl_timePublic = new System.Windows.Forms.Label();
            this.btn_changeRoute = new System.Windows.Forms.Button();
            this.btn_deleteRoute = new System.Windows.Forms.Button();
            this.btn_addRoute = new System.Windows.Forms.Button();
            this.cbx_startingCity = new System.Windows.Forms.ComboBox();
            this.cbx_endingCity = new System.Windows.Forms.ComboBox();
            this.txt_routeName = new System.Windows.Forms.TextBox();
            this.cbx_listedRoutes = new System.Windows.Forms.ComboBox();
            this.lbl_listedRoutes = new System.Windows.Forms.Label();
            this.gbx_private.SuspendLayout();
            this.gbx_public.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_routeName
            // 
            this.lbl_routeName.AutoSize = true;
            this.lbl_routeName.Location = new System.Drawing.Point(10, 28);
            this.lbl_routeName.Name = "lbl_routeName";
            this.lbl_routeName.Size = new System.Drawing.Size(91, 13);
            this.lbl_routeName.TabIndex = 2;
            this.lbl_routeName.Text = "Nombre de la ruta";
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Location = new System.Drawing.Point(10, 81);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(83, 13);
            this.lbl_start.TabIndex = 6;
            this.lbl_start.Text = "Ciudad de Inicio";
            // 
            // txt_Distance
            // 
            this.txt_Distance.Location = new System.Drawing.Point(130, 135);
            this.txt_Distance.Name = "txt_Distance";
            this.txt_Distance.Size = new System.Drawing.Size(131, 20);
            this.txt_Distance.TabIndex = 11;
            // 
            // lbl_distance
            // 
            this.lbl_distance.AutoSize = true;
            this.lbl_distance.Location = new System.Drawing.Point(10, 135);
            this.lbl_distance.Name = "lbl_distance";
            this.lbl_distance.Size = new System.Drawing.Size(51, 13);
            this.lbl_distance.TabIndex = 10;
            this.lbl_distance.Text = "Distancia";
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Location = new System.Drawing.Point(10, 107);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(110, 13);
            this.lbl_end.TabIndex = 8;
            this.lbl_end.Text = "Ciudad donde termina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kms";
            // 
            // gbx_private
            // 
            this.gbx_private.Controls.Add(this.txt_costPrivateCar);
            this.gbx_private.Controls.Add(this.txt_timePrivateCar);
            this.gbx_private.Controls.Add(this.lbl_costPrivate);
            this.gbx_private.Controls.Add(this.lbl_timePrivate);
            this.gbx_private.Location = new System.Drawing.Point(13, 185);
            this.gbx_private.Name = "gbx_private";
            this.gbx_private.Size = new System.Drawing.Size(673, 87);
            this.gbx_private.TabIndex = 13;
            this.gbx_private.TabStop = false;
            this.gbx_private.Text = "Datos si se utiliza auto rentado";
            // 
            // txt_costPrivateCar
            // 
            this.txt_costPrivateCar.Location = new System.Drawing.Point(193, 50);
            this.txt_costPrivateCar.Name = "txt_costPrivateCar";
            this.txt_costPrivateCar.Size = new System.Drawing.Size(461, 20);
            this.txt_costPrivateCar.TabIndex = 17;
            // 
            // txt_timePrivateCar
            // 
            this.txt_timePrivateCar.Location = new System.Drawing.Point(193, 19);
            this.txt_timePrivateCar.Name = "txt_timePrivateCar";
            this.txt_timePrivateCar.Size = new System.Drawing.Size(461, 20);
            this.txt_timePrivateCar.TabIndex = 15;
            // 
            // lbl_costPrivate
            // 
            this.lbl_costPrivate.AutoSize = true;
            this.lbl_costPrivate.Location = new System.Drawing.Point(7, 53);
            this.lbl_costPrivate.Name = "lbl_costPrivate";
            this.lbl_costPrivate.Size = new System.Drawing.Size(172, 13);
            this.lbl_costPrivate.TabIndex = 16;
            this.lbl_costPrivate.Text = "Costo si se recorre en auto rentado";
            // 
            // lbl_timePrivate
            // 
            this.lbl_timePrivate.AutoSize = true;
            this.lbl_timePrivate.Location = new System.Drawing.Point(7, 22);
            this.lbl_timePrivate.Name = "lbl_timePrivate";
            this.lbl_timePrivate.Size = new System.Drawing.Size(180, 13);
            this.lbl_timePrivate.TabIndex = 14;
            this.lbl_timePrivate.Text = "Tiempo si se recorre en auto rentado";
            // 
            // gbx_public
            // 
            this.gbx_public.Controls.Add(this.txt_costPublicCar);
            this.gbx_public.Controls.Add(this.txt_timePublicCar);
            this.gbx_public.Controls.Add(this.lbl_costPublic);
            this.gbx_public.Controls.Add(this.lbl_timePublic);
            this.gbx_public.Location = new System.Drawing.Point(13, 278);
            this.gbx_public.Name = "gbx_public";
            this.gbx_public.Size = new System.Drawing.Size(673, 87);
            this.gbx_public.TabIndex = 18;
            this.gbx_public.TabStop = false;
            this.gbx_public.Text = "Datos si se utiliza transporte público";
            // 
            // txt_costPublicCar
            // 
            this.txt_costPublicCar.Location = new System.Drawing.Point(220, 50);
            this.txt_costPublicCar.Name = "txt_costPublicCar";
            this.txt_costPublicCar.Size = new System.Drawing.Size(434, 20);
            this.txt_costPublicCar.TabIndex = 17;
            // 
            // txt_timePublicCar
            // 
            this.txt_timePublicCar.Location = new System.Drawing.Point(220, 19);
            this.txt_timePublicCar.Name = "txt_timePublicCar";
            this.txt_timePublicCar.Size = new System.Drawing.Size(434, 20);
            this.txt_timePublicCar.TabIndex = 15;
            // 
            // lbl_costPublic
            // 
            this.lbl_costPublic.AutoSize = true;
            this.lbl_costPublic.Location = new System.Drawing.Point(7, 53);
            this.lbl_costPublic.Name = "lbl_costPublic";
            this.lbl_costPublic.Size = new System.Drawing.Size(196, 13);
            this.lbl_costPublic.TabIndex = 16;
            this.lbl_costPublic.Text = "Costo si se recorre en transporte público";
            // 
            // lbl_timePublic
            // 
            this.lbl_timePublic.AutoSize = true;
            this.lbl_timePublic.Location = new System.Drawing.Point(7, 22);
            this.lbl_timePublic.Name = "lbl_timePublic";
            this.lbl_timePublic.Size = new System.Drawing.Size(204, 13);
            this.lbl_timePublic.TabIndex = 14;
            this.lbl_timePublic.Text = "Tiempo si se recorre en transporte público";
            // 
            // btn_changeRoute
            // 
            this.btn_changeRoute.Location = new System.Drawing.Point(488, 395);
            this.btn_changeRoute.Name = "btn_changeRoute";
            this.btn_changeRoute.Size = new System.Drawing.Size(144, 23);
            this.btn_changeRoute.TabIndex = 21;
            this.btn_changeRoute.Text = "Cambiar dato en una ruta";
            this.btn_changeRoute.UseVisualStyleBackColor = true;
            this.btn_changeRoute.Click += new System.EventHandler(this.btn_changeRoute_Click);
            // 
            // btn_deleteRoute
            // 
            this.btn_deleteRoute.Location = new System.Drawing.Point(289, 395);
            this.btn_deleteRoute.Name = "btn_deleteRoute";
            this.btn_deleteRoute.Size = new System.Drawing.Size(142, 23);
            this.btn_deleteRoute.TabIndex = 20;
            this.btn_deleteRoute.Text = "Baja de ruta";
            this.btn_deleteRoute.UseVisualStyleBackColor = true;
            this.btn_deleteRoute.Click += new System.EventHandler(this.btn_deleteRoute_Click);
            // 
            // btn_addRoute
            // 
            this.btn_addRoute.Location = new System.Drawing.Point(71, 395);
            this.btn_addRoute.Name = "btn_addRoute";
            this.btn_addRoute.Size = new System.Drawing.Size(145, 23);
            this.btn_addRoute.TabIndex = 19;
            this.btn_addRoute.Text = "Alta de ruta";
            this.btn_addRoute.UseVisualStyleBackColor = true;
            this.btn_addRoute.Click += new System.EventHandler(this.btn_addRoute_Click);
            // 
            // cbx_startingCity
            // 
            this.cbx_startingCity.FormattingEnabled = true;
            this.cbx_startingCity.Location = new System.Drawing.Point(130, 81);
            this.cbx_startingCity.Name = "cbx_startingCity";
            this.cbx_startingCity.Size = new System.Drawing.Size(537, 21);
            this.cbx_startingCity.TabIndex = 22;
            // 
            // cbx_endingCity
            // 
            this.cbx_endingCity.FormattingEnabled = true;
            this.cbx_endingCity.Location = new System.Drawing.Point(130, 108);
            this.cbx_endingCity.Name = "cbx_endingCity";
            this.cbx_endingCity.Size = new System.Drawing.Size(537, 21);
            this.cbx_endingCity.TabIndex = 23;
            // 
            // txt_routeName
            // 
            this.txt_routeName.Location = new System.Drawing.Point(130, 28);
            this.txt_routeName.Name = "txt_routeName";
            this.txt_routeName.Size = new System.Drawing.Size(537, 20);
            this.txt_routeName.TabIndex = 18;
            // 
            // cbx_listedRoutes
            // 
            this.cbx_listedRoutes.FormattingEnabled = true;
            this.cbx_listedRoutes.Location = new System.Drawing.Point(130, 54);
            this.cbx_listedRoutes.Name = "cbx_listedRoutes";
            this.cbx_listedRoutes.Size = new System.Drawing.Size(537, 21);
            this.cbx_listedRoutes.TabIndex = 25;
            this.cbx_listedRoutes.SelectedIndexChanged += new System.EventHandler(this.cbx_listedRoutes_SelectedIndexChanged);
            // 
            // lbl_listedRoutes
            // 
            this.lbl_listedRoutes.AutoSize = true;
            this.lbl_listedRoutes.Location = new System.Drawing.Point(10, 54);
            this.lbl_listedRoutes.Name = "lbl_listedRoutes";
            this.lbl_listedRoutes.Size = new System.Drawing.Size(85, 13);
            this.lbl_listedRoutes.TabIndex = 24;
            this.lbl_listedRoutes.Text = "Rutas existentes";
            // 
            // Ruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 442);
            this.Controls.Add(this.cbx_listedRoutes);
            this.Controls.Add(this.lbl_listedRoutes);
            this.Controls.Add(this.txt_routeName);
            this.Controls.Add(this.cbx_endingCity);
            this.Controls.Add(this.cbx_startingCity);
            this.Controls.Add(this.btn_changeRoute);
            this.Controls.Add(this.btn_deleteRoute);
            this.Controls.Add(this.btn_addRoute);
            this.Controls.Add(this.gbx_public);
            this.Controls.Add(this.gbx_private);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Distance);
            this.Controls.Add(this.lbl_distance);
            this.Controls.Add(this.lbl_end);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.lbl_routeName);
            this.Name = "Ruta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ruta";
            this.Load += new System.EventHandler(this.Route_Load);
            this.gbx_private.ResumeLayout(false);
            this.gbx_private.PerformLayout();
            this.gbx_public.ResumeLayout(false);
            this.gbx_public.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_routeName;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.TextBox txt_Distance;
        private System.Windows.Forms.Label lbl_distance;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbx_private;
        private System.Windows.Forms.TextBox txt_costPrivateCar;
        private System.Windows.Forms.TextBox txt_timePrivateCar;
        private System.Windows.Forms.Label lbl_costPrivate;
        private System.Windows.Forms.Label lbl_timePrivate;
        private System.Windows.Forms.GroupBox gbx_public;
        private System.Windows.Forms.TextBox txt_costPublicCar;
        private System.Windows.Forms.TextBox txt_timePublicCar;
        private System.Windows.Forms.Label lbl_costPublic;
        private System.Windows.Forms.Label lbl_timePublic;
        private System.Windows.Forms.Button btn_changeRoute;
        private System.Windows.Forms.Button btn_deleteRoute;
        private System.Windows.Forms.Button btn_addRoute;
        private System.Windows.Forms.ComboBox cbx_startingCity;
        private System.Windows.Forms.ComboBox cbx_endingCity;
        private System.Windows.Forms.TextBox txt_routeName;
        private System.Windows.Forms.ComboBox cbx_listedRoutes;
        private System.Windows.Forms.Label lbl_listedRoutes;
    }
}