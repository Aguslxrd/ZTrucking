namespace BackOffice.crudForms
{
    partial class EditCarrieForm
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
            this.labelIDTruck2 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelIDestination = new System.Windows.Forms.Label();
            this.txtBoxIDDestinationCarrie = new System.Windows.Forms.TextBox();
            this.labelIDLot2 = new System.Windows.Forms.Label();
            this.txtBoxIDBatchCarrie = new System.Windows.Forms.TextBox();
            this.txtBoxIDTruckCarrie = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelIDTruck2
            // 
            this.labelIDTruck2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIDTruck2.AutoSize = true;
            this.labelIDTruck2.Location = new System.Drawing.Point(13, 77);
            this.labelIDTruck2.Name = "labelIDTruck2";
            this.labelIDTruck2.Size = new System.Drawing.Size(56, 13);
            this.labelIDTruck2.TabIndex = 151;
            this.labelIDTruck2.Text = "ID Camion";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(16, 221);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 150;
            // 
            // labelIDestination
            // 
            this.labelIDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIDestination.AutoSize = true;
            this.labelIDestination.Location = new System.Drawing.Point(17, 166);
            this.labelIDestination.Name = "labelIDestination";
            this.labelIDestination.Size = new System.Drawing.Size(57, 13);
            this.labelIDestination.TabIndex = 149;
            this.labelIDestination.Text = "ID Destino";
            // 
            // txtBoxIDDestinationCarrie
            // 
            this.txtBoxIDDestinationCarrie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxIDDestinationCarrie.Location = new System.Drawing.Point(18, 182);
            this.txtBoxIDDestinationCarrie.Name = "txtBoxIDDestinationCarrie";
            this.txtBoxIDDestinationCarrie.Size = new System.Drawing.Size(41, 20);
            this.txtBoxIDDestinationCarrie.TabIndex = 148;
            // 
            // labelIDLot2
            // 
            this.labelIDLot2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIDLot2.AutoSize = true;
            this.labelIDLot2.Location = new System.Drawing.Point(15, 122);
            this.labelIDLot2.Name = "labelIDLot2";
            this.labelIDLot2.Size = new System.Drawing.Size(42, 13);
            this.labelIDLot2.TabIndex = 147;
            this.labelIDLot2.Text = "ID Lote";
            // 
            // txtBoxIDBatchCarrie
            // 
            this.txtBoxIDBatchCarrie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxIDBatchCarrie.Location = new System.Drawing.Point(16, 138);
            this.txtBoxIDBatchCarrie.Name = "txtBoxIDBatchCarrie";
            this.txtBoxIDBatchCarrie.Size = new System.Drawing.Size(41, 20);
            this.txtBoxIDBatchCarrie.TabIndex = 146;
            // 
            // txtBoxIDTruckCarrie
            // 
            this.txtBoxIDTruckCarrie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxIDTruckCarrie.Location = new System.Drawing.Point(16, 93);
            this.txtBoxIDTruckCarrie.Name = "txtBoxIDTruckCarrie";
            this.txtBoxIDTruckCarrie.Size = new System.Drawing.Size(41, 20);
            this.txtBoxIDTruckCarrie.TabIndex = 145;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(92, 285);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 144;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(11, 285);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 143;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonClose.Location = new System.Drawing.Point(238, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(22, 20);
            this.buttonClose.TabIndex = 153;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.Location = new System.Drawing.Point(2, 2);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(230, 30);
            this.panelSlide.TabIndex = 152;
            this.panelSlide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseDown);
            this.panelSlide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseMove);
            this.panelSlide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseUp);
            // 
            // EditCarrieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(275, 322);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.labelIDTruck2);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelIDestination);
            this.Controls.Add(this.txtBoxIDDestinationCarrie);
            this.Controls.Add(this.labelIDLot2);
            this.Controls.Add(this.txtBoxIDBatchCarrie);
            this.Controls.Add(this.txtBoxIDTruckCarrie);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCarrieForm";
            this.Text = "EditCarrieForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIDTruck2;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelIDestination;
        private System.Windows.Forms.TextBox txtBoxIDDestinationCarrie;
        private System.Windows.Forms.Label labelIDLot2;
        private System.Windows.Forms.TextBox txtBoxIDBatchCarrie;
        private System.Windows.Forms.TextBox txtBoxIDTruckCarrie;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelSlide;
    }
}