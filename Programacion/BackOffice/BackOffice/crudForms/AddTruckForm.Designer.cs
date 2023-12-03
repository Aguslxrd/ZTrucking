namespace BackOffice.crudForms
{
    partial class AddTruckForm
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
            this.labelTruckVolume = new System.Windows.Forms.Label();
            this.txtBoxVolumeTruck = new System.Windows.Forms.TextBox();
            this.labelTruckWeight = new System.Windows.Forms.Label();
            this.txtBoxWeightTruck = new System.Windows.Forms.TextBox();
            this.labelActivated = new System.Windows.Forms.Label();
            this.comboBoxActivated = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(93, 328);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 143;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 328);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 142;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonClose.Location = new System.Drawing.Point(240, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(22, 20);
            this.buttonClose.TabIndex = 141;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.Location = new System.Drawing.Point(1, 2);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(233, 41);
            this.panelSlide.TabIndex = 140;
            this.panelSlide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseDown);
            this.panelSlide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseMove);
            this.panelSlide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseUp);
            // 
            // labelTruckVolume
            // 
            this.labelTruckVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTruckVolume.AutoSize = true;
            this.labelTruckVolume.Location = new System.Drawing.Point(9, 154);
            this.labelTruckVolume.Name = "labelTruckVolume";
            this.labelTruckVolume.Size = new System.Drawing.Size(103, 13);
            this.labelTruckVolume.TabIndex = 147;
            this.labelTruckVolume.Text = "Volumen de camion:";
            // 
            // txtBoxVolumeTruck
            // 
            this.txtBoxVolumeTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxVolumeTruck.Location = new System.Drawing.Point(12, 180);
            this.txtBoxVolumeTruck.Name = "txtBoxVolumeTruck";
            this.txtBoxVolumeTruck.Size = new System.Drawing.Size(61, 20);
            this.txtBoxVolumeTruck.TabIndex = 146;
            this.txtBoxVolumeTruck.TextChanged += new System.EventHandler(this.txtBoxVolumeTruck_TextChanged);
            // 
            // labelTruckWeight
            // 
            this.labelTruckWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTruckWeight.AutoSize = true;
            this.labelTruckWeight.Location = new System.Drawing.Point(9, 95);
            this.labelTruckWeight.Name = "labelTruckWeight";
            this.labelTruckWeight.Size = new System.Drawing.Size(86, 13);
            this.labelTruckWeight.TabIndex = 145;
            this.labelTruckWeight.Text = "Peso de camion:";
            this.labelTruckWeight.Click += new System.EventHandler(this.labelTruckWeight_Click);
            // 
            // txtBoxWeightTruck
            // 
            this.txtBoxWeightTruck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxWeightTruck.Location = new System.Drawing.Point(12, 121);
            this.txtBoxWeightTruck.Name = "txtBoxWeightTruck";
            this.txtBoxWeightTruck.Size = new System.Drawing.Size(61, 20);
            this.txtBoxWeightTruck.TabIndex = 144;
            this.txtBoxWeightTruck.TextChanged += new System.EventHandler(this.txtBoxWeightTruck_TextChanged);
            // 
            // labelActivated
            // 
            this.labelActivated.AutoSize = true;
            this.labelActivated.BackColor = System.Drawing.Color.Transparent;
            this.labelActivated.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelActivated.Location = new System.Drawing.Point(9, 203);
            this.labelActivated.Name = "labelActivated";
            this.labelActivated.Size = new System.Drawing.Size(62, 17);
            this.labelActivated.TabIndex = 151;
            this.labelActivated.Text = "Activado";
            // 
            // comboBoxActivated
            // 
            this.comboBoxActivated.FormattingEnabled = true;
            this.comboBoxActivated.Location = new System.Drawing.Point(12, 223);
            this.comboBoxActivated.Name = "comboBoxActivated";
            this.comboBoxActivated.Size = new System.Drawing.Size(59, 21);
            this.comboBoxActivated.TabIndex = 150;
            // 
            // AddTruckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(276, 363);
            this.Controls.Add(this.labelActivated);
            this.Controls.Add(this.comboBoxActivated);
            this.Controls.Add(this.labelTruckVolume);
            this.Controls.Add(this.txtBoxVolumeTruck);
            this.Controls.Add(this.labelTruckWeight);
            this.Controls.Add(this.txtBoxWeightTruck);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTruckForm";
            this.Text = "AddTruckForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Label labelTruckVolume;
        private System.Windows.Forms.TextBox txtBoxVolumeTruck;
        private System.Windows.Forms.Label labelTruckWeight;
        private System.Windows.Forms.TextBox txtBoxWeightTruck;
        private System.Windows.Forms.Label labelActivated;
        private System.Windows.Forms.ComboBox comboBoxActivated;
    }
}