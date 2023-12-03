namespace Aplicacion_Choferes.Forms
{
    partial class TruckerDriveTruckManagerForm
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
            this.buttonSearchByTruckByTruckerID = new System.Windows.Forms.Button();
            this.labelIDTrucker = new System.Windows.Forms.Label();
            this.txtBoxIDTrucker = new System.Windows.Forms.TextBox();
            this.dataGridViewTruckerAndTruckers = new System.Windows.Forms.DataGridView();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTruckerAndTruckers)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearchByTruckByTruckerID
            // 
            this.buttonSearchByTruckByTruckerID.Location = new System.Drawing.Point(12, 333);
            this.buttonSearchByTruckByTruckerID.Name = "buttonSearchByTruckByTruckerID";
            this.buttonSearchByTruckByTruckerID.Size = new System.Drawing.Size(57, 23);
            this.buttonSearchByTruckByTruckerID.TabIndex = 82;
            this.buttonSearchByTruckByTruckerID.Text = "Buscar";
            this.buttonSearchByTruckByTruckerID.UseVisualStyleBackColor = true;
            this.buttonSearchByTruckByTruckerID.Click += new System.EventHandler(this.buttonSearchByTruckByTruckerID_Click);
            // 
            // labelIDTrucker
            // 
            this.labelIDTrucker.AutoSize = true;
            this.labelIDTrucker.Location = new System.Drawing.Point(9, 282);
            this.labelIDTrucker.Name = "labelIDTrucker";
            this.labelIDTrucker.Size = new System.Drawing.Size(71, 13);
            this.labelIDTrucker.TabIndex = 81;
            this.labelIDTrucker.Text = "ID Camionero";
            // 
            // txtBoxIDTrucker
            // 
            this.txtBoxIDTrucker.Location = new System.Drawing.Point(12, 307);
            this.txtBoxIDTrucker.Name = "txtBoxIDTrucker";
            this.txtBoxIDTrucker.Size = new System.Drawing.Size(57, 20);
            this.txtBoxIDTrucker.TabIndex = 80;
            // 
            // dataGridViewTruckerAndTruckers
            // 
            this.dataGridViewTruckerAndTruckers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewTruckerAndTruckers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTruckerAndTruckers.Location = new System.Drawing.Point(12, 54);
            this.dataGridViewTruckerAndTruckers.Name = "dataGridViewTruckerAndTruckers";
            this.dataGridViewTruckerAndTruckers.Size = new System.Drawing.Size(265, 216);
            this.dataGridViewTruckerAndTruckers.TabIndex = 79;
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMainMenu.ForeColor = System.Drawing.Color.Olive;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(12, 9);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(113, 23);
            this.buttonBackToMainMenu.TabIndex = 78;
            this.buttonBackToMainMenu.Text = "Volver";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // TruckerDriveTruckManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(696, 385);
            this.Controls.Add(this.buttonSearchByTruckByTruckerID);
            this.Controls.Add(this.labelIDTrucker);
            this.Controls.Add(this.txtBoxIDTrucker);
            this.Controls.Add(this.dataGridViewTruckerAndTruckers);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TruckerDriveTruckManagerForm";
            this.Text = "TruckerDriveTruckManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTruckerAndTruckers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSearchByTruckByTruckerID;
        private System.Windows.Forms.Label labelIDTrucker;
        private System.Windows.Forms.TextBox txtBoxIDTrucker;
        private System.Windows.Forms.DataGridView dataGridViewTruckerAndTruckers;
        private System.Windows.Forms.Button buttonBackToMainMenu;
    }
}