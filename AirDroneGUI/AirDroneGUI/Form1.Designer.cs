namespace AirDroneGUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.trust_label = new System.Windows.Forms.Label();
            this.Connect_button = new System.Windows.Forms.Button();
            this.label_rval = new System.Windows.Forms.Label();
            this.Ctheta_label = new System.Windows.Forms.Label();
            this.Cphi_label = new System.Windows.Forms.Label();
            this.Cpsi_label = new System.Windows.Forms.Label();
            this.trust_trackBar = new System.Windows.Forms.TrackBar();
            this.Ctheta_trackBar = new System.Windows.Forms.TrackBar();
            this.Cphi_trackBar = new System.Windows.Forms.TrackBar();
            this.Cpsi_trackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trust_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctheta_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cphi_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cpsi_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // trust_label
            // 
            this.trust_label.AutoSize = true;
            this.trust_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trust_label.Location = new System.Drawing.Point(266, 64);
            this.trust_label.Name = "trust_label";
            this.trust_label.Size = new System.Drawing.Size(24, 25);
            this.trust_label.TabIndex = 1;
            this.trust_label.Text = "0";
            // 
            // Connect_button
            // 
            this.Connect_button.Location = new System.Drawing.Point(12, 12);
            this.Connect_button.Name = "Connect_button";
            this.Connect_button.Size = new System.Drawing.Size(110, 32);
            this.Connect_button.TabIndex = 2;
            this.Connect_button.Text = "Connect";
            this.Connect_button.UseVisualStyleBackColor = true;
            this.Connect_button.Click += new System.EventHandler(this.Connect_button_Click);
            // 
            // label_rval
            // 
            this.label_rval.AutoSize = true;
            this.label_rval.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rval.Location = new System.Drawing.Point(190, 19);
            this.label_rval.Name = "label_rval";
            this.label_rval.Size = new System.Drawing.Size(24, 25);
            this.label_rval.TabIndex = 3;
            this.label_rval.Text = "0";
            // 
            // Ctheta_label
            // 
            this.Ctheta_label.AutoSize = true;
            this.Ctheta_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ctheta_label.Location = new System.Drawing.Point(266, 122);
            this.Ctheta_label.Name = "Ctheta_label";
            this.Ctheta_label.Size = new System.Drawing.Size(24, 25);
            this.Ctheta_label.TabIndex = 5;
            this.Ctheta_label.Text = "0";
            // 
            // Cphi_label
            // 
            this.Cphi_label.AutoSize = true;
            this.Cphi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cphi_label.Location = new System.Drawing.Point(266, 180);
            this.Cphi_label.Name = "Cphi_label";
            this.Cphi_label.Size = new System.Drawing.Size(24, 25);
            this.Cphi_label.TabIndex = 7;
            this.Cphi_label.Text = "0";
            // 
            // Cpsi_label
            // 
            this.Cpsi_label.AutoSize = true;
            this.Cpsi_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cpsi_label.Location = new System.Drawing.Point(266, 238);
            this.Cpsi_label.Name = "Cpsi_label";
            this.Cpsi_label.Size = new System.Drawing.Size(24, 25);
            this.Cpsi_label.TabIndex = 9;
            this.Cpsi_label.Text = "0";
            // 
            // trust_trackBar
            // 
            this.trust_trackBar.Location = new System.Drawing.Point(12, 64);
            this.trust_trackBar.Maximum = 100;
            this.trust_trackBar.Name = "trust_trackBar";
            this.trust_trackBar.Size = new System.Drawing.Size(242, 45);
            this.trust_trackBar.TabIndex = 11;
            // 
            // Ctheta_trackBar
            // 
            this.Ctheta_trackBar.Location = new System.Drawing.Point(12, 122);
            this.Ctheta_trackBar.Maximum = 50;
            this.Ctheta_trackBar.Minimum = -50;
            this.Ctheta_trackBar.Name = "Ctheta_trackBar";
            this.Ctheta_trackBar.Size = new System.Drawing.Size(242, 45);
            this.Ctheta_trackBar.TabIndex = 12;
            // 
            // Cphi_trackBar
            // 
            this.Cphi_trackBar.Location = new System.Drawing.Point(12, 180);
            this.Cphi_trackBar.Maximum = 50;
            this.Cphi_trackBar.Minimum = -50;
            this.Cphi_trackBar.Name = "Cphi_trackBar";
            this.Cphi_trackBar.Size = new System.Drawing.Size(242, 45);
            this.Cphi_trackBar.TabIndex = 13;
            // 
            // Cpsi_trackBar
            // 
            this.Cpsi_trackBar.Location = new System.Drawing.Point(12, 238);
            this.Cpsi_trackBar.Maximum = 50;
            this.Cpsi_trackBar.Minimum = -50;
            this.Cpsi_trackBar.Name = "Cpsi_trackBar";
            this.Cpsi_trackBar.Size = new System.Drawing.Size(242, 45);
            this.Cpsi_trackBar.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 324);
            this.Controls.Add(this.Cpsi_trackBar);
            this.Controls.Add(this.Cphi_trackBar);
            this.Controls.Add(this.Ctheta_trackBar);
            this.Controls.Add(this.trust_trackBar);
            this.Controls.Add(this.Cpsi_label);
            this.Controls.Add(this.Cphi_label);
            this.Controls.Add(this.Ctheta_label);
            this.Controls.Add(this.label_rval);
            this.Controls.Add(this.Connect_button);
            this.Controls.Add(this.trust_label);
            this.Name = "Form1";
            this.Text = "AirDroneGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.trust_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ctheta_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cphi_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cpsi_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label trust_label;
        private System.Windows.Forms.Button Connect_button;
        private System.Windows.Forms.Label label_rval;
        private System.Windows.Forms.Label Ctheta_label;
        private System.Windows.Forms.Label Cphi_label;
        private System.Windows.Forms.Label Cpsi_label;
        private System.Windows.Forms.TrackBar trust_trackBar;
        private System.Windows.Forms.TrackBar Ctheta_trackBar;
        private System.Windows.Forms.TrackBar Cphi_trackBar;
        private System.Windows.Forms.TrackBar Cpsi_trackBar;
    }
}

