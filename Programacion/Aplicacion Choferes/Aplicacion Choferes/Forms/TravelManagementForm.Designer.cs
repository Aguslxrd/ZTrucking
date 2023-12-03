namespace Aplicacion_Choferes.Forms
{
    partial class TravelManagementForm
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
            this.txtBoxDestination = new System.Windows.Forms.TextBox();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelIDLotToAssign = new System.Windows.Forms.Label();
            this.txtBoxIDBatch = new System.Windows.Forms.TextBox();
            this.labelIDTruck = new System.Windows.Forms.Label();
            this.txtBoxIDTruck = new System.Windows.Forms.TextBox();
            this.dataGridViewTravels = new System.Windows.Forms.DataGridView();
            this.labelIDDestination = new System.Windows.Forms.Label();
            this.comboBoxStatusShipp = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonChangeStatus = new System.Windows.Forms.Button();
            this.txtBoxTruckerID = new System.Windows.Forms.TextBox();
            this.labelIDTrucker = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTravels)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxDestination
            // 
            this.txtBoxDestination.Location = new System.Drawing.Point(333, 205);
            this.txtBoxDestination.Name = "txtBoxDestination";
            this.txtBoxDestination.Size = new System.Drawing.Size(61, 20);
            this.txtBoxDestination.TabIndex = 57;
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMainMenu.ForeColor = System.Drawing.Color.Olive;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(113, 23);
            this.buttonBackToMainMenu.TabIndex = 56;
            this.buttonBackToMainMenu.Text = "Volver";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(333, 304);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(68, 26);
            this.buttonDelete.TabIndex = 54;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // labelIDLotToAssign
            // 
            this.labelIDLotToAssign.AutoSize = true;
            this.labelIDLotToAssign.Location = new System.Drawing.Point(330, 133);
            this.labelIDLotToAssign.Name = "labelIDLotToAssign";
            this.labelIDLotToAssign.Size = new System.Drawing.Size(38, 13);
            this.labelIDLotToAssign.TabIndex = 52;
            this.labelIDLotToAssign.Text = "ID lote";
            // 
            // txtBoxIDBatch
            // 
            this.txtBoxIDBatch.Location = new System.Drawing.Point(333, 158);
            this.txtBoxIDBatch.Name = "txtBoxIDBatch";
            this.txtBoxIDBatch.Size = new System.Drawing.Size(61, 20);
            this.txtBoxIDBatch.TabIndex = 51;
            // 
            // labelIDTruck
            // 
            this.labelIDTruck.AutoSize = true;
            this.labelIDTruck.Location = new System.Drawing.Point(330, 61);
            this.labelIDTruck.Name = "labelIDTruck";
            this.labelIDTruck.Size = new System.Drawing.Size(56, 13);
            this.labelIDTruck.TabIndex = 50;
            this.labelIDTruck.Text = "ID Camion";
            // 
            // txtBoxIDTruck
            // 
            this.txtBoxIDTruck.Location = new System.Drawing.Point(333, 91);
            this.txtBoxIDTruck.Name = "txtBoxIDTruck";
            this.txtBoxIDTruck.Size = new System.Drawing.Size(61, 20);
            this.txtBoxIDTruck.TabIndex = 49;
            // 
            // dataGridViewTravels
            // 
            this.dataGridViewTravels.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewTravels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTravels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTravels.Location = new System.Drawing.Point(12, 59);
            this.dataGridViewTravels.Name = "dataGridViewTravels";
            this.dataGridViewTravels.Size = new System.Drawing.Size(312, 410);
            this.dataGridViewTravels.TabIndex = 48;
            // 
            // labelIDDestination
            // 
            this.labelIDDestination.AutoSize = true;
            this.labelIDDestination.Location = new System.Drawing.Point(330, 189);
            this.labelIDDestination.Name = "labelIDDestination";
            this.labelIDDestination.Size = new System.Drawing.Size(57, 13);
            this.labelIDDestination.TabIndex = 58;
            this.labelIDDestination.Text = "ID Destino";
            // 
            // comboBoxStatusShipp
            // 
            this.comboBoxStatusShipp.FormattingEnabled = true;
            this.comboBoxStatusShipp.Location = new System.Drawing.Point(333, 264);
            this.comboBoxStatusShipp.Name = "comboBoxStatusShipp";
            this.comboBoxStatusShipp.Size = new System.Drawing.Size(98, 21);
            this.comboBoxStatusShipp.TabIndex = 59;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(330, 248);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(86, 13);
            this.labelStatus.TabIndex = 60;
            this.labelStatus.Text = "Estado del envio";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(412, 304);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(68, 26);
            this.buttonSearch.TabIndex = 61;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonChangeStatus
            // 
            this.buttonChangeStatus.Location = new System.Drawing.Point(333, 336);
            this.buttonChangeStatus.Name = "buttonChangeStatus";
            this.buttonChangeStatus.Size = new System.Drawing.Size(147, 26);
            this.buttonChangeStatus.TabIndex = 62;
            this.buttonChangeStatus.Text = "Cambiar estado";
            this.buttonChangeStatus.UseVisualStyleBackColor = true;
            this.buttonChangeStatus.Click += new System.EventHandler(this.buttonChangeStatus_Click);
            // 
            // txtBoxTruckerID
            // 
            this.txtBoxTruckerID.Location = new System.Drawing.Point(412, 91);
            this.txtBoxTruckerID.Name = "txtBoxTruckerID";
            this.txtBoxTruckerID.Size = new System.Drawing.Size(49, 20);
            this.txtBoxTruckerID.TabIndex = 63;
            // 
            // labelIDTrucker
            // 
            this.labelIDTrucker.AutoSize = true;
            this.labelIDTrucker.Location = new System.Drawing.Point(409, 61);
            this.labelIDTrucker.Name = "labelIDTrucker";
            this.labelIDTrucker.Size = new System.Drawing.Size(52, 13);
            this.labelIDTrucker.TabIndex = 64;
            this.labelIDTrucker.Text = "ID Chofer";
            // 
            // TravelManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(741, 481);
            this.Controls.Add(this.labelIDTrucker);
            this.Controls.Add(this.txtBoxTruckerID);
            this.Controls.Add(this.buttonChangeStatus);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBoxStatusShipp);
            this.Controls.Add(this.labelIDDestination);
            this.Controls.Add(this.txtBoxDestination);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelIDLotToAssign);
            this.Controls.Add(this.txtBoxIDBatch);
            this.Controls.Add(this.labelIDTruck);
            this.Controls.Add(this.txtBoxIDTruck);
            this.Controls.Add(this.dataGridViewTravels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TravelManagementForm";
            this.Text = "TravelManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTravels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxDestination;
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelIDLotToAssign;
        private System.Windows.Forms.TextBox txtBoxIDBatch;
        private System.Windows.Forms.Label labelIDTruck;
        private System.Windows.Forms.TextBox txtBoxIDTruck;
        private System.Windows.Forms.DataGridView dataGridViewTravels;
        private System.Windows.Forms.Label labelIDDestination;
        private System.Windows.Forms.ComboBox comboBoxStatusShipp;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonChangeStatus;
        private System.Windows.Forms.TextBox txtBoxTruckerID;
        private System.Windows.Forms.Label labelIDTrucker;
    }
}