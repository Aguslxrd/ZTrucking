namespace BackOffice.crudForms
{
    partial class AddTravelForm
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePickerShippmentDateTime = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTypeTravel = new System.Windows.Forms.ComboBox();
            this.dateTimePickerShippmentDate = new System.Windows.Forms.DateTimePicker();
            this.labelDateTravel = new System.Windows.Forms.Label();
            this.labelTypeTravel = new System.Windows.Forms.Label();
            this.labelIDDestination = new System.Windows.Forms.Label();
            this.txtBoxIDDestination = new System.Windows.Forms.TextBox();
            this.labelIDStoreHouse = new System.Windows.Forms.Label();
            this.txtBoxIDStoreHouse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.DarkOrange;
            this.buttonClose.Location = new System.Drawing.Point(266, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(22, 20);
            this.buttonClose.TabIndex = 116;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.Location = new System.Drawing.Point(-1, 2);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(261, 30);
            this.panelSlide.TabIndex = 115;
            this.panelSlide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseDown);
            this.panelSlide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseMove);
            this.panelSlide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSlide_MouseUp);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(93, 365);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 114;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 365);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 113;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePickerShippmentDateTime
            // 
            this.dateTimePickerShippmentDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerShippmentDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerShippmentDateTime.Location = new System.Drawing.Point(15, 305);
            this.dateTimePickerShippmentDateTime.Name = "dateTimePickerShippmentDateTime";
            this.dateTimePickerShippmentDateTime.Size = new System.Drawing.Size(210, 20);
            this.dateTimePickerShippmentDateTime.TabIndex = 125;
            // 
            // comboBoxTypeTravel
            // 
            this.comboBoxTypeTravel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTypeTravel.FormattingEnabled = true;
            this.comboBoxTypeTravel.Location = new System.Drawing.Point(15, 219);
            this.comboBoxTypeTravel.Name = "comboBoxTypeTravel";
            this.comboBoxTypeTravel.Size = new System.Drawing.Size(210, 21);
            this.comboBoxTypeTravel.TabIndex = 124;
            // 
            // dateTimePickerShippmentDate
            // 
            this.dateTimePickerShippmentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerShippmentDate.Location = new System.Drawing.Point(15, 279);
            this.dateTimePickerShippmentDate.Name = "dateTimePickerShippmentDate";
            this.dateTimePickerShippmentDate.Size = new System.Drawing.Size(210, 20);
            this.dateTimePickerShippmentDate.TabIndex = 123;
            // 
            // labelDateTravel
            // 
            this.labelDateTravel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDateTravel.AutoSize = true;
            this.labelDateTravel.Location = new System.Drawing.Point(12, 254);
            this.labelDateTravel.Name = "labelDateTravel";
            this.labelDateTravel.Size = new System.Drawing.Size(82, 13);
            this.labelDateTravel.TabIndex = 122;
            this.labelDateTravel.Text = "Fecha Trayecto";
            // 
            // labelTypeTravel
            // 
            this.labelTypeTravel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTypeTravel.AutoSize = true;
            this.labelTypeTravel.Location = new System.Drawing.Point(12, 188);
            this.labelTypeTravel.Name = "labelTypeTravel";
            this.labelTypeTravel.Size = new System.Drawing.Size(73, 13);
            this.labelTypeTravel.TabIndex = 121;
            this.labelTypeTravel.Text = "Tipo Trayecto";
            // 
            // labelIDDestination
            // 
            this.labelIDDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIDDestination.AutoSize = true;
            this.labelIDDestination.Location = new System.Drawing.Point(12, 128);
            this.labelIDDestination.Name = "labelIDDestination";
            this.labelIDDestination.Size = new System.Drawing.Size(57, 13);
            this.labelIDDestination.TabIndex = 120;
            this.labelIDDestination.Text = "ID Destino";
            // 
            // txtBoxIDDestination
            // 
            this.txtBoxIDDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxIDDestination.Location = new System.Drawing.Point(15, 153);
            this.txtBoxIDDestination.Name = "txtBoxIDDestination";
            this.txtBoxIDDestination.Size = new System.Drawing.Size(210, 20);
            this.txtBoxIDDestination.TabIndex = 119;
            // 
            // labelIDStoreHouse
            // 
            this.labelIDStoreHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIDStoreHouse.AutoSize = true;
            this.labelIDStoreHouse.Location = new System.Drawing.Point(12, 61);
            this.labelIDStoreHouse.Name = "labelIDStoreHouse";
            this.labelIDStoreHouse.Size = new System.Drawing.Size(62, 13);
            this.labelIDStoreHouse.TabIndex = 118;
            this.labelIDStoreHouse.Text = "ID Almacen";
            // 
            // txtBoxIDStoreHouse
            // 
            this.txtBoxIDStoreHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxIDStoreHouse.Location = new System.Drawing.Point(15, 86);
            this.txtBoxIDStoreHouse.Name = "txtBoxIDStoreHouse";
            this.txtBoxIDStoreHouse.Size = new System.Drawing.Size(210, 20);
            this.txtBoxIDStoreHouse.TabIndex = 117;
            // 
            // AddTravelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(303, 400);
            this.Controls.Add(this.dateTimePickerShippmentDateTime);
            this.Controls.Add(this.comboBoxTypeTravel);
            this.Controls.Add(this.dateTimePickerShippmentDate);
            this.Controls.Add(this.labelDateTravel);
            this.Controls.Add(this.labelTypeTravel);
            this.Controls.Add(this.labelIDDestination);
            this.Controls.Add(this.txtBoxIDDestination);
            this.Controls.Add(this.labelIDStoreHouse);
            this.Controls.Add(this.txtBoxIDStoreHouse);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTravelForm";
            this.Text = "AddTravelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerShippmentDateTime;
        private System.Windows.Forms.ComboBox comboBoxTypeTravel;
        private System.Windows.Forms.DateTimePicker dateTimePickerShippmentDate;
        private System.Windows.Forms.Label labelDateTravel;
        private System.Windows.Forms.Label labelTypeTravel;
        private System.Windows.Forms.Label labelIDDestination;
        private System.Windows.Forms.TextBox txtBoxIDDestination;
        private System.Windows.Forms.Label labelIDStoreHouse;
        private System.Windows.Forms.TextBox txtBoxIDStoreHouse;
    }
}