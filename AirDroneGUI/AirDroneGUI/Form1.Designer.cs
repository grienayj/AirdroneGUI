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
            this.Trottle_progressBar = new System.Windows.Forms.ProgressBar();
            this.Trottle_label = new System.Windows.Forms.Label();
            this.Connect_button = new System.Windows.Forms.Button();
            this.label_rval = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Trottle_progressBar
            // 
            this.Trottle_progressBar.Location = new System.Drawing.Point(12, 64);
            this.Trottle_progressBar.Name = "Trottle_progressBar";
            this.Trottle_progressBar.Size = new System.Drawing.Size(248, 27);
            this.Trottle_progressBar.Step = 5;
            this.Trottle_progressBar.TabIndex = 0;
            // 
            // Trottle_label
            // 
            this.Trottle_label.AutoSize = true;
            this.Trottle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trottle_label.Location = new System.Drawing.Point(121, 94);
            this.Trottle_label.Name = "Trottle_label";
            this.Trottle_label.Size = new System.Drawing.Size(24, 25);
            this.Trottle_label.TabIndex = 1;
            this.Trottle_label.Text = "0";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 129);
            this.Controls.Add(this.label_rval);
            this.Controls.Add(this.Connect_button);
            this.Controls.Add(this.Trottle_label);
            this.Controls.Add(this.Trottle_progressBar);
            this.Name = "Form1";
            this.Text = "AirDroneGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Trottle_progressBar;
        private System.Windows.Forms.Label Trottle_label;
        private System.Windows.Forms.Button Connect_button;
        private System.Windows.Forms.Label label_rval;
    }
}

