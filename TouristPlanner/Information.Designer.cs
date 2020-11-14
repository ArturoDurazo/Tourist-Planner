namespace TouristPlanner
{
    partial class Information
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
            this.lbl_systemName = new System.Windows.Forms.Label();
            this.lbl_version = new System.Windows.Forms.Label();
            this.lbl_language = new System.Windows.Forms.Label();
            this.cbx_language = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_systemName
            // 
            this.lbl_systemName.AutoSize = true;
            this.lbl_systemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_systemName.Location = new System.Drawing.Point(53, 44);
            this.lbl_systemName.Name = "lbl_systemName";
            this.lbl_systemName.Size = new System.Drawing.Size(191, 24);
            this.lbl_systemName.TabIndex = 0;
            this.lbl_systemName.Text = "Planeador Turístico";
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(90, 68);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(35, 13);
            this.lbl_version.TabIndex = 1;
            this.lbl_version.Text = "label1";
            // 
            // lbl_language
            // 
            this.lbl_language.AutoSize = true;
            this.lbl_language.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_language.Location = new System.Drawing.Point(76, 146);
            this.lbl_language.Name = "lbl_language";
            this.lbl_language.Size = new System.Drawing.Size(63, 20);
            this.lbl_language.TabIndex = 6;
            this.lbl_language.Text = "Idioma";
            // 
            // cbx_language
            // 
            this.cbx_language.FormattingEnabled = true;
            this.cbx_language.Items.AddRange(new object[] {
            "es-MX",
            "en-US"});
            this.cbx_language.Location = new System.Drawing.Point(64, 169);
            this.cbx_language.Name = "cbx_language";
            this.cbx_language.Size = new System.Drawing.Size(121, 21);
            this.cbx_language.TabIndex = 7;
            this.cbx_language.SelectedIndexChanged += new System.EventHandler(this.cbx_language_SelectedIndexChanged);
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 316);
            this.Controls.Add(this.cbx_language);
            this.Controls.Add(this.lbl_language);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.lbl_systemName);
            this.Name = "Information";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información";
            this.Load += new System.EventHandler(this.Information_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_systemName;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label lbl_language;
        private System.Windows.Forms.ComboBox cbx_language;
    }
}