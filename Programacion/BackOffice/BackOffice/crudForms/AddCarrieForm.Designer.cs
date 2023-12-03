namespace BackOffice.crudForms
{
    partial class AddCarrieForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.labelIDTruck2 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelIDestination = new System.Windows.Forms.Label();
            this.txtBoxIDDestinationCarrie = new System.Windows.Forms.TextBox();
            this.labelIDLot2 = new System.Windows.Forms.Label();
            this.txtBoxIDBatchCarrie = new System.Windows.Forms.TextBox();
            this.txtBoxIDTruckCarrie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(92, 327);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 135;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(11, 327);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 134;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonClose.Location = new System.Drawing.Point(247, 13);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(22, 20);
            this.buttonClose.TabIndex = 133;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.Location = new System.Drawing.Point(0, 3);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(241, 30);
            this.panelSlide.TabIndex = 132;
            this.panelSlide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseDown);
            this.panelSlide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseMove);
            this.panelSlide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseUp);
            // 
            // labelIDTruck2
            // 
            this.labelIDTruck2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIDTruck2.AutoSize = true;
            this.labelIDTruck2.Location = new System.Drawing.Point(12, 72);
            this.labelIDTruck2.Name = "labelIDTruck2";
            this.labelIDTruck2.Size = new System.Drawing.Size(56, 13);
            this.labelIDTruck2.TabIndex = 142;
            this.labelIDTruck2.Text = "ID Camion";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(15, 216);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 141;
            // 
            // labelIDestination
            // 
            this.labelIDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIDestination.AutoSize = true;
            this.labelIDestination.Location = new System.Drawing.Point(16, 161);
            this.labelIDestination.Name = "labelIDestination";
            this.labelIDestination.Size = new System.Drawing.Size(57, 13);
            this.labelIDestination.TabIndex = 140;
            this.labelIDestination.Text = "ID Destino";
            // 
            // txtBoxIDDestinationCarrie
            // 
            this.txtBoxIDDestinationCarrie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxIDDestinationCarrie.Location = new System.Drawing.Point(17, 177);
            this.txtBoxIDDestinationCarrie.Name = "txtBoxIDDestinationCarrie";
            this.txtBoxIDDestinationCarrie.Size = new System.Drawing.Size(41, 20);
            this.txtBoxIDDestinationCarrie.TabIndex = 139;
            // 
            // labelIDLot2
            // 
            this.labelIDLot2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIDLot2.AutoSize = true;
            this.labelIDLot2.Location = new System.Drawing.Point(14, 117);
            this.labelIDLot2.Name = "labelIDLot2";
            this.labelIDLot2.Size = new System.Drawing.Size(42, 13);
            this.labelIDLot2.TabIndex = 138;
            this.labelIDLot2.Text = "ID Lote";
            // 
            // txtBoxIDBatchCarrie
            // 
            this.txtBoxIDBatchCarrie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxIDBatchCarrie.Location = new System.Drawing.Point(15, 133);
            this.txtBoxIDBatchCarrie.Name = "txtBoxIDBatchCarrie";
            this.txtBoxIDBatchCarrie.Size = new System.Drawing.Size(41, 20);
            this.txtBoxIDBatchCarrie.TabIndex = 137;
            // 
            // txtBoxIDTruckCarrie
            // 
            this.txtBoxIDTruckCarrie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxIDTruckCarrie.Location = new System.Drawing.Point(15, 88);
            this.txtBoxIDTruckCarrie.Name = "txtBoxIDTruckCarrie";
            this.txtBoxIDTruckCarrie.Size = new System.Drawing.Size(41, 20);
            this.txtBoxIDTruckCarrie.TabIndex = 136;
            // 
            // AddCarrieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(287, 361);
            this.Controls.Add(this.labelIDTruck2);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelIDestination);
            this.Controls.Add(this.txtBoxIDDestinationCarrie);
            this.Controls.Add(this.labelIDLot2);
            this.Controls.Add(this.txtBoxIDBatchCarrie);
            this.Controls.Add(this.txtBoxIDTruckCarrie);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCarrieForm";
            this.Text = "AddCarrieForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Label labelIDTruck2;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelIDestination;
        private System.Windows.Forms.TextBox txtBoxIDDestinationCarrie;
        private System.Windows.Forms.Label labelIDLot2;
        private System.Windows.Forms.TextBox txtBoxIDBatchCarrie;
        private System.Windows.Forms.TextBox txtBoxIDTruckCarrie;
    }
}