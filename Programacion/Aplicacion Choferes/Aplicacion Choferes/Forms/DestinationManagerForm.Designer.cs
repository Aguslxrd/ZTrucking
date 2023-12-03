namespace Aplicacion_Choferes.Forms
{
    partial class DestinationManagerForm
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
            this.buttonSearchByDestinationID = new System.Windows.Forms.Button();
            this.labelIDDestination = new System.Windows.Forms.Label();
            this.txtBoxIDDestination = new System.Windows.Forms.TextBox();
            this.dataGridViewDestination = new System.Windows.Forms.DataGridView();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.buttonGetAllDestinations = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestination)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearchByDestinationID
            // 
            this.buttonSearchByDestinationID.Location = new System.Drawing.Point(12, 331);
            this.buttonSearchByDestinationID.Name = "buttonSearchByDestinationID";
            this.buttonSearchByDestinationID.Size = new System.Drawing.Size(57, 23);
            this.buttonSearchByDestinationID.TabIndex = 76;
            this.buttonSearchByDestinationID.Text = "Buscar";
            this.buttonSearchByDestinationID.UseVisualStyleBackColor = true;
            this.buttonSearchByDestinationID.Click += new System.EventHandler(this.buttonSearchByDestinationID_Click);
            // 
            // labelIDDestination
            // 
            this.labelIDDestination.AutoSize = true;
            this.labelIDDestination.Location = new System.Drawing.Point(12, 271);
            this.labelIDDestination.Name = "labelIDDestination";
            this.labelIDDestination.Size = new System.Drawing.Size(57, 13);
            this.labelIDDestination.TabIndex = 75;
            this.labelIDDestination.Text = "ID Destino";
            // 
            // txtBoxIDDestination
            // 
            this.txtBoxIDDestination.Location = new System.Drawing.Point(12, 290);
            this.txtBoxIDDestination.Name = "txtBoxIDDestination";
            this.txtBoxIDDestination.Size = new System.Drawing.Size(57, 20);
            this.txtBoxIDDestination.TabIndex = 74;
            // 
            // dataGridViewDestination
            // 
            this.dataGridViewDestination.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDestination.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewDestination.Name = "dataGridViewDestination";
            this.dataGridViewDestination.Size = new System.Drawing.Size(386, 184);
            this.dataGridViewDestination.TabIndex = 73;
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMainMenu.ForeColor = System.Drawing.Color.Olive;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(12, 7);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(113, 23);
            this.buttonBackToMainMenu.TabIndex = 72;
            this.buttonBackToMainMenu.Text = "Volver";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // buttonGetAllDestinations
            // 
            this.buttonGetAllDestinations.Location = new System.Drawing.Point(75, 331);
            this.buttonGetAllDestinations.Name = "buttonGetAllDestinations";
            this.buttonGetAllDestinations.Size = new System.Drawing.Size(80, 23);
            this.buttonGetAllDestinations.TabIndex = 77;
            this.buttonGetAllDestinations.Text = "Ver destinos";
            this.buttonGetAllDestinations.UseVisualStyleBackColor = true;
            this.buttonGetAllDestinations.Click += new System.EventHandler(this.buttonGetAllDestinations_Click);
            // 
            // DestinationManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(693, 364);
            this.Controls.Add(this.buttonGetAllDestinations);
            this.Controls.Add(this.buttonSearchByDestinationID);
            this.Controls.Add(this.labelIDDestination);
            this.Controls.Add(this.txtBoxIDDestination);
            this.Controls.Add(this.dataGridViewDestination);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DestinationManagerForm";
            this.Text = "DestinationManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearchByDestinationID;
        private System.Windows.Forms.Label labelIDDestination;
        private System.Windows.Forms.TextBox txtBoxIDDestination;
        private System.Windows.Forms.DataGridView dataGridViewDestination;
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Button buttonGetAllDestinations;
    }
}