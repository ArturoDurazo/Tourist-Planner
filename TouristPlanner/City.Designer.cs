namespace TouristPlanner
{
    partial class City
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
            this.lbl_cityName = new System.Windows.Forms.Label();
            this.txt_cityName = new System.Windows.Forms.TextBox();
            this.lbl_loc = new System.Windows.Forms.Label();
            this.num_x = new System.Windows.Forms.NumericUpDown();
            this.lbl_coordx = new System.Windows.Forms.Label();
            this.lbl_coordY = new System.Windows.Forms.Label();
            this.num_y = new System.Windows.Forms.NumericUpDown();
            this.btn_addCity = new System.Windows.Forms.Button();
            this.btn_deleteCity = new System.Windows.Forms.Button();
            this.btn_changeCity = new System.Windows.Forms.Button();
            this.lbl_existentCities = new System.Windows.Forms.Label();
            this.cbx_existentCities = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_y)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cityName
            // 
            this.lbl_cityName.AutoSize = true;
            this.lbl_cityName.Location = new System.Drawing.Point(12, 9);
            this.lbl_cityName.Name = "lbl_cityName";
            this.lbl_cityName.Size = new System.Drawing.Size(105, 13);
            this.lbl_cityName.TabIndex = 0;
            this.lbl_cityName.Text = "Nombre de la ciudad";
            // 
            // txt_cityName
            // 
            this.txt_cityName.Location = new System.Drawing.Point(15, 25);
            this.txt_cityName.Name = "txt_cityName";
            this.txt_cityName.Size = new System.Drawing.Size(560, 20);
            this.txt_cityName.TabIndex = 1;
            // 
            // lbl_loc
            // 
            this.lbl_loc.AutoSize = true;
            this.lbl_loc.Location = new System.Drawing.Point(12, 104);
            this.lbl_loc.Name = "lbl_loc";
            this.lbl_loc.Size = new System.Drawing.Size(66, 13);
            this.lbl_loc.TabIndex = 2;
            this.lbl_loc.Text = "Localización";
            // 
            // num_x
            // 
            this.num_x.Location = new System.Drawing.Point(102, 130);
            this.num_x.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.num_x.Name = "num_x";
            this.num_x.Size = new System.Drawing.Size(167, 20);
            this.num_x.TabIndex = 3;
            // 
            // lbl_coordx
            // 
            this.lbl_coordx.AutoSize = true;
            this.lbl_coordx.Location = new System.Drawing.Point(12, 130);
            this.lbl_coordx.Name = "lbl_coordx";
            this.lbl_coordx.Size = new System.Drawing.Size(73, 13);
            this.lbl_coordx.TabIndex = 4;
            this.lbl_coordx.Text = "Coordenada x";
            // 
            // lbl_coordY
            // 
            this.lbl_coordY.AutoSize = true;
            this.lbl_coordY.Location = new System.Drawing.Point(12, 159);
            this.lbl_coordY.Name = "lbl_coordY";
            this.lbl_coordY.Size = new System.Drawing.Size(73, 13);
            this.lbl_coordY.TabIndex = 5;
            this.lbl_coordY.Text = "Coordenada y";
            // 
            // num_y
            // 
            this.num_y.Location = new System.Drawing.Point(102, 156);
            this.num_y.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.num_y.Name = "num_y";
            this.num_y.Size = new System.Drawing.Size(167, 20);
            this.num_y.TabIndex = 6;
            // 
            // btn_addCity
            // 
            this.btn_addCity.Location = new System.Drawing.Point(26, 209);
            this.btn_addCity.Name = "btn_addCity";
            this.btn_addCity.Size = new System.Drawing.Size(132, 23);
            this.btn_addCity.TabIndex = 7;
            this.btn_addCity.Text = "Alta de ciudad";
            this.btn_addCity.UseVisualStyleBackColor = true;
            this.btn_addCity.Click += new System.EventHandler(this.btn_addCity_Click);
            // 
            // btn_deleteCity
            // 
            this.btn_deleteCity.Location = new System.Drawing.Point(244, 209);
            this.btn_deleteCity.Name = "btn_deleteCity";
            this.btn_deleteCity.Size = new System.Drawing.Size(132, 23);
            this.btn_deleteCity.TabIndex = 8;
            this.btn_deleteCity.Text = "Baja de ciudad";
            this.btn_deleteCity.UseVisualStyleBackColor = true;
            this.btn_deleteCity.Click += new System.EventHandler(this.btn_deleteCity_Click);
            // 
            // btn_changeCity
            // 
            this.btn_changeCity.Location = new System.Drawing.Point(443, 209);
            this.btn_changeCity.Name = "btn_changeCity";
            this.btn_changeCity.Size = new System.Drawing.Size(132, 23);
            this.btn_changeCity.TabIndex = 9;
            this.btn_changeCity.Text = "Cambiar dato en ciudad";
            this.btn_changeCity.UseVisualStyleBackColor = true;
            this.btn_changeCity.Click += new System.EventHandler(this.btn_changeCity_Click);
            // 
            // lbl_existentCities
            // 
            this.lbl_existentCities.AutoSize = true;
            this.lbl_existentCities.Location = new System.Drawing.Point(12, 48);
            this.lbl_existentCities.Name = "lbl_existentCities";
            this.lbl_existentCities.Size = new System.Drawing.Size(102, 13);
            this.lbl_existentCities.TabIndex = 10;
            this.lbl_existentCities.Text = "Ciudades Existentes";
            // 
            // cbx_existentCities
            // 
            this.cbx_existentCities.FormattingEnabled = true;
            this.cbx_existentCities.Location = new System.Drawing.Point(15, 65);
            this.cbx_existentCities.Name = "cbx_existentCities";
            this.cbx_existentCities.Size = new System.Drawing.Size(560, 21);
            this.cbx_existentCities.TabIndex = 11;
            this.cbx_existentCities.SelectedIndexChanged += new System.EventHandler(this.cbx_existentCities_SelectedIndexChanged);
            // 
            // Ciudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 263);
            this.Controls.Add(this.cbx_existentCities);
            this.Controls.Add(this.lbl_existentCities);
            this.Controls.Add(this.btn_changeCity);
            this.Controls.Add(this.btn_deleteCity);
            this.Controls.Add(this.btn_addCity);
            this.Controls.Add(this.num_y);
            this.Controls.Add(this.lbl_coordY);
            this.Controls.Add(this.lbl_coordx);
            this.Controls.Add(this.num_x);
            this.Controls.Add(this.lbl_loc);
            this.Controls.Add(this.txt_cityName);
            this.Controls.Add(this.lbl_cityName);
            this.Name = "Ciudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ciudad";
            this.Load += new System.EventHandler(this.City_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_y)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cityName;
        private System.Windows.Forms.TextBox txt_cityName;
        private System.Windows.Forms.Label lbl_loc;
        private System.Windows.Forms.NumericUpDown num_x;
        private System.Windows.Forms.Label lbl_coordx;
        private System.Windows.Forms.Label lbl_coordY;
        private System.Windows.Forms.NumericUpDown num_y;
        private System.Windows.Forms.Button btn_addCity;
        private System.Windows.Forms.Button btn_deleteCity;
        private System.Windows.Forms.Button btn_changeCity;
        private System.Windows.Forms.Label lbl_existentCities;
        private System.Windows.Forms.ComboBox cbx_existentCities;
    }
}