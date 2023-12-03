namespace Aplicacion_Choferes.Forms
{
    partial class TruckerCarryForm
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
            this.buttonSearchByTruckerID = new System.Windows.Forms.Button();
            this.labelIDTrucker = new System.Windows.Forms.Label();
            this.txtBoxIDTrucker = new System.Windows.Forms.TextBox();
            this.dataGridViewShippments = new System.Windows.Forms.DataGridView();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShippments)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearchByTruckerID
            // 
            this.buttonSearchByTruckerID.Location = new System.Drawing.Point(12, 338);
            this.buttonSearchByTruckerID.Name = "buttonSearchByTruckerID";
            this.buttonSearchByTruckerID.Size = new System.Drawing.Size(113, 23);
            this.buttonSearchByTruckerID.TabIndex = 71;
            this.buttonSearchByTruckerID.Text = "Buscar";
            this.buttonSearchByTruckerID.UseVisualStyleBackColor = true;
            this.buttonSearchByTruckerID.Click += new System.EventHandler(this.buttonSearchByTruckerID_Click);
            // 
            // labelIDTrucker
            // 
            this.labelIDTrucker.AutoSize = true;
            this.labelIDTrucker.Location = new System.Drawing.Point(12, 278);
            this.labelIDTrucker.Name = "labelIDTrucker";
            this.labelIDTrucker.Size = new System.Drawing.Size(56, 13);
            this.labelIDTrucker.TabIndex = 68;
            this.labelIDTrucker.Text = "ID Camion";
            // 
            // txtBoxIDTrucker
            // 
            this.txtBoxIDTrucker.Location = new System.Drawing.Point(12, 297);
            this.txtBoxIDTrucker.Name = "txtBoxIDTrucker";
            this.txtBoxIDTrucker.Size = new System.Drawing.Size(113, 20);
            this.txtBoxIDTrucker.TabIndex = 67;
            // 
            // dataGridViewShippments
            // 
            this.dataGridViewShippments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewShippments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShippments.Location = new System.Drawing.Point(12, 59);
            this.dataGridViewShippments.Name = "dataGridViewShippments";
            this.dataGridViewShippments.Size = new System.Drawing.Size(386, 184);
            this.dataGridViewShippments.TabIndex = 66;
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMainMenu.ForeColor = System.Drawing.Color.Olive;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(12, 14);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(113, 23);
            this.buttonBackToMainMenu.TabIndex = 65;
            this.buttonBackToMainMenu.Text = "Volver";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // TruckerCarryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(709, 403);
            this.Controls.Add(this.buttonSearchByTruckerID);
            this.Controls.Add(this.labelIDTrucker);
            this.Controls.Add(this.txtBoxIDTrucker);
            this.Controls.Add(this.dataGridViewShippments);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TruckerCarryForm";
            this.Text = "TruckerCarryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShippments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSearchByTruckerID;
        private System.Windows.Forms.Label labelIDTrucker;
        private System.Windows.Forms.TextBox txtBoxIDTrucker;
        private System.Windows.Forms.DataGridView dataGridViewShippments;
        private System.Windows.Forms.Button buttonBackToMainMenu;
    }
}