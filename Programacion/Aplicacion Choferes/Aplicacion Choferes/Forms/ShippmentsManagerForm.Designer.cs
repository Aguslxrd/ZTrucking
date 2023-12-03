namespace Aplicacion_Choferes.Forms
{
    partial class ShippmentsManagerForm
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
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.dataGridViewShippments = new System.Windows.Forms.DataGridView();
            this.txtBoxIDDestination = new System.Windows.Forms.TextBox();
            this.labelIDDestination = new System.Windows.Forms.Label();
            this.labelStoreHouse = new System.Windows.Forms.Label();
            this.txtBoxStoreHouseID = new System.Windows.Forms.TextBox();
            this.buttonSearchByDestinationID = new System.Windows.Forms.Button();
            this.buttonSearchByStoreHouseID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShippments)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMainMenu.ForeColor = System.Drawing.Color.Olive;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(113, 23);
            this.buttonBackToMainMenu.TabIndex = 57;
            this.buttonBackToMainMenu.Text = "Volver";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // dataGridViewShippments
            // 
            this.dataGridViewShippments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewShippments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShippments.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewShippments.Name = "dataGridViewShippments";
            this.dataGridViewShippments.Size = new System.Drawing.Size(701, 184);
            this.dataGridViewShippments.TabIndex = 58;
            // 
            // txtBoxIDDestination
            // 
            this.txtBoxIDDestination.Location = new System.Drawing.Point(12, 295);
            this.txtBoxIDDestination.Name = "txtBoxIDDestination";
            this.txtBoxIDDestination.Size = new System.Drawing.Size(57, 20);
            this.txtBoxIDDestination.TabIndex = 59;
            // 
            // labelIDDestination
            // 
            this.labelIDDestination.AutoSize = true;
            this.labelIDDestination.Location = new System.Drawing.Point(12, 276);
            this.labelIDDestination.Name = "labelIDDestination";
            this.labelIDDestination.Size = new System.Drawing.Size(57, 13);
            this.labelIDDestination.TabIndex = 60;
            this.labelIDDestination.Text = "ID Destino";
            // 
            // labelStoreHouse
            // 
            this.labelStoreHouse.AutoSize = true;
            this.labelStoreHouse.Location = new System.Drawing.Point(133, 276);
            this.labelStoreHouse.Name = "labelStoreHouse";
            this.labelStoreHouse.Size = new System.Drawing.Size(62, 13);
            this.labelStoreHouse.TabIndex = 62;
            this.labelStoreHouse.Text = "ID Almacen";
            // 
            // txtBoxStoreHouseID
            // 
            this.txtBoxStoreHouseID.Location = new System.Drawing.Point(136, 295);
            this.txtBoxStoreHouseID.Name = "txtBoxStoreHouseID";
            this.txtBoxStoreHouseID.Size = new System.Drawing.Size(50, 20);
            this.txtBoxStoreHouseID.TabIndex = 61;
            // 
            // buttonSearchByDestinationID
            // 
            this.buttonSearchByDestinationID.Location = new System.Drawing.Point(12, 336);
            this.buttonSearchByDestinationID.Name = "buttonSearchByDestinationID";
            this.buttonSearchByDestinationID.Size = new System.Drawing.Size(57, 23);
            this.buttonSearchByDestinationID.TabIndex = 63;
            this.buttonSearchByDestinationID.Text = "Buscar por destino";
            this.buttonSearchByDestinationID.UseVisualStyleBackColor = true;
            this.buttonSearchByDestinationID.Click += new System.EventHandler(this.buttonSearchByDestinationID_Click);
            // 
            // buttonSearchByStoreHouseID
            // 
            this.buttonSearchByStoreHouseID.Location = new System.Drawing.Point(136, 336);
            this.buttonSearchByStoreHouseID.Name = "buttonSearchByStoreHouseID";
            this.buttonSearchByStoreHouseID.Size = new System.Drawing.Size(50, 23);
            this.buttonSearchByStoreHouseID.TabIndex = 64;
            this.buttonSearchByStoreHouseID.Text = "Buscar por almacen";
            this.buttonSearchByStoreHouseID.UseVisualStyleBackColor = true;
            this.buttonSearchByStoreHouseID.Click += new System.EventHandler(this.buttonSearchByStoreHouseID_Click);
            // 
            // ShippmentsManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(725, 442);
            this.Controls.Add(this.buttonSearchByStoreHouseID);
            this.Controls.Add(this.buttonSearchByDestinationID);
            this.Controls.Add(this.labelStoreHouse);
            this.Controls.Add(this.txtBoxStoreHouseID);
            this.Controls.Add(this.labelIDDestination);
            this.Controls.Add(this.txtBoxIDDestination);
            this.Controls.Add(this.dataGridViewShippments);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShippmentsManagerForm";
            this.Text = "ShippmentsManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShippments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.DataGridView dataGridViewShippments;
        private System.Windows.Forms.TextBox txtBoxIDDestination;
        private System.Windows.Forms.Label labelIDDestination;
        private System.Windows.Forms.Label labelStoreHouse;
        private System.Windows.Forms.TextBox txtBoxStoreHouseID;
        private System.Windows.Forms.Button buttonSearchByDestinationID;
        private System.Windows.Forms.Button buttonSearchByStoreHouseID;
    }
}